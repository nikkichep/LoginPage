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

    }
}