using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static DNT.DNT.Element;

namespace DNT.EnchantmentTotems
{
    public class SentientTotem : EnchantmentTotem
    {
        public override string Texture => ModContent.GetInstance<RageTotem>().Texture;

        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Lime;
            Item.value = 100000;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<DNTPlayer>().immunities |= Poison | Psychic;
        }
    }
}