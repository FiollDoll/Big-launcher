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
using System.Threading;
using Opt;
namespace SuperLauncher
{
    public partial class MainForm : Form
    {
        public ButtonsInScene buttonsInScene = new ButtonsInScene();
        public ProcessStartInfo PSI;
        public string totalAction;
        public string command;
        public int pageTotal;
        public string resultat;
        

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
                    buttonsInScene = xmlSerializer.Deserialize(fs) as ButtonsInScene;
                

                for (int i = 0; i < buttonsInScene.buttons.Count; i++)
                {
                    if (buttonsInScene.buttons[i].position.page == 0)
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

            EditPage(0);
            UpdateVisual();
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

        private void CreateButton(string action, string command, bool newButton = false, int id = 0)
        {
            if (action != "")
            {
                panelCreate.Visible = false;
                Button button = new Button();
                groupButtons.Controls.Add(button);

                if (id == -1)
                {
                    int buttonsCount = 0;
                    for (int i = 0; i < buttonsInScene.buttons.Count; i++)
                    {
                        if (buttonsInScene.buttons[i].position.page == pageTotal)
                            buttonsCount++;
                    }
                    id = buttonsCount;
                }

                if (newButton)
                {
                    if (textBoxNameCommand.Text == "")
                        textBoxNameCommand.Text = action;
                    button.Name = textBoxNameCommand.Text;
                    button.Text = textBoxNameCommand.Text;
                    if (id == 0)
                        buttonsInScene.buttons.Add(new ButtonInfo(id, button.Name, command, textBoxNameCommand.Text, action, new ButtonLocation(pageTotal, 10, 20), checkBoxOption.Checked, checkBoxOtherOption.Checked));
                    else
                    {
                        if (buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.x >= 250) // Новая строка
                            buttonsInScene.buttons.Add(new ButtonInfo(id, button.Name, command, textBoxNameCommand.Text, action, new ButtonLocation(pageTotal, 10, buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.y + 50), checkBoxOption.Checked, checkBoxOtherOption.Checked));

                        else
                            buttonsInScene.buttons.Add(new ButtonInfo(id, button.Name, command, textBoxNameCommand.Text, action, new ButtonLocation(pageTotal, buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.x + 80, buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.y), checkBoxOption.Checked, checkBoxOtherOption.Checked));

                        button.Location = new Point(buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.x, buttonsInScene.buttons[buttonsInScene.buttons.Count - 1].position.y);
                    }
                }
                else
                {
                    button.Name = buttonsInScene.buttons[id].name;
                    button.Text = buttonsInScene.buttons[id].name;
                    button.Location = new Point(buttonsInScene.buttons[id].position.x, buttonsInScene.buttons[id].position.y);
                }

                button.Click += ButtonOnClick;

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ButtonsInScene));

                using (FileStream fs = new FileStream($@"buttons.xml", FileMode.OpenOrCreate))
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

        private void buttonCreate_Click(object sender, EventArgs e) => CreateButton(textBoxCommand.Text, command, true, -1);



        private void buttonSubExit_Click(object sender, EventArgs e) => panelCreate.Visible = false;

        private void OpenProcces()
        {
            resultat = "";
            PSI.RedirectStandardOutput = true;
            PSI.UseShellExecute = false;
            PSI.CreateNoWindow = true;
            Process proc = new Process();
            proc.StartInfo = PSI;
            proc.Start();
            var stream = proc.StandardOutput.BaseStream;
            using (var reader = new StreamReader(stream, Encoding.GetEncoding(866)))
            {
                while (!reader.EndOfStream)
                {
                    resultat = resultat + "\n" + reader.ReadLine();
                    if (InvokeRequired)
                    {
                        Invoke((MethodInvoker)(() =>
                        {
                            UpdateResultat(resultat);
                        }
                        ));
                    }
                    else
                        UpdateResultat(resultat);  
                }
            }
        }

        void UpdateResultat(string res) => resultText.Text = res;

        private void buttonActivate_Click(object sender, EventArgs e)
        {
            resultText.Text = "";
            for (int i = 0; i < buttonsInScene.buttons.Count; i++)
            {
                if (totalAction == buttonsInScene.buttons[i].name)
                {
                    if (buttonsInScene.buttons[i].command == "app")
                        break;
                    else if (buttonsInScene.buttons[i].command == "cmd")
                    {
                        try
                        {
                            PSI = new ProcessStartInfo("cmd", $@"/c {buttonsInScene.buttons[i].action} {textBoxInfo.Text}");

                            Thread thread1 = new Thread(OpenProcces);
                            thread1.Start();
                        }
                        catch (Exception objException)
                        {
                            Console.WriteLine(objException.Message);
                        }
                        break;
                    }
                }
                else if (buttonsInScene.buttons[i].command == "powerShell")
                {
                    try
                    {
                        PSI = new ProcessStartInfo("PowerShell", $@"{buttonsInScene.buttons[i].action} {textBoxInfo.Text}");
                        Thread thread1 = new Thread(OpenProcces);
                        thread1.Start();
                    }
                    catch (Exception objException)
                    {
                        Console.WriteLine(objException.Message);
                    }
                    break;
                }
            }
            panelActivate.Visible = false;
        }

        private void buttonActivateMenuExit_Click(object sender, EventArgs e) => panelActivate.Visible = false;

        private void EditPage(int pageEdit)
        {
            pageTotal += pageEdit;

            for (int i = 0; i < buttonsInScene.buttons.Count; i++) // Очистка
            {
                if (groupButtons.Controls.ContainsKey(buttonsInScene.buttons[i].name))
                {
                    var button = groupButtons.Controls[buttonsInScene.buttons[i].name];
                    //(button as Button).Visible = false;
                    groupButtons.Controls.Remove(button);
                }
            }

            for (int i = 0; i < buttonsInScene.buttons.Count; i++)
            {
                if (buttonsInScene.buttons[i].position.page == pageTotal)
                    CreateButton(buttonsInScene.buttons[i].action, buttonsInScene.buttons[i].command, false, i);
            }

            if (pageTotal == 0)
                buttonBackPage.Visible = false;
            else
                buttonBackPage.Visible = true;

            labelPage.Text = (pageTotal + 1).ToString();
        }


        private void buttonNextPage_Click(object sender, EventArgs e) => EditPage(+1);

        private void buttonBackPage_Click(object sender, EventArgs e) => EditPage(-1);

        private void checkBoxOption_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxOtherOption.Visible = checkBoxOption.Checked;
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            options OptionsForm = new options();
            OptionsForm.Show();
        }

        private void UpdateVisual()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Option));
            Option option = new Option();
            if (File.Exists("option.xml"))
            {
                // десериализуем объект
                using (FileStream fs = new FileStream("option.xml", FileMode.OpenOrCreate))
                    option = xmlSerializer.Deserialize(fs) as Option;
                this.BackColor = Color.FromArgb(255, option.mainPage.r, option.mainPage.g, option.mainPage.b);
                Color newFontColor = Color.FromArgb(255, option.mainPage.rFont, option.mainPage.gFont, option.mainPage.bFont);
                labelPage.ForeColor = newFontColor;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e) => UpdateVisual();
        
    }
}
