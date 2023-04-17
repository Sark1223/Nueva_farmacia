namespace Proyecto_FARMACIA.PL
{
    partial class frmAMedFarm
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmdCerrar = new System.Windows.Forms.PictureBox();
            this.cbFarmacia = new System.Windows.Forms.ComboBox();
            this.cbMedicamento = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCantidadE = new System.Windows.Forms.TextBox();
            this.lblCantidadE = new System.Windows.Forms.Label();
            this.lblFarmacia = new System.Windows.Forms.Label();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.PanelAñadir = new System.Windows.Forms.Panel();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.PanelModificar = new System.Windows.Forms.Panel();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).BeginInit();
            this.PanelAñadir.SuspendLayout();
            this.PanelModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(121)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(5, 252);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(332, 5);
            this.panel8.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(121)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 232);
            this.panel5.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(121)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(337, 25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 232);
            this.panel7.TabIndex = 14;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(121)))));
            this.Title.Controls.Add(this.lblTitle);
            this.Title.Controls.Add(this.cmdCerrar);
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(342, 25);
            this.Title.TabIndex = 13;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(63, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MODIFICAR CIUDAD";
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCerrar.Image = global::Proyecto_FARMACIA.Properties.Resources.iconCerrarblanco;
            this.cmdCerrar.Location = new System.Drawing.Point(316, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(23, 20);
            this.cmdCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdCerrar.TabIndex = 0;
            this.cmdCerrar.TabStop = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cbFarmacia
            // 
            this.cbFarmacia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFarmacia.FormattingEnabled = true;
            this.cbFarmacia.Location = new System.Drawing.Point(24, 52);
            this.cbFarmacia.Name = "cbFarmacia";
            this.cbFarmacia.Size = new System.Drawing.Size(145, 21);
            this.cbFarmacia.TabIndex = 1;
            this.cbFarmacia.SelectedIndexChanged += new System.EventHandler(this.cbFarmacia_SelectedIndexChanged);
            // 
            // cbMedicamento
            // 
            this.cbMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMedicamento.FormattingEnabled = true;
            this.cbMedicamento.Location = new System.Drawing.Point(24, 103);
            this.cbMedicamento.Name = "cbMedicamento";
            this.cbMedicamento.Size = new System.Drawing.Size(145, 21);
            this.cbMedicamento.TabIndex = 3;
            this.cbMedicamento.SelectedIndexChanged += new System.EventHandler(this.cbMedicamento_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(30, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 1);
            this.panel2.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecio.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.txtPrecio.Location = new System.Drawing.Point(32, 152);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(104, 19);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.Text = "122354";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPrecio.Location = new System.Drawing.Point(27, 135);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 17);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(30, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 1);
            this.panel1.TabIndex = 9;
            // 
            // txtCantidadE
            // 
            this.txtCantidadE.BackColor = System.Drawing.Color.White;
            this.txtCantidadE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidadE.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.txtCantidadE.Location = new System.Drawing.Point(32, 205);
            this.txtCantidadE.Name = "txtCantidadE";
            this.txtCantidadE.Size = new System.Drawing.Size(104, 19);
            this.txtCantidadE.TabIndex = 8;
            this.txtCantidadE.Text = "122354";
            // 
            // lblCantidadE
            // 
            this.lblCantidadE.AutoSize = true;
            this.lblCantidadE.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadE.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCantidadE.Location = new System.Drawing.Point(27, 188);
            this.lblCantidadE.Name = "lblCantidadE";
            this.lblCantidadE.Size = new System.Drawing.Size(120, 17);
            this.lblCantidadE.TabIndex = 7;
            this.lblCantidadE.Text = "Cantidad Existente";
            this.lblCantidadE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFarmacia
            // 
            this.lblFarmacia.AutoSize = true;
            this.lblFarmacia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarmacia.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFarmacia.Location = new System.Drawing.Point(21, 32);
            this.lblFarmacia.Name = "lblFarmacia";
            this.lblFarmacia.Size = new System.Drawing.Size(64, 17);
            this.lblFarmacia.TabIndex = 0;
            this.lblFarmacia.Text = "Farmacia";
            this.lblFarmacia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamento.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMedicamento.Location = new System.Drawing.Point(21, 83);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(93, 17);
            this.lblMedicamento.TabIndex = 2;
            this.lblMedicamento.Text = "Medicamento";
            this.lblMedicamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelAñadir
            // 
            this.PanelAñadir.Controls.Add(this.cmdLimpiar);
            this.PanelAñadir.Controls.Add(this.cmdAgregar);
            this.PanelAñadir.Location = new System.Drawing.Point(189, 81);
            this.PanelAñadir.Name = "PanelAñadir";
            this.PanelAñadir.Size = new System.Drawing.Size(124, 123);
            this.PanelAñadir.TabIndex = 10;
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.BackColor = System.Drawing.Color.LightCoral;
            this.cmdLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdLimpiar.FlatAppearance.BorderSize = 2;
            this.cmdLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.cmdLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.ForeColor = System.Drawing.Color.White;
            this.cmdLimpiar.Location = new System.Drawing.Point(9, 77);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(103, 31);
            this.cmdLimpiar.TabIndex = 1;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = false;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdAgregar.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.cmdAgregar.FlatAppearance.BorderSize = 2;
            this.cmdAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.cmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.ForeColor = System.Drawing.Color.Maroon;
            this.cmdAgregar.Location = new System.Drawing.Point(9, 10);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(103, 31);
            this.cmdAgregar.TabIndex = 0;
            this.cmdAgregar.Text = "Añadir";
            this.cmdAgregar.UseVisualStyleBackColor = false;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // PanelModificar
            // 
            this.PanelModificar.Controls.Add(this.cmdCancelar);
            this.PanelModificar.Controls.Add(this.cmdEliminar);
            this.PanelModificar.Controls.Add(this.cmdModificar);
            this.PanelModificar.Location = new System.Drawing.Point(193, 57);
            this.PanelModificar.Name = "PanelModificar";
            this.PanelModificar.Size = new System.Drawing.Size(123, 157);
            this.PanelModificar.TabIndex = 11;
            this.PanelModificar.Visible = false;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.White;
            this.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.cmdCancelar.FlatAppearance.BorderSize = 2;
            this.cmdCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.Color.LightCoral;
            this.cmdCancelar.Location = new System.Drawing.Point(8, 108);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(107, 31);
            this.cmdCancelar.TabIndex = 2;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.cmdEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.cmdEliminar.FlatAppearance.BorderSize = 2;
            this.cmdEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.ForeColor = System.Drawing.Color.White;
            this.cmdEliminar.Location = new System.Drawing.Point(8, 60);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(107, 31);
            this.cmdEliminar.TabIndex = 1;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = false;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdModificar.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.cmdModificar.FlatAppearance.BorderSize = 2;
            this.cmdModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.cmdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.ForeColor = System.Drawing.Color.Maroon;
            this.cmdModificar.Location = new System.Drawing.Point(8, 7);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(107, 31);
            this.cmdModificar.TabIndex = 0;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = false;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // frmAMedFarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cmdCancelar;
            this.ClientSize = new System.Drawing.Size(342, 257);
            this.Controls.Add(this.PanelModificar);
            this.Controls.Add(this.PanelAñadir);
            this.Controls.Add(this.lblMedicamento);
            this.Controls.Add(this.lblFarmacia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCantidadE);
            this.Controls.Add(this.lblCantidadE);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cbMedicamento);
            this.Controls.Add(this.cbFarmacia);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAMedFarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMedFarm";
            this.Load += new System.EventHandler(this.frmAMedFarm_Load);
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).EndInit();
            this.PanelAñadir.ResumeLayout(false);
            this.PanelModificar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Panel Title;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.PictureBox cmdCerrar;
        public System.Windows.Forms.ComboBox cbFarmacia;
        public System.Windows.Forms.ComboBox cbMedicamento;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.Label lblPrecio;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtCantidadE;
        public System.Windows.Forms.Label lblCantidadE;
        public System.Windows.Forms.Label lblFarmacia;
        public System.Windows.Forms.Label lblMedicamento;
        public System.Windows.Forms.Panel PanelAñadir;
        public System.Windows.Forms.Button cmdLimpiar;
        public System.Windows.Forms.Button cmdAgregar;
        public System.Windows.Forms.Panel PanelModificar;
        public System.Windows.Forms.Button cmdCancelar;
        public System.Windows.Forms.Button cmdEliminar;
        public System.Windows.Forms.Button cmdModificar;
    }
}