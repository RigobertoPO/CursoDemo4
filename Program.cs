using System;

namespace CursoDemo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Alumno alu=new Alumno();
            alu.Id =1;
            alu.SetNombre("Juan");
            Console.WriteLine(alu.Id);
            Console.WriteLine(alu.GetNombre());
        }
    }
}
