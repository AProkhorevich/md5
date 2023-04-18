
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
            this.button1 = new System.Windows.Forms.Button();
            this.sourceLoginTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkLoginTextBox = new System.Windows.Forms.TextBox();
            this.checkPassTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateHash
            // 
            this.calculateHash.Location = new System.Drawing.Point(13, 183);
            this.calculateHash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateHash.Name = "calculateHash";
            this.calculateHash.Size = new System.Drawing.Size(308, 114);
            this.calculateHash.TabIndex = 0;
            this.calculateHash.Text = "создать хэш";
            this.calculateHash.UseVisualStyleBackColor = true;
            this.calculateHash.Click += new System.EventHandler(this.calculateHash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Результат хэширования";
            // 
            // sourceMessageTextBox
            // 
            this.sourceMessageTextBox.Location = new System.Drawing.Point(92, 85);
            this.sourceMessageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sourceMessageTextBox.Name = "sourceMessageTextBox";
            this.sourceMessageTextBox.Size = new System.Drawing.Size(409, 22);
            this.sourceMessageTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // sourceMessageHashLabel
            // 
            this.sourceMessageHashLabel.AutoSize = true;
            this.sourceMessageHashLabel.Location = new System.Drawing.Point(269, 139);
            this.sourceMessageHashLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sourceMessageHashLabel.Name = "sourceMessageHashLabel";
            this.sourceMessageHashLabel.Size = new System.Drawing.Size(0, 16);
            this.sourceMessageHashLabel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 183);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 114);
            this.button1.TabIndex = 5;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sourceLoginTextBox
            // 
            this.sourceLoginTextBox.Location = new System.Drawing.Point(92, 52);
            this.sourceLoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sourceLoginTextBox.Name = "sourceLoginTextBox";
            this.sourceLoginTextBox.Size = new System.Drawing.Size(409, 22);
            this.sourceLoginTextBox.TabIndex = 6;
            this.sourceLoginTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Логин";
            // 
            // checkLoginTextBox
            // 
            this.checkLoginTextBox.Location = new System.Drawing.Point(645, 52);
            this.checkLoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.checkLoginTextBox.Name = "checkLoginTextBox";
            this.checkLoginTextBox.Size = new System.Drawing.Size(409, 22);
            this.checkLoginTextBox.TabIndex = 8;
            // 
            // checkPassTextBox
            // 
            this.checkPassTextBox.Location = new System.Drawing.Point(645, 85);
            this.checkPassTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.checkPassTextBox.Name = "checkPassTextBox";
            this.checkPassTextBox.Size = new System.Drawing.Size(409, 22);
            this.checkPassTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Регистрация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(816, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Вход";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkPassTextBox);
            this.Controls.Add(this.checkLoginTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sourceLoginTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sourceMessageHashLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sourceMessageTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateHash);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sourceLoginTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox checkLoginTextBox;
        private System.Windows.Forms.TextBox checkPassTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

