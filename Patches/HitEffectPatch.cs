﻿using HarmonyLib;
using Il2CppAssets.Scripts.GameCore.GameObjectLogics.GameObjectManager;
using SelectiveEffects.Managers;

namespace SelectiveEffects.Patches
{
    [HarmonyPatch(typeof(AttackEffectManager), nameof(AttackEffectManager.PlayAttackEffect))]
    internal static class HitEffectPatch
    {
        public static void Postfix(AttackEffectManager __instance)
        {
            if (!SettingsManager.Enabled) return;

            if (!SettingsManager.DisableHitEffects) return;
            __instance.m_PlayResult.SetActive(false);
        }
    }
}
