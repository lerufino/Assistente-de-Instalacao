﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assistente_de_Instalação.Forms
{
    public partial class PediSenha : Form
    {
        public PediSenha()
        {
            InitializeComponent();
        }
        string senhaDigitada = "";
        string senhaCorreta = "217493220";
        private void btnEntrarSenha_Click(object sender, EventArgs e)
        {
            if (senhaDigitada == senhaCorreta)
            {
                DialogResult = DialogResult.Continue;
            }
            else
            {
                MessageBox.Show("SENHA INCORRETA");
                senhaDigitada = "";
            }
        }
        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                senhaDigitada += e.KeyChar;
                e.KeyChar = '•';
            }
        }
        private void btnSenhaSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
