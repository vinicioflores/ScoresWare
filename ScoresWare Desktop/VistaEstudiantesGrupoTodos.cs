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
    public partial class VistaEstudiantesGrupoTodos : UserControl
    {
        public VistaEstudiantesGrupoTodos()
        {
            InitializeComponent();

            gruposTableAdapter.Fill(scoresWarehouseDBDataSet.Grupos);
            estudiantePorGrupoTableAdapter.Fill(scoresWarehouseDBDataSet.EstudiantePorGrupo);
        }


        private void estudiantePorGrupoBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.estudiantePorGrupoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.scoresWarehouseDBDataSet);

        }

        private void estudiantePorGrupoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VistaEstudiantesGrupoTodos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gruposTableAdapter.Fill(scoresWarehouseDBDataSet.Grupos);
            estudiantePorGrupoTableAdapter.Fill(scoresWarehouseDBDataSet.EstudiantePorGrupo);
        }
    }
}
