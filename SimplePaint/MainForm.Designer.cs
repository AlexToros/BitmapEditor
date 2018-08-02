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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorPanel1 = new System.Windows.Forms.Panel();
            this.LayersListBox = new System.Windows.Forms.CheckedListBox();
            this.colorPanel2 = new System.Windows.Forms.Panel();
            this.ChangeColorLink = new System.Windows.Forms.LinkLabel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(817, 478);
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
            this.toolStripContainer1.Size = new System.Drawing.Size(865, 478);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AnT, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 478);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.colorPanel1);
            this.panel1.Controls.Add(this.LayersListBox);
            this.panel1.Controls.Add(this.colorPanel2);
            this.panel1.Controls.Add(this.ChangeColorLink);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(662, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 472);
            this.panel1.TabIndex = 6;
            // 
            // colorPanel1
            // 
            this.colorPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel1.Location = new System.Drawing.Point(12, 410);
            this.colorPanel1.Name = "colorPanel1";
            this.colorPanel1.Size = new System.Drawing.Size(40, 40);
            this.colorPanel1.TabIndex = 2;
            this.colorPanel1.DoubleClick += new System.EventHandler(this.colorPanel1_DoubleClick);
            // 
            // LayersListBox
            // 
            this.LayersListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayersListBox.FormattingEnabled = true;
            this.LayersListBox.Location = new System.Drawing.Point(0, 0);
            this.LayersListBox.Name = "LayersListBox";
            this.LayersListBox.Size = new System.Drawing.Size(152, 349);
            this.LayersListBox.TabIndex = 0;
            this.LayersListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LayersListBox_ItemCheck);
            this.LayersListBox.SelectedIndexChanged += new System.EventHandler(this.LayersListBox_SelectedIndexChanged);
            // 
            // colorPanel2
            // 
            this.colorPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel2.Location = new System.Drawing.Point(25, 423);
            this.colorPanel2.Name = "colorPanel2";
            this.colorPanel2.Size = new System.Drawing.Size(40, 40);
            this.colorPanel2.TabIndex = 1;
            // 
            // ChangeColorLink
            // 
            this.ChangeColorLink.AutoSize = true;
            this.ChangeColorLink.Location = new System.Drawing.Point(73, 410);
            this.ChangeColorLink.Name = "ChangeColorLink";
            this.ChangeColorLink.Size = new System.Drawing.Size(58, 13);
            this.ChangeColorLink.TabIndex = 3;
            this.ChangeColorLink.TabStop = true;
            this.ChangeColorLink.Text = "Поменять";
            this.ChangeColorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangeColorLink_LinkClicked);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(12, 366);
            this.trackBar1.Maximum = 79;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(130, 38);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickFrequency = 3;
            this.trackBar1.Value = 5;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
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
            this.AnT.Size = new System.Drawing.Size(653, 472);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.Click += new System.EventHandler(this.AnT_Click);
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
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
            this.menuStrip1.Size = new System.Drawing.Size(865, 24);
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
            this.ClientSize = new System.Drawing.Size(865, 502);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(881, 540);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}

