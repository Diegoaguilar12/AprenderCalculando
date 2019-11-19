namespace JuegoNiñosPrimaria
{
    partial class Prueba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prueba));
            this.ptbMaestria = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNumMinNumMax = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNumMaximo = new System.Windows.Forms.TextBox();
            this.txtBoxNumMinimo = new System.Windows.Forms.TextBox();
            this.btnIgualar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicaciónXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.btnRango = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaestria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbMaestria
            // 
            this.ptbMaestria.BackColor = System.Drawing.Color.Transparent;
            this.ptbMaestria.Image = ((System.Drawing.Image)(resources.GetObject("ptbMaestria.Image")));
            this.ptbMaestria.Location = new System.Drawing.Point(-116, 52);
            this.ptbMaestria.Name = "ptbMaestria";
            this.ptbMaestria.Size = new System.Drawing.Size(305, 317);
            this.ptbMaestria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMaestria.TabIndex = 2;
            this.ptbMaestria.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Controls.Add(this.btnNumMinNumMax);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxNumMaximo);
            this.groupBox1.Controls.Add(this.txtBoxNumMinimo);
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(115, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 160);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnNumMinNumMax
            // 
            this.btnNumMinNumMax.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNumMinNumMax.Location = new System.Drawing.Point(150, 127);
            this.btnNumMinNumMax.Name = "btnNumMinNumMax";
            this.btnNumMinNumMax.Size = new System.Drawing.Size(93, 27);
            this.btnNumMinNumMax.TabIndex = 25;
            this.btnNumMinNumMax.Text = "Ingresar";
            this.btnNumMinNumMax.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.OldLace;
            this.label4.Location = new System.Drawing.Point(119, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 34);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ingrese Rango : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.OldLace;
            this.label3.Location = new System.Drawing.Point(222, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 27);
            this.label3.TabIndex = 23;
            this.label3.Text = "Numero maximo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.OldLace;
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Numero minimo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxNumMaximo
            // 
            this.txtBoxNumMaximo.BackColor = System.Drawing.Color.Green;
            this.txtBoxNumMaximo.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtBoxNumMaximo.ForeColor = System.Drawing.Color.OldLace;
            this.txtBoxNumMaximo.Location = new System.Drawing.Point(249, 77);
            this.txtBoxNumMaximo.Multiline = true;
            this.txtBoxNumMaximo.Name = "txtBoxNumMaximo";
            this.txtBoxNumMaximo.Size = new System.Drawing.Size(81, 54);
            this.txtBoxNumMaximo.TabIndex = 2;
            this.txtBoxNumMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxNumMinimo
            // 
            this.txtBoxNumMinimo.BackColor = System.Drawing.Color.Green;
            this.txtBoxNumMinimo.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtBoxNumMinimo.ForeColor = System.Drawing.Color.OldLace;
            this.txtBoxNumMinimo.Location = new System.Drawing.Point(63, 77);
            this.txtBoxNumMinimo.Multiline = true;
            this.txtBoxNumMinimo.Name = "txtBoxNumMinimo";
            this.txtBoxNumMinimo.Size = new System.Drawing.Size(81, 54);
            this.txtBoxNumMinimo.TabIndex = 1;
            this.txtBoxNumMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIgualar
            // 
            this.btnIgualar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnIgualar.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnIgualar.ForeColor = System.Drawing.Color.OldLace;
            this.btnIgualar.Location = new System.Drawing.Point(240, 81);
            this.btnIgualar.Name = "btnIgualar";
            this.btnIgualar.Size = new System.Drawing.Size(63, 72);
            this.btnIgualar.TabIndex = 28;
            this.btnIgualar.Text = "=";
            this.btnIgualar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.OldLace;
            this.label1.Location = new System.Drawing.Point(121, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Realice la siguiente operación";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperacion
            // 
            this.lblOperacion.BackColor = System.Drawing.Color.Transparent;
            this.lblOperacion.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.ForeColor = System.Drawing.Color.OldLace;
            this.lblOperacion.Location = new System.Drawing.Point(119, 94);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(108, 54);
            this.lblOperacion.TabIndex = 26;
            this.lblOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.DarkGreen;
            this.txtResultado.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtResultado.ForeColor = System.Drawing.Color.OldLace;
            this.txtResultado.Location = new System.Drawing.Point(333, 81);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(138, 72);
            this.txtResultado.TabIndex = 25;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNumero1
            // 
            this.lblNumero1.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero1.Cursor = System.Windows.Forms.Cursors.No;
            this.lblNumero1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNumero1.ForeColor = System.Drawing.Color.OldLace;
            this.lblNumero1.Location = new System.Drawing.Point(116, 42);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(118, 60);
            this.lblNumero1.TabIndex = 24;
            this.lblNumero1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(614, 28);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Peru;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(229, 25);
            this.toolStripLabel1.Text = "Elige una operación :";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem,
            this.multiplicaciónXToolStripMenuItem,
            this.divisiónToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::JuegoNiñosPrimaria.Properties.Resources.Operaciones;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 25);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sumaToolStripMenuItem.Text = "Suma ";
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.restaToolStripMenuItem.Text = "Resta ";
            // 
            // multiplicaciónXToolStripMenuItem
            // 
            this.multiplicaciónXToolStripMenuItem.Name = "multiplicaciónXToolStripMenuItem";
            this.multiplicaciónXToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.multiplicaciónXToolStripMenuItem.Text = "Multiplicación  ";
            // 
            // divisiónToolStripMenuItem
            // 
            this.divisiónToolStripMenuItem.Name = "divisiónToolStripMenuItem";
            this.divisiónToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.divisiónToolStripMenuItem.Text = "División  ";
            // 
            // lblNumero2
            // 
            this.lblNumero2.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero2.Cursor = System.Windows.Forms.Cursors.No;
            this.lblNumero2.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero2.ForeColor = System.Drawing.Color.OldLace;
            this.lblNumero2.Location = new System.Drawing.Point(116, 137);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(118, 60);
            this.lblNumero2.TabIndex = 22;
            this.lblNumero2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRango
            // 
            this.btnRango.BackColor = System.Drawing.Color.SandyBrown;
            this.btnRango.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnRango.Location = new System.Drawing.Point(250, 329);
            this.btnRango.Name = "btnRango";
            this.btnRango.Size = new System.Drawing.Size(120, 40);
            this.btnRango.TabIndex = 30;
            this.btnRango.Text = "Rango ";
            this.btnRango.UseVisualStyleBackColor = false;
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JuegoNiñosPrimaria.Properties.Resources.SalonClases;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 381);
            this.Controls.Add(this.btnRango);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIgualar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.ptbMaestria);
            this.Name = "Prueba";
            this.Text = "Prueba";
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaestria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbMaestria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNumMinNumMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNumMaximo;
        private System.Windows.Forms.TextBox txtBoxNumMinimo;
        private System.Windows.Forms.Button btnIgualar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicaciónXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisiónToolStripMenuItem;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.Button btnRango;
    }
}