using MediatR;

namespace HT.Core.Events;

public interface IDomainEventHandler<in TEvent>
    : INotificationHandler<TEvent>
        where TEvent : IDomainEvent
{
}