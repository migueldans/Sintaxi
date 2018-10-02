using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hola seguido de tu nombre

            Console.WriteLine("Hola Miguel");


            //Suma de dos números

            Console.WriteLine(2 + 3);

            //división de dos números

            Console.WriteLine(2 / 1);

            //muestre el resultado de los siguiente

            Console.WriteLine(-5 + 8 * 6);
            Console.WriteLine((55 + 9) % 9);
            Console.WriteLine(20 + -3 + 5 / 8);
            Console.WriteLine(5 + 15 / 3 + 2 - 8 % 3);

            //pide dos numeros al usuario y muestre el resultado de multiplicar los dos
            //conversion int, de numero a texto

            Console.WriteLine("introduzca un numero");
            int num1, num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduzca otro numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("la multiplicacion entre " + num1 + " y " + num2 + " es: " + (num1 * num2));

            //pide dos numeros al usuario y muestre el resultado de sumarlo, multiplicarlos, restarlos, dividirlos yel resto de la division
            //si queremos decimales tendremos que cambiar double por int al principio y tambien su conversion
            //pero si queremos solo el resultado sea decimales hacer double en el int y no en la convert
            Console.WriteLine("introduzca un numero");
            int num3, num4;
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduzca otro numero");
            num4 = Convert.ToInt32(Console.ReadLine());
            double resultado = num3 / num4;
            double resto = num3 % num4;
            Console.WriteLine("la suma entre " + num3 + " y " + num4 + " es: " + (num3 + num4));
            Console.WriteLine("la multiplicación entre " + num3 + " y " + num4 + " es: " + (num3 * num4));
            Console.WriteLine("la resta entre " + num3 + " y " + num4 + " es: " + (num3 - num4));
            Console.WriteLine("la division entre " + num3 + " y " + num4 + " es: " + resultado);
            Console.WriteLine("el modulo " + num3 + " y " + num4 + " es: " + resto);

            //pide un numero al usuario y muestre la tabl de multiplicar hasta 10 de ese numero

            Console.WriteLine("Introduzca un numero");
            int num5;
            num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(+num5 + "x1=" + num5 * 1);
            Console.WriteLine(+num5 + "x2=" + num5 * 2);
            Console.WriteLine(+num5 + "x3=" + num5 * 3);
            Console.WriteLine(+num5 + "x4=" + num5 * 4);
            Console.WriteLine(+num5 + "x5=" + num5 * 5);
            Console.WriteLine(+num5 + "x6=" + num5 * 6);
            Console.WriteLine(+num5 + "x7=" + num5 * 7);
            Console.WriteLine(+num5 + "x8=" + num5 * 8);
            Console.WriteLine(+num5 + "x9=" + num5 * 9);
            Console.WriteLine(+num5 + "x10=" + num5 * 10);

            //Calcula el resultado de esta operacion

            Console.WriteLine((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));

            //Calcula el resultado de esta operación

            Console.WriteLine(4.0 * (1 - (1.0 / 3) + (1.0 / 5) - (1.0 / 7) + (1.0 / 9) - (1.0 / 11)));

            //Pedir radio de un circulo y calcular y mostrar el area y perimetro
            //area=pir2 perimetro=2rpi

            Console.WriteLine("Introduzca Radio de un circulo");
            int num6;
            num6 = Convert.ToInt32(Console.ReadLine());
            const double PI = 3.141593;
            Console.WriteLine("Area del circulo " + (PI * Math.Sqrt(num6)));
            Console.WriteLine("Perimetro del circulo " + (2 * PI * num6));

            //Pedir 3 numeros y calcular y mostrar su media

            Console.WriteLine("Introduza 3 números");
            int num7, num8, num9;
            num7 = Convert.ToInt32(Console.ReadLine());
            num8 = Convert.ToInt32(Console.ReadLine());
            num9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La media de los tres numero es " + ((num7 + num8 + num9) / 3));

            //Pedir anchura y altura de un rectangulo y calcular y mostrar el area y su perimetro
            //Area=a*l perimetro=2*(a+l)

            Console.WriteLine("Introduzca anchura y altura de un rectangulo");
            int num10, num11;
            num10 = Convert.ToInt32(Console.ReadLine());
            num11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El area del rectangulo es " + (num10 * num11));
            Console.WriteLine("El Perimetro es " + (2 * (num10 + num11)));

            //Pedir dos variables y despues intercambiar sus valores
            //a=8 y b=5 => a=5 y b=8

            Console.WriteLine("Introducir un numero");
            int num12, num13, num14;
            num12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introducir otro numero");
            num13 = Convert.ToInt32(Console.ReadLine());

            num14 = num12;
            num12 = num13;
            num13 = num14;

            Console.WriteLine("El primer numero es " + num12 + " y el segundo es " + num13);


            //Pedir nu numero de 3 digitos y mostrar la suma de los 3 numeros

            Console.WriteLine("Introducir un numero de 3 digitos");
            int numa;
            numa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("uno " + (numa / 100) + " dos " + ((numa % 100) / 10) + " tres " + (numa % 10) + " sumado todo " + ((numa / 100) + ((numa % 100) / 10) + (numa % 10)));

            Pedir al usuario un digito(n) y calcular y mostrar el valor de n+nn + nnn

            Console.WriteLine("Dame un numero");
            int n, nn, nnn;
            n = Convert.ToInt32(Console.ReadLine());
            nn = ((n * 10) + n);
            nnn = ((n * 100) + (n * 10) + n);
            Console.WriteLine(n + nn + nnn);

            //Pedir numero convertir string a int y mostrar en pantalla
            Console.WriteLine("Escribe un número");
            int numero;
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Calcular el resto de dividir dos numeros sin utilizar el operador de division de resto(%)

            Console.WriteLine("escribir numero");
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a / b;
            Console.WriteLine(a / (b + c));

            //pedir numero en pulgadas y transformarlo en metros
            // pulgada=0.0254 metros

            Console.WriteLine("escribir numero");
            int pulgada;
            pulgada = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pulgada * 0.0254 + " metros");

            //Pedir numero de minutos y mostrar cuantos años y dias son


            Console.WriteLine("Dame muchos minutos que te digo cuantos años y dias son, majo");
            int minutos, dias, años;
            minutos = Convert.ToInt32(Console.ReadLine());
            años = (minutos / 525600);
            dias = (minutos / 1440);
            Console.WriteLine(años + " años y " + (dias % 365) + " dias");

            //Pedir distancia en metros y tiempo tardado en tres numeros (horas, minutos y segundos)
            //mostrar velocidad en metros, segundos y kilometros
            Console.WriteLine("Dame distancia en metros y el tiempo tardado en tres numeros hora,minutos y segundos");
            int meters, hours, minutes, seconds, ms, kmh;
            Console.WriteLine("Escribe distancia en metros");
            meters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe distancia en horas");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe distancia en minutos");
            minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe distancia en segundos");
            seconds = Convert.ToInt32(Console.ReadLine());
            ms = meters / ((hours * 3600) + (minutes * 60) + (seconds));
            kmh = (meters / 1000) / (hours + (minutes / 60) + (3600 / seconds));
            Console.WriteLine(ms + " m/s y " + kmh + " km/h");

            Genera un numero aleatorio entre el 1 y el 100
            Hay que usar una función

            Console.WriteLine("Generar un numero aleatorio entre 1 y 100");
            Random aleatorio = new Random();
            int alet;
            alet=aleatorio.Next(1,100);
            Console.Write(alet);



            Console.ReadLine();

        }
    }
}
