﻿using FUtility;
using HarmonyLib;
using KMod;

namespace TwelveCyclesOfChristmas
{
    public class Mod : UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            base.OnLoad(harmony);
            Log.PrintVersion();
            Debug.Log("LOADED");
        }
    }
}
