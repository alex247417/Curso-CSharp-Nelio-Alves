string[] tamanho = Console.ReadLine().Split(' ');

int linhas = int.Parse(tamanho[0]);
int colunas = int.Parse(tamanho[1]);

int[,] matris = new int[linhas, colunas];


for (int i = 0; i < linhas; i++)
{
    string[] values = Console.ReadLine().Split(' ');
    for (int j = 0; j < colunas; j++)
    {
        matris[i, j] = int.Parse(values[j]);
    }
}

int x = int.Parse(Console.ReadLine());
Console.WriteLine("");

for (int i = 0; i < linhas; i++)
{
    for (int j = 0; j < colunas; j++)

    {
        if (matris[i, j] == x)
        {
            Console.Write($"Position: {i},{j} \n");
            Console.WriteLine($"Number: {matris[i, j]}");
            if (j > 0)
            {
                Console.WriteLine($"Left: {matris[i,j - 1]}");
            }

            if (j < colunas -1)
            {
                Console.WriteLine($"Right:{matris[i,j + 1]}");
            }

            if (i < linhas -1)
            {
                Console.WriteLine(($"Down: {matris[i + 1,j]}"));
            }

            if (i > 0)
            {
                Console.WriteLine(($"Up: {matris[i - 1,j]}"));
            }
            
            Console.WriteLine("");
        }
    }
}

Console.ReadKey();