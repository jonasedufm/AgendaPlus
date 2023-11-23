using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Agenda_Plus
{
    public partial class FormMain : Form
    {
        private const int EM_SETCUEBANNER = 0x1501;

        public FormMain()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Box_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetWatermark(Box_Name, "Escreva o nome ou razão social do fornecedor");
            SetWatermark(Box_CNPJ, "Digite o CNPJ do fornecedor");
            SetWatermark(Box_Rua, "Digite o Endereço");
            SetWatermark(Box_Cep, "Digite o CEP");
            SetWatermark(Box_Cidade, "Digite a Cidade");
            SetWatermark(Box_InscriEst, "Digite a Inscrição Estadual");
            SetWatermark(Box_Bairro, "Digite o Bairro");
            SetWatermark(Box_Contato, "Um nome para Contato");
            SetWatermark(Box_Tele1, "Numero telefone 1");
            SetWatermark(Box_Tele2, "Numero telefone 2");
            SetWatermark(Box_Email, "Digite um e-mail válido");

        }
        private void SetWatermark(TextBox textBox, string watermark)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, watermark);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void Box_Num_TextChanged(object sender, EventArgs e)
        {

        }

        private void numb_lbl_Click(object sender, EventArgs e)
        {

        }

        private void Box_Cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
