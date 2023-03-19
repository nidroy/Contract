namespace Contract
{
    partial class AddRoadWork
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
            dataGridViewMaterial = new DataGridView();
            label2 = new Label();
            materialName = new TextBox();
            label1 = new Label();
            materialUnit = new TextBox();
            materialPrice = new TextBox();
            label3 = new Label();
            addMaterialButton = new Button();
            label4 = new Label();
            roadWorkName = new TextBox();
            label5 = new Label();
            dataGridViewRoadWork = new DataGridView();
            label6 = new Label();
            addRoadWorkButton = new Button();
            updateRoadWorkButton = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoadWork).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMaterial
            // 
            dataGridViewMaterial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewMaterial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterial.Location = new Point(12, 153);
            dataGridViewMaterial.Name = "dataGridViewMaterial";
            dataGridViewMaterial.ReadOnly = true;
            dataGridViewMaterial.RowTemplate.Height = 25;
            dataGridViewMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMaterial.Size = new Size(377, 276);
            dataGridViewMaterial.TabIndex = 1;
            dataGridViewMaterial.CellClick += dataGridViewMaterial_CellClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(136, 17);
            label2.TabIndex = 4;
            label2.Text = "Название материала:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialName
            // 
            materialName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            materialName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            materialName.Location = new Point(154, 12);
            materialName.Name = "materialName";
            materialName.Size = new Size(100, 25);
            materialName.TabIndex = 5;
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
            // materialUnit
            // 
            materialUnit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            materialUnit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            materialUnit.Location = new Point(147, 43);
            materialUnit.Name = "materialUnit";
            materialUnit.Size = new Size(107, 25);
            materialUnit.TabIndex = 7;
            // 
            // materialPrice
            // 
            materialPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            materialPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            materialPrice.Location = new Point(128, 74);
            materialPrice.Name = "materialPrice";
            materialPrice.Size = new Size(126, 25);
            materialPrice.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(110, 17);
            label3.TabIndex = 9;
            label3.Text = "Цена материала:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addMaterialButton
            // 
            addMaterialButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addMaterialButton.Location = new Point(12, 105);
            addMaterialButton.Name = "addMaterialButton";
            addMaterialButton.Size = new Size(242, 25);
            addMaterialButton.TabIndex = 10;
            addMaterialButton.Text = "Добавить материал";
            addMaterialButton.UseVisualStyleBackColor = true;
            addMaterialButton.Click += addMaterialButton_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(260, 15);
            label4.Name = "label4";
            label4.Size = new Size(183, 17);
            label4.TabIndex = 11;
            label4.Text = "Название дорожной работы:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roadWorkName
            // 
            roadWorkName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            roadWorkName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            roadWorkName.Location = new Point(449, 12);
            roadWorkName.Name = "roadWorkName";
            roadWorkName.Size = new Size(100, 25);
            roadWorkName.TabIndex = 12;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 133);
            label5.Name = "label5";
            label5.Size = new Size(80, 17);
            label5.TabIndex = 13;
            label5.Text = "Материалы:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewRoadWork
            // 
            dataGridViewRoadWork.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewRoadWork.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewRoadWork.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoadWork.Location = new Point(395, 153);
            dataGridViewRoadWork.Name = "dataGridViewRoadWork";
            dataGridViewRoadWork.ReadOnly = true;
            dataGridViewRoadWork.RowTemplate.Height = 25;
            dataGridViewRoadWork.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRoadWork.Size = new Size(377, 276);
            dataGridViewRoadWork.TabIndex = 14;
            dataGridViewRoadWork.CellClick += dataGridViewRoadWork_CellClick;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(395, 133);
            label6.Name = "label6";
            label6.Size = new Size(125, 17);
            label6.TabIndex = 15;
            label6.Text = "Дорожные работы:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addRoadWorkButton
            // 
            addRoadWorkButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addRoadWorkButton.Location = new Point(260, 43);
            addRoadWorkButton.Name = "addRoadWorkButton";
            addRoadWorkButton.Size = new Size(289, 25);
            addRoadWorkButton.TabIndex = 16;
            addRoadWorkButton.Text = "Добавить дорожную работу";
            addRoadWorkButton.UseVisualStyleBackColor = true;
            addRoadWorkButton.Click += addRoadWorkButton_Click;
            // 
            // updateRoadWorkButton
            // 
            updateRoadWorkButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            updateRoadWorkButton.Location = new Point(260, 105);
            updateRoadWorkButton.Name = "updateRoadWorkButton";
            updateRoadWorkButton.Size = new Size(289, 25);
            updateRoadWorkButton.TabIndex = 17;
            updateRoadWorkButton.Text = "Обновить дорожную работу";
            updateRoadWorkButton.UseVisualStyleBackColor = true;
            updateRoadWorkButton.Click += updateRoadWorkButton_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(260, 77);
            label7.Name = "label7";
            label7.Size = new Size(314, 17);
            label7.TabIndex = 18;
            label7.Text = "Выберите материал и дорожную работу из таблиц";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddRoadWork
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 441);
            Controls.Add(label7);
            Controls.Add(updateRoadWorkButton);
            Controls.Add(addRoadWorkButton);
            Controls.Add(label6);
            Controls.Add(dataGridViewRoadWork);
            Controls.Add(label5);
            Controls.Add(roadWorkName);
            Controls.Add(label4);
            Controls.Add(addMaterialButton);
            Controls.Add(label3);
            Controls.Add(materialPrice);
            Controls.Add(materialUnit);
            Controls.Add(label1);
            Controls.Add(materialName);
            Controls.Add(label2);
            Controls.Add(dataGridViewMaterial);
            Name = "AddRoadWork";
            Text = "Добавить дорожную работу";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoadWork).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMaterial;
        private Label label2;
        private TextBox materialName;
        private Label label1;
        private TextBox materialUnit;
        private TextBox materialPrice;
        private Label label3;
        private Button addMaterialButton;
        private Label label4;
        private TextBox roadWorkName;
        private Label label5;
        private DataGridView dataGridViewRoadWork;
        private Label label6;
        private Button addRoadWorkButton;
        private Button updateRoadWorkButton;
        private Label label7;
    }
}