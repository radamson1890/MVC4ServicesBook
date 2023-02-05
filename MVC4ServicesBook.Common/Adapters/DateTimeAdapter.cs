using MVC4ServicesBook.Common.Interfaces;

namespace MVC4ServicesBook.Common
{
   
    public class DateTimeAdapter : IDateTime
    {
        public DateTime UtcNow
        {
            get { return DateTime.UtcNow; }
        }
    }
}