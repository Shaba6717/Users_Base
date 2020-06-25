namespace Users_Base
{
    partial class Work_Del_Tab_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_cansel = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.list_del = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_cansel);
            this.panel1.Controls.Add(this.button_del);
            this.panel1.Location = new System.Drawing.Point(42, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 36);
            this.panel1.TabIndex = 0;
            // 
            // button_cansel
            // 
            this.button_cansel.Location = new System.Drawing.Point(119, 3);
            this.button_cansel.Name = "button_cansel";
            this.button_cansel.Size = new System.Drawing.Size(75, 23);
            this.button_cansel.TabIndex = 1;
            this.button_cansel.Text = "Отмена";
            this.button_cansel.UseVisualStyleBackColor = true;
            this.button_cansel.Click += new System.EventHandler(this.button_cansel_Click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(3, 3);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(75, 23);
            this.button_del.TabIndex = 0;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Доступные таблицы:";
            // 
            // list_del
            // 
            this.list_del.FormattingEnabled = true;
            this.list_del.Location = new System.Drawing.Point(45, 35);
            this.list_del.Name = "list_del";
            this.list_del.Size = new System.Drawing.Size(191, 147);
            this.list_del.TabIndex = 2;
            this.list_del.Click += new System.EventHandler(this.list_del_Click);
            // 
            // Work_Del_Tab_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 237);
            this.Controls.Add(this.list_del);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Work_Del_Tab_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить таблицы";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_cansel;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_del;
    }
}