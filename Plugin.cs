using BepInEx;
using System;

namespace MODNAME
{
    [BepInPlugin(MOD_GUID, MOD_NAME, MOD_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public const string MOD_GUID = "CREATOR.MODNAME";
        public const string MOD_NAME = "MODNAME";
        public const string MOD_VERSION = "0.0.0";

        public void Awake()
        {
        }
    }
}
