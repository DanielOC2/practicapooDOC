using System;

namespace practicapooDOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            persona daniel = new persona();
            daniel.Nombre = "Daniel";
            daniel.Edad = 19;
            daniel.Documento = "1001686125";

            Console.WriteLine("el nombre de la persona es:" + daniel.Nombre + " su edad es " + daniel.Edad + " su documento es: " + daniel.Documento);
            Console.ReadLine();

            persona picaso = new() {

                Nombre = "Picaso",
                Edad = 16,
                Documento = "10951395"
                
            
            };

            animal leon = new() { 
            
                Nombre = "leon",
                tipoAlimentacion = "carnivoro",
                Habitad = "Sabana"
            
            
            };
        }
    }
}
