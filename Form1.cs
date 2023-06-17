namespace GerenciadorDeSenhas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            

            if (textBoxUsuario.Text == "Andre")
            {
                if (textBoxSenha.Text == "1234")
                {
                    labelMensagem.Text = "Login realizado com sucesso!";
                    FormSenhas formSenhas = new FormSenhas();
                    formSenhas.Show();
                    textBoxUsuario.Enabled = false;
                    textBoxSenha.Enabled = false;
                    buttonLogin.Enabled = false;

                }
                else
                {
                    labelMensagem.Text = "Senha incorreta!";
                }
            }
            else
            {
                labelMensagem.Text = "Usuário incorreto!";
            }
        }

        
    }
}