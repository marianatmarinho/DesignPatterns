using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Example
{
    public class ShapeFactory
    {
        private static Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public static IShape GetShape(string key)
        {
            IShape shape;

            if(shapes.ContainsKey(key))
            {
                return shapes[key];
            }
            else
            {
                if(key == "circulo")
                {
                    shape = new Cicle();
                    shapes.Add("circulo", shape);
                }
                else
                {
                    throw new Exception("Esse tipo de objeto não pode ser criado");
                }
            }
            return shape;
        }
    }
}
