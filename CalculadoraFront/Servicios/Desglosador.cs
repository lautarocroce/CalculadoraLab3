using CalculadoraFront.Servicios.CalculadoraEjercicio.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFront.Servicios
{
    internal class Desglosador
    {
        public String[] Desglosar(String ecuacion)
        {
            Operador operador = new Operador();
            int conteo = ecuacion.Count(c => c == '(');
            String ecuacionAux;
            String ecuacionPorcion;
            String ecuacionPorcionAux;
            String[] resultado = new String[2];

            Console.WriteLine($"Ecuación a resolver: {ecuacion}");
            int paso = 0;
            resultado[1] = $"{ecuacion}\n";
            for (int i = 0; i <= conteo; i++)
            {
                if (ecuacion.Contains('('))
                {
                    ecuacionAux = ecuacion.Substring(0, ecuacion.IndexOf(')'));
                    ecuacionPorcion = ecuacionAux.Substring(ecuacionAux.LastIndexOf('(') + 1);
                    ecuacionPorcionAux = ecuacionPorcion;
                    resultado[0] = ecuacionPorcion;
                }
                else
                {
                    ecuacionAux = ecuacion;
                    ecuacionPorcion = ecuacionAux;
                    ecuacionPorcionAux = ecuacionPorcion;
                    resultado[0] = ecuacionPorcion;
                }

                if (ecuacionPorcion.Contains('/'))
                {
                    String division = operador.Dividir(ecuacionPorcion);
                    ecuacionPorcion = division;
                    if (ecuacion.Contains('('))
                    {
                        paso++;
                        Console.WriteLine(ecuacion.Replace($"({resultado[0]})", $"Paso {paso}: {ecuacionPorcion}\n"));
                        resultado[1] += ($"Paso {paso}:" + ecuacion.Replace($"({ecuacionPorcion})", $"{resultado[0]}") + "\n");
                        Console.WriteLine($"Ecuacion: {ecuacion}");
                        Console.WriteLine($"Resultado[0]: {resultado[0]}");
                        Console.WriteLine($"Paso {paso}: {ecuacionPorcion}\n");


                    }
                    else
                    {
                        paso++;
                        Console.WriteLine(ecuacion.Replace($"{resultado[0]}", $"Paso {paso}: {ecuacionPorcion}"));
                        resultado[1] += ecuacion.Replace($"{resultado[0]}", $"Paso {paso}: {ecuacionPorcion}\n");
                    }
                }
                if (ecuacionPorcion.Contains('*'))
                {
                    String multiplicacion = operador.Multiplicar(ecuacionPorcion);
                    ecuacionPorcion = multiplicacion;
                    if (ecuacion.Contains('('))
                    {
                        paso++;
                        Console.WriteLine(ecuacion.Replace($"({resultado[0]})", $"Paso {paso}: {ecuacionPorcion}\n"));
                        resultado[1] += ($"Paso {paso}:" + ecuacion.Replace($"({ecuacionPorcion})", $"{resultado[0]}") + "\n");
                        Console.WriteLine($"Ecuacion: {ecuacion}");
                        Console.WriteLine($"Resultado[0]: {resultado[0]}");
                        Console.WriteLine($"Paso {paso}: {ecuacionPorcion}\n");
                    }
                    else
                    {
                        paso++;
                        Console.WriteLine(ecuacion.Replace($"{resultado[0]}", $"Paso {paso}: {ecuacionPorcion}"));
                        resultado[1] += ecuacion.Replace($"{resultado[0]}", $"Paso {paso}: {ecuacionPorcion}\n");
                    }
                }
                if (ecuacionPorcion.Contains('-'))
                {
                    String resta = operador.Restar(ecuacionPorcion);
                    ecuacionPorcion = resta;
                    if (ecuacion.Contains('('))
                    {
                        paso++;
                        Console.WriteLine(ecuacion.Replace($"({resultado[0]})", $"Paso {paso}: {ecuacionPorcion}\n"));
                        resultado[1] += ($"Paso {paso}:" + ecuacion.Replace($"({ecuacionPorcion})", $"{resultado[0]}") + "\n");
                        Console.WriteLine($"Ecuacion: {ecuacion}");
                        Console.WriteLine($"Resultado[0]: {resultado[0]}");
                        Console.WriteLine($"Paso {paso}: {ecuacionPorcion}\n");
                    }
                    else
                    {
                        paso++;
                        Console.WriteLine(ecuacion.Replace($"{resultado[0]}", $"Paso {paso}: {ecuacionPorcion}"));
                        resultado[1] += ecuacion.Replace($"{resultado[0]}", $"Paso {paso}: {ecuacionPorcion}\n");
                    }
                }
                if (ecuacionPorcion.Contains('+'))
                {
                    String suma = operador.Sumar(ecuacionPorcion);
                    ecuacionPorcion = suma;
                    if (ecuacion.Contains('('))
                    {
                        paso++;
                        Console.WriteLine(ecuacion.Replace($"({resultado[0]})", $"Paso {paso}: {ecuacionPorcion}\n"));
                        resultado[1] += ($"Paso {paso}:" + ecuacion.Replace($"({ecuacionPorcion})", $"{resultado[0]}")+"\n");
                    }
                    else
                    {
                        paso++;
                        Console.WriteLine(ecuacion.Replace($"{resultado[0]}", $"Paso {paso}: {ecuacionPorcion}"));
                        resultado[1] += ecuacion.Replace($"{resultado[0]}", $"Paso {paso}: {ecuacionPorcion}\n");
                    }
                }
                if (ecuacion.Contains('('))
                {
                    ecuacion = ecuacion.Replace($"({resultado[0]})", ecuacionPorcion);
                    //resultado[1] += $"Paso {paso}: {ecuacionPorcion}\n";
                }
                else
                {
                    ecuacion = ecuacion.Replace($"{resultado[0]}", ecuacionPorcion);
                    //resultado[1] += $"Paso {paso}: {ecuacionPorcion}\n";
                }
            }

            //Console.WriteLine($"Resultado: {ecuacion}");
            resultado[0] = ecuacion;
            return resultado;
        }
    }
}
