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
    public partial class RegistroUsuarios : Form
    {
        Usuarios modelo = new Usuarios();

        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtUsername.Text = txtPassword.Text = txtConfPass.Text = "";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != txtConfPass.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else
            {
                modelo.Username = txtUsername.Text.Trim();
                //modelo.Password = txtPassword.Text.Trim();
            }
        }
    }
}
