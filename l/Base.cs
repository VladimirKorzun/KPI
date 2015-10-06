using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l
{
    abstract class Base
    {
        private string name;
        private int[] vectorArray;
        private int[,] matrixArray;
        public string Name
        {
            get
            { return name; }
            set
            { name = value; }
        }
        public int[,] MatrixArray
        {
            get
            {
                return matrixArray;
            }
            set
            {
                matrixArray = value;
            }
        }

        public int[] VectorArray
        {
            get
            {
                return vectorArray;
            }
            set
            {
                vectorArray = value;
            }
        }
        public int this[int index]
        {
            get
            {
                try {
                    return vectorArray[index];
                }
                catch
                {
                    throw new IndexOutOfRangeException("SizeFailure");
                }
            }
        }
        public int this[int index_i, int index_j]
        {
            get
            {
                try {
                    return matrixArray[index_i, index_j];
                }
                catch
                {
                    throw new IndexOutOfRangeException("SizeFailure");
                }
            }
        }
        public abstract Base Add(Base newBase);
        public abstract Base Sub(Base newBase);
        public abstract Base Mult(Base newBase);
        public abstract Base Mult(int number);
        public abstract int Evkl();
        public abstract int Scalar(Base newBase);
        public abstract Base Combine(Base newBase);
        public abstract void Show();
        public abstract string ReturnString();

    }
}
