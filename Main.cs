using GorillaLocomotion;
using HarmonyLib;
using UnityEngine;

namespace bleave // no skid 😛😛😛
{
    [HarmonyPatch(typeof(GTPlayer), nameof(GTPlayer.LateUpdate))]
    public class Main : MonoBehaviour // simplest mod EVER
    {
        public static void Prefix()
        {
            if (ControllerInputPoller.instance.leftControllerPrimaryButton)
            {
                NetworkSystem.Instance.ReturnToSinglePlayer();
            }
        }
    }
}
