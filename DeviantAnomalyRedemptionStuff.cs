using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using DeviantAnomalyRedemptionStuff.Content.Items.Armor.Vanity;

namespace DeviantAnomalyRedemptionStuff
{
	public class DeviantAnomalyRedemptionStuff : Mod
	{
		public static DeviantAnomalyRedemptionStuff Instance { get; private set; }

		public static int xevhaFemLegID;
		public static int xevhaMaleLegID;

		public DeviantAnomalyRedemptionStuff()
        {
			Instance = this;
        }
		public override void Load()
        {
			if (!Main.dedServ)
			{
				xevhaFemLegID = EquipLoader.AddEquipTexture(this, "DeviantAnomalyRedemptionStuff/Content/Items/Armor/Vanity/DeviantAnomalyLegs_FemaleLegs", EquipType.Legs, ModContent.GetInstance<DeviantAnomalyLegs>());
				xevhaMaleLegID = EquipLoader.AddEquipTexture(this, "DeviantAnomalyRedemptionStuff/Content/Items/Armor/Vanity/DeviantAnomalyLegs_Legs", EquipType.Legs, ModContent.GetInstance<DeviantAnomalyLegs>());
			}
        }
        public override void AddRecipeGroups()
        {
			RecipeGroup DARSAdamantiteOrTitaniumBar = new RecipeGroup(() => "Adamantite or Titanium Bar", new int[]
			{
				ItemID.AdamantiteBar,
				ItemID.TitaniumBar
			});
			RecipeGroup.RegisterGroup("DeviantAnomalyRedemptionStuff:Adamantite or Titanium Bar", DARSAdamantiteOrTitaniumBar);

			RecipeGroup DARSCursedFlameOrIchor = new RecipeGroup(() => "Cursed Flame or Ichor", new int[]
			{
				ItemID.CursedFlame,
				ItemID.Ichor
			});
			RecipeGroup.RegisterGroup("DeviantAnomalyRedemptionStuff:Cursed Flame or Ichor", DARSCursedFlameOrIchor);
		}
    }
}