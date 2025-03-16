using Terraria;
using Terraria.ModLoader;

namespace DNT.EnchantmentTotems
{
    public class TotemSlot : ModAccessorySlot
    {
        public override bool DrawDyeSlot => false;
        public override bool DrawVanitySlot => false;
        public override string FunctionalTexture => ModContent.GetInstance<RageTotem>().Texture;

        public override bool CanAcceptItem(Item checkItem, AccessorySlotType context)
        {
            return checkItem.ModItem is EnchantmentTotem;
        }

        public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo)
        {
            return item.ModItem is EnchantmentTotem;
        }

        public override void OnMouseHover(AccessorySlotType context)
        {
            switch (context)
            {
                case AccessorySlotType.FunctionalSlot:
                    Main.hoverItemName = "Enchant Totem";
                    break;
            }
        }
    }
}
