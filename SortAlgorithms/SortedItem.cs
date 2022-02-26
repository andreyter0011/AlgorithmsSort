using System;
using System.Collections.Generic;
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
        public int Value { get; set; }

        public SortedItem(int value, int number)
        {
            Value = value;
            ProgressBar = new VerticalProgressBar();
            label = new Label();

            var x = number * 20;
            // 
            // ProgressBar1
            // 
            ProgressBar.BorderStyle = SortAlgorithms.BorderStyles.Classic;
            ProgressBar.Color = System.Drawing.Color.Blue;
            ProgressBar.Location = new System.Drawing.Point(x, 12);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "ProgressBar1" + number;
            ProgressBar.Size = new System.Drawing.Size(18, 104);
            ProgressBar.Step = 10;
            ProgressBar.Style = SortAlgorithms.Styles.Classic;
            ProgressBar.TabIndex = number;
            ProgressBar.Value = Value;
            // 
            // label3
            // 
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(x, 119);
            label.Name = "label" + number;
            label.Size = new System.Drawing.Size(19, 13);
            label.TabIndex = number;
            label.Text = Value.ToString();
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
    }
}
