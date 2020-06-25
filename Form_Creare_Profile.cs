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
using static Crypt;

namespace Users_Base
{
    public partial class Form_Creare_Profile : Form
    {
        public Form_Creare_Profile()
        {
            InitializeComponent();
        }      

        //close window
        private void button_сlose_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }        

        //create new profile in database
        private void button_create_profile_Click(object sender, EventArgs e)
        {
            if (text_password1.Text == text_password2.Text && text_login.Text != "")
            {
                //enrycpt login and password 
                Crypt cryptograph = new Crypt();
                string login = cryptograph.Decrypt(text_login.Text);
                string password = cryptograph.Decrypt(text_password1.Text);                

                //connect to database
                using (SQLiteConnection connection = new SQLiteConnection())
                {
                    connection.ConnectionString = "Data Source = " + Base_Form.db_name;
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = "SELECT * FROM [profiles]";
                        command.CommandType = CommandType.Text;
                        SQLiteDataReader reader = command.ExecuteReader();
                        Boolean flag_copy = false;

                        //check if there is a profile with that name
                        while (reader.Read())
                        {
                            string text = $"{reader.GetString(1)}";
                            if (login == text)
                            {
                                flag_copy = true;
                                break;
                            }
                        }
                            

                        reader.Close();

                        //if profile with that name exist then show MessageBox and clear all textBox
                        if (flag_copy)
                        {
                            MessageBox.Show("Профиль с таким именем уже существует.");                            
                            connection.Close();
                            text_login.Clear();
                            text_password1.Clear();
                            text_password2.Clear();
                        }
                        else
                        {
                            command.CommandText = "INSERT INTO [profiles]([login], [password]) VALUES(@name, @pass)";
                            command.Parameters.AddWithValue("@name", login);
                            command.Parameters.AddWithValue("@pass", password);                           
                            command.ExecuteNonQuery();
                            connection.Close();

                            //if successful then show label "Профиль создан" and clear all textBox
                            label_created.Visible = true;
                            text_login.Clear();
                            text_password1.Clear();
                            text_password2.Clear();
                        }                        
                    }                    
                }                
            }
            else
            {
                //if failure then show label "Ошибка в логине или пароле" and clear textBox with password
                text_password1.Clear();
                text_password2.Clear();
                label_created.Text = "Ошибка";
                label_created.Visible = true;
                label_created.ForeColor = Color.Red;
            }
        }       
    }
}
