using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculator
{

    public class Matrix // Resiver
    {
        double[][] matrix;
        Shape shape;
        public Matrix(double[][] matrix)
        {
            this.matrix = matrix;
        }
        public Matrix(int X, int Y)
        {
            this.matrix = new double[X][];
            for (int i = 0; i < X; i++)
            {
                this.matrix[i] = new double[Y];
            }
            this.shape = new Shape(X, Y);
        }
        public Matrix(Shape shape)
        {
            this.matrix = new double[shape.X][];
            for (int i = 0; i < shape.X; i++)
            {
                this.matrix[i] = new double[shape.Y];
            }
            this.shape = shape;
        }
        public Matrix(List<List<double>> list)
        {
            this.shape = new Shape(list.Count, list[0].Count);
            this.matrix = new double[this.shape.X][];
            for (int i = 0; i < this.shape.X; i++)
            {
                this.matrix[i] = new double[this.shape.Y];
            }

            for (int i = 0; i < this.shape.X; i++)
            {
                for(int j = 0; j < this.shape.Y; j++)
                {
                    matrix[i][j] = list[i][j];
                }
            }
        }
        public Matrix Copy()
        {
            return new Matrix(this.matrix);
        }
        //=====================================================
        public double this[int i, int j] // Индексаторы 
        {
            get
            {
                return this.matrix[i][j];
            }
            set
            {
                this.matrix[i][j] = value;
            }
        }  

        //=====================================================
        public static Matrix operator +(Matrix lhs, Matrix  rhs)
        {
            if(lhs.shape != rhs.shape)
            {
                throw new Exception("Размеры матриц не совпадают!");
            }
            for (int i = 0; i < lhs.shape.X; i++)
            {
                for (int j = 0; j < lhs.shape.Y; j++)
                {
                    lhs[i, j] += rhs[i, j];
                }
            }

            return lhs;
        }
        public static Matrix operator -(Matrix lhs, Matrix rhs)
        {
            if (lhs.shape != rhs.shape)
            {
                throw new Exception("Размеры матриц не совпадают!");
            }
            Matrix ans = lhs.Copy();
            for (int i = 0; i < lhs.shape.X; i++)
            {
                for (int j = 0; j < lhs.shape.Y; j++)
                {
                    ans[i, j] = lhs[i, j] - rhs[i, j];
                }
            }

            return ans;
        }
        public static Matrix operator *(Matrix lhs, Matrix rhs)
        {
            if (lhs.shape.Y != rhs.shape.X)
            {
                if (rhs.shape.X == 1 && rhs.shape.Y == 1)
                {
                    return lhs * rhs[0, 0];
                }
                throw new Exception("Матрицы не могут быть перемножаны!");
            }

            Matrix ans = new Matrix(lhs.shape.X, rhs.shape.Y);

            for(int i = 0; i < lhs.shape.X; i++)
            {
                for (int j = 0; j < rhs.shape.Y; j++)
                {
                    ans[i, j] = 0;
                    for(int k = 0; k < rhs.shape.X; k++)
                    {
                        ans[i, j] += lhs[i, k] * rhs[k, j];
                    }
                }
            }
            lhs = ans;
            return lhs;
        }
        public static Matrix operator *(Matrix lhs, double rhs)
        {
            Matrix ans = new Matrix(lhs.shape.X, lhs.shape.Y);
            for (int i = 0; i < lhs.shape.X; i++)
            {
                for(int j = 0; j < lhs.shape.Y; j++)
                {
                    ans[i, j] = lhs[i, j] * rhs;
                }
            }
            return ans;
        }
        public Matrix T()
        {
            double[][] ans = new double[this.shape.X][];
            for (int i = 0; i < this.shape.X; i++)
            {
                ans[i] = new double[this.shape.Y];
            }
            for (int i = 0; i < this.shape.X; i++)
            {
                for(int j = 0; j < this.shape.Y; j++)
                {
                    ans[i][j] = this.matrix[j][i];
                }
            }
            return new Matrix(ans);
        }
        public static Matrix Parse(string s)
        {
            s = s.Trim();
            List<List<double>> list = new List<List<double>>();
            foreach(string q in s.Split('\n'))
            {
                string part = q.Trim();
                List<double> doubleList = new List<double>();
                foreach (string t in part.Split())
                {
                    doubleList.Add(Convert.ToDouble(t));
                }
                list.Add(doubleList);
            }
            return new Matrix(list);
        }
        public string ToString()
        {
            string s = "";
            foreach(double[] a in this.matrix)
            {
                foreach(double b in a)
                {
                    s += b.ToString() + " ";
                }
                s.Trim();
                s += "\r\n";
            }

            return s;
        }
    }
}
