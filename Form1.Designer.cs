namespace GerenciadorDeSenhas
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            labelBemVindo = new Label();
            label1 = new Label();
            textBoxUsuario = new TextBox();
            label2 = new Label();
            textBoxSenha = new TextBox();
            buttonLogin = new Button();
            labelMensagem = new Label();
            SuspendLayout();
            // 
            // labelBemVindo
            // 
            labelBemVindo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelBemVindo.AutoSize = true;
            labelBemVindo.BackColor = SystemColors.ActiveCaption;
            labelBemVindo.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelBemVindo.ForeColor = SystemColors.ControlText;
            labelBemVindo.Location = new Point(12, 78);
            labelBemVindo.Name = "labelBemVindo";
            labelBemVindo.Size = new Size(542, 24);
            labelBemVindo.TabIndex = 0;
            labelBemVindo.Text = "Bem vindo ao seu gerenciador de senhas";
            labelBemVindo.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 174);
            label1.Name = "label1";
            label1.Size = new Size(122, 24);
            label1.TabIndex = 1;
            label1.Text = "Usuario:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = SystemColors.ActiveCaption;
            textBoxUsuario.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsuario.Location = new Point(161, 178);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(180, 23);
            textBoxUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 223);
            label2.Name = "label2";
            label2.Size = new Size(94, 24);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // textBoxSenha
            // 
            textBoxSenha.BackColor = SystemColors.ActiveCaption;
            textBoxSenha.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSenha.Location = new Point(161, 223);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(180, 23);
            textBoxSenha.TabIndex = 4;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.ActiveCaption;
            buttonLogin.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(369, 178);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(182, 68);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelMensagem
            // 
            labelMensagem.AutoSize = true;
            labelMensagem.BackColor = SystemColors.ActiveCaption;
            labelMensagem.Font = new Font("Lucida Console", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMensagem.Location = new Point(112, 319);
            labelMensagem.MaximumSize = new Size(348, 21);
            labelMensagem.MinimumSize = new Size(348, 21);
            labelMensagem.Name = "labelMensagem";
            labelMensagem.Size = new Size(348, 21);
            labelMensagem.TabIndex = 6;
            labelMensagem.Text = "Entre com seus dados acima";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(563, 405);
            Controls.Add(labelMensagem);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxSenha);
            Controls.Add(label2);
            Controls.Add(textBoxUsuario);
            Controls.Add(label1);
            Controls.Add(labelBemVindo);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormLogin";
            Text = "Gerenciador de senhas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBemVindo;
        private Label label1;
        private TextBox textBoxUsuario;
        private Label label2;
        private TextBox textBoxSenha;
        private Button buttonLogin;
        private Label labelMensagem;
    }
}