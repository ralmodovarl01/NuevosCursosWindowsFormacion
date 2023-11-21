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

            int position = int.Parse(aLUMNOSBindingNavigator.PositionItem.Text) - 1;
            int? curso = gcfd.ALUMNOS[position].IsCursoNull() ? (int?)null : gcfd.ALUMNOS[position].Curso;

            // Si el alumno está apuntado a un curso, se debe avisar de ello y preguntar de nuevo al usuario.
            // Solamente en caso de que vuelva a contestar afirmativamente, se eliminará al alumno de la BD.
            if (curso != null)
            {
                DialogResult resultCurso = MessageBox.Show("El alumno está apuntado a un Curso, ¿Desea Eliminarlo?", "Eliminar Alumno", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultCurso == DialogResult.Yes)
                {
                    EliminarAlumno(curso.Value);
                    MessageBox.Show("Alumno asociado eliminado correctamente");
                }
                else
                {
                    EliminarAlumno(curso);
                }
            }
           

        }


        private void EliminarAlumno(int? curso)
        {
            gcfdTableAdapters.ALUMNOSTableAdapter alumnos = new gcfdTableAdapters.ALUMNOSTableAdapter();

            // Verificar si curso es null antes de llamar al método DeleteQueryAlumno
            if (curso != null)
            {
                alumnos.DeleteQueryAlumno(curso.Value);
            }

            this.gcfd.ALUMNOS.AcceptChanges();
            this.aLUMNOSTableAdapter.Fill(this.gcfd.ALUMNOS);
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (fdCaratula.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(fdCaratula.FileName);
            }
        }

        
        

        
    }
}
