﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatihanWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            if (!mskNpm.MaskFull)
            {
                MessageBox.Show("NPM harus diisi !! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskNpm.Focus();
                return;
            }
            if (!(txtNama.Text.Length > 0))
            {
                MessageBox.Show("Nama harus diisi !!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNama.Focus();
                return;
            }
            if (!(txtTempatLahir.Text.Length > 0))
            {
                MessageBox.Show("Nama harus diisi !!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNama.Focus();
                return;
            }

            if (!(dptTanggalLahir.Text.Length > 0))
            {
                MessageBox.Show("Nama harus diisi !!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNama.Focus();
                return;
            }

            var jeniskelamin = rdoLakilaki.Checked ? "Laki-laki" : "Perempuan";

            var msg = string.Format("NPM : {0} \nNama: {1} \nJenis Kelamin: {2} \nTempat Lahir :  {3} \nTanggal Lahir : {4} ",
                mskNpm.Text, txtNama.Text, jeniskelamin, txtTempatLahir.Text, dptTanggalLahir.Text);

            MessageBox.Show(msg, "informasi", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            var msg = "Apakah anda yakin ? ";

            var result = MessageBox.Show(msg, "konfirmasi", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
