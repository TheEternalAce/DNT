using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static DNT.DNT.Element;

namespace DNT.EnchantmentTotems
{
    public class RageTotem : EnchantmentTotem
    {
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ItemRarityID.Green;
            Item.value = 100000;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<DNTPlayer>().resistances |= Bludgeoning | Piercing | Slashing;
            player.endurance -= 0.08f;
            player.GetDamage(DamageClass.Melee) += 0.08f;
        }
    }
}