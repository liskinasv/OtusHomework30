namespace PrototipPattern.Abstractions
{
    /// <summary>
    /// Интерфейс, определяющий метод MyClone для клонирования объектов.
    /// </summary>
    public interface IMyCloneable<T>
    {
        T MyClone();
    }
}
