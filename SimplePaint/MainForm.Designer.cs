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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ChangeColorLink = new System.Windows.Forms.LinkLabel();
            this.colorPanel1 = new System.Windows.Forms.Panel();
            this.colorPanel2 = new System.Windows.Forms.Panel();
            this.LayersListBox = new System.Windows.Forms.CheckedListBox();
            this.ModeToolStrip = new System.Windows.Forms.ToolStrip();
            this.ErraseButton = new System.Windows.Forms.ToolStripButton();
            this.BrushButton = new System.Windows.Forms.ToolStripButton();
            this.MainTools = new System.Windows.Forms.ToolStrip();
            this.AddLayerButton = new System.Windows.Forms.ToolStripButton();
            this.RemoveLayerButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewProjectTool = new System.Windows.Forms.ToolStripMenuItem();
            this.FromFileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.SavePicture = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PencilTool = new System.Windows.Forms.ToolStripMenuItem();
            this.BrushTool = new System.Windows.Forms.ToolStripMenuItem();
            this.EraserTool = new System.Windows.Forms.ToolStripMenuItem();
            this.LayersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddLayerTool = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveLayerTool = new System.Windows.Forms.ToolStripMenuItem();
            this.RenderTimer = new System.Windows.Forms.Timer(this.components);
            this.changeColor = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.RightToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(713, 383);
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
            this.toolStripContainer1.Size = new System.Drawing.Size(761, 408);
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
            this.splitContainer1.Panel2.Controls.Add(this.trackBar1);
            this.splitContainer1.Panel2.Controls.Add(this.ChangeColorLink);
            this.splitContainer1.Panel2.Controls.Add(this.colorPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.colorPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.LayersListBox);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.splitContainer1.Size = new System.Drawing.Size(713, 383);
            this.splitContainer1.SplitterDistance = 565;
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
            this.AnT.Size = new System.Drawing.Size(562, 377);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.Click += new System.EventHandler(this.AnT_Click);
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(14, 292);
            this.trackBar1.Maximum = 79;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(116, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickFrequency = 3;
            this.trackBar1.Value = 5;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // ChangeColorLink
            // 
            this.ChangeColorLink.AutoSize = true;
            this.ChangeColorLink.Location = new System.Drawing.Point(72, 343);
            this.ChangeColorLink.Name = "ChangeColorLink";
            this.ChangeColorLink.Size = new System.Drawing.Size(58, 13);
            this.ChangeColorLink.TabIndex = 3;
            this.ChangeColorLink.TabStop = true;
            this.ChangeColorLink.Text = "Поменять";
            this.ChangeColorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangeColorLink_LinkClicked);
            // 
            // colorPanel1
            // 
            this.colorPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel1.Location = new System.Drawing.Point(14, 343);
            this.colorPanel1.Name = "colorPanel1";
            this.colorPanel1.Size = new System.Drawing.Size(40, 40);
            this.colorPanel1.TabIndex = 2;
            this.colorPanel1.DoubleClick += new System.EventHandler(this.colorPanel1_DoubleClick);
            // 
            // colorPanel2
            // 
            this.colorPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel2.Location = new System.Drawing.Point(26, 356);
            this.colorPanel2.Name = "colorPanel2";
            this.colorPanel2.Size = new System.Drawing.Size(40, 40);
            this.colorPanel2.TabIndex = 1;
            // 
            // LayersListBox
            // 
            this.LayersListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayersListBox.FormattingEnabled = true;
            this.LayersListBox.Location = new System.Drawing.Point(0, 3);
            this.LayersListBox.Name = "LayersListBox";
            this.LayersListBox.Size = new System.Drawing.Size(141, 274);
            this.LayersListBox.TabIndex = 0;
            this.LayersListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LayersListBox_ItemCheck);
            this.LayersListBox.SelectedIndexChanged += new System.EventHandler(this.LayersListBox_SelectedIndexChanged);
            // 
            // ModeToolStrip
            // 
            this.ModeToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ModeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ErraseButton,
            this.BrushButton});
            this.ModeToolStrip.Location = new System.Drawing.Point(0, 3);
            this.ModeToolStrip.Name = "ModeToolStrip";
            this.ModeToolStrip.Size = new System.Drawing.Size(24, 57);
            this.ModeToolStrip.TabIndex = 0;
            // 
            // ErraseButton
            // 
            this.ErraseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ErraseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ErraseButton.Image = global::SimplePaint.Properties.Resources.errase_pic;
            this.ErraseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ErraseButton.Name = "ErraseButton";
            this.ErraseButton.Size = new System.Drawing.Size(22, 20);
            this.ErraseButton.Text = "Ластик";
            this.ErraseButton.Click += new System.EventHandler(this.ErraseButton_Click);
            // 
            // BrushButton
            // 
            this.BrushButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrushButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BrushButton.Image = global::SimplePaint.Properties.Resources.std_brush_pic;
            this.BrushButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BrushButton.Name = "BrushButton";
            this.BrushButton.Size = new System.Drawing.Size(22, 20);
            this.BrushButton.Text = "Кисть";
            this.BrushButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BrushButton.Click += new System.EventHandler(this.BrushButton_Click);
            // 
            // MainTools
            // 
            this.MainTools.Dock = System.Windows.Forms.DockStyle.None;
            this.MainTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddLayerButton,
            this.RemoveLayerButton});
            this.MainTools.Location = new System.Drawing.Point(0, 3);
            this.MainTools.Name = "MainTools";
            this.MainTools.Size = new System.Drawing.Size(24, 55);
            this.MainTools.TabIndex = 0;
            // 
            // AddLayerButton
            // 
            this.AddLayerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddLayerButton.Image = ((System.Drawing.Image)(resources.GetObject("AddLayerButton.Image")));
            this.AddLayerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddLayerButton.Name = "AddLayerButton";
            this.AddLayerButton.Size = new System.Drawing.Size(22, 19);
            this.AddLayerButton.Text = "+";
            this.AddLayerButton.Click += new System.EventHandler(this.AddLayerTool_Click);
            // 
            // RemoveLayerButton
            // 
            this.RemoveLayerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RemoveLayerButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveLayerButton.Image")));
            this.RemoveLayerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveLayerButton.Name = "RemoveLayerButton";
            this.RemoveLayerButton.Size = new System.Drawing.Size(22, 19);
            this.RemoveLayerButton.Text = "-";
            this.RemoveLayerButton.Click += new System.EventHandler(this.RemoveLayerTool_Click);
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
            this.NewProjectTool,
            this.FromFileTool,
            this.SavePicture,
            this.ExitTool});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(48, 20);
            this.FileMenu.Text = "Файл";
            // 
            // NewProjectTool
            // 
            this.NewProjectTool.Name = "NewProjectTool";
            this.NewProjectTool.Size = new System.Drawing.Size(157, 22);
            this.NewProjectTool.Text = "Чистый проект";
            this.NewProjectTool.Click += new System.EventHandler(this.NewProjectTool_Click);
            // 
            // FromFileTool
            // 
            this.FromFileTool.Name = "FromFileTool";
            this.FromFileTool.Size = new System.Drawing.Size(157, 22);
            this.FromFileTool.Text = "Из файла";
            this.FromFileTool.Click += new System.EventHandler(this.FromFileTool_Click);
            // 
            // SavePicture
            // 
            this.SavePicture.Name = "SavePicture";
            this.SavePicture.Size = new System.Drawing.Size(157, 22);
            this.SavePicture.Text = "Сохранить";
            this.SavePicture.Click += new System.EventHandler(this.SavePicture_Click);
            // 
            // ExitTool
            // 
            this.ExitTool.Name = "ExitTool";
            this.ExitTool.Size = new System.Drawing.Size(157, 22);
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
            this.PencilTool.Click += new System.EventHandler(this.PencilTool_Click);
            // 
            // BrushTool
            // 
            this.BrushTool.Name = "BrushTool";
            this.BrushTool.Size = new System.Drawing.Size(130, 22);
            this.BrushTool.Text = "Кисть";
            this.BrushTool.Click += new System.EventHandler(this.BrushTool_Click);
            // 
            // EraserTool
            // 
            this.EraserTool.Name = "EraserTool";
            this.EraserTool.Size = new System.Drawing.Size(130, 22);
            this.EraserTool.Text = "Ластик";
            this.EraserTool.Click += new System.EventHandler(this.EraserTool_Click);
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
            this.AddLayerTool.Click += new System.EventHandler(this.AddLayerTool_Click);
            // 
            // RemoveLayerTool
            // 
            this.RemoveLayerTool.Name = "RemoveLayerTool";
            this.RemoveLayerTool.Size = new System.Drawing.Size(156, 22);
            this.RemoveLayerTool.Text = "Удалить слой";
            this.RemoveLayerTool.Click += new System.EventHandler(this.RemoveLayerTool_Click);
            // 
            // RenderTimer
            // 
            this.RenderTimer.Interval = 10;
            this.RenderTimer.Tick += new System.EventHandler(this.RenderTimer_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 432);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(777, 470);
            this.MinimumSize = new System.Drawing.Size(777, 470);
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
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.ToolStrip MainTools;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
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
        private System.Windows.Forms.ToolStripButton AddLayerButton;
        private System.Windows.Forms.ToolStripButton RemoveLayerButton;
        private System.Windows.Forms.ToolStripButton ErraseButton;
        private System.Windows.Forms.ToolStripButton BrushButton;
        private System.Windows.Forms.ColorDialog changeColor;
        private System.Windows.Forms.LinkLabel ChangeColorLink;
        private System.Windows.Forms.Panel colorPanel1;
        private System.Windows.Forms.Panel colorPanel2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem NewProjectTool;
        private System.Windows.Forms.ToolStripMenuItem FromFileTool;
        private System.Windows.Forms.ToolStripMenuItem SavePicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

