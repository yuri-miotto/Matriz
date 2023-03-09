using System.Data.Common;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        //[linha,coluna]
        int[,] mat = new int[3, 4];

        for (int linha = 0; linha < 3; linha++)
        {
            for (int coluna = 0; coluna < 4; coluna++)
            {
                mat[linha, coluna] = linha * coluna;
            }
        }

        //impressão da primeira coluna apenas:
        for (int linha = 0; linha < 3; linha++)
        {
            Console.Write(mat[linha, 0]);
        }

        //imprimindo todas as linhas de cada coluna:
        for (int coluna = 0; coluna < 4; coluna++)
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
            Console.WriteLine(mat[x, x]);
        }

        //para imprimir a diagonal secundaria:
        for (int x = 0; x < 3; x++)
        {
            //ou Console.WriteLine(mat[x, 2-x]);

            for (int y = 2; y >= 0; y--)
            {
                Console.WriteLine(mat[x, y]);
            }
        }
        */ 

        //EXERCÍCIO 1:
        //matriz 5x3 onde a 3º coluna é a média das duas primeiras

        double[,] matriz = new double[5, 3];

        for (int linha = 0; linha < 5; linha++)
        {
            for(int coluna = 0; coluna < 2; coluna++)
            {
                matriz[linha, coluna] = linha + coluna;
            }
            matriz[linha, 2] = (matriz[linha, 0] + matriz[linha, 1]) / 2;
        }

        for (int linha = 0; linha < 5; linha++)
        {
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.Write(matriz[linha,coluna] + " ");
                
            }
            Console.WriteLine();
        }

        Console.WriteLine();


        //feito pelo professor:
        double[,] mat = new double[5, 3];

        Random sorteio = new Random();

        for (int c = 0; c < mat.GetLength(1) - 1; c++) // GetLength(0)==linha , GetLength(1)==coluna
        {
            for (int l = 0; l < mat.GetLength(0); l++)
            {
                mat[l,c] = (double)sorteio.Next(1000)/100;
                //mat[l, c] = sorteio.NextDouble(); /* sorteia um valor entre 0 e 1 */
            }
        }

        //calculando a 3º coluna:
        for (int l = 0; l < mat.GetLength(0); l++)
        {
            mat[l, 2] = (mat[l,0] + mat[l,1]) / 2;
        }



        Console.WriteLine("Os valores da matriz são: ");
        for (int l = 0; l < mat.GetLength(0); l++) 
        {
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                Console.Write("\tmat[" + l + "][" + c + "]=" + mat[l,c]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();




        //EXERCÍCIO 2:
        //matriz 5 x 5 e imprime as somas os caminhos possíveis (coluna(s), linha(s) e diagonal(is))

        int[,] matriz2 = new int[5, 5];

        for (int linha = 0; linha < 5; linha++)
        {
            for (int coluna = 0; coluna < 5; coluna++)
            {
                matriz2[linha, coluna] = linha + coluna;
            }            
        }

        int res = 0;
        for (int linha = 0; linha < 5; linha++)
        {
            res += matriz2[linha, 0];            
        }
        Console.WriteLine(res);

        Console.WriteLine();


        //feito pelo professor:
        int[,] mat2 = new int[5, 5];
        Random sorteio2 = new Random();

        for (int c = 0; c < mat2.GetLength(1); c++) 
        {
            for (int l = 0; l < mat2.GetLength(0); l++)
            {
                mat2[l, c] = sorteio2.Next(1000);                
            }
        }

        Console.WriteLine("Os valores da matriz são: ");
        for (int l = 0; l < mat2.GetLength(0); l++)
        {
            for (int c = 0; c < mat2.GetLength(1); c++)
            {
                Console.Write("\tmat[" + l + "][" + c + "]=" + mat2[l, c]);  // \t == "tab"
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Soma das linhas...");
        for (int l = 0; l < mat2.GetLength(0); l++)
        {
            Console.Write("Soma da Linha ["+l+"]= ");
            int somalinha = 0;
            for (int c = 0; c < mat2.GetLength(1); c++)
            {
                somalinha += mat2[l, c];
            }
            Console.WriteLine(somalinha);
        }

        Console.WriteLine();


        Console.WriteLine("Soma das colunas...");
        for (int c = 0; c < mat2.GetLength(1); c++)
        {
            Console.Write("Soma da coluna [" + c + "]= ");
            int somacoluna = 0;
            for (int l = 0; l < mat2.GetLength(0); l++)
            {
                somacoluna += mat2[l, c];
            }
            Console.WriteLine(somacoluna);
        }

        Console.WriteLine();

        Console.Write("Soma da Diagonal Principal: ");
        int diagonal = 0;
        for (int c = 0; c < mat2.GetLength(1); c++)
        {      
            diagonal += mat2[c, c];
        }
        Console.WriteLine(diagonal);

        Console.WriteLine();


        Console.Write("Soma da Diagonal Secundária: ");
        diagonal = 0;
        for (int c = 0; c < mat2.GetLength(1); c++)
        {
            diagonal += mat2[c, mat2.GetLength(1)-c-1];
        }
        Console.WriteLine(diagonal);

        Console.WriteLine();


        //EXERCÍCIO 3:
        //copia os valores de uma matriz em uma nova de forma invertida
        //feito pelo professor:
        int[,] mat3 = new int[5, 5];
        int[,] mat4 = new int[5, 5];
        Random sorteio3 = new Random();

        for (int c = 0; c < mat3.GetLength(1); c++)
        {
            for (int l = 0; l < mat3.GetLength(0); l++)
            {
                mat3[l, c] = sorteio3.Next(100);
            }
        }

        for (int l = 0; l < mat3.GetLength(0); l++)
        {
            for (int c = 0; c < mat3.GetLength(1); c++)
            {
                mat4[mat3.GetLength(0)-1-l , mat3.GetLength(1)-1-c] = mat3[l,c];
            }
        }


        Console.WriteLine("Os valores da matriz são: ");
        for (int l = 0; l < mat3.GetLength(0); l++)
        {
            for (int c = 0; c < mat3.GetLength(1); c++)
            {
                Console.Write("\tmat[" + l + "][" + c + "]=" + mat3[l, c]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Os valores da matriz invertida são: ");
        for (int l = 0; l < mat4.GetLength(0); l++)
        {
            for (int c = 0; c < mat4.GetLength(1); c++)
            {
                Console.Write("\tmat[" + l + "][" + c + "]=" + mat4[l, c].ToString("d4"));
            }
            Console.WriteLine();
        }

        Console.WriteLine();



    }


}