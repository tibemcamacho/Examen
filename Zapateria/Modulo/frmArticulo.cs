using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zapateria.Model;
using Zapateria.Service;

namespace Zapateria.Modulo
{
    public partial class frmArticulo : Form
    {
        int idArticulo = 0;
        #region C O N S T R U C T O R
        public frmArticulo()
        {
            InitializeComponent();
        }
        #endregion

        #region E V E N T O S
        private void frmArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                loadForm();
                loadAlmacen();
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

        private void dgvAlmacen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == -1)
                {
                    idArticulo = Convert.ToInt32(dgvAlmacen[0, e.RowIndex].Value);
                    txtName.Text = dgvAlmacen[1, e.RowIndex].Value.ToString();
                    txtDescription.Text = dgvAlmacen[2, e.RowIndex].Value.ToString();
                    txtPrice.Text = dgvAlmacen[3, e.RowIndex].Value.ToString();
                    txtStack.Text = dgvAlmacen[4, e.RowIndex].Value.ToString();
                    txtVaul.Text = dgvAlmacen[5, e.RowIndex].Value.ToString();
                    cboStore.SelectedValue = Convert.ToInt32(dgvAlmacen[6, e.RowIndex].Value);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Se presento un fallo que genero una excepción controlada. Contactar al Departamento de TI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStack_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtVaul_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || (e.KeyChar == (char)Keys.Back))
                e.Handled = false;

            else
                e.Handled = true;
        }
        #endregion

        #region M E T O D O S
        private void clearForm()
        {
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtStack.Text = string.Empty;
            txtVaul.Text = string.Empty;
            if (cboStore.SelectedIndex != -1)
                cboStore.SelectedIndex = 0;
        }

        private async void loadForm()
        {
            var response = await ShoeService.getArticulo();
            if (response.success)
                loadGrid(response);
            else
                MessageBox.Show(response.error_msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void loadGrid(reponseArticulo almacen)
        {
            if (almacen != null)
            {
                if (almacen.articles != null && almacen.articles.Count() > 0)
                {
                    dgvAlmacen.AutoGenerateColumns = false;
                    dgvAlmacen.DataSource = almacen.articles;
                }
            }
            clearForm();
        }

        private async void save()
        {

            article a = new article();
            a.id = idArticulo;
            a.name = txtName.Text;
            a.description = txtDescription.Text;
            a.price = Convert.ToDouble(txtPrice.Text);
            a.total_in_shelf = Convert.ToInt32(txtStack.Text);
            a.total_in_vault = Convert.ToInt32(txtVaul.Text);
            a.store_id = Convert.ToInt32(cboStore.SelectedValue);
            var response = await ShoeService.postArticulo(a);
            if (response.success)
            {
                loadGrid(response);
                MessageBox.Show("Transacción realizada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(response.error_msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void loadAlmacen()
        {
            var response = await ShoeService.get();
            if (response.success)
            {
                if (response.stores != null && response.stores.Count > 0)
                {
                    cboStore.ValueMember = "id";
                    cboStore.DisplayMember = "name";
                    cboStore.DataSource = response.stores;
                }
            }
            else
                MessageBox.Show(response.error_msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (txtDescription.Text.TrimEnd().TrimStart() == string.Empty)
            {
                if (errorCtl.Length > 0)
                    errorCtl += "\n- Ingrese una descripción.";
                else
                    errorCtl += "- Ingrese una descripción.";
            }

            if (txtPrice.Text.TrimEnd().TrimStart() == string.Empty)
            {
                if (errorCtl.Length > 0)
                    errorCtl += "\n- Ingrese un precio.";
                else
                    errorCtl += "- Ingrese un precio.";
            }

            if (txtStack.Text.TrimEnd().TrimStart() == string.Empty)
            {
                if (errorCtl.Length > 0)
                    errorCtl += "\n- Ingrese una cantidad stock.";
                else
                    errorCtl += "- Ingrese una cantidad stock.";
            }

            if (txtVaul.Text.TrimEnd().TrimStart() == string.Empty)
            {
                if (errorCtl.Length > 0)
                    errorCtl += "\n- Ingrese la cantidad en bodega.";
                else
                    errorCtl += "- Ingrese la cantidad en bodega.";
            }

            if (cboStore.SelectedIndex == -1)
            {
                if (errorCtl.Length > 0)
                    errorCtl += "\n- Debe seleccionar un almacen.";
                else
                    errorCtl += "- Debe seleccionar un almacen.";
            }

            return errorCtl;
        }
        #endregion

      
    }
}
