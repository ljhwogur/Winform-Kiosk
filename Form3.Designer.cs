namespace Kiosk
{
 partial class Form3
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
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        tPrice1 = new TextBox();
        tPrice2 = new TextBox();
        tPrice3 = new TextBox();
        button4 = new Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(12, 31);
        button1.Name = "button1";
        button1.Size = new Size(117, 116);
        button1.TabIndex = 0;
        button1.Text = "딸기";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(179, 31);
        button2.Name = "button2";
        button2.Size = new Size(117, 116);
        button2.TabIndex = 1;
        button2.Text = "연유";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(346, 31);
        button3.Name = "button3";
        button3.Size = new Size(117, 116);
        button3.TabIndex = 2;
        button3.Text = "떡";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // tPrice1
        // 
        tPrice1.BorderStyle = BorderStyle.None;
        tPrice1.Location = new Point(22, 154);
        tPrice1.Margin = new Padding(4);
        tPrice1.Name = "tPrice1";
        tPrice1.Size = new Size(93, 20);
        tPrice1.TabIndex = 16;
        tPrice1.Text = "1000";
        tPrice1.TextAlign = HorizontalAlignment.Center;
        tPrice1.UseWaitCursor = true;
        // 
        // tPrice2
        // 
        tPrice2.BorderStyle = BorderStyle.None;
        tPrice2.Location = new Point(190, 154);
        tPrice2.Margin = new Padding(4);
        tPrice2.Name = "tPrice2";
        tPrice2.Size = new Size(93, 20);
        tPrice2.TabIndex = 17;
        tPrice2.Text = "300";
        tPrice2.TextAlign = HorizontalAlignment.Center;
        tPrice2.UseWaitCursor = true;
        // 
        // tPrice3
        // 
        tPrice3.BorderStyle = BorderStyle.None;
        tPrice3.Location = new Point(357, 154);
        tPrice3.Margin = new Padding(4);
        tPrice3.Name = "tPrice3";
        tPrice3.Size = new Size(93, 20);
        tPrice3.TabIndex = 18;
        tPrice3.Text = "500";
        tPrice3.TextAlign = HorizontalAlignment.Center;
        tPrice3.UseWaitCursor = true;
        // 
        // button4
        // 
        button4.Location = new Point(346, 373);
        button4.Name = "button4";
        button4.Size = new Size(117, 55);
        button4.TabIndex = 19;
        button4.Text = "추가 완료";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // Form2
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(475, 450);
        Controls.Add(button4);
        Controls.Add(tPrice3);
        Controls.Add(tPrice2);
        Controls.Add(tPrice1);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Name = "Form2";
        Text = "Form2";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Button button2;
    private Button button3;
    private TextBox tPrice1;
    private TextBox tPrice2;
    private TextBox tPrice3;
    private Button button4;
}
}