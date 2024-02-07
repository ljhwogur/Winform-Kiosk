using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Kiosk
{
    public partial class Form3 : Form
    {
        private Form2 mainForm;

        public Form3(Form2 form2)
        {
            InitializeComponent();
            mainForm = form2;
        }


        //totalPrice에 토핑 가격 추가
        private void upTotalPrice(string priceText)
        {
            int price = int.Parse(priceText);
            mainForm.addTotalPrice(price);
        }

        //토핑 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            upTotalPrice(tPrice1.Text);
            mainForm.AddSelectedMenu("ㄴ" + button1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            upTotalPrice(tPrice2.Text);
            mainForm.AddSelectedMenu("ㄴ" + button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            upTotalPrice(tPrice3.Text);
            mainForm.AddSelectedMenu("ㄴ" + button3.Text);
        }

        //종료 버튼
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
