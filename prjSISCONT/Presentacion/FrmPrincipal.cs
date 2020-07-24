using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void menuItemProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedor frmProveedor = new FrmProveedor();
            frmProveedor.MdiParent = this;
            //frmProveedor.Dock = DockStyle.Fill;
            frmProveedor.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProgramaLibrosElectronicos frmProgramaLibrosElectronicos = new FrmProgramaLibrosElectronicos();
            frmProgramaLibrosElectronicos.MdiParent = this;
            frmProgramaLibrosElectronicos.Dock = DockStyle.Fill;
            frmProgramaLibrosElectronicos.Show();
        }
    }
}
