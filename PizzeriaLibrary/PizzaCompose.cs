namespace PizzeriaLibrary
{
    public class PizzaCompose : IBasePizza, IDough, IAdded
    {
        public string Name;

        public string Dough;

        public string Added;

        public PizzaCompose(string name, string dough, string added)
        {
            Name = name;
            Dough = dough;
            Added = added;
        }

        public int GetBase(string Name)
        {
            switch (Name)
            {
                case "Margherita": return 5; break;
                case "Peperoni": return 7;break;
                case "Napoletana": return 3;break;
            }
        }
    

        public int GetDough(string Dough) 
        {
            switch (Dough)
            {
                case "Normale": return 0;break;
                case "Integrale": return 1;break;   
            }

        public int GetAdded(string Added) {
                switch (Added)
                {
                    case "Prosciutto cotto": return 1; break;
                    case "Funghi": return 2; break;
                    case "Crudo": return 2; break;
                    case "Ananas": return 50; break;
                }
            }
    }
}
