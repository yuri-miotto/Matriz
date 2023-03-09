using System.Data.Common;

internal class Program
{
    private static void Main(string[] args)
    {
        //[linha,coluna]
        int[,] mat = new int[3,4];

        for(int linha = 0; linha< 3; linha++)
        {
            for(int coluna = 0; coluna< 4; coluna++)
            {
                mat[linha, coluna] = linha*coluna;
            }
        }

        //impressão da primeira coluna apenas:
        for(int linha = 0;linha< 3; linha++)
        {
            Console.Write(mat[linha,0]);
        }

        //imprimindo todas as linhas de cada coluna:
        for (int coluna = 0; coluna< 4; coluna++)
        {
            for (int linha = 0; linha < 3; linha++)
            {
                Console.WriteLine(mat[linha, coluna]);
            }
        }

        //se fosse uma matriz quadrada
        //para imprimir a diagonal principal teriamos:
        for (int x = 0; x < 3; x++)
        {
            Console.WriteLine(mat[x,x]);
        }

        //para imprimir a diagonal secundaria:
        for (int x =0; x < 3; x++)
        {
            //ou Console.WriteLine(mat[x, 2-x]);

            for (int y = 2; y >= 0; y--)
            {
                Console.WriteLine(mat[x,y]);
            }
        }

        
    }
}