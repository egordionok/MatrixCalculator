using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculator
{
    public class Commands //класс реализующий возможность отмены и востановления операций
    {
        private Stack<ICommand> canceled; // Отмененные операции
        private Stack<ICommand> counted; // Операции, которые были посчитаны

        public Commands()
        {
            canceled = new Stack<ICommand>();
            counted = new Stack<ICommand>();
        }

        public ICommand Prev() // предидущая операция
        {
            ICommand command = counted.Pop();
            canceled.Push(command);
            return command;
        }

        public ICommand Next() // следущая операция(которая была отменена)
        {
            ICommand command = canceled.Pop();
            counted.Push(command);
            return command;
        }

        public void Add(ICommand command) // добавление операции 
        {
            counted.Push(command);
            if (canceled.Count != 0) canceled.Clear();
        }

    }
}
