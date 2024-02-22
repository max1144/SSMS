namespace Спаровочник_аптекаря
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.apteki = new System.Windows.Forms.Button();
            this.ckladi = new System.Windows.Forms.Button();
            this.lekarctva = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apteki
            // 
            this.apteki.Location = new System.Drawing.Point(202, 184);
            this.apteki.Name = "apteki";
            this.apteki.Size = new System.Drawing.Size(75, 23);
            this.apteki.TabIndex = 0;
            this.apteki.Text = "Аптеки";
            this.apteki.UseVisualStyleBackColor = true;
            this.apteki.Click += new System.EventHandler(this.apteki_Click);
            // 
            // ckladi
            // 
            this.ckladi.Location = new System.Drawing.Point(513, 184);
            this.ckladi.Name = "ckladi";
            this.ckladi.Size = new System.Drawing.Size(75, 23);
            this.ckladi.TabIndex = 1;
            this.ckladi.Text = "Склады";
            this.ckladi.UseVisualStyleBackColor = true;
            this.ckladi.Click += new System.EventHandler(this.ckladi_Click);
            // 
            // lekarctva
            // 
            this.lekarctva.Location = new System.Drawing.Point(366, 184);
            this.lekarctva.Name = "lekarctva";
            this.lekarctva.Size = new System.Drawing.Size(75, 23);
            this.lekarctva.TabIndex = 2;
            this.lekarctva.Text = "Лекарства";
            this.lekarctva.UseVisualStyleBackColor = true;
            this.lekarctva.Click += new System.EventHandler(this.lekarctva_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Наличие лекарств в аптеке";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Наличие лекарств в складе";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(639, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lekarctva);
            this.Controls.Add(this.ckladi);
            this.Controls.Add(this.apteki);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник аптекаря";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button apteki;
        private System.Windows.Forms.Button ckladi;
        private System.Windows.Forms.Button lekarctva;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

