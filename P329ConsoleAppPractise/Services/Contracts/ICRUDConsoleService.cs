using P329ConsoleAppPractise.Models;

namespace P329ConsoleAppPractise.Services.Contracts
{
    internal interface ICRUDConsoleService
    {
        void Add();
        void Update();
        void Delete();
        Entity Get();
        Entity[] GetAll();
    }
}
