using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    internal class Tarea2
    {
        static void Main(string[] args)
        {
            // Se solicita al usuario la cantidad de aumentos que desea realizar y se corre en un ciclo for
            Console.WriteLine("Cuantos aumentos desea realizar: ");
            int varN_Aumentos = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < varN_Aumentos; i++)
            {
                // Se toma toda la informacion requerida al usuario
                Console.WriteLine("Digite la informacion del empleado " + i+1);
                Console.WriteLine("Nombre del empleado: ");
                string varNombre = Console.ReadLine();
                Console.WriteLine("Numero de cedula: ");
                string varCedula = Console.ReadLine();
                Console.WriteLine("Indique el codigo del empleado:\n 1) Operario\n 2) Tecnico\n 3) Profesional ");
                int varCodigo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Indique las horas laboradas del empleado: ");
                double varSalario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Indique el salario por hora del empleado: ");
                double varSalarioHora = Convert.ToDouble(Console.ReadLine());

                // Se realizan calculos de las diferentes cintemplaciones en base al salario
                double varSalarioOrdinario = varSalario * varSalarioHora;
                double varSalarioBruto = 0;
                double varAumento = 0;
                if (varCodigo == 1) 
                {   varAumento = varSalarioOrdinario * 0.15;
                    varSalarioBruto = varSalarioOrdinario + varAumento;
                }
                else if (varCodigo == 2) 
                {   varAumento = varSalarioOrdinario * 0.10;
                    varSalarioBruto = varSalarioOrdinario + varAumento;
                }
                else if (varCodigo == 3) 
                {   varAumento = varSalarioOrdinario * 0.5;
                    varSalarioBruto = varSalarioOrdinario + varAumento;
                }
                else
                {
                    Console.WriteLine("Codigo de empleado no valido. Digite entre las opciones establecidas");
                }
                double varDeduccion = varSalarioBruto * 0.0917;
                double varSalarioNeto = varSalarioBruto - varDeduccion;

                // Se imprime la informacion del empleado y los resultados de los calculos realizados
                Console.WriteLine("Nombre del empleado: " + varNombre);
                Console.WriteLine("Numero de cedula: " + varCedula);
                Console.WriteLine("Tipo de empleado: " + varCodigo);
                Console.WriteLine("Salario por hora: " + varSalarioHora);
                Console.WriteLine("Horas laboradas: " + varSalario);
                Console.WriteLine("Salario ordinario: " + varSalarioOrdinario);
                Console.WriteLine("Aumento: " + varAumento);
                Console.WriteLine("Salario bruto: " + varSalarioBruto);
                Console.WriteLine("Deduccion CCSS: " + varDeduccion);
                Console.WriteLine("Salario neto: " + varSalarioNeto);
                Console.WriteLine("--------------------------------------------------");



            }





        }
    }
}
