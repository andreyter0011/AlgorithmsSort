namespace SortAlgorithms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.FillButton = new System.Windows.Forms.Button();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BubbleSort = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.CompareLabel = new System.Windows.Forms.Label();
            this.SwopLabel = new System.Windows.Forms.Label();
            this.CocktailSort = new System.Windows.Forms.Button();
            this.InsertSort = new System.Windows.Forms.Button();
            this.ShellSort = new System.Windows.Forms.Button();
            this.HeapSort = new System.Windows.Forms.Button();
            this.TreeSort = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 62);
            this.panel1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(247, 25);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(95, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить число";
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(24, 28);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(217, 20);
            this.AddTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.FillButton);
            this.panel2.Controls.Add(this.FillTextBox);
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 72);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заполнить массив случайными числами";
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(247, 25);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(95, 23);
            this.FillButton.TabIndex = 1;
            this.FillButton.Text = "Заполнить";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(24, 25);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(217, 20);
            this.FillTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(360, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 140);
            this.panel3.TabIndex = 3;
            // 
            // BubbleSort
            // 
            this.BubbleSort.Location = new System.Drawing.Point(12, 146);
            this.BubbleSort.Name = "BubbleSort";
            this.BubbleSort.Size = new System.Drawing.Size(75, 23);
            this.BubbleSort.TabIndex = 0;
            this.BubbleSort.Text = "BubbleSort";
            this.BubbleSort.UseVisualStyleBackColor = true;
            this.BubbleSort.Click += new System.EventHandler(this.BubbleSort_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(9, 172);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(43, 13);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "Время:";
            // 
            // CompareLabel
            // 
            this.CompareLabel.AutoSize = true;
            this.CompareLabel.Location = new System.Drawing.Point(9, 195);
            this.CompareLabel.Name = "CompareLabel";
            this.CompareLabel.Size = new System.Drawing.Size(126, 13);
            this.CompareLabel.TabIndex = 5;
            this.CompareLabel.Text = "Количество сравнений:";
            // 
            // SwopLabel
            // 
            this.SwopLabel.AutoSize = true;
            this.SwopLabel.Location = new System.Drawing.Point(9, 218);
            this.SwopLabel.Name = "SwopLabel";
            this.SwopLabel.Size = new System.Drawing.Size(116, 13);
            this.SwopLabel.TabIndex = 6;
            this.SwopLabel.Text = "Количество обменов:";
            // 
            // CocktailSort
            // 
            this.CocktailSort.Location = new System.Drawing.Point(93, 146);
            this.CocktailSort.Name = "CocktailSort";
            this.CocktailSort.Size = new System.Drawing.Size(75, 23);
            this.CocktailSort.TabIndex = 7;
            this.CocktailSort.Text = "CocktailSort";
            this.CocktailSort.UseVisualStyleBackColor = true;
            this.CocktailSort.Click += new System.EventHandler(this.CocktailSort_Click);
            // 
            // InsertSort
            // 
            this.InsertSort.Location = new System.Drawing.Point(174, 146);
            this.InsertSort.Name = "InsertSort";
            this.InsertSort.Size = new System.Drawing.Size(75, 23);
            this.InsertSort.TabIndex = 8;
            this.InsertSort.Text = "InsertSort";
            this.InsertSort.UseVisualStyleBackColor = true;
            this.InsertSort.Click += new System.EventHandler(this.InsertSort_Click);
            // 
            // ShellSort
            // 
            this.ShellSort.Location = new System.Drawing.Point(255, 146);
            this.ShellSort.Name = "ShellSort";
            this.ShellSort.Size = new System.Drawing.Size(75, 23);
            this.ShellSort.TabIndex = 9;
            this.ShellSort.Text = "ShellSort";
            this.ShellSort.UseVisualStyleBackColor = true;
            this.ShellSort.Click += new System.EventHandler(this.ShellSort_Click);
            // 
            // HeapSort
            // 
            this.HeapSort.Location = new System.Drawing.Point(336, 146);
            this.HeapSort.Name = "HeapSort";
            this.HeapSort.Size = new System.Drawing.Size(75, 23);
            this.HeapSort.TabIndex = 10;
            this.HeapSort.Text = "HeapSort";
            this.HeapSort.UseVisualStyleBackColor = true;
            this.HeapSort.Click += new System.EventHandler(this.HeapSort_Click);
            // 
            // TreeSort
            // 
            this.TreeSort.Location = new System.Drawing.Point(417, 146);
            this.TreeSort.Name = "TreeSort";
            this.TreeSort.Size = new System.Drawing.Size(75, 23);
            this.TreeSort.TabIndex = 11;
            this.TreeSort.Text = "TreeSort";
            this.TreeSort.UseVisualStyleBackColor = true;
            this.TreeSort.Click += new System.EventHandler(this.TreeSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TreeSort);
            this.Controls.Add(this.HeapSort);
            this.Controls.Add(this.ShellSort);
            this.Controls.Add(this.InsertSort);
            this.Controls.Add(this.CocktailSort);
            this.Controls.Add(this.SwopLabel);
            this.Controls.Add(this.CompareLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.BubbleSort);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.TextBox FillTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BubbleSort;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label CompareLabel;
        private System.Windows.Forms.Label SwopLabel;
        private System.Windows.Forms.Button CocktailSort;
        private System.Windows.Forms.Button InsertSort;
        private System.Windows.Forms.Button ShellSort;
        private System.Windows.Forms.Button HeapSort;
        private System.Windows.Forms.Button TreeSort;
    }
}

