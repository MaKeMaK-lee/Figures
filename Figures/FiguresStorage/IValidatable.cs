
namespace Figures.FiguresStorage
{
    /// <summary>
    /// Представляет функционал для проверки состояния объекта
    /// </summary>
    public interface IValidatable
    {
        /// <summary>
        /// Проверяет, соответствует ли текущее состояние объекта его определению. Рекомендуется использовать для проверки при динамическом создании объектов.
        /// </summary>
        /// <returns>True если состояние корректно, иначе false</returns>
        bool Validate();
    }
}
