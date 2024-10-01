using ReaLTaiizor.Controls;
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
            if (ValidaFormulario())// faz a validação
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

            if (!isAlteracao) //novo registro
            {
                var file = new StreamWriter(alunosFileName, true);
                file.WriteLine(line);
                file.Close();
            }
            else //alteração
            {
                string[] alunos = File.ReadAllLines(alunosFileName);
                alunos[indexSelecionado] = line;
                File.WriteAllLines(alunosFileName, alunos);
            }
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabControlCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        private void CarregaListView()
        {
            Cursor.Current = Cursors.WaitCursor;
            mlvAlunos.Columns.Clear();
            mlvAlunos.Items.Clear();
            mlvAlunos.Columns.Add("Matricula");
            mlvAlunos.Columns.Add("Data Nasc.");
            mlvAlunos.Columns.Add("Nome");
            mlvAlunos.Columns.Add("Endereco");
            mlvAlunos.Columns.Add("Bairro");
            mlvAlunos.Columns.Add("Cidade");
            mlvAlunos.Columns.Add("UF");


            string[] alunos = File.ReadAllLines(alunosFileName);

            foreach (string aluno in alunos)
            {
                var campos = aluno.Split(';');
                mlvAlunos.Items.Add(new ListViewItem(campos));
            }
            mlvAlunos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            Cursor.Current = Cursors.Default;

        }
        private void CarregaListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaListView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void mlvAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Editar()
        {
            if (mlvAlunos.SelectedIndices.Count > 0)
            {
                indexSelecionado = mlvAlunos.SelectedItems[0].Index;
                isAlteracao = true;
                var item = mlvAlunos.SelectedItems[0];
                txtMatricula.Text = item.SubItems[0].Text;
                txtDataNascimento.Text = item.SubItems[1].Text;
                txtNome.Text = item.SubItems[2].Text;
                txtEndereco.Text = item.SubItems[3].Text;
                txtBairro.Text = item.SubItems[4].Text;
                txtCidade.Text = item.SubItems[5].Text;
                cboEstado.Text = item.SubItems[6].Text;
                tabControlCadastro.SelectedIndex = 0;
                txtMatricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum aluno!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mlvAlunos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Atenção: Iformações não salvas sserão perdidas.\r\n" +
                                      "Deseja cancelar?", "Pergunta", MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabControlCadastro.SelectedIndex = 0;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            tabControlCadastro.SelectedIndex = 0;
            txtMatricula.Focus();
        }

        private void Excluir()
        {
            List<string> alunos = File.ReadAllLines(alunosFileName).ToList();
            alunos.RemoveAt(indexSelecionado);
            File.WriteAllLines(alunosFileName, alunos);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(mlvAlunos.SelectedIndices.Count > 0)
            {
                if(MessageBox.Show(this, "Deseja realmente deletar o aluno selecionado?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indexSelecionado = mlvAlunos.SelectedItems[0].Index;
                    Excluir();
                    CarregaListView();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum aluno!", "Atençaõ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
