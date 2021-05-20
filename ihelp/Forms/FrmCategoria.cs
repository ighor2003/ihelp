using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ihelp.Classes;

namespace ihelp
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void bntConsultar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bntConsultar_Click_1(object sender, EventArgs e)
        {
            
                listBox1.Items.Clear();
                categoria categoria = new categoria();
                List<categoria> lista = categoria.Listar();
                foreach (var cat in lista)
                {
                    listBox1.Items.Add(cat.Nome + '-' + cat.Ativo);
                }
           
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
