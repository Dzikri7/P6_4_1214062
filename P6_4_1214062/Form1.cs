using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace P6_4_1214062
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb1_Leave(object sender, EventArgs e)
        {
            if (tbHuruf.Text == "")
            {
                epWarning.SetError(tbHuruf, "TextBox Nama Tidak Boleh Kosong!");
                epWrong.SetError(tbHuruf, "");
                epCorrect.SetError(tbHuruf, "");
            }
            else
            {
                if ((tbHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(tbHuruf, "");
                    epWrong.SetError(tbHuruf, "");
                    epCorrect.SetError(tbHuruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbHuruf, "Inputan Hanya Boleh Huruf!");
                    epWarning.SetError(tbHuruf, "");
                    epCorrect.SetError(tbHuruf, "");
                }
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (tbNomor.Text == "")
            {
                epWarning.SetError(tbNomor, "TextBox Handphone Tidak Boleh Kosong!");
                epWrong.SetError(tbNomor, "");
                epCorrect.SetError(tbNomor, "");
            }
            else
            {
                if ((tbNomor.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(tbNomor, "Betul!");
                    epWarning.SetError(tbNomor, "");
                    epWrong.SetError(tbNomor, "");
                }
                else
                {
                    epCorrect.SetError(tbNomor, "");
                    epWarning.SetError(tbNomor, "");
                    epWrong.SetError(tbNomor, "Inputan Hanya Boleh Angka!");
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                epWarning.SetError(tbEmail, "Textbox Email Tidak Boleh Kosong!");
                epWrong.SetError(tbEmail, "");
                epCorrect.SetError(tbEmail, "");
            }
            else
            {
                if (Regex.IsMatch(tbEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(tbEmail, "");
                    epWrong.SetError(tbEmail, "");
                    epCorrect.SetError(tbEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbEmail, "Format Email Salah\nContoh : a@gmail.com");
                    epWarning.SetError(tbEmail, "");
                    epCorrect.SetError(tbEmail, "");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (tbMerk.Text == "")
            {
                epWarning.SetError(tbMerk, "TextBox Merk Tidak Boleh Kosong!");
                epWrong.SetError(tbMerk, "");
                epCorrect.SetError(tbMerk, "");
            }
            else
            {
                if ((tbMerk.Text).All(Char.IsUpper))
                {
                    epWarning.SetError(tbMerk, "");
                    epWrong.SetError(tbMerk, "");
                    epCorrect.SetError(tbMerk, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbMerk, "Inputan Hanya Boleh Huruf Kapital!");
                    epWarning.SetError(tbMerk, "");
                    epCorrect.SetError(tbMerk, "");
                }
            }
        }

        private void tbJenis_Leave(object sender, EventArgs e)
        {
            if (tbJenis.Text == "")
            {
                epWarning.SetError(tbJenis, "TextBox Jenis Tidak Boleh Kosong!");
                epWrong.SetError(tbJenis, "");
                epCorrect.SetError(tbJenis, "");
            }
            else
            {
                if ((tbJenis.Text).All(Char.IsLower))
                {
                    epWarning.SetError(tbJenis, "");
                    epWrong.SetError(tbJenis, "");
                    epCorrect.SetError(tbJenis, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbJenis, "Inputan Hanya Boleh Huruf Kecil!");
                    epWarning.SetError(tbJenis, "");
                    epCorrect.SetError(tbJenis, "");
                }
            }
        }

        private void tbWarna_Leave(object sender, EventArgs e)
        {
            if (tbWarna.Text == "")
            {
                epWarning.SetError(tbWarna, "TextBox Warna Tidak Boleh Kosong!");
                epWrong.SetError(tbWarna, "");
                epCorrect.SetError(tbWarna, "");
            }
            else
            {
                if (tbWarna.Text.Length >= 3)
                {
                    epWarning.SetError(tbWarna, "");
                    epWrong.SetError(tbWarna, "");
                    epCorrect.SetError(tbWarna, "Betul!");
                }
                else
                {
                    epWrong.SetError(tbWarna, "Inputan Tidak Boleh Kurang Dari 3!");
                    epWarning.SetError(tbWarna, "");
                    epCorrect.SetError(tbWarna, "");
                }
            }
        }

        private void tbTahun_Leave(object sender, EventArgs e)
        {
            if (tbTahun.Text == "")
            {
                epWarning.SetError(tbTahun, "TextBox Tahun Tidak Boleh Kosong!");
                epWrong.SetError(tbTahun, "");
                epCorrect.SetError(tbTahun, "");
            }
            else
            {
                if ((tbTahun.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(tbTahun, "Betul!");
                    epWarning.SetError(tbTahun, "");
                    epWrong.SetError(tbTahun, "");
                }
                else
                {
                    epCorrect.SetError(tbTahun, "");
                    epWarning.SetError(tbTahun, "");
                    epWrong.SetError(tbTahun, "Inputan Hanya Boleh Angka!");
                }
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (tbMS.Text == "")
            {
                epWarning.SetError(tbMS, "Textbox Medium Service Tidak Boleh Kosong!");
                epWrong.SetError(tbMS, "");
                epCorrect.SetError(tbMS, "");
            }
            else
            {
                if ((tbMS.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(tbMS, "");
                    epWrong.SetError(tbMS, "");
                    epCorrect.SetError(tbMS, "Betul!");
                }
                else
                {
                    epWarning.SetError(tbMS, "");
                    epWrong.SetError(tbMS, "Inputan Hanya Boleh Angka!");
                    epCorrect.SetError(tbMS, "");
                }
            }
            if (tbFS.Text == "")
            {
                epWarning.SetError(tbFS, "TextBox Full Service tidak boleh kosong!");
                epWrong.SetError(tbFS, "");
                epCorrect.SetError(tbFS, "");
            }
        }

        private void tbFS_Leave(object sender, EventArgs e)
        {
            int Ms = int.Parse(tbMS.Text);
            int Fs = int.Parse(tbFS.Text);

            if (tbFS.Text == "")
            {
                string input = String.Empty;
                epWarning.SetError(tbFS, "Textbox Angka 2 Tidak Boleh Kosong!");
                epWrong.SetError(tbFS, "");
                epCorrect.SetError(tbFS, "");
            }
            else
            {
                if ((tbFS.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(tbFS, "");
                    epWrong.SetError(tbFS, "");
                    epCorrect.SetError(tbFS, "Betul!");
                }
                else
                {
                    epWarning.SetError(tbFS, "");
                    epWrong.SetError(tbFS, "Inputan hanya boleh angka!");
                    epCorrect.SetError(tbFS, "");
                }
            }
            if (Ms < Fs)
            {
                epWarning.SetError(tbMS, "");
                epWrong.SetError(tbMS, "");
                epCorrect.SetError(tbMS, "Betul!");

                epWarning.SetError(tbFS, "");
                epWrong.SetError(tbFS, "");
                epCorrect.SetError(tbFS, "Betul!");
            }
            else
            {
                epWarning.SetError(tbMS, "Error!");
                epWrong.SetError(tbMS, "");
                epCorrect.SetError(tbMS, "");

                epWarning.SetError(tbFS, "Error!");
                epWrong.SetError(tbFS, "");
                epCorrect.SetError(tbFS, "");
            }
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            if (tbHuruf.Text == "")
            {
                MessageBox.Show("Masukkan Nama Anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbNomor.Text == "")
            {
                MessageBox.Show("Masukkan Nomor Handphone Anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbEmail.Text == "")
            {
                MessageBox.Show("Masukkan Email Anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbMerk.Text == "")
            {
                MessageBox.Show("Masukkan Merk Mobil Anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbJenis.Text == "")
            {
                MessageBox.Show("Masukkan Jenis Mobil Anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbWarna.Text == "")
            {
                MessageBox.Show("Masukkan Warna Mobil Anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbTahun.Text == "")
            {
                MessageBox.Show("Masukkan Tahun Mobil Anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbMS.Text == "")
            {
                MessageBox.Show("Masukkan Permintaan Anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tbFS.Text == "")
            {
                MessageBox.Show("Masukkan Permintaan Anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show
                ("Nama : " + tbHuruf.Text +
                "\nNomor : " + tbNomor.Text +
                "\nEmail : " + tbEmail.Text +
                "\nMerk Mobil : " + tbMerk.Text +
                "\nJenis Mobil : " + tbJenis.Text +
                "\nWarna Mobil : " + tbWarna.Text +
                "\nTahun Mobil : " + tbTahun.Text +
                "\nReq Waktu Medium Service : " + tbMS.Text + " Jam" +
                "\nReq Waktu Full Service : " + tbFS.Text + " Jam",
                "Booking Service Mobil",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
