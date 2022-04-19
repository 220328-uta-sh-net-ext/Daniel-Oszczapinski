namespace CSharpBasics
{
    public class Collections
    {
        public static void Arrays_1d()
        {

            int[] scores;
            scores = new int[5];
            scores[0] = 50;
            scores[3] = 78;

            Console.WriteLine($"Size of an array = {scores.Length}");
            Console.WriteLine($"Dimension of the array = {scores.Rank}");

            /*for (int i = 0; i < scores.Length; i++) 
            {
                Console.WriteLine(scores[i]);
            }*/
            //Array.Reverse(scores); //Gives the reverse order of the array.
            foreach (var score in scores)
            {
                Console.WriteLine(score + " ");
            }

        }

        public static void Arrays_MultiDmensional()
        {
            int[,] twoDArray = new int[2, 3]; // 2d array with two rows and 3 columns

            int[,,] threeDArray = new int[3, 3, 3]; //3d array

            int[][] jaggedArray = new int[2][]; // Jagged array with 2 rows.
            jaggedArray[0] = new int[3]; // 1st row, with 3 columns.
            jaggedArray[1] = new int[5]; // 2nd row with 5 columns. 

            Console.WriteLine($"Size = {twoDArray.Length}");
            Console.WriteLine($"Rank = {twoDArray.Rank}");
            twoDArray[0, 0] = 1;
            twoDArray[1, 0] = 2;

            //read an element
            //Console.WriteLine(twoDArray[1,2]);

            /*for (int i = 0; i < 2; i++) // access rows
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(twoDArray[i,j]+ " ");
                }
                Console.WriteLine();
            
            }
            */
        }

        public static int[] Reverse(int[] x)
        {
            int[] reversed = new int[x.Length];
            for (int i = x.Length - 1; i >= 0; i--)
            {
                reversed[x.Length - 1 - i] = x[i];
            }
            return reversed;
        }

        public static void JaggedArray()

        {
            int[][] jaggedArray = new int[2][]; // Jagged array with 2 rows.
            jaggedArray[0] = new int[3]; // 1st row, with 3 columns.
            jaggedArray[1] = new int[5]; // 2nd row with 5 columns.
            // 1st row
            jaggedArray[0][0] = 89;
            jaggedArray[0][1] = 66;
            jaggedArray[0][2] = 44;
            // 2nd row
            jaggedArray[1][0] = 11;
            jaggedArray[1][1] = 22;
            jaggedArray[1][2] = 45;
            jaggedArray[1][3] = 56;
            jaggedArray[1][4] = 76;
            //read
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void ReadArray(int[] anyArray)
        {
            foreach (var a in anyArray)
            {
                Console.Write(a + " ");
            }

        }
        public static void MoveZeros(int[] y)
        {
            ReadArray(y);
            Console.WriteLine();
            for (int i = 0; i < y.Length; i++)
            {
                if (y[i] == 0)
                {
                    for (int j = i; j < y.Length - 1; j++)
                    {
                        int temp = y[j];
                        y[j] = y[j + 1];
                        y[j + 1] = temp;
                    }
                }

            }
            ReadArray(y);
        }
             public static void Outting(string[] args)
{
    int i;
    for (i = 0; i < 5; i++)
    {
    }
    Console.WriteLine(i);
}


    }
}