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
                    button.Name = $"buttonAction{buttonsInScene.buttons[i].action}";
                    button.Text = buttonsInScene.buttons[i].action;
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
            command = "cmd";
        }
        private void buttonPowerShell_Click(object sender, EventArgs e)
        {
            panelChoice.Visible = false;
            panelCreate.Visible = true;
            command = "powerShell";
        }
        private void buttonApp_Click(object sender, EventArgs e)
        {
            panelChoice.Visible = false;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Открываем окно диалога с пользователем.
            openFileDialog.ShowDialog();
            var extension = Path.GetExtension(openFileDialog.FileName);
            command = "app";
            CreateButton(openFileDialog.FileName, command);
        }

        private void CreateButton(string action, string command)
        {
            if (action != "")
            {
                panelCreate.Visible = false;
                Button button = new Button();
                groupButtons.Controls.Add(button);
                button.Name = $"buttonAction{action}";
                button.Text = action;
                if (buttonsInScene.buttons.Count == 0)
                    buttonsInScene.buttons.Add(new ButtonInfo(button.Name, command, button.Text, 10, 20));
                else
                {
                    if (buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.x >= 250) // Новая строка
                        buttonsInScene.buttons.Add(new ButtonInfo(button.Name, command, button.Text, 10, buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.y + 50));
                    else
                        buttonsInScene.buttons.Add(new ButtonInfo(button.Name, command, button.Text, buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.x + 80, buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.y));
                }

                button.Location = new Point(buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.x, buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.y);

                button.Click += ButtonOnClick;

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ButtonsInScene));

                using (FileStream fs = new FileStream(@"buttons.xml", FileMode.OpenOrCreate))
                    xmlSerializer.Serialize(fs, buttonsInScene);
            }
            else
                MessageBox.Show("Не вписана команда!");
        }
        private void ButtonOnClick(object sender, EventArgs e)
        {
            totalAction = (sender as Button).Text;
            bool app = false;
            for(int i = 0; i < buttonsInScene.buttons.Count; i++)
            {
                if (totalAction == buttonsInScene.buttons[i].action)
                {
                    if (buttonsInScene.buttons[i].command == "app")
                    {
                        app = true;
                        Process.Start(buttonsInScene.buttons[i].action);
                        break;
                    }
                }
            }

            if (!app)
                panelActivate.Visible = true;

        }

        private void buttonCreate_Click(object sender, EventArgs e) => CreateButton(textBoxCommand.Text, command);
        


        private void buttonSubExit_Click(object sender, EventArgs e) => panelCreate.Visible = false;
        

        private void buttonActivate_Click(object sender, EventArgs e) // Сделать проверку(СЕЙЧАС CMD)
        {
            ProcessStartInfo psi;
            for (int i = 0; i < buttonsInScene.buttons.Count; i++)
            {
                if (totalAction == buttonsInScene.buttons[i].action)
                {
                    if (buttonsInScene.buttons[i].command == "app")         
                        break;
                    else if (buttonsInScene.buttons[i].command == "cmd")
                    {
                        psi = new ProcessStartInfo("cmd", $@"/k {totalAction} {textBoxInfo.Text}");
                        Process.Start(psi);
                        break;
                    }
                    else if (buttonsInScene.buttons[i].command == "powerShell")
                    {
                        psi = new ProcessStartInfo("PowerShell", $@"/k {totalAction} {textBoxInfo.Text}");
                        Process.Start(psi);
                        break;
                    }
                }
            }
            panelActivate.Visible = false;
        }

        private void buttonActivateMenuExit_Click(object sender, EventArgs e) => panelActivate.Visible = false;
    }
}
