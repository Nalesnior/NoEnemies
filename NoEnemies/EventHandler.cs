using System;
using System.Collections.Generic;
using UnityEngine;
using HarmonyLib;
using BepInEx;

namespace NoEnemies
{
    [HarmonyPatch(typeof(EnemyDirector), "Update")]
    public static class main
    {
        [HarmonyPrefix]
        public static bool RejectUpdate()
        {
            return false;
        }
    }

    [HarmonyPatch(typeof(LevelGenerator), "EnemySpawn")]
    public static class rejectSpawn
    {
        [HarmonyPrefix]
        public static bool RejectEnemySpawn()
        {
            return false;
        }
    }
}