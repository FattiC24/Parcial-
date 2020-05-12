using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2.Vista
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Master")
            {
                if (txtContraseña.Text == "123")
                {
                    Beneficiarios abrir = new Beneficiarios();
                    abrir.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }
    }
}
