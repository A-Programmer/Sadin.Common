﻿namespace Sadin.Common.ApplicationCommon.Commands;

public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result>
    where TCommand : ICommand
{
}
public interface ICommandHandler<in TCommand, TResponse> :
    IRequestHandler<TCommand, Result<TResponse>>
    where TCommand : ICommand<TResponse>
{
}
