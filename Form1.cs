namespace Group_ATM
{
    public partial class Form1 : Form
    {
        AtmModel account = new AtmModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            account.setAccNum(accNum.Text);
            account.setAccPin(accPin.Text);

            Form2 home = new Form2(account);
            home.Show();
            this.Hide();                

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}