﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace InterfazPokedex
{
    public partial class FrmPrincipal : Form
    {        
        private string entrenador;
        private Pokemon poke = null;
        public FrmPrincipal(string entrenador)
        {
            InitializeComponent();
            this.entrenador = entrenador;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            int i;
            if (this.entrenador == "Ash") { i = 0; }
            else if (this.entrenador == "Brock") { i = 1; }
            else if (this.entrenador == "Misty") { i = 2; }
            else { i = 4; }

            this.picEntrenador.Image = imageList1.Images[i];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlta frmAlta = new FrmAlta(this.entrenador);
            frmAlta.ShowDialog();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PokemonDAO p = new PokemonDAO();
            if (Int32.TryParse(txtBusqueda.Text, out int id))
            {
                poke = p.Leer(null, id);
            }
            else { poke = p.Leer(txtBusqueda.Text, null); }
            lblIdTexto.Text = "ID: " + poke.Id.ToString();
            lblNombre.Text = "Nombre: " + poke.Nombre;
            lblTipo.Text = "Tipo: " + poke.Tipo;
            lblEntrenadorPokemon.Text = "Entrenador: " + poke.Entrenador;
            picPokemon.BackgroundImageLayout = ImageLayout.Stretch;
            picPokemon.BackgroundImage = Image.FromFile(poke.UrlImagen);
        }

        private void btnPorEntrenador_Click(object sender, EventArgs e)
        {

        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
 
        }

        private void btnPorTipo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPorRango_Click(object sender, EventArgs e)
        {
  
        }

        private void btnPersonalizada_Click(object sender, EventArgs e)
        {
  
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
  
        }

        private void btnSerializacion_Click(object sender, EventArgs e)
        {

        }
    }
}