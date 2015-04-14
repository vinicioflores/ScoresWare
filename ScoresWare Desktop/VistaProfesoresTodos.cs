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
    public partial class VistaProfesoresTodos : UserControl
    {
        public VistaProfesoresTodos()
        {
            InitializeComponent();
            this.loadProfesores();
        }

        public void loadProfesores(){
                        
            profesorTableAdapter.Fill(scoresWarehouseDBDataSet.Profesor);
            usuarioTableAdapter.Fill(scoresWarehouseDBDataSet.Usuario);
        }

        private void profesorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.profesorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.scoresWarehouseDBDataSet);

        }

        private void profesorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormularioAgregarProfesor addProf = new FormularioAgregarProfesor();
            addProf.Show();
            addProf.vista = this;
        }
    }
}
