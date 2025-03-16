﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;
using static DNT.DNT;

namespace DNT
{
    public class BestiaryImmunityInfo(Element immunities) : IBestiaryInfoElement
    {
        public Element damageTypes = immunities;

        public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
        {
            UIPanel backgroundPanel = new(Main.Assets.Request<Texture2D>("Images/UI/Bestiary/Stat_Panel", (AssetRequestMode)2), null, 12, 7)
            {
                Width = new StyleDimension(-11f, 1f),
                Height = new StyleDimension(90f, 0f),
                BackgroundColor = new Color(43, 56, 101),
                BorderColor = Color.Transparent,
                Left = new StyleDimension(2.5f, 0f),
                PaddingLeft = 4f,
                PaddingRight = 4f
            };
            UIText titleText = new("Immune Damage")
            {
                HAlign = 0f,
                VAlign = 0f,
                Width = StyleDimension.FromPixelsAndPercent(0f, 1f),
                Height = StyleDimension.FromPixelsAndPercent(0f, 1f),
                IsWrapped = true
            };
            backgroundPanel.Append(titleText);
            UIText elementText = new(damageTypes.ToString(), 0.8f)
            {
                HAlign = 0f,
                VAlign = 0f,
                Width = StyleDimension.FromPixelsAndPercent(0f, 1f),
                Height = StyleDimension.FromPixelsAndPercent(0f, 1f),
                IsWrapped = true,
                Top = new StyleDimension(0f, 0.4f),
                Left = new StyleDimension(0f, 0.05f)
            };
            backgroundPanel.Append(elementText);
            return backgroundPanel;
        }
    }
}
