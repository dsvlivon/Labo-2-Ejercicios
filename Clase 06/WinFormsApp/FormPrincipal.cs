using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormModal;

namespace WinFormsApp
{
    public partial class FormPrincipal: Form
    {
        public string nombre;
        public string apellido;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this.nombre = textBox1_TextChanged.Text;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            FormPrincipal frm = new FormPrincipal();
            frm.ShowDialog();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            this.nombre = tbxNombre.Text;
            this.apellido = tbxApellido.Text;
            FormModal frm = new FormModal(this.nombre, this.apellido);
            frm.ShowDialog();
    
        }
    }
}
