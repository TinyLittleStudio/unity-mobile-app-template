using System.Collections.Generic;

namespace TinyLittleStudio
{
    public sealed class Modules
    {
        private static Modules defaultInstance = new Modules();

        private readonly List<Module> modules = new List<Module>();

        private bool isInitialized = false;

        private Modules()
        {

        }

        public void Initialize()
        {
            isInitialized = true;
        }

        public bool Register(Module module)
        {
            if (module == null)
            {
                throw new ExtensionException(ExtensionException.MSG_MODULE_NULL);
            }

            if (!isInitialized)
            {
                if (!IsRegistered(module.ToString()))
                {
                    modules.Add(module);
                    return true;
                }
            }
            else
            {
                throw new ExtensionException(ExtensionException.MSG_MODULE_CANNOT_REGISTER, module);
            }
            return false;
        }

        public bool Unregister(Module module)
        {
            if (module == null)
            {
                throw new ExtensionException(ExtensionException.MSG_MODULE_NULL);
            }

            if (!isInitialized)
            {
                if (IsRegistered(module.ToString()))
                {
                    modules.Remove(module);
                    return true;
                }
            }
            else
            {
                throw new ExtensionException(ExtensionException.MSG_MODULE_CANNOT_UNREGISTER, module);
            }
            return false;
        }

        public bool IsRegistered(string name)
        {
            return Find(name) != null;
        }

        public Module Enable(string name)
        {
            Module module = Find(name);
            module?.Enable();
            return module;
        }

        public Module Disable(string name)
        {
            Module module = Find(name);
            module?.Disable();
            return module;
        }

        public Module Find(string name)
        {
            foreach (Module module in modules)
            {
                if (module != null && module.ToString().Equals(name))
                {
                    return module;
                }
            }
            return null;
        }

        public static Modules DefaultInstance => Modules.defaultInstance;
    }
}
