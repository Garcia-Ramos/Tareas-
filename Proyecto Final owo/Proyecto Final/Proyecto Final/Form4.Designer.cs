
namespace Proyecto_Final
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup33 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup34 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup35 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup36 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FNAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MARCA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SERIE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UCICACION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ESTATUS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DEPARTAMENTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FUNCIONAMIENTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RIESGO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.REFACCIONES = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ACCESORIOS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Mosbut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Identext = new System.Windows.Forms.TextBox();
            this.Endbut = new System.Windows.Forms.Button();
            this.Abut = new System.Windows.Forms.Button();
            this.Rebut = new System.Windows.Forms.Button();
            this.Busbut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Nombox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FNAME,
            this.Modelo,
            this.MARCA,
            this.SERIE,
            this.UCICACION,
            this.ESTATUS,
            this.DEPARTAMENTO,
            this.FUNCIONAMIENTO,
            this.RIESGO,
            this.REFACCIONES,
            this.ACCESORIOS});
            listViewGroup33.Header = "ListViewGroup";
            listViewGroup33.Name = "ID";
            listViewGroup34.Header = "ListViewGroup";
            listViewGroup34.Name = "F. name";
            listViewGroup35.Header = "ListViewGroup";
            listViewGroup35.Name = "Last Name";
            listViewGroup36.Header = "ListViewGroup";
            listViewGroup36.Name = "Address";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup33,
            listViewGroup34,
            listViewGroup35,
            listViewGroup36});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 85);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1197, 414);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 47;
            // 
            // FNAME
            // 
            this.FNAME.Text = "Descripción";
            this.FNAME.Width = 170;
            // 
            // Modelo
            // 
            this.Modelo.Text = "Modelo";
            this.Modelo.Width = 105;
            // 
            // MARCA
            // 
            this.MARCA.Text = "Marca";
            this.MARCA.Width = 87;
            // 
            // SERIE
            // 
            this.SERIE.Text = "Serie";
            this.SERIE.Width = 75;
            // 
            // UCICACION
            // 
            this.UCICACION.Text = "Ubicación";
            this.UCICACION.Width = 110;
            // 
            // ESTATUS
            // 
            this.ESTATUS.Text = "Estatus";
            this.ESTATUS.Width = 91;
            // 
            // DEPARTAMENTO
            // 
            this.DEPARTAMENTO.Text = "Departamento";
            this.DEPARTAMENTO.Width = 120;
            // 
            // FUNCIONAMIENTO
            // 
            this.FUNCIONAMIENTO.Text = "Funcionamiento";
            this.FUNCIONAMIENTO.Width = 116;
            // 
            // RIESGO
            // 
            this.RIESGO.Text = "Riesgo";
            this.RIESGO.Width = 92;
            // 
            // REFACCIONES
            // 
            this.REFACCIONES.Text = "Cantidad_refacciones";
            this.REFACCIONES.Width = 87;
            // 
            // ACCESORIOS
            // 
            this.ACCESORIOS.Text = "Accesorios";
            this.ACCESORIOS.Width = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 54;
            this.label1.Text = "Pedriatria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 53;
            this.label2.Text = "Company García Ramos\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1245, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 38);
            this.button1.TabIndex = 62;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mosbut
            // 
            this.Mosbut.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mosbut.Location = new System.Drawing.Point(1245, 245);
            this.Mosbut.Name = "Mosbut";
            this.Mosbut.Size = new System.Drawing.Size(113, 38);
            this.Mosbut.TabIndex = 61;
            this.Mosbut.Text = "Mostrar";
            this.Mosbut.UseVisualStyleBackColor = true;
            this.Mosbut.Click += new System.EventHandler(this.Mosbut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1246, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 60;
            this.label3.Text = "ID del equipo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Identext
            // 
            this.Identext.Location = new System.Drawing.Point(1245, 47);
            this.Identext.Name = "Identext";
            this.Identext.Size = new System.Drawing.Size(113, 20);
            this.Identext.TabIndex = 59;
            this.Identext.TextChanged += new System.EventHandler(this.Identext_TextChanged);
            // 
            // Endbut
            // 
            this.Endbut.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endbut.Location = new System.Drawing.Point(1245, 430);
            this.Endbut.Name = "Endbut";
            this.Endbut.Size = new System.Drawing.Size(113, 38);
            this.Endbut.TabIndex = 58;
            this.Endbut.Text = "Salir";
            this.Endbut.UseVisualStyleBackColor = true;
            this.Endbut.Click += new System.EventHandler(this.Endbut_Click);
            // 
            // Abut
            // 
            this.Abut.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abut.Location = new System.Drawing.Point(1245, 306);
            this.Abut.Name = "Abut";
            this.Abut.Size = new System.Drawing.Size(113, 38);
            this.Abut.TabIndex = 57;
            this.Abut.Text = "Actualizar ";
            this.Abut.UseVisualStyleBackColor = true;
            this.Abut.Click += new System.EventHandler(this.Abut_Click);
            // 
            // Rebut
            // 
            this.Rebut.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rebut.Location = new System.Drawing.Point(1245, 368);
            this.Rebut.Name = "Rebut";
            this.Rebut.Size = new System.Drawing.Size(113, 38);
            this.Rebut.TabIndex = 56;
            this.Rebut.Text = "Regresar";
            this.Rebut.UseVisualStyleBackColor = true;
            this.Rebut.Click += new System.EventHandler(this.Rebut_Click);
            // 
            // Busbut
            // 
            this.Busbut.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Busbut.Location = new System.Drawing.Point(1245, 128);
            this.Busbut.Name = "Busbut";
            this.Busbut.Size = new System.Drawing.Size(113, 38);
            this.Busbut.TabIndex = 55;
            this.Busbut.Text = "Buscar";
            this.Busbut.UseVisualStyleBackColor = true;
            this.Busbut.Click += new System.EventHandler(this.Busbut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1011, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 68;
            this.label6.Text = "Estatus";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(945, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 67;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(692, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 66;
            this.label5.Text = "Ubicación";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 22);
            this.label4.TabIndex = 65;
            this.label4.Text = "Nombre del equipo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(307, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 64;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nombox
            // 
            this.Nombox.Location = new System.Drawing.Point(627, 49);
            this.Nombox.Name = "Nombox";
            this.Nombox.Size = new System.Drawing.Size(212, 20);
            this.Nombox.TabIndex = 63;
            this.Nombox.TextChanged += new System.EventHandler(this.Nombox_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 511);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Nombox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mosbut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Identext);
            this.Controls.Add(this.Endbut);
            this.Controls.Add(this.Abut);
            this.Controls.Add(this.Rebut);
            this.Controls.Add(this.Busbut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FNAME;
        private System.Windows.Forms.ColumnHeader Modelo;
        private System.Windows.Forms.ColumnHeader MARCA;
        private System.Windows.Forms.ColumnHeader SERIE;
        private System.Windows.Forms.ColumnHeader UCICACION;
        private System.Windows.Forms.ColumnHeader ESTATUS;
        private System.Windows.Forms.ColumnHeader DEPARTAMENTO;
        private System.Windows.Forms.ColumnHeader FUNCIONAMIENTO;
        private System.Windows.Forms.ColumnHeader RIESGO;
        private System.Windows.Forms.ColumnHeader REFACCIONES;
        private System.Windows.Forms.ColumnHeader ACCESORIOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Mosbut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Identext;
        private System.Windows.Forms.Button Endbut;
        private System.Windows.Forms.Button Abut;
        private System.Windows.Forms.Button Rebut;
        private System.Windows.Forms.Button Busbut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Nombox;
    }
}