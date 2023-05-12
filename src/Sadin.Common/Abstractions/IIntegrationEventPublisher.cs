namespace Sadin.Common.Abstractions;

public interface IIntegrationEventPublisher
{
    void Publish(IntegrationEvent integrationEvent);
}