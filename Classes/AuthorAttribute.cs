namespace InterviewCS.Classes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorAttribute : Attribute
    {
        private string name;
        private string purpose;
        private double version;

        public AuthorAttribute(string authorName, string reason = "", double vers = 1.0)
        {
            name = authorName;
            purpose = reason;
            version = vers;
        }

    }
}