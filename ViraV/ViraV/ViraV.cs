using System.Data;
using System.Data.SqlClient;

namespace ViraV
{
    public partial class ViraV : Form
    {
        public ViraV()
        {
            InitializeComponent();
        }

        readonly SqlConnection connectToDB = new
        (@"Data Source=(localdb)\local;Initial Catalog=UserCreds;Integrated Security=True");

        public void Clear()
        {
            userName.Clear();
            passWord.Clear();

            userName.Focus();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            String username, password;

            try
            {
                String querry = "SELECT * FROM UserCredentials WHERE username = '" + userName.Text + "' AND password = '" + passWord.Text + "'";
                SqlDataAdapter sda = new(querry, connectToDB);

                DataTable dtable = new();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = userName.Text;
                    password = passWord.Text;

                    ViraVMain Vira = new();
                    Vira.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid Credentials", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error");
                Clear();
            }
            finally
            {
                connectToDB.Close();
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            ViraVSignUp Vira = new();
            Vira.Show();
            this.Hide();
        }
    }
}