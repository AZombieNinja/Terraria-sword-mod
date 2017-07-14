using Terraria.ID;
using Terraria.ModLoader;

namespace Testbullet.Items.Bullets
{
	public class Testbullet : ModItem
	{
		public override void SetDefaults()
		{
			item.damage = 100;
			item.ranged = true;
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack =1.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("testbullet");
			item.shootSpeed = 15f;
			item.ammo = AmmoID.Bullet;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Dirtblock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
			
		}
	}
}