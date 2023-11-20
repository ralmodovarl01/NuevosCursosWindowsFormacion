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
    public partial class FormAlumnos : Form
    {
        public FormAlumnos()
        {
            InitializeComponent();
        }

        private void aLUMNOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aLUMNOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gcfd);

        }

        private void FormAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gcfd.CURSOS' Puede moverla o quitarla según sea necesario.
            this.cURSOSTableAdapter.Fill(this.gcfd.CURSOS);
            // TODO: esta línea de código carga datos en la tabla 'gcfd.ALUMNOS' Puede moverla o quitarla según sea necesario.
            this.aLUMNOSTableAdapter.Fill(this.gcfd.ALUMNOS);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {

        }

        private void dameCursos()
        {

        }
    }
}
