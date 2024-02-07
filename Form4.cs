using Kiosk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Kiosk
{
    public partial class Form4 : Form
    {
        private int totalPriceForm2;
        private static int ticketNumber = 1;
        private Form2 form2;

        public Form4(Form2 form2)
        {
            this.form2 = form2;
            InitializeComponent();

            timer1.Tick += timer1_Tick;
            timer2.Tick += timer2_Tick;
            timer3.Tick += timer3_Tick;
            timer4.Tick += timer4_Tick;
        }



        public int TotalPriceForm4
        {
            get { return totalPriceForm2; }
            set { totalPriceForm2 = value; }
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            int totalPriceForm4Value = TotalPriceForm4;
            textBoxTotalPriceForm4.Visible = true;
            Message.Visible = false;
            cancelButton.Visible = false;
            textBoxTotalPriceForm4.Text = $"{totalPriceForm4Value} 원";
        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            // Timer가 Tick 될 때 실행되는 메소드
            // 여기에서 textBox2를 표시하거나 다른 원하는 동작을 수행할 수 있습니다.

            cancelButton.Visible = false;

            // Timer 정지 (더 이상 Tick 이벤트가 발생하지 않도록)
            timer1.Stop();

            Message.Text = $"{ticketNumber}번 번호표를 받아가주세요 ";
            ticketNumber++;
            timer4.Start();
        }

        private void timer2_Tick(object? sender, EventArgs e)
        {
            // Timer가 Tick 될 때 실행되는 메소드
            // 여기에서 textBox2를 표시하거나 다른 원하는 동작을 수행할 수 있습니다.

            cancelButton.Visible = false;

            // Timer 정지 (더 이상 Tick 이벤트가 발생하지 않도록)
            timer2.Stop();

            Message.Text = $"카드 투입구에서 카드를 가져가시고 \n{ticketNumber}번 번호표를 받아가주세요 ";
            ticketNumber++;
            timer4.Start();
        }

        private void timer3_Tick(object? sender, EventArgs e)
        {
            // Timer가 Tick 될 때 실행되는 메소드
            // 여기에서 textBox2를 표시하거나 다른 원하는 동작을 수행할 수 있습니다.

            cancelButton.Visible = false;

            // Timer 정지 (더 이상 Tick 이벤트가 발생하지 않도록)
            timer3.Stop();

            Message.Text = $"{ticketNumber}번 번호표를 받아가주세요 ";
            ticketNumber++;
            timer4.Start();
        }

        private void cashbutton_Click(object sender, EventArgs e)
        {
            cashbutton.Visible = true;
            Message.Visible = true;
            cancelButton.Visible = true;
            Message.Text = "현금을 투입해주세요 ";
            timer1.Start();
        }

        private void cardbutton_Click(object sender, EventArgs e)
        {
            Message.Visible = true;
            cancelButton.Visible = true;
            Message.Text = "카드를 투입해주세요 ";
            timer2.Start();
        }

        private void couponbutton_Click(object sender, EventArgs e)
        {
            Message.Visible = true;
            cancelButton.Visible = true;
            Message.Text = "쿠폰을 리더기에 스캔해주세요 ";
            timer3.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CancelStatus();

        }

        private void CancelStatus()
        {
            // 결제 상태를 초기 상태로 변경하는 로직을 추가
            Message.Text = string.Empty;
            Message.Visible = false;
            cancelButton.Visible = false;
        }


        private void timer4_Tick(object? sender, EventArgs e)
        {
            timer4.Stop();
            CancelStatus();
            form2.Close();
            this.Close();


        }


    }
}
