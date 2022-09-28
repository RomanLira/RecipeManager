using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes
{
    //Класс, создающий объект "Рецепт"
    public class Recipe
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public string Description { get; set; }
        
        public Recipe()
        {
            Ingredients = new List<Ingredient>();
        }

        public Recipe(string name, string type, List<Ingredient> ingredients, string description)
        {
            if (name == null || type == null || ingredients == null || description == null)
                throw new ArgumentNullException();
            Name = name;
            Type = type;
            Ingredients = ingredients;
            Description = description;
        }

        //Метод, возвращающий хэш-код (уникальный номер), нужный для добавления рецепта в базу
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Type.GetHashCode() + Description.GetHashCode();
        }

        //Метод вывода рецепта на экран
        public string Print()
        {
            string str = "";
            str += "Рецепт: " + Name + Environment.NewLine + "Категория: " + Type + 
                Environment.NewLine + PrintIngredients() +
                "Описание: " + Description + Environment.NewLine;
            return str;
        }

        //Вспомогательный метод вывода списка ингредиентов на экран
        public string PrintIngredients()
        {
            string str = ""; 
            foreach (var i in Ingredients)
                str += i.Print();
            return str;
        }
    }
}
