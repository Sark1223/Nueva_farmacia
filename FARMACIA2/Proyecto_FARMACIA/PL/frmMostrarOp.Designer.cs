namespace Proyecto_FARMACIA.PL
{
    partial class frmMostrarOp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.dgvTablaDB = new System.Windows.Forms.DataGridView();
            this.HoverControl = new System.Windows.Forms.ToolTip(this.components);
            this.cmdAgregar = new System.Windows.Forms.PictureBox();
            this.cmdRefrescar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdBuscar = new System.Windows.Forms.PictureBox();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdRefrescar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpcion
            // 
            this.lblOpcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.Location = new System.Drawing.Point(308, 4);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(169, 31);
            this.lblOpcion.TabIndex = 8;
            this.lblOpcion.Text = "CIUDADES";
            // 
            // dgvTablaDB
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTablaDB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTablaDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTablaDB.BackgroundColor = System.Drawing.Color.White;
            this.dgvTablaDB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTablaDB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTablaDB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTablaDB.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(142)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaDB.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTablaDB.EnableHeadersVisualStyles = false;
            this.dgvTablaDB.Location = new System.Drawing.Point(15, 63);
            this.dgvTablaDB.Name = "dgvTablaDB";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(88)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaDB.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTablaDB.RowHeadersVisible = false;
            this.dgvTablaDB.RowHeadersWidth = 30;
            this.dgvTablaDB.RowTemplate.Height = 30;
            this.dgvTablaDB.Size = new System.Drawing.Size(748, 422);
            this.dgvTablaDB.TabIndex = 28;
            this.dgvTablaDB.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MODIFICAR_DobleClick_Registro);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Image = global::Proyecto_FARMACIA.Properties.Resources.add;
            this.cmdAgregar.Location = new System.Drawing.Point(724, 22);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(39, 41);
            this.cmdAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdAgregar.TabIndex = 33;
            this.cmdAgregar.TabStop = false;
            this.HoverControl.SetToolTip(this.cmdAgregar, "Agregar una nueva CIUDAD");
            this.cmdAgregar.Click += new System.EventHandler(this.AGREGAR_Click);
            // 
            // cmdRefrescar
            // 
            this.cmdRefrescar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdRefrescar.Image = global::Proyecto_FARMACIA.Properties.Resources.actualizar;
            this.cmdRefrescar.Location = new System.Drawing.Point(15, 25);
            this.cmdRefrescar.Name = "cmdRefrescar";
            this.cmdRefrescar.Size = new System.Drawing.Size(39, 33);
            this.cmdRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdRefrescar.TabIndex = 32;
            this.cmdRefrescar.TabStop = false;
            this.HoverControl.SetToolTip(this.cmdRefrescar, "Actualizar tabla");
            this.cmdRefrescar.Click += new System.EventHandler(this.REFRESCAR_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.cmdBuscar);
            this.panel1.Controls.Add(this.lblInstrucciones);
            this.panel1.Controls.Add(this.cmdAgregar);
            this.panel1.Controls.Add(this.lblOpcion);
            this.panel1.Controls.Add(this.cmdRefrescar);
            this.panel1.Controls.Add(this.dgvTablaDB);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 509);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Image = global::Proyecto_FARMACIA.Properties.Resources.lupa;
            this.cmdBuscar.Location = new System.Drawing.Point(687, 25);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(36, 33);
            this.cmdBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdBuscar.TabIndex = 35;
            this.cmdBuscar.TabStop = false;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.ForeColor = System.Drawing.Color.DimGray;
            this.lblInstrucciones.Location = new System.Drawing.Point(118, 37);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(538, 17);
            this.lblInstrucciones.TabIndex = 34;
            this.lblInstrucciones.Text = "Para MODIFICAR o ELIMINAR cualquier REGRISTRO haga doble click sobre el mismo";
            this.lblInstrucciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMostrarOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMostrarOp";
            this.Text = "opAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdRefrescar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblOpcion;
        public System.Windows.Forms.DataGridView dgvTablaDB;
        public System.Windows.Forms.PictureBox cmdRefrescar;
        public System.Windows.Forms.PictureBox cmdAgregar;
        public System.Windows.Forms.ToolTip HoverControl;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.PictureBox cmdBuscar;
    }
}