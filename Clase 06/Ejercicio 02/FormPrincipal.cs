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
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string[] array = checkCursos();
            
            EPaises op;
            Enum.TryParse<EPaises>(lbxPaises.SelectedValue.ToString(), out op);
            Int32.TryParse(nudEdad.Value.ToString(), out int x);
            string g = checkGenero();
            ingresante = new Ingresante(tbxNombre.Text, tbxDireccion.Text, g, op.ToString(), array, x);
            
            
            
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
            return x;
        }

        public string[] checkCursos()
        {
            string[] array = new string[3];
            if (cbxCSharp.Checked) { array[0] = "C#"; }
            if (cbxCMasMas.Checked) { array[1] = "C++"; }
            if (cbxJavaScript.Checked) { array[2] = "JavaScript"; }
            return array;
        }
    }
}
