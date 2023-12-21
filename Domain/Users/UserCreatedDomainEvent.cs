using SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users;

internal sealed record UserCreatedDomainEvent(Guid userId) : IDomainEvent;

