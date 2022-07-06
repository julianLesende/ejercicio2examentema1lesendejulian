using System;

namespace ejercicio2examentema1lesendejulian
{
    class Program
    {
		static void Main(string[] args)
		{
			double area;
			double ladoa;
			double ladob;
			double ladoc;
			double p;
			double perimetro;
			
			Console.Write("ingrese el ladoA,LadoB,LadoC");
			ladoa = Double.Parse(Console.ReadLine());
			ladob = Double.Parse(Console.ReadLine());
			ladoc = Double.Parse(Console.ReadLine());
			perimetro = ladoa + ladob + ladoc;
			p = perimetro / 2;
			area = Math.Sqrt(p * (p - ladoa) * (p - ladob) * (p - ladoc));
			if (ladoa * ladoa == ladob * ladob + ladoc * ladoc)
			{
				Console.Write("Se forma un triángulo rectángulo: " + "el area es: " + area + "el perimetro es: " + perimetro + "el semiperimetro es: " + p);
			}
			else
			{
				if (ladoa * ladoa > ladob * ladob + ladoc * ladoc)
				{
					Console.Write("Se forma un triángulo obtusángulo: " + "el area es: " + area + "el perimetro es: " + perimetro + "el semiperimetro es: " + p);
				}
				else
				{
					if (ladoa * ladoa < ladob * ladob + ladoc * ladoc)
					{
						Console.Write("Se forma un triángulo acutángulo: " + "el area es " + area + "el perimetro es: " + perimetro + "el semiperimetro es: " + p);
					}
					else
					{
						Console.WriteLine("ingrese datos validos");
					}
				}
			}
		}

	}

}
 
