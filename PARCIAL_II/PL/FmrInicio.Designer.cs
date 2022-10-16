
namespace PARCIAL_II.PL
{
    partial class FmrInicio
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
            this.btnventamedicamento = new System.Windows.Forms.Button();
            this.btnmedicinatienda = new System.Windows.Forms.Button();
            this.btncompramedicinas = new System.Windows.Forms.Button();
            this.btnfarmaciasedes = new System.Windows.Forms.Button();
            this.btnInfoEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnventamedicamento
            // 
            this.btnventamedicamento.Location = new System.Drawing.Point(43, 181);
            this.btnventamedicamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnventamedicamento.Name = "btnventamedicamento";
            this.btnventamedicamento.Size = new System.Drawing.Size(140, 19);
            this.btnventamedicamento.TabIndex = 15;
            this.btnventamedicamento.Text = "Venta de Medicamentos";
            this.btnventamedicamento.UseVisualStyleBackColor = true;
            // 
            // btnmedicinatienda
            // 
            this.btnmedicinatienda.Location = new System.Drawing.Point(43, 140);
            this.btnmedicinatienda.Margin = new System.Windows.Forms.Padding(2);
            this.btnmedicinatienda.Name = "btnmedicinatienda";
            this.btnmedicinatienda.Size = new System.Drawing.Size(140, 19);
            this.btnmedicinatienda.TabIndex = 14;
            this.btnmedicinatienda.Text = "Medicamento en Tienda";
            this.btnmedicinatienda.UseVisualStyleBackColor = true;
            // 
            // btncompramedicinas
            // 
            this.btncompramedicinas.Location = new System.Drawing.Point(43, 100);
            this.btncompramedicinas.Margin = new System.Windows.Forms.Padding(2);
            this.btncompramedicinas.Name = "btncompramedicinas";
            this.btncompramedicinas.Size = new System.Drawing.Size(140, 19);
            this.btncompramedicinas.TabIndex = 13;
            this.btncompramedicinas.Text = "Compra de Medicamentos";
            this.btncompramedicinas.UseVisualStyleBackColor = true;
            // 
            // btnfarmaciasedes
            // 
            this.btnfarmaciasedes.Location = new System.Drawing.Point(43, 57);
            this.btnfarmaciasedes.Margin = new System.Windows.Forms.Padding(2);
            this.btnfarmaciasedes.Name = "btnfarmaciasedes";
            this.btnfarmaciasedes.Size = new System.Drawing.Size(140, 19);
            this.btnfarmaciasedes.TabIndex = 12;
            this.btnfarmaciasedes.Text = "Sedes de la farmacia";
            this.btnfarmaciasedes.UseVisualStyleBackColor = true;
            this.btnfarmaciasedes.Click += new System.EventHandler(this.btnfarmaciasedes_Click);
            // 
            // btnInfoEmpleados
            // 
            this.btnInfoEmpleados.Location = new System.Drawing.Point(43, 23);
            this.btnInfoEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.btnInfoEmpleados.Name = "btnInfoEmpleados";
            this.btnInfoEmpleados.Size = new System.Drawing.Size(140, 19);
            this.btnInfoEmpleados.TabIndex = 11;
            this.btnInfoEmpleados.Text = "Informacion Empleados";
            this.btnInfoEmpleados.UseVisualStyleBackColor = true;
            this.btnInfoEmpleados.Click += new System.EventHandler(this.btnInfoEmpleados_Click);
            // 
            // FmrInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 286);
            this.Controls.Add(this.btnventamedicamento);
            this.Controls.Add(this.btnmedicinatienda);
            this.Controls.Add(this.btncompramedicinas);
            this.Controls.Add(this.btnfarmaciasedes);
            this.Controls.Add(this.btnInfoEmpleados);
            this.Name = "FmrInicio";
            this.Text = "FmrInicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnventamedicamento;
        private System.Windows.Forms.Button btnmedicinatienda;
        private System.Windows.Forms.Button btncompramedicinas;
        private System.Windows.Forms.Button btnfarmaciasedes;
        private System.Windows.Forms.Button btnInfoEmpleados;
    }
}