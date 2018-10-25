using Terraria.ID;
using Terraria.ModLoader;

namespace BetterEmblems.Items
{
	public class SuperSummonerEmblem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Super Summoner Emblem");
			Tooltip.SetDefault("Increases your max number of minions" + "\nIncreases minion damage by 25%");
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
			recipe.AddIngredient(ItemID.SummonerEmblem, 1);
            recipe.AddIngredient(ItemID.AvengerEmblem, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.minionDamage *= 1.25f;
            player.maxMinions += 1;
        }
    }
}
