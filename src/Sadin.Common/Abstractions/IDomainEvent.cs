namespace Sadin.Common.Abstractions;

public interface IDomainEvent : INotification
{
    DateTimeOffset OccurredOn { get; }
}