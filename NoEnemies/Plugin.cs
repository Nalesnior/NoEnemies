using System;
using System.Collections.Generic;
using BepInEx;
using HarmonyLib;

namespace NoEnemies
{
    [BepInPlugin("com.nalesnior.noenemies", "No Enemies", "1.0.0")]
    public class core : BaseUnityPlugin
    {
        private void Awake()
        {
            var harmony = new Harmony("com.nalesnior.noenemies");
            harmony.PatchAll();
        }
    }
}