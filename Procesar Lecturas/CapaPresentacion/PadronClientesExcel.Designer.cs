namespace CapaPresentacion
{
    partial class PadronClientesExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PadronClientesExcel));
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.chkLibres = new System.Windows.Forms.CheckBox();
            this.chkIlo = new System.Windows.Forms.CheckBox();
            this.chkMoquegua = new System.Windows.Forms.CheckBox();
            this.chkTacna = new System.Windows.Forms.CheckBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(130, 82);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 25;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(36, 82);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 24;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // chkLibres
            // 
            this.chkLibres.AutoSize = true;
            this.chkLibres.Location = new System.Drawing.Point(130, 59);
            this.chkLibres.Name = "chkLibres";
            this.chkLibres.Size = new System.Drawing.Size(54, 17);
            this.chkLibres.TabIndex = 23;
            this.chkLibres.Text = "Libres";
            this.chkLibres.UseVisualStyleBackColor = true;
            // 
            // chkIlo
            // 
            this.chkIlo.AutoSize = true;
            this.chkIlo.Location = new System.Drawing.Point(130, 36);
            this.chkIlo.Name = "chkIlo";
            this.chkIlo.Size = new System.Drawing.Size(37, 17);
            this.chkIlo.TabIndex = 22;
            this.chkIlo.Text = "Ilo";
            this.chkIlo.UseVisualStyleBackColor = true;
            // 
            // chkMoquegua
            // 
            this.chkMoquegua.AutoSize = true;
            this.chkMoquegua.Location = new System.Drawing.Point(44, 59);
            this.chkMoquegua.Name = "chkMoquegua";
            this.chkMoquegua.Size = new System.Drawing.Size(77, 17);
            this.chkMoquegua.TabIndex = 21;
            this.chkMoquegua.Text = "Moquegua";
            this.chkMoquegua.UseVisualStyleBackColor = true;
            // 
            // chkTacna
            // 
            this.chkTacna.AutoSize = true;
            this.chkTacna.Location = new System.Drawing.Point(45, 36);
            this.chkTacna.Name = "chkTacna";
            this.chkTacna.Size = new System.Drawing.Size(57, 17);
            this.chkTacna.TabIndex = 20;
            this.chkTacna.Text = "Tacna";
            this.chkTacna.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(96, 13);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Elija los Padrones :";
            // 
            // PadronClientesExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 114);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.chkLibres);
            this.Controls.Add(this.chkIlo);
            this.Controls.Add(this.chkMoquegua);
            this.Controls.Add(this.chkTacna);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PadronClientesExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar Padron de Clientes a Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancela;
        internal System.Windows.Forms.Button btnExportar;
        internal System.Windows.Forms.CheckBox chkLibres;
        internal System.Windows.Forms.CheckBox chkIlo;
        internal System.Windows.Forms.CheckBox chkMoquegua;
        internal System.Windows.Forms.CheckBox chkTacna;
        internal System.Windows.Forms.Label Label2;
    }
}