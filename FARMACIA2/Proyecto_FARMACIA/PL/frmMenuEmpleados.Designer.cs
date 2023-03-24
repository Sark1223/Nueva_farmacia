namespace Proyecto_FARMACIA.PL
{
    partial class frmMenuEmpleados
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
            this.Encabezado = new System.Windows.Forms.Panel();
            this.lblNomFarm = new System.Windows.Forms.Label();
            this.Encabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(125)))), ((int)(((byte)(164)))));
            this.Encabezado.Controls.Add(this.lblNomFarm);
            this.Encabezado.Location = new System.Drawing.Point(0, 0);
            this.Encabezado.Name = "Encabezado";
            this.Encabezado.Size = new System.Drawing.Size(801, 42);
            this.Encabezado.TabIndex = 5;
            // 
            // lblNomFarm
            // 
            this.lblNomFarm.AutoSize = true;
            this.lblNomFarm.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomFarm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNomFarm.Location = new System.Drawing.Point(3, 6);
            this.lblNomFarm.Name = "lblNomFarm";
            this.lblNomFarm.Size = new System.Drawing.Size(203, 31);
            this.lblNomFarm.TabIndex = 2;
            this.lblNomFarm.Text = "Farmacia Express";
            // 
            // frmMenuEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Encabezado);
            this.Name = "frmMenuEmpleados";
            this.Text = "frmMenuEmpleados";
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Encabezado;
        private System.Windows.Forms.Label lblNomFarm;
    }
}