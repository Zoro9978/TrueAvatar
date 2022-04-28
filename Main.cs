using MelonLoader;
using HarmonyLib;
using System;
using System.Text.RegularExpressions;
using System.IO;
using UnityEngine;
using System.Linq;
using BTD_Mod_Helper.Extensions;
using BTD_Mod_Helper;
using Assets.Scripts.Simulation.Towers.Weapons;

namespace BTD6_Mod_Template // change to mod name, use _ instead of whitespaces

{
    public class Main : BloonsTD6Mod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
                       LoggerInstance.Msg(" has loaded"); // if you want, add your mods name before "has loaded"
        }
        //!!!!!!!!!!!!!!IMPORTANT!!!!!!!!!!!! make sure to update AssemblyInfo.cs with your information. It is located in the Properties folder of your mod's base folder

    }
    //Simple hooks to change weapon speed to hypersonic
    [HarmonyPatch(typeof(Weapon), "Initialise")]
    public class WeaponInitialise_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Weapon __instance)
        {
            __instance.weaponModel.rate = 0;
        }
    }
    [HarmonyPatch(typeof(Weapon), "UpdatedModel")]
    public class WeaponUpdatedModel_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Weapon __instance)
        {
            __instance.weaponModel.rate = 0;
        }
    }
}

