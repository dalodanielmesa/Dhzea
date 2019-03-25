namespace PSaics.Vista
{
    partial class FRMbusqueda
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
            this.TXTbusqueda = new System.Windows.Forms.TextBox();
            this.LBLdocumento = new System.Windows.Forms.Label();
            this.BTNbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTbusqueda
            // 
            this.TXTbusqueda.Location = new System.Drawing.Point(89, 88);
            this.TXTbusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TXTbusqueda.Name = "TXTbusqueda";
            this.TXTbusqueda.Size = new System.Drawing.Size(116, 23);
            this.TXTbusqueda.TabIndex = 0;
            // 
            // LBLdocumento
            // 
            this.LBLdocumento.AutoSize = true;
            this.LBLdocumento.Location = new System.Drawing.Point(86, 68);
            this.LBLdocumento.Name = "LBLdocumento";
            this.LBLdocumento.Size = new System.Drawing.Size(77, 16);
            this.LBLdocumento.TabIndex = 1;
            this.LBLdocumento.Text = "Documento:";
            // 
            // BTNbuscar
            // 
            this.BTNbuscar.Location = new System.Drawing.Point(103, 138);
            this.BTNbuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTNbuscar.Name = "BTNbuscar";
            this.BTNbuscar.Size = new System.Drawing.Size(87, 28);
            this.BTNbuscar.TabIndex = 2;
            this.BTNbuscar.Text = "Buscar";
            this.BTNbuscar.UseVisualStyleBackColor = true;
            this.BTNbuscar.Click += new System.EventHandler(this.BTNbuscar_Click);
            // 
            // FRMbusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 214);
            this.Controls.Add(this.BTNbuscar);
            this.Controls.Add(this.LBLdocumento);
            this.Controls.Add(this.TXTbusqueda);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FRMbusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTbusqueda;
        private System.Windows.Forms.Label LBLdocumento;
        private System.Windows.Forms.Button BTNbuscar;
    }
}