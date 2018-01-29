using System;
namespace Lib
{
	public class MeasuredItem
	{
        public long ID;
		public FoodItem FoodItem;
		public decimal Qty;

		
		public MeasuredItem(FoodItem item, decimal qty)
		{
			FoodItem = item;
			Qty = qty;
		}
	}
}

//Recipes 1. table
//ID
//Name
//Cooking time

//RecipeIngredients 2. table
//ID
//RecipeID
//FoodItemID
//Qty

//Recipe class
//ID
//Name
//Cooking time
//List<MeasuredItem>
//Save()
///doStandardLogicForRecipeFields
///foreach ingredient
///see if it has id
///if it has id then update
///else insert new one


