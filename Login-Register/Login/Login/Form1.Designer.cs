namespace Login
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Registerbut = new System.Windows.Forms.Button();
            this.Loginbut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Passbox = new System.Windows.Forms.TextBox();
            this.Userbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Registerbut
            // 
            this.Registerbut.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbut.Location = new System.Drawing.Point(456, 312);
            this.Registerbut.Name = "Registerbut";
            this.Registerbut.Size = new System.Drawing.Size(111, 45);
            this.Registerbut.TabIndex = 12;
            this.Registerbut.Text = "Register";
            this.Registerbut.UseVisualStyleBackColor = true;
            this.Registerbut.Click += new System.EventHandler(this.Registerbut_Click);
            // 
            // Loginbut
            // 
            this.Loginbut.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbut.Location = new System.Drawing.Point(233, 312);
            this.Loginbut.Name = "Loginbut";
            this.Loginbut.Size = new System.Drawing.Size(111, 45);
            this.Loginbut.TabIndex = 11;
            this.Loginbut.Text = "Login";
            this.Loginbut.UseVisualStyleBackColor = true;
            this.Loginbut.Click += new System.EventHandler(this.Loginbut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Passbox
            // 
            this.Passbox.Location = new System.Drawing.Point(350, 237);
            this.Passbox.Name = "Passbox";
            this.Passbox.Size = new System.Drawing.Size(100, 20);
            this.Passbox.TabIndex = 9;
            this.Passbox.TextChanged += new System.EventHandler(this.Passbox_TextChanged);
            // 
            // Userbox
            // 
            this.Userbox.Location = new System.Drawing.Point(350, 131);
            this.Userbox.Name = "Userbox";
            this.Userbox.Size = new System.Drawing.Size(100, 20);
            this.Userbox.TabIndex = 8;
            this.Userbox.TextChanged += new System.EventHandler(this.Userbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "User\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Company García Ramos\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Registerbut);
            this.Controls.Add(this.Loginbut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Passbox);
            this.Controls.Add(this.Userbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Registerbut;
        private System.Windows.Forms.Button Loginbut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Passbox;
        private System.Windows.Forms.TextBox Userbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

