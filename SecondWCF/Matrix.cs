using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for Matrix
/// </summary>
[DataContract]
public class Matrix
{
    [DataMember]
    public int Rows { get; set; }
    [DataMember]
    public int Columns { get; set; }
    [DataMember]
    public double[][] Data = null;// jagged array
                                  // [,] 2-d array cannot be exposed as data in a SOAP environment
    public Matrix(int rows, int columns)
    {
        this.Rows = rows;
        this.Columns = columns;
        Data = new double[rows][];
        for (int i = 0; i < rows; i++)
            Data[i] = new double[columns];
    }

    public double this[int i, int j]
    {
        get
        {
            return Data[i][j];
        }
        set
        {
            Data[i][j] = value;
        }
    }
}