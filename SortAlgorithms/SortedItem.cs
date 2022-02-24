using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    internal class SortedItem
    {
        public VerticalProgressBar ProgressBar { get; private set; }
        public Label label { get; private set; }
        public int Value { get; set; }

        public SortedItem(int value)
        {
            Value = value;
            ProgressBar = new VerticalProgressBar();
            label = new Label();
            // 
            // ProgressBar1
            // 
            ProgressBar.BorderStyle = SortAlgorithms.BorderStyles.Classic;
            ProgressBar.Color = System.Drawing.Color.Blue;
            ProgressBar.Location = new System.Drawing.Point(3, 12);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "ProgressBar1";
            ProgressBar.Size = new System.Drawing.Size(18, 104);
            ProgressBar.Step = 10;
            ProgressBar.Style = SortAlgorithms.Styles.Classic;
            ProgressBar.TabIndex = 0;
            ProgressBar.Value = Value;
            // 
            // label3
            // 
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(3, 119);
            label.Name = "label3";
            label.Size = new System.Drawing.Size(19, 13);
            label.TabIndex = 4;
            label.Text = Value.ToString();
        }
    }
}
