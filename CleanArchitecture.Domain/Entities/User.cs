using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class User : BaseEntity
    {
        public string? Email { get; private set; }

        public string? Name { get; private set; }

        public User(string email, string name)
        {
            Email = email;
            Name = name;
        }

    }
}
