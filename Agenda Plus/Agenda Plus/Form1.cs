using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetWatermark(Box_Name, "Escreva o nome ou razão social do fornecedor", 8);
            SetWatermark(Box_CNPJ, "Digite o CNPJ do fornecedor", 8);
            SetWatermark(Box_Rua, "Digite o Endereço", 9);
            SetWatermark(Box_Cep, "Digite o CEP", 8);
            SetWatermark(Box_Cidade, "Digite a Cidade e Estado", 8);
            SetWatermark(Box_InscriEst, "Digite a Inscrição Estadual", 8);
            SetWatermark(Box_Bairro, "Digite o Bairro", 8);
            SetWatermark(Box_Contato, "Um nome para Contato", 8);
            SetWatermark(Box_Tele1, "Numero telefone 1", 8);
            SetWatermark(Box_Email, "Digite um e-mail válido", 8);
        }

        private void SetWatermark(TextBox textBox, string watermark, int fontSize)
        {
            SendMessage(textBox.Handle, EM_SETCUEBANNER, 0, watermark);
            textBox.Font = new Font(textBox.Font.FontFamily, fontSize);
        }

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

        private void Box_Cep_TextChanged(object sender, EventArgs e)
        {

        }

        private void cep_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
