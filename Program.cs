// // Window Types
// public static const string FIXED_WINDOWS = "Fixed Window";
//
// const string SLIDING_WINDOWS = "Sliding Window";
// const string CASEMENT_WINDOWS = "Casement Window";
// const string AWNING_WINDOWS = "Awning Window";
// const string GLASS_BLOCK_WINDOWS = "Glass Block Window";
//
// // Window Colors
// const string BROUWN = "Brouwn";
// const string BLACK = "White";
// const string WHITE = "Black";
//
// // Glass Types
// const string FLOAT = "Float Glass";
// const string TEMPERED = "Tempered Glass";
// const string INSULATED = "Insulated Glass";
// const string MIRRORED = "Mirrored Glass";

namespace BuilderNameSpace
{
    


    class Test{
        public static void Main(string[] args)
        {
            WindowBuilder windowBuilder = Window.GetWindowBuilder();
            Window window = windowBuilder.SetColor("Black").SetGlass("Mirrored Glass").SetType("Glass Block Window").SetHeight(1.20).SetWidth(1.75).Build();
            Console.WriteLine(window);
        }
    }
    public class Window
    {
        public string type { get; set; }
        public string color { get; set; }
        public string glass { get; set; }


        public double width { get; set; }
        public double height { get; set; }

        public static WindowBuilder GetWindowBuilder()
        {
            return new WindowBuilderImp();
        }

        public override string ToString()
        {
            return $"{nameof(type)}: {type}, {nameof(color)}: {color}, {nameof(glass)}: {glass}, {nameof(width)}: {width}, {nameof(height)}: {height}";
        }
    }

    public interface WindowBuilder {
        public Window Build();

        WindowBuilder SetType(string type);
        WindowBuilder SetColor(string color);
        WindowBuilder SetGlass(string glass);
        WindowBuilder SetHeight(double height);
        WindowBuilder SetWidth(double width);
    }

    public class WindowBuilderImp : WindowBuilder
    {
        private readonly Window _window;


        public WindowBuilderImp()
        {
            _window = new Window();
        }

        public Window Build()
        {
            // did some validation before build 
            return _window;
        }

        public WindowBuilder SetType(string type)
        {
            _window.type = type;
            return this;
        }

        public WindowBuilder SetColor(string color)
        {
            _window.color = color;
            return this;
        }

        public WindowBuilder SetGlass(string glass)
        {
            _window.glass = glass;
            return this;
        }

        public WindowBuilder SetHeight(double height)
        {
            _window.height = height;
            return this;
        }

        public WindowBuilder SetWidth(double width)
        {
            _window.width = width;
            return this;
        }
    }
}