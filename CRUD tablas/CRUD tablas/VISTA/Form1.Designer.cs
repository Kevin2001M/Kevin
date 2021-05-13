
namespace CRUD_tablas
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cRUDClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickParaMasInformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(102)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDClienteToolStripMenuItem,
            this.cRUDUsuarioToolStripMenuItem,
            this.cRUDDocumentoToolStripMenuItem,
            this.cRUDProductoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cRUDClienteToolStripMenuItem
            // 
            this.cRUDClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem});
            this.cRUDClienteToolStripMenuItem.Name = "cRUDClienteToolStripMenuItem";
            this.cRUDClienteToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.cRUDClienteToolStripMenuItem.Text = "CLIENTE";
            this.cRUDClienteToolStripMenuItem.Click += new System.EventHandler(this.cRUDClienteToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.clienteToolStripMenuItem.Text = "CRUD Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // cRUDUsuarioToolStripMenuItem
            // 
            this.cRUDUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem});
            this.cRUDUsuarioToolStripMenuItem.Name = "cRUDUsuarioToolStripMenuItem";
            this.cRUDUsuarioToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.cRUDUsuarioToolStripMenuItem.Text = "USUARIO";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.usuarioToolStripMenuItem.Text = "CRUD Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // cRUDDocumentoToolStripMenuItem
            // 
            this.cRUDDocumentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentoToolStripMenuItem});
            this.cRUDDocumentoToolStripMenuItem.Name = "cRUDDocumentoToolStripMenuItem";
            this.cRUDDocumentoToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.cRUDDocumentoToolStripMenuItem.Text = "DOCUMENTO";
            // 
            // documentoToolStripMenuItem
            // 
            this.documentoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentoToolStripMenuItem.Name = "documentoToolStripMenuItem";
            this.documentoToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.documentoToolStripMenuItem.Text = "CRUD Documento";
            this.documentoToolStripMenuItem.Click += new System.EventHandler(this.documentoToolStripMenuItem_Click);
            // 
            // cRUDProductoToolStripMenuItem
            // 
            this.cRUDProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem});
            this.cRUDProductoToolStripMenuItem.Name = "cRUDProductoToolStripMenuItem";
            this.cRUDProductoToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.cRUDProductoToolStripMenuItem.Text = "PRODUCTO";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.productoToolStripMenuItem.Text = "CRUD Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickParaMasInformacionToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.acercaDeToolStripMenuItem.Text = "ACERCA DE";
            // 
            // clickParaMasInformacionToolStripMenuItem
            // 
            this.clickParaMasInformacionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickParaMasInformacionToolStripMenuItem.Name = "clickParaMasInformacionToolStripMenuItem";
            this.clickParaMasInformacionToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.clickParaMasInformacionToolStripMenuItem.Text = "Click para mas informacion";
            this.clickParaMasInformacionToolStripMenuItem.Click += new System.EventHandler(this.clickParaMasInformacionToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cRUDClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickParaMasInformacionToolStripMenuItem;
    }
}

