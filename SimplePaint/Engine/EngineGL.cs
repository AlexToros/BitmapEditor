using System;
using System.Collections.Generic;
using System.Drawing;
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
        /// <summary>
        /// Холст
        /// </summary>
        private SimpleOpenGlControl Canvas;
        /// <summary>
        /// Размеры изображения
        /// </summary>
        private int picture_width;
        private int picture_height;

        /// <summary>
        /// Размеры Экрана
        /// </summary>
        private int Screen_width;
        private int Screen_height;

        /// <summary>
        /// полосы прокрутки
        /// </summary>
        private int scroll_x, scroll_y;

        public List<Layer> Layers { get; private set; }

        /// <summary>
        /// Активный слой
        /// </summary>
        public Layer ActiveLayer { get; set; }

        public int LayersCount { get => Layers.Count; }

        private Brush StandartBrush;

        private EngineGL()
        { }

        public EngineGL(SimpleOpenGlControl mainGraphicPanel, int picture_width, int picture_height)
        {
            Layers = new List<Layer>();
            Canvas_Init(mainGraphicPanel.Height, mainGraphicPanel.Width);

            Canvas = mainGraphicPanel;
            this.picture_width = picture_width;
            this.picture_height = picture_height;

            Screen_height = mainGraphicPanel.Height;
            Screen_width = mainGraphicPanel.Width;

            scroll_x = 0;
            scroll_y = 0;

            ActiveLayer = new Layer("Главный слой", picture_width, picture_height);
            Layers.Add(ActiveLayer);
            StandartBrush = new Brush();
        }

        #region Mетоды инициализации движка

        /// <summary>
        /// Первичная инициализация движка. Инициализация библиотеки и холста.
        /// </summary>
        /// <param name="mainGraphicPanel">OpenGL Control</param>
        /// <param name="picture_width">Ширина рисунка</param>
        /// <param name="picture_height">Высота рисунка</param>
        /// <returns>Экземпляр движка</returns>
        public static EngineGL InitializeEngine(SimpleOpenGlControl mainGraphicPanel, int picture_width, int picture_height)
        {
            mainGraphicPanel.InitializeContexts();        
            //Инициализация библиотеки
            Glut.glutInit();
            
            return new EngineGL(mainGraphicPanel, picture_width, picture_height);
        }

        /// <summary>
        /// Первичная инициализация движка. Инициализация библиотеки и холста.
        /// </summary>
        /// <param name="mainGraphicPanel">OpenGL Control</param>
        /// <returns>Экземпляр движка</returns>
        public static EngineGL InitializeEngine(SimpleOpenGlControl mainGraphicPanel)
        {
            return InitializeEngine(mainGraphicPanel, mainGraphicPanel.Width, mainGraphicPanel.Height);
        }

        /// <summary>
        /// Инициализация холста при первичной инициализации и изменении размеров
        /// </summary>
        /// <param name="ScreenHeight">Ширина холста</param>
        /// <param name="ScreenWidth">Высота холста</param>
        public void Canvas_Init(int ScreenHeight, int ScreenWidth)
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

        #region Методы над слоями
       
        public void AddLayer(string name, bool visibility)
        {
            AddLayer(new Layer(name, picture_width, picture_height, visibility));
            ActiveLayer = Layers.Last();
        }

        public void AddLayer(Layer new_layer)
        {
            Layers.Add(new_layer);
            ActiveLayer = Layers.First();
        }

        public void DeleteActiveLayer()
        {
            if (ActiveLayer == Layers.First()) throw new InvalidOperationException("Невозможно удалить главный слой");
            Layers.Remove(ActiveLayer);
            ActiveLayer = Layers.First();
        }
        #endregion

        #region Методы рисования

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

            DrawLayers();

            Gl.glFlush();
            Canvas.Invalidate();
        }

        /// <summary>
        /// Визуализация слоев
        /// </summary>
        private void DrawLayers()
        {
            Layers.ForEach(l => l.Render());
        }

        /// <summary>
        /// Рисование кистью в заданных координатах на активном слое
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        internal void Draw(int x, int y)
        {
            ActiveLayer.Draw(StandartBrush, x, y);
        }

        public void SetColor(Color color)
        {
            Layer.ActiveColor = color;
        }
        #endregion
    }
}
