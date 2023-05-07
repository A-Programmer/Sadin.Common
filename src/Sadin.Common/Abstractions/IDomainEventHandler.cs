namespace Sadin.Common.Abstractions;

public interface IDomainEventHandler<in T> : INotificationHandler<T>
    where T : DomainEvent
{

}
