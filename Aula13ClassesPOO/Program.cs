
using Aula13ClassesPOO;

Console.WriteLine("Hello, World!");


Pessoa conrado=new Pessoa("Conrado",27 ,"Rua Episcopal","São Carlos" );
Pessoa Isaque = new Pessoa("Isaque", 18, "Rua X", "Londrina");
Pessoa Jonatas = new Pessoa("Jonatas", 18, "Rua Y", "Nova Iorque");
Pessoa Camila = new Pessoa("Camila", 19, "Rua Do Goku", "Konoha");

List<Pessoa> pessoas = new List<Pessoa>();
pessoas.Add(conrado);
pessoas.Add(Isaque);
pessoas.Add(Jonatas);
pessoas.Add(Camila);

for (int i = 0; i < pessoas.Count; i++)
{
    pessoas[i].mostra();
    //Console.WriteLine(pessoas[i].nome);
}





Console.ReadKey();

