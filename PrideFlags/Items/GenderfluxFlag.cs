using PrideFlags.Tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace PrideFlags.Items
{
	public class GenderfluxFlag : ModItem
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
			item.createTile = mod.TileType("GenderfluxFlag");
			item.placeStyle = 0;
		}
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 5);
            recipe.AddIngredient(ItemID.BrightPinkDye, 1);	
            recipe.AddIngredient(ItemID.BrightRedDye, 1);			
            recipe.AddIngredient(ItemID.SilverDye, 1);			
            recipe.AddIngredient(ItemID.BrightCyanDye, 1);			
            recipe.AddIngredient(ItemID.SkyBlueDye, 1);			
            recipe.AddIngredient(ItemID.BrightYellowDye, 1);			
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}