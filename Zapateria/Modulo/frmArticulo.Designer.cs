namespace Zapateria.Modulo
{
    partial class frmArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulo));
            this.gb = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboStore = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVaul = new System.Windows.Forms.TextBox();
            this.txtStack = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAlmacen = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_in_shelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_in_vault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // gb
            // 
            this.gb.Controls.Add(this.label6);
            this.gb.Controls.Add(this.cboStore);
            this.gb.Controls.Add(this.label5);
            this.gb.Controls.Add(this.txtVaul);
            this.gb.Controls.Add(this.txtStack);
            this.gb.Controls.Add(this.txtPrice);
            this.gb.Controls.Add(this.label3);
            this.gb.Controls.Add(this.label4);
            this.gb.Controls.Add(this.dgvAlmacen);
            this.gb.Controls.Add(this.btnLimpiar);
            this.gb.Controls.Add(this.txtDescription);
            this.gb.Controls.Add(this.btnGuardar);
            this.gb.Controls.Add(this.txtName);
            this.gb.Controls.Add(this.label2);
            this.gb.Controls.Add(this.label1);
            this.gb.Location = new System.Drawing.Point(57, 47);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(686, 391);
            this.gb.TabIndex = 193;
            this.gb.TabStop = false;
            this.gb.Text = "Artículo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 199;
            this.label6.Text = "Store:";
            // 
            // cboStore
            // 
            this.cboStore.FormattingEnabled = true;
            this.cboStore.Location = new System.Drawing.Point(127, 116);
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(537, 21);
            this.cboStore.TabIndex = 198;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 197;
            this.label5.Text = "Total in vault:";
            // 
            // txtVaul
            // 
            this.txtVaul.Location = new System.Drawing.Point(561, 87);
            this.txtVaul.MaxLength = 6;
            this.txtVaul.Name = "txtVaul";
            this.txtVaul.Size = new System.Drawing.Size(104, 20);
            this.txtVaul.TabIndex = 196;
            this.txtVaul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVaul_KeyPress);
            // 
            // txtStack
            // 
            this.txtStack.Location = new System.Drawing.Point(333, 87);
            this.txtStack.MaxLength = 6;
            this.txtStack.Name = "txtStack";
            this.txtStack.Size = new System.Drawing.Size(105, 20);
            this.txtStack.TabIndex = 195;
            this.txtStack.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStack_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(127, 87);
            this.txtPrice.MaxLength = 250;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(105, 20);
            this.txtPrice.TabIndex = 194;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 193;
            this.label3.Text = "Total in stock:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 192;
            this.label4.Text = "Price:";
            // 
            // dgvAlmacen
            // 
            this.dgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.address,
            this.Price,
            this.total_in_shelf,
            this.total_in_vault,
            this.store_id});
            this.dgvAlmacen.Location = new System.Drawing.Point(31, 188);
            this.dgvAlmacen.Name = "dgvAlmacen";
            this.dgvAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlmacen.Size = new System.Drawing.Size(634, 184);
            this.dgvAlmacen.TabIndex = 4;
            this.dgvAlmacen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlmacen_CellClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(571, 144);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 28);
            this.btnLimpiar.TabIndex = 191;
            this.btnLimpiar.Text = "      Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(128, 58);
            this.txtDescription.MaxLength = 250;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(537, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(473, 144);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 28);
            this.btnGuardar.TabIndex = 138;
            this.btnGuardar.Text = "      Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 29);
            this.txtName.MaxLength = 250;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(537, 20);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.address.DataPropertyName = "description";
            this.address.HeaderText = "Description";
            this.address.Name = "address";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // total_in_shelf
            // 
            this.total_in_shelf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.total_in_shelf.DataPropertyName = "total_in_shelf";
            this.total_in_shelf.HeaderText = "Total in stock";
            this.total_in_shelf.Name = "total_in_shelf";
            // 
            // total_in_vault
            // 
            this.total_in_vault.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.total_in_vault.DataPropertyName = "total_in_vault";
            this.total_in_vault.HeaderText = "Total in vault";
            this.total_in_vault.Name = "total_in_vault";
            // 
            // store_id
            // 
            this.store_id.DataPropertyName = "store_id";
            this.store_id.HeaderText = "store_id";
            this.store_id.Name = "store_id";
            this.store_id.Visible = false;
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArticulo";
            this.Text = "frmArticulo";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboStore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVaul;
        private System.Windows.Forms.TextBox txtStack;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAlmacen;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_in_shelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_in_vault;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_id;
    }
}