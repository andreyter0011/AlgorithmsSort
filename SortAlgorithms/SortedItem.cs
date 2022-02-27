using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    internal class SortedItem : IComparable
    {
        public VerticalProgressBar ProgressBar { get; private set; }
        public Label label { get; private set; }
        public int Value { get; private set; }
        public int Number { get; private set; }
        public int StartNumber { get; private set; }
        public SortedItem(int value, int number)
        {
            Value = value;
            Number = number;
            StartNumber = number;
            ProgressBar = new VerticalProgressBar();
            label = new Label();

            var x = number * 20;
            // 
            // ProgressBar1
            // 
            ProgressBar.BorderStyle = BorderStyles.Classic;
            ProgressBar.Color = Color.Blue;
            ProgressBar.Location = new Point(x, 12);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "ProgressBar" + number;
            ProgressBar.Size = new Size(18, 104);
            ProgressBar.Step = 1;
            ProgressBar.Style = Styles.Classic;
            ProgressBar.TabIndex = number;
            ProgressBar.Value = Value;
            // 
            // label3
            // 
            label.AutoSize = true;
            label.Location = new Point(x, 119);
            label.Name = "label" + number;
            label.Size = new Size(19, 13);
            label.TabIndex = number;
            label.Text = Value.ToString();
        }

        public void SetPosition(int number)
        {
            Number = number;
            var x = number * 20;
            ProgressBar.Location = new Point(x, 12);
            ProgressBar.Name = "ProgressBar" + number;
            label.Location = new Point(x, 119);
            label.Name = "label" + number;
        }

        public void Refresh()
        {
            Number = StartNumber;
            var x = Number * 20;
            ProgressBar.Location = new Point(x, 12);
            ProgressBar.Name = "ProgressBar" + Number;
            label.Location = new Point(x, 119);
            label.Name = "label" + Number;
        }

        public void SetColor(Color color)
        {
            ProgressBar.Color = color;
        }
        public int CompareTo(object obj)
        {
            if(obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            else
            {
                throw new ArgumentException($"obj is not {nameof(SortedItem)}", nameof(obj));
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
