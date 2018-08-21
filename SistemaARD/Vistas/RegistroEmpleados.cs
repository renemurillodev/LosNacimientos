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
    public partial class RegistroEmpleados : Form
    {
        private Empleados empleado = new Empleados();
        public RegistroEmpleados()
        {
            InitializeComponent();
        }

        private void RegistroEmpleados_Load(object sender, EventArgs e)
        {
            Clear();
            CargarGeneros();
        }

        void Clear()
        {
            txtNombres.Text = txtApellidos.Text = txtDireccion.Text = txtNumeroDui.Text = txtNumeroNit.Text = txtNumeroIsss.Text = txtNup.Text = "";
            cbxEstado.Text = "";
            cbxNombreAfp.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            dtpFechaIngreso.Value = DateTime.Now;
        }

        void CargarGeneros()
        {
            using (losnacimientosEntities1 db = new losnacimientosEntities1())
            {
                cbxGenero.DataSource = db.Generos.ToList<Generos>();
                cbxGenero.ValueMember = "Id";
                cbxGenero.DisplayMember = "Nombre";
            }
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Debe ingresar todos los campos");
            }
            else
            {
                empleado.Nombres = txtNombres.Text.Trim();
                empleado.Apellidos = txtApellidos.Text.Trim();
                empleado.FechaNacimiento = dtpFechaNacimiento.Value;
                empleado.Direccion = txtDireccion.Text.Trim();
                if(cbxGenero.Text == "Masculino")
                {
                    //empleado.Genero = "M";
                }else if(cbxGenero.Text == "Femenino")
                {
                    //empleado.Genero = "F";
                }else if(cbxGenero.Text == "Otro")
                {
                    //empleado.Genero = "O";
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un género");
                }
                empleado.N_Dui = txtNumeroDui.Text;
                if (cbxNombreAfp.Text == "Confía")
                {
                    //empleado.NombreAFP = "Confía";
                }
                else if (cbxNombreAfp.Text == "Crecer")
                {
                    //empleado.NombreAFP = "Crecer";
                }
                else
                    MessageBox.Show("Debe seleccionar una AFP");

                empleado.N_Afp = txtNup.Text;
                empleado.N_Isss = txtNumeroIsss.Text;
                empleado.N_Nit = txtNumeroNit.Text;
                
                empleado.FechaIngreso = dtpFechaIngreso.Value;
                if (cbxEstado.Text == "Activo")
                {
                    //empleado.Estado = "A";
                }
                else if (cbxEstado.Text == "Inactivo")
                {
                    //empleado.Estado = "I";
                }
                else
                    MessageBox.Show("Debe seleccionar un estado");

                using (losnacimientosEntities1 db = new losnacimientosEntities1())
                {
                    
                    try
                    {
                        db.Empleados.Add(empleado);
                        db.SaveChanges();
                        MessageBox.Show("Datos del empleado almacenados correctamente");
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                    {
                        Exception raise = dbEx;
                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                string message = string.Format("{0}:{1}",
                                    validationErrors.Entry.Entity.ToString(),
                                    validationError.ErrorMessage);
                                // raise a new exception nesting
                                // the current instance as InnerException
                                raise = new InvalidOperationException(message, raise);
                            }
                        }
                        throw raise;
                    }
                }
                
                Clear();
            }
            
        }
    }
}
