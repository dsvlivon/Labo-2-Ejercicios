using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MisForms
{
    public partial class FormModal : Form
    {
        //public string msg2;
        public FormModal()
        {
            InitializeComponent();
        }
        public FormModal(string n, string a, string o)
        {
            InitializeComponent();
            
            lblSaludar.Text = $"Soy {n} {a}" + " y mi materia favorita es " + o;
            lblTitulo.Text = "¡Hola, Windows Forms!";
        }
        public FormModal(string n)
        {
            InitializeComponent();
            lblSaludar.Hide();
            lblTitulo.Text = n;
        }

        private void FormModal_Load(object sender, EventArgs e)
        {

        }      
    }
}
