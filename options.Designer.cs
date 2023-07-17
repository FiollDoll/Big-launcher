namespace SuperLauncher
{
    partial class options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelColor = new System.Windows.Forms.Panel();
            this.labelTest = new System.Windows.Forms.Label();
            this.Red = new System.Windows.Forms.TrackBar();
            this.Green = new System.Windows.Forms.TrackBar();
            this.Blue = new System.Windows.Forms.TrackBar();
            this.buttonActivate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rvalue = new System.Windows.Forms.TextBox();
            this.Gvalue = new System.Windows.Forms.TextBox();
            this.Bvalue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonMainPage = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panelColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelColor.Controls.Add(this.labelTest);
            this.panelColor.Location = new System.Drawing.Point(226, 72);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(56, 127);
            this.panelColor.TabIndex = 4;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(3, 60);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(35, 13);
            this.labelTest.TabIndex = 0;
            this.labelTest.Text = "ТЕСТ";
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(30, 72);
            this.Red.Maximum = 255;
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(104, 45);
            this.Red.TabIndex = 5;
            this.Red.Scroll += new System.EventHandler(this.Red_Scroll);
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(30, 109);
            this.Green.Maximum = 255;
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(104, 45);
            this.Green.TabIndex = 6;
            this.Green.Scroll += new System.EventHandler(this.Green_Scroll);
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(30, 145);
            this.Blue.Maximum = 255;
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(104, 45);
            this.Blue.TabIndex = 7;
            this.Blue.Scroll += new System.EventHandler(this.Blue_Scroll);
            // 
            // buttonActivate
            // 
            this.buttonActivate.Location = new System.Drawing.Point(89, 392);
            this.buttonActivate.Name = "buttonActivate";
            this.buttonActivate.Size = new System.Drawing.Size(108, 23);
            this.buttonActivate.TabIndex = 8;
            this.buttonActivate.Text = "Применить";
            this.buttonActivate.UseVisualStyleBackColor = true;
            this.buttonActivate.Click += new System.EventHandler(this.buttonActivate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "B";
            // 
            // Rvalue
            // 
            this.Rvalue.Location = new System.Drawing.Point(131, 72);
            this.Rvalue.MaxLength = 3;
            this.Rvalue.Name = "Rvalue";
            this.Rvalue.Size = new System.Drawing.Size(30, 20);
            this.Rvalue.TabIndex = 12;
            this.Rvalue.TextChanged += new System.EventHandler(this.Rvalue_TextChanged);
            // 
            // Gvalue
            // 
            this.Gvalue.Location = new System.Drawing.Point(131, 109);
            this.Gvalue.MaxLength = 3;
            this.Gvalue.Name = "Gvalue";
            this.Gvalue.Size = new System.Drawing.Size(30, 20);
            this.Gvalue.TabIndex = 13;
            this.Gvalue.TextChanged += new System.EventHandler(this.Gvalue_TextChanged);
            // 
            // Bvalue
            // 
            this.Bvalue.Location = new System.Drawing.Point(131, 145);
            this.Bvalue.MaxLength = 3;
            this.Bvalue.Name = "Bvalue";
            this.Bvalue.Size = new System.Drawing.Size(30, 20);
            this.Bvalue.TabIndex = 14;
            this.Bvalue.TextChanged += new System.EventHandler(this.Bvalue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Цвет текста";
            // 
            // buttonWhite
            // 
            this.buttonWhite.Location = new System.Drawing.Point(15, 221);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(75, 23);
            this.buttonWhite.TabIndex = 16;
            this.buttonWhite.Text = "Белый";
            this.buttonWhite.UseVisualStyleBackColor = true;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.Location = new System.Drawing.Point(96, 221);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(75, 23);
            this.buttonBlack.TabIndex = 17;
            this.buttonBlack.Text = "Чёрный";
            this.buttonBlack.UseVisualStyleBackColor = true;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // buttonMainPage
            // 
            this.buttonMainPage.Location = new System.Drawing.Point(12, 12);
            this.buttonMainPage.Name = "buttonMainPage";
            this.buttonMainPage.Size = new System.Drawing.Size(97, 23);
            this.buttonMainPage.TabIndex = 18;
            this.buttonMainPage.Text = "Основной фон";
            this.buttonMainPage.UseVisualStyleBackColor = true;
            this.buttonMainPage.Click += new System.EventHandler(this.buttonMainPage_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(115, 12);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(97, 23);
            this.buttonMenu.TabIndex = 19;
            this.buttonMenu.Text = "Фон меню";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonMainPage);
            this.Controls.Add(this.buttonBlack);
            this.Controls.Add(this.buttonWhite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Bvalue);
            this.Controls.Add(this.Gvalue);
            this.Controls.Add(this.Rvalue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonActivate);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.panelColor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "options";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "options";
            this.panelColor.ResumeLayout(false);
            this.panelColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.TrackBar Red;
        private System.Windows.Forms.TrackBar Green;
        private System.Windows.Forms.TrackBar Blue;
        private System.Windows.Forms.Button buttonActivate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Rvalue;
        private System.Windows.Forms.TextBox Gvalue;
        private System.Windows.Forms.TextBox Bvalue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Button buttonMainPage;
        private System.Windows.Forms.Button buttonMenu;
    }
}