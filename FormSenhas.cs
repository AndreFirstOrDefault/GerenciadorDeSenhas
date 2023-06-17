using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace GerenciadorDeSenhas
{
    public partial class FormSenhas : Form
    {
        EnviaEmail enviaEmail = new EnviaEmail();

        public FormSenhas()
        {
            InitializeComponent();

        }

        string TabelaCriada = "Uma tabela foi criada! - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        string InsercaoNaTabela = "Ocorreu uma inserção na tabela! - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); 
        string ConsultaTabela = "Ocorreu uma consulta na tabela! - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        string DeleteTabela = "Ocorreu uma exclusão na tabela! - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textBoxSite.Text != "")
            {
                if (textBoxUsuarioSite.Text != "")
                {
                    if (textBoxSenhaSite.Text != "")
                    {
                        //Insere dados na tabela
                        string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ProjetosCsharp\\GerenciadorDeSenhas\\GerenciadorDeSenhas\\BancoDeDadosDeSenha.mdf;Integrated Security=True";
                        string stringDoComando = "INSERT INTO TabelaDeSenhas (Servico, Usuario, Senha) VALUES (@Var1, @Var2, @Var3)";
                        SqlConnection con = null;
                        try
                        {
                            con = new SqlConnection(stringDeConexao);
                            SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
                            con.Open();
                            sqlCommand.Parameters.AddWithValue("@Var1", textBoxSite.Text);
                            sqlCommand.Parameters.AddWithValue("@Var2", textBoxUsuarioSite.Text);
                            sqlCommand.Parameters.AddWithValue("@Var3", textBoxSenhaSite.Text);

                            sqlCommand.ExecuteNonQuery();
                            MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EnviaEmail(InsercaoNaTabela);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            if (con != null)
                            {
                                con.Close();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Todos os campos devem ser preenchidos!", "Campo(s) vazio(s)!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!", "Campo(s) vazio(s)!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!", "Campo(s) vazio(s)!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxSiteConsultaApaga.Text != "")
            {
                string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ProjetosCsharp\\GerenciadorDeSenhas\\GerenciadorDeSenhas\\BancoDeDadosDeSenha.mdf;Integrated Security=True";
                string stringDoComando = "DELETE FROM TabelaDeSenhas WHERE Servico=@Var4";
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection(stringDeConexao);
                    SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
                    con.Open();
                    sqlCommand.Parameters.AddWithValue("@Var4", textBoxSiteConsultaApaga.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Dados apagados com sucesso!", "Dados apagados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EnviaEmail(DeleteTabela);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite o nome do dado quer apagar!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxSite.Text = "";
            textBoxUsuarioSite.Text = "";
            textBoxSenhaSite.Text = "";
        }

        private void FormSenhas_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Close();

        }

        private void checkBoxExibeSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExibeSenha.Checked)
            {
                textBoxSenhaSite.Visible = false;
                labelExibeSenha.Visible = true;
                labelExibeSenha.Text = textBoxSenhaSite.Text;
            }
            else
            {
                labelExibeSenha.Text = "";
                labelExibeSenha.Visible = false;
                textBoxSenhaSite.Visible = true;
            }
        }

        private void buttonLimpar2_Click(object sender, EventArgs e)
        {
            textBoxSiteConsultaApaga.Text = "";
            dataGridViewSenhas.Visible = false; 
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ProjetosCsharp\\GerenciadorDeSenhas\\GerenciadorDeSenhas\\BancoDeDadosDeSenha.mdf;Integrated Security=True";
            string stringDoComando = "SELECT Servico, Usuario, Senha FROM  TabelaDeSenhas WHERE Servico=@Var4";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDoComando, con);
                sqlCommand.Parameters.AddWithValue("@Var4", textBoxSiteConsultaApaga.Text);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                dataGridViewSenhas.Visible = true;
                con.Open();
                adapter.Fill(ds);
                dataGridViewSenhas.DataSource = ds.Tables[0];
                EnviaEmail(ConsultaTabela);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exceção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void buttonCriarTabela_Click(object sender, EventArgs e)
        {
            string stringDeConexao2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ProjetosCsharp\\GerenciadorDeSenhas\\GerenciadorDeSenhas\\BancoDeDadosDeSenha.mdf;Integrated Security=True";
            string stringDoComandoCreateTable = "CREATE TABLE TabelaDeSenhas (Servico nchar(15), Usuario nchar(75), Senha nchar(15))";
            SqlConnection con2 = null;
            try
            {
                con2 = new SqlConnection(stringDeConexao2);
                SqlCommand sqlCommand2 = new SqlCommand(stringDoComandoCreateTable, con2);
                con2.Open();

                sqlCommand2.ExecuteNonQuery();
                MessageBox.Show("A tabela foi criado com sucesso!", "Tabela criada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnviaEmail(TabelaCriada);
            }
                 catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro!\nProvavelmente a tabela já exista!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           
        }

        public void EnviaEmail(string msg)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.office365.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("seuemail@hotmail.com", "suasenha");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("seuemail@hotmail.com");
                mailMessage.To.Add(new MailAddress("seuemail@hotmail ou outro válido"));
                mailMessage.Subject = "Mensagem do seu Gerenciador de Senhas";
                mailMessage.Body = msg;
                mailMessage.IsBodyHtml = false;

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
