namespace PracticaDBDiscos
{
    partial class Form1
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
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.pbTapa = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTituloApp = new System.Windows.Forms.Label();
            this.pbAdorno = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarLogico = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblCantCanciones = new System.Windows.Forms.Label();
            this.lblFechaLanzamiento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnReiniciarBusqueda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdorno)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvDiscos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDiscos.Location = new System.Drawing.Point(11, 71);
            this.dgvDiscos.MultiSelect = false;
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.ReadOnly = true;
            this.dgvDiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscos.Size = new System.Drawing.Size(678, 443);
            this.dgvDiscos.TabIndex = 0;
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // pbTapa
            // 
            this.pbTapa.Location = new System.Drawing.Point(11, 70);
            this.pbTapa.Name = "pbTapa";
            this.pbTapa.Size = new System.Drawing.Size(422, 422);
            this.pbTapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTapa.TabIndex = 1;
            this.pbTapa.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(23, 655);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 26);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Disco";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTituloApp
            // 
            this.lblTituloApp.AutoSize = true;
            this.lblTituloApp.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTituloApp.Font = new System.Drawing.Font("Sitka Heading", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloApp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTituloApp.Location = new System.Drawing.Point(282, 23);
            this.lblTituloApp.Name = "lblTituloApp";
            this.lblTituloApp.Size = new System.Drawing.Size(533, 92);
            this.lblTituloApp.TabIndex = 3;
            this.lblTituloApp.Text = "Galeria De Discos";
            // 
            // pbAdorno
            // 
            this.pbAdorno.Location = new System.Drawing.Point(801, 18);
            this.pbAdorno.Name = "pbAdorno";
            this.pbAdorno.Size = new System.Drawing.Size(97, 97);
            this.pbAdorno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdorno.TabIndex = 4;
            this.pbAdorno.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(124, 655);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 26);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar Disco";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarLogico
            // 
            this.btnEliminarLogico.Location = new System.Drawing.Point(437, 655);
            this.btnEliminarLogico.Name = "btnEliminarLogico";
            this.btnEliminarLogico.Size = new System.Drawing.Size(127, 26);
            this.btnEliminarLogico.TabIndex = 6;
            this.btnEliminarLogico.Text = "Eliminar Disco (Logico)";
            this.btnEliminarLogico.UseVisualStyleBackColor = true;
            this.btnEliminarLogico.Click += new System.EventHandler(this.btnEliminarLogico_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Location = new System.Drawing.Point(570, 655);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(131, 26);
            this.btnEliminarFisico.TabIndex = 7;
            this.btnEliminarFisico.Text = "Eliminar Disco (Fisico)";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitulo.Location = new System.Drawing.Point(5, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(99, 36);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtista.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblArtista.Location = new System.Drawing.Point(9, 506);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(89, 29);
            this.lblArtista.TabIndex = 10;
            this.lblArtista.Text = "Artista";
            // 
            // lblCantCanciones
            // 
            this.lblCantCanciones.AutoSize = true;
            this.lblCantCanciones.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantCanciones.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCantCanciones.Location = new System.Drawing.Point(10, 549);
            this.lblCantCanciones.Name = "lblCantCanciones";
            this.lblCantCanciones.Size = new System.Drawing.Size(76, 23);
            this.lblCantCanciones.TabIndex = 11;
            this.lblCantCanciones.Text = "Tracks";
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.AutoSize = true;
            this.lblFechaLanzamiento.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaLanzamiento.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(10, 572);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(213, 23);
            this.lblFechaLanzamiento.TabIndex = 12;
            this.lblFechaLanzamiento.Text = "Fecha De Lanzamiento";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblGenero.Location = new System.Drawing.Point(433, 572);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(0, 23);
            this.lblGenero.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGenero);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Controls.Add(this.lblFechaLanzamiento);
            this.groupBox1.Controls.Add(this.pbTapa);
            this.groupBox1.Controls.Add(this.lblCantCanciones);
            this.groupBox1.Controls.Add(this.lblArtista);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(722, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 615);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disco Seleccionado";
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroRapido.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblFiltroRapido.Location = new System.Drawing.Point(7, 42);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(108, 21);
            this.lblFiltroRapido.TabIndex = 0;
            this.lblFiltroRapido.Text = "Filtro Rapido:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(112, 41);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(185, 24);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(604, 569);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 27);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReiniciarBusqueda);
            this.groupBox2.Controls.Add(this.txtFiltroAvanzado);
            this.groupBox2.Controls.Add(this.lblFiltro);
            this.groupBox2.Controls.Add(this.cbCriterio);
            this.groupBox2.Controls.Add(this.lblCriterio);
            this.groupBox2.Controls.Add(this.cbCampo);
            this.groupBox2.Controls.Add(this.lblCampo);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.txtFiltro);
            this.groupBox2.Controls.Add(this.lblFiltroRapido);
            this.groupBox2.Controls.Add(this.dgvDiscos);
            this.groupBox2.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(701, 615);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(482, 572);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(106, 24);
            this.txtFiltroAvanzado.TabIndex = 8;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblFiltro.Location = new System.Drawing.Point(421, 572);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(55, 21);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Filtro:";
            // 
            // cbCriterio
            // 
            this.cbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriterio.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(285, 572);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(121, 27);
            this.cbCriterio.TabIndex = 6;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCriterio.Location = new System.Drawing.Point(208, 573);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(71, 21);
            this.lblCriterio.TabIndex = 5;
            this.lblCriterio.Text = "Criterio:";
            // 
            // cbCampo
            // 
            this.cbCampo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.IntegralHeight = false;
            this.cbCampo.Location = new System.Drawing.Point(81, 572);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 27);
            this.cbCampo.TabIndex = 4;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbCampo_SelectedIndexChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCampo.Location = new System.Drawing.Point(12, 573);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(63, 21);
            this.lblCampo.TabIndex = 3;
            this.lblCampo.Text = "Campo:";
            // 
            // btnReiniciarBusqueda
            // 
            this.btnReiniciarBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciarBusqueda.Location = new System.Drawing.Point(579, 40);
            this.btnReiniciarBusqueda.Name = "btnReiniciarBusqueda";
            this.btnReiniciarBusqueda.Size = new System.Drawing.Size(110, 23);
            this.btnReiniciarBusqueda.TabIndex = 9;
            this.btnReiniciarBusqueda.Text = "Limpiar Filtros";
            this.btnReiniciarBusqueda.UseVisualStyleBackColor = true;
            this.btnReiniciarBusqueda.Click += new System.EventHandler(this.btnReiniciarBusqueda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1180, 763);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnEliminarLogico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbAdorno);
            this.Controls.Add(this.lblTituloApp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximumSize = new System.Drawing.Size(1196, 802);
            this.MinimumSize = new System.Drawing.Size(1196, 0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galeria de Discos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdorno)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.PictureBox pbTapa;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTituloApp;
        private System.Windows.Forms.PictureBox pbAdorno;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblCantCanciones;
        private System.Windows.Forms.Label lblFechaLanzamiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cbCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnReiniciarBusqueda;
    }
}

