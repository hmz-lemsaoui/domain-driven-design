namespace Application.Abstractions.Messaging;

internal interface ICommand : IBaseCommand
{
}

internal interface IBaseCommand
{
}

internal interface ICommand<TResponse> : IBaseCommand
{
}