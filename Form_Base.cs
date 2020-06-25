using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data.Common;
using static Crypt;

namespace Users_Base
{
    public partial class Base_Form : Form
    {

        public static String db_name = "User_Base.db3"; //default database name for profiles             

        public Base_Form()
        {
            InitializeComponent();
        }      

        //enter to Work_Form with user`s profile
        private void button_enter_Click(object sender, EventArgs e)
        {
            if (File.Exists("User_Base.db3"))
            {
                Crypt cryptograph = new Crypt();
                Work_Form.login = cryptograph.Decrypt(text_login.Text); //encrypt login
                string password = cryptograph.Decrypt(text_password.Text); //encrypt password

                //connect database with user`s profile
                //we compare the encrypted login and password values with the encrypted values in the database
                using (SQLiteConnection connection = new SQLiteConnection())
                {
                    connection.ConnectionString = "Data Source = " + db_name;
                    connection.Open();

                    string command_text = "SELECT * FROM [profiles]";
                    SQLiteCommand command = new SQLiteCommand(command_text, connection);
                    SQLiteDataReader reader = command.ExecuteReader();

                    //if login and password have match in database then close authorization window
                    while (reader.Read())
                    {                        
                        if (Work_Form.login == $"{reader.GetString(1)}" && password == $"{reader.GetString(2)}")
                        {
                            MessageBox.Show("Вход успешно выполнен");
                            Work_Form.login = cryptograph.Decrypt(Work_Form.login); //save current profile name                            
                            connection.Close();
                            Close();
                            break;
                        }
                    }

                    connection.Close();
                    
                    //if login and password incorrect or no found in database
                    label_error.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("База профилей пуста. Пожалуйста, создайте новый профиль");
                text_login.Clear();
                text_password.Clear();
            }
            

        }
        
        //create database with profiles (if not exixsts) and open window to create profile
        private void button_create_profile_Click(object sender, EventArgs e)
        {           
            if (!File.Exists(db_name))
            {
                SQLiteConnection.CreateFile(db_name);
                SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");

                using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
                {
                    connection.ConnectionString = "Data Source = " + db_name;
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = "CREATE TABLE IF NOT EXISTS [profiles] (" +
                                   "[id] INTEGER PRIMARY KEY AUTOINCREMENT," +
                                   "[login] TEXT," +
                                   "[password] TEXT" +
                                   ")";

                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();                        
                    }
                    connection.Close();
                }               
            }

            //open window to create new profile
            Form_Creare_Profile new_form = new Form_Creare_Profile();
            new_form.ShowDialog();
        }

        //close application
        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       

        //clear TextBox and turn on PasswordChar
        private void text_password_GotFocus(object sender, EventArgs e)
        {
            if (text_password.Text == "пароль")
            {
                text_password.Clear();
                text_password.PasswordChar = '\u25CF';
                text_password.ForeColor = Color.Black;
            }
        }

        //if TextBox empty, turn off PasswordChar and display promt
        private void text_password_LostFocus(object sender, EventArgs e)
        {
            if (text_password.Text == "")
            {
                text_password.Text = "пароль";
                text_password.PasswordChar = '\0';
                text_password.ForeColor = SystemColors.ControlDark;
            }
        }

        //clear TextBox when user enter login
        private void text_login_GotFocus(object sender, EventArgs e)
        {
            if (text_login.Text == "логин")
            {
                text_login.Clear();
                text_login.ForeColor = Color.Black;
            }
        }

        //display promt
        private void text_login_LostFocus(object sender, EventArgs e)
        {
            if (text_login.Text == "")
            {
                text_login.Text = "логин";
                text_login.ForeColor = SystemColors.ControlDark;
            }
        }        
        
    }
}
