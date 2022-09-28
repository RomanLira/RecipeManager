
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes
{
    //Основной класс библиотеки, в котором производятся все основные действия с элементами базы рецептов
    public class RecipeDataBase
    {
        //Коллекция Dictionary, которая хранит все рецепты 
        private Dictionary<int, Recipe> _recipeDataBase;

        public RecipeDataBase()
        {
            _recipeDataBase = new Dictionary<int, Recipe>();
        }

        //Метод добавления рецепта в базу
        public void AddRecipe(Recipe recipe)
        {
            //проверка на уникальность
            if (_recipeDataBase.ContainsKey(recipe.GetHashCode()))
                throw new ArgumentException("Рецепт уже добавлен в список рецептов!");
            _recipeDataBase.Add(recipe.GetHashCode(), recipe);
        }

        //Метод добавления ингредиента в рецепт
        public void AddIngredient(Recipe recipe, Ingredient ingredient)
        {
            //здесь и далее - проверка наличия рецепта в базе
            if (!_recipeDataBase.ContainsKey(recipe.GetHashCode()))
                throw new ArgumentException("Такого рецепта не существует!");
            recipe.Ingredients.Add(ingredient);
        }

        //Метод добавления списка ингредиентов в рецепт
        public void AddIngredients(Recipe recipe, List<Ingredient> ingredients)
        {
            if (!_recipeDataBase.ContainsKey(recipe.GetHashCode()))
                throw new ArgumentException("Такого рецепта не существует!");
            foreach (var i in ingredients)
                    recipe.Ingredients.Add(i);
        }

        //Метод редактирования названия рецепта
        public void ChangeName(Recipe recipe, string changedName)
        {
            if (!_recipeDataBase.ContainsKey(recipe.GetHashCode()))
                throw new ArgumentException("Такого рецепта не существует!");
            recipe.Name = changedName;
        }

        //Метод редактирования категории рецепта
        public void ChangeType(Recipe recipe, string changedType)
        {
            if (!_recipeDataBase.ContainsKey(recipe.GetHashCode()))
                throw new ArgumentException("Такого рецепта не существует!");
            recipe.Type = changedType;
        }

        //Метод редактирования одного ингредиента из выбранного рецепта
        public void ChangeIngredient(Recipe recipe, Ingredient ingredient, string name, int count, string measure)
        {
            if (!_recipeDataBase.ContainsKey(recipe.GetHashCode()))
                throw new ArgumentException("Такого рецепта не существует!");
            //здесь и далее - проверка наличия ингредиента в выбранном рецепте
            if (!recipe.Ingredients.Contains(ingredient))
                throw new ArgumentException("В данном рецепте такого ингредиента нет!");
            foreach (var i in recipe.Ingredients)
            {
                if(i == ingredient)
                {
                    i.Name = name;
                    i.Count = count;
                    i.Measure = measure;
                }
            }
        }

        //Метод редактирования всего списка ингредиентов выбранного рецепта
        public void ChangeIngredients(Recipe recipe, List<Ingredient> ingredients)
        {
            if (!_recipeDataBase.ContainsKey(recipe.GetHashCode()))
                throw new ArgumentException("Такого рецепта не существует!");
            recipe.Ingredients = ingredients;
        }

        //Метод редактирования описания рецепта
        public void ChangeDescription(Recipe recipe, string changedDescription)
        {
            if (!_recipeDataBase.ContainsKey(recipe.GetHashCode()))
                throw new ArgumentException("Такого рецепта не существует!");
            recipe.Description = changedDescription;
        }

        //Метод удаления рецепта из базы
        public void DeleteRecipe(Recipe recipe)
        {
            if (!_recipeDataBase.ContainsKey(recipe.GetHashCode()))
                throw new ArgumentException("Такого рецепта не существует!");
            _recipeDataBase.Remove(recipe.GetHashCode());
        }

        //Метод удаления ингредиента из рецепта
        public void DeleteIngredient(Recipe recipe, Ingredient ingredient)
        {
            if (!_recipeDataBase.ContainsKey(recipe.GetHashCode()))
                throw new ArgumentException("Такого рецепта не существует!");
            if (!recipe.Ingredients.Contains(ingredient))
                throw new ArgumentException("В данном рецепте такого ингредиента нет!");
            recipe.Ingredients.Remove(ingredient);
        }

        //Метод вывода на экран конкретного рецепта из базы
        public string ShowRecipe(Recipe recipe)
        {
            if (!_recipeDataBase.ContainsKey(recipe.GetHashCode()))
                throw new ArgumentException("Такого рецепта не существует!");
            return recipe.Print();
        }

        //Метод вывода на экран названий всех рецептов базы
        public string ShowRecipesByName()
        {
            string str = "";
            foreach (var i in _recipeDataBase)
                str += i.Value.Name + Environment.NewLine;
            return str;
        }

        //Метод вывода на экран всех рецептов базы, отсортированных по выбранной категории
        public string ShowRecipesByType(string type)
        {
            string str = "";
            foreach (var r in _recipeDataBase)
            {
                if (r.Value.Type == type)
                    str += r.Value.Name + Environment.NewLine;
            }
            return str;
        }

        //Метод вывода на экран названий всех рецептов базы, в которых содержится выбранный ингредиент
        public string ShowRecipesByIngredient(string name)
        {
            string str = "";
            foreach(var r in _recipeDataBase)
            {
                foreach (var i in r.Value.Ingredients)
                    if(i.Name == name)
                        str += r.Value.Name + Environment.NewLine;
            }
            return str;
        }

        //Метод вывода на экран подробной информации о каждом рецепте базы
        public string ShowRecipes()
        {
            string str = "";
            foreach (var i in _recipeDataBase)
                str += i.Value.Print() + Environment.NewLine;
            return str;
        }

        //Метод поиска рецепта по названию
        public Recipe SearchByName(string name)
        {
            var temp = new Recipe();
            foreach(var n in _recipeDataBase)
            {
                if (n.Value.Name == name)
                    temp = n.Value;
            }
            return temp;
        }

        //Метод поиска ингредиента в выбранном рецепте
        public Ingredient SearchIngredient(Recipe recipe, string name)
        {
            if (!_recipeDataBase.ContainsKey(recipe.GetHashCode()))
                throw new ArgumentException("Такого рецепта не существует!");
            Ingredient temp = new Ingredient();
            foreach(var n in _recipeDataBase)
            {
                if (n.Value == recipe)
                    foreach (var i in recipe.Ingredients)
                        if (i.Name == name)
                            temp = i;
            }
            return temp;
        }

        //Метод сохранения списка рецептов в текстовый файл
        public void Save(string path)
        {
            if (_recipeDataBase.Count == 0)
                throw new ArgumentException("В списке рецептов нет ни одного рецепта!");
            using (var fileWriter = new StreamWriter(path))
                foreach (var p in _recipeDataBase)
                    fileWriter.WriteLine(p.Value.Print());
        }


        //Метод загрузки списка рецептов из текстового файла
        public void Load(string path)
        {
            using (var fileReader = new StreamReader(path))
            {
                var newDataBase = new Dictionary<int, Recipe>();
                string str = fileReader.ReadLine();
                List<Ingredient> ingredients = new List<Ingredient>();
                Ingredient ingredient;
                string name = "", type = "", description = "";
                while (str != null)
                {
                    if (str != "")
                    {
                        var data = str.Split(' ');
                        string temp = data[0];
                        switch (temp)
                        {
                            case "Рецепт:":
                                for (int i = 1; i < data.Length; i++)
                                {
                                    if (i != data.Length - 1)
                                        name += data[i] + " ";
                                    else
                                        name += data[i];
                                }
                                break;
                            case "Категория:":
                                for (int i = 1; i < data.Length; i++)
                                {
                                    if (i != data.Length - 1)
                                        type += data[i] + " ";
                                    else
                                        type += data[i];
                                }
                                break;
                            case "Ингредиент:":
                                string ingredient_name = "";
                                for (int i = 1; i < data.Length - 2; i++)
                                {
                                    if (i != data.Length - 3)
                                        ingredient_name += data[i] + " ";
                                    else
                                        ingredient_name += data[i];
                                }
                                ingredient = new Ingredient
                                {
                                    Name = ingredient_name,
                                    Count = Convert.ToInt32(data[data.Length - 2]),
                                    Measure = data[data.Length - 1]
                                };
                                ingredients.Add(ingredient);
                                break;
                            case "Описание:":
                                for (int i = 1; i < data.Length; i++)
                                    description += data[i] + " ";
                                break;
                        }
                        str = fileReader.ReadLine();
                    }
                    else
                    {
                        var p = new Recipe(name, type, ingredients, description);
                        newDataBase.Add(p.GetHashCode(), p);
                        name = "";
                        type = "";
                        description = "";
                        ingredients = new List<Ingredient>();
                        str = fileReader.ReadLine();
                    }
                }
                _recipeDataBase = newDataBase;
            }
        }
    }
}
