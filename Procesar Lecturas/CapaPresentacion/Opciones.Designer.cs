namespace CapaPresentacion
{
    partial class Opciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opciones));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.rbnNo = new System.Windows.Forms.RadioButton();
            this.rbnSi = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(144, 40);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 39);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(49, 40);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 39);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // rbnNo
            // 
            this.rbnNo.AutoSize = true;
            this.rbnNo.Location = new System.Drawing.Point(207, 7);
            this.rbnNo.Name = "rbnNo";
            this.rbnNo.Size = new System.Drawing.Size(39, 17);
            this.rbnNo.TabIndex = 7;
            this.rbnNo.TabStop = true;
            this.rbnNo.Text = "No";
            this.rbnNo.UseVisualStyleBackColor = true;
            // 
            // rbnSi
            // 
            this.rbnSi.AutoSize = true;
            this.rbnSi.Location = new System.Drawing.Point(167, 7);
            this.rbnSi.Name = "rbnSi";
            this.rbnSi.Size = new System.Drawing.Size(34, 17);
            this.rbnSi.TabIndex = 6;
            this.rbnSi.TabStop = true;
            this.rbnSi.Text = "Si";
            this.rbnSi.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(139, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Guardar en Base de Datos: ";
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 87);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rbnNo);
            this.Controls.Add(this.rbnSi);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Opciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones del Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.RadioButton rbnNo;
        internal System.Windows.Forms.RadioButton rbnSi;
        internal System.Windows.Forms.Label Label1;
    }
}