namespace Calculator
{
    partial class Calculator
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
            SevenButton = new Button();
            EightButton = new Button();
            NineButton = new Button();
            SixButton = new Button();
            FiveButton = new Button();
            FourButton = new Button();
            ThreeButton = new Button();
            TwoButton = new Button();
            OneButton = new Button();
            PeriodButton = new Button();
            ZeroButton = new Button();
            NegativeButton = new Button();
            SquareRootButton = new Button();
            SquaredButton = new Button();
            OneFractionOverButton = new Button();
            CButton = new Button();
            CEButton = new Button();
            PercentButton = new Button();
            DevideButton = new Button();
            BackspaceButton = new Button();
            EqualsButton = new Button();
            PlusButton = new Button();
            MinusButton = new Button();
            TimesButton = new Button();
            OutputTextBox = new TextBox();
            SuspendLayout();
            // 
            // SevenButton
            // 
            SevenButton.Location = new Point(224, 209);
            SevenButton.Name = "SevenButton";
            SevenButton.Size = new Size(75, 23);
            SevenButton.TabIndex = 0;
            SevenButton.Text = "7";
            SevenButton.UseVisualStyleBackColor = true;
            SevenButton.MouseClick += NumberButton_Clicked;
            // 
            // EightButton
            // 
            EightButton.Location = new Point(305, 209);
            EightButton.Name = "EightButton";
            EightButton.Size = new Size(75, 23);
            EightButton.TabIndex = 1;
            EightButton.Text = "8";
            EightButton.UseVisualStyleBackColor = true;
            EightButton.MouseClick += NumberButton_Clicked;
            // 
            // NineButton
            // 
            NineButton.Location = new Point(386, 209);
            NineButton.Name = "NineButton";
            NineButton.Size = new Size(75, 23);
            NineButton.TabIndex = 2;
            NineButton.Text = "9";
            NineButton.UseVisualStyleBackColor = true;
            NineButton.MouseClick += NumberButton_Clicked;
            // 
            // SixButton
            // 
            SixButton.Location = new Point(386, 238);
            SixButton.Name = "SixButton";
            SixButton.Size = new Size(75, 23);
            SixButton.TabIndex = 5;
            SixButton.Text = "6";
            SixButton.UseVisualStyleBackColor = true;
            SixButton.MouseClick += NumberButton_Clicked;
            // 
            // FiveButton
            // 
            FiveButton.Location = new Point(305, 238);
            FiveButton.Name = "FiveButton";
            FiveButton.Size = new Size(75, 23);
            FiveButton.TabIndex = 4;
            FiveButton.Text = "5";
            FiveButton.UseVisualStyleBackColor = true;
            FiveButton.MouseClick += NumberButton_Clicked;
            // 
            // FourButton
            // 
            FourButton.Location = new Point(224, 238);
            FourButton.Name = "FourButton";
            FourButton.Size = new Size(75, 23);
            FourButton.TabIndex = 3;
            FourButton.Text = "4";
            FourButton.UseVisualStyleBackColor = true;
            FourButton.MouseClick += NumberButton_Clicked;
            // 
            // ThreeButton
            // 
            ThreeButton.Location = new Point(386, 267);
            ThreeButton.Name = "ThreeButton";
            ThreeButton.Size = new Size(75, 23);
            ThreeButton.TabIndex = 8;
            ThreeButton.Text = "3";
            ThreeButton.UseVisualStyleBackColor = true;
            ThreeButton.MouseClick += NumberButton_Clicked;
            // 
            // TwoButton
            // 
            TwoButton.Location = new Point(305, 267);
            TwoButton.Name = "TwoButton";
            TwoButton.Size = new Size(75, 23);
            TwoButton.TabIndex = 7;
            TwoButton.Text = "2";
            TwoButton.UseVisualStyleBackColor = true;
            TwoButton.MouseClick += NumberButton_Clicked;
            // 
            // OneButton
            // 
            OneButton.Location = new Point(224, 267);
            OneButton.Name = "OneButton";
            OneButton.Size = new Size(75, 23);
            OneButton.TabIndex = 6;
            OneButton.Text = "1";
            OneButton.UseVisualStyleBackColor = true;
            OneButton.MouseClick += NumberButton_Clicked;
            // 
            // PeriodButton
            // 
            PeriodButton.Location = new Point(386, 296);
            PeriodButton.Name = "PeriodButton";
            PeriodButton.Size = new Size(75, 23);
            PeriodButton.TabIndex = 11;
            PeriodButton.Text = ".";
            PeriodButton.UseVisualStyleBackColor = true;
            PeriodButton.MouseClick += NumberButton_Clicked;
            // 
            // ZeroButton
            // 
            ZeroButton.Location = new Point(305, 296);
            ZeroButton.Name = "ZeroButton";
            ZeroButton.Size = new Size(75, 23);
            ZeroButton.TabIndex = 10;
            ZeroButton.Text = "0";
            ZeroButton.UseVisualStyleBackColor = true;
            ZeroButton.MouseClick += NumberButton_Clicked;
            // 
            // NegativeButton
            // 
            NegativeButton.Location = new Point(224, 296);
            NegativeButton.Name = "NegativeButton";
            NegativeButton.Size = new Size(75, 23);
            NegativeButton.TabIndex = 9;
            NegativeButton.Text = "+/-";
            NegativeButton.UseVisualStyleBackColor = true;
            NegativeButton.MouseClick += NegativeButton_Clicked;
            // 
            // SquareRootButton
            // 
            SquareRootButton.Location = new Point(386, 180);
            SquareRootButton.Name = "SquareRootButton";
            SquareRootButton.Size = new Size(75, 23);
            SquareRootButton.TabIndex = 17;
            SquareRootButton.Text = "²√x";
            SquareRootButton.UseVisualStyleBackColor = true;
            // 
            // SquaredButton
            // 
            SquaredButton.Location = new Point(305, 180);
            SquaredButton.Name = "SquaredButton";
            SquaredButton.Size = new Size(75, 23);
            SquaredButton.TabIndex = 16;
            SquaredButton.Text = "x²";
            SquaredButton.UseVisualStyleBackColor = true;
            SquaredButton.MouseClick += SquaredButton_Clicked;
            // 
            // OneFractionOverButton
            // 
            OneFractionOverButton.Location = new Point(224, 180);
            OneFractionOverButton.Name = "OneFractionOverButton";
            OneFractionOverButton.Size = new Size(75, 23);
            OneFractionOverButton.TabIndex = 15;
            OneFractionOverButton.Text = "⅟x";
            OneFractionOverButton.UseVisualStyleBackColor = true;
            // 
            // CButton
            // 
            CButton.Location = new Point(386, 151);
            CButton.Name = "CButton";
            CButton.Size = new Size(75, 23);
            CButton.TabIndex = 14;
            CButton.Text = "C";
            CButton.UseVisualStyleBackColor = true;
            CButton.MouseClick += CButton_Clicked;
            // 
            // CEButton
            // 
            CEButton.Location = new Point(305, 151);
            CEButton.Name = "CEButton";
            CEButton.Size = new Size(75, 23);
            CEButton.TabIndex = 13;
            CEButton.Text = "CE";
            CEButton.UseVisualStyleBackColor = true;
            // 
            // PercentButton
            // 
            PercentButton.Location = new Point(224, 151);
            PercentButton.Name = "PercentButton";
            PercentButton.Size = new Size(75, 23);
            PercentButton.TabIndex = 12;
            PercentButton.Text = "%";
            PercentButton.UseVisualStyleBackColor = true;
            // 
            // DevideButton
            // 
            DevideButton.Location = new Point(467, 180);
            DevideButton.Name = "DevideButton";
            DevideButton.Size = new Size(75, 23);
            DevideButton.TabIndex = 23;
            DevideButton.Text = "÷";
            DevideButton.UseVisualStyleBackColor = true;
            DevideButton.MouseClick += OperationButton_Clicked;
            // 
            // BackspaceButton
            // 
            BackspaceButton.Location = new Point(467, 151);
            BackspaceButton.Name = "BackspaceButton";
            BackspaceButton.Size = new Size(75, 23);
            BackspaceButton.TabIndex = 22;
            BackspaceButton.Text = "⌫";
            BackspaceButton.UseVisualStyleBackColor = true;
            BackspaceButton.MouseClick += BackspaceButton_Clicked;
            // 
            // EqualsButton
            // 
            EqualsButton.Location = new Point(467, 296);
            EqualsButton.Name = "EqualsButton";
            EqualsButton.Size = new Size(75, 23);
            EqualsButton.TabIndex = 21;
            EqualsButton.Text = "=";
            EqualsButton.UseVisualStyleBackColor = true;
            EqualsButton.MouseClick += EqualsButton_Clicked;
            // 
            // PlusButton
            // 
            PlusButton.Location = new Point(467, 267);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(75, 23);
            PlusButton.TabIndex = 20;
            PlusButton.Text = "+";
            PlusButton.UseVisualStyleBackColor = true;
            PlusButton.MouseClick += OperationButton_Clicked;
            // 
            // MinusButton
            // 
            MinusButton.Location = new Point(467, 238);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(75, 23);
            MinusButton.TabIndex = 19;
            MinusButton.Text = "-";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.MouseClick += OperationButton_Clicked;
            // 
            // TimesButton
            // 
            TimesButton.Location = new Point(467, 209);
            TimesButton.Name = "TimesButton";
            TimesButton.Size = new Size(75, 23);
            TimesButton.TabIndex = 18;
            TimesButton.Text = "x";
            TimesButton.UseVisualStyleBackColor = true;
            TimesButton.MouseClick += OperationButton_Clicked;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Location = new Point(224, 109);
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.ReadOnly = true;
            OutputTextBox.Size = new Size(318, 23);
            OutputTextBox.TabIndex = 24;
            OutputTextBox.Text = "0";
            OutputTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OutputTextBox);
            Controls.Add(DevideButton);
            Controls.Add(BackspaceButton);
            Controls.Add(EqualsButton);
            Controls.Add(PlusButton);
            Controls.Add(MinusButton);
            Controls.Add(TimesButton);
            Controls.Add(SquareRootButton);
            Controls.Add(SquaredButton);
            Controls.Add(OneFractionOverButton);
            Controls.Add(CButton);
            Controls.Add(CEButton);
            Controls.Add(PercentButton);
            Controls.Add(PeriodButton);
            Controls.Add(ZeroButton);
            Controls.Add(NegativeButton);
            Controls.Add(ThreeButton);
            Controls.Add(TwoButton);
            Controls.Add(OneButton);
            Controls.Add(SixButton);
            Controls.Add(FiveButton);
            Controls.Add(FourButton);
            Controls.Add(NineButton);
            Controls.Add(EightButton);
            Controls.Add(SevenButton);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SevenButton;
        private Button EightButton;
        private Button NineButton;
        private Button SixButton;
        private Button FiveButton;
        private Button FourButton;
        private Button ThreeButton;
        private Button TwoButton;
        private Button OneButton;
        private Button PeriodButton;
        private Button ZeroButton;
        private Button NegativeButton;
        private Button SquareRootButton;
        private Button SquaredButton;
        private Button OneFractionOverButton;
        private Button CButton;
        private Button CEButton;
        private Button PercentButton;
        private Button DevideButton;
        private Button BackspaceButton;
        private Button EqualsButton;
        private Button PlusButton;
        private Button MinusButton;
        private Button TimesButton;
        private TextBox OutputTextBox;
    }
}
