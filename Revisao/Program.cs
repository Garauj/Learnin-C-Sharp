
using System;
namespace REVISAO
{
    
class program
{
static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            String opcaousuario = obteropcaousuario();
            var nralunos =0;
            while (opcaousuario.ToUpper() != "X")
            {
                switch (opcaousuario)
                {
                    case "1":
                        Console.WriteLine("informe o nome do aluno");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("informe a nota do aluno");
                        if (decimal.TryParse(Console.ReadLine(),out decimal nota))
                       {
                        aluno.Nota = nota;
                        
                        }
                        else
                        {
                            throw new ArgumentException("o valor da nota deve ser decimal");
                        }
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        nralunos++;
                        break;
                    case "2":
                        foreach(var a in alunos)
                        if(!a.Nome.Equals(""))
                        {
                        Console.WriteLine($"aluno: {a.Nome}  nota {a.Nota}");
                        }
                        break;

                    case "3":
                        decimal notatotal=0;
                        
                        for(int i=0;i<alunos.Length;i++ )
                        {
                        if(!alunos[i].Nota.Equals(""));
                        {
                        notatotal = notatotal + alunos[i].Nota;                       
                        }
                        }
                        var mediageral = notatotal/nralunos;
                        Conceito conceitogeral;
                        if(mediageral<6)
                        {
                        conceitogeral = Conceito.C;
                        }
                        else if(mediageral<8)
                        {
                            conceitogeral= Conceito.B;
                        }
                        else
                        {
                        conceitogeral= Conceito.A;
                        }
                        Console.WriteLine($"média geral{mediageral} conceito geral{conceitogeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();




                }
                opcaousuario = obteropcaousuario();
            }
            Console.WriteLine("obrigado");

        }

        private static string obteropcaousuario()
        {
            Console.WriteLine("informe alunos");
            Console.WriteLine("1 inserir novo aluno");
            Console.WriteLine("2 listar alunos");
            Console.WriteLine("3 cálcular média geral");
            Console.WriteLine(" x Sair");
            Console.WriteLine();

            String opcaousuario = Console.ReadLine();
            return opcaousuario;
        }

    }
}