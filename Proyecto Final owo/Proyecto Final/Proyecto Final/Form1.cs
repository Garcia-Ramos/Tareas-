using Proyecto_Final;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_Final
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
            string connect = "datasource=localhost;port=3306;username=root;password=;database=almacen";
            string query = "select * from ingresar where Usuario = '" + Userbox.Text + "' AND Clave = '" + Passbox.Text + "' AND ID = '" + IDBox.Text + "'";
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
                    MessageBox.Show("Datos ingresados exitosamente.");
                    Form2 registro = new Form2();
                    registro.Show();

                }
          

                else
                {
                    MessageBox.Show("Datos incorrectos, vuelva a intentarlo.");
                }

                databaseConnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
