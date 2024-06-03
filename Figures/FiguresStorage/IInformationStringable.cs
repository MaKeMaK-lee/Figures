
namespace Figures.FiguresStorage
{
    /// <summary>
    /// Представляет функционал для получения информации об объекте в виде строки
    /// </summary>
    public interface IInformationStringable
    {
        /// <summary>
        /// Предоставляет информацию об объекте
        /// </summary>
        /// <returns>Строка с информацией об объекте</returns>
        string GetInformationString();
    }
}
