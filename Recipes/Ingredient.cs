using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes
{
    //класс, создающий объект "Ингредиент"
    public class Ingredient
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public string Measure { get; set; }

        public Ingredient()
        {

        }

        public Ingredient(string name, int count, string measure)
        {
            if (name == null || count == 0 || measure == null)
                throw new ArgumentNullException();
            Name = name;
            Count = count;
            Measure = measure;
            List<string> OneIngredient = new List<string>
            {
                Name,
                Convert.ToString(Count),
                Measure
            };
        }

        //метод вывода ингредиента на экран
        public string Print()
        {
            string str = "";
            str += "Ингредиент: " + Name + " " + Count + " " + Measure + Environment.NewLine;
            return str;
        }
    }
}
