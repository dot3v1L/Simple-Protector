namespace Simple_Protect
{
    partial class fMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.fPath = new System.Windows.Forms.TextBox();
            this.fOpen = new System.Windows.Forms.Button();
            this.fSave = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // fPath
            // 
            this.fPath.Location = new System.Drawing.Point(12, 12);
            this.fPath.Name = "fPath";
            this.fPath.Size = new System.Drawing.Size(167, 20);
            this.fPath.TabIndex = 0;
            // 
            // fOpen
            // 
            this.fOpen.Location = new System.Drawing.Point(197, 10);
            this.fOpen.Name = "fOpen";
            this.fOpen.Size = new System.Drawing.Size(75, 23);
            this.fOpen.TabIndex = 1;
            this.fOpen.Text = "File";
            this.fOpen.UseVisualStyleBackColor = true;
            this.fOpen.Click += new System.EventHandler(this.fOpen_Click);
            // 
            // fSave
            // 
            this.fSave.Location = new System.Drawing.Point(12, 70);
            this.fSave.Name = "fSave";
            this.fSave.Size = new System.Drawing.Size(260, 23);
            this.fSave.TabIndex = 2;
            this.fSave.Text = "Protect";
            this.fSave.UseVisualStyleBackColor = true;
            this.fSave.Click += new System.EventHandler(this.fSave_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Rename types";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(107, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(109, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Rename methods";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 104);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.fSave);
            this.Controls.Add(this.fOpen);
            this.Controls.Add(this.fPath);
            this.Name = "fMain";
            this.Text = "Simple Protect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fPath;
        private System.Windows.Forms.Button fOpen;
        private System.Windows.Forms.Button fSave;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

