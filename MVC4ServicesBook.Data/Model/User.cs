namespace MVC4ServicesBook.Data.Model
{
    public class User
    {
        public virtual Guid UserId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }
        public virtual byte[] Version { get; set; }

    }
}
