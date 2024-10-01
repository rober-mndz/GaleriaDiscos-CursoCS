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

                //Aqui le asigno a ese atributo la lista que arme con el metodo "listarDiscos()"
                listaDisco = discoNegocio.listarDiscos();
                //Aca sigo haciendo lo mismo, le paso la lista al dataGridView
                dgvDiscos.DataSource = listaDisco;
                dgvDiscos.Columns["UrlTapa"].Visible = false;


                // ----------------------------CARGAR IMAGEN--------------------------------

                //Aca cargo en el pictureBox la url del primer objeto "Disco" de la lista "listaDisco"
                cargarImagen(listaDisco[0].urlTapa);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.urlTapa);
                
            
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
        }
    }   
            
}
