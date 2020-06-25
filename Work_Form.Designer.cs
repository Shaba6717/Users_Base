namespace Users_Base
{
    partial class Work_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_create = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_change_profile = new System.Windows.Forms.Button();
            this.button_del_table = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.label_table_name = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_help = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_create
            // 
            this.button_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_create.Location = new System.Drawing.Point(3, 3);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(105, 30);
            this.button_create.TabIndex = 0;
            this.button_create.Text = "Создать таблицу";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_open
            // 
            this.button_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_open.Location = new System.Drawing.Point(114, 3);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(105, 30);
            this.button_open.TabIndex = 1;
            this.button_open.Text = "Открыть таблицу";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_edit.Location = new System.Drawing.Point(99, 3);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(90, 30);
            this.button_edit.TabIndex = 2;
            this.button_edit.Text = "Изменить";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.button_change_profile);
            this.panel1.Controls.Add(this.button_del_table);
            this.panel1.Controls.Add(this.button_create);
            this.panel1.Controls.Add(this.button_open);
            this.panel1.Location = new System.Drawing.Point(29, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 49);
            this.panel1.TabIndex = 3;
            // 
            // button_change_profile
            // 
            this.button_change_profile.Location = new System.Drawing.Point(934, 3);
            this.button_change_profile.Name = "button_change_profile";
            this.button_change_profile.Size = new System.Drawing.Size(120, 30);
            this.button_change_profile.TabIndex = 6;
            this.button_change_profile.Text = "Сменить профиль";
            this.button_change_profile.UseVisualStyleBackColor = true;
            this.button_change_profile.Click += new System.EventHandler(this.button_change_profile_Click);
            // 
            // button_del_table
            // 
            this.button_del_table.Location = new System.Drawing.Point(225, 3);
            this.button_del_table.Name = "button_del_table";
            this.button_del_table.Size = new System.Drawing.Size(105, 30);
            this.button_del_table.TabIndex = 5;
            this.button_del_table.Text = "Удалить таблицу";
            this.button_del_table.UseVisualStyleBackColor = true;
            this.button_del_table.Click += new System.EventHandler(this.button_del_table_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(1023, 588);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(90, 30);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Закрыть";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(195, 3);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(90, 30);
            this.button_del.TabIndex = 3;
            this.button_del.Text = "Удалить";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // data_grid
            // 
            this.data_grid.AllowUserToAddRows = false;
            this.data_grid.AllowUserToDeleteRows = false;
            this.data_grid.AllowUserToResizeColumns = false;
            this.data_grid.AllowUserToResizeRows = false;
            this.data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_grid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.data_grid.Location = new System.Drawing.Point(29, 106);
            this.data_grid.Name = "data_grid";
            this.data_grid.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_grid.Size = new System.Drawing.Size(1054, 446);
            this.data_grid.TabIndex = 4;
            this.data_grid.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_CellLeave);
            this.data_grid.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.data_grid_RowStateChanged);
            // 
            // label_table_name
            // 
            this.label_table_name.AutoSize = true;
            this.label_table_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_table_name.Location = new System.Drawing.Point(26, 87);
            this.label_table_name.Name = "label_table_name";
            this.label_table_name.Size = new System.Drawing.Size(51, 16);
            this.label_table_name.TabIndex = 5;
            this.label_table_name.Text = "label1";
            this.label_table_name.Visible = false;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(3, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(90, 30);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.button_edit);
            this.panel2.Controls.Add(this.button_del);
            this.panel2.Location = new System.Drawing.Point(29, 558);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 60);
            this.panel2.TabIndex = 7;
            // 
            // label_help
            // 
            this.label_help.AutoSize = true;
            this.label_help.Location = new System.Drawing.Point(445, 561);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(35, 13);
            this.label_help.TabIndex = 8;
            this.label_help.Text = "label1";
            this.label_help.Visible = false;
            // 
            // Work_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 630);
            this.Controls.Add(this.label_help);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label_table_name);
            this.Controls.Add(this.data_grid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Work_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Base";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.DataGridView data_grid;

        public static System.Data.DataTable table; //own data form SQlite data base
        private System.Windows.Forms.Label label_table_name;
        private System.Windows.Forms.Button button_del_table;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_change_profile;
        private System.Windows.Forms.Label label_help;
    }
}