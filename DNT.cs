using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace DNT
{
    public class DNT : Mod
    {
        public static bool ContentSetup { get; private set; } = false;

        public static readonly int[] ElementID =
        [
            0,
            1, // Acid
            2, // Bludgeoning
            4, // Cold
            8, // Fire
            16, // Force
            32, // Lightning
            64, // Necrotic
            128, // Piercing
            256, // Poison
            512, // Psychic
            1024, // Radiant
            2048, // Slashing
            4096, // Thunder
        ];

        [Flags]
        public enum Element
        {
            None = 0b_0000_0000_0000_0000, // 0
            Acid = 0b_0000_0000_0000_0001, // 1
            Bludgeoning = 0b_0000_0000_0000_0010, // 2
            Cold = 0b_0000_0000_0000_0100, // 4
            Fire = 0b_0000_0000_0000_1000, // 8
            Force = 0b_0000_0000_0001_0000, // 16
            Lightning = 0b_0000_0000_0010_0000, // 32
            Necrotic = 0b_0000_0000_0100_0000, // 64
            Piercing = 0b_0000_0000_1000_0000, // 128
            Poison = 0b_0000_0001_0000_0000, // 256
            Psychic = 0b_0000_0010_0000_0000, // 512
            Radiant = 0b_0000_0100_0000_0000, // 1024
            Slashing = 0b_0000_1000_0000_0000, // 2048
            Thunder = 0b_0001_0000_0000_0000, // 4096
        }

        #region Mechanics
        public static float ModifyDamage(Entity entity, Element damageTypes)
        {
            Element resistances = GetResistances(entity);
            Element vulnerabilities = GetVulnerabilities(entity);

            float multiplier = GetMultiplier(vulnerabilities, resistances, damageTypes);
            MultiplierEffect(entity.Hitbox, multiplier);
            return multiplier;
        }
        public static float GetMultiplier(Element vulnerabilities, Element resistances, Element damageTypes)
        {
            float vulnerableMatches = GetMatches(vulnerabilities, damageTypes);
            float resistantMatches = GetMatches(resistances, damageTypes);
            return (float)Math.Pow(2f, vulnerableMatches) * (float)Math.Pow(0.5f, resistantMatches);
        }
        public static void MultiplierEffect(Rectangle rectangle, float multiplier)
        {
            if (multiplier != 1f)
            {
                multiplier = (float)Math.Round((decimal)multiplier, 2);
                Color color = Color.LightGreen;
                bool powerful = true;
                if (multiplier < 1f)
                {
                    color = Color.Firebrick;
                    powerful = false;
                }
                CombatText.NewText(rectangle, color, multiplier + "x", powerful, true);
            }
        }

        public static bool CheckImmunity(Entity entity, Element damageTypes)
        {
            var immunities = GetImmunities(entity);
            return GetMatches(immunities, damageTypes) > 0;
        }
        public static int GetMatches(Element types1, Element types2)
        {
            int matches = 0;
            var types = types1 & types2;
            for (int i = 1; i <= 13; i++)
            {
                Element type = (Element)ElementID[i];
                if (types.HasFlag(type)) matches++;
            }
            return matches;
        }

        public static Element GetVulnerabilities(Entity entity)
        {
            if (entity is NPC npc) return npc.GetGlobalNPC<DNTNPCs>().vulnerabilities;
            else if (entity is Player player) return player.GetModPlayer<DNTPlayer>().vulnerabilities;
            return Element.None;
        }
        public static Element GetResistances(Entity entity)
        {
            if (entity is NPC npc) return npc.GetGlobalNPC<DNTNPCs>().resistances;
            else if (entity is Player player) return player.GetModPlayer<DNTPlayer>().resistances;
            return Element.None;
        }
        public static Element GetImmunities(Entity entity)
        {
            if (entity is NPC npc) return npc.GetGlobalNPC<DNTNPCs>().immunities;
            else if (entity is Player player) return player.GetModPlayer<DNTPlayer>().immunities;
            return Element.None;
        }

        public static Element GetDamageTypes(Entity entity)
        {
            if (entity is NPC npc) return npc.GetGlobalNPC<DNTNPCs>().damageTypes;
            else if (entity is Item item) return item.GetGlobalItem<DNTItems>().damageTypes;
            else if (entity is Projectile projectile) return projectile.GetGlobalProjectile<DNTProjectiles>().damageTypes;
            return Element.None;
        }
        #endregion

        public override void PostSetupContent()
        {
            ContentSetup = true;
        }

        public override void Unload()
        {
            ContentSetup = false;
        }

        #region Mod Call
        const string COMMAND_ASSIGN_DAMAGE_ELEMENT = "addDamageElement";
        const string COMMAND_ASSIGN_RESIST_ELEMENT = "addResistElement";
        const string COMMAND_ASSIGN_IMMUNE_ELEMENT = "addImmuneElement";
        const string COMMAND_ASSIGN_VULNERABLE_ELEMENT = "addVulnerableElement";
        const string COMMAND_ASSIGN_TEMP_DAMAGE_ELEMENT = "addTemporaryDamageElement";
        const string COMMAND_ASSIGN_TEMP_RESIST_ELEMENT = "addTemporaryResistElement";
        const string COMMAND_ASSIGN_TEMP_IMMUNE_ELEMENT = "addTemporaryImmuneElement";
        const string COMMAND_ASSIGN_TEMP_VULNERABLE_ELEMENT = "addTemporaryVulnerableElement";
        public override object Call(params object[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args), "Arguments cannot be null!");
            }

            if (args.Length == 0)
            {
                throw new ArgumentException("Arguments cannot be empty!");
            }

            if (args[0] is string command)
            {
                switch (command)
                {
                    default:
                        throw new ArgumentException("Unrecognized ModCall. Usable ModCalls for Elements of Terraria are as follows: " +
                            $"\"{COMMAND_ASSIGN_DAMAGE_ELEMENT}\", \"{COMMAND_ASSIGN_VULNERABLE_ELEMENT}\", " +
                            $"\"{COMMAND_ASSIGN_RESIST_ELEMENT}\", and \"{COMMAND_ASSIGN_IMMUNE_ELEMENT}\".");
                    case COMMAND_ASSIGN_DAMAGE_ELEMENT:
                        AssignDefaultDamage(args);
                        break;
                    case COMMAND_ASSIGN_VULNERABLE_ELEMENT:
                        AssignDefaultVulnerabilities(args, 0);
                        break;
                    case COMMAND_ASSIGN_RESIST_ELEMENT:
                        AssignDefaultVulnerabilities(args, 1);
                        break;
                    case COMMAND_ASSIGN_IMMUNE_ELEMENT:
                        AssignDefaultVulnerabilities(args, 2);
                        break;
                    case COMMAND_ASSIGN_TEMP_DAMAGE_ELEMENT:
                        AddTempDamage(args);
                        break;
                    case COMMAND_ASSIGN_TEMP_VULNERABLE_ELEMENT:
                        AddTempVulnerabilities(args, 0);
                        break;
                    case COMMAND_ASSIGN_TEMP_RESIST_ELEMENT:
                        AddTempVulnerabilities(args, 1);
                        break;
                    case COMMAND_ASSIGN_TEMP_IMMUNE_ELEMENT:
                        AddTempVulnerabilities(args, 2);
                        break;
                }
            }
            return base.Call(args);
        }

        static void AddTempDamage(object[] args)
        {
            if (args[1] is Entity entity)
            {
                Element elements;
                if (args[2] is int[] elementIDs) elements = AddToList(elementIDs);
                else throw new ArgumentException("(args[3]) Invalid int array. Enter an int array with values between 0 and 12 (inclusive).");

                if (entity is NPC npc) npc.GetGlobalNPC<DNTNPCs>().damageTypes |= elements;
                else if (entity is Item item) item.GetGlobalItem<DNTItems>().damageTypes |= elements;
                else if (entity is Projectile projectile) projectile.GetGlobalProjectile<DNTProjectiles>().damageTypes |= elements;
                else throw new ArgumentException("(args[1]) Invalid Entity. Insert an Item, Projectile, or NPC.");
            }
            else throw new ArgumentException("(args[1]) Invalid Entity. Insert an Item, Projectile, or NPC.");
        }
        static void AddTempVulnerabilities(object[] args, int type)
        {
            if (args[1] is NPC npc)
            {
                var dntNPC = npc.GetGlobalNPC<DNTNPCs>();
                Element elements;
                if (args[2] is int[] elementIDs) elements = AddToList(elementIDs);
                else throw new ArgumentException("(args[2]) Invalid int array. Enter an int array with values between 0 and 12 (inclusive).");

                if (type == 1) dntNPC.resistances |= elements;
                else if (type == 2) dntNPC.immunities |= elements;
                else dntNPC.vulnerabilities |= elements;
            }
            else throw new ArgumentException("(args[1]) Invalid NPC.");
        }
        static void AssignDefaultDamage(object[] args)
        {
            if (args[1] is string type)
            {
                Dictionary<int, Element> elements;
                type = type.ToLower();
                if (type.Equals("item")) elements = DNTItems.DefaultDamageTypes;
                else if (type.Equals("projectile")) elements = DNTProjectiles.DefaultDamageTypes;
                else if (type.Equals("npc")) elements = DNTNPCs.ContactDamageTypes;
                else throw new ArgumentException("(args[1]) Invalid string. Insert string \"item\", \"projectile\", or \"npc\".");
                if (args[2] is int id)
                {
                    if (args[3] is int[] elementIDs)
                    {
                        Element damageTypes = AddToList(elementIDs);
                        elements.TryAdd(id, damageTypes);
                    }
                    else throw new ArgumentException("(args[3]) Invalid int array. Enter an int array with values between 0 and 12 (inclusive).");
                }
                else throw new ArgumentException("(args[2]) Invalid int. Enter the item/projectile/npc type.");
            }
            else throw new ArgumentException("(args[1]) Invalid string. Insert string \"item\", \"projectile\", or \"npc\".");
        }
        static void AssignDefaultVulnerabilities(object[] args, int type)
        {
            if (args[1] is int id)
            {
                Dictionary<int, Element> elements = DNTNPCs.VulnerableDamageTypes;
                if (type == 1) elements = DNTNPCs.ResistantDamageTypes;
                else if (type == 2) elements = DNTNPCs.ImmuneDamageTypes;
                if (args[2] is int[] elementIDs)
                {
                    Element damageTypes = AddToList(elementIDs);
                    elements.TryAdd(id, damageTypes);
                }
                else throw new ArgumentException("(args[2]) Invalid int array. Enter an int array with values between 0 and 12 (inclusive).");
            }
            else throw new ArgumentException("(args[1]) Invalid int. Enter the npc type.");
        }
        static Element AddToList(int[] elementIDs)
        {
            Element damageTypes = Element.None;
            for (int i = 0; i < elementIDs.Length; i++)
            {
                int elementID = elementIDs[i];
                if (elementID < 0 || elementID > 12) throw new ArgumentException("(args[3]) Invalid int. The int array values must be between 0 and 12 (inclusive).");
                elementID++;
                damageTypes |= (Element)ElementID[elementID];
            }
            return damageTypes;
        }
        #endregion
    }
}
