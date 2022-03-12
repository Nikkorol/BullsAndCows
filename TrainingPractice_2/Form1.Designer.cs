namespace TrainingPractice_2
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
            this.puzzledWordLabel = new System.Windows.Forms.Label();
            this.userWordTextBox = new System.Windows.Forms.TextBox();
            this.bullsCountLabel = new System.Windows.Forms.Label();
            this.cowsCountLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
            this.StepColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bullsCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cowsCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // puzzledWordLabel
            // 
            this.puzzledWordLabel.AutoSize = true;
            this.puzzledWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.puzzledWordLabel.Location = new System.Drawing.Point(16, 24);
            this.puzzledWordLabel.Name = "puzzledWordLabel";
            this.puzzledWordLabel.Size = new System.Drawing.Size(53, 20);
            this.puzzledWordLabel.TabIndex = 0;
            this.puzzledWordLabel.Text = "label1";
            // 
            // userWordTextBox
            // 
            this.userWordTextBox.Location = new System.Drawing.Point(16, 87);
            this.userWordTextBox.Name = "userWordTextBox";
            this.userWordTextBox.Size = new System.Drawing.Size(100, 20);
            this.userWordTextBox.TabIndex = 1;
            // 
            // bullsCountLabel
            // 
            this.bullsCountLabel.AutoSize = true;
            this.bullsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bullsCountLabel.Location = new System.Drawing.Point(16, 142);
            this.bullsCountLabel.Name = "bullsCountLabel";
            this.bullsCountLabel.Size = new System.Drawing.Size(91, 20);
            this.bullsCountLabel.TabIndex = 2;
            this.bullsCountLabel.Text = "Быков = 0";
            // 
            // cowsCountLabel
            // 
            this.cowsCountLabel.AutoSize = true;
            this.cowsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cowsCountLabel.Location = new System.Drawing.Point(16, 178);
            this.cowsCountLabel.Name = "cowsCountLabel";
            this.cowsCountLabel.Size = new System.Drawing.Size(89, 20);
            this.cowsCountLabel.TabIndex = 3;
            this.cowsCountLabel.Text = "Коров = 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StepColumn,
            this.NumberColumn,
            this.bullsCountColumn,
            this.cowsCountColumn});
            this.historyDataGridView.Location = new System.Drawing.Point(249, 12);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.Size = new System.Drawing.Size(444, 247);
            this.historyDataGridView.TabIndex = 5;
            // 
            // StepColumn
            // 
            this.StepColumn.HeaderText = "Ход";
            this.StepColumn.Name = "StepColumn";
            // 
            // NumberColumn
            // 
            this.NumberColumn.HeaderText = "Число";
            this.NumberColumn.Name = "NumberColumn";
            // 
            // bullsCountColumn
            // 
            this.bullsCountColumn.HeaderText = "Быков";
            this.bullsCountColumn.Name = "bullsCountColumn";
            // 
            // cowsCountColumn
            // 
            this.cowsCountColumn.HeaderText = "Коров";
            this.cowsCountColumn.Name = "cowsCountColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 271);
            this.Controls.Add(this.historyDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cowsCountLabel);
            this.Controls.Add(this.bullsCountLabel);
            this.Controls.Add(this.userWordTextBox);
            this.Controls.Add(this.puzzledWordLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label puzzledWordLabel;
        private System.Windows.Forms.TextBox userWordTextBox;
        private System.Windows.Forms.Label bullsCountLabel;
        private System.Windows.Forms.Label cowsCountLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView historyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bullsCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cowsCountColumn;
    }
}

