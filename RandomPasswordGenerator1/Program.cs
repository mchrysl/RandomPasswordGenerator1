namespace RandomPasswordGenerator1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new RandPasswdGen());


        }




        /*
        private List<List<char>> SetupCharTable(List<string> charTypes)
        {
            List<List<char>> result = new List<List<char>>();
            int listIndex = 0;
            /* Setup:
                *      upperAlpha - a list of uppercase letters
                *      lowerAlpha - a list of lowercase letters
                *      numbers - a list of numbers 0 - 9)
                *      specChar - a list of special characters (! @ # $ *)
                *     
                /*

            foreach (string charType in charTypes)
            {
                switch (charType)
                {
                    case ("upperAlpha"):
                        List<char> uAlpha = new()
                        { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                        result.Add(uAlpha);
                        listIndex++;
                        break;
                    case ("lowerAlpha"):
                        List<char> lAlpha = new ()
                        { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                        result.Add(lAlpha);
                        listIndex++;
                        break;
                    case ("numbers"):
                        List<char> numbers = new () { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                        result.Add(numbers);
                        listIndex++;
                        break;
                    case ("specialChars"):
                        List<char> specChar = new () { '!', '@', '#', '$', '*' };
                        result.Add(specChar);
                        listIndex++;
                        break;
                    default:
                        break;
                }
               
            }
            return result;
        }


        /*
         * Logic:
         * 
         *      1. Read in variables from from:
         *          how many passwords, 
         *          which character groups are used,
         *          which output is used (start with just onscreen)
         *      Note: starting with default password length of 8 chars
         */


        /*      
        *      2. Create a new password
        *          2.1. Randomly choose from selected character groups
        *          2.2. Randomly pick one char from the selected group
        *          2.3. Add to password
        *      3. Make sure new password is not a duplicate
        *          3.1. Loop through password list
        *              3.1.1 If password has a match in the list, wipe out the password and create a new one
        *              3.1.2. If password does not have a match in the list, add it to the list
        *      4. If the number of passwords is less than requested password count
        *          4.1. Reset variables to create a new password
        *          4.2 go to step 2. Create a new Password
        *      5. If the number of passwords is met
        *          5.1. Output the list via requested format (CSV, TXT, screen)
        * 
        * 
        */


    }
}