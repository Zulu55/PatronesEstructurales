namespace Decorator
{
    public class LogNotificationDecorator : NotificationDecorator
    {
        public LogNotificationDecorator(INotification notification) : base(notification)
        {
        }

        public override void Send(string message)
        {
            // Lógica adicional para registrar en log
            Console.WriteLine($"Registrando notificación en log: {message}");
            base.Send(message);
        }
    }
}