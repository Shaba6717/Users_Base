namespace Users_Base
{
    partial class Base_Form
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
            this.button_enter = new System.Windows.Forms.Button();
            this.button_create_profile = new System.Windows.Forms.Button();
            this.text_login = new System.Windows.Forms.TextBox();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label_base = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_enter
            // 
            this.button_enter.Location = new System.Drawing.Point(287, 270);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(75, 23);
            this.button_enter.TabIndex = 0;
            this.button_enter.Text = "Войти";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // button_create_profile
            // 
            this.button_create_profile.Location = new System.Drawing.Point(388, 270);
            this.button_create_profile.Name = "button_create_profile";
            this.button_create_profile.Size = new System.Drawing.Size(130, 23);
            this.button_create_profile.TabIndex = 1;
            this.button_create_profile.Text = "Создать профиль";
            this.button_create_profile.UseVisualStyleBackColor = true;
            this.button_create_profile.Click += new System.EventHandler(this.button_create_profile_Click);
            // 
            // text_login
            // 
            this.text_login.ForeColor = System.Drawing.Color.DarkGray;
            this.text_login.Location = new System.Drawing.Point(287, 180);
            this.text_login.MaxLength = 12;
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(231, 20);
            this.text_login.TabIndex = 2;
            this.text_login.Text = "логин";
            this.text_login.GotFocus += new System.EventHandler(this.text_login_GotFocus);
            this.text_login.LostFocus += new System.EventHandler(this.text_login_LostFocus);
            // 
            // text_password
            // 
            this.text_password.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.text_password.Location = new System.Drawing.Point(287, 215);
            this.text_password.MaxLength = 16;
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(231, 20);
            this.text_password.TabIndex = 3;
            this.text_password.Text = "пароль";
            this.text_password.GotFocus += new System.EventHandler(this.text_password_GotFocus);
            this.text_password.LostFocus += new System.EventHandler(this.text_password_LostFocus);
            // 
            // label_base
            // 
            this.label_base.AutoSize = true;
            this.label_base.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_base.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_base.Location = new System.Drawing.Point(257, 112);
            this.label_base.Name = "label_base";
            this.label_base.Size = new System.Drawing.Size(293, 28);
            this.label_base.TabIndex = 4;
            this.label_base.Text = "База данных сотрудников";
            this.label_base.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(679, 400);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 5;
            this.button_close.Text = "Выход";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_error
            // 
            this.label_error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(325, 238);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(151, 13);
            this.label_error.TabIndex = 6;
            this.label_error.Text = "Неверный логин или пароль";
            this.label_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_error.Visible = false;
            // 
            // Base_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_base);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.text_login);
            this.Controls.Add(this.button_create_profile);
            this.Controls.Add(this.button_enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Base_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Button button_create_profile;
        private System.Windows.Forms.TextBox text_login;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label label_base;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_error;
    }
}

