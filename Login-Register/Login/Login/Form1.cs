using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ingresar()
        {
            string connect = "datasource=localhost;port=3306;username=root;password=;database=mylogin";
            string query = "select * from mylogin where User = '" + Userbox.Text + "' AND Password = '" + Passbox.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Bienvenido al sistema <3");
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecto :c");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
   


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Userbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Passbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbut_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void Registerbut_Click(object sender, EventArgs e)
        {

        }
    }
}
