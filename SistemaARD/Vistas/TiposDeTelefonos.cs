using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaARD.Vistas
{
    public partial class TiposDeTelefonos : Form
    {
        private TiposTelefonos tiposTel = new TiposTelefonos();
        public TiposDeTelefonos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
            else { 
            tiposTel.Nombre = txtNombre.Text.Trim();
            using (losnacimientosEntities1 db = new losnacimientosEntities1())
            {
                db.TiposTelefonos.Add(tiposTel);
                db.SaveChanges();
            }
            MessageBox.Show("Tipo de teléfono almacenado con éxito");
                txtNombre.Text = "";
            }
        }

        private void TiposDeTelefonos_Load(object sender, EventArgs e)
        {

        }
    }
}
