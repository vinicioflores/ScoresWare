namespace ScoresWare_Desktop
{
    partial class VistaGruposTodos
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
            this.scoresWarehouseDBDataSet = new ScoresWare_Desktop.ScoresWarehouseDBDataSet();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruposTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.GruposTableAdapter();
            this.tableAdapterManager = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.TableAdapterManager();
            this.cursoTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.CursoTableAdapter();
            this.franjaHorariaTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.FranjaHorariaTableAdapter();
            this.horarioTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.HorarioTableAdapter();
            this.periodoTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.PeriodoTableAdapter();
            this.profesorTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.ProfesorTableAdapter();
            this.gruposDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.horarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.periodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.franjaHorariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter1 = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.UsuarioTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoresWarehouseDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.franjaHorariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // scoresWarehouseDBDataSet
            // 
            this.scoresWarehouseDBDataSet.DataSetName = "ScoresWarehouseDBDataSet";
            this.scoresWarehouseDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AulaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursoTableAdapter = this.cursoTableAdapter;
            this.tableAdapterManager.EstadoEstudiantePorGrupoTableAdapter = null;
            this.tableAdapterManager.EstudiantePorGrupoTableAdapter = null;
            this.tableAdapterManager.EstudianteTableAdapter = null;
            this.tableAdapterManager.FranjaHorariaTableAdapter = this.franjaHorariaTableAdapter;
            this.tableAdapterManager.GruposTableAdapter = this.gruposTableAdapter;
            this.tableAdapterManager.HorarioTableAdapter = this.horarioTableAdapter;
            this.tableAdapterManager.PeriodoTableAdapter = this.periodoTableAdapter;
            this.tableAdapterManager.ProfesorTableAdapter = this.profesorTableAdapter;
            this.tableAdapterManager.TipoEvaluacionPorGrupoTableAdapter = null;
            this.tableAdapterManager.TiposEvaluacionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // franjaHorariaTableAdapter
            // 
            this.franjaHorariaTableAdapter.ClearBeforeFill = true;
            // 
            // horarioTableAdapter
            // 
            this.horarioTableAdapter.ClearBeforeFill = true;
            // 
            // periodoTableAdapter
            // 
            this.periodoTableAdapter.ClearBeforeFill = true;
            // 
            // profesorTableAdapter
            // 
            this.profesorTableAdapter.ClearBeforeFill = true;
            // 
            // gruposDataGridView
            // 
            this.gruposDataGridView.AllowUserToAddRows = false;
            this.gruposDataGridView.AutoGenerateColumns = false;
            this.gruposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gruposDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.gruposDataGridView.DataSource = this.gruposBindingSource;
            this.gruposDataGridView.Location = new System.Drawing.Point(0, 25);
            this.gruposDataGridView.Name = "gruposDataGridView";
            this.gruposDataGridView.ReadOnly = true;
            this.gruposDataGridView.Size = new System.Drawing.Size(858, 288);
            this.gruposDataGridView.TabIndex = 1;
            this.gruposDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gruposDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cupo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cupos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "horario";
            this.dataGridViewTextBoxColumn4.DataSource = this.horarioBindingSource1;
            this.dataGridViewTextBoxColumn4.DisplayMember = "franja";
            this.dataGridViewTextBoxColumn4.HeaderText = "Horario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "id";
            // 
            // horarioBindingSource1
            // 
            this.horarioBindingSource1.DataMember = "Horario";
            this.horarioBindingSource1.DataSource = this.scoresWarehouseDBDataSet;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "profesor";
            this.dataGridViewTextBoxColumn5.DataSource = this.profesorBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Nombre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Profesor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "id";
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataMember = "Profesor";
            this.profesorBindingSource.DataSource = this.scoresWarehouseDBDataSet;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "periodo";
            this.dataGridViewTextBoxColumn6.DataSource = this.periodoBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "fechaInicio";
            this.dataGridViewTextBoxColumn6.HeaderText = "Periodo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "id";
            // 
            // periodoBindingSource
            // 
            this.periodoBindingSource.DataMember = "Periodo";
            this.periodoBindingSource.DataSource = this.scoresWarehouseDBDataSet;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "curso";
            this.dataGridViewTextBoxColumn7.DataSource = this.cursoBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "Codigo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Curso";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "id";
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.scoresWarehouseDBDataSet;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TipoEvalPorGrupo";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tipo de Evaluacion por grupo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // franjaHorariaBindingSource
            // 
            this.franjaHorariaBindingSource.DataMember = "FranjaHoraria";
            this.franjaHorariaBindingSource.DataSource = this.scoresWarehouseDBDataSet;
            // 
            // horarioBindingSource
            // 
            this.horarioBindingSource.DataMember = "Horario";
            this.horarioBindingSource.DataSource = this.scoresWarehouseDBDataSet;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(0, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(858, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar grupo nuevo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // VistaGruposTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gruposDataGridView);
            this.Name = "VistaGruposTodos";
            this.Size = new System.Drawing.Size(864, 349);
            ((System.ComponentModel.ISupportInitialize)(this.scoresWarehouseDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.franjaHorariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ScoresWarehouseDBDataSet scoresWarehouseDBDataSet;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private ScoresWarehouseDBDataSetTableAdapters.GruposTableAdapter gruposTableAdapter;
        private ScoresWarehouseDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ScoresWarehouseDBDataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private ScoresWarehouseDBDataSetTableAdapters.FranjaHorariaTableAdapter franjaHorariaTableAdapter;
        private ScoresWarehouseDBDataSetTableAdapters.HorarioTableAdapter horarioTableAdapter;
        private ScoresWarehouseDBDataSetTableAdapters.PeriodoTableAdapter periodoTableAdapter;
        private ScoresWarehouseDBDataSetTableAdapters.ProfesorTableAdapter profesorTableAdapter;
        private System.Windows.Forms.DataGridView gruposDataGridView;
        private System.Windows.Forms.BindingSource franjaHorariaBindingSource;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.BindingSource periodoBindingSource;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.BindingSource horarioBindingSource;
        private System.Windows.Forms.BindingSource horarioBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private ScoresWarehouseDBDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}
