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
    public partial class FormularioAgregarEstudiante : Form
    {
        public VistaEstudiantesTodos vista = null;
        public FormularioAgregarEstudiante()
        {
            InitializeComponent();
        }

       
        private void FormularioAgregarEstudiante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'scoresWarehouseDBDataSet.Estudiante' Puede moverla o quitarla según sea necesario. 
            this.estudianteTableAdapter.Fill(this.scoresWarehouseDBDataSet.Estudiante);
            // TODO: esta línea de código carga datos en la tabla 'scoresWarehouseDBDataSet.Grupos' Puede moverla o quitarla según sea necesario.
            this.gruposTableAdapter.Fill(this.scoresWarehouseDBDataSet.Grupos);
            // TODO: esta línea de código carga datos en la tabla 'scoresWarehouseDBDataSet.EstadoEstudiantePorGrupo' Puede moverla o quitarla según sea necesario.
            this.estadoEstudiantePorGrupoTableAdapter.Fill(this.scoresWarehouseDBDataSet.EstadoEstudiantePorGrupo);
            // TODO: esta línea de código carga datos en la tabla 'scoresWarehouseDBDataSet.EstudiantePorGrupo' Puede moverla o quitarla según sea necesario.
            this.estudiantePorGrupoTableAdapter.FillByID(this.scoresWarehouseDBDataSet.EstudiantePorGrupo);
            // TODO: esta línea de código carga datos en la tabla 'scoresWarehouseDBDataSet.EvaluacionesPorEstudiantePorGrupo' Puede moverla o quitarla según sea necesario.
            this.evaluacionesPorEstudiantePorGrupoTableAdapter.Fill(this.scoresWarehouseDBDataSet.EvaluacionesPorEstudiantePorGrupo);
            // TODO: esta línea de código carga datos en la tabla 'scoresWarehouseDBDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.FillByID(this.scoresWarehouseDBDataSet.Usuario);

            this.estudianteBindingSource.MoveLast();
            this.usuarioBindingSource.MoveLast();
            this.estudiantePorGrupoBindingSource.MoveLast();
            this.evaluacionesPorEstudiantePorGrupoBindingSource.MoveLast();

            if (!idTextBox.Text.Equals("")) idTextBox.Text = (Int32.Parse(idTextBox.Text) + 1).ToString();
            else idTextBox.Text = "0";
            if (!idTextBox2.Text.Equals("")) idTextBox2.Text = (Int32.Parse(idTextBox2.Text) + 2).ToString();
            else idTextBox2.Text = "0";
            if (!idTextBox1.Text.Equals("")) idTextBox1.Text = (Int32.Parse(idTextBox1.Text) + 1).ToString(); 
            else idTextBox1.Text = "0";

            usuarioTextBox.Text = idTextBox2.Text;
            estudianteGrupoTextBox.Text = idTextBox1.Text;

            idTextBox.Enabled = idTextBox1.Enabled = idTextBox2.Enabled = usuarioTextBox.Enabled = estudianteGrupoTextBox.Enabled = false;
            usernameTextBox.Text = passwordTextBox.Text = carnetTextBox.Text = "";
            nombreTextBox.Text = primerApellidoTextBox.Text = segundoApellidoTextBox.Text = "";
            emailTextBox.Text = "";
            estadoComboBox.SelectedIndex = grupoComboBox.SelectedIndex = 0;
            notaAcumTextBox.Text = "";

            if (!evaluacionesTextBox.Text.Equals("")) evaluacionesTextBox.Text = (Int32.Parse(evaluacionesTextBox.Text) + 1).ToString();
            else evaluacionesTextBox.Text = "0";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private bool Validate()
        {
            if (usernameTextBox.Text.Equals("") ||
                passwordTextBox.Text.Equals("") ||
                nombreTextBox.Text.Equals("") || notaAcumTextBox.Text.Equals("") 
                || carnetTextBox.Text.Equals("")) return false;
            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(Validate()){
               
               try {
                     usuarioTableAdapter.Insert(Int32.Parse(idTextBox2.Text), usernameTextBox.Text, passwordTextBox.Text, "Estudiante");
                     estudiantePorGrupoTableAdapter.Insert(Int32.Parse(idTextBox1.Text),(int)estadoComboBox.SelectedValue,Int32.Parse(notaAcumTextBox.Text),(int)grupoComboBox.SelectedValue,Int32.Parse(evaluacionesTextBox.Text));
                     estudianteTableAdapter.Insert(Int32.Parse(idTextBox.Text), nombreTextBox.Text,primerApellidoTextBox.Text,segundoApellidoTextBox.Text,Int32.Parse(usuarioTextBox.Text),emailTextBox.Text,Int32.Parse(estudianteGrupoTextBox.Text),Int32.Parse(carnetTextBox.Text));
                     tableAdapterManager.UpdateAll(scoresWarehouseDBDataSet);
                     MessageBox.Show("Insercion exitosa","Se ha guardado el nuevo estudiante "+nombreTextBox.Text+ " correctamente.",MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               catch (Exception e1)
               {
                   MessageBox.Show("Fallo al intentar guardar el nuevo estudiante creado: "+e1.Message+e1.Source+e1.StackTrace, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               vista.loadEstudiantes();
               Dispose();
                
            } else {
                MessageBox.Show("Prohibido dejar información obligatoria en BLANCO", "Error de validación", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if( checkBox1.CheckState == CheckState.Checked){
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
