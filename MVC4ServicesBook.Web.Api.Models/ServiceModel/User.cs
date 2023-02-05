﻿namespace MVC4ServicesBook.Web.Api.Models.ServiceModel
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Link> Links { get; set; }
    }
}