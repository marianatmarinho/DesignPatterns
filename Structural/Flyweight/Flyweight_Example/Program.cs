using System;

namespace Flyweight_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n### Círculos Amarelos");
            for(int i = 0; i<3;i++)
            {
                var cicle = (Cicle)ShapeFactory.GetShape("circulo");
                cicle.SetColor("Amarelo");
                cicle.Draw();
            }

            Console.WriteLine("\n### Círculos Verdes");
            for (int i = 0; i < 3; i++)
            {
                var cicle = (Cicle)ShapeFactory.GetShape("circulo");
                cicle.SetColor("Verde");
                cicle.Draw();
            }

            Console.WriteLine("\n### Círculos Azuis");
            for (int i = 0; i < 3; i++)
            {
                var cicle = (Cicle)ShapeFactory.GetShape("circulo");
                cicle.SetColor("Azul");
                cicle.Draw();
            }

            Console.WriteLine("\n### Círculos Vermelhos");
            for (int i = 0; i < 3; i++)
            {
                var cicle = (Cicle)ShapeFactory.GetShape("circulo");
                cicle.SetColor("Vermelho");
                cicle.Draw();
            }

            Console.WriteLine("\n### Círculos Pretos");
            for (int i = 0; i < 3; i++)
            {
                var cicle = (Cicle)ShapeFactory.GetShape("circulo");
                cicle.SetColor("Preto");
                cicle.Draw();
            }
        }
    }
}
