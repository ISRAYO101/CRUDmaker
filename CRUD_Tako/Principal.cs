using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CRUD_Tako.Acciones;
using System.Drawing.Text;
using System.Globalization;

namespace CRUD_Tako
{
    public partial class Principal : Form
    {


        public Principal()
        {
            InitializeComponent();

        }


        public string GuardarNombre()
        {
            return txtNombre.Text;
        }

        public DateTime GuardarFecha()
        {
            return DTPfecha.Value;
        }
        public string GuardarEstudio()
        {
            return txtEstudio.Text;
        }

        public string GuardarPuntaje()
        {
            return txtPuntaje.Text;
        }

        public string GuardarChk()
        {
            string checados = CX.GuardarGeneros(ChkList);
            return checados;
        }

        public void btnConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CX.LlenarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cAgregar.GuardarData();
            dataGridView1.DataSource = CX.LlenarDatos();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            cBorrado.BorradoAnimes();
            dataGridView1.DataSource = CX.LlenarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cEditar.EditarData();
            dataGridView1.DataSource = CX.LlenarDatos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombre.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DTPfecha.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                ChkList.Text = dataGridView1.CurrentRow.Cells.Count.ToString();
                txtEstudio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtPuntaje.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            }
            catch
            {
               
            }

        }
    }
}