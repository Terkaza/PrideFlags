using PrideFlags.Tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace PrideFlags.Items
{
	public class NonbinaryFlag : ModItem
	{
		// The tooltip for this item is automatically assigned from .lang files
		public override void SetDefaults() {
			item.width = 10;
			item.height = 24;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.rare = ItemRarityID.Expert;
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.createTile = mod.TileType("NonbinaryFlag");
			item.placeStyle = 0;
		}
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddIngredient(ItemID.YellowDye, 1);	
            recipe.AddIngredient(ItemID.BrightSilverDye, 1);			
            recipe.AddIngredient(ItemID.PurpleDye, 1);		
            recipe.AddIngredient(ItemID.BlackDye, 1);			
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}