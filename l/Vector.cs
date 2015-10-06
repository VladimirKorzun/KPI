using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l
{
    class Vector : Base
    {
        public override string ReturnString()
        {
            string res = "";
            int size = this.VectorArray.Length;
            for (int i = 0; i < size; i++)
            {              
                    res = res + this[i].ToString() + " ";             
            }
            return res;
        }
        public Vector(string name, int[] array)
        {
            this.Name = name;
            this.VectorArray = new int[array.Length];
            Array.Copy(array, this.VectorArray, array.Length);
        }
        public override Base Add(Base newBase)
        {
            try {
                string resultName = string.Format("{0}+{1}", this.Name, newBase.Name);
                int size = this.VectorArray.Length;
                int[] resultArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    resultArray[i] = this[i] + newBase[i];
                }
                Log.ToLog(DateTime.Now.ToString(), "vector +", "success");
                return new Vector(resultName, resultArray);
            }
            catch(Exception e)
            {
                Log.ToLog(DateTime.Now.ToString(), "vector +", "failed");
                Console.Write(e.ToString());
                return null;     
            }
        }
        public override Base Sub(Base newBase)
        {
            try {
                string resultName = string.Format("{0}-{1}", this.Name, newBase.Name);
                int size = this.VectorArray.Length;
                int[] resultArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    resultArray[i] = this[i] - newBase[i];
                }
                Log.ToLog(DateTime.Now.ToString(), "vector -", "success");
                return new Vector(resultName, resultArray);
            }
            catch (Exception e)
            {
                Log.ToLog(DateTime.Now.ToString(), "vector -", "failed");
                Console.Write(e.ToString());
                return null;
            }
        }
        public override Base Mult(Base newBase)
        {
            try
            {
                string resultName = string.Format("{0}*{1}", this.Name, newBase.Name);
                int size = this.VectorArray.Length;
                int[] resultArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    resultArray[i] = this[i] * newBase[i];
                }
                Log.ToLog(DateTime.Now.ToString(), "vector *", "success");
                return new Vector(resultName, resultArray);
            }
            catch (Exception e)
            {
                Log.ToLog(DateTime.Now.ToString(), "vector *", "failed");
                Console.Write(e.ToString());
                return null;
            }

        }
        public override Base Mult(int number)
        {
            try {
                string resultName = string.Format("{0}*{1}", this.Name, number);
                int size = this.VectorArray.Length;
                int[] resultArray = new int[size];
                for (int i = 0; i < size; i++)
                {
                    resultArray[i] = this[i] * number;
                }
                Log.ToLog(DateTime.Now.ToString(), "vector * int", "success");
                return new Vector(resultName, resultArray);
            }
            catch (Exception e)
            {
                Log.ToLog(DateTime.Now.ToString(), "vector * int", "failed");
                Console.Write(e.ToString());
                return null;
            }
        }
        public override int Scalar(Base newBase)
        {
            int scalar = 0;
            for (int i = 0; i < this.VectorArray.Length; i++)
            {
                scalar += this[i] * newBase[i];
            }
            Log.ToLog(DateTime.Now.ToString(), "vector scalar", "success");
            return scalar;

        }
        public override int Evkl()
        {
            int result = 0;
            for (int i = 0; i < this.VectorArray.Length; i++)
            {
                result += this[i] * this[i];
            }
            Log.ToLog(DateTime.Now.ToString(), "vector evkl", "success");
            return result;
        }
        public override Base Combine(Base newBase)
        {
            try {
                string ResultName = string.Format("{0}*{1}", this.Name, newBase.Name);
                int size = (int)Math.Sqrt(newBase.MatrixArray.Length);
                int[,] ResultArray = new int[size, size];
                if (this.VectorArray.Length < size)
                    size = this.VectorArray.Length;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                        ResultArray[i, j] = this[i] * newBase[i, j];
                }
                Log.ToLog(DateTime.Now.ToString(), "vector * matrix", "success");
                return new Matrix(ResultName, ResultArray);
            }
            catch (Exception e)
            {
                Log.ToLog(DateTime.Now.ToString(), "vector * matrix", "failed");
                Console.Write(e.ToString());
                return null;
            }
        }
        public override void Show()
        {
            for (int i = 0; i < this.VectorArray.Length; i++)
                Console.Write(this[i] + " ");
        }
    }
}
