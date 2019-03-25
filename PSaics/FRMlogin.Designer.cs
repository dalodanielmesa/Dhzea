namespace PSaics
{
    partial class FRMlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMlogin));
            this.TXTcontraseña = new System.Windows.Forms.TextBox();
            this.BTNiniciar = new System.Windows.Forms.Button();
            this.LBLusuario = new System.Windows.Forms.Label();
            this.LBLcontraseña = new System.Windows.Forms.Label();
            this.TXTusuario = new System.Windows.Forms.TextBox();
            this.LBLocontraseña = new System.Windows.Forms.Label();
            this.LBLrecuperar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTcontraseña
            // 
            this.TXTcontraseña.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTcontraseña.Location = new System.Drawing.Point(132, 283);
            this.TXTcontraseña.Name = "TXTcontraseña";
            this.TXTcontraseña.Size = new System.Drawing.Size(233, 30);
            this.TXTcontraseña.TabIndex = 3;
            this.TXTcontraseña.UseSystemPasswordChar = true;
            // 
            // BTNiniciar
            // 
            this.BTNiniciar.BackColor = System.Drawing.Color.Transparent;
            this.BTNiniciar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BTNiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(105)))), ((int)(((byte)(5)))));
            this.BTNiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BTNiniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNiniciar.Location = new System.Drawing.Point(201, 355);
            this.BTNiniciar.Name = "BTNiniciar";
            this.BTNiniciar.Size = new System.Drawing.Size(93, 44);
            this.BTNiniciar.TabIndex = 4;
            this.BTNiniciar.Text = "Iniciar";
            this.BTNiniciar.UseVisualStyleBackColor = false;
            this.BTNiniciar.Click += new System.EventHandler(this.BTNiniciar_Click);
            // 
            // LBLusuario
            // 
            this.LBLusuario.AutoSize = true;
            this.LBLusuario.BackColor = System.Drawing.Color.Transparent;
            this.LBLusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLusuario.Location = new System.Drawing.Point(123, 123);
            this.LBLusuario.Name = "LBLusuario";
            this.LBLusuario.Size = new System.Drawing.Size(64, 20);
            this.LBLusuario.TabIndex = 5;
            this.LBLusuario.Text = "Usuario";
            // 
            // LBLcontraseña
            // 
            this.LBLcontraseña.AutoSize = true;
            this.LBLcontraseña.BackColor = System.Drawing.Color.Transparent;
            this.LBLcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLcontraseña.Location = new System.Drawing.Point(110, 242);
            this.LBLcontraseña.Name = "LBLcontraseña";
            this.LBLcontraseña.Size = new System.Drawing.Size(92, 20);
            this.LBLcontraseña.TabIndex = 6;
            this.LBLcontraseña.Text = "Contraseña";
            // 
            // TXTusuario
            // 
            this.TXTusuario.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTusuario.Location = new System.Drawing.Point(132, 164);
            this.TXTusuario.Multiline = true;
            this.TXTusuario.Name = "TXTusuario";
            this.TXTusuario.Size = new System.Drawing.Size(233, 30);
            this.TXTusuario.TabIndex = 1;
            // 
            // LBLocontraseña
            // 
            this.LBLocontraseña.AutoSize = true;
            this.LBLocontraseña.BackColor = System.Drawing.Color.Transparent;
            this.LBLocontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLocontraseña.ForeColor = System.Drawing.Color.Red;
            this.LBLocontraseña.Location = new System.Drawing.Point(147, 336);
            this.LBLocontraseña.Name = "LBLocontraseña";
            this.LBLocontraseña.Size = new System.Drawing.Size(134, 16);
            this.LBLocontraseña.TabIndex = 8;
            this.LBLocontraseña.Text = "Olvide Mi contraseña";
            this.LBLocontraseña.Visible = false;
            // 
            // LBLrecuperar
            // 
            this.LBLrecuperar.AutoSize = true;
            this.LBLrecuperar.BackColor = System.Drawing.Color.Transparent;
            this.LBLrecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLrecuperar.ForeColor = System.Drawing.Color.Blue;
            this.LBLrecuperar.Location = new System.Drawing.Point(281, 336);
            this.LBLrecuperar.Name = "LBLrecuperar";
            this.LBLrecuperar.Size = new System.Drawing.Size(75, 16);
            this.LBLrecuperar.TabIndex = 9;
            this.LBLrecuperar.Text = "Recuperar.";
            this.LBLrecuperar.Visible = false;
            this.LBLrecuperar.Click += new System.EventHandler(this.LBLrecuperar_Click);
            // 
            // FRMlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 481);
            this.Controls.Add(this.LBLrecuperar);
            this.Controls.Add(this.LBLocontraseña);
            this.Controls.Add(this.LBLcontraseña);
            this.Controls.Add(this.LBLusuario);
            this.Controls.Add(this.BTNiniciar);
            this.Controls.Add(this.TXTcontraseña);
            this.Controls.Add(this.TXTusuario);
            this.DoubleBuffered = true;
            this.Name = "FRMlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTcontraseña;
        private System.Windows.Forms.Button BTNiniciar;
        private System.Windows.Forms.Label LBLusuario;
        private System.Windows.Forms.Label LBLcontraseña;
        private System.Windows.Forms.TextBox TXTusuario;
        private System.Windows.Forms.Label LBLocontraseña;
        private System.Windows.Forms.Label LBLrecuperar;
    }
}

