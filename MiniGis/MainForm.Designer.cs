namespace MiniGis
{
    partial class MainForm
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
            this.ButtonZoomIn = new System.Windows.Forms.Button();
            this.ButtonZoomOut = new System.Windows.Forms.Button();
            this.map1 = new MiniGis.Map();
            this.SuspendLayout();
            // 
            // ButtonZoomIn
            // 
            this.ButtonZoomIn.Location = new System.Drawing.Point(12, 25);
            this.ButtonZoomIn.Name = "ButtonZoomIn";
            this.ButtonZoomIn.Size = new System.Drawing.Size(52, 48);
            this.ButtonZoomIn.TabIndex = 1;
            this.ButtonZoomIn.Text = "+";
            this.ButtonZoomIn.UseVisualStyleBackColor = true;
            this.ButtonZoomIn.Click += new System.EventHandler(this.ButtonZoomIn_Click);
            // 
            // ButtonZoomOut
            // 
            this.ButtonZoomOut.Location = new System.Drawing.Point(12, 96);
            this.ButtonZoomOut.Name = "ButtonZoomOut";
            this.ButtonZoomOut.Size = new System.Drawing.Size(52, 47);
            this.ButtonZoomOut.TabIndex = 2;
            this.ButtonZoomOut.Text = "-";
            this.ButtonZoomOut.UseVisualStyleBackColor = true;
            this.ButtonZoomOut.Click += new System.EventHandler(this.ButtonZoomOut_Click);
            // 
            // map1
            // 
            this.map1.BackColor = System.Drawing.SystemColors.Window;
            this.map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map1.Location = new System.Drawing.Point(0, 0);
            this.map1.MapScale = 1D;
            this.map1.Margin = new System.Windows.Forms.Padding(5);
            this.map1.Name = "map1";
            this.map1.Size = new System.Drawing.Size(1033, 641);
            this.map1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 641);
            this.Controls.Add(this.ButtonZoomOut);
            this.Controls.Add(this.ButtonZoomIn);
            this.Controls.Add(this.map1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Map map1;
        private System.Windows.Forms.Button ButtonZoomIn;
        private System.Windows.Forms.Button ButtonZoomOut;
    }
}

