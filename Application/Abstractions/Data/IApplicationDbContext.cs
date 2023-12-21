using Application.Users;
using Microsoft.EntityFrameworkCore;

namespace Application.Abstractions.Data;

internal interface IApplicationDbContext
{
    DbSet<User> Users { get; set; }
}
