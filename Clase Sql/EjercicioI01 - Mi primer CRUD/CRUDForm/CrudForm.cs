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

namespace CRUDForm
{
    public partial class CrudForm : Form
    {
        List<Persona> lista;
        Persona p;
        
    public CrudForm()
        {
            InitializeComponent();
            lista = new List<Persona>();
        }

        private void Leer()
        {
            lista = PersonaDAO.Leer();
            List<String> l = new List<string>();

            foreach (var item in lista)
            {
                l.Add($"Nombre: {item.Nombre} Apellido: {item.Apellido}");
            }
            lstPersonas.DataSource = l;
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            Leer();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txbApellido.Text != "" && txbNombre.Text != "")
            {
                p = new Persona(txbNombre.Text, txbApellido.Text);
                if (PersonaDAO.Guardar(p)) { MessageBox.Show("Se GUARDO con exito la persona!");
                    txbApellido.Text = ""; txbNombre.Text = "";
                    p = null;
                    Leer();
                } else { MessageBox.Show("Algo salio mal, revise los datos y vuelva a intentarlo!"); }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txbApellido.Text != "" && txbNombre.Text != "")
            {
                Persona p = new Persona(txbNombre.Text, txbApellido.Text);
                if (lista == p && lista != null)
                {
                    foreach (var item in lista)
                    {
                        if (p == item) { p.ID = item.ID; }
                    }
                    if (PersonaDAO.Borrar(p.ID))
                    {
                        MessageBox.Show("Se ELIMINO con exito la persona!");
                        txbApellido.Text = ""; txbNombre.Text = "";
                        p = null;
                        Leer();
                    }
                    else
                    {
                        MessageBox.Show("Algo salio mal, revise los datos y vuelva a intentarlo!");
                    }
                }
                else { MessageBox.Show("Cargar lista!"); }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txbApellido.Text != "" && txbNombre.Text != "")
            {
                Persona p = new Persona(txbNombre.Text, txbApellido.Text);
                if (lista == p && lista != null)
                {
                    foreach (var item in lista)
                    {
                        if (p == item) { p.ID = item.ID; }
                    }
                    if (PersonaDAO.Modifcar(p))
                    {
                        MessageBox.Show("Se MODIFICO con exito la persona!");
                        txbApellido.Text = ""; txbNombre.Text = "";
                        p = null;
                        Leer();
                    }
                    else
                    {
                        MessageBox.Show("Algo salio mal, revise los datos y vuelva a intentarlo!");
                    }
                }
                else { MessageBox.Show("Cargar lista!"); }
            }
        }
    }
}
