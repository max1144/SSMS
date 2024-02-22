namespace Спаровочник_аптекаря
{
    partial class Form5
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
            this.кодаптекиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодлекарстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наллекваптBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lukyanenkoDataSet = new Спаровочник_аптекаря.lukyanenkoDataSet();
            this.нал_лек_в_аптTableAdapter = new Спаровочник_аптекаря.lukyanenkoDataSetTableAdapters.нал_лек_в_аптTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.наллекваптBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lukyanenkoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодаптекиDataGridViewTextBoxColumn,
            this.кодлекарстваDataGridViewTextBoxColumn,
            this.наличиеDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.наллекваптBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодаптекиDataGridViewTextBoxColumn
            // 
            this.кодаптекиDataGridViewTextBoxColumn.DataPropertyName = "код_аптеки";
            this.кодаптекиDataGridViewTextBoxColumn.HeaderText = "код_аптеки";
            this.кодаптекиDataGridViewTextBoxColumn.Name = "кодаптекиDataGridViewTextBoxColumn";
            // 
            // кодлекарстваDataGridViewTextBoxColumn
            // 
            this.кодлекарстваDataGridViewTextBoxColumn.DataPropertyName = "код_лекарства";
            this.кодлекарстваDataGridViewTextBoxColumn.HeaderText = "код_лекарства";
            this.кодлекарстваDataGridViewTextBoxColumn.Name = "кодлекарстваDataGridViewTextBoxColumn";
            // 
            // наличиеDataGridViewTextBoxColumn
            // 
            this.наличиеDataGridViewTextBoxColumn.DataPropertyName = "наличие";
            this.наличиеDataGridViewTextBoxColumn.HeaderText = "наличие";
            this.наличиеDataGridViewTextBoxColumn.Name = "наличиеDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // наллекваптBindingSource
            // 
            this.наллекваптBindingSource.DataMember = "нал_лек_в_апт";
            this.наллекваптBindingSource.DataSource = this.lukyanenkoDataSet;
            // 
            // lukyanenkoDataSet
            // 
            this.lukyanenkoDataSet.DataSetName = "lukyanenkoDataSet";
            this.lukyanenkoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // нал_лек_в_аптTableAdapter
            // 
            this.нал_лек_в_аптTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(473, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.наллекваптBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lukyanenkoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private lukyanenkoDataSet lukyanenkoDataSet;
        private System.Windows.Forms.BindingSource наллекваптBindingSource;
        private lukyanenkoDataSetTableAdapters.нал_лек_в_аптTableAdapter нал_лек_в_аптTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодаптекиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодлекарстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наличиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}