using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Users_Base
{
    public partial class Work_Form : Form
    {
        public static string login = ""; //current profile
        public static string table_name = ""; //current table`s name
        public static string table_open = ""; //stores the name of the opened table
        public static string table_del = ""; //stores the name of the table to be deleted
        public static string row_selected = ""; //user selected row
        public static Boolean flag_edit = false; //possibility for edit row        


        public Work_Form()
        {
            //show authorization window
            Base_Form new_form = new Base_Form();            
            new_form.ShowDialog();

            InitializeComponent();
        }      

        //create new table
        private void button_create_Click(object sender, EventArgs e)
        {
            if (!File.Exists(login + ".db3"))
                SQLiteConnection.CreateFile(login + ".db3");

            //call table create window
            Work_Create_Form new_form = new Work_Create_Form();            
            new_form.ShowDialog();

            //show table in Work_Form
            data_grid.DataSource = table;
            data_grid.ReadOnly = false;
            data_grid.Columns[data_grid.Columns.Count - 1].Width = 250;
            label_table_name.Text = table_name;
            label_table_name.Visible = true;
        }            

        //close application
        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //if row was selected by user
       private void data_grid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
       {
            //for any other operation except, StateChanged, do nothing
            if (e.StateChanged != DataGridViewElementStates.Selected)
                return;

            row_selected = e.Row.Index.ToString();           
       }      
    
        //add row to table
       private void button_add_Click(object sender, EventArgs e)
       {            
            Work_Add_Form new_form = new Work_Add_Form();
            new_form.ShowDialog();           

            data_grid.DataSource = table; //DataFridView ger DataSource update table            
            foreach (DataGridViewRow row in data_grid.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1); //number rows
                row.ReadOnly = true; //user can edit row if he click special button
            }

       }

        //open table if exist
        private void button_open_Click(object sender, EventArgs e)
        {
            Work_Open_Form new_form = new Work_Open_Form();
            new_form.ShowDialog();


            //if user selected table
            if (table_open != "")
            {
                table_name = table_open; //current table = open table
                table_open = "";

                data_grid.DataSource = table; //DataFridView ger DataSource open table
                data_grid.ReadOnly = false;
                data_grid.Columns[data_grid.Columns.Count - 1].Width = 250;
                data_grid.Enabled = true;                

                foreach (DataGridViewRow row in data_grid.Rows)
                {
                    row.HeaderCell.Value = String.Format("{0}", row.Index + 1); //number rows
                    row.ReadOnly = true; //user can edit row if he click special button
                }

                //show table name
                label_table_name.Text = table_name;
                label_table_name.Visible = true;
            }
                
        }

        //delete table
        private void button_del_table_Click(object sender, EventArgs e)
        {
            Work_Del_Tab_Form new_form = new Work_Del_Tab_Form();
            new_form.ShowDialog();

            //if user delete current table
            if (table_name == table_del)
            {
                table.Clear();
                label_table_name.Visible = false;
            }

        }

        //delete row from table
        private void button_del_Click(object sender, EventArgs e)
        {            
            UInt16 num_row = UInt16.Parse(row_selected);     

            try
            {
                data_grid.Rows.RemoveAt(num_row); //del row form DataGridView object
            }
            catch (FormatException)
            {
                MessageBox.Show("Таблица отсутствует"); //if user click button when DataGridView.DataSource = null
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("В таблице отсутствуют данные"); //if user click button when table have not rows
                return;
            }

            //if user delete last row, previous row get focus
            if (num_row > 0 && num_row == data_grid.Rows.Count)
                data_grid.Rows[num_row - 1].Selected = true;

            num_row++; //Sqlite [id]

            //connect to database for delete value
            using (SQLiteConnection connection = new SQLiteConnection())
            {
                connection.ConnectionString = "Data Source = " + Work_Form.login + ".db3";
                connection.Open();

                //delete row
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "DELETE FROM [" + table_name + "] WHERE [id]='" + num_row + "'";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                //numeration update
                command.CommandText = "UPDATE [" + table_name + "] SET [id]=[id] - 1 WHERE [id]>" + num_row;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                connection.Close();
            }

            foreach (DataGridViewRow row in data_grid.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1); //numberation update in DataGridView               
            }

        }

        //change ReadOnly to false for edit row
        private void button_edit_Click(object sender, EventArgs e)
        {
            UInt16 num_row = UInt16.Parse(row_selected);
            flag_edit = true; //possible edit
            label_help.Text = "Используйте щелчок для редактирования строки";
            label_help.Visible = true;

            try
            {
                data_grid.Rows[num_row].ReadOnly = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Таблица отсутствует"); //if user click button when DataGridView.DataSource = null
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("В таблице отсутствуют данные"); //if user click button when table have not rows
                return;
            }

        }        
        
        //database update after row change
        //event appear after user push Enter with edit mode
        private void data_grid_CellLeave(object sender, DataGridViewCellEventArgs e)
        {            
            if (flag_edit)
            {
                var num_row = UInt16.Parse(row_selected); //row`s number

                //if row was edit
                if (!data_grid.Rows[num_row].ReadOnly)
                {
                    data_grid.Rows[num_row].ReadOnly = true;
                    label_help.Visible = false;
                    flag_edit = false;
                    var id = num_row + 1; //Sqlite [id]

                    DataGridViewCellCollection row = data_grid.Rows[num_row].Cells; //get cells in row

                    //connect to database for update value
                    using (SQLiteConnection connection = new SQLiteConnection())
                    {
                        connection.ConnectionString = "Data Source = " + Work_Form.login + ".db3";
                        connection.Open();

                        SQLiteCommand command = new SQLiteCommand(connection);

                        foreach (DataGridViewCell cell in row)
                        {
                            //if cell not empty
                            if (cell.Value.ToString() != "")
                            {
                                command.CommandText = "UPDATE [" + table_name + "] " +
                                "SET [" + cell.OwningColumn.HeaderText.ToString() + "]='" + cell.Value.ToString() + "' WHERE [id]=" + id;
                                command.CommandType = CommandType.Text;
                                command.ExecuteNonQuery();
                            }
                        }

                        connection.Close();
                    }
                }
            }
        }

        //change profile
        private void button_change_profile_Click(object sender, EventArgs e)
        {
            string temp = Work_Form.login; //save current progile`s name
            Base_Form new_form = new Base_Form(); 
            new_form.ShowDialog(); //show authorization window

            //if profile was changed, clear wrokspace
            if (Work_Form.login != temp)
            {
                table_name = "";
                table_open = "";
                data_grid.DataSource = null;
                data_grid.Rows.Clear();
                label_table_name.Visible = false;
            }
        }
    }
}
