using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_for_BD
{

    /// <summary>
    /// Multiple Linear Regression
    /// </summary>
    public class MultipleLinearRegression
    {
        /// <summary>
        /// Get b coefficients vector (Y = b0x0 + b1x1 + b2x2 ... + bnxn)
        /// </summary>
        /// <param name="m">Matrix to get b coefficients from</param>
        /// <returns></returns>
        public Matrix GetBCoefficientsForMatrix(Matrix m, Matrix yVector)
        {
            Matrix vectorRes = null;

            Matrix transposed = m.Transpose();
            Matrix multiplied = Matrix.MultiplyMatrices(transposed, m);
            Matrix inversed = multiplied.Invert();
            Matrix multiplied2 = Matrix.MultiplyMatrices(inversed, transposed);
            vectorRes = Matrix.MultiplyMatrices(multiplied2, yVector);

            return vectorRes;
        }

        /// <summary>
        /// Get Y for vector of X's
        /// </summary>
        /// <param name="vectB"></param>
        /// <param name="vectX"></param>
        /// <returns></returns>
        public double GetYForVectorXs(Matrix vectB, int[] X)
        {
            double y = 0.0;
            for (int i = 0; i < vectB.matrixBase.GetLength(0); i++)
            {
                y += (vectB.matrixBase[i, 0] * X[i]);
            }

            return y;
        }
    }
}
