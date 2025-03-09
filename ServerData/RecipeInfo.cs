using Growor.Recipe;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GroworDesktop.ServerData
{
    public class RecipeInfo
    {
        private Recipe recipe;
        private string _value = string.Empty;
        public int Id { get; set; }
        public string Value 
        {
            get => _value;
            set
            {
                try
                {
                    _value = value;
                    recipe = System.Text.Json.JsonSerializer.Deserialize<Recipe>(value);
                }
                catch
                {
                    recipe = new Recipe();
                }
                if (recipe != null)
                    recipe.PropertyChanged += (s, e) => { RecipeChanged?.Invoke(this, new EventArgs()); };
            }
        }
        public string DataBaseValue { get; set; } = string.Empty;
        public int UserID { get; set; } = -1;
        public bool AnyChanges => !_value.Equals(GetStringFromRecipe(recipe));
        public Recipe Recipe => recipe;
        public string Name {  get => recipe.Name; set => recipe.Name = value; }
        public string Description { get => recipe.Description; set => recipe.Description = value; }
        public Bitmap Icon
        {
            get
            {
                if (AnyChanges)
                    return Simargl.Res.pencil;
                else
                    return Simargl.Res.check;
            }
        }
        public RecipeInfo(RecipeTransfer recipeTransfer)
        {
            Id = recipeTransfer.Id;
            Value = recipeTransfer.Value;
            UserID = recipeTransfer.UserId;
        }
        public EventHandler ValueChanged;
        private string clientValue = string.Empty;
        public void SetValue(RecipeTransfer recipeTransfer)
        {
            if (recipeTransfer == null || recipeTransfer.Id != Id) return;
            _value = recipeTransfer.Value;
            UserID = recipeTransfer.UserId;
        }
        public RecipeTransfer GetForTransfer()
        {
            return new RecipeTransfer()
            {
                Id = Id,
                Value = GetStringFromRecipe(recipe),
                UserId = UserID,
            };
        }
        private string GetStringFromRecipe(Recipe recipe)
        {
            try
            {
                return System.Text.Json.JsonSerializer.Serialize(recipe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return string.Empty;
            }
        }
        public EventHandler RecipeChanged;
    }
    public class RecipeTransfer
    {
        public int Id { get; set; }
        public string Value { get; set; } = string.Empty;
        public int UserId { get; set; } = -1;
    }
}
