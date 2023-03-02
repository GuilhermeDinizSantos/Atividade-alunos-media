//Criando variáveis
string[,] matriz = new string[5, 7];
int i = 0;
int c = 0;
int trabalho = 0;
int total = 0;
string resultado = "";
double presenca = 0;
for (i = 0; i < 5; i++)
{
    c = 0;
    Console.Clear();
    Console.WriteLine("Bem vindo, professor. \n->Informe o nome do demonio:");
    matriz[i, c++] = Console.ReadLine();
    Console.WriteLine("->Informe a quantidade de aulas:");
    matriz[i, c++] = Console.ReadLine();
    Console.WriteLine("->Informe a quantidade de faltas:");
    matriz[i, c++] = Console.ReadLine();
    Console.WriteLine("->Informe a nota da prova 1:");
    matriz[i, c++] = Console.ReadLine();
    Console.WriteLine("->Informe a nota da prova 2:");
    matriz[i, c++] = Console.ReadLine();
    Console.WriteLine("->Informe a nota da prova 3:");
    matriz[i, c++] = Console.ReadLine();
    Console.WriteLine("->Informe a nota do trabalho:");
    matriz[i, c++] = Console.ReadLine();
    if (matriz[i, 6] == "0")
    {
        trabalho = 0;
    }
    else
    {
        trabalho = 1;
    }
    total = ((int.Parse(matriz[i, 3]) + int.Parse(matriz[i, 4]) + int.Parse(matriz[i, 5])) / 3) + trabalho;
    presenca = int.Parse(matriz[i, 2]) / int.Parse(matriz[i, 1]) * 100;
    if (total >= 6 && presenca >= 25)
    {
        resultado = "Aprovado";
    }
    if (total <= 6 && presenca >= 25)
    {
        resultado = "Reprovado por menção";
    }
    if (total >= 6 && presenca < 25)
    {
        resultado = "Reprovado por falta";
    }
    if (total <= 6 && presenca < 25)
    {
        resultado = "Reprovado por menção e por Falta";
    }
    Console.Clear();
            Console.WriteLine(matriz[i, 0] + ", Sua nota foi de:" + total + "\nSua cota de falta foi de" + presenca + "%\nEle foi: " + resultado + "\nPressione qualquer tecla para continuar");
    Console.ReadLine();
}