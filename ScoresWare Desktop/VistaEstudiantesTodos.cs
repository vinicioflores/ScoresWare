using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoresWare_Desktop
{
    public partial class VistaEstudiantesTodos : UserControl
    {
        public VistaEstudiantesTodos()
        {
            InitializeComponent();
            loadEstudiantes();
        }

        public void loadEstudiantes()
        {
            estudianteTableAdapter.Fill(scoresWarehouseDBDataSet.Estudiante);
            usuarioTableAdapter.Fill(scoresWarehouseDBDataSet.Usuario);
            estudiantePorGrupoTableAdapter.Fill(scoresWarehouseDBDataSet.EstudiantePorGrupo);
        }

        private void estudianteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estudianteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.scoresWarehouseDBDataSet);

        }

        private void estudianteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormularioAgregarEstudiante addStudent = new FormularioAgregarEstudiante();
            addStudent.vista = this;
            addStudent.Show();
        }
    }
}
