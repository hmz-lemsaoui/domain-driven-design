using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Users;

namespace Application.Followers.StartFollowing;

internal sealed class StartFollowingCommandHandler : ICommandHandler<StartFollowingCommand>
{

    /*private readonly IUserRepository _userRepository;
    private readonly IFollowerService _followerService;
    private readonly IUnitOfWork _unitOfWork;

    public StartFollowingCommandHandler(IUserRepository userRepository,
            IFollowerService followerService, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _followerService = followerService;
        _unitOfWork = unitOfWork;
    }*/
}
