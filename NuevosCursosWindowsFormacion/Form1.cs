using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevosCursosWindowsFormacion
{
    public partial class Form1 : Form
    {
        private Form formularioActual;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void MostrarFormulario(Form form)
        {
            if (formularioActual != null)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de cerrar la ventana actual?", "Cerrar ventana", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return; // No abrir el nuevo formulario si el usuario no confirma
                }

                formularioActual.Close(); // Cerrar el formulario actual si el usuario confirma
            }

            form.MdiParent = this; // Establecer el formulario como formulario secundario del formulario principal
            form.Dock = DockStyle.Fill; // Rellenar completamente el formulario principal
            form.FormBorderStyle = FormBorderStyle.None; // Eliminar el borde del formulario secundario
            form.Show(); // Mostrar el nuevo formulario
            formularioActual = form;
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlumnos formAlumnos = new FormAlumnos();
            MostrarFormulario(formAlumnos);

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminCurso formCurso = new FormAdminCurso();
            MostrarFormulario(formCurso);
        }

        private void incripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInscripcion inscri = new FormInscripcion();
            MostrarFormulario(inscri);
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de cerrar la aplicación?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Cerrar la aplicación si el usuario confirma
            }
        }
    }
}
