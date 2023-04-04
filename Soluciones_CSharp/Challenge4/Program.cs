/*
 * Reto #4
 * ÁREA DE UN POLÍGONO
 * Fecha publicación enunciado: 24/01/22
 * Fecha publicación resolución: 31/01/22
 * Dificultad: FÁCIL
 *
 * Enunciado: Crea UNA ÚNICA FUNCIÓN (importante que sólo sea una) que sea capaz de calcular y retornar el área de un polígono.
 * - La función recibirá por parámetro sólo UN polígono a la vez.
 * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
 * - Imprime el cálculo del área de un polígono de cada tipo.
 *
 * Información adicional:
 * - Usa el canal de nuestro discord (https://mouredev.com/discord) "🔁reto-semanal" para preguntas, dudas o prestar ayuda a la acomunidad.
 * - Puedes hacer un Fork del repo y una Pull Request al repo original para que veamos tu solución aportada.
 * - Revisaré el ejercicio en directo desde Twitch el lunes siguiente al de su publicación.
 * - Subiré una posible solución al ejercicio el lunes siguiente al de su publicación.
 *
 */

using System;
using System.Diagnostics;

namespace Hyperion
{
    public abstract class Polygon
    {
        int height;
        int lenght;
        
        public abstract int Area();
    
       
        public int Height {
            get {
                return height;
            }
            set {
                this.height = value;
            }
        }
        public int Lenght {
            get {
                return lenght;
            }
            set {
                this.lenght = value;
            }
        }
    }

    public class Triangulo : Polygon
    {
        public Triangulo(int height, int lenght)
        {
            this.Height = height;
            this.Lenght = lenght;
        }
        
        public override int Area()
        {
            return this.Height * this.Lenght / 2; 
            
        }
    }
    public class Cuadrado : Polygon
    {
        public Cuadrado(int height, int lenght)
        {
            this.Height = height;
            this.Lenght = lenght;
        }
        public override int Area()
        {
            return this.Height * this.Lenght;
        }
    }
    public class Rectangulo : Polygon
    {
        public Rectangulo(int height, int lenght)
        {
            this.Height = height;
            this.Lenght = lenght;
        }
        public override int Area()
        {
            return this.Height * this.Lenght;
        }
    }

    
    class O
    {
        public static int area(Polygon P) {
            return P.Area();
        }
        static void Main()
        {
            Triangulo t1 = new Triangulo(2,3);
            Console.WriteLine(t1.Area());
            Console.WriteLine(area(t1));
        }
    }
}