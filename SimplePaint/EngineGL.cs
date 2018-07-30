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
        private static SimpleOpenGlControl Canvas;

        private EngineGL()
        {
                
        }

        #region Статические методы инициализации движка
        /// <summary>
        /// Первичная инициализация движка. Инициализация библиотеки и холста.
        /// </summary>
        /// <param name="mainGraphicPanel">OpenGL Control</param>
        /// <returns>Экземпляр движка</returns>
        public static EngineGL InitializeEngine(SimpleOpenGlControl mainGraphicPanel)
        {
            mainGraphicPanel.InitializeContexts();
            mainGraphicPanel.Resize += MainGraphicPanel_Resize;

            //Инициализация библиотеки
            Glut.glutInit();
            Canvas = mainGraphicPanel;
            Canvas_Init(mainGraphicPanel.Height, mainGraphicPanel.Width);

            return new EngineGL();
        }
        /// <summary>
        /// Обработчик изменения размеров холста
        /// </summary>
        /// <param name="sender">OpenGL Control</param>
        /// <param name="e"></param>
        private static void MainGraphicPanel_Resize(object sender, EventArgs e)
        {
            SimpleOpenGlControl p = (SimpleOpenGlControl)sender;
            Canvas_Init(p.Height, p.Width);
        }

        /// <summary>
        /// Инициализация холста при первичной инициализации и изменении размеров
        /// </summary>
        /// <param name="ScreenHeight">Ширина холста</param>
        /// <param name="ScreenWidth">Высота холста</param>
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
        #endregion

        /// <summary>
        /// Основной метод отрисовки
        /// </summary>
        internal void Drawing()
        {
            //очистка буферов цвета и глубины
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            //очистка текущей матрицы
            Gl.glLoadIdentity();
            //установка черного цвета
            Gl.glColor3f(0, 0, 0);

            DrawObjects();

            Gl.glFlush();
            Canvas.Invalidate();
        }

        /// <summary>
        /// Визуализация объектов
        /// </summary>
        private void DrawObjects()
        {
            //throw new NotImplementedException();
        }
    }
}
