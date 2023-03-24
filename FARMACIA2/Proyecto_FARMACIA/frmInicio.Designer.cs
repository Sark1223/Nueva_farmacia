namespace Proyecto_FARMACIA
{
    partial class frmInicio
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
            this.Encabezado = new System.Windows.Forms.Panel();
            this.lblNomFarm = new System.Windows.Forms.Label();
            this.cuerpo = new System.Windows.Forms.Panel();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.icon_sesion = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Encabezado.SuspendLayout();
            this.cuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Encabezado
            // 
            this.Encabezado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Encabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(125)))), ((int)(((byte)(164)))));
            this.Encabezado.Controls.Add(this.pictureBox2);
            this.Encabezado.Controls.Add(this.lblNomFarm);
            this.Encabezado.Location = new System.Drawing.Point(0, 0);
            this.Encabezado.Name = "Encabezado";
            this.Encabezado.Size = new System.Drawing.Size(801, 42);
            this.Encabezado.TabIndex = 3;
            // 
            // lblNomFarm
            // 
            this.lblNomFarm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomFarm.AutoSize = true;
            this.lblNomFarm.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomFarm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNomFarm.Location = new System.Drawing.Point(3, 6);
            this.lblNomFarm.Name = "lblNomFarm";
            this.lblNomFarm.Size = new System.Drawing.Size(203, 31);
            this.lblNomFarm.TabIndex = 2;
            this.lblNomFarm.Text = "Farmacia Express";
            // 
            // cuerpo
            // 
            this.cuerpo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cuerpo.BackColor = System.Drawing.Color.White;
            this.cuerpo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cuerpo.Controls.Add(this.btnIniciarSesion);
            this.cuerpo.Controls.Add(this.txtContraseña);
            this.cuerpo.Controls.Add(this.txtUsuario);
            this.cuerpo.Controls.Add(this.pictureBox1);
            this.cuerpo.Controls.Add(this.icon_sesion);
            this.cuerpo.Location = new System.Drawing.Point(0, 40);
            this.cuerpo.Name = "cuerpo";
            this.cuerpo.Size = new System.Drawing.Size(800, 444);
            this.cuerpo.TabIndex = 4;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(125)))), ((int)(((byte)(164)))));
            this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(125)))), ((int)(((byte)(164)))));
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(153)))), ((int)(((byte)(191)))));
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIniciarSesion.Location = new System.Drawing.Point(332, 263);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(146, 41);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "INICIAR SESION";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.DarkGray;
            this.txtContraseña.Location = new System.Drawing.Point(279, 210);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(260, 32);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.Text = "Ingrese contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.Location = new System.Drawing.Point(279, 163);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(260, 32);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "Ingrese usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Proyecto_FARMACIA.Properties.Resources.usuario1;
            this.pictureBox1.Location = new System.Drawing.Point(363, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 81);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // icon_sesion
            // 
            this.icon_sesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icon_sesion.AutoSize = true;
            this.icon_sesion.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icon_sesion.Location = new System.Drawing.Point(284, 112);
            this.icon_sesion.Name = "icon_sesion";
            this.icon_sesion.Size = new System.Drawing.Size(245, 36);
            this.icon_sesion.TabIndex = 0;
            this.icon_sesion.Text = "INICIO DE SESION";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_FARMACIA.Properties.Resources.cerrar;
            this.pictureBox2.Location = new System.Drawing.Point(759, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.cuerpo);
            this.Controls.Add(this.Encabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.cuerpo.ResumeLayout(false);
            this.cuerpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Encabezado;
        private System.Windows.Forms.Label lblNomFarm;
        private System.Windows.Forms.Panel cuerpo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label icon_sesion;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

