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
    public partial class FormularioAgregarProfesor : Form
    {
        public VistaProfesoresTodos vista = null;
        public FormularioAgregarProfesor()
        {
            InitializeComponent();
        }

        private void profesorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.profesorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.scoresWarehouseDBDataSet);

        }

        private void FormularioAgregarProfesor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'scoresWarehouseDBDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.scoresWarehouseDBDataSet.Usuario);
            // TODO: esta línea de código carga datos en la tabla 'scoresWarehouseDBDataSet.Profesor' Puede moverla o quitarla según sea necesario.
            this.profesorTableAdapter.Fill(this.scoresWarehouseDBDataSet.Profesor);

            usuarioBindingSource.MoveLast();
            profesorBindingSource.MoveLast();

            nombreTextBox.Text = primerApellidoTextBox.Text = segundoApellidoTextBox.Text = "";
            usernameTextBox.Text = passwordTextBox.Text = codigoTextBox.Text = "";

            idTextBox.Text = (Int32.Parse(idTextBox.Text) + 1).ToString();
            idTextBox1.Text = (Int32.Parse(idTextBox1.Text) + 2).ToString();
            usuarioTextBox.Text = idTextBox1.Text;
        }

        private bool Validate()
        {
            if (nombreTextBox.Text.Equals("") || usernameTextBox.Text.Equals("") || codigoTextBox.Text.Equals("")
                || passwordTextBox.Text.Equals("")) return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                try 
                {
                    usuarioTableAdapter.Insert(Int32.Parse(idTextBox1.Text), usernameTextBox.Text, passwordTextBox.Text, "Profesor");
                    profesorTableAdapter.Insert(Int32.Parse(idTextBox.Text), nombreTextBox.Text, primerApellidoTextBox.Text, segundoApellidoTextBox.Text, Int32.Parse(usuarioTextBox.Text), Int32.Parse(codigoTextBox.Text));
                    tableAdapterManager.UpdateAll(scoresWarehouseDBDataSet);
                    MessageBox.Show("Inserción del profesor "+nombreTextBox.Text+" realizada exitosamente!","Inserción exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    vista.loadProfesores();
                    Dispose();

                } catch(Exception  err1)
                {
                    MessageBox.Show("Error al intentar insertar al nuevo profesor: "+err1.Message+err1.Source+err1.StackTrace,
                        "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("No se puede dejar campos vacíos, debe rellenar con la información requerida",
                    "Error de validación",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
