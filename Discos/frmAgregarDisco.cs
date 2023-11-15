using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace DiscosDB
{
    public partial class frmAgregarDisco : Form
    {
        Disco disco = null;
        public frmAgregarDisco()
        {
            InitializeComponent();
        }

        public frmAgregarDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtbCantidadCanciones.Text == "" || txtbTitulo.Text == "")
            {
                MessageBox.Show("Por favor rellene todos los campos.");
                return;
            }

            if (!Helper.soloNumeros(txtbCantidadCanciones.Text))
            {
                MessageBox.Show("Ingrese solo números en la sección \"Cantidad de Canciones\".");
                return;
            }


            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                if (disco == null)
                {
                    disco = new Disco();
                }
                disco.Titulo = txtbTitulo.Text;
                disco.FechaLanzamiento = dtpFechaLanzamiento.Value.Date;
                disco.CantidadCanciones = int.Parse(txtbCantidadCanciones.Text);
                disco.Estilo = (Estilo)cbEstilo.SelectedItem;
                disco.TipoEdicion = (Edicion)cbTipoEdicion.SelectedItem;
                disco.UrlImagenTapa = txtbUrlImagen.Text;
                
                if (disco.Id != 0)
                {
                    negocio.modificar(disco);
                    MessageBox.Show("El disco ha sido modificado.");
                }
                else
                {
                    negocio.agregarDisco(disco);
                    MessageBox.Show("El disco ha sido agregado exitosamente.");
                }
       
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void frmAgregarDisco_Load(object sender, EventArgs e)
        {
            EdicionNegocio edicionNegocio = new EdicionNegocio();
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            try
            {
                cbEstilo.DataSource = estiloNegocio.listar();
                cbEstilo.ValueMember = "Id";
                cbEstilo.DisplayMember = "Descripcion";
                cbTipoEdicion.DataSource = edicionNegocio.listar();
                cbTipoEdicion.ValueMember = "Id";
                cbTipoEdicion.DisplayMember = "Descripcion";
                
                if(disco != null)
                {
                    //Aca lo que tengo que hacer es previsualizar los valores seleccionados del dgv.
                    txtbTitulo.Text = disco.Titulo;
                    dtpFechaLanzamiento.Value = disco.FechaLanzamiento;
                    txtbCantidadCanciones.Text = disco.CantidadCanciones.ToString();
                    txtbUrlImagen.Text = disco.UrlImagenTapa;
                    cargarImagen(txtbUrlImagen.Text);
                    cbEstilo.SelectedValue = disco.Estilo.Id;
                    cbTipoEdicion.SelectedValue = disco.TipoEdicion.Id;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
                

        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbDiscos.Load(imagen);
            }
            catch (Exception)
            {
                pbDiscos.Load("https://www.campana.gob.ar/wp-content/uploads/2022/05/placeholder-1.png");
            }
        }

        private void txtbUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtbUrlImagen.Text);
        }
    }
}
