using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace shapes
{
    class Shapes
    {
        public int Height;//высота треугольника
        public int Wight;//основание треугольника
        public void ShowTr()
        {
            Console.WriteLine("Основание и высота треугольника равны " + Height + " " +Wight);
        }
  
        public int a;//сторона квадрата
        public void ShowSq()
        {
            Console.WriteLine("Сторона треугольника ранва " + a);
        }
        public int x;//координата абсцисс для центра
        public int y;//координата ординат для центра
        public int r;//радиус окружности
        public void ShowCir()
        {
            Console.WriteLine("Центр окружности " + "( " + x + "," + y + " )" + "  и его радиус " + r);
        }
    }

    class ShapesDemo : Shapes
    {
        static void Main()
        {
            ShapesDemo i1 = new ShapesDemo();//экземпляр для треугольника
            ShapesDemo i2 = new ShapesDemo();//экземпляр для квадрата
            ShapesDemo i3 = new ShapesDemo();//экземпляр для окружности
            i1.Height = 3;//какэтим экземплярам не присваивать значения тут, а считать эти значения из файла?
            i1.Wight = 5;
            i1.ShowTr();
            i2.a = 111;
            i2.ShowSq();
            i3.x = 3;
            i3.y = 5;
            i3.r = 5;
            i3.ShowCir();

        }
    }
}
