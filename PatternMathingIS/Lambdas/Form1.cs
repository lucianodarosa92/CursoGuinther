namespace Lambdas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var b = new Button()
            {
                Left = 100,
                Top = 100,
                Text = "Clique",
                Parent = this
            };
            b.Click += button2_buttonclick;

            b.Click += delegate (Object sender, EventArgs e)
            {
                MessageBox.Show("OK2");
            };

            b.Click += (s, e) => MessageBox.Show("OK3");

            b.Click += (_,_) => MessageBox.Show("OK4");

        }
        private void button2_buttonclick(Object sender, EventArgs e)
        {
            MessageBox.Show("OK1");
        }
    }
}