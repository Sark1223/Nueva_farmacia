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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.dgvCiudades = new System.Windows.Forms.DataGridView();
            this.cmdRefrescar = new System.Windows.Forms.PictureBox();
            this.cmdAgregar = new System.Windows.Forms.PictureBox();
            this.HoverControl = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdRefrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAgregar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCiudad
            // 
            this.lblCiudad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(308, 4);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(169, 31);
            this.lblCiudad.TabIndex = 8;
            this.lblCiudad.Text = "CIUDADES";
            // 
            // dgvCiudades
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCiudades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCiudades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCiudades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCiudades.BackgroundColor = System.Drawing.Color.White;
            this.dgvCiudades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCiudades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCiudades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCiudades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCiudades.ColumnHeadersHeight = 30;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(142)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCiudades.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCiudades.EnableHeadersVisualStyles = false;
            this.dgvCiudades.Location = new System.Drawing.Point(15, 63);
            this.dgvCiudades.Name = "dgvCiudades";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(88)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCiudades.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCiudades.RowHeadersVisible = false;
            this.dgvCiudades.RowHeadersWidth = 30;
            this.dgvCiudades.RowTemplate.Height = 30;
            this.dgvCiudades.Size = new System.Drawing.Size(748, 422);
            this.dgvCiudades.TabIndex = 28;
            this.dgvCiudades.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SeleccionarDK);
            // 
            // cmdRefrescar
            // 
            this.cmdRefrescar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdRefrescar.Image = global::Proyecto_FARMACIA.Properties.Resources.actualizar;
            this.cmdRefrescar.Location = new System.Drawing.Point(724, 25);
            this.cmdRefrescar.Name = "cmdRefrescar";
            this.cmdRefrescar.Size = new System.Drawing.Size(39, 33);
            this.cmdRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdRefrescar.TabIndex = 32;
            this.cmdRefrescar.TabStop = false;
            this.HoverControl.SetToolTip(this.cmdRefrescar, "Actualizar tabla");
            this.cmdRefrescar.Click += new System.EventHandler(this.pbRefrescar_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Image = global::Proyecto_FARMACIA.Properties.Resources.add;
            this.cmdAgregar.Location = new System.Drawing.Point(15, 15);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(39, 41);
            this.cmdAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdAgregar.TabIndex = 33;
            this.cmdAgregar.TabStop = false;
            this.HoverControl.SetToolTip(this.cmdAgregar, "Agregar una nueva CIUDAD");
            this.cmdAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.cmdAgregar);
            this.panel1.Controls.Add(this.lblCiudad);
            this.panel1.Controls.Add(this.cmdRefrescar);
            this.panel1.Controls.Add(this.dgvCiudades);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 509);
            this.panel1.TabIndex = 34;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombre.Location = new System.Drawing.Point(118, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(538, 17);
            this.lblNombre.TabIndex = 34;
            this.lblNombre.Text = "Para MODIFICAR o ELIMINAR cualquier REGRISTRO haga doble click sobre el mismo";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCiudad";
            this.Text = "frmCiudad";
            this.Load += new System.EventHandler(this.frmCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdRefrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAgregar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblCiudad;
        public System.Windows.Forms.DataGridView dgvCiudades;
        public System.Windows.Forms.PictureBox cmdRefrescar;
        public System.Windows.Forms.PictureBox cmdAgregar;
        public System.Windows.Forms.ToolTip HoverControl;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblNombre;
    }
}