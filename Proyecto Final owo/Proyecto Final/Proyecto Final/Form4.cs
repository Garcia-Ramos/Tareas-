﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            string connection = "datasource=localhost;port=3306;username=root;password=;database=almacen";
            string query = "SELECT * FROM pediatria";
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

                        Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));
                        datos = reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3);

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
            string query = "DELETE FROM `pediatria` WHERE Numero_identificacion  = '" + Identext.Text + "' ";
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
            string query = "SELECT * FROM pediatria where Numero_identificacion= '" + Identext.Text + "' ";
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
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };

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
            string query = "SELECT * FROM pediatria";
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
                            string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
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

        }

        private void Rebut_Click(object sender, EventArgs e)
        {
            Form2 registro = new Form2();
            registro.Show();
        }

        private void Endbut_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 registro3 = new Form3();
            registro3.Close();
            Form2 registro2 = new Form2();
            registro2.Close();
            Form1 registro1 = new Form1();
            registro1.Close();
        }
    }
}