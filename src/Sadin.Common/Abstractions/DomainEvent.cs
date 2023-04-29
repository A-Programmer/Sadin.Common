namespace Sadin.Common.Abstractions;

public abstract record DomainEvent(Guid Id, DateTimeOffset OccurredOn) : IDomainEvent;