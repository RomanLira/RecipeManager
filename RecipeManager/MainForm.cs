using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recipes;
using System.IO;

namespace RecipeManager
{
    public partial class MainForm : Form
    {
        //глобальные переменные для дальнейшей работы с ними
        public static RecipeDataBase _recipeDB = new RecipeDataBase();
        public static Recipe _recipe = new Recipe();
        public static Ingredient _ingredient = new Ingredient();

        //запуск формы, вывод по центру
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        //настройка интерфейса при нажатии на кнопку "Добавить рецепт"
        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            RecipeNameLabel.Visible = true;
            RecipeNameTextBox.Visible = true;
            RecipeTypeLabel.Visible = true;
            RecipeTypeComboBox.Visible = true;
            IngredientsLabel.Visible = true;
            IngredientsTextBox.Visible = true;
            DescriptionLabel.Visible = true;
            DescriptionTextBox.Visible = true;
            AddIngredientButton.Visible = true;
            ShowIngredientsButton.Visible = true;
            ShowIngredientsButton.Enabled = false;
            SaveRecipeButton.Visible = true;
            RecipeNameTextBox.Text = "";
            IngredientsTextBox.Text = "";
            DescriptionTextBox.Text = "";
            _recipe = new Recipe();
            RecipeListTextBox.Visible = false;
            RecipeListLabel.Visible = false;
            HideRecipeListButton.Visible = false;
            ShowRecipesByIngredientButton.Visible = false;
            ShowRecipesByIngredientTextBox.Visible = false;
            ShowRecipesByIngredientTextBox.Text = "";
            ShowRecipesByTypeButton.Visible = false;
            ShowRecipesByTypeComboBox.Visible = false;
            SearchRecipeButton.Visible = false;
            SearchRecipeButton.Enabled = true;
            SearchRecipeTextBox.Visible = false;
            SearchRecipeTextBox.Text = "";
            ClearSearchAndInfoButton.Visible = false;
            RecipeInfoTextBox.Visible = false;
            RecipeInfoTextBox.Text = "";
            ChangeRecipeButton.Visible = false;
            DeleteRecipeButton.Visible = false;
            SaveChangingRecipeButton.Visible = false;
            ActionsWithIngredientButton.Visible = false;
            SearchIngredientButton.Visible = false;
            SearchIngredientTextBox.Visible = false;
            SearchIngredientTextBox.Text = "";
            SearchIngredientTextBox.Enabled = true;
            ClearSearchingIngredientButton.Visible = false;
            ChangeIngredientButton.Visible = false;
            DeleteIngredientButton.Visible = false;
            SaveChangingIngredientButton.Visible = false;
        }


        //настройка интерфейса при нажатии на кнопку "Показать рецепты"
        private void RecipeDataBaseButton_Click(object sender, EventArgs e)
        {
            RecipeListLabel.Visible = true;
            RecipeListTextBox.Visible = true;
            HideRecipeListButton.Visible = true;
            RecipeListTextBox.Text = _recipeDB.ShowRecipesByName();
            SearchRecipeButton.Visible = true;
            SearchRecipeTextBox.Visible = true;
            ShowRecipesByTypeButton.Visible = true;
            ShowRecipesByTypeComboBox.Visible = true;
            ShowRecipesByIngredientButton.Visible = true;
            ShowRecipesByIngredientTextBox.Visible = true;
            #region(Cleaning)
            RecipeNameLabel.Visible = false;
            RecipeNameTextBox.Visible = false;
            RecipeNameTextBox.Text = "";
            RecipeTypeLabel.Visible = false;
            RecipeTypeComboBox.Visible = false;
            IngredientsLabel.Visible = false;
            IngredientsTextBox.Visible = false;
            IngredientsTextBox.Text = "";
            AddIngredientButton.Visible = false;
            ShowIngredientsButton.Visible = false;
            DescriptionLabel.Visible = false;
            DescriptionTextBox.Visible = false;
            DescriptionTextBox.Text = "";
            SaveRecipeButton.Visible = false;
            IngredientNameLabel.Visible = false;
            IngredientNameTextBox.Visible = false;
            IngredientNameTextBox.Text = "";
            CountLabel.Visible = false;
            CountTextBox.Visible = false;
            CountTextBox.Text = "";
            MeasureComboBox.Visible = false;
            MeasureLabel.Visible = false;
            SaveIngredientButton.Visible = false;
            SaveChangingIngredientButton.Visible = false;
            CancelAddingIngredientButton.Visible = false;
            SaveChangingRecipeButton.Visible = false;
            ActionsWithIngredientButton.Visible = false;
            SearchIngredientButton.Visible = false;
            SearchIngredientTextBox.Visible = false;
            SearchIngredientTextBox.Text = "";
            ClearSearchingIngredientButton.Visible = false;
            ChangeIngredientButton.Visible = false;
            DeleteIngredientButton.Visible = false;
            #endregion
        }

        //настройка интерфейса при нажатии на кнопку "Сохранить рецепт"
        //И сохранение рецепта в базу рецептов
        private void SaveRecipeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (RecipeNameTextBox.Text == "" || RecipeTypeComboBox.Text == "" || _recipe.Ingredients.Count == 0 
                    || DescriptionTextBox.Text == "")
                {
                    throw new ArgumentNullException();
                }
                _recipe.Name = RecipeNameTextBox.Text;
                _recipe.Type = RecipeTypeComboBox.Text;
                _recipe.Description = DescriptionTextBox.Text;
                _recipeDB.AddRecipe(_recipe);
                _recipe = new Recipe();
                IngredientNameLabel.Visible = false;
                IngredientNameTextBox.Visible = false;
                CountLabel.Visible = false;
                CountTextBox.Visible = false;
                MeasureLabel.Visible = false;
                MeasureComboBox.Visible = false;
                SaveChangingIngredientButton.Visible = false;
                RecipeNameLabel.Visible = false;
                RecipeNameTextBox.Visible = false;
                RecipeTypeLabel.Visible = false;
                RecipeTypeComboBox.Visible = false;
                IngredientsLabel.Visible = false;
                IngredientsTextBox.Visible = false;
                DescriptionLabel.Visible = false;
                DescriptionTextBox.Visible = false;
                AddIngredientButton.Visible = false;
                ShowIngredientsButton.Visible = false;
                SaveRecipeButton.Visible = false;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show(
                        "Все поля должны быть заполнены!",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            catch(ArgumentException exception)
            {
                MessageBox.Show(
                        exception.Message,
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        //настройка интерфейса при нажатии на кнопку "Добавить/редактировать ингредиент"
        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            IngredientNameLabel.Visible = true;
            IngredientNameTextBox.Visible = true;
            CountLabel.Visible = true;
            CountTextBox.Visible = true;
            MeasureLabel.Visible = true;
            MeasureComboBox.Visible = true;
            SaveIngredientButton.Visible = true;
            IngredientNameTextBox.Text = "";
            CountTextBox.Text = "";
            MeasureComboBox.Text = "";
            ActionsWithIngredientButton.Enabled = false;
            CancelAddingIngredientButton.Visible = true;
        }

        //настройка интерфейса при нажатии на кнопку "Сохранить ингредиент"
        //И добавление ингредиента в список ингредиентов выбранного рецепта
        private void SaveIngredientButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IngredientNameTextBox.Text == "" || CountTextBox.Text == "" || MeasureComboBox.Text == "")
                {
                    throw new ArgumentException();
                }
                string name = IngredientNameTextBox.Text;
                int count = Convert.ToInt32(CountTextBox.Text);
                string measure = MeasureComboBox.Text;
                Ingredient ingredient = new Ingredient(name, count, measure);
                _recipe.Ingredients.Add(ingredient);
                IngredientNameLabel.Visible = false;
                IngredientNameTextBox.Visible = false;
                CountLabel.Visible = false;
                CountTextBox.Visible = false;
                MeasureLabel.Visible = false;
                MeasureComboBox.Visible = false;
                SaveIngredientButton.Visible = false;
                ShowIngredientsButton.Enabled = true;
                ActionsWithIngredientButton.Enabled = true;
                CancelAddingIngredientButton.Visible = false;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show(
                        "Количество ингредиентов не может быть равно нулю!",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show(
                        "Все поля должны быть заполнены!",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        //настройка интерфейса при нажатии на кнопку "Отменить добавление/редактирование ингредиента"
        private void CancelAddingIngredientButton_Click(object sender, EventArgs e)
        {
            IngredientNameLabel.Visible = false;
            IngredientNameTextBox.Visible = false;
            IngredientNameTextBox.Text = "";
            CountLabel.Visible = false;
            CountTextBox.Visible = false;
            CountTextBox.Text = "";
            MeasureComboBox.Visible = false;
            MeasureLabel.Visible = false;
            SaveIngredientButton.Visible = false;
            SaveChangingIngredientButton.Visible = false;
            CancelAddingIngredientButton.Visible = false;
            ActionsWithIngredientButton.Enabled = true;
        }

        //Вывод списка ингредиентов выбранного рецепта при нажатии на кнопку "Показать ингредиенты"
        private void ShowIngredientsButton_Click(object sender, EventArgs e)
        {
            IngredientsTextBox.Text = "";
            foreach (var i in _recipe.Ingredients)
            {
                IngredientsTextBox.Text += i.Print();
            }
        }

        //настройка интерфейса при нажатии на кнопку "Скрыть"
        private void HideRecipeListButton_Click(object sender, EventArgs e)
        {
            RecipeListLabel.Visible = false;
            RecipeListTextBox.Text = "";
            RecipeListTextBox.Visible = false;
            HideRecipeListButton.Visible = false;
            SearchRecipeButton.Visible = false;
            SearchRecipeButton.Enabled = true;
            SearchRecipeTextBox.Visible = false;
            SearchRecipeTextBox.Text = "";
            SearchRecipeTextBox.Enabled = true;
            ClearSearchAndInfoButton.Visible = false;
            RecipeInfoTextBox.Visible = false;
            ChangeRecipeButton.Visible = false;
            DeleteRecipeButton.Visible = false;
            ShowRecipesByTypeButton.Visible = false;
            ShowRecipesByTypeComboBox.Visible = false;
            ShowRecipesByIngredientButton.Visible = false;
            ShowRecipesByIngredientTextBox.Visible = false;
            AddRecipeButton.Enabled = true;
        }

        //настройка интерфейса при нажатии на кнопку "Поиск рецепта"
        //И инициализация поиска рецепта
        private void SearchRecipeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchRecipeTextBox.Text == "")
                    throw new ArgumentException();
                AddRecipeButton.Enabled = false;
                SearchRecipeTextBox.Enabled = false;
                ClearSearchAndInfoButton.Visible = true;
                string _searchedText = SearchRecipeTextBox.Text;
                var _searchedRecipe = _recipeDB.SearchByName(_searchedText);
                if (_searchedRecipe.Name != null)
                {
                    RecipeInfoTextBox.Visible = true;
                    ChangeRecipeButton.Visible = true;
                    DeleteRecipeButton.Visible = true;
                    SearchRecipeButton.Enabled = false;
                    RecipeInfoTextBox.Text = _recipeDB.ShowRecipe(_searchedRecipe);
                    _recipe = _searchedRecipe;
                }
                else
                {
                    MessageBox.Show(
                        "Такого рецепта не существует!",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    SearchRecipeButton.Enabled = false;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show(
                        "Поле поиска пустое!",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                SearchRecipeButton.Enabled = false;
                SearchRecipeTextBox.Enabled = false;
                ClearSearchAndInfoButton.Visible = true;
            }
        }

        //настройка интерфейса при нажатии на кнопку "Очистить поиск рецепта"
        private void ClearSearchAndInfoButton_Click(object sender, EventArgs e)
        {
            SearchRecipeTextBox.Text = "";
            SearchRecipeTextBox.Enabled = true;
            RecipeInfoTextBox.Text = "";
            RecipeInfoTextBox.Visible = false;
            ChangeRecipeButton.Visible = false;
            DeleteRecipeButton.Visible = false;
            SearchRecipeButton.Enabled = true;
        }

        //настройка интерфейса при нажатии на кнопку "Изменить рецепт"
        private void ChangeRecipeButton_Click(object sender, EventArgs e)
        {
            RecipeNameLabel.Visible = true;
            RecipeNameTextBox.Visible = true;
            RecipeTypeLabel.Visible = true;
            RecipeTypeComboBox.Visible = true;
            IngredientsLabel.Visible = true;
            IngredientsTextBox.Visible = true;
            DescriptionLabel.Visible = true;
            DescriptionTextBox.Visible = true;
            AddIngredientButton.Visible = true;
            ShowIngredientsButton.Visible = true;
            ShowIngredientsButton.Enabled = false;
            SaveChangingRecipeButton.Visible = true;
            ActionsWithIngredientButton.Visible = true;
            ActionsWithIngredientButton.Enabled = true;
            RecipeNameTextBox.Text = _recipe.Name;
            RecipeTypeComboBox.Text = _recipe.Type;
            IngredientsTextBox.Text = "";
            foreach (var i in _recipe.Ingredients)
            {
                IngredientsTextBox.Text += i.Print();
            }
            DescriptionTextBox.Text = _recipe.Description;
        }

        //настройка интерфейса при нажатии на кнопку "Сохранить изменяемый рецепт"
        //И сохранение изменений рецепта
        private void SaveChangingRecipeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (RecipeNameTextBox.Text == "" || RecipeTypeComboBox.Text == "" || _recipe.Ingredients.Count == 0
                    || DescriptionTextBox.Text == "")
                {
                    throw new ArgumentException();
                }
                _recipeDB.ChangeName(_recipe, RecipeNameTextBox.Text);
                _recipeDB.ChangeType(_recipe, RecipeTypeComboBox.Text);
                _recipeDB.ChangeIngredients(_recipe, _recipe.Ingredients);
                _recipeDB.ChangeDescription(_recipe, DescriptionTextBox.Text);
                IngredientNameLabel.Visible = false;
                IngredientNameTextBox.Visible = false;
                CountLabel.Visible = false;
                CountTextBox.Visible = false;
                MeasureLabel.Visible = false;
                MeasureComboBox.Visible = false;
                SaveChangingIngredientButton.Visible = false;
                RecipeNameLabel.Visible = false;
                RecipeNameTextBox.Visible = false;
                RecipeTypeLabel.Visible = false;
                RecipeTypeComboBox.Visible = false;
                IngredientsLabel.Visible = false;
                IngredientsTextBox.Visible = false;
                DescriptionLabel.Visible = false;
                DescriptionTextBox.Visible = false;
                AddIngredientButton.Visible = false;
                ShowIngredientsButton.Visible = false;
                SaveChangingRecipeButton.Visible = false;
                ActionsWithIngredientButton.Visible = false;
                SearchIngredientTextBox.Text = "";
                SearchIngredientTextBox.Visible = false;
                SearchIngredientTextBox.Enabled = true;
                ChangeIngredientButton.Visible = false;
                DeleteIngredientButton.Visible = false;
                SearchIngredientButton.Enabled = true;
                SearchIngredientButton.Visible = false;
                ClearSearchingIngredientButton.Visible = false;
                RecipeInfoTextBox.Text = _recipeDB.ShowRecipe(_recipe);
            }
            catch (ArgumentException)
            {
                MessageBox.Show(
                        "Все поля должны быть заполнены!",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        //настройка интерфейса при нажатии на кнопку "Удалить рецепт"
        //И удаление рецепта из базы рецептов
        private void DeleteRecipeButton_Click(object sender, EventArgs e)
        {
            _recipeDB.DeleteRecipe(_recipe);
            MessageBox.Show(
                        "Выбранный рецепт удалён!",
                        "Информация",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            SearchRecipeTextBox.Text = "";
            SearchRecipeTextBox.Enabled = true;
            SearchRecipeButton.Enabled = true;
            RecipeInfoTextBox.Text = "";
            RecipeInfoTextBox.Visible = false;
            ChangeRecipeButton.Visible = false;
            DeleteRecipeButton.Visible = false;
            ClearSearchAndInfoButton.Visible = false;
            RecipeListTextBox.Text = _recipeDB.ShowRecipesByName();
        }

        //настройка интерфейса при нажатии на кнопку "Показать рецепты по группам"
        private void ShowRecipesByTypeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShowRecipesByTypeComboBox.Text == "")
                    throw new ArgumentException();
                RecipeListTextBox.Text = _recipeDB.ShowRecipesByType(ShowRecipesByTypeComboBox.Text);
                RecipeNameLabel.Visible = false;
                RecipeNameTextBox.Visible = false;
                RecipeNameTextBox.Text = "";
                RecipeTypeLabel.Visible = false;
                RecipeTypeComboBox.Visible = false;
                IngredientsLabel.Visible = false;
                IngredientsTextBox.Visible = false;
                IngredientsTextBox.Text = "";
                AddIngredientButton.Visible = false;
                ShowIngredientsButton.Visible = false;
                DescriptionLabel.Visible = false;
                DescriptionTextBox.Visible = false;
                DescriptionTextBox.Text = "";
                SaveRecipeButton.Visible = false;
                IngredientNameLabel.Visible = false;
                IngredientNameTextBox.Visible = false;
                IngredientNameTextBox.Text = "";
                CountLabel.Visible = false;
                CountTextBox.Visible = false;
                CountTextBox.Text = "";
                MeasureComboBox.Visible = false;
                MeasureLabel.Visible = false;
                SaveIngredientButton.Visible = false;
                SaveChangingIngredientButton.Visible = false;
                SaveChangingRecipeButton.Visible = false;
                ActionsWithIngredientButton.Visible = false;
                SearchIngredientButton.Visible = false;
                SearchIngredientTextBox.Visible = false;
                SearchIngredientTextBox.Text = "";
                ClearSearchingIngredientButton.Visible = false;
                ChangeIngredientButton.Visible = false;
                DeleteIngredientButton.Visible = false;
                if (RecipeListTextBox.Text == "")
                {
                    MessageBox.Show(
                        "Рецепты такой категории отсутствуют!",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show(
                        "Группа рецептов не выбрана!",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                RecipeNameLabel.Visible = false;
                RecipeNameTextBox.Visible = false;
                RecipeNameTextBox.Text = "";
                RecipeTypeLabel.Visible = false;
                RecipeTypeComboBox.Visible = false;
                IngredientsLabel.Visible = false;
                IngredientsTextBox.Visible = false;
                IngredientsTextBox.Text = "";
                AddIngredientButton.Visible = false;
                ShowIngredientsButton.Visible = false;
                DescriptionLabel.Visible = false;
                DescriptionTextBox.Visible = false;
                DescriptionTextBox.Text = "";
                SaveRecipeButton.Visible = false;
                IngredientNameLabel.Visible = false;
                IngredientNameTextBox.Visible = false;
                IngredientNameTextBox.Text = "";
                CountLabel.Visible = false;
                CountTextBox.Visible = false;
                CountTextBox.Text = "";
                MeasureComboBox.Visible = false;
                MeasureLabel.Visible = false;
                SaveIngredientButton.Visible = false;
                SaveChangingIngredientButton.Visible = false;
                SaveChangingRecipeButton.Visible = false;
                ActionsWithIngredientButton.Visible = false;
                SearchIngredientButton.Visible = false;
                SearchIngredientTextBox.Visible = false;
                SearchIngredientTextBox.Text = "";
                ClearSearchingIngredientButton.Visible = false;
                ChangeIngredientButton.Visible = false;
                DeleteIngredientButton.Visible = false;
            }
        }

        //настройка интерфейса при нажатии на кнопку "Действия с ингредиентом"
        private void ActionsWithIngredientButton_Click(object sender, EventArgs e)
        {
            SearchIngredientButton.Visible = true;
            SearchIngredientTextBox.Visible = true;
        }

        //настройка интерфейса при нажатии на кнопку "Поиск ингредиента"
        //И инициализация поиска ингредиента в выбранном рецепте
        private void SearchIngredientButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchIngredientTextBox.Text == "")
                    throw new ArgumentException();
                SearchIngredientTextBox.Enabled = false;
                ClearSearchingIngredientButton.Visible = true;
                string _searchedText = SearchIngredientTextBox.Text;
                var _searchedIngredient = _recipeDB.SearchIngredient(_recipe, _searchedText);
                if (_searchedIngredient.Name != null)
                {
                    ChangeIngredientButton.Visible = true;
                    DeleteIngredientButton.Visible = true;
                    SearchIngredientButton.Enabled = false;
                    _ingredient = _searchedIngredient;
                }
                else
                {
                    MessageBox.Show(
                        "Такого ингредиента в этом рецепте нет!",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    SearchIngredientTextBox.Enabled = false;
                    SearchIngredientButton.Enabled = false;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show(
                        "Поле поиска пустое!",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                SearchIngredientButton.Enabled = false;
                ClearSearchingIngredientButton.Visible = true;
            }
        }

        //настройка интерфейса при нажатии на кнопку "Очистить поиск ингредиента"
        private void ClearSearchingIngredientButton_Click(object sender, EventArgs e)
        {
            SearchIngredientTextBox.Text = "";
            SearchIngredientTextBox.Enabled = true;
            ChangeIngredientButton.Visible = false;
            DeleteIngredientButton.Visible = false;
            SearchIngredientButton.Enabled = true;
        }

        //настройка интерфейса при нажатии на кнопку "Изменить ингредиент"
        private void ChangeIngredientButton_Click(object sender, EventArgs e)
        {
            IngredientNameLabel.Visible = true;
            IngredientNameTextBox.Visible = true;
            CountLabel.Visible = true;
            CountTextBox.Visible = true;
            MeasureLabel.Visible = true;
            MeasureComboBox.Visible = true;
            SaveChangingIngredientButton.Visible = true;
            CancelAddingIngredientButton.Visible = true;
            IngredientNameTextBox.Text = _ingredient.Name;
            CountTextBox.Text = _ingredient.Count.ToString();
            MeasureComboBox.Text = _ingredient.Measure;
        }

        //настройка интерфейса при нажатии на кнопку "Сохранить изменяемый ингредиент"
        //И сохранение изменений в рецепте
        private void SaveChangingIngredientButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IngredientNameTextBox.Text == "" || CountTextBox.Text == ""
                    || MeasureComboBox.Text == "")
                {
                    throw new ArgumentException();
                }
                _recipeDB.ChangeIngredient(_recipe, _ingredient, IngredientNameTextBox.Text, Convert.ToInt32(CountTextBox.Text), MeasureComboBox.Text);
                SaveIngredientButton.Visible = false;
                IngredientNameLabel.Visible = false;
                IngredientNameTextBox.Visible = false;
                CountLabel.Visible = false;
                CountTextBox.Visible = false;
                MeasureLabel.Visible = false;
                MeasureComboBox.Visible = false;
                SaveChangingIngredientButton.Visible = false;
                SearchIngredientButton.Enabled = true;
                SearchIngredientButton.Visible = false;
                SearchIngredientTextBox.Visible = false;
                SearchIngredientTextBox.Enabled = true;
                SearchIngredientTextBox.Text = "";
                ClearSearchingIngredientButton.Visible = false;
                ChangeIngredientButton.Visible = false;
                DeleteIngredientButton.Visible = false;
                CancelAddingIngredientButton.Visible = false;
                IngredientsTextBox.Text = "";
                foreach (var i in _recipe.Ingredients)
                {
                    IngredientsTextBox.Text += i.Print();
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show(
                        "Количество ингредиентов не может быть равно нулю!",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show(
                        "Все поля должны быть заполнены!",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }


        //настройка интерфейса при нажатии на кнопку "Удалить ингредиент"
        //И удаление ингредиента из выбранного рецепта
        private void DeleteIngredientButton_Click(object sender, EventArgs e)
        {
            _recipeDB.DeleteIngredient(_recipe, _ingredient);
            MessageBox.Show(
                        "Выбранный ингредиент удалён!",
                        "Информация",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            SearchIngredientTextBox.Text = "";
            SearchIngredientTextBox.Enabled = true;
            SearchIngredientTextBox.Visible = false;
            SearchIngredientButton.Enabled = true;
            SearchIngredientButton.Visible = false;
            IngredientsTextBox.Text = "";
            foreach (var i in _recipe.Ingredients)
            {
                IngredientsTextBox.Text += i.Print();
            }
            ChangeIngredientButton.Visible = false;
            DeleteIngredientButton.Visible = false;
            ClearSearchingIngredientButton.Visible = false;
        }

        //настройка интерфейса при нажатии на кнопку "Показать рецепты по ингредиентам"
        private void ShowRecipesByIngredientButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShowRecipesByIngredientTextBox.Text == "")
                    throw new ArgumentException();
                RecipeListTextBox.Text = _recipeDB.ShowRecipesByIngredient(ShowRecipesByIngredientTextBox.Text);
                RecipeNameLabel.Visible = false;
                RecipeNameTextBox.Visible = false;
                RecipeNameTextBox.Text = "";
                RecipeTypeLabel.Visible = false;
                RecipeTypeComboBox.Visible = false;
                IngredientsLabel.Visible = false;
                IngredientsTextBox.Visible = false;
                IngredientsTextBox.Text = "";
                AddIngredientButton.Visible = false;
                ShowIngredientsButton.Visible = false;
                DescriptionLabel.Visible = false;
                DescriptionTextBox.Visible = false;
                DescriptionTextBox.Text = "";
                SaveRecipeButton.Visible = false;
                IngredientNameLabel.Visible = false;
                IngredientNameTextBox.Visible = false;
                IngredientNameTextBox.Text = "";
                CountLabel.Visible = false;
                CountTextBox.Visible = false;
                CountTextBox.Text = "";
                MeasureComboBox.Visible = false;
                MeasureLabel.Visible = false;
                SaveIngredientButton.Visible = false;
                SaveChangingIngredientButton.Visible = false;
                SaveChangingRecipeButton.Visible = false;
                ActionsWithIngredientButton.Visible = false;
                SearchIngredientButton.Visible = false;
                SearchIngredientTextBox.Visible = false;
                SearchIngredientTextBox.Text = "";
                ClearSearchingIngredientButton.Visible = false;
                ChangeIngredientButton.Visible = false;
                DeleteIngredientButton.Visible = false;
                if (RecipeListTextBox.Text == "")
                {
                    ShowRecipesByIngredientTextBox.Text = "";
                    MessageBox.Show(
                        "Искомого ингредиента нет ни в одном рецепте!",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show(
                        "Ингредиент не введён!",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                RecipeNameLabel.Visible = false;
                RecipeNameTextBox.Visible = false;
                RecipeNameTextBox.Text = "";
                RecipeTypeLabel.Visible = false;
                RecipeTypeComboBox.Visible = false;
                IngredientsLabel.Visible = false;
                IngredientsTextBox.Visible = false;
                IngredientsTextBox.Text = "";
                AddIngredientButton.Visible = false;
                ShowIngredientsButton.Visible = false;
                DescriptionLabel.Visible = false;
                DescriptionTextBox.Visible = false;
                DescriptionTextBox.Text = "";
                SaveRecipeButton.Visible = false;
                IngredientNameLabel.Visible = false;
                IngredientNameTextBox.Visible = false;
                IngredientNameTextBox.Text = "";
                CountLabel.Visible = false;
                CountTextBox.Visible = false;
                CountTextBox.Text = "";
                MeasureComboBox.Visible = false;
                MeasureLabel.Visible = false;
                SaveIngredientButton.Visible = false;
                SaveChangingIngredientButton.Visible = false;
                SaveChangingRecipeButton.Visible = false;
                ActionsWithIngredientButton.Visible = false;
                SearchIngredientButton.Visible = false;
                SearchIngredientTextBox.Visible = false;
                SearchIngredientTextBox.Text = "";
                ClearSearchingIngredientButton.Visible = false;
                ChangeIngredientButton.Visible = false;
                DeleteIngredientButton.Visible = false;
            }
        }

        //Сохранение базы рецептов в текстовый файл
        private void SaveRecipeDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _recipeDB.Save(saveFileDialog1.FileName);
                }
            }
            catch(ArgumentException exception)
            {
                MessageBox.Show(
                        exception.Message,
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        //Загрузка базы рецептов из текстового файла и вывод списка рецептов в текстовое поле
        private void LoadRecipeDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecipeListTextBox.Visible = false;
            RecipeListLabel.Visible = false;
            HideRecipeListButton.Visible = false;
            ShowRecipesByIngredientButton.Visible = false;
            ShowRecipesByIngredientTextBox.Visible = false;
            ShowRecipesByIngredientTextBox.Text = "";
            ShowRecipesByTypeButton.Visible = false;
            ShowRecipesByTypeComboBox.Visible = false;
            SearchRecipeButton.Visible = false;
            SearchRecipeButton.Enabled = true;
            SearchRecipeTextBox.Visible = false;
            SearchRecipeTextBox.Text = "";
            SearchRecipeTextBox.Enabled = true;
            ClearSearchAndInfoButton.Visible = false;
            RecipeInfoTextBox.Visible = false;
            RecipeInfoTextBox.Text = "";
            ChangeRecipeButton.Visible = false;
            DeleteRecipeButton.Visible = false;
            SaveChangingRecipeButton.Visible = false;
            ActionsWithIngredientButton.Visible = false;
            SearchIngredientButton.Visible = false;
            SearchIngredientTextBox.Visible = false;
            SearchIngredientTextBox.Text = "";
            SearchIngredientTextBox.Enabled = true;
            ClearSearchingIngredientButton.Visible = false;
            ChangeIngredientButton.Visible = false;
            DeleteIngredientButton.Visible = false;
            SaveChangingIngredientButton.Visible = false;
            IngredientNameLabel.Visible = false;
            IngredientNameTextBox.Visible = false;
            IngredientNameTextBox.Text = "";
            CountLabel.Visible = false;
            CountTextBox.Visible = false;
            CountTextBox.Text = "";
            MeasureLabel.Visible = false;
            MeasureComboBox.Visible = false;
            RecipeNameLabel.Visible = false;
            RecipeNameTextBox.Visible = false;
            RecipeNameTextBox.Text = "";
            RecipeTypeLabel.Visible = false;
            RecipeTypeComboBox.Visible = false;
            IngredientsLabel.Visible = false;
            IngredientsTextBox.Visible = false;
            IngredientsTextBox.Text = "";
            DescriptionLabel.Visible = false;
            DescriptionTextBox.Visible = false;
            DescriptionTextBox.Text = "";
            AddIngredientButton.Visible = false;
            ShowIngredientsButton.Visible = false;
            SaveRecipeButton.Visible = false;
            AddRecipeButton.Enabled = true;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                _recipeDB.Load(openFileDialog1.FileName);
                RecipeListTextBox.Text = _recipeDB.ShowRecipesByName();
            }
        }

        //Ссылка на инструкцию по пользованию программой
        private void ManualLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1x-2VTOXLezMdr_fzyW35QG8dKcuHEejd/edit?usp=sharing&ouid=110542121653010795872&rtpof=true&sd=true");
        }

        //Ограничение ввода пользователя (ввод только цифр)
        private void CountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }
    }
}
