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
    public partial class VistaUsuariosTodos : UserControl
    {
        public VistaUsuariosTodos()
        {
            InitializeComponent();
            usuarioTableAdapter.Fill(scoresWarehouseDBDataSet.Usuario);   
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.scoresWarehouseDBDataSet);

        }

        private void usuarioBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void usuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            usuarioTableAdapter.Fill(scoresWarehouseDBDataSet.Usuario);
        }
    }
}
