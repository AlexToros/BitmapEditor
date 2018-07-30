namespace SimplePaint
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
            this.components = new System.ComponentModel.Container();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.LayersListBox = new System.Windows.Forms.CheckedListBox();
            this.ModeToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.MainTools = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewBitmapTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PencilTool = new System.Windows.Forms.ToolStripMenuItem();
            this.BrushTool = new System.Windows.Forms.ToolStripMenuItem();
            this.EraserTool = new System.Windows.Forms.ToolStripMenuItem();
            this.LayersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddLayerTool = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveLayerTool = new System.Windows.Forms.ToolStripMenuItem();
            this.RenderTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.RightToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ModeToolStrip.SuspendLayout();
            this.MainTools.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(713, 398);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.ModeToolStrip);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            this.toolStripContainer1.RightToolStripPanel.Controls.Add(this.MainTools);
            this.toolStripContainer1.Size = new System.Drawing.Size(761, 423);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AnT);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LayersListBox);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.splitContainer1.Size = new System.Drawing.Size(713, 398);
            this.splitContainer1.SplitterDistance = 566;
            this.splitContainer1.TabIndex = 0;
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.White;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnT.Location = new System.Drawing.Point(3, 3);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(563, 392);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            // 
            // LayersListBox
            // 
            this.LayersListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayersListBox.FormattingEnabled = true;
            this.LayersListBox.Location = new System.Drawing.Point(0, 3);
            this.LayersListBox.Name = "LayersListBox";
            this.LayersListBox.Size = new System.Drawing.Size(140, 229);
            this.LayersListBox.TabIndex = 0;
            // 
            // ModeToolStrip
            // 
            this.ModeToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ModeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.ModeToolStrip.Location = new System.Drawing.Point(0, 3);
            this.ModeToolStrip.Name = "ModeToolStrip";
            this.ModeToolStrip.Size = new System.Drawing.Size(24, 32);
            this.ModeToolStrip.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(22, 4);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(22, 4);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(22, 4);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // MainTools
            // 
            this.MainTools.Dock = System.Windows.Forms.DockStyle.None;
            this.MainTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton5});
            this.MainTools.Location = new System.Drawing.Point(0, 3);
            this.MainTools.Name = "MainTools";
            this.MainTools.Size = new System.Drawing.Size(24, 25);
            this.MainTools.TabIndex = 0;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(22, 4);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(22, 4);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.DrawingMenu,
            this.LayersMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBitmapTool,
            this.ExitTool});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(48, 20);
            this.FileMenu.Text = "Файл";
            // 
            // NewBitmapTool
            // 
            this.NewBitmapTool.Name = "NewBitmapTool";
            this.NewBitmapTool.Size = new System.Drawing.Size(161, 22);
            this.NewBitmapTool.Text = "Новый рисунок";
            // 
            // ExitTool
            // 
            this.ExitTool.Name = "ExitTool";
            this.ExitTool.Size = new System.Drawing.Size(161, 22);
            this.ExitTool.Text = "Выход";
            // 
            // DrawingMenu
            // 
            this.DrawingMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PencilTool,
            this.BrushTool,
            this.EraserTool});
            this.DrawingMenu.Name = "DrawingMenu";
            this.DrawingMenu.Size = new System.Drawing.Size(78, 20);
            this.DrawingMenu.Text = "Рисование";
            // 
            // PencilTool
            // 
            this.PencilTool.Name = "PencilTool";
            this.PencilTool.Size = new System.Drawing.Size(130, 22);
            this.PencilTool.Text = "Карандаш";
            // 
            // BrushTool
            // 
            this.BrushTool.Name = "BrushTool";
            this.BrushTool.Size = new System.Drawing.Size(130, 22);
            this.BrushTool.Text = "Кисть";
            // 
            // EraserTool
            // 
            this.EraserTool.Name = "EraserTool";
            this.EraserTool.Size = new System.Drawing.Size(130, 22);
            this.EraserTool.Text = "Ластик";
            // 
            // LayersMenu
            // 
            this.LayersMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddLayerTool,
            this.RemoveLayerTool});
            this.LayersMenu.Name = "LayersMenu";
            this.LayersMenu.Size = new System.Drawing.Size(48, 20);
            this.LayersMenu.Text = "Слои";
            // 
            // AddLayerTool
            // 
            this.AddLayerTool.Name = "AddLayerTool";
            this.AddLayerTool.Size = new System.Drawing.Size(156, 22);
            this.AddLayerTool.Text = "Добавить слой";
            // 
            // RemoveLayerTool
            // 
            this.RemoveLayerTool.Name = "RemoveLayerTool";
            this.RemoveLayerTool.Size = new System.Drawing.Size(156, 22);
            this.RemoveLayerTool.Text = "Удалить слой";
            // 
            // RenderTimer
            // 
            this.RenderTimer.Interval = 30;
            this.RenderTimer.Tick += new System.EventHandler(this.RenderTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 447);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Простой растровый редактор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.RightToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.RightToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ModeToolStrip.ResumeLayout(false);
            this.ModeToolStrip.PerformLayout();
            this.MainTools.ResumeLayout(false);
            this.MainTools.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip ModeToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStrip MainTools;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem NewBitmapTool;
        private System.Windows.Forms.ToolStripMenuItem ExitTool;
        private System.Windows.Forms.ToolStripMenuItem DrawingMenu;
        private System.Windows.Forms.ToolStripMenuItem PencilTool;
        private System.Windows.Forms.ToolStripMenuItem BrushTool;
        private System.Windows.Forms.ToolStripMenuItem EraserTool;
        private System.Windows.Forms.ToolStripMenuItem LayersMenu;
        private System.Windows.Forms.ToolStripMenuItem AddLayerTool;
        private System.Windows.Forms.ToolStripMenuItem RemoveLayerTool;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.CheckedListBox LayersListBox;
        private System.Windows.Forms.Timer RenderTimer;
    }
}

