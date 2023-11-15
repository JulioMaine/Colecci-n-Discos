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
    public partial class frmDiscos : Form
    {
        public frmDiscos()
        {
            InitializeComponent();
        }

        private List<Estilo> listaEstilos;
        private List<Disco> listaDiscos;
        private void Form1_Load(object sender, EventArgs e)
        {
            Actualizar();
            cbCampo.Items.Add("Nombre del disco");
            cbCampo.Items.Add("Año de lanzamiento");
            cbCampo.Items.Add("Genero");
            

        }
        private void Actualizar()
        {
            try
            {
                DiscoNegocio disco = new DiscoNegocio();
                EstiloNegocio estilo = new EstiloNegocio();
                listaDiscos = disco.listar();
                dgvDiscos.DataSource = listaDiscos;
                cargarImagen(listaDiscos[0].UrlImagenTapa); // Para cargar imagenes.
                ocultarColumnas();
                dgvEstilos.Visible = false;
                listaEstilos = estilo.listar();
                dgvEstilos.DataSource = listaEstilos;
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void ocultarColumnas()
        {
            dgvDiscos.Columns["Id"].Visible = false;
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDiscos.CurrentRow != null)
                {
                    Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                    cargarImagen(seleccionado.UrlImagenTapa);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarDisco agregar = new frmAgregarDisco();
            agregar.ShowDialog();
            Actualizar();
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            Disco modificarDisco = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            frmAgregarDisco agregar = new frmAgregarDisco(modificarDisco);
            agregar.ShowDialog();
            Actualizar();
        }

        private void btnEliminarFisicamente_Click(object sender, EventArgs e)
        {
            DialogResult seleccion = MessageBox.Show("¿Estas seguro que deseas eliminarlo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {
                if (seleccion == DialogResult.Yes)
                {
                    DiscoNegocio discoNegocio = new DiscoNegocio();
                    Disco seleccionado;
                    seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                    discoNegocio.eliminarDiscoFisicamente(seleccionado.Id);
                    Actualizar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void txtbFiltrar_TextChanged(object sender, EventArgs e)
        {
            List<Disco> listaFiltrada;
            string filtro = txtbFiltrar.Text;
           
            if (filtro.Length >= 3)
            {
                // BUENAS PRACTICAS SERIA TENER 2 LISTAS DIFERENTES, UNA LISTA DE DISCOS Y LA OTRA CON LOS DISCOS FILTRADOS.
                // REEVER
                listaFiltrada = listaDiscos.FindAll(x => x.Titulo.ToUpper().Contains(txtbFiltrar.Text.ToUpper()) || x.FechaLanzamiento.Year.ToString() == (txtbFiltrar.Text));            
            }
            else
            {
                listaFiltrada = listaDiscos;
            }

            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            if (cbCampo.SelectedItem.ToString() == "Nombre del disco")                
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Empieza con");
                cbCriterio.Items.Add("Termina con");
                cbCriterio.Items.Add("Contiene");
                txtbFiltroAvanzado.Enabled = true;
            }
            else if (cbCampo.SelectedItem.ToString() == "Año de lanzamiento")
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Despues del");
                cbCriterio.Items.Add("Antes del");
                cbCriterio.Items.Add("Año exacto");
                txtbFiltroAvanzado.Enabled = true;

                // ANTES DE SEGUIR, FIJATE EL VIDEO DE LAS VALIDACIONES Y QUE ESTA PARTE SEA UN DATE TIME PICKER DONDE ELIJA LA FECHA.
                // O INDICARLE COMO DEBE PONER EL AÑO, MES Y EL DIA EN EL TEXT BOX....
            }
            else
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Pop Punk");
                cbCriterio.Items.Add("Pop");
                cbCriterio.Items.Add("Rock");
                cbCriterio.Items.Add("Grunge");
                cbCriterio.Items.Add("Phonk");
                cbCriterio.Items.Add("Clasica");
                cbCriterio.Items.Add("Todos");
                txtbFiltroAvanzado.Enabled = false;
                txtbFiltroAvanzado.Clear();

            }
        }

        private void btnFiltroAvanzado_Click(object sender, EventArgs e)
        {
            DiscoNegocio discoNegocio = new DiscoNegocio();
            try
            {
                string campo = cbCampo.SelectedItem.ToString();
                string criterio = cbCriterio.SelectedItem.ToString();
                if (cbCampo.SelectedItem.ToString() == "Año de lanzamiento")                 
                    string filtro = dtpFiltro.Value.ToString();

                if (txtbFiltroAvanzado.Enabled == false)
                {
                    filtro = criterio;
                }
                else
                {
                    filtro = txtbFiltroAvanzado.Text;
                }   
                
                dgvDiscos.DataSource = discoNegocio.filtroAvanzado(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
