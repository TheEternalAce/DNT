using System.Collections.Generic;
using static DNT.DNT;
using static DNT.DNT.Element;
using static Terraria.ID.NPCID;

namespace DNT
{
    public partial class DNTNPCs
    {
        public static readonly Dictionary<int, Element> ImmuneDamageTypes = new()
        {
            #region Corruption
            { DarkMummy, Poison },
            { DesertGhoulCorruption, Poison },
            { CursedHammer, Poison | Psychic },
            { BigMimicCorruption, Acid },
            #endregion
            #region Crimson
            { CrimsonAxe, Poison | Psychic },
            { FloatyGross, Poison | Cold | Necrotic },
            { BigMimicCrimson, Acid },
            { DesertGhoulCrimson, Poison },
            { BloodMummy, Poison },
            #endregion
            #region Hallow
            { LightMummy, Poison },
            { DesertGhoulHallow, Poison },
            { EnchantedSword, Poison | Psychic },
            { Unicorn, Poison },
            { BigMimicHallow, Acid },
            #endregion
            #region Underground
            #region Skeleton
            { Skeleton, Poison },
            { BoneThrowingSkeleton, Poison },
            { BoneThrowingSkeleton2, Poison },
            { BoneThrowingSkeleton3, Poison },
            { BoneThrowingSkeleton4, Poison },
            { UndeadMiner, Poison },
            { Tim, Poison },
            { SkeletonArcher, Poison },
            { ArmoredSkeleton, Poison },
            { HeadacheSkeleton, Poison },
            { MisassembledSkeleton, Poison },
            { PantlessSkeleton, Poison },
            { RuneWizard, Poison },
            #endregion
            { Mimic, Acid },
            { ToxicSludge, Poison },
            { RockGolem, Poison | Psychic },

            { GreekSkeleton, Poison },
            { GraniteGolem, Poison | Psychic },
            { GraniteFlyer, Poison | Psychic },
            #endregion
            #region Glowing Mushroom
            { SporeBat, Poison },
            { SporeSkeleton, Poison },
            { ZombieMushroom, Poison },
            { ZombieMushroomHat, Poison },
            #endregion
            #region Snow/Ice
            { UndeadViking, Poison },

            { IceElemental, Cold },
            { ArmoredViking, Poison },
            { IceGolem, Poison | Psychic },
            { IceMimic, Acid },
            #endregion
            #region Dungeon
            { AngryBones, Poison },
            { AngryBonesBig, Poison },
            { AngryBonesBigMuscle, Poison },
            { AngryBonesBigHelmet, Poison },
            { DarkCaster, Poison },
            { CursedSkull, Poison },
            { SpikeBall, Poison | Psychic },
            { BlazingWheel, Fire },

            { RustyArmoredBonesAxe, Poison },
            { RustyArmoredBonesFlail, Poison },
            { RustyArmoredBonesSword, Poison },
            { RustyArmoredBonesSwordNoArmor, Poison },
            { BlueArmoredBones, Poison },
            { BlueArmoredBonesMace, Poison },
            { BlueArmoredBonesNoPants, Poison },
            { BlueArmoredBonesSword, Poison },
            { HellArmoredBones, Poison | Fire },
            { HellArmoredBonesSword, Poison | Fire },
            { HellArmoredBonesMace, Poison | Fire },
            { HellArmoredBonesSpikeShield, Poison | Fire },
            { RaggedCaster, Poison },
            { RaggedCasterOpenCoat, Poison },
            { Necromancer, Poison },
            { NecromancerArmored, Poison },
            { DiabolistRed, Poison },
            { DiabolistWhite, Poison },
            { BoneLee, Poison },
            { DungeonSpirit, Poison | Cold | Necrotic },
            { GiantCursedSkull, Poison },
            { Paladin, Poison },
            { SkeletonSniper, Poison },
            { TacticalSkeleton, Poison },
            { SkeletonCommando, Poison },
            { CultistArcherBlue, Poison },
            { CultistArcherWhite, Poison },
            #endregion
            #region Desert
            { Mummy, Poison },
            { DesertGhoul, Poison },
            { SandElemental, Lightning | Thunder },
            { DesertDjinn, Lightning | Thunder },
            #endregion
            #region Jungle
            { ManEater, Lightning },
            { Snatcher, Lightning },
            { AngryTrapper, Lightning },
            { MossHornet, Lightning },
            { DoctorBones, Poison },
            { BigMimicJungle, Acid },
            #endregion
            #region Hell
            { LavaSlime, Fire },
            { Hellbat, Fire },
            { FireImp, Fire },
            { BurningSphere, Fire },
            { BoneSerpentHead, Poison | Fire },
            { BoneSerpentBody, Poison | Fire },
            { BoneSerpentTail, Poison | Fire },
            { Demon, Fire | Poison },
            { VoodooDemon, Fire | Poison },
            { Lavabat, Fire },
            { RedDevil, Fire | Poison },
            { DemonTaxCollector, Poison | Fire },
            #endregion

            #region Misc
            #region Zombie
            { Zombie, Poison },
            { MaggotZombie, Poison },
            { TorchZombie, Poison },
            { ArmedZombie, Poison },
            { ArmedTorchZombie, Poison },
            { ArmedZombieEskimo, Poison },
            { ArmedZombiePincussion, Poison },
            { ArmedZombieSwamp, Poison },
            { ArmedZombieTwiggy, Poison },
            { ArmedZombieCenx, Poison },
            { BaldZombie, Poison },
            { ZombieEskimo, Poison },
            { PincushionZombie, Poison },
            { SlimedZombie, Poison },
            { SwampZombie, Poison },
            { TwiggyZombie, Poison },
            { FemaleZombie, Poison },
            { ZombieRaincoat, Poison },
            { ZombieDoctor, Poison },
            { ZombieSuperman, Poison },
            { ZombiePixie, Poison },
            { ZombieXmas, Poison },
            { ZombieSweater, Poison },
            { SkeletonTopHat, Poison },
            { SkeletonAstonaut, Poison },
            { SkeletonAlien, Poison },
            #endregion

            { Dandelion, Lightning },
            { Ghost, Poison | Cold | Necrotic },

            { Wraith, Poison | Cold | Necrotic },
            { PossessedArmor, Poison | Psychic },
            { AngryNimbus, Lightning | Thunder },
            { WyvernHead, Lightning },
            { WyvernLegs, Lightning },
            { WyvernBody, Lightning },
            { WyvernBody2, Lightning },
            { WyvernBody3, Lightning },
            { WyvernTail, Lightning },
            #endregion

            #region Events
            #region Blood Moon
            { BloodZombie, Poison },
            { TheGroom, Poison },
            { TheBride, Poison },
            { ZombieMerman, Poison },

            { ChatteringTeethBomb, Poison | Psychic },
            #endregion
            #region Goblin Army
            { ShadowFlameApparition, Poison | Cold | Necrotic },
            #endregion
            #region Old One's Army
            { DD2Betsy, Fire },
            { DD2WyvernT1, Fire },
            { DD2WyvernT2, Fire },
            { DD2WyvernT3, Fire },
            { DD2DrakinT2, Fire },
            { DD2DrakinT3, Fire },
            #endregion
            #region Frost Legion
            { SnowmanGangsta, Cold },
            { MisterStabby, Cold },
            { SnowBalla, Cold },
            #endregion
            #region Pirate Invasion
            { PirateShip, Poison | Psychic },
            { PirateShipCannon, Poison | Psychic },
            { PirateGhost, Poison | Cold | Necrotic },
            #endregion
            #region Pumpkin Moon
            { Scarecrow1, Poison | Psychic },
            { Scarecrow2, Poison | Psychic },
            { Scarecrow3, Poison | Psychic },
            { Scarecrow4, Poison | Psychic },
            { Scarecrow5, Poison | Psychic },
            { Scarecrow6, Poison | Psychic },
            { Scarecrow7, Poison | Psychic },
            { Scarecrow8, Poison | Psychic },
            { Scarecrow9, Poison | Psychic },
            { Scarecrow10, Poison | Psychic },
            { MourningWood, Lightning },
            { Splinterling, Lightning },
            { Pumpking, Poison | Cold | Necrotic },
            { PumpkingBlade, Poison | Cold | Necrotic },
            { Hellhound, Fire },
            { Poltergeist, Poison | Cold | Necrotic },
            #endregion
            #region Frost Moon
            { PresentMimic, Piercing },
            { GingerbreadMan, Poison | Psychic },
            { Everscream, Lightning },
            { IceQueen, Cold },
            { SantaNK1, Poison | Psychic },
            { Nutcracker, Poison | Psychic },
            { NutcrackerSpinning, Poison | Psychic },
            { Krampus, Cold },
            { Flocko, Cold },
            #endregion
            #region Eclipse
            { Reaper, Poison | Cold | Necrotic },
            { SwampThing, Lightning },
            { DeadlySphere, Poison | Psychic },
            #endregion
            #region Martian Madness
            { BrainScrambler, Lightning },
            { RayGunner, Lightning },
            { MartianOfficer, Lightning },
            { GrayGrunt, Lightning },
            { MartianEngineer, Lightning },
            { MartianTurret, Poison | Psychic | Lightning },
            { MartianDrone, Poison | Psychic | Lightning },
            { GigaZapper, Lightning },
            { ScutlixRider, Lightning },
            { Scutlix, Lightning },
            { MartianSaucer, Poison | Psychic| Lightning },
            { MartianSaucerTurret, Poison | Psychic| Lightning },
            { MartianSaucerCannon, Poison | Psychic | Lightning },
            { MartianSaucerCore, Poison | Psychic | Lightning },
            { MartianProbe, Poison | Psychic | Lightning },
            { MartianWalker, Poison | Psychic | Lightning },
            #endregion
            #region Pillars
            { LunarTowerStardust, Poison | Psychic | Poison },
            { StardustWormHead, Poison },
            { StardustWormBody, Poison },
            { StardustWormTail, Poison },
            { StardustCellBig, Poison },
            { StardustCellSmall, Poison },
            { StardustJellyfishBig, Poison },
            { StardustSpiderBig, Poison },
            { StardustSpiderSmall, Poison },
            { StardustSoldier, Poison},

            { LunarTowerSolar, Poison | Psychic | Fire },
            { SolarCrawltipedeHead, Fire },
            { SolarCrawltipedeBody, Fire },
            { SolarCrawltipedeTail, Fire },
            { SolarDrakomire, Fire },
            { SolarDrakomireRider, Fire },
            { SolarSpearman, Fire },
            { SolarSroller, Fire },
            { SolarCorite, Fire },
            { SolarSolenian, Fire },
            { SolarFlare, Fire },
            { SolarGoop, Fire },

            { LunarTowerNebula, Poison | Psychic | Psychic },
            { NebulaBrain, Psychic },
            { NebulaHeadcrab, Psychic },
            { NebulaBeast,  Psychic },
            { NebulaSoldier, Psychic },

            { LunarTowerVortex, Poison | Psychic | Lightning },
            { VortexRifleman, Lightning },
            { VortexHornetQueen, Lightning },
            { VortexHornet, Lightning },
            { VortexLarva, Lightning },
            { VortexSoldier, Lightning },
            #endregion
            #endregion

            #region Bosses
            { SkeletronHead, Poison },
            { SkeletronHand, Poison },
            { DungeonGuardian, Poison },
            { WallofFlesh, Cold | Poison },
            { WallofFleshEye, Cold | Poison },

            { QueenSlimeBoss, Lightning | Slashing },
            { QueenSlimeMinionBlue, Lightning | Slashing },
            { QueenSlimeMinionPink, Lightning | Slashing },
            { QueenSlimeMinionPurple, Lightning | Slashing },
            { Retinazer, Poison | Psychic },
            { Spazmatism, Poison | Psychic },
            { SkeletronPrime, Poison | Psychic },
            { PrimeCannon, Poison | Psychic },
            { PrimeLaser, Poison | Psychic },
            { PrimeSaw, Poison | Psychic },
            { PrimeVice, Poison | Psychic },
            { TheDestroyer, Poison | Psychic },
            { TheDestroyerBody, Poison | Psychic },
            { TheDestroyerTail, Poison | Psychic },
            { Probe, Poison | Psychic },
            { Plantera, Lightning },
            { PlanterasHook, Lightning },
            { PlanterasTentacle, Lightning },
            { Spore, Lightning },
            { Golem, Poison | Psychic },
            { GolemFistLeft, Poison | Psychic },
            { GolemFistRight, Poison | Psychic },
            { GolemHead, Poison | Psychic },
            { GolemHeadFree, Poison | Psychic },
            { DetonatingBubble, Cold },
            { CultistBossClone, Poison | Psychic },
            { CultistDragonHead, Poison | Cold | Necrotic },
            { CultistDragonBody1, Poison | Cold | Necrotic },
            { CultistDragonBody2, Poison | Cold | Necrotic },
            { CultistDragonBody3, Poison | Cold | Necrotic },
            { CultistDragonBody4, Poison | Cold | Necrotic },
            { CultistDragonTail, Poison | Cold | Necrotic },
            { AncientCultistSquidhead, Poison | Cold | Necrotic },
            { AncientLight, Poison | Cold | Necrotic },
            { AncientDoom, Poison | Cold | Necrotic },
            { MoonLordHand, Psychic },
            { MoonLordHead, Psychic },
            { MoonLordFreeEye, Psychic },
            #endregion
        };
    }
}
