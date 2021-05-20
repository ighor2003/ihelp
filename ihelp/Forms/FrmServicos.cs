using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ihelp.Forms
{
    public partial class FrmServicos : Form
    {
        public FrmServicos()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            {
                listBoxTrabalhador.Items.Clear();
                Trabalhador trabalhador = new Trabalhador();
                List<Trabalhador> lista = trabalhador.Listar();
                foreach (var cat in lista)
                {
                    listBoxTrabalhador.Items.Add(cat.Nome + cat.Email + cat.Cep + cat.Cpf + cat.Celular);
                }
            }
        }
    }
}
