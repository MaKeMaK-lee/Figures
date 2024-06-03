using Figures.FiguresStorage;
using Figures.FiguresStorage.Polygons;
using Figures.FiguresStorage.Rounded;
using System.Diagnostics;
using System.Windows;

namespace Figures
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var figures = (new List<IFigure>() {
                new Polygon([
                    new(0,5), new(3,-5), new(3,5), new(0,-10),
                    new(-3,5), new(-3,-5), new(0,5)]),

                new Polygon([new(0,-3)] ),
                new Polygon([new(0,3), new(3,0), new(0,-3)] ),
                new Polygon([new(0,2), new(2,0), new(0,-2)] ),
                new Polygon([new(1,1), new(1,0), new(-1,-1)] ),
                new Polygon([new(5,5), new(3,0), new(0,-10), new(-8,5)] ),

                new Rectangle([new(5,5), new(3,0), new(0,-10), new(-8,5)] ),
                new Rectangle([new(5,5), new(5,-5), new(-5,-5), new(-5,5)] ),
                new Rectangle([new(5,0), new(0,5), new(-5,0), new(0,-5)] ),

                new Rectangle(5.5f,8 ),
                new Rectangle(-8,-8),
                new Rectangle(0,7),

                new Square(8),
                new Square(-5),
                new Square(0),

                new Triangle([new(5,5), new(3,0), new(0,-10)]),
                new Triangle([new(5,5), new(-5,-5)]),

                new Triangle([new(5,5), new(3,0), new(-8,-5)]),
                new Triangle([new(5,5), new(3,0)]),

                new TriangleRight(10,10),
                new TriangleRight(-8,10),
                new TriangleRight(0,10),

                new Circle(9),
                new Circle(5),
                new Circle(1),
                new Circle(0),
                new Circle(-1),
                new Circle(2),


                new Ellipse(2,2),

                new Ellipse(9,3),
                new Ellipse(9,3),
                new Ellipse(9,0.5f),
                new Ellipse(-8,5),
                new Ellipse(0,3),

            }).Where(f => f.Validate());

            Debug.WriteLine("Figures:\n");
            foreach (var polygon in figures)
            {
                Debug.WriteLine(polygon.GetInformationString());
                Debug.WriteLine("\n");
            }
            Debug.WriteLine("\n");

        }
    }
}