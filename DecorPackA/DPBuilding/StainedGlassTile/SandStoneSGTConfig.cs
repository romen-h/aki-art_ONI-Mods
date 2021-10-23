﻿namespace DecorPackA.DPBuilding.StainedGlassTile
{
	class SandStoneSGTConfig : DefaultStainedGlassTileConfig
	{
		private static readonly string name = "SandStone";
		new public static string ID = Mod.PREFIX + name + "StainedGlassTile";

		public override BuildingDef CreateBuildingDef() => StainedGlassHelper.getDef(name);
	}
}