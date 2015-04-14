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
    public partial class VistaGruposTodos : UserControl
    {
        public VistaGruposTodos()
        {
            InitializeComponent();

            gruposTableAdapter.Fill(scoresWarehouseDBDataSet.Grupos);
            profesorTableAdapter.Fill(scoresWarehouseDBDataSet.Profesor);
            horarioTableAdapter.Fill(scoresWarehouseDBDataSet.Horario);
            cursoTableAdapter.Fill(scoresWarehouseDBDataSet.Curso);
            periodoTableAdapter.Fill(scoresWarehouseDBDataSet.Periodo);
        }

        private void gruposBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gruposBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.scoresWarehouseDBDataSet);

        }

        private void gruposDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
