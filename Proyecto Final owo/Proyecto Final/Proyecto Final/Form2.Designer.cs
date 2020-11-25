
namespace Proyecto_Final
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.Pediatriabut = new System.Windows.Forms.Button();
            this.Traobut = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Imabut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Company García Ramos\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Pediatriabut
            // 
            this.Pediatriabut.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pediatriabut.Location = new System.Drawing.Point(43, 141);
            this.Pediatriabut.Name = "Pediatriabut";
            this.Pediatriabut.Size = new System.Drawing.Size(177, 75);
            this.Pediatriabut.TabIndex = 21;
            this.Pediatriabut.Text = "Pediatría";
            this.Pediatriabut.UseVisualStyleBackColor = true;
            this.Pediatriabut.Click += new System.EventHandler(this.Pediatriabut_Click);
            // 
            // Traobut
            // 
            this.Traobut.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Traobut.Location = new System.Drawing.Point(287, 141);
            this.Traobut.Name = "Traobut";
            this.Traobut.Size = new System.Drawing.Size(177, 75);
            this.Traobut.TabIndex = 22;
            this.Traobut.Text = "Traumatología y ortopedia";
            this.Traobut.UseVisualStyleBackColor = true;
            this.Traobut.Click += new System.EventHandler(this.Traobut_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(287, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 75);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cardiología";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Imabut
            // 
            this.Imabut.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imabut.Location = new System.Drawing.Point(43, 243);
            this.Imabut.Name = "Imabut";
            this.Imabut.Size = new System.Drawing.Size(177, 75);
            this.Imabut.TabIndex = 24;
            this.Imabut.Text = "Imagenología";
            this.Imabut.UseVisualStyleBackColor = true;
            this.Imabut.Click += new System.EventHandler(this.Imabut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Especialidades";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Imabut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Traobut);
            this.Controls.Add(this.Pediatriabut);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Pediatriabut;
        private System.Windows.Forms.Button Traobut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Imabut;
        private System.Windows.Forms.Label label1;
    }
}