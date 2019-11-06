namespace JuegoNiñosPrimaria
{
    partial class AprenderCalculando
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AprenderCalculando));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnPracticar = new System.Windows.Forms.Button();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-116, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.OldLace;
            this.lblBienvenida.Location = new System.Drawing.Point(124, 45);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(362, 138);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Bienvenido a Aprender Calculando \r\nMi nombre es Angeles Mejias \r\nSeré tu profesor" +
    "a de Matemáticas \r\n¿Que querés hacer hoy?";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPracticar
            // 
            this.btnPracticar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnPracticar.Location = new System.Drawing.Point(109, 204);
            this.btnPracticar.Name = "btnPracticar";
            this.btnPracticar.Size = new System.Drawing.Size(140, 50);
            this.btnPracticar.TabIndex = 2;
            this.btnPracticar.Text = "¿Practicar?";
            this.btnPracticar.UseVisualStyleBackColor = false;
            this.btnPracticar.Click += new System.EventHandler(this.btnPracticar_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.BackColor = System.Drawing.Color.SandyBrown;
            this.btnPrueba.Location = new System.Drawing.Point(363, 204);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(140, 50);
            this.btnPrueba.TabIndex = 3;
            this.btnPrueba.Text = "¿Prueba?";
            this.btnPrueba.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AprenderCalculando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 381);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.btnPracticar);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AprenderCalculando";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnPracticar;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.ImageList imageList1;
    }
}

