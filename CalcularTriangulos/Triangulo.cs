using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalcularTriangulos
{
    internal class Triangulo
    {

        public void calcular()
        {
            //Diseñar un algoritmo que:

            //Solicite al usuario ingresar un número entero "n" que represente la cantidad de triángulos a procesar. listo
            //Para cada triángulo, capture los valores de la base y la altura. listo
            //Calcule el área de cada triángulo utilizando la fórmula correspondiente. listo
            //Muestre en pantalla los datos de cada triángulo(base, altura y área). listo
            //Determine y reporte la cantidad de triángulos con un área superior a 12 unidades cuadradas.

            const int unidadesCuadradasParaAprobar = 12;
            int cantidadDeTriangulos = 0;
            int Base = 0;
            int altura = 0;
            int areaDeTriangulo = 0;
            int cantidadDeTriangulosMayorQue12 = 0;
            int vueltasBucle = 0;
            string valorIngresadoPorConsola = string.Empty;

            try
            {
                //Solicitamos la cantidad de triangulos a ingresar y validamos que nos nos manden datos vacios o letras
                while (true)
                {
                    Console.WriteLine("Ingrese la cantidad de Triangulos Que debe Ingresar");
                    valorIngresadoPorConsola = Console.ReadLine();
                    if (string.IsNullOrEmpty(valorIngresadoPorConsola))
                    {
                        Console.WriteLine("No puede dejar datos vacios");
                        continue;
                    }
                    if (int.TryParse(valorIngresadoPorConsola, out cantidadDeTriangulos))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Solo se admiten numeros");
                        continue;
                    }
                }

                //Para cada triángulo, capture los valores de la base y la altura.
                while (true)
                {
                    //Solicitamos la Base del triangulo
                    Console.WriteLine($"Ingrese los valores de la base y la altura del triangulo #{vueltasBucle}");
                    Console.WriteLine("Base:");
                    valorIngresadoPorConsola = Console.ReadLine();
                    if (string.IsNullOrEmpty(valorIngresadoPorConsola))
                    {
                        Console.WriteLine("No se permiten Datos Vacios");
                        continue;
                    }
                    if (int.TryParse(valorIngresadoPorConsola, out Base))
                    {
                        Console.WriteLine("Valor agregado con Exito");
                    }
                    else
                    {
                        Console.WriteLine("Solo se admiten numeros en la base del triangulo");
                        continue;
                    }
                    //Solicitamos la altura del Triangulo
                    Console.WriteLine("Altura:");
                    valorIngresadoPorConsola = Console.ReadLine();
                    if (string.IsNullOrEmpty(valorIngresadoPorConsola))
                    {
                        Console.WriteLine("No se permiten Datos Vacios");
                        continue;
                    }
                    if (int.TryParse(valorIngresadoPorConsola, out altura))
                    {
                        Console.WriteLine("Valor agregado con Exito");
                    }
                    else
                    {
                        Console.WriteLine("Solo se admiten numeros en la altura del triangulo");
                        continue;
                    }

                    //Calculamos el area del triangulo
                    areaDeTriangulo = (Base * altura / 2);

                    //agregamos triangulos aprovados
                    if (areaDeTriangulo >= unidadesCuadradasParaAprobar)
                    {
                        cantidadDeTriangulosMayorQue12++;
                    }

                    Console.WriteLine($"La altura del triangulo es de: {altura}\n" +
                                      $"La base del triangulo es de: {Base}\n" +
                                      $"el Area de este triangulo es de: {areaDeTriangulo}");





                    vueltasBucle++;
                    if (cantidadDeTriangulos == vueltasBucle)
                    {
                        vueltasBucle = 0;
                        break;
                    }
                }
                Console.WriteLine($"Cantidad de triangulos aprobados (su area es mayor a 12): {cantidadDeTriangulosMayorQue12}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }
    }
}
