using System;
using TwitterUCU;
using WhatsAppApiUCU;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("Vamo a Programar", @"..\..\..\programacion-2-e1551291144973.jpg"));

            var whatsApp = new WhatsAppApi();
            whatsApp.Send("+59894409040", "Hey! I'm using WhatsApp");

            // Crear el contacto dueño

            // Crear la lista de contactos

            // Agregar contactos a la lista

            // Envia    r un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos
        }
    }
}
