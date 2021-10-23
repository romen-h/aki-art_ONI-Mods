﻿namespace DecorPackA.DPBuilding.StainedGlassTile
{
	class GraniteSGTConfig : DefaultStainedGlassTileConfig
	{
		private static readonly string name = "Granite";
		new public static string ID = Mod.PREFIX + name + "StainedGlassTile";

		public override BuildingDef CreateBuildingDef() => StainedGlassHelper.getDef(name);
	}
}