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

            // Se declaran variables para almacenar la informacion final de acumulados y promedios
            int varOperarios = 0;
            double varAcumuladoOperarios = 0;

            int varTecnicos = 0;
            double varAcumuladoTecnicos = 0;

            int varProfesionales = 0;
            double varAcumuladoProfesionales = 0;

            double varPromedioOperarios = 0;
            double varPromedioTecnicos = 0;
            double varPromedioProfesionales = 0;

            // Se inicia el for
            for (int i = 0; i < varN_Aumentos; i++)
            {
                // Se toma toda la informacion requerida al usuario
                Console.WriteLine("Digite la informacion del empleado " + (i+1));
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
                {   varAumento = varSalarioOrdinario * 0.05;
                    varSalarioBruto = varSalarioOrdinario + varAumento;
                }
                else
                {
                    Console.WriteLine("Codigo de empleado no valido. Digite entre las opciones establecidas");
                }
                double varDeduccion = varSalarioBruto * 0.0917;
                double varSalarioNeto = varSalarioBruto - varDeduccion;

                // Se clasifica el empleado y se acumulan sus codigos y salarios acumulados
                if (varCodigo == 1)
                {
                    varOperarios++;
                    varAcumuladoOperarios += varSalarioNeto;
                }
                else if (varCodigo == 2)
                {
                    varTecnicos++;
                    varAcumuladoTecnicos += varSalarioNeto;
                }
                else if (varCodigo == 3)
                {
                    varProfesionales++;
                    varAcumuladoProfesionales += varSalarioNeto;
                }

                // Se calcula el promedio de salarios por tipo de empleado
                varPromedioOperarios = varAcumuladoOperarios / varOperarios;
                varPromedioTecnicos = varAcumuladoTecnicos / varTecnicos;
                varPromedioProfesionales = varAcumuladoProfesionales / varProfesionales;

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

            // Se imprimen los resultados finales de los acumulados y promedios
            Console.WriteLine("***OPERARIOS***");
            Console.WriteLine("Total de operarios: " + varOperarios);
            Console.WriteLine("Total acumulado de operarios: " + varAcumuladoOperarios);
            Console.WriteLine("Promedio de salarios de operarios: " + varPromedioOperarios);
            Console.WriteLine("***TECNICOS***");
            Console.WriteLine("Total de tecnicos: " + varTecnicos);
            Console.WriteLine("Total acumulado de tecnicos: " + varAcumuladoTecnicos);
            Console.WriteLine("Promedio de salarios de tecnicos: " + varPromedioTecnicos);
            Console.WriteLine("***PROFESIONALES***");
            Console.WriteLine("Total de profesionales: " + varProfesionales);
            Console.WriteLine("Total acumulado de profesionales: " + varAcumuladoProfesionales);
            Console.WriteLine("Promedio de salarios de profesionales: " + varPromedioProfesionales);


        }
    }
}
