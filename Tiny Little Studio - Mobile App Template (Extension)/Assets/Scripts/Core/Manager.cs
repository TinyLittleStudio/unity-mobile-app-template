using UnityEngine;

namespace TinyLittleStudio
{
    public sealed class Manager
    {
        private static readonly Manager defaultInstance = new Manager();

        private Manager()
        {
            GameObject = new GameObject(CoreMono.OBJECT_NAME, typeof(CoreMono));

            if (GameObject != null)
            {
                CoreMono = GameObject.GetComponent<CoreMono>();
            }
        }

        public Core Core { get; private set; }

        public CoreMono CoreMono { get; private set; }

        public GameObject GameObject { get; private set; }

        public static Core SetCore(Core core)
        {
            Manager manager = Manager.defaultInstance;

            if (manager == null)
            {
                throw new ExtensionException(ExtensionException.MSG_MANAGER_INITIALIZATION_ERROR);
            }
            else
            {
                if (core == null)
                {
                    throw new ExtensionException(ExtensionException.MSG_MANAGER_CORE_NULL);
                }
            }
            return (manager.Core = core);
        }

        public static Core GetCore()
        {
            Manager manager = Manager.defaultInstance;

            if (manager == null)
            {
                throw new ExtensionException(ExtensionException.MSG_MANAGER_INITIALIZATION_ERROR);
            }
            else
            {
                if (manager.Core == null)
                {
                    throw new ExtensionException(ExtensionException.MSG_MANAGER_CORE_GET_NULL);
                }
            }
            return manager.Core;
        }

        public static bool IsCoreInitialized => Manager.defaultInstance != null && Manager.defaultInstance.Core != null && Manager.defaultInstance.Core.IsInitialized;

        public static Manager DefaultInstance => defaultInstance;
    }
}
