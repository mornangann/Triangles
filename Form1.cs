using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double size1, size2, size3;

            if (!double.TryParse(oneBox.Text, out size1) || !double.TryParse(twoBox.Text, out size2) || !double.TryParse(threeBox.Text, out size3))
            {
                resultLable.Text = "Некорретный ввод - введите значение/поставьте запятую";
            }
            else if (size1 <= 0 || size2 <= 0 || size3 <= 0)
            {
                resultLable.Text = "Значение стороны должно быть больше нуля";
            }
            else if (size1 + size2 <= size3 || size1 + size3 <= size2 || size2 + size3 <= size1)
            {
                resultLable.Text = "Этот треугольник - не существует";
            }
            else if (size1 == size2 && size1 == size3)
            {
                resultLable.Text = "Этот треугольник - равносторонний";
            }
            else if (size1 == size2 || size1 == size3 || size2 == size3)
            {
                resultLable.Text = "Этот треугольник -  равнобедренный";
            }
            else
            {
                resultLable.Text = "Этот треугольник - разносторонний";
            }
        }
    }
}
