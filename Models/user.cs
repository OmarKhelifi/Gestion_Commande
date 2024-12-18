using System;

namespace GestionCommandeApp
{
    public class User
    {
        public int ID { get; set; }           // Primary Key
        public string Username { get; set; }  // User's Username
        public string Password { get; set; }  // User's Password (hashed or plain text)
        public string Role { get; set; }      // User's Role (e.g., Admin, User, etc.)

        // Constructor
        public User(int id, string username, string password, string role)
        {
            ID = id;
            Username = username;
            Password = password;
            Role = role;
        }

        // Default constructor
        public User() { }
    }
}
