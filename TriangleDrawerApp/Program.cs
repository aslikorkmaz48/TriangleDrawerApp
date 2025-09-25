using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDrawerApp
{
namespace TriangleDrawerApp
    {
        // Üçgen çizmeyi sağlayan sınıf
        public class TriangleDrawer
        {
            public void DrawTriangle(int size)
            {
                for (int i = 1; i <= size; i++)
                {
                    string spaces = new string(' ', size - i);
                    string stars = new string('*', 2 * i - 1);
                    Console.WriteLine(spaces + stars);
                }
            }
        }

        // Kullanıcıdan veri almakla sorumlu sınıf
        public class InputReader
        {
            public int ReadSize()
            {
                int size;
                Console.Write("Üçgenin boyutunu giriniz: ");
                while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
                {
                    Console.Write("Lütfen pozitif bir sayı giriniz: ");
                }
                return size;
            }
        }

        // Uygulamanın çalışmasını yöneten sınıf
        public class Application
        {
            private readonly InputReader _inputReader;
            private readonly TriangleDrawer _triangleDrawer;

            public Application()
            {
                _inputReader = new InputReader();
                _triangleDrawer = new TriangleDrawer();
            }

            public void Run()
            {
                int size = _inputReader.ReadSize();
                _triangleDrawer.DrawTriangle(size);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                var app = new Application();
                app.Run();
            }
        }
    }

}
   
