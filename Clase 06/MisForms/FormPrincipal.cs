using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MisForms
{
    public enum EOpciones { Laboratorio, Programacion, SPD, PPP, Ingles }
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(tbxNombre.Text) || !String.IsNullOrWhiteSpace(tbxApellido.Text))
            {
                EOpciones op;
                //podria agregar una validacion x si el try falla

                Enum.TryParse<EOpciones>(cmbMaterias.SelectedValue.ToString(), out op);
                FormModal frm = new FormModal(tbxNombre.Text, tbxApellido.Text, op.ToString());
                //frm.getMateria(op);
                frm.ShowDialog();
            } else {
                FormModal frm = new FormModal("Error!!!!");
                frm.ShowDialog();
            }            
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //cmbMaterias.Items.AddRange(EOpciones);
            cmbMaterias.DataSource = Enum.GetValues(typeof(EOpciones));
        }
    }
}
