using Domain.Users;
using SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Users;

public class User : Entity
{
    public Email Email { get; set; }
    public Name Name { get; set; }
    public bool HasPublicProfile { get; set; }

    private User(Guid id, Email email, Name name, bool hasPublicProfile)
        : base(id)
    {
        Email = email;
        Name = name;
        HasPublicProfile = hasPublicProfile;
    }

    private User()
    {

    }

    public static User Create(Email email, Name name, bool hasPublicProfile)
    {
        var user = new User(Guid.NewGuid(), email, name, hasPublicProfile);

    }
}
