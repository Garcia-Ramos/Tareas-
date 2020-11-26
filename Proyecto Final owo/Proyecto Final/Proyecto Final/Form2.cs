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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 registro = new Form6();
            registro.Show();
        }

        private void Imabut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 registro = new Form5();
            registro.Show();
        }

        private void Traobut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 registro = new Form3();
            registro.Show();
        }

        private void Pediatriabut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 registro = new Form4();
            registro.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Endbut_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
