using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;using Entidades;

namespace Ejercicio_02
{
    public enum EPaises { Argentina, Uruaguay, Chile}
    public partial class FormPrincipal : Form
    {
        Ingresante ingresante;
        public FormPrincipal()
        {
            InitializeComponent();
        }//holooooo

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string[] array = new string[0];
            EPaises op;
            Enum.TryParse<EPaises>(lbxPaises.SelectedValue.ToString(), out op);
            Int32.TryParse(nudEdad.Value.ToString(), out int i);
            string g = checkGenero();
            ingresante = new Ingresante(tbxNombre.Text, tbxDireccion.Text, g, op.ToString(), array, i);
            
            
            
            FormModal frm = new FormModal(ingresante);
            //frm.getMateria(op);
            frm.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            lbxPaises.DataSource = Enum.GetValues(typeof(EPaises));
        }

        public string checkGenero()
        {
            string x;
            if (rdbMasculino.Checked) { x = "Masculino"; }
            else if(rdbFemenino.Checked) { x = "Femenino"; }
            else { x = "No Binario"; }
            return "";
        }

        public string checkCursos()
        {
            string x;
            if (rdbMasculino.Checked) { x = "Masculino"; }
            else if (rdbFemenino.Checked) { x = "Femenino"; }
            else { x = "No Binario"; }
            return "";
        }
    }
}
