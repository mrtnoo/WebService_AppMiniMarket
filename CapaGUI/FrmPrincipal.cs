﻿using System;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;

        public int IdUsuario;
        public int IdRol;
        public string Nombre;
        public string Rol;
        public bool Estado;


        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void CategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            StBarraInferior.Text = "Usuario en sesión: " + this.Nombre;
            MessageBox.Show("Bienvenido: " + this.Nombre, "Emarket", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (this.Rol.Equals("Administrador"))
            {
                MnuAlmacen.Enabled = true;
                MnuIngresos.Enabled = true;
                MnuVentas.Enabled = true;
                MnuAccesos.Enabled = true;
                MnuConsultas.Enabled = true;
                TsCompras.Enabled = true;
                TsVentas.Enabled = true;
            }
            else
            {
                if (this.Rol.Equals("Vendedor"))
                {
                    MnuAlmacen.Enabled = false;
                    MnuIngresos.Enabled = false;
                    MnuVentas.Enabled = true;
                    MnuAccesos.Enabled = false;
                    MnuConsultas.Enabled = true;
                    TsCompras.Enabled = false;
                    TsVentas.Enabled = true;
                }
                else
                {
                    if (this.Rol.Equals("Bodeguero"))
                    {
                        MnuAlmacen.Enabled = true;
                        MnuIngresos.Enabled = true;
                        MnuVentas.Enabled = false;
                        MnuAccesos.Enabled = false;
                        MnuConsultas.Enabled = true;
                        TsCompras.Enabled = true;
                        TsVentas.Enabled = false;
                    }
                    else
                    {
                        MnuAlmacen.Enabled = false;
                        MnuIngresos.Enabled = false;
                        MnuVentas.Enabled = false;
                        MnuAccesos.Enabled = false;
                        MnuConsultas.Enabled = false;
                        TsCompras.Enabled = false;
                        TsVentas.Enabled = false;
                    }
                }
            }
        }

        

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedor frm = new FrmProveedor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngreso frm = new FrmIngreso();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ventasToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmVenta frm = new FrmVenta();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRol frm = new FrmRol();
            frm.MdiParent = this;
            frm.Show();
        }

        private void consultaVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta_VentaFechas frm = new FrmConsulta_VentaFechas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Deseas salir del sistema?", "Emarket", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void consultaComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta_CompraFechas frm = new FrmConsulta_CompraFechas();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
