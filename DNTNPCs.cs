using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.ModLoader;
using static DNT.DNT;
using static DNT.DNT.Element;
using static Terraria.ID.NPCID;

namespace DNT
{
    public partial class DNTNPCs : GlobalNPC
    {
        public Element damageTypes = Element.None;
        public Element vulnerabilities = Element.None;
        public Element resistances = Element.None;
        public Element immunities = Element.None;

        public override bool InstancePerEntity => true;

        public override void OnSpawn(NPC npc, IEntitySource source)
        {
            if (ContactDamageTypes.TryGetValue(npc.type, out var value)) damageTypes |= value;
            if (VulnerableDamageTypes.TryGetValue(npc.type, out value)) vulnerabilities |= value;
            if (ResistantDamageTypes.TryGetValue(npc.type, out value)) resistances |= value;
            if (ImmuneDamageTypes.TryGetValue(npc.type, out value)) immunities |= value;
        }

        public override void AI(NPC npc)
        {
            if (npc.active && GetMatches(damageTypes, Piercing) == 0)
            {
                if ((npc.type == EyeofCthulhu && npc.life <= npc.lifeMax * (Main.expertMode ? 0.65f : 0.5f)) ||
                    (npc.type == BrainofCthulhu && !NPC.AnyNPCs(Creeper)) ||
                    (npc.type == WanderingEye && npc.life <= npc.lifeMax * 0.5f) ||
                    (npc.type == Spazmatism && npc.life <= (Main.masterMode ? 17594 : (Main.expertMode ? 13800 : 9200))) ||
                    (npc.type == Plantera && npc.life <= npc.lifeMax * 0.5f))
                    damageTypes |= Piercing;
            }
        }

        public override void SetBestiary(NPC npc, BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            if (ContactDamageTypes.TryGetValue(npc.type, out var value)) damageTypes |= value;
            if (VulnerableDamageTypes.TryGetValue(npc.type, out value)) vulnerabilities |= value;
            if (ResistantDamageTypes.TryGetValue(npc.type, out value)) resistances |= value;
            if (ImmuneDamageTypes.TryGetValue(npc.type, out value)) immunities |= value;
            bestiaryEntry.Info.Insert(0, new BestiaryImmunityInfo(immunities));
            bestiaryEntry.Info.Insert(0, new BestiaryResistanceInfo(resistances));
            bestiaryEntry.Info.Insert(0, new BestiaryVulnerabilityInfo(vulnerabilities));
            bestiaryEntry.Info.Insert(0, new BestiaryDamageInfo(damageTypes));
        }

        public override bool? CanBeHitByItem(NPC npc, Player player, Item item)
        {
            return CheckImmunity(npc, GetDamageTypes(item)) ? false : base.CanBeHitByItem(npc, player, item);
        }
        public override bool? CanBeHitByProjectile(NPC npc, Projectile projectile)
        {
            return CheckImmunity(npc, GetDamageTypes(projectile)) ? false : base.CanBeHitByProjectile(npc, projectile);
        }
        public override bool CanBeHitByNPC(NPC npc, NPC attacker)
        {
            return !CheckImmunity(npc, GetDamageTypes(attacker)) && base.CanBeHitByNPC(npc, attacker);
        }

        public override void ModifyHitByItem(NPC npc, Player player, Item item, ref NPC.HitModifiers modifiers)
        {
            modifiers.FinalDamage *= ModifyDamage(npc, GetDamageTypes(item));
        }
        public override void ModifyHitByProjectile(NPC npc, Projectile projectile, ref NPC.HitModifiers modifiers)
        {
            modifiers.FinalDamage *= ModifyDamage(npc, GetDamageTypes(projectile));
        }
        public override void ModifyHitNPC(NPC npc, NPC target, ref NPC.HitModifiers modifiers)
        {
            modifiers.FinalDamage *= ModifyDamage(target, GetDamageTypes(npc));
        }
    }
}
