using System;

namespace Checkout.Entities {
    class Customer {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Customer(string name, string email, DateTime birthDate) {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString() {
            return Name
                + " "
                + Email
                + " "
                + BirthDate.ToString("d");
        }
    }
}
