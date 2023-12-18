using AlbumesFinal.Entidades;
using AlbumesFinal.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumesFinal
{
    public partial class frmAlbumesABM : Form
    {
        List<Album> listaAlbumes;
        Service oServicio;
        private bool esNuevo = false;
        public frmAlbumesABM()
        {
            InitializeComponent();
            listaAlbumes = new List<Album>();
            oServicio = new Service();
        }

        private void frmAlbumesABM_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarLista();
            Habilitar(true);
            LimpiarCampos();
        }

        private void Habilitar(bool v)
        {
            //no
            txtId.Enabled = !v;
            txtAutor.Enabled = !v;
            txtDuracion.Enabled = !v;
            txtNombre.Enabled = !v;
            dtpPublicacion.Enabled = !v;
            cboGenero.Enabled = !v;
            cboDiscografica.Enabled = !v;
            txtProductor.Enabled = !v;
            chkVinilo.Enabled = !v;
            chkCd.Enabled = !v;
            chkCasete.Enabled = !v;
            chkDigital.Enabled = !v;
            chkStreaming.Enabled = !v;
            btnEditar.Enabled = !v;
            btnGrabar.Enabled = !v;
            btnBorrar.Enabled = !v;
            btnCancelar.Enabled = !v;
            //si
            btnNuevo.Enabled = v;
            btnSalir.Enabled = v;
            lstAlbumes.Enabled = v;
        }

        private void CargarLista()
        {
            listaAlbumes.Clear();
            lstAlbumes.Items.Clear();
            listaAlbumes = oServicio.ListarAlbumes();
            lstAlbumes.Items.AddRange(listaAlbumes.ToArray());
        }

        private void CargarCombos()
        {
            DataTable tablaGeneros = oServicio.Select("GENEROS");
            cboGenero.DataSource = tablaGeneros;
            cboGenero.ValueMember = tablaGeneros.Columns[0].ColumnName;    //"ID_GENERO"
            cboGenero.DisplayMember = tablaGeneros.Columns[1].ColumnName;  //"GENERO"
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;   //no permite edición, solo selección

            DataTable tablaDisc = oServicio.Select("DISCOGRAFICAS");
            cboDiscografica.DataSource = tablaDisc;
            cboDiscografica.ValueMember = tablaDisc.Columns[0].ColumnName;    //"ID_DISCOGRAFICA"
            cboDiscografica.DisplayMember = tablaDisc.Columns[1].ColumnName;  //"NOMBRE"
            cboDiscografica.DropDownStyle = ComboBoxStyle.DropDownList;   //no permite edición, solo selección
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //validacion de los datos
            if (ValidarDatos())
            {
                //crear objeto
                Album oAlbum = new Album();
                oAlbum.Id = Convert.ToInt32(txtId.Text);
                oAlbum.Autor = txtAutor.Text;
                oAlbum.Duracion = txtDuracion.Text;
                oAlbum.Nombre = txtNombre.Text;
                oAlbum.Publicacion = dtpPublicacion.Value;
                oAlbum.Genero = (int)cboGenero.SelectedValue;
                oAlbum.Discografica = (int)cboDiscografica.SelectedValue;
                oAlbum.Productor = txtProductor.Text;
                oAlbum.Vinilo = chkVinilo.Checked;
                oAlbum.Cd = chkCd.Checked;
                oAlbum.Casete = chkCasete.Checked;
                oAlbum.Digital = chkDigital.Checked;
                oAlbum.Streaming = chkStreaming.Checked;

                if (esNuevo)
                {
                    if (Existe(oAlbum.Id))
                    {
                        MessageBox.Show("Album ya cargado!", "Validación");
                        return;
                    }
                }

                oServicio.Grabar(oAlbum, esNuevo);

                MessageBox.Show("Se ha grabado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Habilitar(true);
                LimpiarCampos();
                CargarLista();
            }
        }

        private void LimpiarCampos()
        {
            foreach (Control control in this.gbDatos.Controls)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }

                if (control is TextBox)
                {
                    control.Text = String.Empty;
                }

                if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }

                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }

        private bool Existe(int pk)
        {
            bool encontro = false;
            for (int i = 0; i < listaAlbumes.Count; i++)
            {
                if (listaAlbumes[i].Id == pk)
                {
                    encontro = true;
                    break;
                }
            }
            return encontro;
        }

        private bool ValidarDatos()
        {
            if (dtpPublicacion.Value >= DateTime.Now)
            {
                MessageBox.Show("Ingrese una fecha valida...");
                dtpPublicacion.Focus();
                return false;
            }
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un ID...");
                txtId.Focus();
                return false;
            }
            if (txtAutor.Text == string.Empty)
            {
                MessageBox.Show("El autor esta vacio");
                txtAutor.Focus();
                return false;
            }
            if (txtDuracion.Text == string.Empty)
            {
                MessageBox.Show("La duracion esta vacia");
                txtAutor.Focus();
                return false;
            }
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("El nombre esta vacio");
                txtNombre.Focus();
                return false;
            }
            if (txtProductor.Text == string.Empty)
            {
                MessageBox.Show("El campo de productor(es) esta vacio");
                txtProductor.Focus();
                return false;
            }
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("El nombre esta vacio");
                txtNombre.Focus();
                return false;
            }
            if (cboDiscografica.SelectedIndex == -1)
            {
                MessageBox.Show("No selecciono una discografica");
                cboDiscografica.Focus();
                return false;
            }
            if (cboGenero.SelectedIndex == -1)
            {
                MessageBox.Show("No selecciono un genero");
                cboGenero.Focus();
                return false;
            }

            try
            {
                int codigo = Int32.Parse(txtId.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El ID solo acepta numeros");
                txtId.Focus();
                return false;
            }

            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            esNuevo = true;
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            esNuevo = false;
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int index = lstAlbumes.SelectedIndex;
            if (MessageBox.Show("Seguro que desea borrar el Album seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (oServicio.Delete(listaAlbumes[index].Id))
                {
                    MessageBox.Show("El Album fue eliminado.", "Informacion");
                    Habilitar(true);
                    LimpiarCampos();
                    CargarLista();
                }
                else
                {
                    MessageBox.Show("No se pudo borrar el Album seleccionado!", "Error");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cancelar? Los cambios no guardados se perderan", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarCampos();
                CargarLista();
                Habilitar(true);
            }
        }

        private void lstAlbumes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = lstAlbumes.SelectedIndex;

            if (selected != -1)
            {
                Album oAlbum = listaAlbumes[selected];

                txtId.Text = oAlbum.Id.ToString();
                txtAutor.Text = oAlbum.Autor;
                txtDuracion.Text = oAlbum.Duracion;
                txtNombre.Text = oAlbum.Nombre;
                dtpPublicacion.Value = oAlbum.Publicacion;
                cboGenero.SelectedValue = oAlbum.Genero;
                cboDiscografica.SelectedValue = oAlbum.Discografica;
                txtProductor.Text = oAlbum.Productor;
                chkVinilo.Checked = oAlbum.Vinilo;
                chkCd.Checked = oAlbum.Cd;
                chkCasete.Checked = oAlbum.Casete;
                chkDigital.Checked = oAlbum.Digital;
                chkStreaming.Checked = oAlbum.Streaming;

                btnEditar.Enabled = true;
                btnBorrar.Enabled = true;
                btnNuevo.Enabled = false;
                btnCancelar.Enabled = true;
                btnSalir.Enabled = false;
            }
        }
    }
}
