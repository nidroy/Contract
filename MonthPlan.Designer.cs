namespace Contract
{
    partial class MonthPlan
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
            price = new TextBox();
            label2 = new Label();
            label1 = new Label();
            month = new TextBox();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // price
            // 
            price.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            price.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(254, 12);
            price.Name = "price";
            price.ReadOnly = true;
            price.Size = new Size(100, 25);
            price.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 8;
            label2.Text = "Mесяц:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(174, 15);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 7;
            label1.Text = "Стоимость:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // month
            // 
            month.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            month.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            month.Location = new Point(68, 12);
            month.Name = "month";
            month.ReadOnly = true;
            month.Size = new Size(100, 25);
            month.TabIndex = 6;
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
            dataGridView.TabIndex = 5;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // MonthPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 441);
            Controls.Add(price);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(month);
            Controls.Add(dataGridView);
            Name = "MonthPlan";
            Text = "План на месяц";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox price;
        private Label label2;
        private Label label1;
        private TextBox month;
        private DataGridView dataGridView;
    }
}