namespace Kiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDineln_Click(object sender, EventArgs e)
        {
            OpenForm2();
        }

        private void btnTakeOut_Click(object sender, EventArgs e)
        {
            OpenForm2();
        }

        private void OpenForm2()
        {
            // Form1을 숨기고 Form2가 열림
            this.Hide();
            Form2 newForm2 = new Form2();
            newForm2.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
            newForm2.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Form2가 닫히면 Form1이 다시 열림
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
