using BepInEx;
using GorillaNetworking;
using HarmonyLib;
using Photon.Pun;
using System;
using UnityEngine;

namespace WearItAnyway
{
    [HarmonyPatch(typeof(VRRig))]
    [HarmonyPatch("IsItemAllowed", MethodType.Normal)]
    internal class SlidePatch
    {
        private static void Postfix(VRRig __instance, ref bool __result)
        {
            __result = true;
        }
    }
}
