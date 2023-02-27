namespace wesh_calculator
{
    partial class calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            ResultBox = new TextBox();
            SevenBtn = new Button();
            FourBtn = new Button();
            ZeroBtn = new Button();
            DotBtn = new Button();
            TwoBtn = new Button();
            FiveBtn = new Button();
            EightBtn = new Button();
            EqualBtn = new Button();
            ThreeBtn = new Button();
            SixBtn = new Button();
            NineBtn = new Button();
            PercentageBtn = new Button();
            MultiplyBtn = new Button();
            PlusBtn = new Button();
            PlusMinusBtn = new Button();
            DivideBtn = new Button();
            MinusBtn = new Button();
            ClearBtn = new Button();
            OneBtn = new Button();
            SuspendLayout();
            // 
            // ResultBox
            // 
            ResultBox.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            ResultBox.Location = new Point(19, 12);
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(581, 50);
            ResultBox.TabIndex = 0;
            ResultBox.Text = "3";
            ResultBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SevenBtn
            // 
            SevenBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SevenBtn.Location = new Point(19, 85);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(80, 80);
            SevenBtn.TabIndex = 1;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FourBtn.Location = new Point(19, 184);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(80, 80);
            FourBtn.TabIndex = 2;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += FourBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ZeroBtn.Location = new Point(19, 382);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(80, 80);
            ZeroBtn.TabIndex = 4;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += ZeroBtn_Click;
            // 
            // DotBtn
            // 
            DotBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DotBtn.Location = new Point(129, 382);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(80, 80);
            DotBtn.TabIndex = 8;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += DotBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TwoBtn.Location = new Point(129, 282);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(80, 80);
            TwoBtn.TabIndex = 7;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FiveBtn.Location = new Point(129, 184);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(80, 80);
            FiveBtn.TabIndex = 6;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // EightBtn
            // 
            EightBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            EightBtn.Location = new Point(129, 85);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(80, 80);
            EightBtn.TabIndex = 5;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += EightBtn_Click;
            // 
            // EqualBtn
            // 
            EqualBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            EqualBtn.Location = new Point(237, 382);
            EqualBtn.Name = "EqualBtn";
            EqualBtn.Size = new Size(80, 80);
            EqualBtn.TabIndex = 12;
            EqualBtn.Text = "=";
            EqualBtn.UseVisualStyleBackColor = true;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ThreeBtn.Location = new Point(237, 282);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(80, 80);
            ThreeBtn.TabIndex = 11;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SixBtn.Location = new Point(237, 184);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(80, 80);
            SixBtn.TabIndex = 10;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += SixBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NineBtn.Location = new Point(237, 85);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(80, 80);
            NineBtn.TabIndex = 9;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += NineBtn_Click;
            // 
            // PercentageBtn
            // 
            PercentageBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PercentageBtn.Location = new Point(520, 382);
            PercentageBtn.Name = "PercentageBtn";
            PercentageBtn.Size = new Size(80, 80);
            PercentageBtn.TabIndex = 16;
            PercentageBtn.Text = "%";
            PercentageBtn.UseVisualStyleBackColor = true;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MultiplyBtn.Location = new Point(520, 282);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(80, 80);
            MultiplyBtn.TabIndex = 15;
            MultiplyBtn.Text = "x";
            MultiplyBtn.UseVisualStyleBackColor = true;
            // 
            // PlusBtn
            // 
            PlusBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PlusBtn.Location = new Point(520, 184);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(80, 80);
            PlusBtn.TabIndex = 14;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            // 
            // PlusMinusBtn
            // 
            PlusMinusBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PlusMinusBtn.Location = new Point(415, 382);
            PlusMinusBtn.Name = "PlusMinusBtn";
            PlusMinusBtn.Size = new Size(80, 80);
            PlusMinusBtn.TabIndex = 20;
            PlusMinusBtn.Text = "+/-";
            PlusMinusBtn.UseVisualStyleBackColor = true;
            // 
            // DivideBtn
            // 
            DivideBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DivideBtn.Location = new Point(415, 282);
            DivideBtn.Name = "DivideBtn";
            DivideBtn.Size = new Size(80, 80);
            DivideBtn.TabIndex = 19;
            DivideBtn.Text = "/";
            DivideBtn.UseVisualStyleBackColor = true;
            // 
            // MinusBtn
            // 
            MinusBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MinusBtn.Location = new Point(415, 184);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(80, 80);
            MinusBtn.TabIndex = 18;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBtn.Location = new Point(415, 85);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(185, 80);
            ClearBtn.TabIndex = 17;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            // 
            // OneBtn
            // 
            OneBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            OneBtn.Location = new Point(19, 282);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(80, 80);
            OneBtn.TabIndex = 21;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += OneBtn_Click;
            // 
            // calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(625, 482);
            Controls.Add(OneBtn);
            Controls.Add(PlusMinusBtn);
            Controls.Add(DivideBtn);
            Controls.Add(MinusBtn);
            Controls.Add(ClearBtn);
            Controls.Add(PercentageBtn);
            Controls.Add(MultiplyBtn);
            Controls.Add(PlusBtn);
            Controls.Add(EqualBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(SixBtn);
            Controls.Add(NineBtn);
            Controls.Add(DotBtn);
            Controls.Add(TwoBtn);
            Controls.Add(FiveBtn);
            Controls.Add(EightBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(FourBtn);
            Controls.Add(SevenBtn);
            Controls.Add(ResultBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "calculator";
            Text = "Wesh Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ResultBox;
        private Button SevenBtn;
        private Button FourBtn;
        private Button ZeroBtn;
        private Button DotBtn;
        private Button TwoBtn;
        private Button FiveBtn;
        private Button EightBtn;
        private Button EqualBtn;
        private Button ThreeBtn;
        private Button SixBtn;
        private Button NineBtn;
        private Button PercentageBtn;
        private Button MultiplyBtn;
        private Button PlusBtn;
        private Button PlusMinusBtn;
        private Button DivideBtn;
        private Button MinusBtn;
        private Button ClearBtn;
        private Button OneBtn;
    }
}