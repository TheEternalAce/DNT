using System.Collections.Generic;
using static DNT.DNT;
using static DNT.DNT.Element;
using static Terraria.ID.NPCID;

namespace DNT
{
    public partial class DNTNPCs
    {
        public static readonly Dictionary<int, Element> ResistantDamageTypes = new()
        {
            #region Corruption
            { DevourerHead, Bludgeoning },
            { DevourerBody, Bludgeoning },
            { DevourerTail, Bludgeoning },
            { DesertGhoulCorruption, Necrotic },
            { SeekerHead, Bludgeoning },
            { SeekerBody, Bludgeoning },
            { SeekerTail, Bludgeoning },
            { BigMimicCorruption, Bludgeoning | Piercing | Slashing },
            #endregion
            #region Crimson
            { FloatyGross, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Slashing },
            { BigMimicCrimson, Bludgeoning | Piercing | Slashing },
            { DesertGhoulCrimson, Necrotic },
            #endregion
            #region Hallow
            { DesertGhoulHallow, Necrotic },
            { BigMimicHallow, Bludgeoning | Piercing | Slashing },
            #endregion
            #region Underground
            { GiantWormHead, Bludgeoning },
            { GiantWormBody, Bludgeoning },
            { GiantWormTail, Bludgeoning },

            { DiggerHead, Bludgeoning },
            { DiggerBody, Bludgeoning },
            { DiggerTail, Bludgeoning },
            { RockGolem, Bludgeoning | Piercing | Slashing },

            { GraniteGolem, Bludgeoning | Piercing | Slashing },
            { GraniteFlyer, Bludgeoning | Piercing | Slashing },
            #endregion
            #region Glowing Mushroom
            { FungoFish, Psychic },
            { AnomuraFungus, Psychic },
            { MushiLadybug, Psychic },
            { FungiBulb, Psychic },
            { GiantFungiBulb, Psychic },
            { FungiSpore, Psychic },
            { SporeBat, Psychic },
            { SporeSkeleton, Psychic },
            #endregion
            #region Snow/Ice
            { IceSlime, Cold },
            { SpikedIceSlime, Cold },
            { SnowFlinx, Cold },

            { IceElemental, Bludgeoning | Piercing | Slashing },
            { IcyMerman, Bludgeoning | Piercing | Slashing },
            { IceGolem, Bludgeoning | Piercing | Slashing },
            #endregion
            #region Dungeon
            { SpikeBall, Bludgeoning | Piercing | Slashing },

            { BoneLee, Bludgeoning | Piercing | Slashing },
            { DungeonSpirit, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Slashing },
            { GiantCursedSkull, Necrotic },
            #endregion
            #region Desert
            { TombCrawlerHead, Bludgeoning },
            { TombCrawlerBody, Bludgeoning },
            { TombCrawlerTail, Bludgeoning },

            { DuneSplicerHead, Bludgeoning },
            { DuneSplicerBody, Bludgeoning },
            { DuneSplicerTail, Bludgeoning },
            { Mummy, Bludgeoning | Piercing | Slashing },
            { DesertGhoul, Necrotic },
            { SandElemental, Bludgeoning | Piercing | Slashing },
            #endregion
            #region Jungle
            { ManEater, Cold },
            { Snatcher, Cold },
            { GiantTortoise, Slashing },
            { Arapaima, Piercing },
            { AngryTrapper, Cold | Fire },
            { MossHornet, Cold | Fire },
            #endregion
            #region Hell
            { LavaSlime, Cold },
            { Hellbat, Cold },
            { FireImp, Cold | Bludgeoning | Piercing | Slashing },
            { BoneSerpentHead, Cold },
            { BoneSerpentBody, Cold },
            { BoneSerpentTail, Cold },
            { Demon, Cold | Lightning | Bludgeoning | Piercing | Slashing },
            { VoodooDemon, Cold | Lightning | Bludgeoning | Piercing | Slashing },
            { Lavabat, Cold },
            { RedDevil, Cold | Lightning | Bludgeoning | Piercing | Slashing },
            { DemonTaxCollector, Cold },
            #endregion

            #region Misc
            { ZombieEskimo, Cold },
            { ArmedZombieEskimo, Cold },
            { Dandelion, Cold },
            { Ghost, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Slashing },
            { MeteorHead, Fire | Bludgeoning | Piercing | Slashing },

            { Wraith, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Slashing },
            { AngryNimbus, Cold | Bludgeoning | Piercing | Slashing },
            #endregion

            #region Events
            #region Goblin Army
            { ShadowFlameApparition, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Slashing },
            #endregion
            #region Pirate Invasion
            { PirateGhost, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Slashing },
            #endregion
            #region Pumpkin Moon
            { MourningWood, Cold | Fire },
            { Splinterling, Cold | Fire },
            { Pumpking, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Slashing },
            { PumpkingBlade, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Slashing },
            { Poltergeist, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Slashing },
            #endregion
            #region Frost Moon
            { Everscream, Cold | Fire },
            { IceQueen, Bludgeoning | Piercing | Slashing },
            { SantaNK1, Bludgeoning | Piercing | Slashing },
            { Krampus, Bludgeoning | Piercing | Slashing },
            #endregion
            #region Eclipse
            { Reaper, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Slashing },
            { VampireBat, Necrotic | Bludgeoning | Piercing | Slashing },
            { Vampire, Necrotic | Bludgeoning | Piercing | Slashing },
            { SwampThing, Cold | Fire },
            { Nailhead, Bludgeoning | Piercing | Slashing },
            { DeadlySphere, Bludgeoning | Piercing | Slashing },
            #endregion
            #endregion

            #region Bosses
            { EaterofWorldsHead, Bludgeoning },
            { EaterofWorldsBody, Bludgeoning },
            { EaterofWorldsTail, Bludgeoning },
            { BrainofCthulhu, Psychic },
            { Creeper, Psychic },
            { Deerclops, Cold },
            { WallofFlesh, Necrotic | Slashing },
            { WallofFleshEye, Necrotic | Slashing },

            { QueenSlimeBoss, Acid },
            { QueenSlimeMinionBlue, Acid },
            { QueenSlimeMinionPink, Acid },
            { QueenSlimeMinionPurple, Acid },
            { Retinazer, Bludgeoning | Piercing | Slashing },
            { Spazmatism, Bludgeoning | Piercing | Slashing },
            { SkeletronPrime, Bludgeoning | Piercing | Slashing },
            { PrimeCannon, Bludgeoning | Piercing | Slashing },
            { PrimeLaser, Bludgeoning | Piercing | Slashing },
            { PrimeSaw, Bludgeoning | Piercing | Slashing },
            { PrimeVice, Bludgeoning | Piercing | Slashing },
            { TheDestroyer, Bludgeoning | Piercing | Slashing },
            { TheDestroyerBody, Bludgeoning | Piercing | Slashing },
            { TheDestroyerTail, Bludgeoning | Piercing | Slashing },
            { Probe, Bludgeoning | Piercing | Slashing },
            { Plantera, Cold | Fire },
            { PlanterasHook, Cold | Fire },
            { PlanterasTentacle, Cold | Fire },
            { Spore, Cold | Fire },
            { Golem, Bludgeoning | Piercing | Slashing },
            { GolemFistLeft, Bludgeoning | Piercing | Slashing },
            { GolemFistRight, Bludgeoning | Piercing | Slashing },
            { GolemHead, Bludgeoning | Piercing | Slashing },
            { GolemHeadFree, Bludgeoning | Piercing | Slashing },
            { CultistBoss, Psychic },
            { CultistBossClone, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Slashing },
            { CultistDragonHead, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Psychic | Slashing },
            { CultistDragonBody1, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Psychic | Slashing },
            { CultistDragonBody2, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Psychic | Slashing },
            { CultistDragonBody3, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Psychic | Slashing },
            { CultistDragonBody4, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Psychic | Slashing },
            { CultistDragonTail, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Psychic | Slashing },
            { AncientCultistSquidhead, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Psychic | Slashing },
            { AncientLight, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Psychic | Slashing },
            { AncientDoom, Acid | Fire | Lightning | Thunder | Bludgeoning | Piercing | Psychic | Slashing },
            #endregion
        };
    }
}
