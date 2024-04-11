using Decorator;

internal class Program
{
    static void Main(string[] args)
    {
        // Crear una notificación básica
        INotification notification = new BasicNotification();

        // Decorar la notificación básica con funcionalidad de email
        notification = new EmailNotificationDecorator(notification);

        // Decorar la notificación (ahora con email) con registro en log
        notification = new LogNotificationDecorator(notification);

        // Enviar notificación
        notification.Send("Hola mundo de las notificaciones!");

        // Salida esperada:
        // Registrando notificación en log: Hola mundo de las notificaciones!
        // Notificación básica: Hola mundo de las notificaciones!
        // Enviando notificación por email: Hola mundo de las notificaciones!
    }
}