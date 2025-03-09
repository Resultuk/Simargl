using Aga.Controls.Tree;
using Aga.Controls.Tree.NodeControls;
using Growor.Recipe;
using GroworDesktop.ServerData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroworDesktop
{
    public partial class FormForRecipe : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public RecipeInfo RecipeInfo { get; set; }
        private Recipe recipe;
        private ModelForRecipe ModelForRecipe;
        private NodeTextBox nodeRecipeName = new NodeTextBox() { DataPropertyName = "Name", EditEnabled = true };
        private NodeTextBox nodeRecipeDuration = new NodeTextBox() { DataPropertyName = "Duration", EditEnabled = true, TextAlign = HorizontalAlignment.Center };
        private NodeTextBox nodeRecipeInformation = new NodeTextBox() { DataPropertyName = "Information", TextAlign = HorizontalAlignment.Left };

        public FormForRecipe(Recipe recipe)
        {
            this.recipe = recipe;
            ModelForRecipe = new ModelForRecipe() { Recipe = this.recipe };
            InitializeComponent();
            nodeRecipeName.ParentColumn = tcRecipeName;
            nodeRecipeDuration.ParentColumn = tcRecipeDuration;
            nodeRecipeInformation.ParentColumn = tcRecipeInformation;
            tvaRecipe.NodeControls.Add(nodeRecipeName);
            tvaRecipe.NodeControls.Add(nodeRecipeDuration);
            tvaRecipe.NodeControls.Add(nodeRecipeInformation);
            tvaRecipe.Model = ModelForRecipe;

            this.Text = this.recipe.Name;
        }
        private Recipe GetRecipeFromString(string data)
        {
            try
            {
                return System.Text.Json.JsonSerializer.Deserialize<Recipe>(data);
            }
            catch
            {
                return new Recipe();
            }
        }
        private string GetStringFromRecipe(Recipe recipe)
        {
            try
            {
                return System.Text.Json.JsonSerializer.Serialize(recipe);
            }
            catch
            {
                return string.Empty;
            }
        }
        private void tsbAddPhase_Click(object sender, EventArgs e)
        {
            recipe.AddPhase();
            RefreshTree(true);
        }
        private void tsbDelPhase_Click(object sender, EventArgs e)
        {
            RemoveItemTree(tvaRecipe);
        }
        private void FormForRecipe_Load(object sender, EventArgs e)
        {
            ModelForRecipe.NotifyStructureChanged(TreePath.Empty);
        }
        private void tsmiAddLighting_Click(object sender, EventArgs e)
        {
            if (tvaRecipe.SelectedNode != null && tvaRecipe.SelectedNode.Tag is PhaseInfo PI)
            {
                PI.Phase.Add(ActionsType.Lighting, new Period() { StartTime = 0, Duration = 15 });
                RefreshTree(true);
            }
        }
        private void CopyItemTree(TreeViewAdv tree)
        {
            if (tree.SelectedNode == null) return;
            if (tree.SelectedNode.Tag is PhaseInfo phi)
            {
                recipe.AddPhase((Phase)phi.Phase.Clone());
            }
            RefreshTree(true);
        }
        private void RemoveItemTree(TreeViewAdv tree)
        {
            if (tree.SelectedNode == null) return;
            if (tree.SelectedNode.Tag is PhaseInfo phi)
            {
                try
                {
                    recipe.Phases.Remove(phi.Phase);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (tree.SelectedNode.Tag is PeriodInfo pi)
            {
                try
                {
                    ((CategoryInfo)tree.SelectedNode.Parent.Tag).Periods.Remove(pi.Period);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (tree.SelectedNode.Tag is ActionInfo ai)
            {
                try
                {
                    ((PeriodInfo)tree.SelectedNode.Parent.Tag).Period.Actions.Remove(ai.Action);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            RefreshTree(true);
        }
        private void RefreshTree(bool keep = false)
        {
            if (keep)
            {
                var r = Classes.TreeViewExtensions.GetExpandedNodesState(tvaRecipe);
                ModelForRecipe.NotifyStructureChanged(TreePath.Empty);
                Classes.TreeViewExtensions.RestoreExpandedNodesState(tvaRecipe, r);
            }
            else
            {
                ModelForRecipe.NotifyStructureChanged(TreePath.Empty);
            }
        }
        private void tmsiAddParameter_Click(object sender, EventArgs e)
        {
            if (tvaRecipe.SelectedNode != null && tvaRecipe.SelectedNode.Tag is PeriodInfo PI)
            {
                PI.Period.Actions.Add(new Growor.Recipe.Action() { Name = "Blue", UnitOfMeasure = "%", Reduction = "B", Description = "Channel-1", Value = 0 });
                RefreshTree(true);
            }
        }
        private void tsmiCalcPeriods_Click(object sender, EventArgs e)
        {
            if (tvaRecipe.SelectedNode != null && tvaRecipe.SelectedNode.Tag is PhaseInfo PI)
            {
                PI.Phase.CalcLight();
                RefreshTree(true);
            }
        }
        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            if (tvaRecipe.SelectedNode != null && tvaRecipe.SelectedNode.Tag is PeriodInfo PI)
            {
                ((PhaseInfo)tvaRecipe.SelectedNode.Parent.Parent.Tag).Phase.Lighting.Add((Period)PI.Period.Clone());
                RefreshTree(true);
            }
        }
        private void tsmiAddGroworLight_Click(object sender, EventArgs e)
        {
            if (tvaRecipe.SelectedNode != null && tvaRecipe.SelectedNode.Tag is PeriodInfo PI)
            {
                PI.Period.Actions.Add(new Growor.Recipe.Action() { Name = "Blue", UnitOfMeasure = "%", Reduction = "B", Description = "Channel-1", Value = 0 });
                PI.Period.Actions.Add(new Growor.Recipe.Action() { Name = "Red", UnitOfMeasure = "%", Reduction = "R", Description = "Channel-2", Value = 0 });
                PI.Period.Actions.Add(new Growor.Recipe.Action() { Name = "Deep Blue", UnitOfMeasure = "%", Reduction = "DB", Description = "Channel-3", Value = 0 });
                PI.Period.Actions.Add(new Growor.Recipe.Action() { Name = "Far Red", UnitOfMeasure = "%", Reduction = "FR", Description = "Channel-4", Value = 0 });
                RefreshTree(true);
            }
        }
        private void tsbCopyItem_Click(object sender, EventArgs e)
        {
            CopyItemTree(tvaRecipe);
        }

        private void conMenu_Opening(object sender, CancelEventArgs e)
        {
            var treeView = tvaRecipe;
            if (treeView.SelectedNode == null)
            {

            }
            else
            {
                if (treeView.SelectedNode.Tag is PhaseInfo phi)
                {
                    tsmiAddPeriod.Visible = false;
                    if (phi.Phase.Lighting.Count < 1)
                        tsmiLighting.Visible = true;
                    else
                        tsmiLighting.Visible = false;
                    if (phi.Phase.Controls.Count < 1)
                        tsmiAddControling.Visible = true;
                    else
                        tsmiAddControling.Visible = false;
                }
                else if (treeView.SelectedNode.Tag is CategoryInfo)
                {
                    tsmiAddPeriod.Visible = true;
                    tsmiLighting.Visible = false;
                    tsmiAddControling.Visible = false;
                }
                else if (treeView.SelectedNode.Tag is PeriodInfo)
                {
                    tsmiAddPeriod.Visible = false;
                    tsmiLighting.Visible = false;
                    tsmiAddControling.Visible = false;
                }
                else if (treeView.SelectedNode.Tag is ActionInfo)
                {
                    tsmiAddPeriod.Visible = false;
                    tsmiLighting.Visible = false;
                    tsmiAddControling.Visible = false;
                }
            }
        }
    }
    public class ModelForRecipe : TreeModelBase
    {
        public Recipe Recipe { get; set; }
        public override IEnumerable GetChildren(TreePath treePath)
        {
            ArrayList arrayList = new();
            lock (Recipe)
            {
                if (treePath.IsEmpty())
                {
                    foreach (var phase in Recipe.Phases)
                    {
                        arrayList.Add(new PhaseInfo() { Phase = phase });
                    }
                }
                else
                {
                    if (treePath.LastNode is PhaseInfo PI)
                    {
                        if (PI.Phase.Lighting.Count > 0) arrayList.Add(new CategoryInfo() { Name = "Lighting", Periods = PI.Phase.Lighting });
                        if (PI.Phase.Watering.Count > 0) arrayList.Add(new CategoryInfo() { Name = "Watering" });
                    }
                    if (treePath.LastNode is CategoryInfo CI)
                    {
                        switch(CI.Name)
                        {
                            case "Lighting":
                                if (treePath.FirstNode is PhaseInfo PIN)
                                {
                                    foreach (var light in PIN.Phase.Lighting)
                                    {
                                        arrayList.Add(new PeriodInfo() { Period = light });
                                    }
                                }
                                break;
                        }
                    }
                    if (treePath.LastNode is PeriodInfo pi)
                    {
                        foreach (var step in pi.Period.Actions)
                        {
                            arrayList.Add(new ActionInfo() { Action = step });
                        }
                    }
                }
            }
            return arrayList;
        }

        public override bool IsLeaf(TreePath treePath)
        {
            return treePath.LastNode is ActionInfo;
        }
        public void NotifyStructureChanged(TreePath treePath)
        {
            OnStructureChanged(new TreePathEventArgs(treePath));
        }
    }
}
