using Terraria;
using Terraria.ID;
using static DNT.DNT.Element;

namespace DNT.EnchantmentTotems
{
    public class EctoTotem : EnchantmentTotem
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Yellow;
            Item.value = 100000;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<DNTPlayer>().immunities |= Cold | Poison | Necrotic;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Ectoplasm, 15)
                .AddCondition(Condition.InExpertMode)
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }
    }
}