using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Opt;
using Buttons;

namespace SuperLauncher
{
    public partial class options : Form
    {
        int rFont, gFont, bFont;
        string totalObj = "menu";
        Option option = new Option();

        public options()
        {
            InitializeComponent();
            // Десериализация

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Opt.Option));
                if (File.Exists("option.xml"))
                {
                    // десериализуем объект
                    using (FileStream fs = new FileStream("option.xml", FileMode.OpenOrCreate))
                        option = xmlSerializer.Deserialize(fs) as Option;
                Red.Value = option.mainPage.r;
                Green.Value = option.mainPage.g;
                Blue.Value = option.mainPage.b;
                rFont = option.mainPage.rFont;
                gFont = option.mainPage.gFont;
                bFont = option.mainPage.bFont;
                Rvalue.Text = Red.Value.ToString();
                Gvalue.Text = Green.Value.ToString();
                Bvalue.Text = Blue.Value.ToString();
                SetColor(option.mainPage.r, option.mainPage.g, option.mainPage.b);
            }
        }

        private void SetColor(int r, int g, int b)
        {
            Color newColor = Color.FromArgb(255, r, g, b);
            labelTest.ForeColor = Color.FromArgb(255, rFont, gFont, bFont);
            panelColor.BackColor = newColor;
        }

        private void Red_Scroll(object sender, EventArgs e)
        {
            SetColor(Red.Value, Green.Value, Blue.Value);
            Rvalue.Text = Red.Value.ToString();
        }

        private void Green_Scroll(object sender, EventArgs e)
        {
            SetColor(Red.Value, Green.Value, Blue.Value);
            Gvalue.Text = Green.Value.ToString();
        }

        private void Blue_Scroll(object sender, EventArgs e)
        {
            SetColor(Red.Value, Green.Value, Blue.Value);
            Bvalue.Text = Blue.Value.ToString();
        }

        private void Rvalue_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Rvalue.Text) > 255)
                Rvalue.Text = "255";
            Red.Value = Convert.ToInt32(Rvalue.Text);
            SetColor(Red.Value, Green.Value, Blue.Value);
        }

        private void Gvalue_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Gvalue.Text) > 255)
                Gvalue.Text = "255";
            Green.Value = Convert.ToInt32(Gvalue.Text);
            SetColor(Red.Value, Green.Value, Blue.Value);
        }

        private void Bvalue_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Bvalue.Text) > 255)
                Bvalue.Text = "255";
            Blue.Value = Convert.ToInt32(Bvalue.Text);
            SetColor(Red.Value, Green.Value, Blue.Value);
        }

        private void buttonActivate_Click(object sender, EventArgs e)
        {
            if (totalObj == "main")
            {
                option.mainPage.r = Red.Value;
                option.mainPage.g = Green.Value;
                option.mainPage.b = Blue.Value;
                option.mainPage.rFont = rFont;
                option.mainPage.gFont = gFont;
                option.mainPage.bFont = bFont;
            }
            else
            {
                option.menus.r = Red.Value;
                option.menus.g = Green.Value;
                option.menus.b = Blue.Value;
                option.menus.rFont = rFont;
                option.menus.gFont = gFont;
                option.menus.bFont = bFont;
            }


            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Option));

            using (FileStream fs = new FileStream($@"option.xml", FileMode.OpenOrCreate))
                xmlSerializer.Serialize(fs, option);        
        }

        private void buttonMainPage_Click(object sender, EventArgs e)
        {
            Red.Value = option.mainPage.r;
            Green.Value = option.mainPage.g;
            Blue.Value = option.mainPage.b;
            rFont = option.mainPage.rFont;
            gFont = option.mainPage.gFont;
            bFont = option.mainPage.bFont;
            Rvalue.Text = Red.Value.ToString();
            Gvalue.Text = Green.Value.ToString();
            Bvalue.Text = Blue.Value.ToString();
            SetColor(option.mainPage.r, option.mainPage.g, option.mainPage.b);
            totalObj = "main";
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Red.Value = option.menus.r;
            Green.Value = option.menus.g;
            Blue.Value = option.menus.b;
            rFont = option.menus.rFont;
            gFont = option.menus.gFont;
            bFont = option.menus.bFont;
            Rvalue.Text = Red.Value.ToString();
            Gvalue.Text = Green.Value.ToString();
            Bvalue.Text = Blue.Value.ToString();
            SetColor(option.menus.r, option.menus.g, option.menus.b);
            totalObj = "menu";
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            rFont = 255;
            gFont = 255;
            bFont = 255;
            SetColor(Red.Value, Green.Value, Blue.Value);
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            rFont = 0;
            gFont = 0;
            bFont = 0;
            SetColor(Red.Value, Green.Value, Blue.Value);
        }
    }
}

namespace Opt
{
    public class Option
    {
        public OptionPart mainPage;
        public OptionPart menus;

        public Option()
        {
            mainPage = new OptionPart();
            menus = new OptionPart();
        }
    }

    public class OptionPart
    {
        public int r, g, b;
        public int rFont, gFont, bFont;

        public OptionPart()
        {

        }
    }
}
