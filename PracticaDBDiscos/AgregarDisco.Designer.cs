namespace PracticaDBDiscos
{
    partial class AgregarDisco
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCantCanciones = new System.Windows.Forms.TextBox();
            this.txtUrlTapa = new System.Windows.Forms.TextBox();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaLanzamiento = new System.Windows.Forms.Label();
            this.lblCantCanciones = new System.Windows.Forms.Label();
            this.lblUrlTapa = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblIngreseData = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbEstilo = new System.Windows.Forms.ComboBox();
            this.cbArtista = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(66, 233);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 22);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Disco";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(133, 51);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(201, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtCantCanciones
            // 
            this.txtCantCanciones.Location = new System.Drawing.Point(133, 103);
            this.txtCantCanciones.Name = "txtCantCanciones";
            this.txtCantCanciones.Size = new System.Drawing.Size(201, 20);
            this.txtCantCanciones.TabIndex = 3;
            // 
            // txtUrlTapa
            // 
            this.txtUrlTapa.Location = new System.Drawing.Point(133, 129);
            this.txtUrlTapa.Name = "txtUrlTapa";
            this.txtUrlTapa.Size = new System.Drawing.Size(201, 20);
            this.txtUrlTapa.TabIndex = 4;
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(133, 77);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(201, 20);
            this.dtpFechaLanzamiento.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.AutoSize = true;
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(12, 83);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(118, 13);
            this.lblFechaLanzamiento.TabIndex = 8;
            this.lblFechaLanzamiento.Text = "Fecha de Lanzamiento:";
            // 
            // lblCantCanciones
            // 
            this.lblCantCanciones.AutoSize = true;
            this.lblCantCanciones.Location = new System.Drawing.Point(12, 106);
            this.lblCantCanciones.Name = "lblCantCanciones";
            this.lblCantCanciones.Size = new System.Drawing.Size(120, 13);
            this.lblCantCanciones.TabIndex = 9;
            this.lblCantCanciones.Text = "Cantidad de Canciones:";
            // 
            // lblUrlTapa
            // 
            this.lblUrlTapa.AutoSize = true;
            this.lblUrlTapa.Location = new System.Drawing.Point(12, 132);
            this.lblUrlTapa.Name = "lblUrlTapa";
            this.lblUrlTapa.Size = new System.Drawing.Size(51, 13);
            this.lblUrlTapa.TabIndex = 10;
            this.lblUrlTapa.Text = "Url Tapa:";
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(12, 158);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(75, 13);
            this.lblEstilo.TabIndex = 11;
            this.lblEstilo.Text = "Estilo/Genero:";
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Location = new System.Drawing.Point(12, 184);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(32, 13);
            this.lblArtista.TabIndex = 12;
            this.lblArtista.Text = "Autor";
            // 
            // lblIngreseData
            // 
            this.lblIngreseData.AutoSize = true;
            this.lblIngreseData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseData.Location = new System.Drawing.Point(10, 9);
            this.lblIngreseData.Name = "lblIngreseData";
            this.lblIngreseData.Size = new System.Drawing.Size(347, 25);
            this.lblIngreseData.TabIndex = 13;
            this.lblIngreseData.Text = "Ingrese la informacion del disco";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(178, 233);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 22);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbEstilo
            // 
            this.cbEstilo.FormattingEnabled = true;
            this.cbEstilo.Location = new System.Drawing.Point(133, 154);
            this.cbEstilo.Name = "cbEstilo";
            this.cbEstilo.Size = new System.Drawing.Size(201, 21);
            this.cbEstilo.TabIndex = 15;
            // 
            // cbArtista
            // 
            this.cbArtista.FormattingEnabled = true;
            this.cbArtista.Location = new System.Drawing.Point(133, 181);
            this.cbArtista.Name = "cbArtista";
            this.cbArtista.Size = new System.Drawing.Size(201, 21);
            this.cbArtista.TabIndex = 16;
            // 
            // AgregarDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(367, 281);
            this.Controls.Add(this.cbArtista);
            this.Controls.Add(this.cbEstilo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblIngreseData);
            this.Controls.Add(this.lblArtista);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.lblUrlTapa);
            this.Controls.Add(this.lblCantCanciones);
            this.Controls.Add(this.lblFechaLanzamiento);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.txtUrlTapa);
            this.Controls.Add(this.txtCantCanciones);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnAgregar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AgregarDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Disco";
            this.Load += new System.EventHandler(this.AgregarDisco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCantCanciones;
        private System.Windows.Forms.TextBox txtUrlTapa;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaLanzamiento;
        private System.Windows.Forms.Label lblCantCanciones;
        private System.Windows.Forms.Label lblUrlTapa;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblIngreseData;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbEstilo;
        private System.Windows.Forms.ComboBox cbArtista;
    }
}