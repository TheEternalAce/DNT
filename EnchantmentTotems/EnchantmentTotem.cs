using Terraria;
using Terraria.ModLoader;

namespace DNT.EnchantmentTotems
{
    public abstract class EnchantmentTotem : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 34;
            Item.accessory = true;
            Item.expert = true;
        }

        public override bool CanAccessoryBeEquippedWith(Item equippedItem, Item incomingItem, Player player)
        {
            if (incomingItem.ModItem is EnchantmentTotem && equippedItem.ModItem is EnchantmentTotem) return false;
            return base.CanAccessoryBeEquippedWith(equippedItem, incomingItem, player);
        }

        public override bool CanEquipAccessory(Player player, int slot, bool modded)
        {
            return modded;
        }
    }
}
