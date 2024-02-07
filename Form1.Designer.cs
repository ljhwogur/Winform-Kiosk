namespace Kiosk
{
    partial class Form1
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
            btnDineln = new Button();
            btnTakeOut = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnDineln
            // 
            btnDineln.BackColor = SystemColors.ControlDark;
            btnDineln.FlatAppearance.BorderSize = 0;
            btnDineln.FlatStyle = FlatStyle.Flat;
            btnDineln.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btnDineln.Location = new Point(300, 517);
            btnDineln.Name = "btnDineln";
            btnDineln.Size = new Size(250, 330);
            btnDineln.TabIndex = 0;
            btnDineln.Text = "매장에서먹기";
            btnDineln.UseVisualStyleBackColor = false;
            btnDineln.Click += btnDineln_Click;
            // 
            // btnTakeOut
            // 
            btnTakeOut.BackColor = SystemColors.ControlDark;
            btnTakeOut.FlatAppearance.BorderSize = 0;
            btnTakeOut.FlatStyle = FlatStyle.Flat;
            btnTakeOut.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Bold, GraphicsUnit.Point);
            btnTakeOut.Image = Properties.Resources.button_takeout;
            btnTakeOut.Location = new Point(12, 517);
            btnTakeOut.Name = "btnTakeOut";
            btnTakeOut.Size = new Size(250, 330);
            btnTakeOut.TabIndex = 1;
            btnTakeOut.Text = "포장하기";
            btnTakeOut.UseVisualStyleBackColor = false;
            btnTakeOut.Click += btnTakeOut_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Image = Properties.Resources.gonggangab_logo;
            label2.Location = new Point(41, 40);
            label2.Name = "label2";
            label2.Size = new Size(480, 368);
            label2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.button_takein;
            button1.Location = new Point(300, 517);
            button1.Name = "button1";
            button1.Size = new Size(250, 330);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnDineln_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 13.999999F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.button_takeout;
            button2.Location = new Point(12, 517);
            button2.Name = "button2";
            button2.Size = new Size(250, 330);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnTakeOut_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(562, 861);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnTakeOut);
            Controls.Add(btnDineln);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDineln;
        private Button btnTakeOut;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}