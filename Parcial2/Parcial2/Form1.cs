using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2.Model;
using Parcial2.Vista;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void cargarDatos()
        {
            using(gobEntities bd = new gobEntities())
            {
                var listaDui = from user in bd.usuarios
                               where user.DUI == txtConsultar.Text

                               select new
                               {
                                   nombre = user.Nombre
                               };
                if (listaDui.Count()> 0)
                {
                    foreach(var iterar in listaDui)
                    {
                        lbNoEresBeneficiario.Visible = false;
                        lbNombre.Visible = true;
                        lbBeneficiario.Visible = true;
                        lbNombre.Text = iterar.nombre;
                    }
                }
                else
                {
                    lbNombre.Visible = false;
                    lbBeneficiario.Visible = false;
                    lbNoEresBeneficiario.Visible = true;
                }
            }
            
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Loguin busqueda = new Loguin();
            //busqueda.MdiParent = this;
            busqueda.Show();

           
        }
    }
}
