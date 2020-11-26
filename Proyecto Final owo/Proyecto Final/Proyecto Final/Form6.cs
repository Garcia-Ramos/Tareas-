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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            string connection = "datasource=localhost;port=3306;username=root;password=;database=almacen";
            string query = "SELECT * FROM cardiologia";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;
            MySqlDataReader reader;
            string datos;


            try
            {
                conectionDatabase.Open();
                reader = databaseCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3) + " - " + reader.GetString(4) + " - " + reader.GetString(5) + " - " + reader.GetString(6) + " - " + reader.GetString(7) + " - " + reader.GetString(8) + " - " + reader.GetString(9) + " - " + reader.GetString(10) + " - " + reader.GetString(11));
                        datos = reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3) + " - " + reader.GetString(4) + " - " + reader.GetString(5) + " - " + reader.GetString(6) + " - " + reader.GetString(7) + " - " + reader.GetString(8) + " - " + reader.GetString(9) + " - " + reader.GetString(10) + " - " + reader.GetString(11);

                    }
                }
                else
                {
                    Console.WriteLine("No hay datos existentes.");
                }
                conectionDatabase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Eliminar()
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=almacen";
            string query = "DELETE FROM `cardiologia` WHERE Numero_identificacion  = '" + Identext.Text + "' ";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;

            try
            {
                conectionDatabase.Open();
                MySqlDataReader myeader1 = databaseCommand.ExecuteReader();
                MessageBox.Show("El dato se ha borrado exitosamente.");
                MostrarDatos();
                conectionDatabase.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                Nombox.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        private void Buscar()
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=almacen;";
            string query = "SELECT * FROM cardiologia where Numero_identificacion= '" + Identext.Text + "' ";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                conectionDatabase.Open();
                reader = databaseCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    listView1.Items.Clear();
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(5), reader.GetString(6) };

                        textBox1.Text = row[1];
                        Nombox.Text = row[2];
                        textBox2.Text = row[3];

                    }

                }
                else
                {
                    Console.WriteLine("Datos inexistentes");
                }
                conectionDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void MostrarDatos()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=almacen;";
            string query = "SELECT * cardiologia";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        listView1.Items.Clear();
                        while (reader.Read())
                        {
                            string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11) };
                            var ListViewItems = new ListViewItem(row);
                            listView1.Items.Add(ListViewItems);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Datos inexistentes.");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Nombox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Identext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Busbut_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Mosbut_Click(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void Abut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 registro = new Form10();
            registro.Show();
        }

        private void Rebut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 registro = new Form2();
            registro.Show();
        }

        private void Endbut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
