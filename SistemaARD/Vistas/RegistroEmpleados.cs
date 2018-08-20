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
        }

        void Clear()
        {
            txtNombres.Text = txtApellidos.Text = txtDireccion.Text = txtNumeroDui.Text = txtNumeroNit.Text = txtNumeroIsss.Text = txtNup.Text = "";
            cbxEstado.Text = "";
            cbxGenero.Text = "";
            cbxNombreAfp.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            dtpFechaIngreso.Value = DateTime.Now;
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
                string fechaNacimientoYear = Convert.ToString(dtpFechaNacimiento.Value.Year);
                string fechaNacimientoMes = Convert.ToString(dtpFechaNacimiento.Value.Month);
                string fechaNacimientoDia = Convert.ToString(dtpFechaNacimiento.Value.Day);
                string fechaNacimiento = fechaNacimientoYear + "/" + fechaNacimientoMes + "/" + fechaNacimientoDia;
                empleado.FechaIngreso = Convert.ToDateTime(fechaNacimiento);
                empleado.FechaNacimiento = dtpFechaNacimiento.Value;
                empleado.Direccion = txtDireccion.Text.Trim();
                if(cbxGenero.Text == "Masculino")
                {
                    empleado.Genero = "M";
                }else if(cbxGenero.Text == "Femenino")
                {
                    empleado.Genero = "F";
                }else if(cbxGenero.Text == "Otro")
                {
                    empleado.Genero = "O";
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un género");
                }
                empleado.N_Dui = txtNumeroDui.Text;
                if (cbxNombreAfp.Text == "Confía")
                {
                    empleado.NombreAFP = "Confía";
                }
                else if (cbxNombreAfp.Text == "Crecer")
                {
                    empleado.NombreAFP = "Crecer";
                }
                else
                    MessageBox.Show("Debe seleccionar una AFP");

                empleado.N_Afp = txtNup.Text;
                empleado.N_Isss = txtNumeroIsss.Text;
                empleado.N_Nit = txtNumeroNit.Text;
                string fechaIngresoYear = Convert.ToString(dtpFechaIngreso.Value.Year);
                string fechaIngresoMes = Convert.ToString(dtpFechaIngreso.Value.Month);
                string fechaIngresoDia = Convert.ToString(dtpFechaIngreso.Value.Day);
                string fechaIngreso = fechaIngresoYear + "/" + fechaIngresoMes + "/" + fechaIngresoDia;
                empleado.FechaIngreso = Convert.ToDateTime(fechaIngreso);
                if (cbxEstado.Text == "Activo")
                {
                    empleado.Estado = "A";
                }
                else if (cbxEstado.Text == "Inactivo")
                {
                    empleado.Estado = "I";
                }
                else
                    MessageBox.Show("Debe seleccionar un estado");

                using (DBEntities db = new DBEntities())
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
