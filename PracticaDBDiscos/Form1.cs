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

namespace PracticaDBDiscos
{
    public partial class Form1 : Form
    {
        // Defino un atributo en la clase form donde voy a guardar
        // la lista de objetos "Disco" que armo con la info que traigo desde
        // la DB.
        private List<Disco> listaDisco;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cargar();
            
        }

        private void cargar()
        {
            try
            {
                DiscoNegocio discoNegocio = new DiscoNegocio();

                //Aca le asigno a ese atributo la lista que arme con el metodo "listarDiscos()"
                listaDisco = discoNegocio.listarDiscos();
                //Aca sigo haciendo lo mismo, le paso la lista al dataGridView
                dgvDiscos.DataSource = listaDisco;
                dgvDiscos.Columns["UrlTapa"].Visible = false;
                dgvDiscos.Columns["Id"].Visible = false;
                dgvDiscos.Columns["FechaLanzamiento"].DefaultCellStyle.Format = "dd/MM/yyyy";



                // ----------------------------CARGAR DATOS POR DEFECTO--------------------------------

                //Aca cargo en el pictureBox la url del primer objeto "Disco" de la lista "listaDisco"
                cargarImagen(listaDisco[0].urlTapa);
                lblTitulo.Text = listaDisco[0].Titulo;
                lblArtista.Text = listaDisco[0].Artista.Nombre;
                lblCantCanciones.Text = listaDisco[0].CantCanciones.ToString();
                lblFechaLanzamiento.Text = listaDisco[0].FechaLanzamiento.Year.ToString();
                lblGenero.Text = listaDisco[0].Estilo.Genero;
                lblCantCanciones.Text = listaDisco[0].CantCanciones.ToString() + " Tracks";
                FijarExtremoDerecho(lblGenero);

                pbAdorno.Load("https://png.pngtree.com/png-vector/20231016/ourmid/pngtree-vinyl-disc-png-image_10188179.png");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Disco seleccionado;
                if (dgvDiscos.CurrentRow != null) seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                else return;

                cargarImagen(seleccionado.urlTapa);
                lblTitulo.Text = seleccionado.Titulo;
                lblArtista.Text = seleccionado.Artista.Nombre;
                lblCantCanciones.Text = seleccionado.CantCanciones.ToString();
                lblFechaLanzamiento.Text = seleccionado.FechaLanzamiento.Year.ToString();
                lblGenero.Text = seleccionado.Estilo.Genero;
                lblCantCanciones.Text = seleccionado.CantCanciones.ToString() + " Tracks";
                FijarExtremoDerecho(lblGenero);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbTapa.Load(imagen);
            }
            catch (Exception)
            {

                pbTapa.Load("https://www.kurin.com/wp-content/uploads/placeholder-square.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDisco ventana = new AgregarDisco();  
            ventana.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado;
            seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            AgregarDisco ventana = new AgregarDisco(seleccionado);
            ventana.ShowDialog();
            cargar();
        }

        private void Eliminar (bool logico = true)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            Disco seleccionado;
            if (dgvDiscos.CurrentRow != null) seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            else
            {
                MessageBox.Show("Seleccione el disco a eliminar");
                return;
            }

            DialogResult result = MessageBox.Show("Seguro quiere eliminar el disco '" + seleccionado.Titulo + "'", "Eliminar Disco", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (logico)
                {

                    negocio.EliminarLogico(seleccionado);
                }
                else negocio.EliminarFisico(seleccionado);

                cargar();
            }
            
            
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            try
            {
                Eliminar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            try
            {
                Eliminar(false);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FijarExtremoDerecho(Label label)
        {
            int fixedRightPosition = 433; // Posición X del extremo derecho (ajusta según necesites)
            label.Left = fixedRightPosition - label.Width;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Disco> listaFiltrada;

            listaFiltrada = listaDisco.FindAll(x => x.Titulo.ToUpper().Contains(txtFiltro.Text.ToUpper()));

            dgvDiscos.DataSource = listaFiltrada;
        }
    }   
            
}
