namespace proyecto0._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form JUEGO = new Nivel1();
            JUEGO.Show();
            this.Hide();
        }
    }
}