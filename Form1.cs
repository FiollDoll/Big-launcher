using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Buttons;
namespace SuperLauncher
{
    public partial class MainForm : Form
    {
        public ButtonsInScene buttonsInScene = new ButtonsInScene();
        public string totalAction;
        public string command;

        public MainForm()
        {
            InitializeComponent();
            panelChoice.Visible = false;
            panelCreate.Visible = false;
            panelActivate.Visible = false;
            buttonPath.Visible = false;
            buttonsInScene.buttons = new List<ButtonInfo>();

            // Десериализация

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ButtonsInScene));

            if (File.Exists("buttons.xml"))
            {
                // десериализуем объект
                using (FileStream fs = new FileStream("buttons.xml", FileMode.OpenOrCreate))
                {
                    buttonsInScene = xmlSerializer.Deserialize(fs) as ButtonsInScene;
                }

                for (int i = 0; i < buttonsInScene.buttons.Count; i++)
                {
                    Button button = new Button();
                    groupButtons.Controls.Add(button);
                    button.Name = buttonsInScene.buttons[i].name;
                    button.Text = buttonsInScene.buttons[i].name;
                    button.Location = new Point(buttonsInScene.buttons[i].position.x, buttonsInScene.buttons[i].position.y);

                    button.Click += ButtonOnClick;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e) => panelChoice.Visible = true;


        private void buttonExit_Click(object sender, EventArgs e) => panelChoice.Visible = false;


        // CMD
        private void buttonCmd_Click(object sender, EventArgs e)
        {
            panelChoice.Visible = false;
            panelCreate.Visible = true;
            labelNameCommand.Text = "Команда*";

            command = "cmd";
        }
        private void buttonPowerShell_Click(object sender, EventArgs e)
        {
            panelChoice.Visible = false;
            panelCreate.Visible = true;
            labelNameCommand.Text = "Команда*";
            command = "powerShell";
        }
        private void buttonApp_Click(object sender, EventArgs e)
        {
            panelChoice.Visible = false;
            panelCreate.Visible = true;
            labelNameCommand.Text = "Путь*";
            buttonPath.Visible = true;

        }
        private void buttonPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Открываем окно диалога с пользователем.
            openFileDialog.ShowDialog();
            var extension = Path.GetExtension(openFileDialog.FileName);
            command = "app";
            textBoxCommand.Text = openFileDialog.FileName;
        }

        private void CreateButton(string action, string command)
        {
            if (action != "")
            {
                panelCreate.Visible = false;
                Button button = new Button();
                groupButtons.Controls.Add(button);
                if (textBoxNameCommand.Text == "")
                    textBoxNameCommand.Text = action;
                button.Name = textBoxNameCommand.Text;
                button.Text = textBoxNameCommand.Text;
                if (buttonsInScene.buttons.Count == 0)
                    buttonsInScene.buttons.Add(new ButtonInfo(button.Name, command, textBoxNameCommand.Text, action, new ButtonLocation(10, 20), checkBoxOption.Checked, checkBoxOtherOption.Checked));
                else
                {
                    if (buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.x >= 250) // Новая строка
                        buttonsInScene.buttons.Add(new ButtonInfo(button.Name, command, textBoxNameCommand.Text, action, new ButtonLocation(10, buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.y + 50), checkBoxOption.Checked, checkBoxOtherOption.Checked));
                    else
                        buttonsInScene.buttons.Add(new ButtonInfo(button.Name, command, textBoxNameCommand.Text, action, new ButtonLocation(buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.x + 80, buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.y), checkBoxOption.Checked, checkBoxOtherOption.Checked));
                }

                button.Location = new Point(buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.x, buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.y);

                button.Click += ButtonOnClick;

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ButtonsInScene));

                using (FileStream fs = new FileStream(@"buttons.xml", FileMode.OpenOrCreate))
                    xmlSerializer.Serialize(fs, buttonsInScene);

                textBoxNameCommand.Text = "";
                checkBoxOption.Checked = false;
                checkBoxOtherOption.Visible = false;
                checkBoxOtherOption.Checked = false;
                action = "";
                textBoxCommand.Text = "";

            }
            else
                MessageBox.Show("Не вписана команда!");

            buttonPath.Visible = false;
        }

        public void DeleteAllButtons()
        {
            for (int i = 0; i < buttonsInScene.buttons.Count; i++)
            {
                groupButtons.Controls.Remove(groupButtons.Controls.Find(buttonsInScene.buttons[i].name, false)[0]);
                buttonsInScene.buttons.RemoveAt(i);
            }
        }

        private void ButtonOnClick(object sender, EventArgs e)
        {
            totalAction = (sender as Button).Text;
            bool app = false;

            for (int i = 0; i < buttonsInScene.buttons.Count; i++)
            {
                if (totalAction == buttonsInScene.buttons[i].name)
                {
                    if (buttonsInScene.buttons[i].command == "app")
                    {
                        app = true;
                        Process.Start(buttonsInScene.buttons[i].action);
                        break;
                    }
                }
            }
            for (int i = 0; i < buttonsInScene.buttons.Count; i++)
            {
                if (totalAction == buttonsInScene.buttons[i].name)
                {
                    if (!app)
                    {
                        panelActivate.Visible = true;
                        textBoxInfo.Visible = buttonsInScene.buttons[i].optionHave;
                        labelOption.Visible = buttonsInScene.buttons[i].optionHave;
                        textBoxOtherInfo.Visible = buttonsInScene.buttons[i].otherOptionHave;
                        labelOtherOption.Visible = buttonsInScene.buttons[i].otherOptionHave;
                        break;
                    }
                }
            }

            Console.WriteLine(totalAction);
        }

        private void buttonCreate_Click(object sender, EventArgs e) => CreateButton(textBoxCommand.Text, command);



        private void buttonSubExit_Click(object sender, EventArgs e) => panelCreate.Visible = false;


        private void buttonActivate_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi;
            for (int i = 0; i < buttonsInScene.buttons.Count; i++)
            {
                if (totalAction == buttonsInScene.buttons[i].name)
                {
                    if (buttonsInScene.buttons[i].command == "app")
                        break;
                    else if (buttonsInScene.buttons[i].command == "cmd")
                    {
                        psi = new ProcessStartInfo("cmd", $@"/k {buttonsInScene.buttons[i].action} {textBoxInfo.Text}");
                        Process.Start(psi);
                        break;
                    }
                    else if (buttonsInScene.buttons[i].command == "powerShell")
                    {
                        psi = new ProcessStartInfo("PowerShell", $@"{buttonsInScene.buttons[i].action} {textBoxInfo.Text}");
                        Process.Start(psi);
                        break;
                    }
                }
            }
            panelActivate.Visible = false;
        }

        private void buttonActivateMenuExit_Click(object sender, EventArgs e) => panelActivate.Visible = false;

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteAllButtons();
            DeleteAllButtons();
            DeleteAllButtons();
        }

        private void checkBoxOption_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxOtherOption.Visible = checkBoxOption.Checked;
        }
    }
}
