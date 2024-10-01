namespace ProjetoCadastro
{
    partial class FormCadastroCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            tabPageConsulta = new TabPage();
            txtCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboNivel = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDuracao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboPeriodo = new ReaLTaiizor.Controls.MaterialComboBox();
            cboArea = new ReaLTaiizor.Controls.MaterialComboBox();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            mlvCurso = new ListView();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            tabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Controls.Add(tabPageCadastro);
            tabControlCadastro.Controls.Add(tabPageConsulta);
            tabControlCadastro.Depth = 0;
            tabControlCadastro.Dock = DockStyle.Fill;
            tabControlCadastro.Location = new Point(3, 64);
            tabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlCadastro.Multiline = true;
            tabControlCadastro.Name = "tabControlCadastro";
            tabControlCadastro.SelectedIndex = 0;
            tabControlCadastro.Size = new Size(795, 324);
            tabControlCadastro.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(btnCancelar);
            tabPageCadastro.Controls.Add(btnSalvar);
            tabPageCadastro.Controls.Add(cboArea);
            tabPageCadastro.Controls.Add(cboPeriodo);
            tabPageCadastro.Controls.Add(txtDuracao);
            tabPageCadastro.Controls.Add(cboNivel);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtCodigo);
            tabPageCadastro.Location = new Point(4, 29);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(787, 291);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(btnExcluir);
            tabPageConsulta.Controls.Add(btnEditar);
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.Controls.Add(mlvCurso);
            tabPageConsulta.Location = new Point(4, 29);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(787, 291);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.AnimateReadOnly = false;
            txtCodigo.AutoCompleteMode = AutoCompleteMode.None;
            txtCodigo.AutoCompleteSource = AutoCompleteSource.None;
            txtCodigo.BackgroundImageLayout = ImageLayout.None;
            txtCodigo.CharacterCasing = CharacterCasing.Normal;
            txtCodigo.Depth = 0;
            txtCodigo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigo.HideSelection = true;
            txtCodigo.Hint = "Código";
            txtCodigo.LeadingIcon = null;
            txtCodigo.Location = new Point(6, 6);
            txtCodigo.MaxLength = 32767;
            txtCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PasswordChar = '\0';
            txtCodigo.PrefixSuffixText = null;
            txtCodigo.ReadOnly = false;
            txtCodigo.RightToLeft = RightToLeft.No;
            txtCodigo.SelectedText = "";
            txtCodigo.SelectionLength = 0;
            txtCodigo.SelectionStart = 0;
            txtCodigo.ShortcutsEnabled = true;
            txtCodigo.Size = new Size(166, 48);
            txtCodigo.TabIndex = 0;
            txtCodigo.TabStop = false;
            txtCodigo.TextAlign = HorizontalAlignment.Left;
            txtCodigo.TrailingIcon = null;
            txtCodigo.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome do Curso";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(178, 6);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(602, 48);
            txtNome.TabIndex = 1;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // cboNivel
            // 
            cboNivel.AutoResize = false;
            cboNivel.BackColor = Color.FromArgb(255, 255, 255);
            cboNivel.Depth = 0;
            cboNivel.DrawMode = DrawMode.OwnerDrawVariable;
            cboNivel.DropDownHeight = 174;
            cboNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNivel.DropDownWidth = 121;
            cboNivel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboNivel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboNivel.FormattingEnabled = true;
            cboNivel.Hint = "Nível (Técnico ou Superior)";
            cboNivel.IntegralHeight = false;
            cboNivel.ItemHeight = 43;
            cboNivel.Items.AddRange(new object[] { "Técnico", "Superior" });
            cboNivel.Location = new Point(6, 60);
            cboNivel.MaxDropDownItems = 4;
            cboNivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboNivel.Name = "cboNivel";
            cboNivel.Size = new Size(774, 49);
            cboNivel.StartIndex = 0;
            cboNivel.TabIndex = 2;
            cboNivel.SelectedIndexChanged += this.materialComboBox1_SelectedIndexChanged;
            // 
            // txtDuracao
            // 
            txtDuracao.AnimateReadOnly = false;
            txtDuracao.AutoCompleteMode = AutoCompleteMode.None;
            txtDuracao.AutoCompleteSource = AutoCompleteSource.None;
            txtDuracao.BackgroundImageLayout = ImageLayout.None;
            txtDuracao.CharacterCasing = CharacterCasing.Normal;
            txtDuracao.Depth = 0;
            txtDuracao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDuracao.HideSelection = true;
            txtDuracao.Hint = "Duração em semestres";
            txtDuracao.LeadingIcon = null;
            txtDuracao.Location = new Point(3, 115);
            txtDuracao.MaxLength = 32767;
            txtDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDuracao.Name = "txtDuracao";
            txtDuracao.PasswordChar = '\0';
            txtDuracao.PrefixSuffixText = null;
            txtDuracao.ReadOnly = false;
            txtDuracao.RightToLeft = RightToLeft.No;
            txtDuracao.SelectedText = "";
            txtDuracao.SelectionLength = 0;
            txtDuracao.SelectionStart = 0;
            txtDuracao.ShortcutsEnabled = true;
            txtDuracao.Size = new Size(203, 48);
            txtDuracao.TabIndex = 3;
            txtDuracao.TabStop = false;
            txtDuracao.TextAlign = HorizontalAlignment.Left;
            txtDuracao.TrailingIcon = null;
            txtDuracao.UseSystemPasswordChar = false;
            // 
            // cboPeriodo
            // 
            cboPeriodo.AutoResize = false;
            cboPeriodo.BackColor = Color.FromArgb(255, 255, 255);
            cboPeriodo.Depth = 0;
            cboPeriodo.DrawMode = DrawMode.OwnerDrawVariable;
            cboPeriodo.DropDownHeight = 174;
            cboPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPeriodo.DropDownWidth = 121;
            cboPeriodo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPeriodo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPeriodo.FormattingEnabled = true;
            cboPeriodo.Hint = "Período (Matutino, Vespertino, Noturno, Integral)";
            cboPeriodo.IntegralHeight = false;
            cboPeriodo.ItemHeight = 43;
            cboPeriodo.Items.AddRange(new object[] { "Matutino", "Vespertino", "Noturno", "Integral" });
            cboPeriodo.Location = new Point(212, 115);
            cboPeriodo.MaxDropDownItems = 4;
            cboPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPeriodo.Name = "cboPeriodo";
            cboPeriodo.Size = new Size(568, 49);
            cboPeriodo.StartIndex = 0;
            cboPeriodo.TabIndex = 5;
            // 
            // cboArea
            // 
            cboArea.AutoResize = false;
            cboArea.BackColor = Color.FromArgb(255, 255, 255);
            cboArea.Depth = 0;
            cboArea.DrawMode = DrawMode.OwnerDrawVariable;
            cboArea.DropDownHeight = 174;
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea.DropDownWidth = 121;
            cboArea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboArea.FormattingEnabled = true;
            cboArea.Hint = "Área (Licenciatura, Informatica, Industria, Adminitração)";
            cboArea.IntegralHeight = false;
            cboArea.ItemHeight = 43;
            cboArea.Items.AddRange(new object[] { "Licenciatura", "Informatica", "Industria", "Administração" });
            cboArea.Location = new Point(3, 170);
            cboArea.MaxDropDownItems = 4;
            cboArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(439, 49);
            cboArea.StartIndex = 0;
            cboArea.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(621, 249);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(455, 249);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // mlvCurso
            // 
            mlvCurso.FullRowSelect = true;
            mlvCurso.Location = new Point(3, 3);
            mlvCurso.Name = "mlvCurso";
            mlvCurso.Size = new Size(780, 240);
            mlvCurso.TabIndex = 0;
            mlvCurso.UseCompatibleStateImageBehavior = false;
            mlvCurso.View = View.Details;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(293, 252);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(459, 251);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(625, 251);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // FormCadastroCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 391);
            Controls.Add(tabControlCadastro);
            Name = "FormCadastroCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Curso";
            tabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tabControlCadastro;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodigo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialComboBox cboNivel;
        private ReaLTaiizor.Controls.MaterialComboBox cboArea;
        private ReaLTaiizor.Controls.MaterialComboBox cboPeriodo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDuracao;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ListView mlvCurso;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
    }
}