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
    public partial class AgregarDisco : Form
    {
        private Disco disco = null;

        public AgregarDisco()
        {
            InitializeComponent();
        }
        public AgregarDisco(Disco e)
        {
            InitializeComponent();
            disco = e;
            lblIngreseData.Text = "Modifique la informacion que desee";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (disco == null)
            {
                InsertarDisco();
            }
            else ModificarDisco();
        }

        private void AgregarDisco_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            EstiloNegocio en = new EstiloNegocio();
            AutorNegocio an = new AutorNegocio();
            try
            {
                cbEstilo.DataSource = en.listarEstilos();
                cbArtista.DataSource = an.listarAutores();
                cbEstilo.Text = "";
                cbArtista.Text = "";

                if (disco != null)
                {
                    txtTitulo.Text = disco.Titulo;
                    dtpFechaLanzamiento.Value = disco.FechaLanzamiento;
                    txtCantCanciones.Text = disco.CantCanciones.ToString();
                    txtUrlTapa.Text = disco.urlTapa;
                    cbEstilo.Text = disco.Estilo.Genero;
                    cbArtista.Text = disco.Artista.Nombre;
                    cargarImagen(txtUrlTapa.Text);
                }
                else pbAgregarDisco.Load("https://www.kurin.com/wp-content/uploads/placeholder-square.jpg");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void InsertarDisco()
        {
            Disco disc = new Disco();
            Estilo est = new Estilo();
            Autor aut = new Autor();
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                disc.Titulo = txtTitulo.Text;
                disc.FechaLanzamiento = dtpFechaLanzamiento.Value;
                disc.CantCanciones = int.Parse(txtCantCanciones.Text);
                disc.urlTapa = txtUrlTapa.Text;
                est.Genero = cbEstilo.Text;
                aut.Nombre = cbArtista.Text;

                negocio.InsertarDisco(disc, est, aut);
                MessageBox.Show("Agregado Exitosamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ModificarDisco()
        {

            try
            {
                DiscoNegocio disconegocio = new DiscoNegocio();
                Estilo est = new Estilo();
                Autor aut = new Autor();

                disco.Titulo = txtTitulo.Text;
                disco.FechaLanzamiento = dtpFechaLanzamiento.Value;
                disco.CantCanciones = int.Parse(txtCantCanciones.Text);
                disco.urlTapa= txtUrlTapa.Text;
                est.Genero = cbEstilo.Text;
                aut.Nombre = cbArtista.Text;

                disconegocio.ModificarDisco(disco, est, aut);
                MessageBox.Show("Modificado Exitosamente");
                Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cargarImagen(string s)
        {
            try
            {
                pbAgregarDisco.Load(s);
            }
            catch (Exception)
            {
                pbAgregarDisco.Load("https://www.kurin.com/wp-content/uploads/placeholder-square.jpg");
            }
        }

        private void txtUrlTapa_Leave(object sender, EventArgs e)
        {
            try
            {
                pbAgregarDisco.Load(txtUrlTapa.Text);
            }
            catch (Exception)
            {
                pbAgregarDisco.Load("https://www.kurin.com/wp-content/uploads/placeholder-square.jpg");
            }
        }

    }
}
