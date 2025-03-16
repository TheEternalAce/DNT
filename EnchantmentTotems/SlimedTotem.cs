using Terraria;
using Terraria.ID;
using static DNT.DNT.Element;

namespace DNT.EnchantmentTotems
{
    public class SlimedTotem : EnchantmentTotem
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Blue;
            Item.value = 100000;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<DNTPlayer>().resistances |= Acid;
        }
    }
}