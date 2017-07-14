using Terraria.ID;
using Terraria.ModLoader;

namespace Testgun.Items
{
	public class Testgun : ModItem
	{
		public override void SetStaticDefaults()
		{
			item.damage = 16;  //gun damage
            item.ranged = true;   //its a gun so set this to true
            item.width = 38;     //gun image width
            item.height = 11;   //gun image  height
            item.useTime = 20;  //how fast 
            item.useAnimation = 20;
            item.useStyle = 5;    //
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 1;
            item.value = 10000;
            item.rare = 1;
            item.autoReuse = false;
            item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 16f;
            item.UseSound = SoundID.Item11;
            item.useAmmo = AmmoID.Bullet;
		}
		
		public override void AddRecipes()  //How to craft this gun
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1); //after ItemID any block/item can be used.
			recipe.AddTile(TileID.WorkBenches); //after TileID you can change to Anvils or whatnot.
			recipe.SetResult(this);
			
		}
	}
}