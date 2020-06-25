namespace Users_Base
{
    partial class Form_Creare_Profile
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
            this.text_login = new System.Windows.Forms.TextBox();
            this.text_password1 = new System.Windows.Forms.TextBox();
            this.text_password2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_create_profile = new System.Windows.Forms.Button();
            this.button_сlose = new System.Windows.Forms.Button();
            this.label_created = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_login
            // 
            this.text_login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.text_login.Location = new System.Drawing.Point(125, 50);
            this.text_login.MaxLength = 12;
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(150, 20);
            this.text_login.TabIndex = 0;
            
            // 
            // text_password1
            // 
            this.text_password1.Location = new System.Drawing.Point(125, 111);
            this.text_password1.MaxLength = 16;
            this.text_password1.Name = "text_password1";
            this.text_password1.PasswordChar = '*';
            this.text_password1.Size = new System.Drawing.Size(150, 20);
            this.text_password1.TabIndex = 1;
            this.text_password1.Text = "";
            text_password1.PasswordChar = '\u25CF';

            // 
            // text_password2
            // 
            this.text_password2.Location = new System.Drawing.Point(125, 171);
            this.text_password2.MaxLength = 16;
            this.text_password2.Name = "text_password2";
            this.text_password2.PasswordChar = '*';
            this.text_password2.Size = new System.Drawing.Size(150, 20);
            this.text_password2.TabIndex = 2;
            this.text_password2.Text = "";
            text_password2.PasswordChar = '\u25CF';


            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Повторите пароль:";
            
            // 
            // button_create_profile
            // 
            this.button_create_profile.Location = new System.Drawing.Point(90, 232);
            this.button_create_profile.Name = "button_create_profile";
            this.button_create_profile.Size = new System.Drawing.Size(100, 25);
            this.button_create_profile.TabIndex = 6;
            this.button_create_profile.Text = "Создать";
            this.button_create_profile.UseVisualStyleBackColor = true;
            this.button_create_profile.Click += new System.EventHandler(this.button_create_profile_Click);
            // 
            // button_сlose
            // 
            this.button_сlose.Location = new System.Drawing.Point(210, 232);
            this.button_сlose.Name = "button_сlose";
            this.button_сlose.Size = new System.Drawing.Size(100, 25);
            this.button_сlose.TabIndex = 7;
            this.button_сlose.Text = "Закрыть";
            this.button_сlose.UseVisualStyleBackColor = true;
            this.button_сlose.Click += new System.EventHandler(this.button_сlose_Click);
            // 
            // label_created
            // 
            this.label_created.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_created.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_created.Location = new System.Drawing.Point(148, 279);
            this.label_created.Name = "label_created";
            this.label_created.Size = new System.Drawing.Size(92, 13);
            this.label_created.TabIndex = 9;
            this.label_created.Text = "Профиль создан";
            this.label_created.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_created.Visible = false;
           
            // 
            // Form_Creare_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(384, 316);
            this.Controls.Add(this.label_created);
            this.Controls.Add(this.button_сlose);
            this.Controls.Add(this.button_create_profile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_password2);
            this.Controls.Add(this.text_password1);
            this.Controls.Add(this.text_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form_Creare_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание профиля";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_login;
        private System.Windows.Forms.TextBox text_password1;
        private System.Windows.Forms.TextBox text_password2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_create_profile;
        private System.Windows.Forms.Button button_сlose;
        private System.Windows.Forms.Label label_created;
    }
}