using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_ALGORITMO
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            float nota;
            int aprovado  = 0;
            int reprovado = 0;
            int exame = 0;

            do
            {
                Console.Write("Digite a média do aluno: ");
                nota = float.Parse(Console.ReadLine());
                while (nota <= 0 || nota > 10)
                {
                    Console.Write("Erro! Digite novamente a média:");
                    nota = float.Parse(Console.ReadLine());
                }
                contador++;
                if (nota >= 7)
                {
                    aprovado++;
                }
                else
                    if ( nota < 3)
                    {
                        reprovado++;
                    }
                    else
                    {
                        exame++;
                    }
            }
            while (contador < 30);

            Console.WriteLine("Alunos aprovados: {0} que representam {1}% do total.", aprovado, ((float)aprovado / (float)contador) * 100 );
            Console.WriteLine("Alunos reprovados: {0} que representam {1}% do total.", reprovado, ((float)reprovado / (float)contador) * 100);
            Console.WriteLine("Alunos de Exame: {0} que representam {1}% do total.", exame, ((float)exame / (float)contador) * 100);

            Console.ReadKey();
        }
    }
}
