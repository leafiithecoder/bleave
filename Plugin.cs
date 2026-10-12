using BepInEx;
using bleave.Patches;
using bleave.Utilities;
using UnityEngine;

namespace bleave;

[BepInPlugin(Constants.Name, Constants.Guid, Constants.Version)]
public class Plugin : BaseUnityPlugin
{
    private void Start()
    {
        HarmonyPatches.Patch();
        GorillaTagger.OnPlayerSpawned(() =>
            MethodUtilities.Attempt(OnPlayerSpawned));
    }

    private void OnPlayerSpawned()
    {
        Debug.Log("bleave init");
    }
}
