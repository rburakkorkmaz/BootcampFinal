﻿namespace EntityLayer.Concrete.PetVM
{
    public class PetUserGetDTO
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public string? Address { get; set; }

        public int PetsFound { get; set; }

    }
}
