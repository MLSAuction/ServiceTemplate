﻿namespace UserService.Models
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Username { get; set}
        public string Password { get; set}
        public string FirstName { get; set}
        public string LastName { get; set}
        public int Phone { get; set }
        public string Email { get; set}
        public string Adress { get; set}
    }

    public UserDTO()
    {

    }

}
