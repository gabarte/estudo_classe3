using ex_classe3_aluno;

Aluno a = new Aluno();

Console.Write("Digite o nome do aluno: ");
a.Nome = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Digite as três notas do aluno");
Console.Write("1º Semestre: 30/");
a.Nota1 = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.Write("2º Semestre: 35/");
a.Nota2 = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.Write("3º Semestre: 35/");
a.Nota3 = double.Parse(Console.ReadLine());

Console.WriteLine();
double somaNota = a.SomaNota();
Console.WriteLine("A nota total é: " + somaNota);

string aprovado = a.Aprovacao();
Console.WriteLine(aprovado);
