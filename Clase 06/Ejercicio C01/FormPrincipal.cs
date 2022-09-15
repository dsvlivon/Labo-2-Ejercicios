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
using System.Text.RegularExpressions;

namespace Ejercicio_C01
{
    public partial class FormPrincipal : Form
    {
        Dolar unDolar;
        Euro unEuro;
        Peso unPeso;
        string pattern = @"^[0-9]";
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
            if (Regex.IsMatch(tbxEuro.Text, pattern, RegexOptions.IgnoreCase))
            {
                Double x = Convert.ToDouble(tbxEuro.Text);
                if (x != 0)//la expresion regex asegura q los caracteres esten dados entre 0 - 9, d forma q el convert nunca va a fallar
                {
                    unEuro = new Euro(x);//as cantidad
                    tbxEuroAEuro.Text = x.ToString();
                    Dolar d = (Dolar)unEuro;
                    tbxEuroADolar.Text = (d.getCantidad()).ToString();
                    Peso p = (Peso)unEuro;
                    tbxEuroAPeso.Text = (p.getCantidad()).ToString();
                }
            } else { setError(2); }
        }

        private void btnConvertirDolar_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbxDolar.Text, pattern, RegexOptions.IgnoreCase))
            {
                unDolar = new Dolar(Convert.ToDouble(tbxDolar.Text));
                Euro z = (Euro)unDolar;
                tbxDolarAEuro.Text = (z.getCantidad()).ToString();
                tbxDolarADolar.Text = Convert.ToDouble(tbxDolar.Text).ToString();
                Peso p = (Peso)unDolar;
                tbxDolarAPeso.Text = (p.getCantidad()).ToString();
            } else { setError(1); }
        }

        private void btnConvertirPeso_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbxPeso.Text, pattern, RegexOptions.IgnoreCase))
            {
                unPeso = new Peso(Convert.ToDouble(tbxPeso.Text));
                Euro z = (Euro)unPeso;
                tbxPesoAEuro.Text = (z.getCantidad()).ToString();
                Dolar d = (Dolar)unPeso;
                tbxPesoADolar.Text = (d.getCantidad()).ToString();
                tbxPesoAPeso.Text = Convert.ToDouble(tbxPeso.Text).ToString();
            }
            else { setError(3); }
        }

        private void setError(int i) 
        {
            string msg = "Error!";
            switch (i)
            {
                case 1:
                    tbxDolarAEuro.Text = msg;
                    tbxDolarADolar.Text = msg;
                    tbxDolarAPeso.Text = msg;
                    break;
                case 2:
                    tbxEuroAEuro.Text = msg;
                    tbxEuroADolar.Text = msg;
                    tbxEuroAPeso.Text = msg;
                    break;
                case 3:
                    tbxPesoAEuro.Text = "no ";
                    tbxPesoADolar.Text = "queres ";
                    tbxPesoAPeso.Text = "saberlo...";
                    break;
                default:
                    tbxDolarAEuro.Text = "";
                    tbxDolarADolar.Text = "";
                    tbxDolarAPeso.Text = "";
                    tbxEuroAEuro.Text = "";
                    tbxEuroADolar.Text = "";
                    tbxEuroAPeso.Text = "";
                    tbxPesoAEuro.Text = "";
                    tbxPesoADolar.Text = "";
                    tbxPesoAPeso.Text = "";
                    tbxDolar.Text = "";
                    tbxPeso.Text = "";
                    tbxEuro.Text = "";
                    break;
            }
        }
                    
    }
}
