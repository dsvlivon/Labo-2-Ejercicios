using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Ejercicio_C01
{
    public partial class FormPrincipal : Form
    {
        Dolar unDolar;
        Euro unEuro;
        Peso unPeso;
        public FormPrincipal()
        {
            InitializeComponent();
            tbxCotizacionEuro.Text = Euro.getCotizacion().ToString();
            tbxCotizacionDolar.Text = Dolar.getCotizacion().ToString();
            tbxCotizacionPeso.Text = Peso.getCotizacion().ToString();
            AddMyImage();    
        }

        private void AddMyImage()
        {
            btnLockCotizacion.ImageList = imageList;
            btnLockCotizacion.ImageIndex = 0;//cerrado
            SwitchTextBox(false);
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (btnLockCotizacion.ImageIndex == 0)
            {
                btnLockCotizacion.ImageIndex = 1;//cerrado
                SwitchTextBox(true);
            } else { 
                btnLockCotizacion.ImageIndex = 0;
                SwitchTextBox(false);
            }
        }

        private void SwitchTextBox(bool b) {
            tbxCotizacionDolar.Enabled = b;
            tbxCotizacionEuro.Enabled = b;
            tbxCotizacionPeso.Enabled = b;
            Euro.SetCotizacion(Convert.ToDouble(tbxCotizacionEuro.Text));
            Peso.SetCotizacion(Convert.ToDouble(tbxCotizacionPeso.Text));
        }

        private void tbxCotizacionDolar_LostFocus(object sender, EventArgs e)
        {
            if (Int32.TryParse(tbxCotizacionDolar.Text, out int i))
            {
                if (i != 1)
                {
                    tbxCotizacionDolar.Text = 1.ToString();
                }
            }
            tbxCotizacionDolar.Text = 1.ToString();


        }

        private void btnConvertirEuro_Click(object sender, EventArgs e)
        {
            Double x = Convert.ToDouble(tbxEuro.Text);
                        
            tbxEuroAEuro.Text = Euro.getCotizacion().ToString();
            //tbxEuroADolar.Text = (Dolar)unEuro.ToString();
            tbxEuroAPeso.Text = 1.ToString();
        }
    }
}
