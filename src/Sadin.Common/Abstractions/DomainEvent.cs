namespace Sadin.Cms.Domain.Events;

public abstract record DomainEvent(Guid Id, DateTimeOffset OccurredOn) : IDomainEvent;