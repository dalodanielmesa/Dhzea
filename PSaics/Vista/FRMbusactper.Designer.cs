namespace PSaics.Vista
{
    partial class FRMbusactper
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
            this.DGVpersona = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVpersona)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVpersona
            // 
            this.DGVpersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVpersona.Location = new System.Drawing.Point(69, 49);
            this.DGVpersona.Name = "DGVpersona";
            this.DGVpersona.Size = new System.Drawing.Size(670, 334);
            this.DGVpersona.TabIndex = 0;
            this.DGVpersona.DoubleClick += new System.EventHandler(this.DGVpersona_DoubleClick);
            // 
            // FRMbusactper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVpersona);
            this.Name = "FRMbusactper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar";
            this.Load += new System.EventHandler(this.FRMbusactper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVpersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVpersona;
    }
}