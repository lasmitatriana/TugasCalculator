using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiCalculator
{
    public partial class Calculator : Form
    {
        public delegate void OperasiPerhitunganEventHandler(int index, int a, int b);

        public event OperasiPerhitunganEventHandler ProsesHitung;
        public Calculator()
        {
            InitializeComponent();
            cmbOperasi.Items.Add("Penjumlahan");
            cmbOperasi.Items.Add("Pengurangan");
            cmbOperasi.Items.Add("Perkalian");
            cmbOperasi.Items.Add("Pembagian");
            cmbOperasi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperasi.Text = "Penjumlahan";
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void BtnProses_Click(object sender, EventArgs e)
        {
            int NilaiA = int.Parse(txtNilaiA.Text);
            int NilaiB = int.Parse(txtNilaiB.Text);

            if (cmbOperasi.SelectedIndex == 0)
            {
                ProsesHitung(0, NilaiA, NilaiB);
            }
            else if (cmbOperasi.SelectedIndex == 1)
            {
                ProsesHitung(1, NilaiA, NilaiB);
            }
            else if (cmbOperasi.SelectedIndex == 2)
            {
                ProsesHitung(2, NilaiA, NilaiB);
            }
            else
            {
                ProsesHitung(3, NilaiA, NilaiB);
            }
        }
    }
}
