using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Example
{
    public class Cicle : IShape
    {
        //estado extrinseco
        public string Color { get; set; }

        //estado intrinseco
        private int x = 10;
        private int y = 20;
        private int radius = 30;

        public void SetColor(string color)
        {
            this.Color = color;
        }
        public void Draw()
        {
            Console.WriteLine($"Circulo: Desenhar() [Cor:{Color} x:{x}, y:{y}, raio: {radius}]");
        }
    }
}
