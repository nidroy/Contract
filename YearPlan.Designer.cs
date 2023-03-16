namespace Contract
{
    partial class YearPlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            year = new TextBox();
            label1 = new Label();
            label2 = new Label();
            price = new TextBox();
            updateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 43);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(760, 386);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // year
            // 
            year.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            year.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            year.Location = new Point(50, 12);
            year.Name = "year";
            year.ReadOnly = true;
            year.Size = new Size(100, 25);
            year.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(156, 15);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 2;
            label1.Text = "Стоимость:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 3;
            label2.Text = "Год:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // price
            // 
            price.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            price.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(236, 12);
            price.Name = "price";
            price.ReadOnly = true;
            price.Size = new Size(100, 25);
            price.TabIndex = 4;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            updateButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton.Location = new Point(672, 12);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(100, 25);
            updateButton.TabIndex = 5;
            updateButton.Text = "Обновить";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // YearPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 441);
            Controls.Add(updateButton);
            Controls.Add(price);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(year);
            Controls.Add(dataGridView);
            Name = "YearPlan";
            Text = "План на год";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private TextBox year;
        private Label label1;
        private Label label2;
        private TextBox price;
        private Button updateButton;
    }
}