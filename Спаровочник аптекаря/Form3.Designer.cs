namespace Спаровочник_аптекаря
{
    partial class Form3
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
            this.кодскладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.областьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.улицаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.складыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lukyanenkoDataSet = new Спаровочник_аптекаря.lukyanenkoDataSet();
            this.складыTableAdapter = new Спаровочник_аптекаря.lukyanenkoDataSetTableAdapters.складыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lukyanenkoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодскладаDataGridViewTextBoxColumn,
            this.областьDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn,
            this.улицаDataGridViewTextBoxColumn,
            this.домаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.складыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодскладаDataGridViewTextBoxColumn
            // 
            this.кодскладаDataGridViewTextBoxColumn.DataPropertyName = "код_склада";
            this.кодскладаDataGridViewTextBoxColumn.HeaderText = "код_склада";
            this.кодскладаDataGridViewTextBoxColumn.Name = "кодскладаDataGridViewTextBoxColumn";
            this.кодскладаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // областьDataGridViewTextBoxColumn
            // 
            this.областьDataGridViewTextBoxColumn.DataPropertyName = "область";
            this.областьDataGridViewTextBoxColumn.HeaderText = "область";
            this.областьDataGridViewTextBoxColumn.Name = "областьDataGridViewTextBoxColumn";
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "город";
            this.городDataGridViewTextBoxColumn.HeaderText = "город";
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            // 
            // улицаDataGridViewTextBoxColumn
            // 
            this.улицаDataGridViewTextBoxColumn.DataPropertyName = "улица";
            this.улицаDataGridViewTextBoxColumn.HeaderText = "улица";
            this.улицаDataGridViewTextBoxColumn.Name = "улицаDataGridViewTextBoxColumn";
            // 
            // домаDataGridViewTextBoxColumn
            // 
            this.домаDataGridViewTextBoxColumn.DataPropertyName = "№_дома";
            this.домаDataGridViewTextBoxColumn.HeaderText = "№_дома";
            this.домаDataGridViewTextBoxColumn.Name = "домаDataGridViewTextBoxColumn";
            // 
            // складыBindingSource
            // 
            this.складыBindingSource.DataMember = "склады";
            this.складыBindingSource.DataSource = this.lukyanenkoDataSet;
            // 
            // lukyanenkoDataSet
            // 
            this.lukyanenkoDataSet.DataSetName = "lukyanenkoDataSet";
            this.lukyanenkoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // складыTableAdapter
            // 
            this.складыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lukyanenkoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private lukyanenkoDataSet lukyanenkoDataSet;
        private System.Windows.Forms.BindingSource складыBindingSource;
        private lukyanenkoDataSetTableAdapters.складыTableAdapter складыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодскладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn областьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn улицаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}