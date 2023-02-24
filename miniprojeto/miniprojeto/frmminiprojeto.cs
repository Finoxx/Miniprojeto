using System.Data;
using System.Data.SqlClient;
namespace miniprojeto

{

    public partial class frmminiprojeto : Form
    {
        string stringConexao = "" +
        "Data Source=localhost;" +
        "Initial Catalog=n8_miniprojeto;" +
        "User ID=sa;" +
        "Password=123456";

        private void testarconexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
                Application.Exit();
                
            }
        }
            
        public frmminiprojeto()
        {
            InitializeComponent();
        }

        private void btocadastro_Click(object sender, EventArgs e)
        {
            string sql = "insert into usuario " +
                "(" +
                    "nome_usuario," +
                    "login_usuario," +
                    "senha_usuario," +
                    "cpf_usuario," +
                    " obs_usuario," +
                    "status_usuario" +
                ")" +
                 "Values" +
                 "(" +
                        "'" +txtnome.Text+ "'," +
                        "'"+txtlogin.Text + "'," +
                        "'"+txtmcpf.Text + "'," +
                        "'"+txtsenha.Text + "'," +
                        "'"+txtobs.Text + "'," +
                        "'"+cbostatus.Text + "'" +
                 ")";
            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cadastro realizado com sucesso");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void frmminiprojeto_Load(object sender, EventArgs e)
        {
            testarconexao();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtlogin.Text = "";
            txtmcpf.Text = "";
            txtnome.Text = "";
            txtsenha.Text = "";
            cbostatus.Text = "";
            txtobs.Text = "";
            txtnome.Focus();
        }
    }

}