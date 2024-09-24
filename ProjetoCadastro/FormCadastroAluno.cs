﻿using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class FormCadastroAluno : MaterialForm
    {
        string alunosFileName = "alunos.txt";
        bool isAlteracao = false;
        int indexSelecionado = 0;

        public FormCadastroAluno()
        {
            InitializeComponent();
        }

        private void FormCadastroAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidaFormulario())// faz a validação
            {
                Salvar(); // chama o metodo para salvar rm um arquivo
                // muda para pagina de consulta
                tabControlCadastro.SelectedIndex = 1;
            }
        }

        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Matrícula é Obrigatório!");
                txtMatricula.Focus();
                return false;
            }

            if (!DateTime.TryParse(txtDataNascimento.Text, out DateTime _))
            {
                MessageBox.Show("Data de Nascimento Inválida", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataNascimento.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é Obrigatório!");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Endereço é Obrigatório!");
                txtEndereco.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Bairro é Obrigatório!");
                txtBairro.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Cidade é Obrigatório!");
                txtCidade.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cboEstado.Text))
            {
                MessageBox.Show("Estado é Obrigatório!");
                cboEstado.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha é Obrigatório!");
                txtSenha.Focus();
                return false;
            }
            return true;
        }

        private void Salvar()
        {
            var line = $"{txtMatricula.Text};" +
                       $"{txtDataNascimento.Text};" +
                       $"{txtNome.Text};" +
                       $"{txtEndereco.Text};" +
                       $"{txtBairro.Text};" +
                       $"{txtCidade.Text};" +
                       $"{cboEstado.Text};" +
                       $"{txtSenha.Text};";

            if(!isAlteracao) //novo registro
            {
                var file = new StreamWriter(alunosFileName, true);
                file.Write(line);
                file.Close();
            }
            else //alteração
            {
                //implementar alteração
            }
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabControlCadastro.Controls)
            {
                if(control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if(control is MaterialTextBoxEdit)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }
    }
}