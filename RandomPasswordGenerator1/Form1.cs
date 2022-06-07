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

        

        private void RoutineToCheckBoxes(object sender, EventArgs e)
        {
            int maxCharacters = 0;
            //there must be 2 character sets chosen
            int setsChosen = 0;
            if (upperAZ.Checked == true)
            {
                setsChosen++;
                maxCharacters += 26;
            }
            if (lowerAZ.Checked == true)
            {
                setsChosen++;
                maxCharacters += 26;
            }
            if (digits.Checked == true)
            {
                setsChosen++;
                maxCharacters += 10;
            }
            if (specialChar.Checked == true)
            {
                setsChosen++;
                maxCharacters += 5;
            }
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