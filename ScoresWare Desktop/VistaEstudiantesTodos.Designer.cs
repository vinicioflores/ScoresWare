namespace ScoresWare_Desktop
{
    partial class VistaEstudiantesTodos
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.estudianteDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoresWarehouseDBDataSet = new ScoresWare_Desktop.ScoresWarehouseDBDataSet();
            this.estudiantePorGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.EstudianteTableAdapter();
            this.tableAdapterManager = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.TableAdapterManager();
            this.estudiantePorGrupoTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.EstudiantePorGrupoTableAdapter();
            this.usuarioTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.UsuarioTableAdapter();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruposTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.GruposTableAdapter();
            this.carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresWarehouseDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantePorGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // estudianteDataGridView
            // 
            this.estudianteDataGridView.AllowUserToAddRows = false;
            this.estudianteDataGridView.AutoGenerateColumns = false;
            this.estudianteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estudianteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carnet,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.estudianteDataGridView.DataSource = this.estudianteBindingSource;
            this.estudianteDataGridView.Location = new System.Drawing.Point(0, 17);
            this.estudianteDataGridView.Name = "estudianteDataGridView";
            this.estudianteDataGridView.ReadOnly = true;
            this.estudianteDataGridView.Size = new System.Drawing.Size(864, 293);
            this.estudianteDataGridView.TabIndex = 1;
            this.estudianteDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.estudianteDataGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(3, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(858, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar estudiante nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.scoresWarehouseDBDataSet;
            // 
            // scoresWarehouseDBDataSet
            // 
            this.scoresWarehouseDBDataSet.DataSetName = "ScoresWarehouseDBDataSet";
            this.scoresWarehouseDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudiantePorGrupoBindingSource
            // 
            this.estudiantePorGrupoBindingSource.DataMember = "EstudiantePorGrupo";
            this.estudiantePorGrupoBindingSource.DataSource = this.scoresWarehouseDBDataSet;
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataMember = "Estudiante";
            this.estudianteBindingSource.DataSource = this.scoresWarehouseDBDataSet;
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AulaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursoTableAdapter = null;
            this.tableAdapterManager.EstadoEstudiantePorGrupoTableAdapter = null;
            this.tableAdapterManager.EstudiantePorGrupoTableAdapter = this.estudiantePorGrupoTableAdapter;
            this.tableAdapterManager.EstudianteTableAdapter = this.estudianteTableAdapter;
            this.tableAdapterManager.FranjaHorariaTableAdapter = null;
            this.tableAdapterManager.GruposTableAdapter = null;
            this.tableAdapterManager.HorarioTableAdapter = null;
            this.tableAdapterManager.PeriodoTableAdapter = null;
            this.tableAdapterManager.ProfesorTableAdapter = null;
            this.tableAdapterManager.TipoEvaluacionPorGrupoTableAdapter = null;
            this.tableAdapterManager.TiposEvaluacionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // estudiantePorGrupoTableAdapter
            // 
            this.estudiantePorGrupoTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataMember = "Grupos";
            this.gruposBindingSource.DataSource = this.scoresWarehouseDBDataSet;
            // 
            // gruposTableAdapter
            // 
            this.gruposTableAdapter.ClearBeforeFill = true;
            // 
            // carnet
            // 
            this.carnet.DataPropertyName = "carnet";
            this.carnet.Frozen = true;
            this.carnet.HeaderText = "Carné";
            this.carnet.Name = "carnet";
            this.carnet.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PrimerApellido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Primer Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SegundoApellido";
            this.dataGridViewTextBoxColumn4.HeaderText = "Segundo Apellido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "usuario";
            this.dataGridViewTextBoxColumn5.DataSource = this.usuarioBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "username";
            this.dataGridViewTextBoxColumn5.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "estudianteGrupo";
            this.dataGridViewTextBoxColumn7.DataSource = this.estudiantePorGrupoBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Grupo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Grupo del Estudiante";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "id";
            // 
            // VistaEstudiantesTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.estudianteDataGridView);
            this.Name = "VistaEstudiantesTodos";
            this.Size = new System.Drawing.Size(884, 366);
            ((System.ComponentModel.ISupportInitialize)(this.estudianteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresWarehouseDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantePorGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ScoresWarehouseDBDataSet scoresWarehouseDBDataSet;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private ScoresWarehouseDBDataSetTableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        private ScoresWarehouseDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView estudianteDataGridView;
        private ScoresWarehouseDBDataSetTableAdapters.EstudiantePorGrupoTableAdapter estudiantePorGrupoTableAdapter;
        private ScoresWarehouseDBDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.BindingSource estudiantePorGrupoBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private ScoresWarehouseDBDataSetTableAdapters.GruposTableAdapter gruposTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
    }
}
