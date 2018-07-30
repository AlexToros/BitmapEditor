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
            InitializeOpenGL();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializeOpenGL()
        {
            Engine = EngineGL.InitializeEngine(AnT);
            RenderTimer.Start();
        }
        private void RenderTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
