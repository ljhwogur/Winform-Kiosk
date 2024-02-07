namespace Kiosk
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            menuButton_3 = new Button();
            selectedMenu_list = new ListBox();
            purchase_Button = new Button();
            totalPrice = new TextBox();
            menuButton_1 = new Button();
            menuButton_2 = new Button();
            menuButton_5 = new Button();
            menuButton_4 = new Button();
            menuButton_6 = new Button();
            menuNameTag_1 = new TextBox();
            menuNameTag_2 = new TextBox();
            menuNameTag_3 = new TextBox();
            menuNameTag_6 = new TextBox();
            menuNameTag_5 = new TextBox();
            menuNameTag_4 = new TextBox();
            cancel_Button = new Button();
            imageList1 = new ImageList(components);
            button4 = new Button();
            backButton = new Button();
            label1 = new Label();
            menuPrice_1 = new TextBox();
            menuPrice_2 = new TextBox();
            menuPrice_3 = new TextBox();
            menuPrice_4 = new TextBox();
            menuPrice_6 = new TextBox();
            menuPrice_5 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.button_ice;
            button1.Location = new Point(11, 169);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(144, 32);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_selectIce;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = Properties.Resources.button_beverage;
            button2.Location = new Point(402, 169);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(144, 32);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_selectBeverage;
            // 
            // menuButton_3
            // 
            menuButton_3.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Regular, GraphicsUnit.Point);
            menuButton_3.Location = new Point(405, 213);
            menuButton_3.Margin = new Padding(4, 5, 4, 5);
            menuButton_3.Name = "menuButton_3";
            menuButton_3.Size = new Size(140, 144);
            menuButton_3.TabIndex = 6;
            menuButton_3.Text = "칸3";
            menuButton_3.UseVisualStyleBackColor = true;
            menuButton_3.Click += button_selectMenu_3;
            // 
            // selectedMenu_list
            // 
            selectedMenu_list.Font = new Font("HS봄바람체 3.0 Vertical Thin", 9F, FontStyle.Italic, GraphicsUnit.Point);
            selectedMenu_list.FormattingEnabled = true;
            selectedMenu_list.ItemHeight = 15;
            selectedMenu_list.Location = new Point(14, 687);
            selectedMenu_list.Margin = new Padding(4, 5, 4, 5);
            selectedMenu_list.Name = "selectedMenu_list";
            selectedMenu_list.Size = new Size(283, 169);
            selectedMenu_list.TabIndex = 7;
            // 
            // purchase_Button
            // 
            purchase_Button.FlatAppearance.BorderSize = 0;
            purchase_Button.FlatStyle = FlatStyle.Flat;
            purchase_Button.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Regular, GraphicsUnit.Point);
            purchase_Button.Image = Properties.Resources.button_purchaceMenu;
            purchase_Button.Location = new Point(305, 757);
            purchase_Button.Margin = new Padding(4, 5, 4, 5);
            purchase_Button.Name = "purchase_Button";
            purchase_Button.Size = new Size(247, 99);
            purchase_Button.TabIndex = 8;
            purchase_Button.UseVisualStyleBackColor = true;
            purchase_Button.Click += purchase_Button_Click;
            // 
            // totalPrice
            // 
            totalPrice.Font = new Font("HS봄바람체 3.0 Vertical Thin", 9F, FontStyle.Italic, GraphicsUnit.Point);
            totalPrice.Location = new Point(13, 654);
            totalPrice.Margin = new Padding(4, 5, 4, 5);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(539, 24);
            totalPrice.TabIndex = 9;
            totalPrice.Text = "20000원";
            totalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // menuButton_1
            // 
            menuButton_1.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Regular, GraphicsUnit.Point);
            menuButton_1.ImageAlign = ContentAlignment.MiddleLeft;
            menuButton_1.Location = new Point(14, 213);
            menuButton_1.Margin = new Padding(4, 5, 4, 5);
            menuButton_1.Name = "menuButton_1";
            menuButton_1.Size = new Size(140, 144);
            menuButton_1.TabIndex = 10;
            menuButton_1.Text = "칸1";
            menuButton_1.UseVisualStyleBackColor = true;
            menuButton_1.Click += button_selectMenu_1;
            // 
            // menuButton_2
            // 
            menuButton_2.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Regular, GraphicsUnit.Point);
            menuButton_2.Location = new Point(211, 213);
            menuButton_2.Margin = new Padding(4, 5, 4, 5);
            menuButton_2.Name = "menuButton_2";
            menuButton_2.Size = new Size(140, 144);
            menuButton_2.TabIndex = 11;
            menuButton_2.Text = "칸2";
            menuButton_2.UseVisualStyleBackColor = true;
            menuButton_2.Click += button_selectMenu_2;
            // 
            // menuButton_5
            // 
            menuButton_5.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Regular, GraphicsUnit.Point);
            menuButton_5.Location = new Point(211, 414);
            menuButton_5.Margin = new Padding(4, 5, 4, 5);
            menuButton_5.Name = "menuButton_5";
            menuButton_5.Size = new Size(140, 144);
            menuButton_5.TabIndex = 14;
            menuButton_5.Text = "칸5";
            menuButton_5.UseVisualStyleBackColor = true;
            menuButton_5.Click += button_selectMenu_5;
            // 
            // menuButton_4
            // 
            menuButton_4.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Regular, GraphicsUnit.Point);
            menuButton_4.Location = new Point(14, 414);
            menuButton_4.Margin = new Padding(4, 5, 4, 5);
            menuButton_4.Name = "menuButton_4";
            menuButton_4.Size = new Size(140, 144);
            menuButton_4.TabIndex = 13;
            menuButton_4.Text = "칸4";
            menuButton_4.UseVisualStyleBackColor = true;
            menuButton_4.Click += button_selectMenu_4;
            // 
            // menuButton_6
            // 
            menuButton_6.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Regular, GraphicsUnit.Point);
            menuButton_6.Location = new Point(405, 414);
            menuButton_6.Margin = new Padding(4, 5, 4, 5);
            menuButton_6.Name = "menuButton_6";
            menuButton_6.Size = new Size(140, 144);
            menuButton_6.TabIndex = 12;
            menuButton_6.Text = "칸6";
            menuButton_6.UseVisualStyleBackColor = true;
            menuButton_6.Click += button_selectMenu_6;
            // 
            // menuNameTag_1
            // 
            menuNameTag_1.BorderStyle = BorderStyle.None;
            menuNameTag_1.Font = new Font("HS봄바람체 3.0 Regular", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuNameTag_1.Location = new Point(14, 367);
            menuNameTag_1.Margin = new Padding(4, 5, 4, 5);
            menuNameTag_1.Name = "menuNameTag_1";
            menuNameTag_1.Size = new Size(140, 21);
            menuNameTag_1.TabIndex = 15;
            menuNameTag_1.Text = " NameTag1";
            menuNameTag_1.TextAlign = HorizontalAlignment.Center;
            menuNameTag_1.UseWaitCursor = true;
            // 
            // menuNameTag_2
            // 
            menuNameTag_2.BorderStyle = BorderStyle.None;
            menuNameTag_2.Font = new Font("HS봄바람체 3.0 Regular", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuNameTag_2.Location = new Point(210, 367);
            menuNameTag_2.Margin = new Padding(4, 5, 4, 5);
            menuNameTag_2.Name = "menuNameTag_2";
            menuNameTag_2.Size = new Size(140, 21);
            menuNameTag_2.TabIndex = 16;
            menuNameTag_2.Text = " NameTag2";
            menuNameTag_2.TextAlign = HorizontalAlignment.Center;
            menuNameTag_2.UseWaitCursor = true;
            // 
            // menuNameTag_3
            // 
            menuNameTag_3.BorderStyle = BorderStyle.None;
            menuNameTag_3.Font = new Font("HS봄바람체 3.0 Regular", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuNameTag_3.Location = new Point(406, 367);
            menuNameTag_3.Margin = new Padding(4, 5, 4, 5);
            menuNameTag_3.Name = "menuNameTag_3";
            menuNameTag_3.Size = new Size(140, 21);
            menuNameTag_3.TabIndex = 17;
            menuNameTag_3.Text = " NameTag3";
            menuNameTag_3.TextAlign = HorizontalAlignment.Center;
            menuNameTag_3.UseWaitCursor = true;
            // 
            // menuNameTag_6
            // 
            menuNameTag_6.BorderStyle = BorderStyle.None;
            menuNameTag_6.Font = new Font("HS봄바람체 3.0 Regular", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuNameTag_6.Location = new Point(406, 568);
            menuNameTag_6.Margin = new Padding(4, 5, 4, 5);
            menuNameTag_6.Name = "menuNameTag_6";
            menuNameTag_6.Size = new Size(140, 21);
            menuNameTag_6.TabIndex = 27;
            menuNameTag_6.Text = " NameTag6";
            menuNameTag_6.TextAlign = HorizontalAlignment.Center;
            menuNameTag_6.UseWaitCursor = true;
            // 
            // menuNameTag_5
            // 
            menuNameTag_5.BorderStyle = BorderStyle.None;
            menuNameTag_5.Font = new Font("HS봄바람체 3.0 Regular", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuNameTag_5.Location = new Point(210, 568);
            menuNameTag_5.Margin = new Padding(4, 5, 4, 5);
            menuNameTag_5.Name = "menuNameTag_5";
            menuNameTag_5.Size = new Size(140, 21);
            menuNameTag_5.TabIndex = 26;
            menuNameTag_5.Text = " NameTag5";
            menuNameTag_5.TextAlign = HorizontalAlignment.Center;
            menuNameTag_5.UseWaitCursor = true;
            // 
            // menuNameTag_4
            // 
            menuNameTag_4.BorderStyle = BorderStyle.None;
            menuNameTag_4.Font = new Font("HS봄바람체 3.0 Regular", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuNameTag_4.Location = new Point(14, 568);
            menuNameTag_4.Margin = new Padding(4, 5, 4, 5);
            menuNameTag_4.Name = "menuNameTag_4";
            menuNameTag_4.Size = new Size(140, 21);
            menuNameTag_4.TabIndex = 25;
            menuNameTag_4.Text = " NameTag4";
            menuNameTag_4.TextAlign = HorizontalAlignment.Center;
            menuNameTag_4.UseWaitCursor = true;
            // 
            // cancel_Button
            // 
            cancel_Button.FlatAppearance.BorderSize = 0;
            cancel_Button.FlatStyle = FlatStyle.Flat;
            cancel_Button.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_Button.Image = Properties.Resources.button_deleteMenu;
            cancel_Button.Location = new Point(304, 687);
            cancel_Button.Margin = new Padding(4, 5, 4, 5);
            cancel_Button.Name = "cancel_Button";
            cancel_Button.Size = new Size(248, 60);
            cancel_Button.TabIndex = 22;
            cancel_Button.UseVisualStyleBackColor = true;
            cancel_Button.Click += deleteMenu;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Image = Properties.Resources.button_cake;
            button4.Location = new Point(209, 169);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(144, 32);
            button4.TabIndex = 24;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_selectcake;
            // 
            // backButton
            // 
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Image = Properties.Resources.button_return;
            backButton.Location = new Point(457, 618);
            backButton.Margin = new Padding(4, 5, 4, 5);
            backButton.Name = "backButton";
            backButton.Size = new Size(95, 29);
            backButton.TabIndex = 23;
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // label1
            // 
            label1.Image = Properties.Resources.BANNER;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(542, 151);
            label1.TabIndex = 31;
            // 
            // menuPrice_1
            // 
            menuPrice_1.BorderStyle = BorderStyle.None;
            menuPrice_1.Font = new Font("HS유지체 ", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuPrice_1.Location = new Point(14, 390);
            menuPrice_1.Name = "menuPrice_1";
            menuPrice_1.Size = new Size(141, 17);
            menuPrice_1.TabIndex = 39;
            menuPrice_1.Text = "10000원";
            menuPrice_1.TextAlign = HorizontalAlignment.Center;
            // 
            // menuPrice_2
            // 
            menuPrice_2.BorderStyle = BorderStyle.None;
            menuPrice_2.Font = new Font("HS유지체 ", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuPrice_2.Location = new Point(209, 389);
            menuPrice_2.Name = "menuPrice_2";
            menuPrice_2.Size = new Size(141, 17);
            menuPrice_2.TabIndex = 40;
            menuPrice_2.Text = "10000원";
            menuPrice_2.TextAlign = HorizontalAlignment.Center;
            // 
            // menuPrice_3
            // 
            menuPrice_3.BorderStyle = BorderStyle.None;
            menuPrice_3.Font = new Font("HS유지체 ", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuPrice_3.Location = new Point(405, 389);
            menuPrice_3.Name = "menuPrice_3";
            menuPrice_3.Size = new Size(141, 17);
            menuPrice_3.TabIndex = 41;
            menuPrice_3.Text = "10000원";
            menuPrice_3.TextAlign = HorizontalAlignment.Center;
            // 
            // menuPrice_4
            // 
            menuPrice_4.BorderStyle = BorderStyle.None;
            menuPrice_4.Font = new Font("HS유지체 ", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuPrice_4.Location = new Point(14, 591);
            menuPrice_4.Name = "menuPrice_4";
            menuPrice_4.Size = new Size(141, 17);
            menuPrice_4.TabIndex = 42;
            menuPrice_4.Text = "10000원";
            menuPrice_4.TextAlign = HorizontalAlignment.Center;
            // 
            // menuPrice_6
            // 
            menuPrice_6.BorderStyle = BorderStyle.None;
            menuPrice_6.Font = new Font("HS유지체 ", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuPrice_6.Location = new Point(402, 593);
            menuPrice_6.Name = "menuPrice_6";
            menuPrice_6.Size = new Size(141, 17);
            menuPrice_6.TabIndex = 43;
            menuPrice_6.Text = "10000원";
            menuPrice_6.TextAlign = HorizontalAlignment.Center;
            // 
            // menuPrice_5
            // 
            menuPrice_5.BorderStyle = BorderStyle.None;
            menuPrice_5.Font = new Font("HS유지체 ", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuPrice_5.Location = new Point(209, 591);
            menuPrice_5.Name = "menuPrice_5";
            menuPrice_5.Size = new Size(141, 17);
            menuPrice_5.TabIndex = 44;
            menuPrice_5.Text = "10000원";
            menuPrice_5.TextAlign = HorizontalAlignment.Center;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(562, 861);
            Controls.Add(menuPrice_5);
            Controls.Add(menuPrice_6);
            Controls.Add(menuPrice_4);
            Controls.Add(menuPrice_3);
            Controls.Add(menuPrice_2);
            Controls.Add(menuPrice_1);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(cancel_Button);
            Controls.Add(button4);
            Controls.Add(menuNameTag_3);
            Controls.Add(menuNameTag_2);
            Controls.Add(menuNameTag_1);
            Controls.Add(menuNameTag_6);
            Controls.Add(menuNameTag_5);
            Controls.Add(menuNameTag_4);
            Controls.Add(menuButton_5);
            Controls.Add(menuButton_4);
            Controls.Add(menuButton_6);
            Controls.Add(menuButton_2);
            Controls.Add(menuButton_1);
            Controls.Add(totalPrice);
            Controls.Add(purchase_Button);
            Controls.Add(selectedMenu_list);
            Controls.Add(menuButton_3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        /*private Button button6;*/
        private Button menuButton_5;
        private Button menuButton_4;
        private Button menuButton_6;
        private Button menuButton_3;
        private ListBox selectedMenu_list;
        private Button purchase_Button;
        private TextBox totalPrice;
        private TextBox menuNameTag_1;
        private TextBox menuNameTag_2;
        private TextBox menuNameTag_3;
        private TextBox menuNameTag_6;
        private TextBox menuNameTag_5;
        private TextBox menuNameTag_4;
        private Button menuButton_1;
        private Button menuButton_2;
        private ImageList imageList1;
        private Button button4;
        private Button cancel_Button;
        private Button backButton;
        private Label label1;
        private TextBox menuPrice_1;
        private TextBox menuPrice_2;
        private TextBox menuPrice_3;
        private TextBox menuPrice_4;
        private TextBox menuPrice_6;
        private TextBox menuPrice_5;
    }
}