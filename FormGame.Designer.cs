namespace Labirint
{
    partial class FormGame
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
            this.dataGridViewLabirint = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLabirint)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLabirint
            // 
            this.dataGridViewLabirint.AllowUserToAddRows = false;
            this.dataGridViewLabirint.AllowUserToDeleteRows = false;
            this.dataGridViewLabirint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLabirint.ColumnHeadersVisible = false;
            this.dataGridViewLabirint.Location = new System.Drawing.Point(-5, 0);
            this.dataGridViewLabirint.Name = "dataGridViewLabirint";
            this.dataGridViewLabirint.ReadOnly = true;
            this.dataGridViewLabirint.RowHeadersVisible = false;
            this.dataGridViewLabirint.RowHeadersWidth = 62;
            this.dataGridViewLabirint.RowTemplate.Height = 40;
            this.dataGridViewLabirint.Size = new System.Drawing.Size(277, 346);
            this.dataGridViewLabirint.TabIndex = 0;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 416);
            this.Controls.Add(this.dataGridViewLabirint);
            this.Name = "FormGame";
            this.Text = "Лабиринт";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLabirint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLabirint;
    }
}

