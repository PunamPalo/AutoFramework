namespace AutoFramework
{
    public static class Config
    {
        public static int ElementsWaitingTimeout = 5;
          public static string BaseURL = "https://the-internet.herokuapp.com/login";
          public static string BaseURL_DynamicControl = "https://the-internet.herokuapp.com/dynamic_controls";
        public static string BaseURL_DataTable = "https://the-internet.herokuapp.com/tables#delete";
        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "tomsmith";
                public static string Password = "SuperSecretPassword!";
            }

            public static class Invalid
            {
               
                public static class Username
                {
                    public static string OtherthangivenValue = "abcd";
                    public static string EmptyUserName = "";
                }

                public static class Password
                {
                    public static string OtherthangivenValue = "abcd";
                    public static string EmptyPassword = "";
                }
            }
        }

       

        public static class AlertsTexts
        {
            
            public static string SuccessfulLoginText = "You logged into a secure area!";
            public static string SuccessfulLogOutText = "You logged out of the secure area!";
            public static string RemoveCheckBoxText = "It's gone!";

            public static string Errormessage = "Your username is invalid!";
            public static string Errormessage_Password = "Your password is invalid!";
        }
    }
    
}

