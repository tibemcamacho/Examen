using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zapateria.Model;
using Zapateria.Service;

namespace Zapateria.Modulo
{
    public partial class frmAlmacen : Form
    {
        #region C O N S T R U C T O R
        private int idAlmacen = 0;
        public frmAlmacen()
        {
            InitializeComponent();
        }
        #endregion

        #region E V E N T O S
        private void frmAlmacen_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                clearForm();
            }
            catch (Exception)
            {
                MessageBox.Show("Se presento un fallo que genero una excepción controlada. Contactar al Departamento de TI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string isCtlValid = validForm();
                if (isCtlValid != string.Empty)
                {
                    MessageBox.Show(isCtlValid, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                save();
            }
            catch (Exception)
            {
                MessageBox.Show("Se presento un fallo que genero una excepción controlada. Contactar al Departamento de TI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvAlmacen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1)
                {
                    idAlmacen = Convert.ToInt32(dgvAlmacen[0, e.RowIndex].Value);
                    txtName.Text = dgvAlmacen[1, e.RowIndex].Value.ToString();
                    txtAddress.Text = dgvAlmacen[2, e.RowIndex].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se presento un fallo que genero una excepción controlada. Contactar al Departamento de TI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region M E T O D O S
        private async void clearForm()
        {
            idAlmacen = 0;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }

        private async void loadForm()
        {
            var response = await ShoeService.get();
            if (response.success)
                loadGrid(response);
            else
                MessageBox.Show(response.error_msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void save() 
        {
            Store s = new Store();
            s.id = idAlmacen;
            s.name = txtName.Text;
            s.address = txtAddress.Text;
            var response = await ShoeService.post(s);
            if (response.success)
            {
                loadGrid(response);
                MessageBox.Show("Transacción realizada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(response.error_msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void loadGrid(reponseAlmacen almacen)
        {
            if (almacen != null)
            {
                if (almacen.stores != null && almacen.stores.Count() > 0)
                {
                    dgvAlmacen.AutoGenerateColumns = false;
                    dgvAlmacen.DataSource = almacen.stores;
                }
            }
            clearForm();
        }

        #endregion

        #region F U N C I O N
        private string validForm()
        {
            string errorCtl = string.Empty;
            if (txtName.Text.TrimEnd().TrimStart() == string.Empty)
            {
                if (errorCtl.Length > 0)
                    errorCtl += "\n- Ingrese un nombre.";
                else
                    errorCtl += "- Ingrese un nombre.";
            }

            if (txtAddress.Text.TrimEnd().TrimStart() == string.Empty)
            {
                if (errorCtl.Length > 0)
                    errorCtl += "\n- Ingrese una dirección.";
                else
                    errorCtl += "- Ingrese una dirección.";
            }

            return errorCtl;
        }
        #endregion
    }
}
