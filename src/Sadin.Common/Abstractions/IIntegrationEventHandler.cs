namespace Sadin.Common.Abstractions;

public interface IIntegrationEventHandler<in T> : INotificationHandler<T>
    where T : IntegrationEvent
{

}
