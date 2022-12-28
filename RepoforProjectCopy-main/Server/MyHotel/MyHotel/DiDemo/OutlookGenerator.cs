namespace MyHotel.DiDemo
{
    public class OutlookGenerator : IEmailGenerator
    {
        public string GenerateEmail()
        {
            return "me@outlook.com";
         }
    }
}
