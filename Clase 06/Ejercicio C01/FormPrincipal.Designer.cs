
namespace Ejercicio_C01
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblEuroA = new System.Windows.Forms.Label();
            this.lblDolarA = new System.Windows.Forms.Label();
            this.lblPesoA = new System.Windows.Forms.Label();
            this.tbxEuroAEuro = new System.Windows.Forms.TextBox();
            this.tbxDolarAEuro = new System.Windows.Forms.TextBox();
            this.tbxPesoAEuro = new System.Windows.Forms.TextBox();
            this.tbxPesoADolar = new System.Windows.Forms.TextBox();
            this.tbxDolarADolar = new System.Windows.Forms.TextBox();
            this.tbxEuroADolar = new System.Windows.Forms.TextBox();
            this.tbxPesoAPeso = new System.Windows.Forms.TextBox();
            this.tbxDolarAPeso = new System.Windows.Forms.TextBox();
            this.tbxEuroAPeso = new System.Windows.Forms.TextBox();
            this.tbxPeso = new System.Windows.Forms.TextBox();
            this.tbxDolar = new System.Windows.Forms.TextBox();
            this.tbxEuro = new System.Windows.Forms.TextBox();
            this.btnConvertirEuro = new System.Windows.Forms.Button();
            this.btnConvertirDolar = new System.Windows.Forms.Button();
            this.btnConvertirPeso = new System.Windows.Forms.Button();
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.tbxCotizacionPeso = new System.Windows.Forms.TextBox();
            this.tbxCotizacionDolar = new System.Windows.Forms.TextBox();
            this.tbxCotizacionEuro = new System.Windows.Forms.TextBox();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(19, 120);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(48, 25);
            this.lblEuro.TabIndex = 1;
            this.lblEuro.Text = "Euro";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(19, 218);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(49, 25);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(19, 170);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(55, 25);
            this.lblDolar.TabIndex = 4;
            this.lblDolar.Text = "Dolar";
            // 
            // lblEuroA
            // 
            this.lblEuroA.AutoSize = true;
            this.lblEuroA.Location = new System.Drawing.Point(459, 87);
            this.lblEuroA.Name = "lblEuroA";
            this.lblEuroA.Size = new System.Drawing.Size(48, 25);
            this.lblEuroA.TabIndex = 5;
            this.lblEuroA.Text = "Euro";
            // 
            // lblDolarA
            // 
            this.lblDolarA.AutoSize = true;
            this.lblDolarA.Location = new System.Drawing.Point(611, 87);
            this.lblDolarA.Name = "lblDolarA";
            this.lblDolarA.Size = new System.Drawing.Size(55, 25);
            this.lblDolarA.TabIndex = 6;
            this.lblDolarA.Text = "Dolar";
            // 
            // lblPesoA
            // 
            this.lblPesoA.AutoSize = true;
            this.lblPesoA.Location = new System.Drawing.Point(761, 87);
            this.lblPesoA.Name = "lblPesoA";
            this.lblPesoA.Size = new System.Drawing.Size(49, 25);
            this.lblPesoA.TabIndex = 7;
            this.lblPesoA.Text = "Peso";
            // 
            // tbxEuroAEuro
            // 
            this.tbxEuroAEuro.Location = new System.Drawing.Point(407, 115);
            this.tbxEuroAEuro.Name = "tbxEuroAEuro";
            this.tbxEuroAEuro.ReadOnly = true;
            this.tbxEuroAEuro.Size = new System.Drawing.Size(150, 31);
            this.tbxEuroAEuro.TabIndex = 8;
            // 
            // tbxDolarAEuro
            // 
            this.tbxDolarAEuro.Location = new System.Drawing.Point(407, 163);
            this.tbxDolarAEuro.Name = "tbxDolarAEuro";
            this.tbxDolarAEuro.ReadOnly = true;
            this.tbxDolarAEuro.Size = new System.Drawing.Size(150, 31);
            this.tbxDolarAEuro.TabIndex = 9;
            // 
            // tbxPesoAEuro
            // 
            this.tbxPesoAEuro.Location = new System.Drawing.Point(407, 213);
            this.tbxPesoAEuro.Name = "tbxPesoAEuro";
            this.tbxPesoAEuro.ReadOnly = true;
            this.tbxPesoAEuro.Size = new System.Drawing.Size(150, 31);
            this.tbxPesoAEuro.TabIndex = 10;
            // 
            // tbxPesoADolar
            // 
            this.tbxPesoADolar.Location = new System.Drawing.Point(564, 213);
            this.tbxPesoADolar.Name = "tbxPesoADolar";
            this.tbxPesoADolar.ReadOnly = true;
            this.tbxPesoADolar.Size = new System.Drawing.Size(150, 31);
            this.tbxPesoADolar.TabIndex = 13;
            // 
            // tbxDolarADolar
            // 
            this.tbxDolarADolar.Location = new System.Drawing.Point(564, 163);
            this.tbxDolarADolar.Name = "tbxDolarADolar";
            this.tbxDolarADolar.ReadOnly = true;
            this.tbxDolarADolar.Size = new System.Drawing.Size(150, 31);
            this.tbxDolarADolar.TabIndex = 12;
            // 
            // tbxEuroADolar
            // 
            this.tbxEuroADolar.Location = new System.Drawing.Point(564, 115);
            this.tbxEuroADolar.Name = "tbxEuroADolar";
            this.tbxEuroADolar.ReadOnly = true;
            this.tbxEuroADolar.Size = new System.Drawing.Size(150, 31);
            this.tbxEuroADolar.TabIndex = 11;
            // 
            // tbxPesoAPeso
            // 
            this.tbxPesoAPeso.Location = new System.Drawing.Point(720, 213);
            this.tbxPesoAPeso.Name = "tbxPesoAPeso";
            this.tbxPesoAPeso.ReadOnly = true;
            this.tbxPesoAPeso.Size = new System.Drawing.Size(150, 31);
            this.tbxPesoAPeso.TabIndex = 16;
            // 
            // tbxDolarAPeso
            // 
            this.tbxDolarAPeso.Location = new System.Drawing.Point(720, 163);
            this.tbxDolarAPeso.Name = "tbxDolarAPeso";
            this.tbxDolarAPeso.ReadOnly = true;
            this.tbxDolarAPeso.Size = new System.Drawing.Size(150, 31);
            this.tbxDolarAPeso.TabIndex = 15;
            // 
            // tbxEuroAPeso
            // 
            this.tbxEuroAPeso.Location = new System.Drawing.Point(720, 115);
            this.tbxEuroAPeso.Name = "tbxEuroAPeso";
            this.tbxEuroAPeso.ReadOnly = true;
            this.tbxEuroAPeso.Size = new System.Drawing.Size(150, 31);
            this.tbxEuroAPeso.TabIndex = 14;
            // 
            // tbxPeso
            // 
            this.tbxPeso.Location = new System.Drawing.Point(83, 213);
            this.tbxPeso.Name = "tbxPeso";
            this.tbxPeso.Size = new System.Drawing.Size(150, 31);
            this.tbxPeso.TabIndex = 19;
            // 
            // tbxDolar
            // 
            this.tbxDolar.Location = new System.Drawing.Point(83, 163);
            this.tbxDolar.Name = "tbxDolar";
            this.tbxDolar.Size = new System.Drawing.Size(150, 31);
            this.tbxDolar.TabIndex = 18;
            // 
            // tbxEuro
            // 
            this.tbxEuro.Location = new System.Drawing.Point(83, 115);
            this.tbxEuro.Name = "tbxEuro";
            this.tbxEuro.Size = new System.Drawing.Size(150, 31);
            this.tbxEuro.TabIndex = 17;
            // 
            // btnConvertirEuro
            // 
            this.btnConvertirEuro.Location = new System.Drawing.Point(249, 115);
            this.btnConvertirEuro.Name = "btnConvertirEuro";
            this.btnConvertirEuro.Size = new System.Drawing.Size(111, 33);
            this.btnConvertirEuro.TabIndex = 20;
            this.btnConvertirEuro.Text = "->";
            this.btnConvertirEuro.UseVisualStyleBackColor = true;
            this.btnConvertirEuro.Click += new System.EventHandler(this.btnConvertirEuro_Click);
            // 
            // btnConvertirDolar
            // 
            this.btnConvertirDolar.Location = new System.Drawing.Point(249, 162);
            this.btnConvertirDolar.Name = "btnConvertirDolar";
            this.btnConvertirDolar.Size = new System.Drawing.Size(111, 33);
            this.btnConvertirDolar.TabIndex = 21;
            this.btnConvertirDolar.Text = "->";
            this.btnConvertirDolar.UseVisualStyleBackColor = true;
            // 
            // btnConvertirPeso
            // 
            this.btnConvertirPeso.Location = new System.Drawing.Point(249, 212);
            this.btnConvertirPeso.Name = "btnConvertirPeso";
            this.btnConvertirPeso.Size = new System.Drawing.Size(111, 33);
            this.btnConvertirPeso.TabIndex = 22;
            this.btnConvertirPeso.Text = "->";
            this.btnConvertirPeso.UseVisualStyleBackColor = true;
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.Location = new System.Drawing.Point(249, 40);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(111, 33);
            this.btnLockCotizacion.TabIndex = 23;
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.btnLockCotizacion_Click);
            // 
            // tbxCotizacionPeso
            // 
            this.tbxCotizacionPeso.Location = new System.Drawing.Point(720, 35);
            this.tbxCotizacionPeso.Name = "tbxCotizacionPeso";
            this.tbxCotizacionPeso.Size = new System.Drawing.Size(150, 31);
            this.tbxCotizacionPeso.TabIndex = 26;
            // 
            // tbxCotizacionDolar
            // 
            this.tbxCotizacionDolar.Location = new System.Drawing.Point(564, 35);
            this.tbxCotizacionDolar.Name = "tbxCotizacionDolar";
            this.tbxCotizacionDolar.Size = new System.Drawing.Size(150, 31);
            this.tbxCotizacionDolar.TabIndex = 25;
            this.tbxCotizacionDolar.TextChanged += new System.EventHandler(this.tbxCotizacionDolar_LostFocus);
            // 
            // tbxCotizacionEuro
            // 
            this.tbxCotizacionEuro.Location = new System.Drawing.Point(407, 35);
            this.tbxCotizacionEuro.Name = "tbxCotizacionEuro";
            this.tbxCotizacionEuro.Size = new System.Drawing.Size(150, 31);
            this.tbxCotizacionEuro.TabIndex = 24;
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Location = new System.Drawing.Point(83, 42);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(94, 25);
            this.lblCotizacion.TabIndex = 2;
            this.lblCotizacion.Text = "Cotizacion";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "candado_abierto.png");
            this.imageList.Images.SetKeyName(1, "candado_cerrado.png");
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 308);
            this.Controls.Add(this.tbxCotizacionPeso);
            this.Controls.Add(this.tbxCotizacionDolar);
            this.Controls.Add(this.tbxCotizacionEuro);
            this.Controls.Add(this.btnLockCotizacion);
            this.Controls.Add(this.btnConvertirPeso);
            this.Controls.Add(this.btnConvertirDolar);
            this.Controls.Add(this.btnConvertirEuro);
            this.Controls.Add(this.tbxPeso);
            this.Controls.Add(this.tbxDolar);
            this.Controls.Add(this.tbxEuro);
            this.Controls.Add(this.tbxPesoAPeso);
            this.Controls.Add(this.tbxDolarAPeso);
            this.Controls.Add(this.tbxEuroAPeso);
            this.Controls.Add(this.tbxPesoADolar);
            this.Controls.Add(this.tbxDolarADolar);
            this.Controls.Add(this.tbxEuroADolar);
            this.Controls.Add(this.tbxPesoAEuro);
            this.Controls.Add(this.tbxDolarAEuro);
            this.Controls.Add(this.tbxEuroAEuro);
            this.Controls.Add(this.lblPesoA);
            this.Controls.Add(this.lblDolarA);
            this.Controls.Add(this.lblEuroA);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.lblEuro);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblEuroA;
        private System.Windows.Forms.Label lblDolarA;
        private System.Windows.Forms.Label lblPesoA;
        private System.Windows.Forms.TextBox tbxEuroAEuro;
        private System.Windows.Forms.TextBox tbxDolarAEuro;
        private System.Windows.Forms.TextBox tbxPesoAEuro;
        private System.Windows.Forms.TextBox tbxPesoADolar;
        private System.Windows.Forms.TextBox tbxDolarADolar;
        private System.Windows.Forms.TextBox tbxEuroADolar;
        private System.Windows.Forms.TextBox tbxPesoAPeso;
        private System.Windows.Forms.TextBox tbxDolarAPeso;
        private System.Windows.Forms.TextBox tbxEuroAPeso;
        private System.Windows.Forms.TextBox tbxPeso;
        private System.Windows.Forms.TextBox tbxDolar;
        private System.Windows.Forms.TextBox tbxEuro;
        private System.Windows.Forms.Button btnConvertirEuro;
        private System.Windows.Forms.Button btnConvertirDolar;
        private System.Windows.Forms.Button btnConvertirPeso;
        private System.Windows.Forms.Button btnLockCotizacion;
        private System.Windows.Forms.TextBox tbxCotizacionPeso;
        private System.Windows.Forms.TextBox tbxCotizacionDolar;
        private System.Windows.Forms.TextBox tbxCotizacionEuro;
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.ImageList imageList;
    }
}

