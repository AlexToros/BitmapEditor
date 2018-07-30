using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace SimplePaint
{
    class EngineGL
    {
        private EngineGL()
        {
                
        }
        public static EngineGL InitializeEngine(SimpleOpenGlControl mainGraphicPanel)
        {
            mainGraphicPanel.InitializeContexts();
            mainGraphicPanel.Resize += MainGraphicPanel_Resize;

            //Инициализация библиотеки
            Glut.glutInit();

            Canvas_Init(mainGraphicPanel.Height, mainGraphicPanel.Width);

            return new EngineGL();
        }

        private static void MainGraphicPanel_Resize(object sender, EventArgs e)
        {
            SimpleOpenGlControl p = (SimpleOpenGlControl)sender;
            Canvas_Init(p.Height, p.Width);
        }

        private static void Canvas_Init(int ScreenHeight, int ScreenWidth)
        {            
            //режим окна
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            //цвет очистки окна
            Gl.glClearColor(255, 255, 255, 1);
            // установка порта вывода
            Gl.glViewport(0, 0, ScreenWidth, ScreenHeight);
            //установка проекционной матрицы
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            //ее очистка
            Gl.glLoadIdentity();

            Glu.gluOrtho2D(0.0, ScreenWidth, 0.0, ScreenHeight);

            //переход к объектно-видовой матрице
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
        }

    }
}
