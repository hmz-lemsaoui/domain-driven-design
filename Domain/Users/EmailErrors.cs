using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users;

internal static class EmailErrors
{
    public static readonly Error Empty = new("Email.Empty", "Email is empty");
    public static readonly Error InvalidFormat = new("Email.InvalidFormat", "Email format is invalid");
}
