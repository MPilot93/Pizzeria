

namespace PizzeriaLibrary
{
    public interface IBasePizza
    {
        string Name { get; }

        public int GetBase(string name);
    }
}
