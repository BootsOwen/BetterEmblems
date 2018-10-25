using Terraria.ID;
using Terraria.ModLoader;

namespace BetterEmblems.Items
{
	public class SuperSorcererEmblem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Super Sorcerer Emblem");
			Tooltip.SetDefault("Increases maximum mana by 50" + "\n25% increased magic damage");
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
			recipe.AddIngredient(ItemID.SorcererEmblem, 1);
            recipe.AddIngredient(ItemID.AvengerEmblem, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.magicDamage *= 1.25f;
            player.statManaMax2 += 50;
        }
    }
}
