namespace Contract
{
    partial class ThreeYearPlan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            addButton = new Button();
            comboBox = new ComboBox();
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
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(243, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 25);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // comboBox
            // 
            comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox.DropDownHeight = 125;
            comboBox.DropDownWidth = 225;
            comboBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox.FormattingEnabled = true;
            comboBox.IntegralHeight = false;
            comboBox.Items.AddRange(new object[] { "Добавить материал", "Добавить дорожную работу", "Добавить дорожный объект", "Добавить задачу куратора", "Добавить отчет подрядчика", "Добавить отчет куратора", "Обновить план на год", "Обновить трехлетний план" });
            comboBox.Location = new Point(12, 12);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(225, 25);
            comboBox.TabIndex = 2;
            comboBox.Text = "Обновление плана";
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            updateButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton.Location = new Point(672, 12);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(100, 25);
            updateButton.TabIndex = 3;
            updateButton.Text = "Обновить";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // ThreeYearPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 441);
            Controls.Add(updateButton);
            Controls.Add(comboBox);
            Controls.Add(addButton);
            Controls.Add(dataGridView);
            Name = "ThreeYearPlan";
            Text = "Трехлетние планы";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Button addButton;
        private ComboBox comboBox;
        private Button updateButton;
    }
}