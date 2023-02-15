using System;

namespace fileorgodev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Button generateNumberButton;
        private System.Windows.Forms.TextBox arraySizeValue;
        private System.Windows.Forms.DataGridView REISCH_dataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchValue_textBox;
        private System.Windows.Forms.TextBox searchResults_textBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox numberRange_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listBox3;
        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.generateNumberButton = new System.Windows.Forms.Button();
            this.arraySizeValue = new System.Windows.Forms.TextBox();
            this.REISCH_dataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Values = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.searchValue_textBox = new System.Windows.Forms.TextBox();
            this.searchResults_textBox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.numberRange_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ProbsStatistics_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.REISCH_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox3
            // 
            this.listBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(883, 122);
            this.listBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(266, 340);
            this.listBox3.TabIndex = 18;
            // 
            // generateNumberButton
            // 
            this.generateNumberButton.Location = new System.Drawing.Point(644, 197);
            this.generateNumberButton.Margin = new System.Windows.Forms.Padding(4);
            this.generateNumberButton.Name = "generateNumberButton";
            this.generateNumberButton.Size = new System.Drawing.Size(196, 28);
            this.generateNumberButton.TabIndex = 2;
            this.generateNumberButton.Text = "Generate";
            this.generateNumberButton.UseVisualStyleBackColor = true;
            this.generateNumberButton.Click += new System.EventHandler(this.generateNumberButton_Click);
            // 
            // arraySizeValue
            // 
            this.arraySizeValue.Location = new System.Drawing.Point(784, 152);
            this.arraySizeValue.Margin = new System.Windows.Forms.Padding(4);
            this.arraySizeValue.Name = "arraySizeValue";
            this.arraySizeValue.Size = new System.Drawing.Size(56, 22);
            this.arraySizeValue.TabIndex = 3;
            this.arraySizeValue.Text = "10";
            // 
            // REISCH_dataGrid
            // 
            this.REISCH_dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.REISCH_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.REISCH_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewLinkColumn2});
            this.REISCH_dataGrid.Location = new System.Drawing.Point(289, 121);
            this.REISCH_dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.REISCH_dataGrid.Name = "REISCH_dataGrid";
            this.REISCH_dataGrid.RowHeadersWidth = 51;
            this.REISCH_dataGrid.Size = new System.Drawing.Size(311, 341);
            this.REISCH_dataGrid.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Index";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Value";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewLinkColumn2
            // 
            this.dataGridViewLinkColumn2.ActiveLinkColor = System.Drawing.Color.Green;
            this.dataGridViewLinkColumn2.HeaderText = "Link";
            this.dataGridViewLinkColumn2.LinkColor = System.Drawing.Color.Red;
            this.dataGridViewLinkColumn2.MinimumWidth = 6;
            this.dataGridViewLinkColumn2.Name = "dataGridViewLinkColumn2";
            this.dataGridViewLinkColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinkColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn2.VisitedLinkColor = System.Drawing.Color.Blue;
            this.dataGridViewLinkColumn2.Width = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "REISCH";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Values,
            this.REIS});
            this.dataGrid.Location = new System.Drawing.Point(21, 122);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.Size = new System.Drawing.Size(244, 340);
            this.dataGrid.TabIndex = 4;
            // 
            // Values
            // 
            this.Values.HeaderText = "Value";
            this.Values.MinimumWidth = 6;
            this.Values.Name = "Values";
            this.Values.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Values.Width = 50;
            // 
            // REIS
            // 
            this.REIS.HeaderText = "REISCH";
            this.REIS.MinimumWidth = 6;
            this.REIS.Name = "REIS";
            this.REIS.Width = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "Prob Number";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchValue_textBox
            // 
            this.searchValue_textBox.Location = new System.Drawing.Point(645, 254);
            this.searchValue_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchValue_textBox.Name = "searchValue_textBox";
            this.searchValue_textBox.Size = new System.Drawing.Size(67, 22);
            this.searchValue_textBox.TabIndex = 3;
            // 
            // searchResults_textBox
            // 
            this.searchResults_textBox.Location = new System.Drawing.Point(644, 298);
            this.searchResults_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchResults_textBox.Multiline = true;
            this.searchResults_textBox.Name = "searchResults_textBox";
            this.searchResults_textBox.Size = new System.Drawing.Size(196, 68);
            this.searchResults_textBox.TabIndex = 8;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(736, 248);
            this.search_button.Margin = new System.Windows.Forms.Padding(4);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(104, 28);
            this.search_button.TabIndex = 9;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // numberRange_textBox
            // 
            this.numberRange_textBox.Location = new System.Drawing.Point(685, 152);
            this.numberRange_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberRange_textBox.Name = "numberRange_textBox";
            this.numberRange_textBox.Size = new System.Drawing.Size(56, 22);
            this.numberRange_textBox.TabIndex = 3;
            this.numberRange_textBox.Text = "900";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Number Range";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(656, 155);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "0 -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(772, 122);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Array Size";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(13, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(991, 54);
            this.label13.TabIndex = 10;
            this.label13.Text = "Random Early Insertion Coalesced Hashing";
            // 
            // ProbsStatistics_textBox
            // 
            this.ProbsStatistics_textBox.Location = new System.Drawing.Point(21, 497);
            this.ProbsStatistics_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProbsStatistics_textBox.Multiline = true;
            this.ProbsStatistics_textBox.Name = "ProbsStatistics_textBox";
            this.ProbsStatistics_textBox.Size = new System.Drawing.Size(244, 97);
            this.ProbsStatistics_textBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(940, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Binary Tree";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.searchResults_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProbsStatistics_textBox);
            this.Controls.Add(this.REISCH_dataGrid);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.searchValue_textBox);
            this.Controls.Add(this.numberRange_textBox);
            this.Controls.Add(this.arraySizeValue);
            this.Controls.Add(this.generateNumberButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.REISCH_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ProbsStatistics_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Values;
        private System.Windows.Forms.DataGridViewTextBoxColumn REIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn2;
    }
}

