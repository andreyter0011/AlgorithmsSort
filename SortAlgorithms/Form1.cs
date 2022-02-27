using Algorithm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        List <SortedItem> items = new List <SortedItem> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(int.TryParse(AddTextBox.Text, out int value))
            {
                var item = new SortedItem (value, items.Count);
                items.Add(item);
            }

            RefreshItems();

            AddTextBox.Text = "";
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(FillTextBox.Text, out int value))
            {
                var rnd = new Random();

                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next(100), items.Count);
                    items.Add(item);
                }
            }
            
            RefreshItems();

            FillTextBox.Text = "";
        }

        private void DrawItems(List<SortedItem> items)
        {
            panel3.Controls.Clear();

            foreach (var item in items)
            {
                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.label);
            }
            panel3.Refresh();
        }

        private void RefreshItems()
        {
            foreach(var item in items)
            {
                item.Refresh();
            }
            DrawItems(items);
        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            RefreshItems();

            var bubble = new BubbleSort<SortedItem>(items);
            bubble.CompareEvent += Bubble_CompareEvent;
            bubble.SwopEvent += Bubble_SwopEvent;
            var time = bubble.Sort();
            TimeLabel.Text = "Время: " + time.Seconds;
            SwopLabel.Text = "Количество обменов: " + bubble.SwopCount;
            CompareLabel.Text = "Количество сравнений: " + bubble.ComparisonCount;
        }

        private void Bubble_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            e.Item1.SetColor(Color.Red);
            e.Item2.SetColor(Color.Green);
            panel3.Refresh();
        }

        private void Bubble_SwopEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Number;
            e.Item1.SetPosition(e.Item2.Number);
            e.Item2.SetPosition(temp);

            panel3.Refresh();

            e.Item1.SetColor(Color.Blue);
            e.Item2.SetColor(Color.Blue);
            panel3.Refresh();
        }

        private void Swop(SortedItem a, SortedItem b)
        {
            a.SetColor(Color.Red);
            b.SetColor(Color.Green);
        }
    }
}
