using Terraria.ID;
using Terraria.ModLoader;

namespace BetterEmblems.Items
{
	public class SuperWarriorEmblem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Super Warrior Emblem");
			Tooltip.SetDefault("5 Defense" + "\n25% increased melee damage");
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
			recipe.AddIngredient(ItemID.WarriorEmblem, 1);
            recipe.AddIngredient(ItemID.AvengerEmblem, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.meleeDamage *= 1.25f;
            player.statDefense += 5;
        }
    }
}
