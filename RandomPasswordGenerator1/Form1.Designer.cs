namespace RandomPasswordGenerator1
{
    partial class RandPasswdGen
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberPasswords = new System.Windows.Forms.NumericUpDown();
            this.lowerAZ = new System.Windows.Forms.CheckBox();
            this.upperAZ = new System.Windows.Forms.CheckBox();
            this.digits = new System.Windows.Forms.CheckBox();
            this.specialChar = new System.Windows.Forms.CheckBox();
            this.CharChooseBox = new System.Windows.Forms.GroupBox();
            this.mustChooseTwo = new System.Windows.Forms.Label();
            this.HowManyBox = new System.Windows.Forms.GroupBox();
            this.OutputPrefBox = new System.Windows.Forms.GroupBox();
            this.rbtnOutputScreen = new System.Windows.Forms.RadioButton();
            this.rbtnOutputText = new System.Windows.Forms.RadioButton();
            this.rbtnOutputCSV = new System.Windows.Forms.RadioButton();
            this.genPasswdBtn = new System.Windows.Forms.Button();
            this.FormInternalLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblPasswordList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberPasswords)).BeginInit();
            this.CharChooseBox.SuspendLayout();
            this.HowManyBox.SuspendLayout();
            this.OutputPrefBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate how many passwords?";
            // 
            // numberPasswords
            // 
            this.numberPasswords.Enabled = false;
            this.numberPasswords.Location = new System.Drawing.Point(203, 17);
            this.numberPasswords.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberPasswords.Name = "numberPasswords";
            this.numberPasswords.Size = new System.Drawing.Size(120, 23);
            this.numberPasswords.TabIndex = 1;
            this.numberPasswords.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lowerAZ
            // 
            this.lowerAZ.AutoSize = true;
            this.lowerAZ.Location = new System.Drawing.Point(31, 50);
            this.lowerAZ.Name = "lowerAZ";
            this.lowerAZ.Size = new System.Drawing.Size(147, 19);
            this.lowerAZ.TabIndex = 2;
            this.lowerAZ.Text = "Alpha Lower Case (a-z)";
            this.lowerAZ.UseVisualStyleBackColor = true;
            this.lowerAZ.CheckedChanged += new System.EventHandler(this.RoutineToCheckBoxes);
            // 
            // upperAZ
            // 
            this.upperAZ.AutoSize = true;
            this.upperAZ.Location = new System.Drawing.Point(31, 75);
            this.upperAZ.Name = "upperAZ";
            this.upperAZ.Size = new System.Drawing.Size(151, 19);
            this.upperAZ.TabIndex = 3;
            this.upperAZ.Text = "Alpha Upper Case (A-Z)";
            this.upperAZ.UseVisualStyleBackColor = true;
            this.upperAZ.CheckedChanged += new System.EventHandler(this.RoutineToCheckBoxes);
            // 
            // digits
            // 
            this.digits.AutoSize = true;
            this.digits.Location = new System.Drawing.Point(31, 100);
            this.digits.Name = "digits";
            this.digits.Size = new System.Drawing.Size(128, 19);
            this.digits.TabIndex = 4;
            this.digits.Text = "Numeric Digit (0-9)";
            this.digits.UseVisualStyleBackColor = true;
            this.digits.CheckedChanged += new System.EventHandler(this.RoutineToCheckBoxes);
            // 
            // specialChar
            // 
            this.specialChar.AutoSize = true;
            this.specialChar.Location = new System.Drawing.Point(31, 125);
            this.specialChar.Name = "specialChar";
            this.specialChar.Size = new System.Drawing.Size(199, 19);
            this.specialChar.TabIndex = 5;
            this.specialChar.Text = "Special Characters ( ! @ # $ % & * )";
            this.specialChar.UseVisualStyleBackColor = true;
            this.specialChar.CheckedChanged += new System.EventHandler(this.RoutineToCheckBoxes);
            // 
            // CharChooseBox
            // 
            this.CharChooseBox.Controls.Add(this.mustChooseTwo);
            this.CharChooseBox.Controls.Add(this.specialChar);
            this.CharChooseBox.Controls.Add(this.lowerAZ);
            this.CharChooseBox.Controls.Add(this.digits);
            this.CharChooseBox.Controls.Add(this.upperAZ);
            this.CharChooseBox.Location = new System.Drawing.Point(40, 122);
            this.CharChooseBox.Name = "CharChooseBox";
            this.CharChooseBox.Size = new System.Drawing.Size(338, 163);
            this.CharChooseBox.TabIndex = 7;
            this.CharChooseBox.TabStop = false;
            this.CharChooseBox.Text = "Choose which characters will appear in your password(s):";
            // 
            // mustChooseTwo
            // 
            this.mustChooseTwo.AutoSize = true;
            this.mustChooseTwo.Location = new System.Drawing.Point(28, 18);
            this.mustChooseTwo.Name = "mustChooseTwo";
            this.mustChooseTwo.Size = new System.Drawing.Size(155, 15);
            this.mustChooseTwo.TabIndex = 6;
            this.mustChooseTwo.Text = "(must choose at least 2 sets)";
            // 
            // HowManyBox
            // 
            this.HowManyBox.Controls.Add(this.label1);
            this.HowManyBox.Controls.Add(this.numberPasswords);
            this.HowManyBox.Location = new System.Drawing.Point(40, 332);
            this.HowManyBox.Name = "HowManyBox";
            this.HowManyBox.Size = new System.Drawing.Size(329, 50);
            this.HowManyBox.TabIndex = 8;
            this.HowManyBox.TabStop = false;
            // 
            // OutputPrefBox
            // 
            this.OutputPrefBox.Controls.Add(this.rbtnOutputScreen);
            this.OutputPrefBox.Controls.Add(this.rbtnOutputText);
            this.OutputPrefBox.Controls.Add(this.rbtnOutputCSV);
            this.OutputPrefBox.Location = new System.Drawing.Point(40, 435);
            this.OutputPrefBox.Name = "OutputPrefBox";
            this.OutputPrefBox.Size = new System.Drawing.Size(200, 100);
            this.OutputPrefBox.TabIndex = 9;
            this.OutputPrefBox.TabStop = false;
            this.OutputPrefBox.Text = "Pick the output preference:";
            // 
            // rbtnOutputScreen
            // 
            this.rbtnOutputScreen.AutoSize = true;
            this.rbtnOutputScreen.Checked = true;
            this.rbtnOutputScreen.Location = new System.Drawing.Point(29, 74);
            this.rbtnOutputScreen.Name = "rbtnOutputScreen";
            this.rbtnOutputScreen.Size = new System.Drawing.Size(172, 19);
            this.rbtnOutputScreen.TabIndex = 2;
            this.rbtnOutputScreen.TabStop = true;
            this.rbtnOutputScreen.Text = "To the screen (new window)";
            this.rbtnOutputScreen.UseVisualStyleBackColor = true;
            // 
            // rbtnOutputText
            // 
            this.rbtnOutputText.AutoSize = true;
            this.rbtnOutputText.Enabled = false;
            this.rbtnOutputText.Location = new System.Drawing.Point(29, 51);
            this.rbtnOutputText.Name = "rbtnOutputText";
            this.rbtnOutputText.Size = new System.Drawing.Size(67, 19);
            this.rbtnOutputText.TabIndex = 1;
            this.rbtnOutputText.Text = "Text File";
            this.rbtnOutputText.UseVisualStyleBackColor = true;
            // 
            // rbtnOutputCSV
            // 
            this.rbtnOutputCSV.AutoSize = true;
            this.rbtnOutputCSV.Enabled = false;
            this.rbtnOutputCSV.Location = new System.Drawing.Point(29, 28);
            this.rbtnOutputCSV.Name = "rbtnOutputCSV";
            this.rbtnOutputCSV.Size = new System.Drawing.Size(65, 19);
            this.rbtnOutputCSV.TabIndex = 0;
            this.rbtnOutputCSV.Text = "CSV file";
            this.rbtnOutputCSV.UseVisualStyleBackColor = true;
            // 
            // genPasswdBtn
            // 
            this.genPasswdBtn.Enabled = false;
            this.genPasswdBtn.Location = new System.Drawing.Point(37, 569);
            this.genPasswdBtn.Name = "genPasswdBtn";
            this.genPasswdBtn.Size = new System.Drawing.Size(181, 54);
            this.genPasswdBtn.TabIndex = 10;
            this.genPasswdBtn.Text = "Generate Passwords";
            this.genPasswdBtn.UseVisualStyleBackColor = true;
            this.genPasswdBtn.Click += new System.EventHandler(this.GenPasswdBtn_Click);
            // 
            // FormInternalLbl
            // 
            this.FormInternalLbl.AutoSize = true;
            this.FormInternalLbl.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormInternalLbl.Location = new System.Drawing.Point(91, 21);
            this.FormInternalLbl.Name = "FormInternalLbl";
            this.FormInternalLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FormInternalLbl.Size = new System.Drawing.Size(575, 59);
            this.FormInternalLbl.TabIndex = 11;
            this.FormInternalLbl.Text = "Random Password Generator";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(688, 618);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 30);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Exit Program";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(503, 155);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(181, 388);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // lblPasswordList
            // 
            this.lblPasswordList.AutoSize = true;
            this.lblPasswordList.Location = new System.Drawing.Point(502, 123);
            this.lblPasswordList.Name = "lblPasswordList";
            this.lblPasswordList.Size = new System.Drawing.Size(138, 15);
            this.lblPasswordList.TabIndex = 14;
            this.lblPasswordList.Text = "Generated Password List:";
            // 
            // RandPasswdGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.lblPasswordList);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.FormInternalLbl);
            this.Controls.Add(this.genPasswdBtn);
            this.Controls.Add(this.OutputPrefBox);
            this.Controls.Add(this.HowManyBox);
            this.Controls.Add(this.CharChooseBox);
            this.Name = "RandPasswdGen";
            this.Text = "Random Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberPasswords)).EndInit();
            this.CharChooseBox.ResumeLayout(false);
            this.CharChooseBox.PerformLayout();
            this.HowManyBox.ResumeLayout(false);
            this.HowManyBox.PerformLayout();
            this.OutputPrefBox.ResumeLayout(false);
            this.OutputPrefBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown numberPasswords;
        private CheckBox lowerAZ;
        private CheckBox upperAZ;
        private CheckBox digits;
        private CheckBox specialChar;
        private GroupBox CharChooseBox;
        private GroupBox HowManyBox;
        private GroupBox OutputPrefBox;
        private RadioButton rbtnOutputScreen;
        private RadioButton rbtnOutputText;
        private RadioButton rbtnOutputCSV;
        private Button genPasswdBtn;
        private Label FormInternalLbl;
        private Button exitBtn;
        private Label mustChooseTwo;
        private RichTextBox richTextBox1;
        private Label lblPasswordList;
    }
}