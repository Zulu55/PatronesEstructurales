namespace Decorator
{
    public abstract class NotificationDecorator : INotification
    {
        protected INotification _wrappedNotification;

        public NotificationDecorator(INotification notification)
        {
            _wrappedNotification = notification;
        }

        public virtual void Send(string message)
        {
            _wrappedNotification.Send(message);
        }
    }
}