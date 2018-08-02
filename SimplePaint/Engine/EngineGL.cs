using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform.Windows;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SimplePaint
{
    class EngineGL : INotifyPropertyChanged
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

        private Color s_activeColor;

        public List<Layer> Layers { get; private set; }

        /// <summary>
        /// Активный слой
        /// </summary>
        public Layer ActiveLayer
        {
            get => _activeLayer;
            set
            {
                _activeLayer?.CreateNewList();                
                _activeLayer = value;
            }
        }

        public int LayersCount { get => Layers.Count; }

        public Brush CurrentBrush { get; set; }

        public Color LastColor
        {
            get => _lastColor;
            set
            {
                _lastColor = value;
                NotifyPropertyChanged();
            }
        }

        public Color ActiveColor
        {
            get => s_activeColor;
            set
            {
                LastColor = s_activeColor;
                s_activeColor = value;
                NotifyPropertyChanged();
            }
        }

        private Layer HiddenLayer;
        private Color _lastColor;
        private Layer _activeLayer;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private EngineGL()
        { }

        public EngineGL(SimpleOpenGlControl mainGraphicPanel, int picture_width, int picture_height)
        {
            HiddenLayer = new HiddenLayer(picture_width, picture_height);
            Layers = new List<Layer>();
            Canvas_Init(mainGraphicPanel.Height, mainGraphicPanel.Width);

            Canvas = mainGraphicPanel;
            this.picture_width = picture_width;
            this.picture_height = picture_height;

            Screen_height = mainGraphicPanel.Height;
            Screen_width = mainGraphicPanel.Width;

            scroll_x = 0;
            scroll_y = 0;

            ActiveLayer = new Layer(1,"Главный слой", picture_width, picture_height);
            Layers.Add(ActiveLayer);
            CurrentBrush = new Brush();
            ActiveColor = Color.Black;
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
            AddLayer(new Layer(LayersCount+1, name, picture_width, picture_height, visibility));
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

        public Bitmap GetResultBitMap()
        {
            Bitmap result = new Bitmap(picture_width, picture_height);
            for (int i = 0; i < picture_width; i++)
                for (int j = 0; j < picture_height; j++)
                {
                    for (int l = LayersCount - 1; l >= 0; l--)
                    {
                        short[,,] temp = Layers[l].DrawPlace;
                        if (temp[i, j, 3] == 0)
                        {
                            result.SetPixel(i, j, Color.FromArgb(temp[i, j, 0], temp[i, j, 1], temp[i, j, 2]));
                            break;
                        }
                        else if (l == 0)
                        {
                            result.SetPixel(i, j, Color.FromArgb(255, 255, 255));
                        }
                    }
                }
            result.RotateFlip(RotateFlipType.Rotate180FlipX);
            return result;
        }

        public void SetImageToMainLayer(Bitmap bitmap)
        {
            bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
            var data = bitmap.LockBits(new Rectangle(0, 0, picture_width > bitmap.Width ? bitmap.Width : picture_width, picture_height > bitmap.Height ? bitmap.Height : picture_height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppRgb);

            byte[] pixels = new byte[data.Stride];
            for (int i = 0; i < picture_height && i < bitmap.Height; i++)
            {
                Marshal.Copy(data.Scan0 + i * data.Stride, pixels, 0, data.Stride);
                for (int j = 0; j < picture_width && j < bitmap.Width; j++)
                {
                    int indx = j * 4;
                    ActiveLayer.DrawPlace[j, i, 2] = pixels[indx];
                    ActiveLayer.DrawPlace[j, i, 1] = pixels[++indx];
                    ActiveLayer.DrawPlace[j, i, 0] = pixels[++indx];
                    ActiveLayer.DrawPlace[j, i, 3] = 0;
                }
            }
            bitmap.UnlockBits(data);
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
            Layers.ForEach(l => l.Render(l != ActiveLayer));
            HiddenLayer.Render(false);
        }

        /// <summary>
        /// Рисование кистью в заданных координатах на активном слое
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        internal void Draw(int x, int y)
        {
            ActiveLayer.Draw(ActiveColor, CurrentBrush, x, y);
        }
        internal void SystemDraw(int x, int y)
        {
            HiddenLayer.Draw(ActiveColor, CurrentBrush, x, y);
        }

        public void SetColor(Color color)
        {
            ActiveColor = color;
        }

        internal void SwapColors()
        {
            if (LastColor.A == 0) return;
            ActiveColor = LastColor;
        }

        internal void ChangeSize(int newSize)
        {
            CurrentBrush.ChangeSize(newSize);
        }
        #endregion
    }
}
