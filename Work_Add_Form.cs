using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Users_Base
{
    public partial class Work_Add_Form : Form
    {
        private static Int32 num_row; //number last row

        public Work_Add_Form()
        {
            InitializeComponent();
        }

        //add new row in database and DataTable
        private void button_add_Click(object sender, EventArgs e)
        {            
            //connect to database
            using (SQLiteConnection connection = new SQLiteConnection())
            {
                //add new row to database
                string command_text = "INSERT INTO [" + Work_Form.table_name + "]" +

                    "([name], [surname], [patronymic], [birthday], [address], [department], [about]) " +

                    "VALUES(@name, @surname, @patronymic, @birthday, @address, @department, @about)";

                SQLiteCommand command = new SQLiteCommand(command_text, connection);
                command.Parameters.AddWithValue("@name", text_name.Text);
                command.Parameters.AddWithValue("@surname", text_surname.Text);
                command.Parameters.AddWithValue("@patronymic", text_patronymic.Text);
                command.Parameters.AddWithValue("@birthday", text_birthday.Text);
                command.Parameters.AddWithValue("@address", text_address.Text);
                command.Parameters.AddWithValue("@department", text_department.Text);
                command.Parameters.AddWithValue("@about", text_about.Text);
                connection.ConnectionString = "Data Source = " + Work_Form.login + ".db3";
                connection.Open();
                command.ExecuteNonQuery();
               
                num_row = Work_Form.table.Rows.Count;  //Sqlite [id]              
                num_row++;                
                
                //read new row from database
                command.CommandText = "SELECT * FROM [" + Work_Form.table_name + "] WHERE [id]=" + num_row;
                command.CommandType = CommandType.Text;
                SQLiteDataReader reader = command.ExecuteReader();

                //create and add new row in DataTable
                DataRow row = Work_Form.table.NewRow();
                while (reader.Read())
                {                   
                    for (int i = 1; i < reader.FieldCount; i++)
                    {
                        row[reader.GetName(i)] = reader.GetValue(i).ToString();
                        reader.GetValue(i).ToString();
                    }
                    Work_Form.table.Rows.Add(row);
                }

                reader.Close();
                connection.Close();
            }
            Close();
            Dispose();
        }

        //close window
        private void button_cansel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
