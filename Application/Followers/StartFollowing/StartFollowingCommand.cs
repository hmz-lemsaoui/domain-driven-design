using Application.Abstractions.Messaging;

namespace Application.Followers.StartFollowing;

internal sealed record StartFollowingCommand(Guid UserId, Guid FollowerId) : ICommand;
