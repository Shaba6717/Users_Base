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
using System.Data.Common;

namespace Users_Base
{
    public partial class Work_Create_Form : Form
    {
        public Work_Create_Form()
        {
            InitializeComponent();
        }

        //close window
        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        //creat new table in carrent profile
        private void button_create_Click(object sender, EventArgs e)
        {
            SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");

            //connect to database
            using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
            {
                connection.ConnectionString = "Data Source = " + Work_Form.login + ".db3";
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "SELECT name FROM sqlite_master WHERE type='table'";
                    command.CommandType = CommandType.Text;
                    SQLiteDataReader reader = command.ExecuteReader();
                    Boolean flag_copy = false;

                    //searching table duplicate
                    while (reader.Read())                    
                        if (text_name.Text == $"{reader.GetString(0)}")
                        {
                            flag_copy = true;                                                  
                            break;
                        }                    

                    //if duplicate exist then show message and close window
                    //else create and show new table
                    if(flag_copy)
                    {
                        MessageBox.Show("Таблица с таким именем уже существует.");
                        reader.Close();
                        connection.Close();
                        Close();
                        Dispose();
                    }
                    else
                    {
                        reader.Close();

                        command.CommandText = "CREATE TABLE IF NOT EXISTS [" + text_name.Text + "] (" +
                                   "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                                   "[name] TEXT," +
                                   "[surname] TEXT," +
                                   "[patronymic] TEXT," +
                                   "[birthday] TEXT," +
                                   "[address] TEXT," +
                                   "[department] TEXT," +
                                   "[about] TEXT" +
                                   ")";

                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();

                        Work_Form.table = new DataTable();
                        DataColumn col;

                        command.CommandText = "SELECT * FROM [" + text_name.Text + "]";
                        command.CommandType = CommandType.Text;
                        reader = command.ExecuteReader();

                        for (int i = 1; i < reader.FieldCount; i++)
                        {                            
                            col = new DataColumn(reader.GetName(i));
                            Work_Form.table.Columns.Add(col);
                        }

                        reader.Close();
                        connection.Close();

                        MessageBox.Show("Таблица создана.");
                        Work_Form.table_name = text_name.Text; //current table = new table
                        
                        Close();
                        Dispose();
                    }
                    
                }                
            }
        }
    }
}
