namespace AlbumesFinal
{
    partial class frmAlbumesABM
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
            gbControles = new GroupBox();
            btnSalir = new Button();
            btnCancelar = new Button();
            btnBorrar = new Button();
            btnGrabar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            gbLista = new GroupBox();
            lstAlbumes = new ListBox();
            gbDatos = new GroupBox();
            chkStreaming = new CheckBox();
            chkDigital = new CheckBox();
            chkCasete = new CheckBox();
            chkCd = new CheckBox();
            chkVinilo = new CheckBox();
            txtDuracion = new TextBox();
            lblDuracion = new Label();
            lblProductor = new Label();
            txtProductor = new TextBox();
            cboDiscografica = new ComboBox();
            lblDiscografica = new Label();
            cboGenero = new ComboBox();
            lblGenero = new Label();
            lblPublicacion = new Label();
            dtpPublicacion = new DateTimePicker();
            txtAutor = new TextBox();
            lblAutor = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtId = new TextBox();
            lblId = new Label();
            gbControles.SuspendLayout();
            gbLista.SuspendLayout();
            gbDatos.SuspendLayout();
            SuspendLayout();
            // 
            // gbControles
            // 
            gbControles.Controls.Add(btnSalir);
            gbControles.Controls.Add(btnCancelar);
            gbControles.Controls.Add(btnBorrar);
            gbControles.Controls.Add(btnGrabar);
            gbControles.Controls.Add(btnEditar);
            gbControles.Controls.Add(btnNuevo);
            gbControles.Location = new Point(12, 246);
            gbControles.Name = "gbControles";
            gbControles.Size = new Size(585, 71);
            gbControles.TabIndex = 28;
            gbControles.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(486, 28);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 29;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(394, 28);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(300, 28);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 27;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(207, 28);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 26;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(115, 28);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 25;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(22, 28);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 24;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // gbLista
            // 
            gbLista.Controls.Add(lstAlbumes);
            gbLista.Location = new Point(398, 2);
            gbLista.Name = "gbLista";
            gbLista.Size = new Size(199, 238);
            gbLista.TabIndex = 27;
            gbLista.TabStop = false;
            // 
            // lstAlbumes
            // 
            lstAlbumes.FormattingEnabled = true;
            lstAlbumes.ItemHeight = 15;
            lstAlbumes.Location = new Point(6, 16);
            lstAlbumes.Name = "lstAlbumes";
            lstAlbumes.Size = new Size(187, 214);
            lstAlbumes.TabIndex = 22;
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(chkStreaming);
            gbDatos.Controls.Add(chkDigital);
            gbDatos.Controls.Add(chkCasete);
            gbDatos.Controls.Add(chkCd);
            gbDatos.Controls.Add(chkVinilo);
            gbDatos.Controls.Add(txtDuracion);
            gbDatos.Controls.Add(lblDuracion);
            gbDatos.Controls.Add(lblProductor);
            gbDatos.Controls.Add(txtProductor);
            gbDatos.Controls.Add(cboDiscografica);
            gbDatos.Controls.Add(lblDiscografica);
            gbDatos.Controls.Add(cboGenero);
            gbDatos.Controls.Add(lblGenero);
            gbDatos.Controls.Add(lblPublicacion);
            gbDatos.Controls.Add(dtpPublicacion);
            gbDatos.Controls.Add(txtAutor);
            gbDatos.Controls.Add(lblAutor);
            gbDatos.Controls.Add(lblNombre);
            gbDatos.Controls.Add(txtNombre);
            gbDatos.Controls.Add(txtId);
            gbDatos.Controls.Add(lblId);
            gbDatos.Location = new Point(12, 2);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(380, 238);
            gbDatos.TabIndex = 26;
            gbDatos.TabStop = false;
            // 
            // chkStreaming
            // 
            chkStreaming.AutoSize = true;
            chkStreaming.Location = new Point(292, 208);
            chkStreaming.Name = "chkStreaming";
            chkStreaming.Size = new Size(80, 19);
            chkStreaming.TabIndex = 41;
            chkStreaming.Text = "Streaming";
            chkStreaming.UseVisualStyleBackColor = true;
            // 
            // chkDigital
            // 
            chkDigital.AutoSize = true;
            chkDigital.Location = new Point(220, 208);
            chkDigital.Name = "chkDigital";
            chkDigital.Size = new Size(60, 19);
            chkDigital.TabIndex = 40;
            chkDigital.Text = "Digital";
            chkDigital.UseVisualStyleBackColor = true;
            // 
            // chkCasete
            // 
            chkCasete.AutoSize = true;
            chkCasete.Location = new Point(144, 208);
            chkCasete.Name = "chkCasete";
            chkCasete.Size = new Size(61, 19);
            chkCasete.TabIndex = 39;
            chkCasete.Text = "Casete";
            chkCasete.UseVisualStyleBackColor = true;
            // 
            // chkCd
            // 
            chkCd.AutoSize = true;
            chkCd.Location = new Point(87, 208);
            chkCd.Name = "chkCd";
            chkCd.Size = new Size(42, 19);
            chkCd.TabIndex = 38;
            chkCd.Text = "CD";
            chkCd.UseVisualStyleBackColor = true;
            // 
            // chkVinilo
            // 
            chkVinilo.AutoSize = true;
            chkVinilo.Location = new Point(17, 208);
            chkVinilo.Name = "chkVinilo";
            chkVinilo.Size = new Size(56, 19);
            chkVinilo.TabIndex = 37;
            chkVinilo.Text = "Vinilo";
            chkVinilo.UseVisualStyleBackColor = true;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(316, 19);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(53, 23);
            txtDuracion.TabIndex = 36;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(252, 22);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(58, 15);
            lblDuracion.TabIndex = 35;
            lblDuracion.Text = "Duracion:";
            // 
            // lblProductor
            // 
            lblProductor.AutoSize = true;
            lblProductor.Location = new Point(6, 172);
            lblProductor.Name = "lblProductor";
            lblProductor.Size = new Size(82, 15);
            lblProductor.TabIndex = 34;
            lblProductor.Text = "Productor(es):";
            // 
            // txtProductor
            // 
            txtProductor.Location = new Point(93, 169);
            txtProductor.Name = "txtProductor";
            txtProductor.Size = new Size(276, 23);
            txtProductor.TabIndex = 33;
            // 
            // cboDiscografica
            // 
            cboDiscografica.FormattingEnabled = true;
            cboDiscografica.Location = new Point(241, 131);
            cboDiscografica.Name = "cboDiscografica";
            cboDiscografica.Size = new Size(128, 23);
            cboDiscografica.TabIndex = 32;
            // 
            // lblDiscografica
            // 
            lblDiscografica.AutoSize = true;
            lblDiscografica.Location = new Point(161, 134);
            lblDiscografica.Name = "lblDiscografica";
            lblDiscografica.Size = new Size(75, 15);
            lblDiscografica.TabIndex = 31;
            lblDiscografica.Text = "Discografica:";
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(60, 131);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(95, 23);
            cboGenero.TabIndex = 30;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(6, 134);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(48, 15);
            lblGenero.TabIndex = 29;
            lblGenero.Text = "Genero:";
            // 
            // lblPublicacion
            // 
            lblPublicacion.AutoSize = true;
            lblPublicacion.Location = new Point(6, 99);
            lblPublicacion.Name = "lblPublicacion";
            lblPublicacion.Size = new Size(122, 15);
            lblPublicacion.TabIndex = 28;
            lblPublicacion.Text = "Fecha de Publicacion:";
            // 
            // dtpPublicacion
            // 
            dtpPublicacion.Location = new Point(134, 93);
            dtpPublicacion.Name = "dtpPublicacion";
            dtpPublicacion.Size = new Size(235, 23);
            dtpPublicacion.TabIndex = 27;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(139, 19);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(107, 23);
            txtAutor.TabIndex = 26;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(93, 22);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(40, 15);
            lblAutor.TabIndex = 25;
            lblAutor.Text = "Autor:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 24;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(66, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(303, 23);
            txtNombre.TabIndex = 23;
            // 
            // txtId
            // 
            txtId.Location = new Point(33, 19);
            txtId.Name = "txtId";
            txtId.Size = new Size(45, 23);
            txtId.TabIndex = 22;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(6, 22);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 21;
            lblId.Text = "ID:";
            // 
            // frmAlbumesABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 327);
            Controls.Add(gbControles);
            Controls.Add(gbLista);
            Controls.Add(gbDatos);
            Name = "frmAlbumesABM";
            Text = "Albumes ABM";
            gbControles.ResumeLayout(false);
            gbLista.ResumeLayout(false);
            gbDatos.ResumeLayout(false);
            gbDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbControles;
        private Button btnSalir;
        private Button btnCancelar;
        private Button btnBorrar;
        private Button btnGrabar;
        private Button btnEditar;
        private Button btnNuevo;
        private GroupBox gbLista;
        private ListBox lstAlbumes;
        private GroupBox gbDatos;
        private CheckBox chkStreaming;
        private CheckBox chkDigital;
        private CheckBox chkCasete;
        private CheckBox chkCd;
        private CheckBox chkVinilo;
        private TextBox txtDuracion;
        private Label lblDuracion;
        private Label lblProductor;
        private TextBox txtProductor;
        private ComboBox cboDiscografica;
        private Label lblDiscografica;
        private ComboBox cboGenero;
        private Label lblGenero;
        private Label lblPublicacion;
        private DateTimePicker dtpPublicacion;
        private TextBox txtAutor;
        private Label lblAutor;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label lblId;
    }
}