namespace GerenciadorDeSenhas
{
    public partial class FormSenhas
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxUsuarioSite = new TextBox();
            textBoxSenhaSite = new TextBox();
            textBoxSite = new TextBox();
            buttonSalvar = new Button();
            buttonLimpar = new Button();
            buttonExcluir = new Button();
            checkBoxExibeSenha = new CheckBox();
            labelExibeSenha = new Label();
            label4 = new Label();
            textBoxSiteConsultaApaga = new TextBox();
            label5 = new Label();
            buttonConsultar = new Button();
            buttonLimpar2 = new Button();
            dataGridViewSenhas = new DataGridView();
            buttonCriarTabela = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSenhas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(177, 16);
            label1.TabIndex = 1;
            label1.Text = "Nome do site/ app";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(259, 18);
            label2.Name = "label2";
            label2.Size = new Size(207, 16);
            label2.TabIndex = 2;
            label2.Text = "Usuário/ E-mail/ CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(551, 18);
            label3.Name = "label3";
            label3.Size = new Size(57, 16);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // textBoxUsuarioSite
            // 
            textBoxUsuarioSite.Location = new Point(259, 44);
            textBoxUsuarioSite.Name = "textBoxUsuarioSite";
            textBoxUsuarioSite.Size = new Size(257, 23);
            textBoxUsuarioSite.TabIndex = 4;
            // 
            // textBoxSenhaSite
            // 
            textBoxSenhaSite.Location = new Point(551, 44);
            textBoxSenhaSite.Name = "textBoxSenhaSite";
            textBoxSenhaSite.PasswordChar = '*';
            textBoxSenhaSite.Size = new Size(237, 23);
            textBoxSenhaSite.TabIndex = 5;
            // 
            // textBoxSite
            // 
            textBoxSite.Location = new Point(12, 44);
            textBoxSite.Name = "textBoxSite";
            textBoxSite.Size = new Size(201, 23);
            textBoxSite.TabIndex = 6;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalvar.Location = new Point(259, 83);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(257, 46);
            buttonSalvar.TabIndex = 7;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpar.Location = new Point(551, 83);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(237, 46);
            buttonLimpar.TabIndex = 8;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExcluir.Location = new Point(259, 158);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(115, 54);
            buttonExcluir.TabIndex = 9;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // checkBoxExibeSenha
            // 
            checkBoxExibeSenha.AutoSize = true;
            checkBoxExibeSenha.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxExibeSenha.Location = new Point(680, 18);
            checkBoxExibeSenha.Name = "checkBoxExibeSenha";
            checkBoxExibeSenha.Size = new Size(108, 16);
            checkBoxExibeSenha.TabIndex = 10;
            checkBoxExibeSenha.Text = "Exibir senha";
            checkBoxExibeSenha.UseVisualStyleBackColor = true;
            checkBoxExibeSenha.CheckedChanged += checkBoxExibeSenha_CheckedChanged;
            // 
            // labelExibeSenha
            // 
            labelExibeSenha.AutoSize = true;
            labelExibeSenha.Location = new Point(645, 47);
            labelExibeSenha.Name = "labelExibeSenha";
            labelExibeSenha.Size = new Size(0, 15);
            labelExibeSenha.TabIndex = 11;
            labelExibeSenha.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 214);
            label4.Name = "label4";
            label4.Size = new Size(0, 19);
            label4.TabIndex = 12;
            // 
            // textBoxSiteConsultaApaga
            // 
            textBoxSiteConsultaApaga.Location = new Point(12, 189);
            textBoxSiteConsultaApaga.Name = "textBoxSiteConsultaApaga";
            textBoxSiteConsultaApaga.Size = new Size(177, 23);
            textBoxSiteConsultaApaga.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 158);
            label5.Name = "label5";
            label5.Size = new Size(177, 16);
            label5.TabIndex = 14;
            label5.Text = "Nome do site/ app";
            // 
            // buttonConsultar
            // 
            buttonConsultar.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConsultar.Location = new Point(401, 158);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(115, 54);
            buttonConsultar.TabIndex = 15;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = true;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // buttonLimpar2
            // 
            buttonLimpar2.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpar2.Location = new Point(551, 158);
            buttonLimpar2.Name = "buttonLimpar2";
            buttonLimpar2.Size = new Size(237, 54);
            buttonLimpar2.TabIndex = 16;
            buttonLimpar2.Text = "Limpar";
            buttonLimpar2.UseVisualStyleBackColor = true;
            buttonLimpar2.Click += buttonLimpar2_Click;
            // 
            // dataGridViewSenhas
            // 
            dataGridViewSenhas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSenhas.Location = new Point(12, 236);
            dataGridViewSenhas.Name = "dataGridViewSenhas";
            dataGridViewSenhas.RowTemplate.Height = 25;
            dataGridViewSenhas.Size = new Size(776, 167);
            dataGridViewSenhas.TabIndex = 17;
            dataGridViewSenhas.Visible = false;
            // 
            // buttonCriarTabela
            // 
            buttonCriarTabela.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCriarTabela.Location = new Point(12, 83);
            buttonCriarTabela.Name = "buttonCriarTabela";
            buttonCriarTabela.Size = new Size(201, 46);
            buttonCriarTabela.TabIndex = 18;
            buttonCriarTabela.Text = "Caso a tabela não exista clique aqui para gerar";
            buttonCriarTabela.UseVisualStyleBackColor = true;
            buttonCriarTabela.Click += buttonCriarTabela_Click;
            // 
            // FormSenhas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 418);
            Controls.Add(buttonCriarTabela);
            Controls.Add(dataGridViewSenhas);
            Controls.Add(buttonLimpar2);
            Controls.Add(buttonConsultar);
            Controls.Add(label5);
            Controls.Add(textBoxSiteConsultaApaga);
            Controls.Add(label4);
            Controls.Add(labelExibeSenha);
            Controls.Add(checkBoxExibeSenha);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxSite);
            Controls.Add(textBoxSenhaSite);
            Controls.Add(textBoxUsuarioSite);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(816, 457);
            MinimumSize = new Size(816, 457);
            Name = "FormSenhas";
            Text = "Gerenciador de Senhas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSenhas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox textBoxUsuarioSite;
        public TextBox textBoxSenhaSite;
        public TextBox textBoxSite;
        public Button buttonSalvar;
        public Button buttonLimpar;
        public Button buttonExcluir;
        private CheckBox checkBoxExibeSenha;
        private Label labelExibeSenha;
        private Label label4;
        private TextBox textBoxSiteConsultaApaga;
        private Label label5;
        private Button buttonConsultar;
        private Button buttonLimpar2;
        private DataGridView dataGridViewSenhas;
        public Button buttonCriarTabela;
    }
}