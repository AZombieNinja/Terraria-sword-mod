/*
	File:		Eviscerator
	Created:	7/13/2017A.M. Eastern Time
	Info:		File that Contains weapon mods
	Author:		Darkblood9696
*/


using Terraria.ID;
using Terraria.ModLoader;

namespace EvisceratorMKI.Items
{
	public class EvisceratorMKI : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("EvisceratorMKI");
			Tooltip.SetDefault("This sword will decimate.");
		}
		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
