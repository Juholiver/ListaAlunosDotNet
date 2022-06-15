using System;

namespace Revisao {

    class Program 
    {

        static void Main (string []  args, int v)
        {

            Aluno[] alunos =new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar aluno
                        Console.WriteLine("Informe o nome do aluno: ");
                        var aluno = new Aluno();
                        string? v1 = Console.ReadLine();
                        aluno.Nome = v;

                        Console.WriteLine("Informe a nota do aluno: ");
                        
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else 
                        {
                            throw new ArgumentNullException("valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        //TODO: listar alunos
                        foreach(var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {    
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                            }
                        }
                        break;
                    case "3":
                        //TODO: calcular media geral
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for (int i=0; i < alunos.Length; i++);
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome));
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        Console.WriteLine($"Media geral: {mediaGeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1- Inserir novo aluno: ");
            Console.WriteLine("2- Listar alunos: ");
            Console.WriteLine("3- Calcular média geral: ");
            Console.WriteLine("X- Sair ");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}