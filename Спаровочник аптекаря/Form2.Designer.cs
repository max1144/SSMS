namespace Спаровочник_аптекаря
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.код_аптеки = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.областьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.улицаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аптекиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lukyanenkoDataSet = new Спаровочник_аптекаря.lukyanenkoDataSet();
            this.аптекиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аптекиTableAdapter = new Спаровочник_аптекаря.lukyanenkoDataSetTableAdapters.аптекиTableAdapter();
            this.fKналлекваптаптекиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.нал_лек_в_аптTableAdapter = new Спаровочник_аптекаря.lukyanenkoDataSetTableAdapters.нал_лек_в_аптTableAdapter();
            this.лекарстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.лекарстваTableAdapter = new Спаровочник_аптекаря.lukyanenkoDataSetTableAdapters.лекарстваTableAdapter();
            this.аптекиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lukyanenkoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKналлекваптаптекиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.код_аптеки,
            this.названиеDataGridViewTextBoxColumn,
            this.областьDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn,
            this.улицаDataGridViewTextBoxColumn,
            this.домаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.аптекиBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 426);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // код_аптеки
            // 
            this.код_аптеки.DataPropertyName = "код_аптеки";
            this.код_аптеки.HeaderText = "Номер аптеки";
            this.код_аптеки.Name = "код_аптеки";
            this.код_аптеки.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // областьDataGridViewTextBoxColumn
            // 
            this.областьDataGridViewTextBoxColumn.DataPropertyName = "область";
            this.областьDataGridViewTextBoxColumn.HeaderText = "Область";
            this.областьDataGridViewTextBoxColumn.Name = "областьDataGridViewTextBoxColumn";
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            // 
            // улицаDataGridViewTextBoxColumn
            // 
            this.улицаDataGridViewTextBoxColumn.DataPropertyName = "улица";
            this.улицаDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.улицаDataGridViewTextBoxColumn.Name = "улицаDataGridViewTextBoxColumn";
            // 
            // домаDataGridViewTextBoxColumn
            // 
            this.домаDataGridViewTextBoxColumn.DataPropertyName = "№_дома";
            this.домаDataGridViewTextBoxColumn.HeaderText = "№_дома";
            this.домаDataGridViewTextBoxColumn.Name = "домаDataGridViewTextBoxColumn";
            // 
            // аптекиBindingSource2
            // 
            this.аптекиBindingSource2.DataMember = "аптеки";
            this.аптекиBindingSource2.DataSource = this.lukyanenkoDataSet;
            // 
            // lukyanenkoDataSet
            // 
            this.lukyanenkoDataSet.DataSetName = "lukyanenkoDataSet";
            this.lukyanenkoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // аптекиBindingSource
            // 
            this.аптекиBindingSource.DataMember = "аптеки";
            this.аптекиBindingSource.DataSource = this.lukyanenkoDataSet;
            // 
            // аптекиTableAdapter
            // 
            this.аптекиTableAdapter.ClearBeforeFill = true;
            // 
            // fKналлекваптаптекиBindingSource
            // 
            this.fKналлекваптаптекиBindingSource.DataMember = "FK_нал_лек_в_апт_аптеки";
            this.fKналлекваптаптекиBindingSource.DataSource = this.аптекиBindingSource;
            // 
            // нал_лек_в_аптTableAdapter
            // 
            this.нал_лек_в_аптTableAdapter.ClearBeforeFill = true;
            // 
            // лекарстваBindingSource
            // 
            this.лекарстваBindingSource.DataMember = "лекарства";
            this.лекарстваBindingSource.DataSource = this.lukyanenkoDataSet;
            // 
            // лекарстваTableAdapter
            // 
            this.лекарстваTableAdapter.ClearBeforeFill = true;
            // 
            // аптекиBindingSource1
            // 
            this.аптекиBindingSource1.DataMember = "аптеки";
            this.аптекиBindingSource1.DataSource = this.lukyanenkoDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аптеки";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lukyanenkoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKналлекваптаптекиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.лекарстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аптекиBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private lukyanenkoDataSet lukyanenkoDataSet;
        private System.Windows.Forms.BindingSource аптекиBindingSource;
        private lukyanenkoDataSetTableAdapters.аптекиTableAdapter аптекиTableAdapter;
        private System.Windows.Forms.BindingSource fKналлекваптаптекиBindingSource;
        private lukyanenkoDataSetTableAdapters.нал_лек_в_аптTableAdapter нал_лек_в_аптTableAdapter;
        private System.Windows.Forms.BindingSource лекарстваBindingSource;
        private lukyanenkoDataSetTableAdapters.лекарстваTableAdapter лекарстваTableAdapter;
        private System.Windows.Forms.BindingSource аптекиBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn код_аптеки;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn областьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn улицаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource аптекиBindingSource2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}