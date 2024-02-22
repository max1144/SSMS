namespace Спаровочник_аптекаря
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодлекарстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиелекарстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.лекарственнаяформаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.производительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.характеристикиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокхранениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.лекарстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lukyanenkoDataSet = new Спаровочник_аптекаря.lukyanenkoDataSet();
            this.лекарстваTableAdapter = new Спаровочник_аптекаря.lukyanenkoDataSetTableAdapters.лекарстваTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lukyanenkoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодлекарстваDataGridViewTextBoxColumn,
            this.названиелекарстваDataGridViewTextBoxColumn,
            this.лекарственнаяформаDataGridViewTextBoxColumn,
            this.фотоDataGridViewImageColumn,
            this.производительDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.характеристикиDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn,
            this.срокхранениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.лекарстваBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // кодлекарстваDataGridViewTextBoxColumn
            // 
            this.кодлекарстваDataGridViewTextBoxColumn.DataPropertyName = "код_лекарства";
            this.кодлекарстваDataGridViewTextBoxColumn.HeaderText = "код_лекарства";
            this.кодлекарстваDataGridViewTextBoxColumn.Name = "кодлекарстваDataGridViewTextBoxColumn";
            this.кодлекарстваDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиелекарстваDataGridViewTextBoxColumn
            // 
            this.названиелекарстваDataGridViewTextBoxColumn.DataPropertyName = "название_лекарства";
            this.названиелекарстваDataGridViewTextBoxColumn.HeaderText = "название_лекарства";
            this.названиелекарстваDataGridViewTextBoxColumn.Name = "названиелекарстваDataGridViewTextBoxColumn";
            // 
            // лекарственнаяформаDataGridViewTextBoxColumn
            // 
            this.лекарственнаяформаDataGridViewTextBoxColumn.DataPropertyName = "лекарственная_форма";
            this.лекарственнаяформаDataGridViewTextBoxColumn.HeaderText = "лекарственная_форма";
            this.лекарственнаяформаDataGridViewTextBoxColumn.Name = "лекарственнаяформаDataGridViewTextBoxColumn";
            // 
            // фотоDataGridViewImageColumn
            // 
            this.фотоDataGridViewImageColumn.DataPropertyName = "фото";
            this.фотоDataGridViewImageColumn.HeaderText = "фото";
            this.фотоDataGridViewImageColumn.Name = "фотоDataGridViewImageColumn";
            // 
            // производительDataGridViewTextBoxColumn
            // 
            this.производительDataGridViewTextBoxColumn.DataPropertyName = "производитель";
            this.производительDataGridViewTextBoxColumn.HeaderText = "производитель";
            this.производительDataGridViewTextBoxColumn.Name = "производительDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // характеристикиDataGridViewTextBoxColumn
            // 
            this.характеристикиDataGridViewTextBoxColumn.DataPropertyName = "характеристики";
            this.характеристикиDataGridViewTextBoxColumn.HeaderText = "характеристики";
            this.характеристикиDataGridViewTextBoxColumn.Name = "характеристикиDataGridViewTextBoxColumn";
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            // 
            // срокхранениеDataGridViewTextBoxColumn
            // 
            this.срокхранениеDataGridViewTextBoxColumn.DataPropertyName = "срок_хранение";
            this.срокхранениеDataGridViewTextBoxColumn.HeaderText = "срок_хранение";
            this.срокхранениеDataGridViewTextBoxColumn.Name = "срокхранениеDataGridViewTextBoxColumn";
            // 
            // лекарстваBindingSource
            // 
            this.лекарстваBindingSource.DataMember = "лекарства";
            this.лекарстваBindingSource.DataSource = this.lukyanenkoDataSet;
            // 
            // lukyanenkoDataSet
            // 
            this.lukyanenkoDataSet.DataSetName = "lukyanenkoDataSet";
            this.lukyanenkoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // лекарстваTableAdapter
            // 
            this.лекарстваTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(964, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(965, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lukyanenkoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private lukyanenkoDataSet lukyanenkoDataSet;
        private System.Windows.Forms.BindingSource лекарстваBindingSource;
        private lukyanenkoDataSetTableAdapters.лекарстваTableAdapter лекарстваTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодлекарстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиелекарстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn лекарственнаяформаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn фотоDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn производительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn характеристикиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокхранениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}