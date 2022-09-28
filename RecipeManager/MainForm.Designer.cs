namespace RecipeManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddRecipeButton = new System.Windows.Forms.Button();
            this.RecipeDataBaseButton = new System.Windows.Forms.Button();
            this.ShowIngredientsButton = new System.Windows.Forms.Button();
            this.SaveRecipeButton = new System.Windows.Forms.Button();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.AddIngredientButton = new System.Windows.Forms.Button();
            this.IngredientsTextBox = new System.Windows.Forms.TextBox();
            this.IngredientsLabel = new System.Windows.Forms.Label();
            this.RecipeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.RecipeTypeLabel = new System.Windows.Forms.Label();
            this.RecipeNameTextBox = new System.Windows.Forms.TextBox();
            this.RecipeNameLabel = new System.Windows.Forms.Label();
            this.SaveIngredientButton = new System.Windows.Forms.Button();
            this.MeasureComboBox = new System.Windows.Forms.ComboBox();
            this.MeasureLabel = new System.Windows.Forms.Label();
            this.CountTextBox = new System.Windows.Forms.TextBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.IngredientNameTextBox = new System.Windows.Forms.TextBox();
            this.IngredientNameLabel = new System.Windows.Forms.Label();
            this.RecipeListTextBox = new System.Windows.Forms.TextBox();
            this.SearchRecipeTextBox = new System.Windows.Forms.TextBox();
            this.RecipeListLabel = new System.Windows.Forms.Label();
            this.HideRecipeListButton = new System.Windows.Forms.Button();
            this.SearchRecipeButton = new System.Windows.Forms.Button();
            this.RecipeInfoTextBox = new System.Windows.Forms.TextBox();
            this.ClearSearchAndInfoButton = new System.Windows.Forms.Button();
            this.DeleteRecipeButton = new System.Windows.Forms.Button();
            this.ChangeRecipeButton = new System.Windows.Forms.Button();
            this.SaveChangingRecipeButton = new System.Windows.Forms.Button();
            this.ShowRecipesByTypeButton = new System.Windows.Forms.Button();
            this.ShowRecipesByTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ActionsWithIngredientButton = new System.Windows.Forms.Button();
            this.ClearSearchingIngredientButton = new System.Windows.Forms.Button();
            this.SearchIngredientButton = new System.Windows.Forms.Button();
            this.SearchIngredientTextBox = new System.Windows.Forms.TextBox();
            this.DeleteIngredientButton = new System.Windows.Forms.Button();
            this.ChangeIngredientButton = new System.Windows.Forms.Button();
            this.SaveChangingIngredientButton = new System.Windows.Forms.Button();
            this.ShowRecipesByIngredientTextBox = new System.Windows.Forms.TextBox();
            this.ShowRecipesByIngredientButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveRecipeDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadRecipeDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.CancelAddingIngredientButton = new System.Windows.Forms.Button();
            this.ManualLinkLabel = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddRecipeButton
            // 
            this.AddRecipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRecipeButton.Location = new System.Drawing.Point(51, 43);
            this.AddRecipeButton.Name = "AddRecipeButton";
            this.AddRecipeButton.Size = new System.Drawing.Size(215, 33);
            this.AddRecipeButton.TabIndex = 0;
            this.AddRecipeButton.Text = "Создать рецепт";
            this.AddRecipeButton.UseVisualStyleBackColor = true;
            this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // RecipeDataBaseButton
            // 
            this.RecipeDataBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecipeDataBaseButton.Location = new System.Drawing.Point(51, 82);
            this.RecipeDataBaseButton.Name = "RecipeDataBaseButton";
            this.RecipeDataBaseButton.Size = new System.Drawing.Size(215, 34);
            this.RecipeDataBaseButton.TabIndex = 2;
            this.RecipeDataBaseButton.Text = "Показать рецепты";
            this.RecipeDataBaseButton.UseVisualStyleBackColor = true;
            this.RecipeDataBaseButton.Click += new System.EventHandler(this.RecipeDataBaseButton_Click);
            // 
            // ShowIngredientsButton
            // 
            this.ShowIngredientsButton.Enabled = false;
            this.ShowIngredientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowIngredientsButton.Location = new System.Drawing.Point(858, 208);
            this.ShowIngredientsButton.Name = "ShowIngredientsButton";
            this.ShowIngredientsButton.Size = new System.Drawing.Size(165, 64);
            this.ShowIngredientsButton.TabIndex = 21;
            this.ShowIngredientsButton.Text = "Показать ингредиенты";
            this.ShowIngredientsButton.UseVisualStyleBackColor = true;
            this.ShowIngredientsButton.Visible = false;
            this.ShowIngredientsButton.Click += new System.EventHandler(this.ShowIngredientsButton_Click);
            // 
            // SaveRecipeButton
            // 
            this.SaveRecipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveRecipeButton.Location = new System.Drawing.Point(858, 351);
            this.SaveRecipeButton.Name = "SaveRecipeButton";
            this.SaveRecipeButton.Size = new System.Drawing.Size(165, 64);
            this.SaveRecipeButton.TabIndex = 20;
            this.SaveRecipeButton.Text = "Сохранить";
            this.SaveRecipeButton.UseVisualStyleBackColor = true;
            this.SaveRecipeButton.Visible = false;
            this.SaveRecipeButton.Click += new System.EventHandler(this.SaveRecipeButton_Click);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(485, 287);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(354, 128);
            this.DescriptionTextBox.TabIndex = 19;
            this.DescriptionTextBox.Visible = false;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.Location = new System.Drawing.Point(351, 290);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(102, 25);
            this.DescriptionLabel.TabIndex = 18;
            this.DescriptionLabel.Text = "Описание";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DescriptionLabel.Visible = false;
            // 
            // AddIngredientButton
            // 
            this.AddIngredientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddIngredientButton.Location = new System.Drawing.Point(858, 138);
            this.AddIngredientButton.Name = "AddIngredientButton";
            this.AddIngredientButton.Size = new System.Drawing.Size(165, 64);
            this.AddIngredientButton.TabIndex = 17;
            this.AddIngredientButton.Text = "Добавить ингредиент";
            this.AddIngredientButton.UseVisualStyleBackColor = true;
            this.AddIngredientButton.Visible = false;
            this.AddIngredientButton.Click += new System.EventHandler(this.AddIngredientButton_Click);
            // 
            // IngredientsTextBox
            // 
            this.IngredientsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IngredientsTextBox.Location = new System.Drawing.Point(485, 138);
            this.IngredientsTextBox.Multiline = true;
            this.IngredientsTextBox.Name = "IngredientsTextBox";
            this.IngredientsTextBox.ReadOnly = true;
            this.IngredientsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IngredientsTextBox.Size = new System.Drawing.Size(354, 134);
            this.IngredientsTextBox.TabIndex = 16;
            this.IngredientsTextBox.Visible = false;
            // 
            // IngredientsLabel
            // 
            this.IngredientsLabel.AutoSize = true;
            this.IngredientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IngredientsLabel.Location = new System.Drawing.Point(315, 141);
            this.IngredientsLabel.Name = "IngredientsLabel";
            this.IngredientsLabel.Size = new System.Drawing.Size(138, 25);
            this.IngredientsLabel.TabIndex = 15;
            this.IngredientsLabel.Text = "Ингредиенты";
            this.IngredientsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IngredientsLabel.Visible = false;
            // 
            // RecipeTypeComboBox
            // 
            this.RecipeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RecipeTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecipeTypeComboBox.FormattingEnabled = true;
            this.RecipeTypeComboBox.Items.AddRange(new object[] {
            "Закуски",
            "Салаты",
            "Супы",
            "Основные блюда",
            "Гарниры",
            "Японское",
            "Выпечка",
            "Десерты",
            "Напитки",
            "Соусы"});
            this.RecipeTypeComboBox.Location = new System.Drawing.Point(485, 91);
            this.RecipeTypeComboBox.Name = "RecipeTypeComboBox";
            this.RecipeTypeComboBox.Size = new System.Drawing.Size(354, 33);
            this.RecipeTypeComboBox.TabIndex = 14;
            this.RecipeTypeComboBox.Visible = false;
            // 
            // RecipeTypeLabel
            // 
            this.RecipeTypeLabel.AutoSize = true;
            this.RecipeTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecipeTypeLabel.Location = new System.Drawing.Point(377, 99);
            this.RecipeTypeLabel.Name = "RecipeTypeLabel";
            this.RecipeTypeLabel.Size = new System.Drawing.Size(76, 25);
            this.RecipeTypeLabel.TabIndex = 13;
            this.RecipeTypeLabel.Text = "Группа";
            this.RecipeTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RecipeTypeLabel.Visible = false;
            // 
            // RecipeNameTextBox
            // 
            this.RecipeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecipeNameTextBox.Location = new System.Drawing.Point(485, 44);
            this.RecipeNameTextBox.Multiline = true;
            this.RecipeNameTextBox.Name = "RecipeNameTextBox";
            this.RecipeNameTextBox.Size = new System.Drawing.Size(354, 33);
            this.RecipeNameTextBox.TabIndex = 12;
            this.RecipeNameTextBox.Visible = false;
            // 
            // RecipeNameLabel
            // 
            this.RecipeNameLabel.AutoSize = true;
            this.RecipeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecipeNameLabel.Location = new System.Drawing.Point(354, 52);
            this.RecipeNameLabel.Name = "RecipeNameLabel";
            this.RecipeNameLabel.Size = new System.Drawing.Size(99, 25);
            this.RecipeNameLabel.TabIndex = 11;
            this.RecipeNameLabel.Text = "Название";
            this.RecipeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RecipeNameLabel.Visible = false;
            // 
            // SaveIngredientButton
            // 
            this.SaveIngredientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveIngredientButton.Location = new System.Drawing.Point(1039, 200);
            this.SaveIngredientButton.Name = "SaveIngredientButton";
            this.SaveIngredientButton.Size = new System.Drawing.Size(338, 33);
            this.SaveIngredientButton.TabIndex = 28;
            this.SaveIngredientButton.Text = "Сохранить";
            this.SaveIngredientButton.UseVisualStyleBackColor = true;
            this.SaveIngredientButton.Visible = false;
            this.SaveIngredientButton.Click += new System.EventHandler(this.SaveIngredientButton_Click);
            // 
            // MeasureComboBox
            // 
            this.MeasureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MeasureComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MeasureComboBox.FormattingEnabled = true;
            this.MeasureComboBox.Items.AddRange(new object[] {
            "шт.",
            "кг.",
            "гр.",
            "л.",
            "мл."});
            this.MeasureComboBox.Location = new System.Drawing.Point(1178, 138);
            this.MeasureComboBox.Name = "MeasureComboBox";
            this.MeasureComboBox.Size = new System.Drawing.Size(199, 33);
            this.MeasureComboBox.TabIndex = 27;
            this.MeasureComboBox.Visible = false;
            // 
            // MeasureLabel
            // 
            this.MeasureLabel.AutoSize = true;
            this.MeasureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MeasureLabel.Location = new System.Drawing.Point(1059, 141);
            this.MeasureLabel.Name = "MeasureLabel";
            this.MeasureLabel.Size = new System.Drawing.Size(60, 25);
            this.MeasureLabel.TabIndex = 26;
            this.MeasureLabel.Text = "Мера";
            this.MeasureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MeasureLabel.Visible = false;
            // 
            // CountTextBox
            // 
            this.CountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountTextBox.Location = new System.Drawing.Point(1178, 89);
            this.CountTextBox.Multiline = true;
            this.CountTextBox.Name = "CountTextBox";
            this.CountTextBox.Size = new System.Drawing.Size(199, 33);
            this.CountTextBox.TabIndex = 25;
            this.CountTextBox.Visible = false;
            this.CountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountTextBox_KeyPress);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountLabel.Location = new System.Drawing.Point(1035, 92);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(123, 25);
            this.CountLabel.TabIndex = 24;
            this.CountLabel.Text = "Количество";
            this.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountLabel.Visible = false;
            // 
            // IngredientNameTextBox
            // 
            this.IngredientNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IngredientNameTextBox.Location = new System.Drawing.Point(1178, 40);
            this.IngredientNameTextBox.Multiline = true;
            this.IngredientNameTextBox.Name = "IngredientNameTextBox";
            this.IngredientNameTextBox.Size = new System.Drawing.Size(199, 33);
            this.IngredientNameTextBox.TabIndex = 23;
            this.IngredientNameTextBox.Visible = false;
            // 
            // IngredientNameLabel
            // 
            this.IngredientNameLabel.AutoSize = true;
            this.IngredientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IngredientNameLabel.Location = new System.Drawing.Point(1034, 43);
            this.IngredientNameLabel.Name = "IngredientNameLabel";
            this.IngredientNameLabel.Size = new System.Drawing.Size(124, 25);
            this.IngredientNameLabel.TabIndex = 22;
            this.IngredientNameLabel.Text = "Ингредиент";
            this.IngredientNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IngredientNameLabel.Visible = false;
            // 
            // RecipeListTextBox
            // 
            this.RecipeListTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecipeListTextBox.Location = new System.Drawing.Point(51, 433);
            this.RecipeListTextBox.Multiline = true;
            this.RecipeListTextBox.Name = "RecipeListTextBox";
            this.RecipeListTextBox.ReadOnly = true;
            this.RecipeListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecipeListTextBox.Size = new System.Drawing.Size(325, 291);
            this.RecipeListTextBox.TabIndex = 29;
            this.RecipeListTextBox.Visible = false;
            // 
            // SearchRecipeTextBox
            // 
            this.SearchRecipeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchRecipeTextBox.Location = new System.Drawing.Point(559, 433);
            this.SearchRecipeTextBox.Multiline = true;
            this.SearchRecipeTextBox.Name = "SearchRecipeTextBox";
            this.SearchRecipeTextBox.Size = new System.Drawing.Size(280, 33);
            this.SearchRecipeTextBox.TabIndex = 30;
            this.SearchRecipeTextBox.Visible = false;
            // 
            // RecipeListLabel
            // 
            this.RecipeListLabel.AutoSize = true;
            this.RecipeListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecipeListLabel.Location = new System.Drawing.Point(129, 405);
            this.RecipeListLabel.Name = "RecipeListLabel";
            this.RecipeListLabel.Size = new System.Drawing.Size(172, 25);
            this.RecipeListLabel.TabIndex = 31;
            this.RecipeListLabel.Text = "Список рецептов";
            this.RecipeListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RecipeListLabel.Visible = false;
            // 
            // HideRecipeListButton
            // 
            this.HideRecipeListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HideRecipeListButton.Location = new System.Drawing.Point(105, 730);
            this.HideRecipeListButton.Name = "HideRecipeListButton";
            this.HideRecipeListButton.Size = new System.Drawing.Size(215, 33);
            this.HideRecipeListButton.TabIndex = 32;
            this.HideRecipeListButton.Text = "Скрыть";
            this.HideRecipeListButton.UseVisualStyleBackColor = true;
            this.HideRecipeListButton.Visible = false;
            this.HideRecipeListButton.Click += new System.EventHandler(this.HideRecipeListButton_Click);
            // 
            // SearchRecipeButton
            // 
            this.SearchRecipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchRecipeButton.Location = new System.Drawing.Point(382, 433);
            this.SearchRecipeButton.Name = "SearchRecipeButton";
            this.SearchRecipeButton.Size = new System.Drawing.Size(171, 33);
            this.SearchRecipeButton.TabIndex = 33;
            this.SearchRecipeButton.Text = "Поиск...";
            this.SearchRecipeButton.UseVisualStyleBackColor = true;
            this.SearchRecipeButton.Visible = false;
            this.SearchRecipeButton.Click += new System.EventHandler(this.SearchRecipeButton_Click);
            // 
            // RecipeInfoTextBox
            // 
            this.RecipeInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecipeInfoTextBox.Location = new System.Drawing.Point(858, 433);
            this.RecipeInfoTextBox.Multiline = true;
            this.RecipeInfoTextBox.Name = "RecipeInfoTextBox";
            this.RecipeInfoTextBox.ReadOnly = true;
            this.RecipeInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecipeInfoTextBox.Size = new System.Drawing.Size(352, 330);
            this.RecipeInfoTextBox.TabIndex = 34;
            this.RecipeInfoTextBox.Visible = false;
            // 
            // ClearSearchAndInfoButton
            // 
            this.ClearSearchAndInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearSearchAndInfoButton.Location = new System.Drawing.Point(382, 472);
            this.ClearSearchAndInfoButton.Name = "ClearSearchAndInfoButton";
            this.ClearSearchAndInfoButton.Size = new System.Drawing.Size(171, 33);
            this.ClearSearchAndInfoButton.TabIndex = 35;
            this.ClearSearchAndInfoButton.Text = "Очистить";
            this.ClearSearchAndInfoButton.UseVisualStyleBackColor = true;
            this.ClearSearchAndInfoButton.Visible = false;
            this.ClearSearchAndInfoButton.Click += new System.EventHandler(this.ClearSearchAndInfoButton_Click);
            // 
            // DeleteRecipeButton
            // 
            this.DeleteRecipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteRecipeButton.Location = new System.Drawing.Point(1216, 472);
            this.DeleteRecipeButton.Name = "DeleteRecipeButton";
            this.DeleteRecipeButton.Size = new System.Drawing.Size(171, 33);
            this.DeleteRecipeButton.TabIndex = 37;
            this.DeleteRecipeButton.Text = "Удалить";
            this.DeleteRecipeButton.UseVisualStyleBackColor = true;
            this.DeleteRecipeButton.Visible = false;
            this.DeleteRecipeButton.Click += new System.EventHandler(this.DeleteRecipeButton_Click);
            // 
            // ChangeRecipeButton
            // 
            this.ChangeRecipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeRecipeButton.Location = new System.Drawing.Point(1216, 433);
            this.ChangeRecipeButton.Name = "ChangeRecipeButton";
            this.ChangeRecipeButton.Size = new System.Drawing.Size(171, 33);
            this.ChangeRecipeButton.TabIndex = 36;
            this.ChangeRecipeButton.Text = "Изменить...";
            this.ChangeRecipeButton.UseVisualStyleBackColor = true;
            this.ChangeRecipeButton.Visible = false;
            this.ChangeRecipeButton.Click += new System.EventHandler(this.ChangeRecipeButton_Click);
            // 
            // SaveChangingRecipeButton
            // 
            this.SaveChangingRecipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChangingRecipeButton.Location = new System.Drawing.Point(858, 351);
            this.SaveChangingRecipeButton.Name = "SaveChangingRecipeButton";
            this.SaveChangingRecipeButton.Size = new System.Drawing.Size(165, 64);
            this.SaveChangingRecipeButton.TabIndex = 38;
            this.SaveChangingRecipeButton.Text = "Сохранить";
            this.SaveChangingRecipeButton.UseVisualStyleBackColor = true;
            this.SaveChangingRecipeButton.Visible = false;
            this.SaveChangingRecipeButton.Click += new System.EventHandler(this.SaveChangingRecipeButton_Click);
            // 
            // ShowRecipesByTypeButton
            // 
            this.ShowRecipesByTypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowRecipesByTypeButton.Location = new System.Drawing.Point(51, 161);
            this.ShowRecipesByTypeButton.Name = "ShowRecipesByTypeButton";
            this.ShowRecipesByTypeButton.Size = new System.Drawing.Size(215, 34);
            this.ShowRecipesByTypeButton.TabIndex = 39;
            this.ShowRecipesByTypeButton.Text = "По группам";
            this.ShowRecipesByTypeButton.UseVisualStyleBackColor = true;
            this.ShowRecipesByTypeButton.Visible = false;
            this.ShowRecipesByTypeButton.Click += new System.EventHandler(this.ShowRecipesByTypeButton_Click);
            // 
            // ShowRecipesByTypeComboBox
            // 
            this.ShowRecipesByTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShowRecipesByTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowRecipesByTypeComboBox.FormattingEnabled = true;
            this.ShowRecipesByTypeComboBox.Items.AddRange(new object[] {
            "Закуски",
            "Салаты",
            "Супы",
            "Основные блюда",
            "Гарниры",
            "Японское ",
            "Выпечка",
            "Десерты",
            "Напитки",
            "Соусы"});
            this.ShowRecipesByTypeComboBox.Location = new System.Drawing.Point(51, 122);
            this.ShowRecipesByTypeComboBox.Name = "ShowRecipesByTypeComboBox";
            this.ShowRecipesByTypeComboBox.Size = new System.Drawing.Size(215, 33);
            this.ShowRecipesByTypeComboBox.TabIndex = 40;
            this.ShowRecipesByTypeComboBox.Visible = false;
            // 
            // ActionsWithIngredientButton
            // 
            this.ActionsWithIngredientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionsWithIngredientButton.Location = new System.Drawing.Point(858, 278);
            this.ActionsWithIngredientButton.Name = "ActionsWithIngredientButton";
            this.ActionsWithIngredientButton.Size = new System.Drawing.Size(165, 67);
            this.ActionsWithIngredientButton.TabIndex = 41;
            this.ActionsWithIngredientButton.Text = "Действия с ингредиентом";
            this.ActionsWithIngredientButton.UseVisualStyleBackColor = true;
            this.ActionsWithIngredientButton.Visible = false;
            this.ActionsWithIngredientButton.Click += new System.EventHandler(this.ActionsWithIngredientButton_Click);
            // 
            // ClearSearchingIngredientButton
            // 
            this.ClearSearchingIngredientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearSearchingIngredientButton.Location = new System.Drawing.Point(1040, 360);
            this.ClearSearchingIngredientButton.Name = "ClearSearchingIngredientButton";
            this.ClearSearchingIngredientButton.Size = new System.Drawing.Size(171, 33);
            this.ClearSearchingIngredientButton.TabIndex = 44;
            this.ClearSearchingIngredientButton.Text = "Очистить";
            this.ClearSearchingIngredientButton.UseVisualStyleBackColor = true;
            this.ClearSearchingIngredientButton.Visible = false;
            this.ClearSearchingIngredientButton.Click += new System.EventHandler(this.ClearSearchingIngredientButton_Click);
            // 
            // SearchIngredientButton
            // 
            this.SearchIngredientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchIngredientButton.Location = new System.Drawing.Point(1040, 321);
            this.SearchIngredientButton.Name = "SearchIngredientButton";
            this.SearchIngredientButton.Size = new System.Drawing.Size(171, 33);
            this.SearchIngredientButton.TabIndex = 43;
            this.SearchIngredientButton.Text = "Поиск...";
            this.SearchIngredientButton.UseVisualStyleBackColor = true;
            this.SearchIngredientButton.Visible = false;
            this.SearchIngredientButton.Click += new System.EventHandler(this.SearchIngredientButton_Click);
            // 
            // SearchIngredientTextBox
            // 
            this.SearchIngredientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchIngredientTextBox.Location = new System.Drawing.Point(1040, 278);
            this.SearchIngredientTextBox.Multiline = true;
            this.SearchIngredientTextBox.Name = "SearchIngredientTextBox";
            this.SearchIngredientTextBox.Size = new System.Drawing.Size(348, 33);
            this.SearchIngredientTextBox.TabIndex = 42;
            this.SearchIngredientTextBox.Visible = false;
            // 
            // DeleteIngredientButton
            // 
            this.DeleteIngredientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteIngredientButton.Location = new System.Drawing.Point(1217, 361);
            this.DeleteIngredientButton.Name = "DeleteIngredientButton";
            this.DeleteIngredientButton.Size = new System.Drawing.Size(171, 32);
            this.DeleteIngredientButton.TabIndex = 46;
            this.DeleteIngredientButton.Text = "Удалить";
            this.DeleteIngredientButton.UseVisualStyleBackColor = true;
            this.DeleteIngredientButton.Visible = false;
            this.DeleteIngredientButton.Click += new System.EventHandler(this.DeleteIngredientButton_Click);
            // 
            // ChangeIngredientButton
            // 
            this.ChangeIngredientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeIngredientButton.Location = new System.Drawing.Point(1217, 322);
            this.ChangeIngredientButton.Name = "ChangeIngredientButton";
            this.ChangeIngredientButton.Size = new System.Drawing.Size(171, 33);
            this.ChangeIngredientButton.TabIndex = 45;
            this.ChangeIngredientButton.Text = "Изменить...";
            this.ChangeIngredientButton.UseVisualStyleBackColor = true;
            this.ChangeIngredientButton.Visible = false;
            this.ChangeIngredientButton.Click += new System.EventHandler(this.ChangeIngredientButton_Click);
            // 
            // SaveChangingIngredientButton
            // 
            this.SaveChangingIngredientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChangingIngredientButton.Location = new System.Drawing.Point(1039, 200);
            this.SaveChangingIngredientButton.Name = "SaveChangingIngredientButton";
            this.SaveChangingIngredientButton.Size = new System.Drawing.Size(338, 33);
            this.SaveChangingIngredientButton.TabIndex = 47;
            this.SaveChangingIngredientButton.Text = "Сохранить";
            this.SaveChangingIngredientButton.UseVisualStyleBackColor = true;
            this.SaveChangingIngredientButton.Visible = false;
            this.SaveChangingIngredientButton.Click += new System.EventHandler(this.SaveChangingIngredientButton_Click);
            // 
            // ShowRecipesByIngredientTextBox
            // 
            this.ShowRecipesByIngredientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowRecipesByIngredientTextBox.Location = new System.Drawing.Point(51, 201);
            this.ShowRecipesByIngredientTextBox.Multiline = true;
            this.ShowRecipesByIngredientTextBox.Name = "ShowRecipesByIngredientTextBox";
            this.ShowRecipesByIngredientTextBox.Size = new System.Drawing.Size(215, 33);
            this.ShowRecipesByIngredientTextBox.TabIndex = 48;
            this.ShowRecipesByIngredientTextBox.Visible = false;
            // 
            // ShowRecipesByIngredientButton
            // 
            this.ShowRecipesByIngredientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowRecipesByIngredientButton.Location = new System.Drawing.Point(51, 240);
            this.ShowRecipesByIngredientButton.Name = "ShowRecipesByIngredientButton";
            this.ShowRecipesByIngredientButton.Size = new System.Drawing.Size(215, 34);
            this.ShowRecipesByIngredientButton.TabIndex = 49;
            this.ShowRecipesByIngredientButton.Text = "По ингредиентам";
            this.ShowRecipesByIngredientButton.UseVisualStyleBackColor = true;
            this.ShowRecipesByIngredientButton.Visible = false;
            this.ShowRecipesByIngredientButton.Click += new System.EventHandler(this.ShowRecipesByIngredientButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ActionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1409, 36);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ActionsToolStripMenuItem
            // 
            this.ActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveRecipeDBToolStripMenuItem,
            this.LoadRecipeDBToolStripMenuItem});
            this.ActionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem";
            this.ActionsToolStripMenuItem.Size = new System.Drawing.Size(72, 32);
            this.ActionsToolStripMenuItem.Text = "Файл";
            // 
            // SaveRecipeDBToolStripMenuItem
            // 
            this.SaveRecipeDBToolStripMenuItem.Name = "SaveRecipeDBToolStripMenuItem";
            this.SaveRecipeDBToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveRecipeDBToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.SaveRecipeDBToolStripMenuItem.Text = "Сохранить";
            this.SaveRecipeDBToolStripMenuItem.Click += new System.EventHandler(this.SaveRecipeDBToolStripMenuItem_Click);
            // 
            // LoadRecipeDBToolStripMenuItem
            // 
            this.LoadRecipeDBToolStripMenuItem.Name = "LoadRecipeDBToolStripMenuItem";
            this.LoadRecipeDBToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.LoadRecipeDBToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.LoadRecipeDBToolStripMenuItem.Text = "Загрузить";
            this.LoadRecipeDBToolStripMenuItem.Click += new System.EventHandler(this.LoadRecipeDBToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.txt)|*.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "(*.txt)|*.txt";
            // 
            // CancelAddingIngredientButton
            // 
            this.CancelAddingIngredientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelAddingIngredientButton.Location = new System.Drawing.Point(1040, 239);
            this.CancelAddingIngredientButton.Name = "CancelAddingIngredientButton";
            this.CancelAddingIngredientButton.Size = new System.Drawing.Size(338, 33);
            this.CancelAddingIngredientButton.TabIndex = 51;
            this.CancelAddingIngredientButton.Text = "Отменить";
            this.CancelAddingIngredientButton.UseVisualStyleBackColor = true;
            this.CancelAddingIngredientButton.Visible = false;
            this.CancelAddingIngredientButton.Click += new System.EventHandler(this.CancelAddingIngredientButton_Click);
            // 
            // ManualLinkLabel
            // 
            this.ManualLinkLabel.AutoSize = true;
            this.ManualLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManualLinkLabel.Location = new System.Drawing.Point(1317, 741);
            this.ManualLinkLabel.Name = "ManualLinkLabel";
            this.ManualLinkLabel.Size = new System.Drawing.Size(80, 25);
            this.ManualLinkLabel.TabIndex = 52;
            this.ManualLinkLabel.TabStop = true;
            this.ManualLinkLabel.Text = "Мануал";
            this.ManualLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ManualLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 775);
            this.Controls.Add(this.ManualLinkLabel);
            this.Controls.Add(this.CancelAddingIngredientButton);
            this.Controls.Add(this.ShowRecipesByIngredientButton);
            this.Controls.Add(this.ShowRecipesByIngredientTextBox);
            this.Controls.Add(this.SaveChangingIngredientButton);
            this.Controls.Add(this.DeleteIngredientButton);
            this.Controls.Add(this.ChangeIngredientButton);
            this.Controls.Add(this.ClearSearchingIngredientButton);
            this.Controls.Add(this.SearchIngredientButton);
            this.Controls.Add(this.SearchIngredientTextBox);
            this.Controls.Add(this.ActionsWithIngredientButton);
            this.Controls.Add(this.ShowRecipesByTypeComboBox);
            this.Controls.Add(this.ShowRecipesByTypeButton);
            this.Controls.Add(this.SaveChangingRecipeButton);
            this.Controls.Add(this.DeleteRecipeButton);
            this.Controls.Add(this.ChangeRecipeButton);
            this.Controls.Add(this.ClearSearchAndInfoButton);
            this.Controls.Add(this.RecipeInfoTextBox);
            this.Controls.Add(this.SearchRecipeButton);
            this.Controls.Add(this.HideRecipeListButton);
            this.Controls.Add(this.RecipeListLabel);
            this.Controls.Add(this.SearchRecipeTextBox);
            this.Controls.Add(this.RecipeListTextBox);
            this.Controls.Add(this.SaveIngredientButton);
            this.Controls.Add(this.MeasureComboBox);
            this.Controls.Add(this.MeasureLabel);
            this.Controls.Add(this.CountTextBox);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.IngredientNameTextBox);
            this.Controls.Add(this.IngredientNameLabel);
            this.Controls.Add(this.ShowIngredientsButton);
            this.Controls.Add(this.SaveRecipeButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.AddIngredientButton);
            this.Controls.Add(this.IngredientsTextBox);
            this.Controls.Add(this.IngredientsLabel);
            this.Controls.Add(this.RecipeTypeComboBox);
            this.Controls.Add(this.RecipeTypeLabel);
            this.Controls.Add(this.RecipeNameTextBox);
            this.Controls.Add(this.RecipeNameLabel);
            this.Controls.Add(this.RecipeDataBaseButton);
            this.Controls.Add(this.AddRecipeButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Менеджер рецептов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRecipeButton;
        private System.Windows.Forms.Button RecipeDataBaseButton;
        private System.Windows.Forms.Button ShowIngredientsButton;
        private System.Windows.Forms.Button SaveRecipeButton;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button AddIngredientButton;
        private System.Windows.Forms.TextBox IngredientsTextBox;
        private System.Windows.Forms.Label IngredientsLabel;
        private System.Windows.Forms.ComboBox RecipeTypeComboBox;
        private System.Windows.Forms.Label RecipeTypeLabel;
        private System.Windows.Forms.TextBox RecipeNameTextBox;
        private System.Windows.Forms.Label RecipeNameLabel;
        private System.Windows.Forms.Button SaveIngredientButton;
        private System.Windows.Forms.ComboBox MeasureComboBox;
        private System.Windows.Forms.Label MeasureLabel;
        private System.Windows.Forms.TextBox CountTextBox;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.TextBox IngredientNameTextBox;
        private System.Windows.Forms.Label IngredientNameLabel;
        private System.Windows.Forms.TextBox RecipeListTextBox;
        private System.Windows.Forms.TextBox SearchRecipeTextBox;
        private System.Windows.Forms.Label RecipeListLabel;
        private System.Windows.Forms.Button HideRecipeListButton;
        private System.Windows.Forms.Button SearchRecipeButton;
        private System.Windows.Forms.TextBox RecipeInfoTextBox;
        private System.Windows.Forms.Button ClearSearchAndInfoButton;
        private System.Windows.Forms.Button DeleteRecipeButton;
        private System.Windows.Forms.Button ChangeRecipeButton;
        private System.Windows.Forms.Button SaveChangingRecipeButton;
        private System.Windows.Forms.Button ShowRecipesByTypeButton;
        private System.Windows.Forms.ComboBox ShowRecipesByTypeComboBox;
        private System.Windows.Forms.Button ActionsWithIngredientButton;
        private System.Windows.Forms.Button ClearSearchingIngredientButton;
        private System.Windows.Forms.Button SearchIngredientButton;
        private System.Windows.Forms.TextBox SearchIngredientTextBox;
        private System.Windows.Forms.Button DeleteIngredientButton;
        private System.Windows.Forms.Button ChangeIngredientButton;
        private System.Windows.Forms.Button SaveChangingIngredientButton;
        private System.Windows.Forms.TextBox ShowRecipesByIngredientTextBox;
        private System.Windows.Forms.Button ShowRecipesByIngredientButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveRecipeDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadRecipeDBToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button CancelAddingIngredientButton;
        private System.Windows.Forms.LinkLabel ManualLinkLabel;
    }
}

