using System.Collections.Generic;
using static DNT.DNT;
using static DNT.DNT.Element;
using static Terraria.ID.NPCID;

namespace DNT
{
    public partial class DNTNPCs
    {
        public static readonly Dictionary<int, Element> VulnerableDamageTypes = new()
        {
            #region Corruption
            { Slimer, Fire },
            { Slimer2, Fire },
            { CorruptSlime, Fire },
            #endregion
            #region Crimson
            { Crimslime, Fire },
            #endregion
            #region Hallow
            { IlluminantSlime, Fire },
            { RainbowSlime, Fire },
            #endregion
            #region Underground
            #region Skeleton
            { Skeleton, Bludgeoning },
            { BoneThrowingSkeleton, Bludgeoning },
            { BoneThrowingSkeleton2, Bludgeoning },
            { BoneThrowingSkeleton3, Bludgeoning },
            { BoneThrowingSkeleton4, Bludgeoning },
            { UndeadMiner, Bludgeoning },
            { Tim, Bludgeoning },
            { SkeletonArcher, Bludgeoning },
            { ArmoredSkeleton, Bludgeoning },
            { HeadacheSkeleton, Bludgeoning },
            { MisassembledSkeleton, Bludgeoning },
            { PantlessSkeleton, Bludgeoning },
            { RuneWizard, Bludgeoning },
            #endregion
            { MotherSlime, Fire },
            { ToxicSludge, Fire },

            { GreekSkeleton, Bludgeoning },
            #endregion
            #region Glowing Mushroom
            { SporeSkeleton, Bludgeoning },
            #endregion
            #region Snow/Ice
            { IceSlime, Fire },
            { SpikedIceSlime, Fire },
            { UndeadViking, Bludgeoning },
            { ArmoredViking, Bludgeoning },
            #endregion
            #region Dungeon
            { AngryBones, Bludgeoning },
            { AngryBonesBig, Bludgeoning },
            { AngryBonesBigMuscle, Bludgeoning },
            { AngryBonesBigHelmet, Bludgeoning },
            { DarkCaster, Bludgeoning },
            { CursedSkull, Bludgeoning },
            { DungeonSlime, Fire },

            { RustyArmoredBonesAxe, Bludgeoning },
            { RustyArmoredBonesFlail, Bludgeoning },
            { RustyArmoredBonesSword, Bludgeoning },
            { RustyArmoredBonesSwordNoArmor, Bludgeoning },
            { BlueArmoredBones, Bludgeoning },
            { BlueArmoredBonesMace, Bludgeoning },
            { BlueArmoredBonesNoPants, Bludgeoning },
            { BlueArmoredBonesSword, Bludgeoning },
            { HellArmoredBones, Bludgeoning },
            { HellArmoredBonesSword, Bludgeoning },
            { HellArmoredBonesMace, Bludgeoning },
            { HellArmoredBonesSpikeShield, Bludgeoning },
            { RaggedCaster, Bludgeoning },
            { RaggedCasterOpenCoat, Bludgeoning },
            { Necromancer, Bludgeoning },
            { NecromancerArmored, Bludgeoning },
            { DiabolistRed, Bludgeoning },
            { DiabolistWhite, Bludgeoning },
            { BoneLee, Bludgeoning },
            { DungeonSpirit, Bludgeoning },
            { GiantCursedSkull, Bludgeoning },
            { Paladin, Bludgeoning },
            { SkeletonSniper, Bludgeoning },
            { TacticalSkeleton, Bludgeoning },
            { SkeletonCommando, Bludgeoning },
            #endregion
            #region Jungle
            { GiantTortoise, Piercing },
            { SpikedJungleSlime, Fire },
            #endregion

            #region Misc
            #region Slime
            { BlueSlime, Fire },
            { SlimeSpiked, Fire },
            { UmbrellaSlime, Fire },
            { SlimeMasked, Fire },
            { HoppinJack, Fire },
            { SlimeRibbonGreen, Fire },
            { SlimeRibbonRed, Fire },
            { SlimeRibbonWhite, Fire },
            { SlimeRibbonYellow, Fire },
            { GoldenSlime, Fire },
            { ShimmerSlime, Fire },
            #endregion
            { Dandelion, Fire },
            #endregion

            #region Frost Legion
            { SnowmanGangsta, Fire },
            { MisterStabby, Fire },
            { SnowBalla, Fire },
            #endregion

            #region Bosses
            { KingSlime, Fire},
            { SkeletronHead, Bludgeoning },
            { SkeletronHand, Bludgeoning },
            { DungeonGuardian, Bludgeoning },

            { QueenSlimeBoss, Fire },
            { QueenSlimeMinionBlue, Fire  },
            { QueenSlimeMinionPink, Fire },
            { QueenSlimeMinionPurple, Fire },
            #endregion
        };
    }
}
