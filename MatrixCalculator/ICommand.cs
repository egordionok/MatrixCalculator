using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculator
{
    //Command:
    public interface ICommand
    {
        Matrix Execute();
        Matrix Undo();
    }

    //ConcreteCommands:
    public class SumCommand : ICommand
    {
        Matrix lhs, rhs;

        public SumCommand(Matrix lhs, Matrix rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }
        public Matrix Execute()
        {
            return lhs + rhs;
        }

        public Matrix Undo()
        {
            return lhs - rhs;
        }
    }

    public class SubCommand : ICommand
    {
        Matrix lhs, rhs;

        public SubCommand(Matrix lhs, Matrix rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }
        public Matrix Execute()
        {
            return lhs - rhs;
        }

        public Matrix Undo()
        {
            return lhs + rhs;
        }
    }

    public class MultCommand : ICommand
    {
        Matrix lhs, rhs;
        Matrix undoMatrix;

        public MultCommand(Matrix lhs, Matrix rhs)
        {
            this.undoMatrix = lhs.Copy();
            this.lhs = lhs;
            this.rhs = rhs;
        }
        public Matrix Execute()
        {
            return lhs * rhs;
        }

        public Matrix Undo()
        {
            return undoMatrix;
        }
    }

    public class TransCommand : ICommand
    {
        Matrix matrix;

        public TransCommand(Matrix matrix)
        {
            this.matrix = matrix;
        }
        public Matrix Execute()
        {
            return matrix.T();
        }

        public Matrix Undo()
        {
            return matrix;
        }
    }
}
