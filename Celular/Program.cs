using Celular.Models;

Console.WriteLine("O seu smartphone vai ser iphone ou nokia? \n");

string x = Console.ReadLine();

Console.WriteLine("Escreva o número, modelo, IMEI e memória do celular \n");
Console.WriteLine("NÚMERO: \n");
string numero = Console.ReadLine();
Console.WriteLine("MODELO: \n");
string modelo = Console.ReadLine();
Console.WriteLine("IMEI: \n"); 
string imei = Console.ReadLine();
Console.WriteLine("MEMÓRIA: \n");
int memoria = Convert.ToInt32(Console.ReadLine());

if (x == "iphone") 
{
    Iphone y = new Iphone(numero, modelo, imei, memoria);

    Console.WriteLine("Parabéns o seu iphone foi criado \n" +
        "Número: "+y.Numero);
}
else
{
    Nokia z = new Nokia(numero, modelo, imei, memoria);
    Console.WriteLine("Parabéns o seu nokia foi criado \n" +
        "Número: " + z.Numero);
}




