internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Input how many rows:");
        string? input = Console.ReadLine();

        Writer(input);

    }

    private static void Writer(string? rows)
    {
        if (Int32.TryParse(rows, out int rowNumber))
        {
            Console.WriteLine("Input was a number: {0}", rowNumber);

            WriterHelper(rowNumber);

            for (int i = 1; i < rowNumber; i++)
            {
                WriterHelper(rowNumber - i, rowNumber + i);
                Console.WriteLine();
            }            
        }
    }

    private static void WriterHelper(int firstPos, int? lastPos = null)
    {
        if (lastPos == null)
        {
            for (int i = 1; i <= firstPos; i++)
            {
                if (i == firstPos)
                {
                    Console.Write("^");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = 1; i <= lastPos; i++)
            {
                if (i == firstPos)
                {
                    Console.Write("/");
                }
                else if (i == lastPos)
                {
                    Console.Write(Convert.ToChar(92));
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }

    }
}