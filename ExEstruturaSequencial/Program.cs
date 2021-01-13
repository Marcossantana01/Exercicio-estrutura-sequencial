using System;
using System.Globalization;

namespace ExEstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2,soma = 0;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("SOMA"+"="+soma);

            Console.WriteLine("-------------------------------------");

            double raio,area = 0;

            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            area = Math.Pow(raio, 2) * 3.14159;

            Console.WriteLine(area.ToString("F4",CultureInfo.InvariantCulture));

            Console.WriteLine("----------------------------------------");

            int a, b, c, d, res;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            res = a * b - c * d;

            Console.WriteLine(res);

            Console.WriteLine("-----------------------------------------");

            int numero;
            double salario,valorhora, horas;

            numero = int.Parse(Console.ReadLine());
            horas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            valorhora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            salario = horas * valorhora;

            Console.WriteLine("NUMBER = " + numero.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("--------------------------------------------------------------");

            int cod1, cod2, qte1, qte2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);


            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);



            total = preco1 * qte1 + preco2 * qte2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));





        }
    }
}
