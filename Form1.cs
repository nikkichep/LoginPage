namespace login{
    public partial class Form1: Form{
        public Form1()
        {
            InitializeComponemt();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private bool isValid()
        {
            if (textBox1.Text.TrainStart() == string.Empty)
            {
                MessageBox.Show("Enter valid username", "error");
                return false;
            }else if (textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("enter valid password","error");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender,EventArgs e)
        {
            if(isValid())
            {
                using(SqlConnection conn = new SqlConnection(@"Data Source =(LocalDB)\MSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\login\Database1.mdf;Integrated Security=True"))
                {
                    string query = "SELECT *FROM LOGIN WHERE username = '" + textBox1.Text.Trim() + " 'AND password = '" + textBox2.Text.Trim() +" ' ";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if (dta.Rows.Count == 1)
                    {
                        dashboard dashboard = new dashboard();
                        this.Hide();
                        dashboard.Show();
                    }
                }          
            }
        }

    }
}