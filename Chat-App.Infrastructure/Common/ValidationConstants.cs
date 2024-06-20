namespace Chat_App.Infrastructure.Common
{
    public static class ValidationConstants
    {
        //identity constants
        public const int FirstNameMin = 3;
        public const int FirstNameMax = 50;

        public const int LastNameMin = 3;
        public const int LastNameMax = 50;

        public const int ChatGroupNameMin = 1;
        public const int ChatGroupNameMax = 50;

        public const int UserNameMax = 20;
        public const int UserNameMin = 3;

        public const int EmailMax = 60;
        public const int EmailMin = 10;

        public const int PassMax = 20;
        public const int PassMin = 5;

        public const string LengthErrorMessage = "{0} should be between {2} and {1} charackters";
        public const string RequiredErrorMessage = "The field {0} is required";
    }
}
