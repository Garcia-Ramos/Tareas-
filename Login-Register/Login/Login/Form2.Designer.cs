namespace LOGIN
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
            this.Registerbut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Passbox = new System.Windows.Forms.TextBox();
            this.Userbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Company García Ramos\r\n";
            // 
            // Registerbut
            // 
            this.Registerbut.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbut.Location = new System.Drawing.Point(350, 341);
            this.Registerbut.Name = "Registerbut";
            this.Registerbut.Size = new System.Drawing.Size(111, 45);
            this.Registerbut.TabIndex = 19;
            this.Registerbut.Text = "Register";
            this.Registerbut.UseVisualStyleBackColor = true;
            this.Registerbut.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password\r\n";
            // 
            // Passbox
            // 
            this.Passbox.Location = new System.Drawing.Point(350, 264);
            this.Passbox.Name = "Passbox";
            this.Passbox.Size = new System.Drawing.Size(100, 20);
            this.Passbox.TabIndex = 16;
            // 
            // Userbox
            // 
            this.Userbox.Location = new System.Drawing.Point(350, 158);
            this.Userbox.Name = "Userbox";
            this.Userbox.Size = new System.Drawing.Size(100, 20);
            this.Userbox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "User\r\n";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Registerbut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Passbox);
            this.Controls.Add(this.Userbox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Registerbut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Passbox;
        private System.Windows.Forms.TextBox Userbox;
        private System.Windows.Forms.Label label1;
    }
}