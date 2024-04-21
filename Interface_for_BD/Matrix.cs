using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_for_BD
{
    /// <summary>
    /// Matrix.
    /// </summary>
    public class Matrix
    {
        public double[,] matrixBase;
        public Matrix(double[,] matrixBase)
        {
            this.matrixBase = matrixBase;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.matrixBase.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrixBase.GetLength(1); j++)
                {
                    sb.Append(this.matrixBase[i, j]);
                    sb.Append("\t");
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Adding matrixes
        /// </summary>
        /// <param name="matrixA"></param>
        /// <param name="matrixb"></param>
        /// <returns></returns>
        public static Matrix SumMatrices(Matrix matrixA, Matrix matrixB)
        {
            if (matrixA.matrixBase.GetLength(0) != matrixB.matrixBase.GetLength(0) || matrixA.matrixBase.GetLength(1) != matrixB.matrixBase.GetLength(1))
                throw new FormatException("Matrixes have different number of rows or different number of columns");

            Matrix matrixC = new Matrix(new double[matrixA.matrixBase.GetLength(0), matrixB.matrixBase.GetLength(1)]);
            for (int row = 0; row < matrixA.matrixBase.GetLength(0); row++)
            {
                for (int column = 0; column < matrixA.matrixBase.GetLength(1); column++)
                {
                    matrixC.matrixBase[row, column] = matrixA.matrixBase[row, column] + matrixB.matrixBase[row, column];
                }
            }

            return matrixC;
        }

        /// <summary>
        /// Substracting matrixes.
        /// </summary>
        /// <param name="matrixA"></param>
        /// <param name="matrixb"></param>
        /// <returns></returns>
        public static Matrix SubstractMatrices(Matrix matrixA, Matrix matrixB)
        {
            if (matrixA.matrixBase.GetLength(0) != matrixB.matrixBase.GetLength(0) || matrixA.matrixBase.GetLength(1) != matrixB.matrixBase.GetLength(1))
                throw new FormatException("Matrixes have different number of rows or different number of columns");

            Matrix matrixC = new Matrix(new double[matrixA.matrixBase.GetLength(0), matrixB.matrixBase.GetLength(1)]);
            for (int row = 0; row < matrixA.matrixBase.GetLength(0); row++)
            {
                for (int column = 0; column < matrixA.matrixBase.GetLength(1); column++)
                {
                    matrixC.matrixBase[row, column] = matrixA.matrixBase[row, column] - matrixB.matrixBase[row, column];
                }
            }

            return matrixC;
        }

        /// <summary>
        /// Multiplying matrices.
        /// </summary>
        /// <param name="matrixA"></param>
        /// <param name="matrixb"></param>
        /// <returns></returns>
        public static Matrix MultiplyMatrices(Matrix matrixA, Matrix matrixB)
        {
            if (matrixA.matrixBase.GetLength(1) != matrixB.matrixBase.GetLength(0))
                throw new FormatException("matrixA's dimensions number is diffrent from matrixB dimensions[0] length");

            Matrix matrixC = new Matrix(new double[matrixA.matrixBase.GetLength(0), matrixB.matrixBase.GetLength(1)]);
            for (int i = 0; i < matrixB.matrixBase.GetLength(1); i++)
            {
                for (int j = 0; j < matrixA.matrixBase.GetLength(0); j++)
                {
                    double result = 0;
                    for (int k = 0; k < matrixA.matrixBase.GetLength(1); k++)
                    {
                        result += matrixA.matrixBase[j, k] * matrixB.matrixBase[k, i];
                    }
                    matrixC.matrixBase[j, i] = result;
                }
            }

            return matrixC;
        }

        /// <summary>
        /// Multiply to scalar
        /// </summary>
        /// <param name="scalar"></param>
        /// <returns>Returns NEW matrix</returns>
        public Matrix MultiplyToScalar(double scalar)
        {
            Matrix m = new Matrix(this.matrixBase);
            for (int i = 0; i < this.matrixBase.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrixBase.GetLength(1); j++)
                {
                    m.matrixBase[i, j] = m.matrixBase[i, j] * scalar;
                }
            }

            return m;
        }

        /// <summary>
        /// Transporate matrix.
        /// </summary>
        /// <param name="matrixA"></param>
        public Matrix Transpose()
        {
            Matrix newMatrix = new Matrix(new double[this.matrixBase.GetLength(1), this.matrixBase.GetLength(0)]);

            for (int i = 0; i < this.matrixBase.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrixBase.GetLength(1); j++)
                {
                    newMatrix.matrixBase[j, i] = this.matrixBase[i, j];
                }
            }

            return newMatrix;

        }

        /// <summary>
        /// Get matrix determinant
        /// </summary>
        /// <returns></returns>
        public double GetDeterminant()
        {
            if (this.matrixBase.GetLength(0) != this.matrixBase.GetLength(1))
                throw new InvalidOperationException("Matrices should be squared");

            //if it is 2x2 matrix
            if (this.matrixBase.GetLength(0) == 2)
            {
                return this.matrixBase[0, 0] * this.matrixBase[1, 1]
                    - this.matrixBase[0, 1] * this.matrixBase[1, 0];
            }



            //new matrix with new columns (we need the same number of columns - 1) for the same values 
            //from beginning of matrix
            double[,] extendedMatrixBase = new double[this.matrixBase.GetLength(0),
                this.matrixBase.GetLength(1) + this.matrixBase.GetLength(1) - 1];

            //filling part of new matrix with the same values as in this object matrix
            for (int i = 0; i < this.matrixBase.GetLength(0); i++)
            {
                for (int j = 0; j < this.matrixBase.GetLength(1); j++)
                {
                    extendedMatrixBase[i, j] = this.matrixBase[i, j];
                }
            }

            //filling new columns with values the same as at beginning of matrix
            for (int i = 0; i < this.matrixBase.GetLength(0); i++)
            {
                for (int j = this.matrixBase.GetLength(1); j < extendedMatrixBase.GetLength(1); j++)
                {
                    extendedMatrixBase[i, j] = this.matrixBase[i, j - this.matrixBase.GetLength(0)];
                }
            }

            Matrix extendedMatrix = new Matrix(extendedMatrixBase);

            //calculating determinant
            double determinant = 0.0;

            //summing
            double sumsResult = 0.0;
            for (int i = 0; i < this.matrixBase.GetLength(0); i++)
            {
                int row = 0;
                int column = i;

                double diagonalResult = 1.0;
                for (int j = 0; j < this.matrixBase.GetLength(0); j++, row++, column++)
                {
                    diagonalResult *= extendedMatrix.matrixBase[row, column];
                }
                sumsResult += diagonalResult;
            }

            //substracting
            double substractionsResult = 0.0;
            for (int i = 0; i < this.matrixBase.GetLength(0); i++)
            {
                int row = 0;
                int column = extendedMatrix.matrixBase.GetLength(1) - 1 - i;

                double diagonalResult = 1.0;
                for (int j = 0; j < this.matrixBase.GetLength(0); j++, row++, column--)
                {
                    diagonalResult *= extendedMatrix.matrixBase[row, column];
                }
                substractionsResult += diagonalResult;
            }

            determinant = sumsResult - substractionsResult;

            return determinant;
        }

        /// <summary>
        /// Is matrix invertable?
        /// </summary>
        /// <returns></returns>
        public bool isInvertable()
        {
            if (this.GetDeterminant() != 0)
                return true;
            else
                return false;
        }


        /// <summary>
        /// Invert matrix.
        /// </summary>
        /// <param name="matrixA"></param>
        /// <returns>new inverted matrix</returns>
        public Matrix Invert()
        {
            Matrix invertedMatrix;

            if (this.isInvertable())
            {
                //Getting matrix of minors
                Matrix matrixOfMinors = new Matrix(new double[matrixBase.GetLength(0), matrixBase.GetLength(1)]);

                for (int row = 0; row < matrixBase.GetLength(0); row++)
                {
                    for (int column = 0; column < matrixBase.GetLength(1); column++)
                    {
                        double[,] subMArrBase = new double[matrixBase.GetLength(0) - 1, matrixBase.GetLength(1) - 1];
                        Matrix subMatrix = new Matrix(subMArrBase);

                        int subMRow = 0;
                        for (int r = 0; r < matrixBase.GetLength(0); r++)
                        {
                            if (row == r)
                                continue;
                            int subMColumn = 0;
                            for (int c = 0; c < matrixBase.GetLength(1); c++)
                            {
                                if (column == c)
                                    continue;

                                subMArrBase[subMRow, subMColumn] = this.matrixBase[r, c];
                                subMColumn++;
                            }
                            subMRow++;
                        }

                        matrixOfMinors.matrixBase[row, column] = subMatrix.GetDeterminant();
                    }
                }

                //creating cofactor matrix
                int rowStartMultiplier;
                for (int i = 0; i < matrixOfMinors.matrixBase.GetLength(0); i++)
                {
                    if (i % 2 == 0)
                        rowStartMultiplier = 1;
                    else
                        rowStartMultiplier = -1;

                    for (int j = 0; j < matrixOfMinors.matrixBase.GetLength(1); j++)
                    {
                        matrixOfMinors.matrixBase[i, j] *= rowStartMultiplier;
                        //swap
                        rowStartMultiplier *= -1;
                    }
                }

                //determinant of THIS matrix
                double determinant = this.GetDeterminant();
                Matrix transposed = matrixOfMinors.Transpose();
                invertedMatrix = transposed.MultiplyToScalar(1 / determinant);

            }
            else
                throw new InvalidOperationException("Matrix is not invertable");

            return invertedMatrix;
        }

        /// <summary>
        /// get matrix from txt UTF-8 encoded file with data
        /// </summary>
        /// <param name="fileDir">file direction</param>
        /// <param name="delim">delimeter of columns</param>
        /// <returns></returns>
        public static Matrix GetMatrixFromTXT(string fileDir, char delim)
        {
            Matrix result = null;

            string line;
            List<string> rawLines = new List<string>();

            System.IO.StreamReader file = new System.IO.StreamReader(fileDir);
            while ((line = file.ReadLine()) != null)
            {
                rawLines.Add(line);
            }
            file.Close();

            int columns = rawLines.FirstOrDefault().Split(delim).Count();
            int rows = rawLines.Count();

            result = new Matrix(new double[rows, columns]);
            for (int i = 0; i < rawLines.Count(); i++)
            {
                string[] lineData = rawLines[i].Split(delim);
                for (int j = 0; j < columns; j++)
                {
                    result.matrixBase[i, j] = Double.Parse(lineData[j]);
                }
            }

            return result;
        }

        /// <summary>
        /// Get part of matrix
        /// </summary>
        /// <returns>new sub Matrix</returns>
        public Matrix GetMatrixPart(int[] rows, int[] columns)
        {
            Matrix result = new Matrix(new double[rows.Length, columns.Length]);

            int row = 0;
            for (int i = 0; i < this.matrixBase.GetLength(0); i++)
            {
                if (!rows.Contains(i))
                    continue;
                int column = 0;
                for (int j = 0; j < this.matrixBase.GetLength(1); j++)
                {
                    if (!columns.Contains(j))
                        continue;

                    result.matrixBase[row, column] = this.matrixBase[i, j];
                    column++;
                }
                row++;
            }
            return result;
        }

    }
}
