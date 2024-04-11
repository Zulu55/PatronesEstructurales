namespace Decorator
{
    public class BasicNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Notificación básica: {message}");
        }
    }
}