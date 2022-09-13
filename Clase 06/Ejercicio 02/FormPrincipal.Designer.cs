
namespace Ejercicio_02
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxCSharp = new System.Windows.Forms.CheckBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbNoBinario = new System.Windows.Forms.RadioButton();
            this.cbxCMasMas = new System.Windows.Forms.CheckBox();
            this.cbxJavaScript = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lbxPaises = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbxDireccion);
            this.groupBox1.Controls.Add(this.tbxNombre);
            this.groupBox1.Location = new System.Drawing.Point(34, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 205);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxJavaScript);
            this.groupBox2.Controls.Add(this.cbxCMasMas);
            this.groupBox2.Controls.Add(this.cbxCSharp);
            this.groupBox2.Location = new System.Drawing.Point(374, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 150);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cursos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbNoBinario);
            this.groupBox3.Controls.Add(this.rdbFemenino);
            this.groupBox3.Controls.Add(this.rdbMasculino);
            this.groupBox3.Location = new System.Drawing.Point(374, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 150);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Género";
            // 
            // cbxCSharp
            // 
            this.cbxCSharp.AutoSize = true;
            this.cbxCSharp.Location = new System.Drawing.Point(20, 45);
            this.cbxCSharp.Name = "cbxCSharp";
            this.cbxCSharp.Size = new System.Drawing.Size(60, 29);
            this.cbxCSharp.TabIndex = 4;
            this.cbxCSharp.Text = "C#";
            this.cbxCSharp.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(20, 30);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(117, 29);
            this.rdbMasculino.TabIndex = 5;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(20, 65);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(115, 29);
            this.rdbFemenino.TabIndex = 6;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbNoBinario
            // 
            this.rdbNoBinario.AutoSize = true;
            this.rdbNoBinario.Location = new System.Drawing.Point(20, 100);
            this.rdbNoBinario.Name = "rdbNoBinario";
            this.rdbNoBinario.Size = new System.Drawing.Size(120, 29);
            this.rdbNoBinario.TabIndex = 7;
            this.rdbNoBinario.TabStop = true;
            this.rdbNoBinario.Text = "No Binario";
            this.rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // cbxCMasMas
            // 
            this.cbxCMasMas.AutoSize = true;
            this.cbxCMasMas.Location = new System.Drawing.Point(20, 75);
            this.cbxCMasMas.Name = "cbxCMasMas";
            this.cbxCMasMas.Size = new System.Drawing.Size(73, 29);
            this.cbxCMasMas.TabIndex = 5;
            this.cbxCMasMas.Text = "C++";
            this.cbxCMasMas.UseVisualStyleBackColor = true;
            // 
            // cbxJavaScript
            // 
            this.cbxJavaScript.AutoSize = true;
            this.cbxJavaScript.Location = new System.Drawing.Point(20, 106);
            this.cbxJavaScript.Name = "cbxJavaScript";
            this.cbxJavaScript.Size = new System.Drawing.Size(123, 29);
            this.cbxJavaScript.TabIndex = 6;
            this.cbxJavaScript.Text = "JavaScropt";
            this.cbxJavaScript.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(374, 371);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(206, 34);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "País";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(132, 30);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(150, 31);
            this.tbxNombre.TabIndex = 0;
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(132, 77);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(150, 31);
            this.tbxDireccion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Edad";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(141, 193);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(180, 31);
            this.nudEdad.TabIndex = 6;
            // 
            // lbxPaises
            // 
            this.lbxPaises.FormattingEnabled = true;
            this.lbxPaises.ItemHeight = 25;
            this.lbxPaises.Location = new System.Drawing.Point(34, 289);
            this.lbxPaises.Name = "lbxPaises";
            this.lbxPaises.Size = new System.Drawing.Size(287, 29);
            this.lbxPaises.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.lbxPaises);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxJavaScript;
        private System.Windows.Forms.CheckBox cbxCMasMas;
        private System.Windows.Forms.CheckBox cbxCSharp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbNoBinario;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.ListBox lbxPaises;
    }
}

