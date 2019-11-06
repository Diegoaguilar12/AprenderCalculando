namespace JuegoNiñosPrimaria
{
    partial class EleccionPrueba
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
            this.PuertaCerrada = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PuertaCerrada)).BeginInit();
            this.SuspendLayout();
            // 
            // PuertaCerrada
            // 
            this.PuertaCerrada.BackgroundImage = global::JuegoNiñosPrimaria.Properties.Resources.PuertaCerrada;
            this.PuertaCerrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PuertaCerrada.Location = new System.Drawing.Point(124, 101);
            this.PuertaCerrada.Name = "PuertaCerrada";
            this.PuertaCerrada.Size = new System.Drawing.Size(120, 250);
            this.PuertaCerrada.TabIndex = 1;
            this.PuertaCerrada.TabStop = false;
            this.PuertaCerrada.Click += new System.EventHandler(this.PuertaCerrada_Click);
            // 
            // EleccionPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoNiñosPrimaria.Properties.Resources.PuertaAbierta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 381);
            this.Controls.Add(this.PuertaCerrada);
            this.Name = "EleccionPrueba";
            this.Text = "EleccionPrueba";
            this.Click += new System.EventHandler(this.EleccionPrueba_Click_2);
            this.MouseHover += new System.EventHandler(this.EleccionPrueba_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.PuertaCerrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PuertaCerrada;
    }
}