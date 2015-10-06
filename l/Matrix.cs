using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l
{

    class Matrix : Base
    {
        public override string ReturnString()
        {
            string res = "";
            int size = (int)Math.Sqrt(this.MatrixArray.Length);
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    res = res + this[i, j].ToString()+ " ";
                }
            }
            return res;
        }
        public override Base Combine(Base newBase)
        {
            try
            {
                string resultName = string.Format("{0}*{1}", this.Name, newBase.Name);
                int size = (int)Math.Sqrt(this.MatrixArray.Length);
                int[,] resultArray = new int[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                        resultArray[i, j] = this[i, j] * newBase[i];
                }
                Log.ToLog(DateTime.Now.ToString(), "matrix * vector", "success");
                return new Matrix(resultName, resultArray);
            }
            catch (Exception e)
            {
                Log.ToLog(DateTime.Now.ToString(), "matrix * vector", "failed");
                Console.Write(e.ToString());
                return null;
            }
        }

        public Matrix(string name, int[,] array)
        {
            this.Name = name;
            int size = (int)Math.Sqrt(array.Length);
            this.MatrixArray = new int[size, size];
            Array.Copy(array, this.MatrixArray, array.Length);
        }
        public override Base Add(Base newBase)
        {
            try {
                string resultName = string.Format("{0}+{1}", this.Name, newBase.Name);
                int size = (int)Math.Sqrt(this.MatrixArray.Length);
                int[,] resultArray = new int[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                        resultArray[i, j] = this[i, j] + newBase[i, j];
                }
                Log.ToLog(DateTime.Now.ToString(), "matrix +", "success");
                return new Matrix(resultName, resultArray);
            }
            catch (Exception e)
            {
                Log.ToLog(DateTime.Now.ToString(), "matrix +", "failed");
                Console.Write(e.ToString());
                return null;
            }



        }
        public override Base Sub(Base newBase)
        {
            try {
                string resultName = string.Format("{0}-{1}", this.Name, newBase.Name);
                int size = (int)Math.Sqrt(this.MatrixArray.Length);
                int[,] resultArray = new int[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                        resultArray[i, j] = this[i, j] - newBase[i, j];
                }
                Log.ToLog(DateTime.Now.ToString(), "matrix -", "success");
                return new Matrix(resultName, resultArray);
            }
            catch (Exception e)
            {
                Log.ToLog(DateTime.Now.ToString(), "matrix -", "failed");
                Console.Write(e.ToString());
                return null;
            }
        }
        public override Base Mult(Base newBase)
        {
            try {
                string resultName = string.Format("{0}*{1}", this.Name, newBase.Name);
                int size = (int)Math.Sqrt(this.MatrixArray.Length);
                int[,] resultArray = new int[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        for (int k = 0; k < size; k++)
                            resultArray[i, j] += this[i, k] * newBase[k, j];
                    }
                }
                Log.ToLog(DateTime.Now.ToString(), "matrix *", "success");
                return new Matrix(resultName, resultArray);
            }
            catch (Exception e)
            {
                Log.ToLog(DateTime.Now.ToString(), "matrix *", "failed");
                Console.Write(e.ToString());
                return null;
            }
        }
        public override Base Mult(int number)
        {
            try {
                string resultName = string.Format("{0}*{1}", this.Name, number);
                int size = (int)Math.Sqrt(this.MatrixArray.Length);
                int[,] resultArray = new int[size, size];
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                        resultArray[i, j] = this[i, j] * number;
                }
                Log.ToLog(DateTime.Now.ToString(), "matrix * int", "success");
                return new Matrix(resultName, resultArray);
            }
            catch (Exception e)
            {
                Log.ToLog(DateTime.Now.ToString(), "matrix * int", "failed");
                Console.Write(e.ToString());
                return null;
            }
        }
        public override int Scalar(Base newBase)
        {
            Console.WriteLine("OPERATION NOT SUPPORTED");
            return 0;
        }
        public override int Evkl()
        {
            int result = 0;
            int size = (int)Math.Sqrt(this.MatrixArray.Length);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result += this[i, j] * this[i, j];
                }
            }
            return result;
        }
        public override void Show()
        {
            int size = (int)Math.Sqrt(this.MatrixArray.Length);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(this[i, j] + " ");
                }
                Console.Write("\n");
            }
        }

    }
}
