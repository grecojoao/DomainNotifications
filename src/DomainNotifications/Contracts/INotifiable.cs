using DomainNotifications.Entities;
using System.Collections.Generic;

namespace DomainNotifications.Contracts
{
    internal interface INotifiable
    {
        IReadOnlyCollection<Notification> Notifications { get; }
        bool IsInvalid { get; }
        bool IsValid { get; }
        string NotificationsMessage();
    }
}