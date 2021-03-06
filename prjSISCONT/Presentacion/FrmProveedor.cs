﻿using Negocios;
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
    public partial class FrmProveedor : Form
    {
        private Proveedor proveedor = new Proveedor();
        private bool method = false;

        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            allSuppliers();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            saveSupplier();
           
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            deleteSupplier();
        }

        private void dgvSuppliersCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            getToTextBox();
        }

        private void saveSupplier()
        {
            string ruc, razonSocial;
            ruc = txtRuc.Text;
            razonSocial = txtRazonSocial.Text;
            if (method)
            {
                int id = Convert.ToInt32(dgvSuppliers.CurrentRow.Cells["ID"].Value);
                if (proveedor.edit(id, ruc, razonSocial))
                {
                    MessageBox.Show("Proveedor Editado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTextBox();
                    allSuppliers();
                }
                else
                    MessageBox.Show("Proveedor NO Editado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (proveedor.save(ruc, razonSocial))
                {
                    MessageBox.Show("Proveedor Agregado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTextBox();
                    allSuppliers();
                }
                else
                    MessageBox.Show("Proveedor NO Agregado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearTextBox()
        {
            txtRuc.Text = null;
            txtRazonSocial.Text = null;
            this.ActiveControl = txtRuc;
        }

        private void allSuppliers()
        {
            dgvSuppliers.DataSource = proveedor.allSuppliers();
        }

        private void deleteSupplier()
        {
            int id = Convert.ToInt32(dgvSuppliers.CurrentRow.Cells["ID"].Value);
            if (proveedor.delete(id))
            {
                MessageBox.Show("Proveedor Eliminado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTextBox();
                allSuppliers();
            } else
                MessageBox.Show("Proveedor NO Eliminado", "Proveedor .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void getToTextBox()
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                method = true;
                txtRuc.Text = dgvSuppliers.CurrentRow.Cells["RUC"].Value.ToString();
                txtRazonSocial.Text = dgvSuppliers.CurrentRow.Cells["NOMBRE"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
