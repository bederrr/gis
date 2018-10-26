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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButtonSelect = new System.Windows.Forms.ToolStripButton();
            this.ButtonPan = new System.Windows.Forms.ToolStripButton();
            this.ButtonZoomIn = new System.Windows.Forms.ToolStripButton();
            this.ButtonZoomOut = new System.Windows.Forms.ToolStripButton();
            this.map1 = new MiniGis.Map();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelMapCursorPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonSelect,
            this.ButtonPan,
            this.ButtonZoomIn,
            this.ButtonZoomOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(988, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonSelect.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSelect.Image")));
            this.ButtonSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(24, 24);
            this.ButtonSelect.Text = "toolStripButton1";
            this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // ButtonPan
            // 
            this.ButtonPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonPan.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPan.Image")));
            this.ButtonPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonPan.Name = "ButtonPan";
            this.ButtonPan.Size = new System.Drawing.Size(24, 24);
            this.ButtonPan.Text = "toolStripButton2";
            this.ButtonPan.Click += new System.EventHandler(this.ButtonPan_Click);
            // 
            // ButtonZoomIn
            // 
            this.ButtonZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("ButtonZoomIn.Image")));
            this.ButtonZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonZoomIn.Name = "ButtonZoomIn";
            this.ButtonZoomIn.Size = new System.Drawing.Size(24, 24);
            this.ButtonZoomIn.Text = "toolStripButton3";
            this.ButtonZoomIn.Click += new System.EventHandler(this.ButtonZoomIn_Click);
            // 
            // ButtonZoomOut
            // 
            this.ButtonZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("ButtonZoomOut.Image")));
            this.ButtonZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonZoomOut.Name = "ButtonZoomOut";
            this.ButtonZoomOut.Size = new System.Drawing.Size(24, 24);
            this.ButtonZoomOut.Text = "toolStripButton4";
            this.ButtonZoomOut.Click += new System.EventHandler(this.ButtonZoomOut_Click);
            // 
            // map1
            // 
            this.map1.ActiveTool = MiniGis.MapToolType.Select;
            this.map1.BackColor = System.Drawing.SystemColors.Window;
            this.map1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map1.Location = new System.Drawing.Point(0, 0);
            this.map1.MapScale = 1D;
            this.map1.Margin = new System.Windows.Forms.Padding(5);
            this.map1.Name = "map1";
            this.map1.Size = new System.Drawing.Size(988, 554);
            this.map1.TabIndex = 0;
            this.map1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.map1_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelMapCursorPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(988, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LabelMapCursorPosition
            // 
            this.LabelMapCursorPosition.Name = "LabelMapCursorPosition";
            this.LabelMapCursorPosition.Size = new System.Drawing.Size(151, 20);
            this.LabelMapCursorPosition.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 554);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.map1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Map map1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ButtonSelect;
        private System.Windows.Forms.ToolStripButton ButtonPan;
        private System.Windows.Forms.ToolStripButton ButtonZoomIn;
        private System.Windows.Forms.ToolStripButton ButtonZoomOut;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LabelMapCursorPosition;
    }
}

