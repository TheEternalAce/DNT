using Terraria;
using Terraria.ModLoader;
using static DNT.DNT;

namespace DNT
{
    public class DNTPlayer : ModPlayer
    {
        public enum Stat
        {
            Strength,
            Dexterity,
            Constitution,
            Intelligence,
            Wisdom,
            Charisma,
        }
        public float[] stats = [1f, 1f, 1f, 1f, 1f, 1f];
        public Element vulnerabilities = Element.None;
        public Element resistances = Element.None;
        public Element immunities = Element.None;

        public override void ResetEffects()
        {
            vulnerabilities = Element.None;
            resistances = Element.None;
            immunities = Element.None;
        }

        public override bool CanBeHitByProjectile(Projectile proj)
        {
            return !CheckImmunity(Player, GetDamageTypes(proj));
        }
        public override bool CanBeHitByNPC(NPC npc, ref int cooldownSlot)
        {
            return !CheckImmunity(Player, GetDamageTypes(npc));
        }

        public override void ModifyHitByProjectile(Projectile proj, ref Player.HurtModifiers modifiers)
        {
            modifiers.FinalDamage *= ModifyDamage(Player, GetDamageTypes(proj));
        }
        public override void ModifyHitByNPC(NPC npc, ref Player.HurtModifiers modifiers)
        {
            modifiers.FinalDamage *= ModifyDamage(Player, GetDamageTypes(npc));
        }
    }
}
