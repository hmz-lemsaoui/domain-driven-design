namespace Application.Abstractions.Messaging;

internal interface ICommandHandler
{
}

internal interface ICommandHandler<TResponse>
{
}

internal interface ICommandHandler<TResponse, TRequset>
{
}
