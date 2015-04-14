using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoresWare_Desktop
{
    public partial class LoginWindow : Form
    {
        private UserManager userControlClass = new UserManager();
        public MainPanel mainWindow = new MainPanel();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.scoresWarehouseDBDataSet);

        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'scoresWarehouseDBDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            //this.usuarioTableAdapter.Fill(this.scoresWarehouseDBDataSet.Usuario);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool Validate()
        {
            if (usernameTextBox.Text.Equals("") || passwordTextBox.Text.Equals(""))
                return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.Validate())
            {
                MessageBox.Show("No se puede dejar ningún campo de texto en blanco", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = -1;
            object oid = usuarioTableAdapter.GetUsuarioID(usernameTextBox.Text, passwordTextBox.Text);
    
            if (oid != null)
            {
                id = (int)oid;
                userControlClass.current_UID = id;
                userControlClass.current_username = usernameTextBox.Text;
                MessageBox.Show( "Bienvenido(a) " + userControlClass.current_username + " !","Acceso otorgado!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                userControlClass.Login();
                mainWindow = new MainPanel();
                mainWindow.userManager = userControlClass;
                mainWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existe ningun usuario registrado con los datos ingresados", "Error de ingreso",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                userControlClass.Logout();
            }
            usernameTextBox.Text = passwordTextBox.Text = "";
        }
    }
}
