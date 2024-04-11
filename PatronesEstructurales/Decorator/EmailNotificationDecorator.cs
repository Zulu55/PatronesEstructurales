namespace Decorator
{
    public class EmailNotificationDecorator : NotificationDecorator
    {
        public EmailNotificationDecorator(INotification notification) : base(notification)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            // Lógica adicional para enviar email
            Console.WriteLine($"Enviando notificación por email: {message}");
        }
    }
}