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
        }
        private void InitializeOpenGL()
        {
            Engine = EngineGL.InitializeEngine(AnT);
            RenderTimer.Start();
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
        
    }
}
