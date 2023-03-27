namespace Proyecto_FARMACIA.PL
{
    partial class frmCiudad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.dgvCiudades = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCiudad
            // 
            this.lblCiudad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(305, 20);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(169, 31);
            this.lblCiudad.TabIndex = 8;
            this.lblCiudad.Text = "CIUDADES";
            // 
            // dgvCiudades
            // 
            this.dgvCiudades.BackgroundColor = System.Drawing.Color.White;
            this.dgvCiudades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCiudades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiudades.Location = new System.Drawing.Point(12, 78);
            this.dgvCiudades.Name = "dgvCiudades";
            this.dgvCiudades.RowHeadersWidth = 62;
            this.dgvCiudades.Size = new System.Drawing.Size(643, 338);
            this.dgvCiudades.TabIndex = 28;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Image = global::Proyecto_FARMACIA.Properties.Resources.add;
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(43, 42);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAgregar
            // 
            this.lblAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregar.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAgregar.Location = new System.Drawing.Point(0, 48);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(50, 16);
            this.lblAgregar.TabIndex = 30;
            this.lblAgregar.Text = "AÑADIR";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.lblAgregar);
            this.panel1.Location = new System.Drawing.Point(710, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 70);
            this.panel1.TabIndex = 31;
            // 
            // frmCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCiudades);
            this.Controls.Add(this.lblCiudad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCiudad";
            this.Text = "frmCiudad";
            this.Load += new System.EventHandler(this.frmCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.DataGridView dgvCiudades;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Panel panel1;
    }
}