using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_batch_Final.Modelo;

namespace Console_batch_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Base.CargarReporte();
            Base.CalcularStock();
            //Base.CalcularMenorStock();
            //Base.MostrarMensaje();


            Console.WriteLine($"El material de menor stock es: {Base.Stock[0].Nombre} con {Base.Stock[0].Cantidad} unidades");
            Console.WriteLine($"El material de Mayor stock es: {Base.Stock[1].Nombre} con {Base.Stock[1].Cantidad} unidades");
            Console.ReadLine();





        }
        
    }
}
