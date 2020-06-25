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
    public partial class Work_Open_Form : Form
    {
        public Work_Open_Form()
        {
            InitializeComponent();

            //connect to database for load list of tables
            using (SQLiteConnection connection = new SQLiteConnection())
            {
                connection.ConnectionString = "Data Source = " + Work_Form.login + ".db3";
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT name FROM sqlite_master WHERE type='table'";
                command.CommandType = CommandType.Text;
                SQLiteDataReader reader = command.ExecuteReader();                

                //only user`s tables
                while (reader.Read())
                {
                    if ($"{reader.GetString(0)}" != "sqlite_sequence")
                        listBox_open.Items.Add($"{reader.GetString(0)}");
                }                   

                reader.Close();
                connection.Close();
            }
        }

        //close window
        private void button_cansel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        //select table for open
        private void listBox_open_Click(object sender, EventArgs e)
        {
            if (listBox_open.SelectedItem != null)
                Work_Form.table_open = listBox_open.SelectedItem.ToString();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            //connect to database and load information from base to DataSource
            using (SQLiteConnection connection = new SQLiteConnection())
            {
                connection.ConnectionString = "Data Source = " + Work_Form.login + ".db3";
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM [" + Work_Form.table_open + "]";
                command.CommandType = CommandType.Text;
                SQLiteDataReader reader = command.ExecuteReader();

                Work_Form.table = new DataTable();
                DataColumn col;
                DataRow row;

                for (int i = 1; i < reader.FieldCount; i++)
                {
                    col = new DataColumn(reader.GetName(i));
                    Work_Form.table.Columns.Add(col);
                }

                while (reader.Read())
                {
                    row = Work_Form.table.NewRow();
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
    }
}
