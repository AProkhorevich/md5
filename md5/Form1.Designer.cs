
namespace md5
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
            this.calculateHash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceMessageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceMessageHashLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateHash
            // 
            this.calculateHash.Location = new System.Drawing.Point(56, 206);
            this.calculateHash.Name = "calculateHash";
            this.calculateHash.Size = new System.Drawing.Size(231, 93);
            this.calculateHash.TabIndex = 0;
            this.calculateHash.Text = "создать хэш";
            this.calculateHash.UseVisualStyleBackColor = true;
            this.calculateHash.Click += new System.EventHandler(this.calculateHash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Результат хэширования";
            // 
            // sourceMessageTextBox
            // 
            this.sourceMessageTextBox.Location = new System.Drawing.Point(200, 67);
            this.sourceMessageTextBox.Name = "sourceMessageTextBox";
            this.sourceMessageTextBox.Size = new System.Drawing.Size(308, 20);
            this.sourceMessageTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Исходное сообщение:";
            // 
            // sourceMessageHashLabel
            // 
            this.sourceMessageHashLabel.AutoSize = true;
            this.sourceMessageHashLabel.Location = new System.Drawing.Point(202, 113);
            this.sourceMessageHashLabel.Name = "sourceMessageHashLabel";
            this.sourceMessageHashLabel.Size = new System.Drawing.Size(0, 13);
            this.sourceMessageHashLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sourceMessageHashLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sourceMessageTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateHash);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sourceMessageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sourceMessageHashLabel;
    }
}

