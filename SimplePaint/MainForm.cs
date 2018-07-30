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
        private static EngineGL Engine;

        public MainForm()
        {
            InitializeComponent();
        }
        Action ac;
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeOpenGL();
        }
        private void InitializeOpenGL()
        {
            Engine = EngineGL.InitializeEngine(AnT);
            ac = Engine.Drawing;
            RenderTimer.Start();
            
        }
        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            ac.Invoke();
        }
    }
}
