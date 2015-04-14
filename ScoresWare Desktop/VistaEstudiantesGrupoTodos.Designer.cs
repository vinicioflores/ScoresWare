namespace ScoresWare_Desktop
{
    partial class VistaEstudiantesGrupoTodos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaEstudiantesGrupoTodos));
            this.scoresWarehouseDBDataSet = new ScoresWare_Desktop.ScoresWarehouseDBDataSet();
            this.estudiantePorGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiantePorGrupoTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.EstudiantePorGrupoTableAdapter();
            this.tableAdapterManager = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.TableAdapterManager();
            this.estudiantePorGrupoDataGridView = new System.Windows.Forms.DataGridView();
            this.Grupo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gruposTableAdapter = new ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.GruposTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.evaluaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scoresWarehouseDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantePorGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantePorGrupoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // estudiantePorGrupoTableAdapter
            // 
            this.estudiantePorGrupoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AulaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CantidadInstanciasTableAdapter = null;
            this.tableAdapterManager.ContadorInstanciasTableAdapter = null;
            this.tableAdapterManager.CursoTableAdapter = null;
            this.tableAdapterManager.EstadoEstudiantePorGrupoTableAdapter = null;
            this.tableAdapterManager.EstudiantePorGrupoTableAdapter = this.estudiantePorGrupoTableAdapter;
            this.tableAdapterManager.EstudianteTableAdapter = null;
            this.tableAdapterManager.FranjaHorariaTableAdapter = null;
            this.tableAdapterManager.GruposTableAdapter = null;
            this.tableAdapterManager.HorarioTableAdapter = null;
            this.tableAdapterManager.PeriodoTableAdapter = null;
            this.tableAdapterManager.ProfesorTableAdapter = null;
            this.tableAdapterManager.TipoEvaluacionPorGrupoTableAdapter = null;
            this.tableAdapterManager.TiposEvaluacionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ScoresWare_Desktop.ScoresWarehouseDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // estudiantePorGrupoDataGridView
            // 
            this.estudiantePorGrupoDataGridView.AllowUserToAddRows = false;
            this.estudiantePorGrupoDataGridView.AutoGenerateColumns = false;
            this.estudiantePorGrupoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estudiantePorGrupoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grupo,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.evaluaciones});
            this.estudiantePorGrupoDataGridView.DataSource = this.estudiantePorGrupoBindingSource;
            this.estudiantePorGrupoDataGridView.Location = new System.Drawing.Point(0, 25);
            this.estudiantePorGrupoDataGridView.Name = "estudiantePorGrupoDataGridView";
            this.estudiantePorGrupoDataGridView.ReadOnly = true;
            this.estudiantePorGrupoDataGridView.Size = new System.Drawing.Size(783, 285);
            this.estudiantePorGrupoDataGridView.TabIndex = 1;
            this.estudiantePorGrupoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.estudiantePorGrupoDataGridView_CellContentClick);
            // 
            // Grupo
            // 
            this.Grupo.DataPropertyName = "Grupo";
            this.Grupo.DataSource = this.gruposBindingSource;
            this.Grupo.DisplayMember = "codigo";
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            this.Grupo.ReadOnly = true;
            this.Grupo.ValueMember = "id";
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataMember = "Grupos";
            this.gruposBindingSource.DataSource = this.scoresWarehouseDBDataSet;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn2.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NotaAcum";
            this.dataGridViewTextBoxColumn3.HeaderText = "Acumulado de Nota";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // gruposTableAdapter
            // 
            this.gruposTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(789, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 70);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // evaluaciones
            // 
            this.evaluaciones.DataPropertyName = "evaluaciones";
            this.evaluaciones.HeaderText = "evaluaciones";
            this.evaluaciones.Name = "evaluaciones";
            this.evaluaciones.ReadOnly = true;
            // 
            // VistaEstudiantesGrupoTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.estudiantePorGrupoDataGridView);
            this.Name = "VistaEstudiantesGrupoTodos";
            this.Size = new System.Drawing.Size(874, 326);
            this.Load += new System.EventHandler(this.VistaEstudiantesGrupoTodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoresWarehouseDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantePorGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantePorGrupoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ScoresWarehouseDBDataSet scoresWarehouseDBDataSet;
        private System.Windows.Forms.BindingSource estudiantePorGrupoBindingSource;
        private ScoresWarehouseDBDataSetTableAdapters.EstudiantePorGrupoTableAdapter estudiantePorGrupoTableAdapter;
        private ScoresWarehouseDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView estudiantePorGrupoDataGridView;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private ScoresWarehouseDBDataSetTableAdapters.GruposTableAdapter gruposTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluaciones;


    }
}
