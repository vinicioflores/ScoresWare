namespace ScoresWare_Desktop
{
    partial class FormularioAgregarEstudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label primerApellidoLabel;
            System.Windows.Forms.Label segundoApellidoLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label estudianteGrupoLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label idLabel3;
            System.Windows.Forms.Label notaAcumLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label grupoLabel;
            System.Windows.Forms.Label carnetLabel;
            System.Windows.Forms.Label evaluacionesLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.carnetTextBox = new System.Windows.Forms.TextBox();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoresWarehouseDBDataSet = new ScoresWare_Desktop.ScoresWarehouseDBDataSet();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.primerApellidoTextBox = new System.Windows.Forms.TextBox();
            this.segundoApellidoTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.estudianteGrupoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.evaluacionesTextBox = new System.Windows.Forms.TextBox();
            this.estudiantePorGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.idTextBox2 = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grupoComboBox = new System.Windows.Forms.ComboBox();
            this.estudiantePorGrupoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.estadoEstudiantePorGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.notaAcumTextBox = new System.Windows.Forms.TextBox();
            this.estudianteTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.EstudianteTableAdapter();
            this.tableAdapterManager = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.TableAdapterManager();
            this.estadoEstudiantePorGrupoTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.EstadoEstudiantePorGrupoTableAdapter();
            this.estudiantePorGrupoTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.EstudiantePorGrupoTableAdapter();
            this.usuarioTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.UsuarioTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.gruposTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.GruposTableAdapter();
            this.evaluacionesPorEstudiantePorGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evaluacionesPorEstudiantePorGrupoTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.EvaluacionesPorEstudiantePorGrupoTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            primerApellidoLabel = new System.Windows.Forms.Label();
            segundoApellidoLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            estudianteGrupoLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            idLabel3 = new System.Windows.Forms.Label();
            notaAcumLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            grupoLabel = new System.Windows.Forms.Label();
            carnetLabel = new System.Windows.Forms.Label();
            evaluacionesLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresWarehouseDBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantePorGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantePorGrupoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoEstudiantePorGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesPorEstudiantePorGrupoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(21, 32);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(21, 58);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // primerApellidoLabel
            // 
            primerApellidoLabel.AutoSize = true;
            primerApellidoLabel.Location = new System.Drawing.Point(21, 84);
            primerApellidoLabel.Name = "primerApellidoLabel";
            primerApellidoLabel.Size = new System.Drawing.Size(79, 13);
            primerApellidoLabel.TabIndex = 4;
            primerApellidoLabel.Text = "Primer Apellido:";
            // 
            // segundoApellidoLabel
            // 
            segundoApellidoLabel.AutoSize = true;
            segundoApellidoLabel.Location = new System.Drawing.Point(21, 110);
            segundoApellidoLabel.Name = "segundoApellidoLabel";
            segundoApellidoLabel.Size = new System.Drawing.Size(93, 13);
            segundoApellidoLabel.TabIndex = 6;
            segundoApellidoLabel.Text = "Segundo Apellido:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(21, 136);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(26, 13);
            usuarioLabel.TabIndex = 8;
            usuarioLabel.Text = "UID";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(21, 162);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email";
            // 
            // estudianteGrupoLabel
            // 
            estudianteGrupoLabel.AutoSize = true;
            estudianteGrupoLabel.Location = new System.Drawing.Point(21, 188);
            estudianteGrupoLabel.Name = "estudianteGrupoLabel";
            estudianteGrupoLabel.Size = new System.Drawing.Size(33, 13);
            estudianteGrupoLabel.TabIndex = 12;
            estudianteGrupoLabel.Text = "EGID";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(6, 61);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(55, 13);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(6, 87);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(53, 13);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // idLabel3
            // 
            idLabel3.AutoSize = true;
            idLabel3.Location = new System.Drawing.Point(17, 29);
            idLabel3.Name = "idLabel3";
            idLabel3.Size = new System.Drawing.Size(33, 13);
            idLabel3.TabIndex = 0;
            idLabel3.Text = "EGID";
            // 
            // notaAcumLabel
            // 
            notaAcumLabel.AutoSize = true;
            notaAcumLabel.Location = new System.Drawing.Point(17, 81);
            notaAcumLabel.Name = "notaAcumLabel";
            notaAcumLabel.Size = new System.Drawing.Size(70, 13);
            notaAcumLabel.TabIndex = 4;
            notaAcumLabel.Text = "Nota General";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(17, 55);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 7;
            estadoLabel.Text = "Estado:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(6, 36);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(26, 13);
            idLabel1.TabIndex = 5;
            idLabel1.Text = "UID";
            // 
            // grupoLabel
            // 
            grupoLabel.AutoSize = true;
            grupoLabel.Location = new System.Drawing.Point(17, 107);
            grupoLabel.Name = "grupoLabel";
            grupoLabel.Size = new System.Drawing.Size(39, 13);
            grupoLabel.TabIndex = 8;
            grupoLabel.Text = "Grupo:";
            // 
            // carnetLabel
            // 
            carnetLabel.AutoSize = true;
            carnetLabel.Location = new System.Drawing.Point(21, 213);
            carnetLabel.Name = "carnetLabel";
            carnetLabel.Size = new System.Drawing.Size(35, 13);
            carnetLabel.TabIndex = 14;
            carnetLabel.Text = "Carné";
            // 
            // evaluacionesLabel
            // 
            evaluacionesLabel.AutoSize = true;
            evaluacionesLabel.Location = new System.Drawing.Point(13, 206);
            evaluacionesLabel.Name = "evaluacionesLabel";
            evaluacionesLabel.Size = new System.Drawing.Size(74, 13);
            evaluacionesLabel.TabIndex = 7;
            evaluacionesLabel.Text = "ID Evaluacion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(carnetLabel);
            this.groupBox1.Controls.Add(this.carnetTextBox);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(primerApellidoLabel);
            this.groupBox1.Controls.Add(this.primerApellidoTextBox);
            this.groupBox1.Controls.Add(segundoApellidoLabel);
            this.groupBox1.Controls.Add(this.segundoApellidoTextBox);
            this.groupBox1.Controls.Add(usuarioLabel);
            this.groupBox1.Controls.Add(this.usuarioTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(estudianteGrupoLabel);
            this.groupBox1.Controls.Add(this.estudianteGrupoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de estudiante";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // carnetTextBox
            // 
            this.carnetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "carnet", true));
            this.carnetTextBox.Location = new System.Drawing.Point(120, 210);
            this.carnetTextBox.Name = "carnetTextBox";
            this.carnetTextBox.Size = new System.Drawing.Size(100, 20);
            this.carnetTextBox.TabIndex = 15;
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataMember = "Estudiante";
            this.estudianteBindingSource.DataSource = this.scoresWarehouseDBDataSet;
            // 
            // scoresWarehouseDBDataSet
            // 
            this.scoresWarehouseDBDataSet.DataSetName = "ScoresWarehouseDBDataSet";
            this.scoresWarehouseDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(120, 29);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(120, 55);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 3;
            // 
            // primerApellidoTextBox
            // 
            this.primerApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "PrimerApellido", true));
            this.primerApellidoTextBox.Location = new System.Drawing.Point(120, 81);
            this.primerApellidoTextBox.Name = "primerApellidoTextBox";
            this.primerApellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.primerApellidoTextBox.TabIndex = 5;
            // 
            // segundoApellidoTextBox
            // 
            this.segundoApellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "SegundoApellido", true));
            this.segundoApellidoTextBox.Location = new System.Drawing.Point(120, 107);
            this.segundoApellidoTextBox.Name = "segundoApellidoTextBox";
            this.segundoApellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.segundoApellidoTextBox.TabIndex = 7;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(120, 133);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.usuarioTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(120, 159);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 11;
            // 
            // estudianteGrupoTextBox
            // 
            this.estudianteGrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudianteBindingSource, "estudianteGrupo", true));
            this.estudianteGrupoTextBox.Location = new System.Drawing.Point(120, 185);
            this.estudianteGrupoTextBox.Name = "estudianteGrupoTextBox";
            this.estudianteGrupoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estudianteGrupoTextBox.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(idLabel1);
            this.groupBox2.Controls.Add(this.idTextBox2);
            this.groupBox2.Controls.Add(usernameLabel);
            this.groupBox2.Controls.Add(this.usernameTextBox);
            this.groupBox2.Controls.Add(passwordLabel);
            this.groupBox2.Controls.Add(this.passwordTextBox);
            this.groupBox2.Location = new System.Drawing.Point(262, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del usuario asociado";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // evaluacionesTextBox
            // 
            this.evaluacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudiantePorGrupoBindingSource, "evaluaciones", true));
            this.evaluacionesTextBox.Enabled = false;
            this.evaluacionesTextBox.Location = new System.Drawing.Point(93, 203);
            this.evaluacionesTextBox.Name = "evaluacionesTextBox";
            this.evaluacionesTextBox.Size = new System.Drawing.Size(101, 20);
            this.evaluacionesTextBox.TabIndex = 8;
            // 
            // estudiantePorGrupoBindingSource
            // 
            this.estudiantePorGrupoBindingSource.DataMember = "FK_Estudiante_EstudiantePorGrupo";
            this.estudiantePorGrupoBindingSource.DataSource = this.estudianteBindingSource;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(175, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Visible?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // idTextBox2
            // 
            this.idTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "id", true));
            this.idTextBox2.Location = new System.Drawing.Point(68, 33);
            this.idTextBox2.Name = "idTextBox2";
            this.idTextBox2.Size = new System.Drawing.Size(100, 20);
            this.idTextBox2.TabIndex = 6;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "FK_Estudiante_Usuario";
            this.usuarioBindingSource.DataSource = this.estudianteBindingSource;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(68, 58);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(68, 84);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(evaluacionesLabel);
            this.groupBox3.Controls.Add(this.evaluacionesTextBox);
            this.groupBox3.Controls.Add(grupoLabel);
            this.groupBox3.Controls.Add(this.grupoComboBox);
            this.groupBox3.Controls.Add(estadoLabel);
            this.groupBox3.Controls.Add(this.estadoComboBox);
            this.groupBox3.Controls.Add(idLabel3);
            this.groupBox3.Controls.Add(this.idTextBox1);
            this.groupBox3.Controls.Add(notaAcumLabel);
            this.groupBox3.Controls.Add(this.notaAcumTextBox);
            this.groupBox3.Location = new System.Drawing.Point(566, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 235);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del grupo asociado";
            // 
            // grupoComboBox
            // 
            this.grupoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudiantePorGrupoBindingSource, "Grupo", true));
            this.grupoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.estudiantePorGrupoBindingSource1, "Grupo", true));
            this.grupoComboBox.DataSource = this.gruposBindingSource;
            this.grupoComboBox.DisplayMember = "codigo";
            this.grupoComboBox.FormattingEnabled = true;
            this.grupoComboBox.Location = new System.Drawing.Point(93, 104);
            this.grupoComboBox.Name = "grupoComboBox";
            this.grupoComboBox.Size = new System.Drawing.Size(101, 21);
            this.grupoComboBox.TabIndex = 9;
            this.grupoComboBox.ValueMember = "id";
            // 
            // estudiantePorGrupoBindingSource1
            // 
            this.estudiantePorGrupoBindingSource1.DataMember = "EstudiantePorGrupo";
            this.estudiantePorGrupoBindingSource1.DataSource = this.scoresWarehouseDBDataSet;
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataMember = "Grupos";
            this.gruposBindingSource.DataSource = this.scoresWarehouseDBDataSet;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudiantePorGrupoBindingSource, "Estado", true));
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.estudiantePorGrupoBindingSource1, "Estado", true));
            this.estadoComboBox.DataSource = this.estadoEstudiantePorGrupoBindingSource;
            this.estadoComboBox.DisplayMember = "estadoNombre";
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(93, 52);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(101, 21);
            this.estadoComboBox.TabIndex = 8;
            this.estadoComboBox.ValueMember = "id";
            // 
            // estadoEstudiantePorGrupoBindingSource
            // 
            this.estadoEstudiantePorGrupoBindingSource.DataMember = "EstadoEstudiantePorGrupo";
            this.estadoEstudiantePorGrupoBindingSource.DataSource = this.scoresWarehouseDBDataSet;
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudiantePorGrupoBindingSource, "id", true));
            this.idTextBox1.Location = new System.Drawing.Point(93, 26);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idTextBox1.TabIndex = 1;
            // 
            // notaAcumTextBox
            // 
            this.notaAcumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estudiantePorGrupoBindingSource, "NotaAcum", true));
            this.notaAcumTextBox.Location = new System.Drawing.Point(93, 78);
            this.notaAcumTextBox.Name = "notaAcumTextBox";
            this.notaAcumTextBox.Size = new System.Drawing.Size(100, 20);
            this.notaAcumTextBox.TabIndex = 5;
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AulaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CantidadInstanciasTableAdapter = null;
            this.tableAdapterManager.ContadorInstanciasTableAdapter = null;
            this.tableAdapterManager.CursoTableAdapter = null;
            this.tableAdapterManager.EstadoEstudiantePorGrupoTableAdapter = this.estadoEstudiantePorGrupoTableAdapter;
            this.tableAdapterManager.EstudiantePorGrupoTableAdapter = this.estudiantePorGrupoTableAdapter;
            this.tableAdapterManager.EstudianteTableAdapter = this.estudianteTableAdapter;
            this.tableAdapterManager.EvaluacionesPorEstudiantePorGrupoTableAdapter = null;
            this.tableAdapterManager.EvaluacionesTableAdapter = null;
            this.tableAdapterManager.FranjaHorariaTableAdapter = null;
            this.tableAdapterManager.GruposTableAdapter = null;
            this.tableAdapterManager.HorarioTableAdapter = null;
            this.tableAdapterManager.InstanciaEvaluacionFijaTableAdapter = null;
            this.tableAdapterManager.InstanciaEvaluacionNoFijaTableAdapter = null;
            this.tableAdapterManager.PeriodoTableAdapter = null;
            this.tableAdapterManager.ProfesorTableAdapter = null;
            this.tableAdapterManager.RubrosEvaluacionesTableAdapter = null;
            this.tableAdapterManager.TipoEvaluacionPorGrupoTableAdapter = null;
            this.tableAdapterManager.TiposEvaluacionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // estadoEstudiantePorGrupoTableAdapter
            // 
            this.estadoEstudiantePorGrupoTableAdapter.ClearBeforeFill = true;
            // 
            // estudiantePorGrupoTableAdapter
            // 
            this.estudiantePorGrupoTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(832, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar estudiante";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gruposTableAdapter
            // 
            this.gruposTableAdapter.ClearBeforeFill = true;
            // 
            // evaluacionesPorEstudiantePorGrupoBindingSource
            // 
            this.evaluacionesPorEstudiantePorGrupoBindingSource.DataMember = "EvaluacionesPorEstudiantePorGrupo";
            this.evaluacionesPorEstudiantePorGrupoBindingSource.DataSource = this.scoresWarehouseDBDataSet;
            // 
            // evaluacionesPorEstudiantePorGrupoTableAdapter
            // 
            this.evaluacionesPorEstudiantePorGrupoTableAdapter.ClearBeforeFill = true;
            // 
            // FormularioAgregarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormularioAgregarEstudiante";
            this.Text = "Formulario de registro de estudiante nuevo";
            this.Load += new System.EventHandler(this.FormularioAgregarEstudiante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresWarehouseDBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantePorGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantePorGrupoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoEstudiantePorGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesPorEstudiantePorGrupoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private ScoresWarehouseDBDataSet scoresWarehouseDBDataSet;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private ScoresWarehouseDBDataSetTableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        private ScoresWarehouseDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox primerApellidoTextBox;
        private System.Windows.Forms.TextBox segundoApellidoTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox estudianteGrupoTextBox;
        private ScoresWarehouseDBDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private ScoresWarehouseDBDataSetTableAdapters.EstudiantePorGrupoTableAdapter estudiantePorGrupoTableAdapter;
        private System.Windows.Forms.BindingSource estudiantePorGrupoBindingSource;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox notaAcumTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private ScoresWarehouseDBDataSetTableAdapters.EstadoEstudiantePorGrupoTableAdapter estadoEstudiantePorGrupoTableAdapter;
        private System.Windows.Forms.BindingSource estadoEstudiantePorGrupoBindingSource;
        private System.Windows.Forms.BindingSource estudiantePorGrupoBindingSource1;
        private System.Windows.Forms.TextBox idTextBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox grupoComboBox;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private ScoresWarehouseDBDataSetTableAdapters.GruposTableAdapter gruposTableAdapter;
        private System.Windows.Forms.TextBox carnetTextBox;
        private System.Windows.Forms.BindingSource evaluacionesPorEstudiantePorGrupoBindingSource;
        private ScoresWarehouseDBDataSetTableAdapters.EvaluacionesPorEstudiantePorGrupoTableAdapter evaluacionesPorEstudiantePorGrupoTableAdapter;
        private System.Windows.Forms.TextBox evaluacionesTextBox;


    }
}