﻿
namespace SuperLauncher
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCMD = new System.Windows.Forms.Button();
            this.buttonPowerShell = new System.Windows.Forms.Button();
            this.panelChoice = new System.Windows.Forms.Panel();
            this.buttonApp = new System.Windows.Forms.Button();
            this.panelCreate = new System.Windows.Forms.Panel();
            this.labelNameCommand = new System.Windows.Forms.Label();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonSubExit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupButtons = new System.Windows.Forms.GroupBox();
            this.panelActivate = new System.Windows.Forms.Panel();
            this.labelActionSecond = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.buttonActivate = new System.Windows.Forms.Button();
            this.buttonActivateMenuExit = new System.Windows.Forms.Button();
            this.panelChoice.SuspendLayout();
            this.panelCreate.SuspendLayout();
            this.panelActivate.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(148, 400);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(346, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(34, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonCMD
            // 
            this.buttonCMD.Location = new System.Drawing.Point(14, 21);
            this.buttonCMD.Name = "buttonCMD";
            this.buttonCMD.Size = new System.Drawing.Size(92, 23);
            this.buttonCMD.TabIndex = 3;
            this.buttonCMD.Text = "CMD";
            this.buttonCMD.UseVisualStyleBackColor = true;
            this.buttonCMD.Click += new System.EventHandler(this.buttonCmd_Click);
            // 
            // buttonPowerShell
            // 
            this.buttonPowerShell.Location = new System.Drawing.Point(143, 21);
            this.buttonPowerShell.Name = "buttonPowerShell";
            this.buttonPowerShell.Size = new System.Drawing.Size(92, 23);
            this.buttonPowerShell.TabIndex = 4;
            this.buttonPowerShell.Text = "PowerShell";
            this.buttonPowerShell.UseVisualStyleBackColor = true;
            this.buttonPowerShell.Click += new System.EventHandler(this.buttonPowerShell_Click);
            // 
            // panelChoice
            // 
            this.panelChoice.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelChoice.Controls.Add(this.buttonApp);
            this.panelChoice.Controls.Add(this.buttonCMD);
            this.panelChoice.Controls.Add(this.buttonExit);
            this.panelChoice.Controls.Add(this.buttonPowerShell);
            this.panelChoice.Location = new System.Drawing.Point(396, 305);
            this.panelChoice.Name = "panelChoice";
            this.panelChoice.Size = new System.Drawing.Size(392, 133);
            this.panelChoice.TabIndex = 5;
            // 
            // buttonApp
            // 
            this.buttonApp.Location = new System.Drawing.Point(14, 66);
            this.buttonApp.Name = "buttonApp";
            this.buttonApp.Size = new System.Drawing.Size(92, 23);
            this.buttonApp.TabIndex = 5;
            this.buttonApp.Text = "Приложение";
            this.buttonApp.UseVisualStyleBackColor = true;
            this.buttonApp.Click += new System.EventHandler(this.buttonApp_Click);
            // 
            // panelCreate
            // 
            this.panelCreate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelCreate.Controls.Add(this.labelNameCommand);
            this.panelCreate.Controls.Add(this.textBoxCommand);
            this.panelCreate.Controls.Add(this.buttonCreate);
            this.panelCreate.Controls.Add(this.buttonSubExit);
            this.panelCreate.Location = new System.Drawing.Point(396, 27);
            this.panelCreate.Name = "panelCreate";
            this.panelCreate.Size = new System.Drawing.Size(392, 133);
            this.panelCreate.TabIndex = 6;
            // 
            // labelNameCommand
            // 
            this.labelNameCommand.AutoSize = true;
            this.labelNameCommand.Location = new System.Drawing.Point(102, 12);
            this.labelNameCommand.Name = "labelNameCommand";
            this.labelNameCommand.Size = new System.Drawing.Size(52, 13);
            this.labelNameCommand.TabIndex = 5;
            this.labelNameCommand.Text = "Команда";
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(45, 35);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(190, 20);
            this.textBoxCommand.TabIndex = 4;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(288, 95);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(92, 23);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonSubExit
            // 
            this.buttonSubExit.Location = new System.Drawing.Point(346, 12);
            this.buttonSubExit.Name = "buttonSubExit";
            this.buttonSubExit.Size = new System.Drawing.Size(34, 23);
            this.buttonSubExit.TabIndex = 2;
            this.buttonSubExit.Text = "X";
            this.buttonSubExit.UseVisualStyleBackColor = true;
            this.buttonSubExit.Click += new System.EventHandler(this.buttonSubExit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(346, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupButtons
            // 
            this.groupButtons.Location = new System.Drawing.Point(13, 13);
            this.groupButtons.Name = "groupButtons";
            this.groupButtons.Size = new System.Drawing.Size(377, 381);
            this.groupButtons.TabIndex = 7;
            this.groupButtons.TabStop = false;
            // 
            // panelActivate
            // 
            this.panelActivate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelActivate.Controls.Add(this.labelActionSecond);
            this.panelActivate.Controls.Add(this.textBoxInfo);
            this.panelActivate.Controls.Add(this.buttonActivate);
            this.panelActivate.Controls.Add(this.buttonActivateMenuExit);
            this.panelActivate.Location = new System.Drawing.Point(396, 166);
            this.panelActivate.Name = "panelActivate";
            this.panelActivate.Size = new System.Drawing.Size(392, 133);
            this.panelActivate.TabIndex = 7;
            // 
            // labelActionSecond
            // 
            this.labelActionSecond.AutoSize = true;
            this.labelActionSecond.Location = new System.Drawing.Point(102, 12);
            this.labelActionSecond.Name = "labelActionSecond";
            this.labelActionSecond.Size = new System.Drawing.Size(55, 13);
            this.labelActionSecond.TabIndex = 5;
            this.labelActionSecond.Text = "Значение";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(45, 35);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(190, 20);
            this.textBoxInfo.TabIndex = 4;
            // 
            // buttonActivate
            // 
            this.buttonActivate.Location = new System.Drawing.Point(288, 95);
            this.buttonActivate.Name = "buttonActivate";
            this.buttonActivate.Size = new System.Drawing.Size(92, 23);
            this.buttonActivate.TabIndex = 3;
            this.buttonActivate.Text = "Создать";
            this.buttonActivate.UseVisualStyleBackColor = true;
            this.buttonActivate.Click += new System.EventHandler(this.buttonActivate_Click);
            // 
            // buttonActivateMenuExit
            // 
            this.buttonActivateMenuExit.Location = new System.Drawing.Point(346, 12);
            this.buttonActivateMenuExit.Name = "buttonActivateMenuExit";
            this.buttonActivateMenuExit.Size = new System.Drawing.Size(34, 23);
            this.buttonActivateMenuExit.TabIndex = 2;
            this.buttonActivateMenuExit.Text = "X";
            this.buttonActivateMenuExit.UseVisualStyleBackColor = true;
            this.buttonActivateMenuExit.Click += new System.EventHandler(this.buttonActivateMenuExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelActivate);
            this.Controls.Add(this.groupButtons);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelCreate);
            this.Controls.Add(this.panelChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelChoice.ResumeLayout(false);
            this.panelCreate.ResumeLayout(false);
            this.panelCreate.PerformLayout();
            this.panelActivate.ResumeLayout(false);
            this.panelActivate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonCMD;
        private System.Windows.Forms.Button buttonPowerShell;
        private System.Windows.Forms.Panel panelChoice;
        private System.Windows.Forms.Panel panelCreate;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSubExit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelNameCommand;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.GroupBox groupButtons;
        private System.Windows.Forms.Panel panelActivate;
        private System.Windows.Forms.Label labelActionSecond;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button buttonActivate;
        private System.Windows.Forms.Button buttonActivateMenuExit;
        private System.Windows.Forms.Button buttonApp;
    }
}
