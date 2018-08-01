using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class MainForm : Form
    {
        private EngineGL Engine;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeOpenGL();
            UpdateLayersList();
        }
        private void InitializeOpenGL()
        {
            Engine = EngineGL.InitializeEngine(AnT);
            RenderTimer.Start();
        }
        private void UpdateLayersList()
        {
            LayersListBox.Items.Clear();
            LayersListBox.Items.AddRange(Engine.Layers.ToArray());
            for (int i = 0; i < Engine.LayersCount; i++)
            {
                if (Engine.Layers[i].IsVisible) LayersListBox.SetItemChecked(i, true);
            }
        }
        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            Engine.Drawing();
        }

        private void AnT_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Engine.Draw(e.X, AnT.Height - e.Y);
        }

        private void AnT_Click(object sender, EventArgs e)
        {
            AnT_MouseMove(sender, (MouseEventArgs)e);
        }

        private void LayersListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Layer l = (Layer)LayersListBox.SelectedItem;
            if (l != null)
                l.IsVisible = e.NewValue == CheckState.Checked ? true : false;
        }

        private void AddLayerTool_Click(object sender, EventArgs e)
        {
            Engine.AddLayer("Слой " + Engine.LayersCount.ToString(), true);
            UpdateLayersList();
        }

        private void LayersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Engine.ActiveLayer = (Layer)LayersListBox.SelectedItem;
        }

        private void RemoveLayerTool_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Будет удален текущий активный слой.", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                try
                {
                    Engine.DeleteActiveLayer();
                    UpdateLayersList();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}
