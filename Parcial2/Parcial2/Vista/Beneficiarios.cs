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

namespace Parcial2.Vista
{
    public partial class Beneficiarios : Form
    {
        public Beneficiarios()
        {
            InitializeComponent();
        }
            usuarios user = new usuarios();

            void cargardatos()
            {
                using (gobEntities bd = new gobEntities())
                {
                    var usuarios = bd.usuarios;

                    foreach (var iterardatosUsuario in usuarios)
                    {
                        dtvDatos.Rows.Add(iterardatosUsuario.id, iterardatosUsuario.Nombre, iterardatosUsuario.DUI);
                    }  
                }

            }
        void limpiardatos()
        {
            txtNombre.Text = "";
            txtDUI.Text = "";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (gobEntities bd = new gobEntities())
            {
                user.Nombre = txtNombre.Text;
                user.DUI = txtDUI.Text;

                bd.usuarios.Add(user);
                bd.SaveChanges();
            }
            dtvDatos.Rows.Clear();
            cargardatos();
            limpiardatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (gobEntities bd = new gobEntities())
            {
                String Id = dtvDatos.CurrentRow.Cells[0].Value.ToString();
                int idC = int.Parse(Id);
                user = bd.usuarios.Where(VerificarID => VerificarID.id == idC).First();
                user.Nombre = txtNombre.Text;
                user.DUI = txtDUI.Text;
                bd.Entry(user).State = System.Data.Entity.EntityState.Modified;
                bd.SaveChanges();
            }
            dtvDatos.Rows.Clear();
            cargardatos();
            limpiardatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (gobEntities bd = new gobEntities())

            {
                String id = dtvDatos.CurrentRow.Cells[0].Value.ToString();

                user = bd.usuarios.Find(int.Parse(id));
                bd.usuarios.Remove(user);
                bd.SaveChanges();
            }
            dtvDatos.Rows.Clear();
            cargardatos();
            limpiardatos();
        }

        private void Beneficiarios_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void dtvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String nombre = dtvDatos.CurrentRow.Cells[1].Value.ToString();
            String Dui = dtvDatos.CurrentRow.Cells[2].Value.ToString();
            txtNombre.Text = nombre;
            txtDUI.Text = Dui;
        }
    }
}
