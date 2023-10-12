using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraFront.Servicios
{
    internal class Lector
    {
        public String[] Leer(String ecuacion)
        {
            String[] resultado = new String[2];
            Corroborador corroborador = new Corroborador();
            if (corroborador.CorroborarParentesis(ecuacion))
                if (corroborador.CorroborarEscritura(ecuacion))
                {
                    Desglosador desglosador = new Desglosador();
                    resultado = desglosador.Desglosar(ecuacion);
                    if (resultado[0].Contains("Error"))
                    {
                        resultado[0] = "Error.";
                    }
                }
                else
                {
                    resultado[0]= "Error.";
                    resultado[1] = "Error: Ecuación mal escrita.";
                }
            else
            {
                resultado[0] = "Error.";
                resultado[1] = "Error: Paréntesis mal colocados.";
            }



            return resultado;
            /*
            Corroborador corroborador = new Corroborador();
            String ecuacion="";
            Boolean caracteresNoValidos = corroborador.CorroborarParentesis(ecuacion);
            */
            /*
            Corroborador corroborador = new Corroborador();
            Boolean seguir = true;
            while (seguir)
            {
                Console.WriteLine("Ingrese la ecuación a resolver: ");
                String ecuacion = Console.ReadLine();
                String caracteresNoValidos = corroborador.CorroborarContenido(ecuacion);
                if (!(caracteresNoValidos == null))
                {
                    Console.WriteLine($"Los siguientes caracteres ingresados no son válidos: {caracteresNoValidos}");
                }
                Console.WriteLine($"¿Desea resolver otra ecuación?");
                Console.WriteLine($"Cualquier tecla para continuar.");
                Console.WriteLine($"S - Salir.");
                String opcion = Console.ReadLine();
                if (opcion == "S" || opcion == "s")
                {
                    seguir = false;
                    Console.WriteLine($"Adios.");
                }
            }
            */
        }
    }
}
