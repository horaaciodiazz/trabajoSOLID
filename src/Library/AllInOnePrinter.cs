using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    // Se aplica el Principio de Abierto/Cerrado (OCP) porque
    // podemos agregar nuevos tipos de impresoras sin modificar el código existente.
    public interface IPrinter
    {
        void Print(string text);
    }
    
    // Cada clase tiene una sola responsabilidad.
    // Esto cumple con el Principio de Responsabilidad Única (SRP).
    public class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }

    // También cumple con SRP: solo se encarga de imprimir en archivo.
    public class FilePrinter : IPrinter
    {
        public void Print(string text)
        {
            File.WriteAllText("Recipe.txt", text);
        }
    }
}