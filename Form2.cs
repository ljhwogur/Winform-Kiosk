using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Form2 : Form
    {

        private bool isIceSelected = false;
        public Form2()
        {
            InitializeComponent();
        }

        // 메뉴 버튼이 할당하는 가격과 고른 메뉴의 총 가격. 메뉴 칸이 증설될 때 마다 price_num을 추가

        int price_1 = 0, price_2 = 0, price_3 = 0, price_4 = 0, price_5 = 0, price_6 = 0;

        public int totalprice = 0;

        public int[] menuPriceIndex = new int[30]; // 선택된 상품들의 가격정보를 담고 있는 배열


        public void updateTotalPrice() // totalprice 업데이트
        {

            totalprice = 0;

            for (int i = 0; i < menuPriceIndex.Length; i++)
            {

                totalprice += menuPriceIndex[i];

            }

            totalPrice.Text = (totalprice.ToString() + " 원"); //가격 표기 초기화

        }

        public void addTotalPrice(int price) // 배열에 가격을 추가하고 TotalPrice 업데이트
        {

            for (int i = 0; i < menuPriceIndex.Length; i++)
            {

                if (menuPriceIndex[i] == 0)
                {
                    menuPriceIndex[i] = price;
                    break;
                }

            }

            updateTotalPrice();

        }

        public void deleteMenu(object sender, EventArgs e) // 배열에 가격을 빼고 TotalPrice 업데이트
        {

            for (int i = 0; i < menuPriceIndex.Length; i++)
            {
                if (selectedMenu_list.Items.Count > 0)
                {
                    if (menuPriceIndex[i] == 0)
                    {
                        menuPriceIndex[i - 1] = 0;
                        break;
                    }
                }

            }

            updateTotalPrice();

            // 선택된 메뉴 리스트에서 맨 끝 항목 제거
            if (selectedMenu_list.Items.Count > 0)
            {
                selectedMenu_list.Items.RemoveAt(selectedMenu_list.Items.Count - 1);
            }

        }

        public void AddSelectedMenu(string menuName) //form2 ???? ??? list?? ????????
        {
            selectedMenu_list.Items.Add(menuName);
        }

        public struct Menu
        {

            public string name;  // 해당 메뉴의 이름
            public int price;  // 해당 메뉴의 가격       

            public Menu(string name, int price)
            {
                this.name = name;
                this.price = price;
            }

        }

        // 빙수 메뉴 정보
        Menu ice1 = new Menu("딸기 빙수", 15000);
        Menu ice2 = new Menu("캬라멜 빙수", 14000);
        Menu ice3 = new Menu("말챠 빙수", 16000);
        Menu ice4 = new Menu("푸딩 시그니처 빙수", 17500);
        Menu ice5 = new Menu("팥빙수", 10000);

        // 음료 메뉴 정보
        Menu beverage1 = new Menu("공간 우유 커피", 5400);
        Menu beverage2 = new Menu("크림브륄레", 6000);
        Menu beverage3 = new Menu("Flat gosoty", 6000);
        Menu beverage4 = new Menu("공간 아메리카노", 6000);

        // 케이크 메뉴 정보
        Menu cake1 = new Menu("민초 바스크 치즈케이크", 5400);
        Menu cake2 = new Menu("옥수수 바스크 치즈케이크", 6000);
        Menu cake3 = new Menu("갸또 말챠맨", 6000);
        Menu cake4 = new Menu("애플 크럼블", 5400);


        private void menu_initialize() // 메뉴 초기화
        {

            // 각 메뉴 버튼이 할당받은 가격 초기화

            price_1 = 0;
            price_2 = 0;
            price_3 = 0;
            price_4 = 0;
            price_5 = 0;
            price_6 = 0;

            // 메뉴 버튼 안보이게

            menuButton_1.Visible = false;
            menuButton_2.Visible = false;
            menuButton_3.Visible = false;
            menuButton_4.Visible = false;
            menuButton_5.Visible = false;
            menuButton_6.Visible = false;

            // 네임택 안보이게 

            menuNameTag_1.Visible = false;
            menuNameTag_2.Visible = false;
            menuNameTag_3.Visible = false;
            menuNameTag_4.Visible = false;
            menuNameTag_5.Visible = false;
            menuNameTag_6.Visible = false;

            // 가격표 안보이게 

            menuPrice_1.Visible = false;
            menuPrice_2.Visible = false;
            menuPrice_3.Visible = false;
            menuPrice_4.Visible = false;
            menuPrice_5.Visible = false;
            menuPrice_6.Visible = false;

            // 메뉴에 있는 텍스트 초기화

            menuButton_1.Text = "";
            menuButton_2.Text = "";
            menuButton_3.Text = "";
            menuButton_4.Text = "";
            menuButton_5.Text = "";
            menuButton_6.Text = "";

            menuPrice_1.Text = "";
            menuPrice_2.Text = "";
            menuPrice_3.Text = "";
            menuPrice_4.Text = "";
            menuPrice_5.Text = "";
            menuPrice_6.Text = "";

        }

        private void iceSelected() // 모든 메뉴버튼의 정보를 빙수로 업데이트
        {

            isIceSelected = true;  // 빙수를 선택하면 토핑 선택 가능


            menu_initialize(); //메뉴의 정보를 바꾸기 전 초기화

            //빙수 메뉴 1
            menuButton_1.Visible = true;
            menuNameTag_1.Visible = true;
            menuButton_1.Text = "";
            menuNameTag_1.Text = ice1.name;
            menuPrice_1.Text = ice1.price.ToString() + " 원";
            price_1 = ice1.price;
            menuButton_1.Image = Properties.Resources.strawberry_bingsu;

            //빙수 메뉴 2
            menuButton_2.Visible = true;
            menuNameTag_2.Visible = true;
            menuButton_2.Text = "";
            menuNameTag_2.Text = ice2.name;
            menuPrice_2.Text = ice2.price.ToString() + " 원";
            price_2 = ice2.price;
            menuButton_2.Image = Properties.Resources.caramel_bingsu;

            //빙수 메뉴 3
            menuButton_3.Visible = true;
            menuNameTag_3.Visible = true;
            menuButton_3.Text = "";
            menuNameTag_3.Text = ice3.name;
            menuPrice_3.Text = ice3.price.ToString() + " 원";
            price_3 = ice3.price;
            menuButton_3.Image = Properties.Resources.mattcha_bingsu;

            //빙수 메뉴 4
            menuButton_4.Visible = true;
            menuNameTag_4.Visible = true;
            menuButton_4.Text = "";
            menuNameTag_4.Text = ice4.name;
            menuPrice_4.Text = ice4.price.ToString() + " 원";
            price_4 = ice4.price;
            menuButton_4.Image = Properties.Resources.vanille_custard;


            //빙수 메뉴 5
            menuButton_5.Visible = true;
            menuNameTag_5.Visible = true;
            menuButton_5.Text = "";
            menuNameTag_5.Text = ice5.name;
            menuPrice_5.Text = ice5.price.ToString() + " 원";
            price_5 = ice5.price;
            menuButton_5.Image = Properties.Resources.redbean_bingsu;

            menuPrice_1.Visible = true;
            menuPrice_2.Visible = true;
            menuPrice_3.Visible = true;
            menuPrice_4.Visible = true;
            menuPrice_5.Visible = true;

        }

        private void beverageSelected() // 모든 메뉴버튼의 정보를 음료로 업데이트
        {

            isIceSelected = false;

            menu_initialize(); //메뉴의 정보를 바꾸기 전 초기화

            //음료 메뉴 1
            menuButton_1.Visible = true;
            menuNameTag_1.Visible = true;
            menuButton_1.Text = "";
            menuNameTag_1.Text = beverage1.name;
            menuPrice_1.Text = beverage1.price.ToString() + " 원";
            price_1 = beverage1.price;
            menuButton_1.Image = Properties.Resources.gonggan_milk_coffee;

            //음료 메뉴 2
            menuButton_2.Visible = true;
            menuNameTag_2.Visible = true;
            menuButton_2.Text = "";
            menuNameTag_2.Text = beverage2.name;
            menuPrice_2.Text = beverage2.price.ToString() + " 원";
            price_2 = beverage2.price;
            menuButton_2.Image = Properties.Resources.cream_bre;

            //음료 메뉴3
            menuButton_3.Visible = true;
            menuNameTag_3.Visible = true;
            menuButton_3.Text = "";
            menuNameTag_3.Text = beverage3.name;
            menuPrice_3.Text = beverage3.price.ToString() + " 원";
            price_3 = beverage3.price;
            menuButton_3.Image = Properties.Resources.plate_gosty;

            //음료 메뉴4
            menuButton_4.Visible = true;
            menuNameTag_4.Visible = true;
            menuButton_4.Text = "";
            menuNameTag_4.Text = beverage4.name;
            menuPrice_4.Text = beverage4.price.ToString() + " 원";
            price_4 = beverage4.price;
            menuButton_4.Image = Properties.Resources.americano;

            menuPrice_1.Visible = true;
            menuPrice_2.Visible = true;
            menuPrice_3.Visible = true;
            menuPrice_4.Visible = true;


        }


        private void cakeSelected() // 모든 메뉴버튼의 정보를 케이크로 업데이트
        {
            isIceSelected = false;

            menu_initialize(); //메뉴의 정보를 바꾸기 전 초기화

            //케이크 메뉴 1
            menuButton_1.Visible = true;
            menuNameTag_1.Visible = true;
            menuButton_1.Text = "";
            menuNameTag_1.Text = cake1.name;
            menuPrice_1.Text = cake1.price.ToString() + " 원";
            price_1 = cake1.price;
            menuButton_1.Image = Properties.Resources.mint_choco;

            //케이크 메뉴 2
            menuButton_2.Visible = true;
            menuNameTag_2.Visible = true;
            menuButton_2.Text = "";
            menuNameTag_2.Text = cake2.name;
            menuPrice_2.Text = cake2.price.ToString() + " 원";
            price_2 = cake2.price;
            menuButton_2.Image = Properties.Resources.oksusu_basc;

            //케이크 메뉴 3
            menuButton_3.Visible = true;
            menuNameTag_3.Visible = true;
            menuButton_3.Text = "";
            menuNameTag_3.Text = cake3.name;
            menuPrice_3.Text = cake3.price.ToString() + " 원";
            price_3 = cake3.price;
            menuButton_3.Image = Properties.Resources.gatto_mattchaman;

            //케이크 메뉴 4
            menuButton_4.Visible = true;
            menuNameTag_4.Visible = true;
            menuButton_4.Text = "";
            menuNameTag_4.Text = cake4.name;
            menuPrice_4.Text = cake4.price.ToString() + " 원";
            price_4 = cake4.price;
            menuButton_4.Image = Properties.Resources.apple_cramble;

            menuPrice_1.Visible = true;
            menuPrice_2.Visible = true;
            menuPrice_3.Visible = true;
            menuPrice_4.Visible = true;


        }


        // 메뉴 종류 선택 버튼

        private void button_selectIce(object sender, EventArgs e) // 빙수 메뉴 선택 버튼
        {
            iceSelected();
        }

        private void button_selectBeverage(object sender, EventArgs e) // 음료 메뉴 선택 버튼
        {
            beverageSelected();
        }

        private void button_selectcake(object sender, EventArgs e) // 케이크 메뉴 선택 버튼
        {
            cakeSelected();
        }

        // 메뉴 선택 버튼 (1~6)

        // 1
        private void button_selectMenu_1(object sender, EventArgs e) // 음료 메뉴 선택 버튼
        {
            if (selectedMenu_list.Items.Count < menuPriceIndex.Length)
            {

                selectedMenu_list.Items.Add((menuNameTag_1.Text));
                addTotalPrice(price_1);

                if (isIceSelected)
                {
                    Form form3 = new Form3(this);
                    form3.Show();
                }
            }
        }

        // 2
        private void button_selectMenu_2(object sender, EventArgs e) // 음료 메뉴 선택 버튼
        {
            if (selectedMenu_list.Items.Count < menuPriceIndex.Length)
            {
                selectedMenu_list.Items.Add((menuNameTag_2.Text));
                addTotalPrice(price_2);

                if (isIceSelected)
                {
                    Form form3 = new Form3(this);
                    form3.Show();
                }
            }
        }

        // 3
        private void button_selectMenu_3(object sender, EventArgs e) // 음료 메뉴 선택 버튼
        {
            if (selectedMenu_list.Items.Count < menuPriceIndex.Length)
            {
                selectedMenu_list.Items.Add((menuNameTag_3.Text));
                addTotalPrice(price_3);

                if (isIceSelected)
                {
                    Form form3 = new Form3(this);
                    form3.Show();
                }
            }
        }

        // 4
        private void button_selectMenu_4(object sender, EventArgs e) // 음료 메뉴 선택 버튼
        {
            if (selectedMenu_list.Items.Count < menuPriceIndex.Length)
            {
                selectedMenu_list.Items.Add((menuNameTag_4.Text));
                addTotalPrice(price_4);

                if (isIceSelected)
                {
                    Form form3 = new Form3(this);
                    form3.Show();
                }
            }
        }

        // 5
        private void button_selectMenu_5(object sender, EventArgs e) // 음료 메뉴 선택 버튼
        {
            if (selectedMenu_list.Items.Count < menuPriceIndex.Length)
            {
                selectedMenu_list.Items.Add((menuNameTag_5.Text));
                addTotalPrice(price_5);

                if (isIceSelected)
                {
                    Form form3 = new Form3(this);
                    form3.Show();
                }
            }
        }

        // 6
        private void button_selectMenu_6(object sender, EventArgs e) // 음료 메뉴 선택 버튼
        {
            if (selectedMenu_list.Items.Count < menuPriceIndex.Length)
            {
                selectedMenu_list.Items.Add((menuNameTag_6.Text));
                addTotalPrice(price_6);

                if (isIceSelected)
                {
                    Form form3 = new Form3(this);
                    form3.Show();
                }
            }
        }



        private void Form2_Load(object sender, EventArgs e) // 폼이 처음 로드 되었을 때
        {

            totalPrice.Text = (totalprice.ToString() + " 원"); //가격 표기 초기화
            menu_initialize(); // 메뉴를 우선 초기화

            iceSelected(); // 빙수 메뉴를 우선적으로 업데이트

        }

        public void ResetForm()
        {
            menu_initialize();
            totalprice = 0;
            totalPrice.Text = (totalprice.ToString() + " 원");
            iceSelected();
            selectedMenu_list.Items.Clear();
        }

        private void purchase_Button_Click(object sender, EventArgs e)
        {
            if (selectedMenu_list.Items.Count > 0)
            {
                Form4 form4 = new Form4(this);
                form4.TotalPriceForm4 = totalprice;
                form4.ShowDialog();
            }
            else
            {
                MessageBox.Show("선택된 메뉴가 없습니다.");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // '뒤로가기' 버튼이 클릭되었을 때 Form2를 닫음
            this.Close();
        }
    }
}