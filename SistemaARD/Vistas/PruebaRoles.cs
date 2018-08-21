using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaARD.Vistas
{
    public partial class PruebaRoles : Form
    {
        Roles modelo = new Roles();
        public PruebaRoles()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txtNombre.Text = txtDescripcion.Text = "";
            btnCancelar.Enabled = false;
            modelo.Id = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            modelo.Nombre = txtNombre.Text.Trim();
            modelo.Descripcion = txtDescripcion.Text.Trim();

            using (losnacimientosEntities1 db = new losnacimientosEntities1())
            {
                if (modelo.Id == 0)
                    db.Roles.Add(modelo);
                else
                    db.Entry(modelo).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            LlenarDataGrid();
            MessageBox.Show("Rol almacenado con éxito");
        }

        void LlenarDataGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (losnacimientosEntities1 db = new losnacimientosEntities1())
            {
                dataGridView1.DataSource = db.Roles.ToList<Roles>();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                modelo.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                using (losnacimientosEntities1 db = new losnacimientosEntities1())
                {
                    modelo = db.Roles.Where(x => x.Id == modelo.Id).FirstOrDefault();
                    txtNombre.Text = modelo.Nombre;
                    txtDescripcion.Text = modelo.Descripcion;
                }
                btnGuardar.Text = "Actualizar";
                btnEliminar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (losnacimientosEntities1 db = new losnacimientosEntities1())
                {
                    var entry = db.Entry(modelo);
                    if (entry.State == EntityState.Detached)
                        db.Roles.Attach(modelo);
                    db.Roles.Remove(modelo);
                    db.SaveChanges();
                    LlenarDataGrid();
                    Clear();
                    MessageBox.Show("Eliminado con éxito");
                }
                btnGuardar.Text = "Guardar";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void PruebaRoles_Load(object sender, EventArgs e)
        {
            Clear();
            LlenarDataGrid();
        }
    }
}
