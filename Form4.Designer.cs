using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kiosk
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBoxTotalPriceForm4 = new TextBox();
            cashbutton = new Button();
            cardbutton = new Button();
            couponbutton = new Button();
            Message = new Label();
            cancelButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textBoxTotalPriceForm4
            // 
            textBoxTotalPriceForm4.Font = new Font("HS봄바람체 3.0 Vertical Thin", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxTotalPriceForm4.Location = new Point(9, 278);
            textBoxTotalPriceForm4.Margin = new Padding(2);
            textBoxTotalPriceForm4.Name = "textBoxTotalPriceForm4";
            textBoxTotalPriceForm4.Size = new Size(413, 24);
            textBoxTotalPriceForm4.TabIndex = 0;
            textBoxTotalPriceForm4.TextAlign = HorizontalAlignment.Right;
            // 
            // cashbutton
            // 
            cashbutton.FlatAppearance.BorderSize = 0;
            cashbutton.FlatStyle = FlatStyle.Flat;
            cashbutton.Image = Properties.Resources.button_cash;
            cashbutton.Location = new Point(9, 75);
            cashbutton.Margin = new Padding(2);
            cashbutton.Name = "cashbutton";
            cashbutton.Size = new Size(132, 128);
            cashbutton.TabIndex = 1;
            cashbutton.UseVisualStyleBackColor = true;
            cashbutton.Click += cashbutton_Click;
            // 
            // cardbutton
            // 
            cardbutton.FlatAppearance.BorderSize = 0;
            cardbutton.FlatStyle = FlatStyle.Flat;
            cardbutton.Image = Properties.Resources.button_card;
            cardbutton.Location = new Point(149, 75);
            cardbutton.Margin = new Padding(2);
            cardbutton.Name = "cardbutton";
            cardbutton.Size = new Size(132, 128);
            cardbutton.TabIndex = 2;
            cardbutton.UseVisualStyleBackColor = true;
            cardbutton.Click += cardbutton_Click;
            // 
            // couponbutton
            // 
            couponbutton.FlatAppearance.BorderSize = 0;
            couponbutton.FlatStyle = FlatStyle.Flat;
            couponbutton.Image = Properties.Resources.button_coupon;
            couponbutton.Location = new Point(289, 75);
            couponbutton.Margin = new Padding(2);
            couponbutton.Name = "couponbutton";
            couponbutton.Size = new Size(132, 128);
            couponbutton.TabIndex = 3;
            couponbutton.UseVisualStyleBackColor = true;
            couponbutton.Click += couponbutton_Click;
            // 
            // Message
            // 
            Message.Location = new Point(59, 9);
            Message.Margin = new Padding(2, 0, 2, 0);
            Message.Name = "Message";
            Message.Size = new Size(311, 315);
            Message.TabIndex = 4;
            Message.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(180, 236);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(73, 43);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "취소";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += button4_Click;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            // 
            // timer2
            // 
            timer2.Interval = 5000;
            // 
            // timer3
            // 
            timer3.Interval = 5000;
            // 
            // timer4
            // 
            timer4.Interval = 5000;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 340);
            Controls.Add(cancelButton);
            Controls.Add(Message);
            Controls.Add(couponbutton);
            Controls.Add(cardbutton);
            Controls.Add(cashbutton);
            Controls.Add(textBoxTotalPriceForm4);
            Margin = new Padding(2);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTotalPriceForm4;
        private Button cashbutton;
        private Button cardbutton;
        private Button couponbutton;
        private Label Message;
        private Button cancelButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}