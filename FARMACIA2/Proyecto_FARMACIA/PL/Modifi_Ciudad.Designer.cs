namespace Proyecto_FARMACIA.PL
{
    partial class frmModifi_Ciudad
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
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.linea = new System.Windows.Forms.Panel();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblTamaño = new System.Windows.Forms.Label();
            this.lblHabitantes = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(121)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(5, 240);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(340, 5);
            this.panel8.TabIndex = 49;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(121)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 220);
            this.panel5.TabIndex = 48;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(121)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(345, 25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 220);
            this.panel7.TabIndex = 47;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(100)))), ((int)(((byte)(121)))));
            this.Title.Controls.Add(this.lblTitle);
            this.Title.Controls.Add(this.cmdCerrar);
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(350, 25);
            this.Title.TabIndex = 46;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(88, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 21);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "AÑADIR CIUDAD";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCerrar.Image = global::Proyecto_FARMACIA.Properties.Resources.iconCerrarblanco;
            this.cmdCerrar.Location = new System.Drawing.Point(324, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(23, 20);
            this.cmdCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdCerrar.TabIndex = 0;
            this.cmdCerrar.TabStop = false;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
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
            this.cmdEliminar.Location = new System.Drawing.Point(139, 187);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(91, 31);
            this.cmdEliminar.TabIndex = 69;
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
            this.cmdModificar.Location = new System.Drawing.Point(14, 187);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(107, 31);
            this.cmdModificar.TabIndex = 68;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = false;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // linea
            // 
            this.linea.BackColor = System.Drawing.Color.IndianRed;
            this.linea.Location = new System.Drawing.Point(148, 168);
            this.linea.Name = "linea";
            this.linea.Size = new System.Drawing.Size(114, 1);
            this.linea.TabIndex = 67;
            // 
            // txtTamaño
            // 
            this.txtTamaño.BackColor = System.Drawing.Color.White;
            this.txtTamaño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTamaño.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTamaño.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamaño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.txtTamaño.Location = new System.Drawing.Point(152, 144);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(110, 19);
            this.txtTamaño.TabIndex = 66;
            this.txtTamaño.Text = "TIJUANA";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.IndianRed;
            this.panel6.Location = new System.Drawing.Point(15, 168);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(114, 1);
            this.panel6.TabIndex = 65;
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.BackColor = System.Drawing.Color.White;
            this.txtPoblacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPoblacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPoblacion.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoblacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.txtPoblacion.Location = new System.Drawing.Point(19, 144);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(110, 19);
            this.txtPoblacion.TabIndex = 64;
            this.txtPoblacion.Text = "TIJUANA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(182, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 1);
            this.panel1.TabIndex = 63;
            // 
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.Color.White;
            this.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.txtPais.Location = new System.Drawing.Point(188, 95);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(142, 19);
            this.txtPais.TabIndex = 62;
            this.txtPais.Text = "TIJUANA";
            // 
            // lblTamaño
            // 
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamaño.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTamaño.Location = new System.Drawing.Point(145, 129);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(135, 17);
            this.lblTamaño.TabIndex = 61;
            this.lblTamaño.Text = "Tamaño de superficie";
            this.lblTamaño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHabitantes
            // 
            this.lblHabitantes.AutoSize = true;
            this.lblHabitantes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitantes.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHabitantes.Location = new System.Drawing.Point(12, 129);
            this.lblHabitantes.Name = "lblHabitantes";
            this.lblHabitantes.Size = new System.Drawing.Size(114, 17);
            this.lblHabitantes.TabIndex = 60;
            this.lblHabitantes.Text = "No. de habitantes";
            this.lblHabitantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblPais.Location = new System.Drawing.Point(179, 78);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(31, 17);
            this.lblPais.TabIndex = 59;
            this.lblPais.Text = "Pais";
            this.lblPais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(15, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 1);
            this.panel4.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(143, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 1);
            this.panel3.TabIndex = 57;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(15, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 1);
            this.panel2.TabIndex = 50;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.txtEstado.Location = new System.Drawing.Point(19, 95);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(148, 19);
            this.txtEstado.TabIndex = 56;
            this.txtEstado.Text = "TIJUANA";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblEstado.Location = new System.Drawing.Point(12, 78);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 17);
            this.lblEstado.TabIndex = 55;
            this.lblEstado.Text = "Estado";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.txtNombre.Location = new System.Drawing.Point(146, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(187, 19);
            this.txtNombre.TabIndex = 54;
            this.txtNombre.Text = "TIJUANA";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(86)))), ((int)(((byte)(107)))));
            this.txtId.Location = new System.Drawing.Point(19, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(104, 19);
            this.txtId.TabIndex = 53;
            this.txtId.Text = "122354";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNombre.Location = new System.Drawing.Point(140, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(135, 17);
            this.lblNombre.TabIndex = 52;
            this.lblNombre.Text = "Nombre de la Ciudad";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCiudad.Location = new System.Drawing.Point(12, 28);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(68, 17);
            this.lblCiudad.TabIndex = 51;
            this.lblCiudad.Text = "Id_Ciudad";
            this.lblCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.BackColor = System.Drawing.Color.White;
            this.cmdCancelar.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.cmdCancelar.FlatAppearance.BorderSize = 2;
            this.cmdCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.Color.LightCoral;
            this.cmdCancelar.Location = new System.Drawing.Point(247, 187);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(91, 31);
            this.cmdCancelar.TabIndex = 70;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            this.cmdCancelar.MouseLeave += new System.EventHandler(this.cmdCancelar_MouseLeave);
            this.cmdCancelar.MouseHover += new System.EventHandler(this.cmdCancelar_MouseHover);
            // 
            // frmModifi_Ciudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 245);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.linea);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtPoblacion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblTamaño);
            this.Controls.Add(this.lblHabitantes);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModifi_Ciudad";
            this.Text = "Modifi_Ciudad";
            this.Title.ResumeLayout(false);
            this.Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Panel Title;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.PictureBox cmdCerrar;
        public System.Windows.Forms.Button cmdEliminar;
        public System.Windows.Forms.Button cmdModificar;
        public System.Windows.Forms.Panel linea;
        public System.Windows.Forms.TextBox txtTamaño;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TextBox txtPoblacion;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtPais;
        public System.Windows.Forms.Label lblTamaño;
        public System.Windows.Forms.Label lblHabitantes;
        public System.Windows.Forms.Label lblPais;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtEstado;
        public System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.Label lblCiudad;
        public System.Windows.Forms.Button cmdCancelar;
    }
}