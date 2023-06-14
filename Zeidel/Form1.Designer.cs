namespace Zeidel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            menuStrip1 = new MenuStrip();
            signInToolStripMenuItem = new ToolStripMenuItem();
            nameToolStripMenuItem = new ToolStripTextBox();
            passwordToolStripMenuItem = new ToolStripTextBox();
            signInToolStripMenuItem1 = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            nameToolStripMenuItem1 = new ToolStripTextBox();
            passwordToolStripMenuItem1 = new ToolStripTextBox();
            registerToolStripMenuItem1 = new ToolStripMenuItem();
            iDToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(594, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Location = new Point(694, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Location = new Point(12, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Решить";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Location = new Point(112, 409);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "Очистить";
            button4.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { signInToolStripMenuItem, registerToolStripMenuItem, iDToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // signInToolStripMenuItem
            // 
            signInToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nameToolStripMenuItem, passwordToolStripMenuItem, signInToolStripMenuItem1 });
            signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            signInToolStripMenuItem.Size = new Size(68, 24);
            signInToolStripMenuItem.Text = "Sign In";
            // 
            // nameToolStripMenuItem
            // 
            nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            nameToolStripMenuItem.Size = new Size(224, 27);
            nameToolStripMenuItem.Text = "ildar";
            // 
            // passwordToolStripMenuItem
            // 
            passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            passwordToolStripMenuItem.Size = new Size(298, 27);
            passwordToolStripMenuItem.Text = "123";
            // 
            // signInToolStripMenuItem1
            // 
            signInToolStripMenuItem1.Name = "signInToolStripMenuItem1";
            signInToolStripMenuItem1.Size = new Size(372, 26);
            signInToolStripMenuItem1.Text = "Sign In";
            signInToolStripMenuItem1.Click += SignIn;
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nameToolStripMenuItem1, passwordToolStripMenuItem1, registerToolStripMenuItem1 });
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(77, 24);
            registerToolStripMenuItem.Text = "Register";
            // 
            // nameToolStripMenuItem1
            // 
            nameToolStripMenuItem1.Name = "nameToolStripMenuItem1";
            nameToolStripMenuItem1.Size = new Size(224, 27);
            // 
            // passwordToolStripMenuItem1
            // 
            passwordToolStripMenuItem1.Name = "passwordToolStripMenuItem1";
            passwordToolStripMenuItem1.Size = new Size(298, 27);
            // 
            // registerToolStripMenuItem1
            // 
            registerToolStripMenuItem1.Name = "registerToolStripMenuItem1";
            registerToolStripMenuItem1.Size = new Size(372, 26);
            registerToolStripMenuItem1.Text = "Register";
            registerToolStripMenuItem1.Click += Register;
            // 
            // iDToolStripMenuItem
            // 
            iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            iDToolStripMenuItem.Size = new Size(41, 24);
            iDToolStripMenuItem.Text = "ID:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Форма";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem signInToolStripMenuItem;
        private ToolStripMenuItem signInToolStripMenuItem1;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem1;
        private ToolStripTextBox nameToolStripMenuItem;
        private ToolStripTextBox passwordToolStripMenuItem;
        private ToolStripTextBox nameToolStripMenuItem1;
        private ToolStripTextBox passwordToolStripMenuItem1;
        private ToolStripMenuItem iDToolStripMenuItem;
    }
}