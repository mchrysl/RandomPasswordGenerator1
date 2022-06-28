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


        

        private void RoutineToCheckBoxes(object sender, EventArgs e)
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
                genPasswdBtn.Enabled = true;    
            }
            else
            {
                mustChooseTwo.Visible = true;
                numberPasswords.Enabled = false;
                genPasswdBtn.Enabled = false;   
            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the application?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void GenPasswdBtn_Click(object sender, EventArgs e)
        {
            
            //Declare the character source table and password list
            List<List<char>> charSourceTable = new();
            List<string> passwordList = new();
            //Bring in number of passwords to generate
            int numberOfPasswords = (int)numberPasswords.Value;
            
            //Bring in values from screen and put appropriate list into the charSourceTable
            List<string> charInputs = new();
            if (lowerAZ.Checked == true)
            {
                List<char> lAlpha = new()
                            { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                charSourceTable.Add(lAlpha);
            }

            if (upperAZ.Checked == true)
            {
                List<char> uAlpha = new()
                            { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                charSourceTable.Add(uAlpha);
            }

            if (digits.Checked == true)
            {
                List<char> numbers = new() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                charSourceTable.Add(numbers);
            }

            if (specialChar.Checked == true)
            {
                List<char> specChar = new() { '!', '@', '#', '$', '*' };
                charSourceTable.Add(specChar);
            }


            Random rand = new Random();
            int whichList = 0;
            int whichChar = 0;
            char newChar;
            string newPassword;
            //do this sequence:
            do
            {
                //Create the password:
                //choose eight characters to convert to a password string:
                List<char> passwordCharList = new ();
                
                for (int ch = 0; ch < 8; ch++)
                {
                    //randomly choose one of the lists in the table
                    whichList = rand.Next(0, charSourceTable.Count);
                    
                    //randomly choose one of the characters in the list
                    whichChar = rand.Next(0, charSourceTable[whichList].Count);
                    newChar = charSourceTable[whichList][whichChar];
                    
                    //add new character to password list
                    passwordCharList.Add(newChar);
                }

                //convert new password to string
                newPassword = new string(passwordCharList.ToArray());       //***This was key for making string from List<char> *NOT* the ToString() function***
                string message = "New Password: " + newPassword;
                
                
                //search the password list to see if the new password is a duplicate
                
                if (!(passwordList.Contains(newPassword)))
                {
                    //if new password is not a duplicate, add it to the password list
                    passwordList.Add(newPassword);
                }

                //repeat the full sequence until the number of requested passwords is created.
            } while (passwordList.Count < numberOfPasswords);


            //output to screen ****or [later development] as desired (CSV, TXT files)
            string pwOutputStr = "";
            foreach(var s in passwordList)
            {
                pwOutputStr += (s + "\n");
            }
            
            
            richTextBox1.Text = pwOutputStr;
            richTextBox1.Enabled = true;

            
        }

    }
}