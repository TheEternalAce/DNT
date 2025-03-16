using DNT.EnchantmentTotems;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.Localization;
using Terraria.ModLoader;
using static DNT.DNT;
using static DNT.DNT.Element;
using static Terraria.ID.ItemID;

namespace DNT
{
    public class DNTItems : GlobalItem
    {
        public static readonly Dictionary<int, Element> DefaultDamageTypes = new()
        {
            #region Accessory
            { BeeCloak, Piercing | Poison },
            { HoneyComb, Piercing | Poison },
            { StarCloak, Radiant },
            { StarVeil, Radiant },
            { StingerNecklace, Piercing | Poison },
            { SweetheartNecklace, Piercing | Poison },
            { EoCShield, Piercing },
            { BoneGlove, Bludgeoning },
            { BoneHelm, Necrotic },
            { VolatileGelatin, Radiant },
            { SporeSac, Poison },
            #endregion

            #region Magic
            #region PreHM
            { WandofSparking, Fire },
            { WandofFrosting, Cold },
            { ThunderStaff, Lightning },
            { AmethystStaff, Force },
            { TopazStaff, Force },
            { SapphireStaff, Force },
            { EmeraldStaff, Force },
            { RubyStaff, Force },
            { DiamondStaff, Force },
            { AmberStaff, Force },
            { Vilethorn, Piercing },
            { WeatherPain, Thunder },
            { MagicMissile, Force },
            { AquaScepter, Cold },
            { FlowerofFire, Fire },
            { Flamelash, Fire },

            { ZapinatorGray, Lightning },
            { SpaceGun, Lightning },
            { BeeGun, Piercing | Poison },

            { WaterBolt, Cold },
            { BookofSkulls, Necrotic },
            { DemonScythe, Necrotic },

            { CrimsonRod, Psychic },
            #endregion
            #region HM
            { SkyFracture, Thunder },
            { CrystalSerpent, Psychic },
            { FlowerofFrost, Cold },
            { FrostStaff, Cold },
            { CrystalVileShard, Piercing },
            { SoulDrain, Necrotic },
            { MeteorStaff, Bludgeoning | Fire },
            { PoisonStaff, Poison },
            { RainbowRod, Psychic },
            { UnholyTrident, Force },
            { BookStaff, Thunder },
            { VenomStaff, Poison },
            { NettleBurst, Piercing },
            { BatScepter, Piercing },
            { BlizzardStaff, Cold },
            { InfernoFork, Fire },
            { ShadowbeamStaff, Necrotic },
            { SpectreStaff, Necrotic },
            { PrincessWeapon, Radiant },
            { Razorpine, Piercing },
            { StaffofEarth, Bludgeoning },
            { ApprenticeStaffT3, Fire },

            { LaserRifle, Lightning },
            { ZapinatorOrange, Lightning },
            { WaspGun, Piercing | Poison },
            { LeafBlower, Piercing },
            { RainbowGun, Radiant },
            { HeatRay, Fire },
            { LaserMachinegun, Lightning },
            { ChargedBlasterCannon, Lightning },
            { BubbleGun, Cold },

            { CursedFlames, Fire | Necrotic },
            { GoldenShower, Psychic },
            { CrystalStorm, Piercing },
            { MagnetSphere, Lightning | Thunder },
            { RazorbladeTyphoon, Cold | Slashing },
            { LunarFlareBook, Radiant },

            { IceRod, Cold },
            { ClingerStaff, Fire | Necrotic },
            { NimbusRod, Cold },
            { MagicDagger, Force },
            { MedusaHead, Force },
            { SpiritFlame, Fire | Necrotic },
            { ShadowFlameHexDoll, Fire | Necrotic },
            { SharpTears, Psychic },
            { MagicalHarp, Thunder },
            { ToxicFlask, Acid },
            { FairyQueenMagicItem, Radiant },
            { SparkleGuitar, Radiant | Thunder },
            { NebulaArcanum, Psychic },
            { NebulaBlaze, Psychic },
            { LastPrism, Radiant },
            #endregion
            #endregion

            #region Melee
            #region Wood Weapons
            { WoodenSword, Slashing },
            { WoodenHammer, Bludgeoning },
            { WoodenBoomerang, Bludgeoning },
            { WoodYoyo, Bludgeoning },
            { BorealWoodSword, Slashing },
            { BorealWoodHammer, Bludgeoning },
            { PalmWoodSword, Slashing },
            { PalmWoodHammer, Bludgeoning },
            { RichMahoganySword, Slashing },
            { RichMahoganyHammer, Bludgeoning },
            { JungleYoyo, Poison },
            { EbonwoodSword, Slashing },
            { EbonwoodHammer, Bludgeoning },
            { ShadewoodSword, Slashing },
            { ShadewoodHammer, Bludgeoning },
            { AshWoodSword, Slashing },
            { AshWoodHammer, Bludgeoning },
            { PearlwoodSword, Slashing },
            { PearlwoodHammer, Bludgeoning },
            #endregion

            #region PreHM Weapons
            #region Metal
            { CopperPickaxe, Piercing },
            { CopperBroadsword, Slashing },
            { CopperAxe, Slashing },
            { CopperShortsword, Piercing },
            { CopperHammer, Bludgeoning },

            { TinPickaxe, Piercing },
            { TinBroadsword, Slashing },
            { TinAxe, Slashing },
            { TinShortsword, Piercing },
            { TinHammer, Bludgeoning },

            { IronPickaxe, Piercing },
            { IronBroadsword, Slashing },
            { IronAxe, Slashing },
            { IronShortsword, Piercing },
            { IronHammer, Bludgeoning },

            { LeadPickaxe, Poison },
            { LeadBroadsword, Poison },
            { LeadAxe, Poison },
            { LeadShortsword, Poison },
            { LeadHammer, Poison },

            { SilverPickaxe, Piercing },
            { SilverBroadsword, Slashing },
            { SilverAxe, Slashing },
            { SilverShortsword, Piercing },
            { SilverHammer, Bludgeoning },

            { TungstenPickaxe, Piercing },
            { TungstenBroadsword, Slashing },
            { TungstenAxe, Slashing },
            { TungstenShortsword, Piercing },
            { TungstenHammer, Bludgeoning },

            { GoldPickaxe, Piercing },
            { GoldBroadsword, Slashing },
            { GoldAxe, Slashing },
            { GoldShortsword, Piercing },
            { GoldHammer, Bludgeoning },

            { PlatinumPickaxe, Piercing },
            { PlatinumBroadsword, Slashing },
            { PlatinumAxe, Slashing },
            { PlatinumShortsword, Piercing },
            { PlatinumHammer, Bludgeoning },

            { NightmarePickaxe, Piercing },
            { LightsBane, Slashing },
            { WarAxeoftheNight, Slashing },
            { BallOHurt, Bludgeoning },
            { TheBreaker, Bludgeoning },
            { CorruptYoyo, Bludgeoning },

            { DeathbringerPickaxe, Piercing },
            { BloodButcherer, Slashing },
            { BloodLustCluster, Slashing },
            { TheMeatball, Bludgeoning },
            { TheRottedFork, Piercing },
            { FleshGrinder, Bludgeoning },
            { CrimsonYoyo, Bludgeoning },

            { MeteorHamaxe, Fire },

            { BluePhaseblade, Force },
            { GreenPhaseblade, Force },
            { OrangePhaseblade, Force },
            { PurplePhaseblade, Force },
            { RedPhaseblade, Force },
            { WhitePhaseblade, Force },
            { YellowPhaseblade, Force },

            { LucyTheAxe, Slashing },

            { FieryGreatsword, Fire },
            { BladeofGrass, Poison },
            { Muramasa, Necrotic },
            { NightsEdge, Necrotic },
            #endregion
            { CactusSword, Piercing | Slashing },
            { ZombieArm, Bludgeoning },
            { AntlionClaw, Piercing },
            { StylistKilLaKillScissorsIWish, Slashing },
            { Ruler, Bludgeoning },
            { Umbrella, Piercing },
            { BreathingReed, Bludgeoning },
            { Gladius, Piercing },
            { BoneSword, Slashing },
            { IceBlade, Cold },
            { TragicUmbrella, Piercing },
            { BatBat, Bludgeoning },
            { TentacleSpike, Piercing },
            { DyeTradersScimitar, Slashing },
            { Starfury, Thunder },
            { EnchantedSword, Force },
            { PurpleClubberfish, Bludgeoning },
            { BeeKeeper, Piercing | Poison },
            { FalconBlade, Slashing },

            { Rally, Bludgeoning },
            { Code1, Bludgeoning },
            { Valor, Bludgeoning },
            { Cascade, Fire },
            { HiveFive, Poison },

            { Spear, Piercing },
            { Trident, Piercing },
            { ThunderSpear, Lightning },
            { Swordfish, Piercing },
            { DarkLance, Necrotic },

            { EnchantedBoomerang, Force },
            { FruitcakeChakram, Piercing },
            { BloodyMachete, Slashing },
            { Shroomerang, Psychic },
            { IceBoomerang, Cold },
            { ThornChakram, Poison },
            { CombatWrench, Bludgeoning },
            { Flamarang, Fire },
            { Trimarang, Force },

            { Mace, Bludgeoning },
            { FlamingMace, Fire },
            { BlueMoon, Cold },
            { Sunfury, Fire },
            { ChainKnife, Piercing },

            { Terragrim, Force },

            { CactusPickaxe, Piercing },
            { CnadyCanePickaxe, Piercing },
            { FossilPickaxe, Piercing },
            { BonePickaxe, Piercing },
            { SawtoothShark, Piercing },
            { ReaverShark, Piercing },
            { AcornAxe, Slashing },
            { StaffofRegrowth, Bludgeoning },
            #endregion

            #region HM Weapons
            #region Metal
            { CobaltPickaxe, Piercing },
            { CobaltWaraxe, Piercing },
            { CobaltDrill, Piercing },
            { CobaltChainsaw, Slashing },
            { CobaltSword, Slashing },
            { CobaltNaginata, Piercing },

            { PalladiumPickaxe, Piercing },
            { PalladiumWaraxe, Slashing },
            { PalladiumDrill, Piercing },
            { PalladiumChainsaw, Slashing },
            { PalladiumSword, Slashing },
            { PalladiumPike, Piercing },

            { BluePhasesaber, Force },
            { GreenPhasesaber, Force },
            { OrangePhasesaber, Force },
            { PurplePhasesaber, Force },
            { RedPhasesaber, Force },
            { WhitePhasesaber, Force },
            { YellowPhasesaber, Force },

            { MythrilPickaxe, Piercing },
            { MythrilWaraxe, Slashing },
            { MythrilDrill, Piercing },
            { MythrilChainsaw, Slashing },
            { MythrilSword, Slashing },
            { MythrilHalberd, Piercing },

            { OrichalcumPickaxe, Piercing },
            { OrichalcumWaraxe, Slashing },
            { OrichalcumDrill, Piercing },
            { OrichalcumChainsaw, Slashing },
            { OrichalcumSword, Slashing },
            { OrichalcumHalberd, Piercing },

            { AdamantitePickaxe, Piercing },
            { AdamantiteWaraxe, Slashing },
            { AdamantiteDrill, Piercing },
            { AdamantiteChainsaw, Slashing },
            { AdamantiteSword, Slashing },
            { AdamantiteGlaive, Piercing },

            { TitaniumPickaxe, Piercing },
            { TitaniumWaraxe, Slashing },
            { TitaniumDrill, Piercing },
            { TitaniumChainsaw, Slashing },
            { TitaniumSword, Slashing },
            { TitaniumTrident, Piercing },

            { Excalibur, Radiant  },
            { Gungnir, Radiant },
            { PickaxeAxe, Radiant },
            { Drax, Radiant },
            { Pwnhammer, Radiant },
            { LightDisc, Radiant },
            { HallowJoustingLance, Radiant },

            { ChlorophyteSaber, Poison },
            { ChlorophyteClaymore, Poison },
            { ChlorophytePartisan, Poison },
            { ChlorophyteWarhammer, Poison },
            { ChlorophytePickaxe, Poison },
            { ChlorophyteGreataxe, Poison },
            { ChlorophyteDrill, Poison },
            { ChlorophyteChainsaw, Poison },
            { ChlorophyteJackhammer, Poison },

            { ShroomiteDiggingClaw, Slashing },

            { TrueExcalibur, Radiant },
            { TrueNightsEdge, Necrotic },
            { TerraBlade, Force },

            { NebulaPickaxe, Psychic },
            { LunarHamaxeNebula, Psychic },
            { SolarFlarePickaxe, Fire },
            { LunarHamaxeSolar, Fire },
            { StardustPickaxe, Radiant },
            { LunarHamaxeStardust, Radiant },
            { VortexPickaxe, Lightning },
            { LunarHamaxeVortex, Lightning },
            #endregion
            { TaxCollectorsStickOfDoom, Thunder },
            { SlapHand, Thunder },
            { IceSickle, Cold },
            { DD2SquireDemonSword, Cold },
            { BreakerBlade, Thunder },
            { Cutlass, Slashing },
            { Frostbrand, Cold },
            { BeamSword, Radiant },
            { FetidBaghnakhs, Slashing },
            { Bladetongue, Slashing },
            { HamBat, Bludgeoning },
            { WaffleIron, Fire },
            { DeathSickle, Necrotic },
            { PsychoKnife, Slashing },
            { Keybrand, Radiant },
            { TheHorsemansBlade, Fire },
            { ChristmasTreeSword, Piercing },
            { Seedler, Poison },
            { DD2SquireBetsySword, Fire },
            { InfluxWaver, Lightning },
            { StarWrath, Thunder },
            { Meowmere, Thunder }, // Because it's noisy as FUCK

            { FormatC, Bludgeoning },
            { Gradient, Bludgeoning },
            { Chik, Radiant },
            { HelFire, Fire },
            { Amarok, Cold },
            { Code2, Bludgeoning },
            { Yelets, Poison },
            { RedsYoyo, Force },
            { ValkyrieYoyo, Lightning },
            { Kraken, Cold },
            { TheEyeOfCthulhu, Bludgeoning },
            { Terrarian, Force },

            { MonkStaffT2, Fire },
            { MushroomSpear, Psychic },
            { ObsidianSwordfish, Piercing },
            { NorthPole, Cold },

            { FlyingKnife, Psychic },
            { BouncingShield, Bludgeoning },
            { Bananarang, Bludgeoning },
            { PossessedHatchet, Slashing },
            { PaladinsHammer, Radiant },

            { DripplerFlail, Bludgeoning },
            { DaoofPow, Necrotic | Radiant },
            { FlowerPow, Poison },
            { Anchor, Bludgeoning | Piercing },
            { ChainGuillotines, Piercing },
            { KOCannon, Bludgeoning },
            { GolemFist, Fire },
            { Flairon, Cold },

            { Arkhalis, Force },
            { JoustingLance, Piercing },
            { ShadowFlameKnife, Fire | Necrotic },
            { MonkStaffT1, Bludgeoning },
            { ScourgeoftheCorruptor, Necrotic },
            { VampireKnives, Necrotic },
            { ShadowJoustingLance, Necrotic },
            { PiercingStarlight, Radiant },
            { MonkStaffT3, Lightning },
            { DayBreak, Fire },
            { SolarEruption, Fire },
            { Zenith, Force },
            { FirstFractal, Force },

            { BloodHamaxe, Bludgeoning | Slashing },
            { Picksaw, Piercing | Slashing },
            { TheAxe, Thunder },
            #endregion
            #endregion

            #region Ranged
            #region PreHM
            { WoodenBow, Piercing },
            { BorealWoodBow, Piercing },
            { PalmWoodBow, Piercing },
            { RichMahoganyBow, Piercing },
            { EbonwoodBow, Piercing },
            { ShadewoodBow, Piercing },
            { AshWoodBow, Piercing },
            { CopperBow, Piercing },
            { TinBow, Piercing },
            { IronBow, Piercing },
            { LeadBow, Piercing },
            { SilverBow, Piercing },
            { TungstenBow, Piercing },
            { GoldBow, Piercing },
            { PlatinumBow, Piercing },
            { DemonBow, Necrotic },
            { TendonBow, Necrotic },
            { BloodRainBow, Psychic },
            { BeesKnees, Piercing | Poison },
            { HellwingBow, Fire },
            { MoltenFury, Fire },

            { RedRyder, Piercing },
            { FlintlockPistol, Piercing },
            { Musket, Piercing },
            { TheUndertaker, Piercing },
            { Revolver, Piercing },
            { Minishark, Piercing },
            { Boomstick, Piercing },
            { QuadBarrelShotgun, Piercing },
            { Handgun, Piercing },
            { PhoenixBlaster, Piercing },
            { PewMaticHorn, Bludgeoning },

            { PaperAirplaneA, Bludgeoning },
            { PaperAirplaneB, Bludgeoning },
            { Shuriken, Piercing },
            { ThrowingKnife, Piercing },
            { PoisonedKnife, Poison },
            { Snowball, Cold },
            { SpikyBall, Piercing },
            { Bone, Bludgeoning },
            { RottenEgg, Poison },
            { StarAnise, Piercing },
            { MolotovCocktail, Fire },
            { FrostDaggerfish, Cold },
            { Javelin, Piercing },
            { BoneJavelin, Piercing },
            { BoneDagger, Piercing },

            { Grenade, Force },
            { StickyGrenade, Force },
            { BouncyGrenade, Force },
            { Beenade, Piercing | Poison },
            { PartyGirlGrenade, Force },

            { Blowgun, Piercing },
            { Sandgun, Bludgeoning },
            { Blowpipe, Piercing },
            { SnowballCannon, Cold },
            { PainterPaintballGun, Bludgeoning },
            { AleThrowingGlove, Poison },
            { Harpoon, Piercing },
            { StarCannon, Radiant },

            { MusketBall, Piercing },
            { MeteorShot, Fire },
            { SilverBullet, Piercing },
            { TungstenBullet, Piercing },
            { PartyBullet, Piercing },

            { WoodenArrow, Piercing },
            { FlamingArrow, Piercing },
            { UnholyArrow, Piercing },
            { JestersArrow, Piercing },
            { HellfireArrow, Piercing },
            { FrostburnArrow, Piercing },
            { BoneArrow, Piercing },
            { ShimmerArrow, Piercing },

            { Seed, Bludgeoning },
            { PoisonDart, Poison },
            #endregion
            #region HM
            { PearlwoodBow, Radiant },
            { SkeletonBow, Piercing },
            { IceBow, Cold },
            { DaedalusStormbow, Lightning },
            { ShadowFlameBow, Fire },
            { CobaltRepeater, Piercing },
            { PalladiumRepeater, Piercing },
            { MythrilRepeater, Piercing },
            { OrichalcumRepeater, Piercing },
            { AdamantiteRepeater, Piercing },
            { TitaniumRepeater, Piercing },
            { HallowedRepeater, Radiant },
            { ChlorophyteShotbow, Poison },
            { DD2PhoenixBow, Fire },
            { PulseBow, Force },
            { StakeLauncher, Piercing },
            { DD2BetsyBow, Fire },
            { Tsunami, Cold },
            { FairyQueenRangedItem, Radiant },
            { Phantasm, Radiant },

            { ClockworkAssaultRifle, Piercing },
            { Gatligator, Piercing },
            { Shotgun, Piercing },
            { OnyxBlaster, Force },
            { Uzi, Piercing },
            { Megashark, Piercing },
            { VenusMagnum, Poison },
            { TacticalShotgun, Piercing },
            { SniperRifle, Piercing },
            { CandyCornRifle, Poison },
            { ChainGun, Piercing },
            { Xenopopper, Piercing },
            { VortexBeater, Radiant },
            { SDMG, Piercing },

            { GrenadeLauncher, Force },
            { ProximityMineLauncher, Force },
            { RocketLauncher, Force },
            { NailGun, Piercing },
            { Stynger, Force },
            { JackOLanternLauncher, Fire },
            { SnowmanCannon, Cold | Force },
            { FireworksLauncher, Force },
            { ElectrosphereLauncher, Lightning },
            { Celeb2, Force },

            { Toxikarp, Poison },
            { DartPistol, Necrotic },
            { DartRifle, Necrotic },
            { CoinGun, Bludgeoning },
            { Flamethrower, Fire },
            { PiranhaGun, Piercing },
            { ElfMelter, Cold },
            { SuperStarCannon, Radiant },

            { CrystalBullet, Piercing },
            { CursedBullet, Fire },
            { ChlorophyteBullet, Poison },
            { HighVelocityBullet, Piercing },
            { IchorBullet, Psychic },
            { NanoBullet, Lightning },
            { ExplodingBullet, Force },
            { GoldenBullet, Piercing },
            { EndlessMusketPouch, Piercing },
            { MoonlordBullet, Radiant },

            { HolyArrow, Radiant },
            { CursedArrow, Fire },
            { ChlorophyteArrow, Poison },
            { IchorArrow, Psychic },
            { VenomArrow, Poison },
            { EndlessQuiver, Piercing },
            { MoonlordArrow, Radiant },

            { RocketI, Force },
            { RocketII, Force },
            { RocketIII, Force },
            { RocketIV, Force },
            { ClusterRocketI, Force },
            { ClusterRocketII, Force },
            { DryRocket, Force },
            { WetRocket, Cold },
            { LavaRocket, Fire },
            { HoneyRocket, Cold },
            { MiniNukeI, Force },
            { MiniNukeII, Force },

            { CrystalDart, Piercing },
            { CursedDart, Fire },
            { IchorDart, Psychic },

            { StyngerBolt, Force },
            { CandyCorn, Poison },
            { ExplosiveJackOLantern, Fire },
            { Stake, Piercing },
            { Nail, Piercing },
            #endregion
            #endregion

            #region Summon
            #region PreHM
            { BabyBirdStaff, Piercing },
            { SlimeStaff, Acid },
            { FlinxStaff, Bludgeoning },
            { AbigailsFlower, Necrotic },
            { HornetStaff, Poison },
            { VampireFrogStaff, Acid },
            { ImpStaff, Fire },

            { HoundiusShootius, Fire },
            { DD2LightningAuraT1Popper, Lightning },
            { DD2FlameburstTowerT1Popper, Fire },
            { DD2ExplosiveTrapT1Popper, Force },
            { DD2BallistraTowerT1Popper, Piercing },

            { BlandWhip, Slashing },
            { ThornWhip, Slashing },
            { BoneWhip, Slashing },
            #endregion
            #region HM
            { Smolstar, Psychic },
            { SpiderStaff, Poison },
            { PirateStaff, Slashing },
            { SanguineStaff, Psychic },
            { OpticStaff, Lightning | Piercing },
            { DeadlySphereStaff, Piercing },
            { PygmyStaff, Piercing },
            { RavenStaff, Piercing },
            { StormTigerStaff, Lightning },
            { TempestStaff, Cold },
            { EmpressBlade, Radiant },
            { XenoStaff, Lightning },
            { StardustCellStaff, Poison },
            { StardustDragonStaff, Cold },

            { QueenSpiderStaff, Poison },
            { StaffoftheFrostHydra, Cold },
            { MoonlordTurretStaff, Radiant },
            { RainbowCrystalStaff, Radiant },
            { DD2LightningAuraT2Popper, Lightning },
            { DD2LightningAuraT3Popper, Lightning },
            { DD2FlameburstTowerT2Popper, Fire },
            { DD2FlameburstTowerT3Popper, Fire },
            { DD2ExplosiveTrapT2Popper, Force },
            { DD2ExplosiveTrapT3Popper, Force },
            { DD2BallistraTowerT2Popper, Piercing },
            { DD2BallistraTowerT3Popper, Piercing },

            { FireWhip, Fire },
            { CoolWhip, Cold },
            { SwordWhip, Radiant },
            { ScytheWhip, Necrotic },
            { MaceWhip, Bludgeoning },
            { RainbowWhip, Radiant },
            #endregion
            #endregion
        };

        public Element damageTypes = Element.None;

        public override bool InstancePerEntity => true;

        public override void SetDefaults(Item entity)
        {
            if (ContentSetup && damageTypes == Element.None && DefaultDamageTypes.TryGetValue(entity.type, out var value) && value != Element.None) damageTypes |= value;
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            string dntTypeKey = "Mods.DNT.ElementTooltip.Item" + item.type;
            if (Language.Exists(dntTypeKey))
            {
                var line = new TooltipLine(Mod, "DNTTypeTooltip", Language.GetTextValue(dntTypeKey));
                tooltips.Insert(DNTHelper.GetIndex(tooltips, "OneDropLogo"), line);
            }

            if (damageTypes != Element.None)
            {
                var line1 = new TooltipLine(Mod, "DNTTypesTooltip", "Hold Left Shift to see damage types");
                if (Keyboard.GetState().IsKeyDown(Keys.LeftShift)) line1 = new TooltipLine(Mod, "DNTTypesTooltip", damageTypes.ToString());
                tooltips.Insert(DNTHelper.GetIndex(tooltips, "OneDropLogo"), line1);
            }
        }

        public override void ModifyItemLoot(Item item, ItemLoot itemLoot)
        {
            if (item.type == KingSlimeBossBag) itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SlimedTotem>(), 3));
            if (item.type == SkeletronBossBag) itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<RageTotem>(), 3));
            if (item.type == PlanteraBossBag) itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<OvergrownTotem>(), 3));
            if (item.type == GolemBossBag) itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SentientTotem>(), 3));
        }
    }
}
