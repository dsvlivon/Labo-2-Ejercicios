using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;using Entidades;

namespace Ejercicio_02
{
    public partial class FormModal : Form
    {
        public FormModal()
        {
            InitializeComponent();
        }
        public FormModal(Ingresante i)
        {
            InitializeComponent();
            lblData.Text = i.Mostrar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
