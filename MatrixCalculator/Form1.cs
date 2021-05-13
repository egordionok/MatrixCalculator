using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalculator
{
    public partial class Form1 : Form
    {
        Commands _commands;
        Matrix lhs, rhs;
        public Form1()
        {
            InitializeComponent();
            _commands = new Commands();
        }

        // Invokers ---------------------------------------------
        private void SumButton_Click(object sender, EventArgs e)
        {
            if (!TextBoxParse()) return;
            NewCommand(new SumCommand(lhs, rhs));
        }
        private void SubButton_Click(object sender, EventArgs e)
        {

            if (!TextBoxParse()) return;
            NewCommand(new SubCommand(lhs, rhs));
        }
        private void MultButton_Click(object sender, EventArgs e)
        {
            if (!TextBoxParse()) return;
            NewCommand(new MultCommand(lhs, rhs));
        }
        private void TransButton_Click(object sender, EventArgs e)
        {
            if (!TextBoxParse()) return;
            NewCommand(new TransCommand(lhs));
        }
        // -------------------------------------------------------
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            string s = lhsMatrixBox.Text;
            lhsMatrixBox.Text = rhsMatrixBox.Text;
            rhsMatrixBox.Text = s;
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            try
            {
                lhs = _commands.Prev().Undo();
                lhsMatrixBox.Text = lhs.ToString();
            }
            catch (Exception ex) { }
        }
        private void ForwardButton_Click(object sender, EventArgs e)
        {
            try
            {
                lhs = _commands.Next().Execute();
                lhsMatrixBox.Text = lhs.ToString();
            }
            catch (Exception ex) { }
        }

        private bool TextBoxParse()
        {
            try
            {
                this.lhs = Matrix.Parse(lhsMatrixBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Левая матрица введена некоректно!");
                return false;
            }
            try
            {
                this.rhs = Matrix.Parse(rhsMatrixBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Правая матрица введена некоректно!");
                return false;
            }
            return true;
        }

        private void NewCommand(ICommand command)
        {
            try
            {
                lhs = command.Execute();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            _commands.Add(command);
            lhsMatrixBox.Text = lhs.ToString();
        }
    }
}
