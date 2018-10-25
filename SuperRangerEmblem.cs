using Terraria.ID;
using Terraria.ModLoader;

namespace BetterEmblems.Items
{
	public class SuperRangerEmblem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Super Ranger Emblem");
			Tooltip.SetDefault("20% chance to not consume ammo" + "\n25% increased ranged damage");
		}
        public override void SetDefaults()
        {
            item.accessory = true;
            item.width = 28;
            item.height = 28;
            item.value = 400000;
            item.rare = 5;
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RangerEmblem, 1);
            recipe.AddIngredient(ItemID.AvengerEmblem, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.rangedDamage *= 1.25f;
            player.ammoBox = true;
        }
    }
}
