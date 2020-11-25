
namespace Proyecto_Final
{
    partial class Form6
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
            System.Windows.Forms.ListViewGroup listViewGroup81 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup82 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup83 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup84 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup85 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup86 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup87 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup88 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup89 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup90 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Nombox = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(998, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 50;
            this.label6.Text = "Estatus";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(932, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 49;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            listViewGroup81.Header = "ListViewGroup";
            listViewGroup81.Name = "ID";
            listViewGroup82.Header = "ListViewGroup";
            listViewGroup82.Name = "Descripcion";
            listViewGroup83.Header = "ListViewGroup";
            listViewGroup83.Name = "Marca";
            listViewGroup84.Header = "ListViewGroup";
            listViewGroup84.Name = "Serie";
            listViewGroup85.Header = "ListViewGroup";
            listViewGroup85.Name = "Ubicacion";
            listViewGroup86.Header = "ListViewGroup";
            listViewGroup86.Name = "Departamento";
            listViewGroup87.Header = "ListViewGroup";
            listViewGroup87.Name = "Funcionamiento";
            listViewGroup88.Header = "ListViewGroup";
            listViewGroup88.Name = "Riesgo";
            listViewGroup89.Header = "ListViewGroup";
            listViewGroup89.Name = "Cantidad de refacciones ";
            listViewGroup90.Header = "ListViewGroup";
            listViewGroup90.Name = "Accesorios";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup81,
            listViewGroup82,
            listViewGroup83,
            listViewGroup84,
            listViewGroup85,
            listViewGroup86,
            listViewGroup87,
            listViewGroup88,
            listViewGroup89,
            listViewGroup90});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1197, 414);
            this.listView1.TabIndex = 48;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(679, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ubicación";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 22);
            this.label4.TabIndex = 46;
            this.label4.Text = "Nombre del equipo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(294, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 45;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nombox
            // 
            this.Nombox.Location = new System.Drawing.Point(614, 45);
            this.Nombox.Name = "Nombox";
            this.Nombox.Size = new System.Drawing.Size(212, 20);
            this.Nombox.TabIndex = 44;
            this.Nombox.TextChanged += new System.EventHandler(this.Nombox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "Cardiología";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Company García Ramos\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1231, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 38);
            this.button1.TabIndex = 58;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mosbut
            // 
            this.Mosbut.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mosbut.Location = new System.Drawing.Point(1231, 240);
            this.Mosbut.Name = "Mosbut";
            this.Mosbut.Size = new System.Drawing.Size(113, 38);
            this.Mosbut.TabIndex = 57;
            this.Mosbut.Text = "Mostrar";
            this.Mosbut.UseVisualStyleBackColor = true;
            this.Mosbut.Click += new System.EventHandler(this.Mosbut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1232, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 56;
            this.label3.Text = "ID del equipo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Identext
            // 
            this.Identext.Location = new System.Drawing.Point(1231, 42);
            this.Identext.Name = "Identext";
            this.Identext.Size = new System.Drawing.Size(113, 20);
            this.Identext.TabIndex = 55;
            this.Identext.TextChanged += new System.EventHandler(this.Identext_TextChanged);
            // 
            // Endbut
            // 
            this.Endbut.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Endbut.Location = new System.Drawing.Point(1231, 425);
            this.Endbut.Name = "Endbut";
            this.Endbut.Size = new System.Drawing.Size(113, 38);
            this.Endbut.TabIndex = 54;
            this.Endbut.Text = "Salir";
            this.Endbut.UseVisualStyleBackColor = true;
            this.Endbut.Click += new System.EventHandler(this.Endbut_Click);
            // 
            // Abut
            // 
            this.Abut.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Abut.Location = new System.Drawing.Point(1231, 301);
            this.Abut.Name = "Abut";
            this.Abut.Size = new System.Drawing.Size(113, 38);
            this.Abut.TabIndex = 53;
            this.Abut.Text = "Actualizar ";
            this.Abut.UseVisualStyleBackColor = true;
            this.Abut.Click += new System.EventHandler(this.Abut_Click);
            // 
            // Rebut
            // 
            this.Rebut.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rebut.Location = new System.Drawing.Point(1231, 363);
            this.Rebut.Name = "Rebut";
            this.Rebut.Size = new System.Drawing.Size(113, 38);
            this.Rebut.TabIndex = 52;
            this.Rebut.Text = "Regresar";
            this.Rebut.UseVisualStyleBackColor = true;
            this.Rebut.Click += new System.EventHandler(this.Rebut_Click);
            // 
            // Busbut
            // 
            this.Busbut.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Busbut.Location = new System.Drawing.Point(1231, 123);
            this.Busbut.Name = "Busbut";
            this.Busbut.Size = new System.Drawing.Size(113, 38);
            this.Busbut.TabIndex = 51;
            this.Busbut.Text = "Buscar";
            this.Busbut.UseVisualStyleBackColor = true;
            this.Busbut.Click += new System.EventHandler(this.Busbut_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mosbut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Identext);
            this.Controls.Add(this.Endbut);
            this.Controls.Add(this.Abut);
            this.Controls.Add(this.Rebut);
            this.Controls.Add(this.Busbut);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Nombox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Nombox;
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
    }
}