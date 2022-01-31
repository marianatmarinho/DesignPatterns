using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Example
{
    public class VideoMP4 : VideoPlayer
    {
        public override void DecodeVideoFormato()
        {
            Console.WriteLine("O video está sendo convertido para MP4.");
        }
    }
}
