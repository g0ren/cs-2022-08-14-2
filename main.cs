using System;

class Program
{

    public static Int32[][] InitializeMatrix(Int32 vertices)
    {
        Int32[][] ret = new Int32[vertices][];
        for (int i = 0; i < ret.Length; i++)
        {
            ret[i] = new Int32[vertices];
        }
        return ret;
    }

    public static Int32[][] CloneMatrix(Int32[][] matrix)
    {
        Int32[][] ret = InitializeMatrix(matrix.Length);
        for (int i = 0; i < ret.Length; i++)
        {
            for (int j = 0; j < ret[i].Length; j++)
            {
                ret[i][j] = matrix[i][j];
            }
        }
        return ret;
    }

  public static Int32[][] TransposeMatrix(Int32[][] matrix)
    {
        Int32[][] ret = InitializeMatrix(matrix.Length);
        for (int i = 0; i < ret.Length; i++)
        {
            for (int j = 0; j < ret[i].Length; j++)
            {
                ret[i][j] = matrix[j][i];
            }
        }
        return ret;
    }

  public static Int32[][] RotateMatrixCC(Int32[][] matrix)
    {
        Int32[][] ret = InitializeMatrix(matrix.Length);
        for (int i = 0; i < ret.Length; i++)
        {
            for (int j = 0; j < ret[i].Length; j++)
            {
                ret[matrix.Length-j-1][i] = matrix[i][j];
            }
        }
        return ret;
    }

public static Int32[][] RotateMatrix(Int32[][] matrix)
    {
        Int32[][] ret = InitializeMatrix(matrix.Length);
        for (int i = 0; i < ret.Length; i++)
        {
            for (int j = 0; j < ret[i].Length; j++)
            {
                ret[j][matrix.Length-i-1] = matrix[i][j];
            }
        }
        return ret;
    }
  
    public static void PrintMatrix(Int32[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write("{0} ", matrix[i][j]);
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        Int32[][]matrix=new Int32[3][]{new Int32[3]{1,2,3},
                                       new Int32[3]{4,5,6},
                                       new Int32[3]{7,8,9}};
      Int32[][]r=RotateMatrix(matrix);
      PrintMatrix(matrix);
      Console.WriteLine();
      PrintMatrix(r);
    }


}