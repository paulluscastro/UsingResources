using System;
using System.Globalization;
using System.Threading;
using UsingResources.Resources.Resources;

namespace UsingResources.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*                        Exemplo de uso de repositories                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("Configurando idioma da thread para PORTUGUÊS BRASIL, que foi o idioma que eu usei no resource padrão...");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");
            Console.WriteLine("Mostrando o conteúdo dos Resources...");
            Console.WriteLine($"ACCOUNT_IS_UNREGISTERED = {ErrorMessages.ACCOUNT_IS_UNREGISTERED}");
            Console.WriteLine($"CANNOT_ADD_GIFT_CARD = {ErrorMessages.CANNOT_ADD_GIFT_CARD}");
            Console.WriteLine($"MAXIMUM_SPEND_LIMIT_IS_OVER = {ErrorMessages.MAXIMUM_SPEND_LIMIT_IS_OVER}");
            Console.WriteLine($"REPLACEMENT_DEVICE_DOES_NOT_ALLOW_SPEND = {ErrorMessages.REPLACEMENT_DEVICE_DOES_NOT_ALLOW_SPEND}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Configurando idioma da thread para INGLÊS...");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Console.WriteLine("Mostrando o conteúdo dos Resources...");
            Console.WriteLine($"ACCOUNT_IS_UNREGISTERED = {ErrorMessages.ACCOUNT_IS_UNREGISTERED}");
            Console.WriteLine($"CANNOT_ADD_GIFT_CARD = {ErrorMessages.CANNOT_ADD_GIFT_CARD}");
            Console.WriteLine($"MAXIMUM_SPEND_LIMIT_IS_OVER = {ErrorMessages.MAXIMUM_SPEND_LIMIT_IS_OVER}");
            Console.WriteLine($"REPLACEMENT_DEVICE_DOES_NOT_ALLOW_SPEND = {ErrorMessages.REPLACEMENT_DEVICE_DOES_NOT_ALLOW_SPEND}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Configurando idioma da thread para FRANCÊS, que é um idioma para o qual eu não criei um resource...");
            Console.WriteLine("Nesse caso os valores deverão aparecer conforme especificado no Resource padrão.");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
            Console.WriteLine("Mostrando o conteúdo dos Resources...");
            Console.WriteLine($"ACCOUNT_IS_UNREGISTERED = {ErrorMessages.ACCOUNT_IS_UNREGISTERED}");
            Console.WriteLine($"CANNOT_ADD_GIFT_CARD = {ErrorMessages.CANNOT_ADD_GIFT_CARD}");
            Console.WriteLine($"MAXIMUM_SPEND_LIMIT_IS_OVER = {ErrorMessages.MAXIMUM_SPEND_LIMIT_IS_OVER}");
            Console.WriteLine($"REPLACEMENT_DEVICE_DOES_NOT_ALLOW_SPEND = {ErrorMessages.REPLACEMENT_DEVICE_DOES_NOT_ALLOW_SPEND}");
            Console.ReadKey();
        }
    }
}
