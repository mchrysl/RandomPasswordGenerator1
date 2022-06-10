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