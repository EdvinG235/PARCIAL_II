using PARCIAL_II.BLL;
using PARCIAL_II.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL_II.PL
{
    public partial class FrmSedes : Form
    {

        FarmaciaSedDAL sedes;
        public FrmSedes()
        {
            InitializeComponent();
            sedes = new FarmaciaSedDAL();
        }

        private void FrmSedes_Load(object sender, EventArgs e)
        {
            fillDgvSedes();
        }

        private void fillDgvSedes()
        {
            dgvSedes.DataSource = sedes.getAllfarmacia_sedes();
        }

        private void clearTextBox()
        {
            txtId.Clear();
            txtSede.Clear();
            txtUbicacion.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSede.Text) || string.IsNullOrEmpty(txtUbicacion.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Debe completar todos los campos requeridos");
            }
            else
            {
                string nombre = txtSede.Text;
                string ubicacion = txtUbicacion.Text;
                string email = txtEmail.Text;
                FarmaciaSedBLL sede = new FarmaciaSedBLL(0, nombre, ubicacion, email);
                FarmaciaSedDAL create = new FarmaciaSedDAL();
                if (create.updatefarmacia_sedes(sede))
                {
                    MessageBox.Show("Sede actualizada con éxito");
                    fillDgvSedes();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la sede");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Debe seleccionar una sede");
            }
            else
            {
                int id = int.Parse(txtId.Text);
                FarmaciaSedBLL sede = new FarmaciaSedBLL(id);
                var confirm = MessageBox.Show("¿Estás seguro de eliminar esta sede?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (sedes.deletefarmacia_sedes(sede))
                    {
                        MessageBox.Show("Sede eliminada con éxito");
                        fillDgvSedes();
                        clearTextBox();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la sede");
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtId.Text = dgvSedes.Rows[index].Cells[0].Value.ToString();
                txtSede.Text = dgvSedes.Rows[index].Cells[1].Value.ToString();
                txtUbicacion.Text = dgvSedes.Rows[index].Cells[2].Value.ToString();
                txtEmail.Text = dgvSedes.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSede.Text) || string.IsNullOrEmpty(txtUbicacion.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Debe completar todos los campos requeridos");
            }
            else
            {
                string nombre = txtSede.Text;
                string email = txtEmail.Text;
                string ubicacion = txtUbicacion.Text;
                FarmaciaSedBLL sede = new FarmaciaSedBLL(nombre, ubicacion, email);
                FarmaciaSedDAL create = new FarmaciaSedDAL();
                if (create.updatefarmacia_sedes(sede))
                {
                    MessageBox.Show("Sede actualizada con éxito");
                    fillDgvSedes();
                    clearTextBox();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la sede");
                }
            }
        }
    }
}
    
