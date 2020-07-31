namespace Zapateria
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.btnAlmacen);
            this.MenuVertical.Controls.Add(this.btnArticulo);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 529);
            this.MenuVertical.TabIndex = 1;
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.FlatAppearance.BorderSize = 0;
            this.btnAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlmacen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacen.ForeColor = System.Drawing.Color.White;
            this.btnAlmacen.Image = ((System.Drawing.Image)(resources.GetObject("btnAlmacen.Image")));
            this.btnAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmacen.Location = new System.Drawing.Point(6, 3);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(244, 40);
            this.btnAlmacen.TabIndex = 4;
            this.btnAlmacen.Text = "Almacén";
            this.btnAlmacen.UseVisualStyleBackColor = true;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // btnArticulo
            // 
            this.btnArticulo.FlatAppearance.BorderSize = 0;
            this.btnArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulo.ForeColor = System.Drawing.Color.White;
            this.btnArticulo.Image = ((System.Drawing.Image)(resources.GetObject("btnArticulo.Image")));
            this.btnArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticulo.Location = new System.Drawing.Point(3, 60);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(241, 40);
            this.btnArticulo.TabIndex = 2;
            this.btnArticulo.Text = "Artículos";
            this.btnArticulo.UseVisualStyleBackColor = true;
            this.btnArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(819, 529);
            this.panelContenedor.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 529);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Name = "Form1";
            this.Text = "Examen";
            this.MenuVertical.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

