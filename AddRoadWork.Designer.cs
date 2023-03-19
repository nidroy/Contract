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
            splitContainer3 = new SplitContainer();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            showRoadWorkButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoadWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewMaterial
            // 
            dataGridViewMaterial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMaterial.Dock = DockStyle.Fill;
            dataGridViewMaterial.Location = new Point(0, 0);
            dataGridViewMaterial.Name = "dataGridViewMaterial";
            dataGridViewMaterial.ReadOnly = true;
            dataGridViewMaterial.RowTemplate.Height = 25;
            dataGridViewMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMaterial.Size = new Size(397, 264);
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
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(397, 25);
            label5.TabIndex = 13;
            label5.Text = "Материалы";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewRoadWork
            // 
            dataGridViewRoadWork.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewRoadWork.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoadWork.Dock = DockStyle.Fill;
            dataGridViewRoadWork.Location = new Point(0, 0);
            dataGridViewRoadWork.Name = "dataGridViewRoadWork";
            dataGridViewRoadWork.ReadOnly = true;
            dataGridViewRoadWork.RowTemplate.Height = 25;
            dataGridViewRoadWork.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRoadWork.Size = new Size(359, 264);
            dataGridViewRoadWork.TabIndex = 14;
            dataGridViewRoadWork.CellClick += dataGridViewRoadWork_CellClick;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ControlLight;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(359, 25);
            label6.TabIndex = 15;
            label6.Text = "Дорожные работы";
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
            updateRoadWorkButton.Size = new Size(242, 25);
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
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.AutoScroll = true;
            splitContainer3.Panel1.Controls.Add(label6);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.AutoScroll = true;
            splitContainer3.Panel2.Controls.Add(dataGridViewRoadWork);
            splitContainer3.Size = new Size(359, 293);
            splitContainer3.SplitterDistance = 25;
            splitContainer3.TabIndex = 19;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(12, 136);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.Controls.Add(splitContainer3);
            splitContainer1.Size = new Size(760, 293);
            splitContainer1.SplitterDistance = 397;
            splitContainer1.TabIndex = 20;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = SystemColors.Control;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.AutoScroll = true;
            splitContainer2.Panel1.BackColor = SystemColors.ControlLight;
            splitContainer2.Panel1.Controls.Add(label5);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.AutoScroll = true;
            splitContainer2.Panel2.Controls.Add(dataGridViewMaterial);
            splitContainer2.Size = new Size(397, 293);
            splitContainer2.SplitterDistance = 25;
            splitContainer2.TabIndex = 21;
            // 
            // showRoadWorkButton
            // 
            showRoadWorkButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showRoadWorkButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            showRoadWorkButton.Location = new Point(530, 105);
            showRoadWorkButton.Name = "showRoadWorkButton";
            showRoadWorkButton.Size = new Size(242, 25);
            showRoadWorkButton.TabIndex = 21;
            showRoadWorkButton.Text = "Показать дорожную работу";
            showRoadWorkButton.UseVisualStyleBackColor = true;
            showRoadWorkButton.Click += showRoadWorkButton_Click;
            // 
            // AddRoadWork
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 441);
            Controls.Add(showRoadWorkButton);
            Controls.Add(updateRoadWorkButton);
            Controls.Add(splitContainer1);
            Controls.Add(label7);
            Controls.Add(addRoadWorkButton);
            Controls.Add(roadWorkName);
            Controls.Add(label4);
            Controls.Add(addMaterialButton);
            Controls.Add(label3);
            Controls.Add(materialPrice);
            Controls.Add(materialUnit);
            Controls.Add(label1);
            Controls.Add(materialName);
            Controls.Add(label2);
            Name = "AddRoadWork";
            Text = "Добавить дорожную работу";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMaterial).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoadWork).EndInit();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
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
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button showRoadWorkButton;
    }
}