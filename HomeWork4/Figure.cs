
namespace HomeWork4
{
    abstract class Figure
    {
        // Абстрактный метод получения названия фигуры
        public abstract string GetName { get; }
        
        // Абстрактный метод для получения значения периметра фигуры
        public abstract double GetPerimeter();
        
        // Абстрактный метод для получения значения площади фигуры
        public abstract double GetArea();
    }
}
