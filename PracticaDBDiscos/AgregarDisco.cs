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
        public AgregarDisco()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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

        private void AgregarDisco_Load(object sender, EventArgs e)
        {
            EstiloNegocio en = new EstiloNegocio();
            AutorNegocio an = new AutorNegocio();
            try
            {
                cbEstilo.DataSource = en.listarEstilos();
                cbArtista.DataSource = an.listarAutores();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
