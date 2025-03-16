using Terraria;
using Terraria.ID;
using static DNT.DNT.Element;

namespace DNT.EnchantmentTotems
{
    public class OvergrownTotem : EnchantmentTotem
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Lime;
            Item.value = 100000;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<DNTPlayer>().resistances |= Cold | Fire | Lightning;
        }
    }
}