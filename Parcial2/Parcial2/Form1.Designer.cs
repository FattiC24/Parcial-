namespace Parcial2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbBeneficiario = new System.Windows.Forms.Label();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lbNoEresBeneficiario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Aquí";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(101, 285);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(87, 25);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            this.lbNombre.Visible = false;
            // 
            // lbBeneficiario
            // 
            this.lbBeneficiario.AutoSize = true;
            this.lbBeneficiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBeneficiario.Location = new System.Drawing.Point(262, 274);
            this.lbBeneficiario.Name = "lbBeneficiario";
            this.lbBeneficiario.Size = new System.Drawing.Size(291, 25);
            this.lbBeneficiario.TabIndex = 2;
            this.lbBeneficiario.Text = "Eres beneficiario de los $300";
            this.lbBeneficiario.Visible = false;
            // 
            // txtConsultar
            // 
            this.txtConsultar.Location = new System.Drawing.Point(228, 124);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(314, 20);
            this.txtConsultar.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(275, 176);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(220, 66);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consulta";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(646, 375);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(129, 51);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lbNoEresBeneficiario
            // 
            this.lbNoEresBeneficiario.AutoSize = true;
            this.lbNoEresBeneficiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoEresBeneficiario.Location = new System.Drawing.Point(298, 311);
            this.lbNoEresBeneficiario.Name = "lbNoEresBeneficiario";
            this.lbNoEresBeneficiario.Size = new System.Drawing.Size(204, 25);
            this.lbNoEresBeneficiario.TabIndex = 6;
            this.lbNoEresBeneficiario.Text = "No eres beneficiario";
            this.lbNoEresBeneficiario.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbNoEresBeneficiario);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.lbBeneficiario);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbBeneficiario;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lbNoEresBeneficiario;
    }
}

