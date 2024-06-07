using MediatR;

namespace LH.Core.Events;

public interface IDomainEventHandler<in TEvent>
    : INotificationHandler<TEvent>
        where TEvent : IDomainEvent
{
}