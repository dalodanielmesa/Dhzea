namespace PSaics.Vista
{
    partial class FRMreccorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMreccorreo));
            this.TXTdocumento = new System.Windows.Forms.TextBox();
            this.BTNrecuperar = new System.Windows.Forms.Button();
            this.LBLdocumento = new System.Windows.Forms.Label();
            this.BTNatras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTdocumento
            // 
            this.TXTdocumento.Location = new System.Drawing.Point(104, 95);
            this.TXTdocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTdocumento.Name = "TXTdocumento";
            this.TXTdocumento.Size = new System.Drawing.Size(148, 26);
            this.TXTdocumento.TabIndex = 0;
            // 
            // BTNrecuperar
            // 
            this.BTNrecuperar.BackColor = System.Drawing.Color.Transparent;
            this.BTNrecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNrecuperar.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNrecuperar.Location = new System.Drawing.Point(120, 156);
            this.BTNrecuperar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNrecuperar.Name = "BTNrecuperar";
            this.BTNrecuperar.Size = new System.Drawing.Size(112, 35);
            this.BTNrecuperar.TabIndex = 1;
            this.BTNrecuperar.Text = "Recuperar";
            this.BTNrecuperar.UseVisualStyleBackColor = false;
            this.BTNrecuperar.Click += new System.EventHandler(this.BTNrecuperar_Click);
            // 
            // LBLdocumento
            // 
            this.LBLdocumento.AutoSize = true;
            this.LBLdocumento.BackColor = System.Drawing.Color.Transparent;
            this.LBLdocumento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLdocumento.Location = new System.Drawing.Point(127, 70);
            this.LBLdocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLdocumento.Name = "LBLdocumento";
            this.LBLdocumento.Size = new System.Drawing.Size(96, 20);
            this.LBLdocumento.TabIndex = 2;
            this.LBLdocumento.Text = "Documento:";
            // 
            // BTNatras
            // 
            this.BTNatras.BackColor = System.Drawing.Color.Transparent;
            this.BTNatras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNatras.BackgroundImage")));
            this.BTNatras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNatras.FlatAppearance.BorderSize = 0;
            this.BTNatras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNatras.Location = new System.Drawing.Point(12, 12);
            this.BTNatras.Name = "BTNatras";
            this.BTNatras.Size = new System.Drawing.Size(46, 44);
            this.BTNatras.TabIndex = 29;
            this.BTNatras.UseVisualStyleBackColor = false;
            this.BTNatras.Click += new System.EventHandler(this.BTNatras_Click);
            // 
            // FRMreccorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(367, 248);
            this.Controls.Add(this.BTNatras);
            this.Controls.Add(this.LBLdocumento);
            this.Controls.Add(this.BTNrecuperar);
            this.Controls.Add(this.TXTdocumento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMreccorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTdocumento;
        private System.Windows.Forms.Button BTNrecuperar;
        private System.Windows.Forms.Label LBLdocumento;
        private System.Windows.Forms.Button BTNatras;
    }
}