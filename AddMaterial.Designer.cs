namespace Contract
{
    partial class AddMaterial
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
            label2 = new Label();
            name = new TextBox();
            label1 = new Label();
            unit = new TextBox();
            price = new TextBox();
            label3 = new Label();
            addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 136);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(760, 293);
            dataGridView.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 4;
            label2.Text = "Название:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            name.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(86, 12);
            name.Name = "name";
            name.Size = new Size(161, 25);
            name.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(129, 17);
            label1.TabIndex = 6;
            label1.Text = "Единица измерения:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // unit
            // 
            unit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            unit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            unit.Location = new Point(147, 43);
            unit.Name = "unit";
            unit.Size = new Size(100, 25);
            unit.TabIndex = 7;
            // 
            // price
            // 
            price.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            price.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(60, 74);
            price.Name = "price";
            price.Size = new Size(187, 25);
            price.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 9;
            label3.Text = "Цена:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(12, 105);
            addButton.Name = "addButton";
            addButton.Size = new Size(235, 25);
            addButton.TabIndex = 10;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // AddMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 441);
            Controls.Add(addButton);
            Controls.Add(label3);
            Controls.Add(price);
            Controls.Add(unit);
            Controls.Add(label1);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(dataGridView);
            Name = "AddMaterial";
            Text = "Добавить материал";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label label2;
        private TextBox name;
        private Label label1;
        private TextBox unit;
        private TextBox price;
        private Label label3;
        private Button addButton;
    }
}