using System;
using System.Linq;
using DeviantAnomalyRedemptionStuff.Content.Items.Weapons.Magic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace DeviantAnomalyRedemptionStuff.Common
{
    public class WeaponImages : PlayerDrawLayer
    {
        private Asset<Texture2D> XenomiteBusterTexture;
        public override bool GetDefaultVisibility(PlayerDrawSet drawInfo)
        {
            var itemTypes = new int[] { ModContent.ItemType<XenomiteCrystalBomb1>(), ModContent.ItemType<XenomiteCrystalBomb2>(), ModContent.ItemType<XenomiteCrystalBomb3>(), ModContent.ItemType<XenomiteCrystalBomb4>(), ModContent.ItemType<XenomiteCrystalBomb5>(), ModContent.ItemType<XenomiteCrystalBomb6>() };
            return itemTypes.Contains(drawInfo.drawPlayer.HeldItem?.type ?? 0);
        }
        public override Position GetDefaultPosition() => new AfterParent(PlayerDrawLayers.HandOnAcc);

        protected override void Draw(ref PlayerDrawSet drawInfo)
        {
            if (XenomiteBusterTexture == null)
            {
                XenomiteBusterTexture = ModContent.Request<Texture2D>("DeviantAnomalyRedemptionStuff/Content/Items/Weapons/Magic/XenomiteBuster");
            }
            var position = drawInfo.Center + new Vector2(0, 0) - Main.screenPosition;
            position = new Vector2((int)position.X, (int)position.Y - 3);

            drawInfo.DrawDataCache.Add(new DrawData(
                XenomiteBusterTexture.Value,
                position,
                drawInfo.compFrontArmFrame,
                Lighting.GetColor((int)(drawInfo.Center.X / 16), (int)(drawInfo.Center.Y / 16), Color.White),
                0f,
                new Vector2(drawInfo.compFrontArmFrame.Width, drawInfo.compFrontArmFrame.Height) * 0.5f,
                1f,
                drawInfo.playerEffect,
                0
            ));
        }
    }
}