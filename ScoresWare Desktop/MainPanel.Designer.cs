namespace ScoresWare_Desktop
{
    partial class MainPanel
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.vistaUsuariosTodos1 = new ScoresWare_Desktop.VistaUsuariosTodos();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.vistaProfesoresTodos1 = new ScoresWare_Desktop.VistaProfesoresTodos();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.vistaEstudiantesGrupoTodos1 = new ScoresWare_Desktop.VistaEstudiantesGrupoTodos();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.vistaEstudiantesTodos1 = new ScoresWare_Desktop.VistaEstudiantesTodos();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.vistaGruposTodos1 = new ScoresWare_Desktop.VistaGruposTodos();
            this.gruposTab = new System.Windows.Forms.TabControl();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gruposTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(16, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(890, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.vistaUsuariosTodos1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(886, 374);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Usuarios";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // vistaUsuariosTodos1
            // 
            this.vistaUsuariosTodos1.Location = new System.Drawing.Point(6, 12);
            this.vistaUsuariosTodos1.Name = "vistaUsuariosTodos1";
            this.vistaUsuariosTodos1.Size = new System.Drawing.Size(864, 356);
            this.vistaUsuariosTodos1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.vistaProfesoresTodos1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(886, 374);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Profesores";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // vistaProfesoresTodos1
            // 
            this.vistaProfesoresTodos1.Location = new System.Drawing.Point(7, 7);
            this.vistaProfesoresTodos1.Name = "vistaProfesoresTodos1";
            this.vistaProfesoresTodos1.Size = new System.Drawing.Size(878, 378);
            this.vistaProfesoresTodos1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.vistaEstudiantesGrupoTodos1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(886, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Estudiantes Por Grupo";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            //  vistaEstudiantesGrupoTodos1
            // 
            this.vistaEstudiantesGrupoTodos1.Location = new System.Drawing.Point(6, 3);
            this.vistaEstudiantesGrupoTodos1.Name = "vistaEstudiantesGrupoTodos1";
            this.vistaEstudiantesGrupoTodos1.Size = new System.Drawing.Size(864, 356);
            this.vistaEstudiantesGrupoTodos1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.vistaEstudiantesTodos1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estudiantes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // vistaEstudiantesTodos1
            // 
            this.vistaEstudiantesTodos1.Location = new System.Drawing.Point(7, 7);
            this.vistaEstudiantesTodos1.Name = "vistaEstudiantesTodos1";
            this.vistaEstudiantesTodos1.Size = new System.Drawing.Size(884, 366);
            this.vistaEstudiantesTodos1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.vistaGruposTodos1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grupos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // vistaGruposTodos1
            // 
            this.vistaGruposTodos1.Location = new System.Drawing.Point(7, 7);
            this.vistaGruposTodos1.Name = "vistaGruposTodos1";
            this.vistaGruposTodos1.Size = new System.Drawing.Size(864, 349);
            this.vistaGruposTodos1.TabIndex = 0;
            // 
            // gruposTab
            // 
            this.gruposTab.Controls.Add(this.tabPage1);
            this.gruposTab.Controls.Add(this.tabPage2);
            this.gruposTab.Controls.Add(this.tabPage3);
            this.gruposTab.Controls.Add(this.tabPage4);
            this.gruposTab.Controls.Add(this.tabPage5);
            this.gruposTab.Location = new System.Drawing.Point(12, 13);
            this.gruposTab.Name = "gruposTab";
            this.gruposTab.SelectedIndex = 0;
            this.gruposTab.Size = new System.Drawing.Size(894, 400);
            this.gruposTab.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gruposTab);
            this.Name = "MainPanel";
            this.Opacity = 0.8D;
            this.Text = "Panel Principal";
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.tabPage5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gruposTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage5;
        private VistaUsuariosTodos vistaUsuariosTodos1;
        private System.Windows.Forms.TabPage tabPage4;
        private VistaProfesoresTodos vistaProfesoresTodos1;
        private System.Windows.Forms.TabPage tabPage3;
        private VistaEstudiantesGrupoTodos vistaEstudiantesGrupoTodos1;
        private System.Windows.Forms.TabPage tabPage2;
        private VistaEstudiantesTodos vistaEstudiantesTodos1;
        private System.Windows.Forms.TabPage tabPage1;
        private VistaGruposTodos vistaGruposTodos1;
        private System.Windows.Forms.TabControl gruposTab;
       

    }
}

