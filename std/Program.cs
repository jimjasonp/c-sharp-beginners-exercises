using System;

class MatrixStandardDeviation
{
    static void Main(string[] args)
    {
        // Example matrix
        double[,] matrix = {
            { 1.0, 2.0, 3.0 },
            { 4.0, 5.0, 6.0 },
            { 7.0, 8.0, 9.0 }
        };




        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int n = rows * cols;

      
        double sum = 0.0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum += matrix[i, j];
            }
        }
        double mean = sum / n;

        
        double varianceSum = 0.0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                varianceSum += Math.Pow(matrix[i, j] - mean, 2);
            }
        }
        double variance = varianceSum / n;

     
       

        double stdDev =Math.Sqrt(variance) ;
        Console.WriteLine("H tupikh apoklish einai: " + stdDev);
        Console.WriteLine("O mesos oros einai: " + mean);
    }


}
