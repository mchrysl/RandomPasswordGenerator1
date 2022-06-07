namespace RandomPasswordGenerator1
{
    public partial class RandPasswdGen : Form
    {
        public RandPasswdGen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Are you sure you want to close the application?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
                        
        }

        private void GenPasswdBtn_Click(object sender, EventArgs e)
        {
            //Bring in values from screen and put into variables

            List<string> charInputs = new List<string>();
            if(lowerAZ.Checked == true) charInputs.Add("upperAlpha");

            if (upperAZ.Checked == true) charInputs.Add("lowerAlpha");

            if (digits.Checked == true) charInputs.Add("numbers");

            if (specialChar.Checked == true) charInputs.Add("specChar");


            MessageBox.Show("Well, you clicked the submit button.\r\nNow to make it work.", "", MessageBoxButtons.OK);
        }

        private void lowerAZ_CheckedChanged(object sender, EventArgs e)
        {
            RoutineToCheckBoxes();
            /*
            //there must be 2 character sets chosen
            int setsChosen = 0;
            if (upperAZ.Checked == true) setsChosen++;
            if (lowerAZ.Checked == true) setsChosen++;
            if (digits.Checked == true) setsChosen++;
            if (specialChar.Checked == true) setsChosen++;
            if (setsChosen >= 2)
            {
                mustChooseTwo.Visible = false;
                numberPasswords.Enabled = true;
            }
            else
            {
                mustChooseTwo.Visible = true;
                numberPasswords.Enabled = false;
            }
            */
        }

        private void CharChooseBox_Enter(object sender, EventArgs e)
        {
            //there must be 2 character sets chosen
            int setsChosen = 0;
            if (upperAZ.Checked == true) setsChosen++;
            if (lowerAZ.Checked == true) setsChosen++;
            if (digits.Checked == true) setsChosen++;
            if (specialChar.Checked == true) setsChosen++;
            if (setsChosen >= 2)
            {
                mustChooseTwo.Visible = false;
            }
            else
            {
                mustChooseTwo.Visible = true;
            }
        }

        private void digits_CheckedChanged(object sender, EventArgs e)
        {
            RoutineToCheckBoxes();
            /*
            //there must be 2 character sets chosen
            int setsChosen = 0;
            if (upperAZ.Checked == true) setsChosen++;
            if (lowerAZ.Checked == true) setsChosen++;
            if (digits.Checked == true) setsChosen++;
            if (specialChar.Checked == true) setsChosen++;
            if (setsChosen >= 2)
            {
                mustChooseTwo.Visible = false;
                numberPasswords.Enabled = true;
            }
            else
            {
                mustChooseTwo.Visible = true;
                numberPasswords.Enabled = false;
            }
            */
        }

        private void specialChar_CheckedChanged(object sender, EventArgs e)
        {
            RoutineToCheckBoxes();
            /*
            //there must be 2 character sets chosen
            int setsChosen = 0;
            if (upperAZ.Checked == true) setsChosen++;
            if (lowerAZ.Checked == true) setsChosen++;
            if (digits.Checked == true) setsChosen++;
            if (specialChar.Checked == true) setsChosen++;
            if (setsChosen >= 2)
            {
                mustChooseTwo.Visible = false;
                numberPasswords.Enabled = true;
            }
            else
            {
                mustChooseTwo.Visible = true;
                numberPasswords.Enabled = false;
            }
            */
        }

        private void upperAZ_CheckedChanged(object sender, EventArgs e)
        {
            RoutineToCheckBoxes();
        }
        
        private void RoutineToCheckBoxes()
        {
            //there must be 2 character sets chosen
            int setsChosen = 0;
            if (upperAZ.Checked == true) setsChosen++;
            if (lowerAZ.Checked == true) setsChosen++;
            if (digits.Checked == true) setsChosen++;
            if (specialChar.Checked == true) setsChosen++;
            if (setsChosen >= 2)
            {
                mustChooseTwo.Visible = false;
                numberPasswords.Enabled = true;
            }
            else
            {
                mustChooseTwo.Visible = true;
                numberPasswords.Enabled = false;
            }
        }

    }
}