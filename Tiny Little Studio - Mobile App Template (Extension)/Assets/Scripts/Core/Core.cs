namespace TinyLittleStudio
{
    public abstract class Core
    {
        private static Core defaultInstance;

        protected Core()
        {

        }

        public void Initialize()
        {
            if (!IsInitialized && defaultInstance != null)
            {
                if (defaultInstance == null)
                {
                    defaultInstance = this;
                }
                else
                {
                    throw new ExtensionException();
                }
                IsInitialized = true;
            }
        }

        public virtual void Awake() { }

        public virtual void Start() { }

        public virtual void Update() { }

        public virtual void LateUpdate() { }

        public virtual void FixedUpdate() { }

        public virtual void OnEnable() { }

        public virtual void OnDisable() { }

        public virtual void OnApplicationFocus() { }

        public virtual void OnApplicationPause() { }

        public virtual void OnApplicationQuit() { }

        public void Enable(string name)
        {
            Modules.Enable(name);
        }

        public void Disable(string name)
        {
            Modules.Disable(name);
        }

        public Module Find(string name)
        {
            return Modules.Find(name);
        }

        public Modules Modules => Modules.DefaultInstance;

        public bool IsInitialized { get; private set; }

        public static Core DefaultInstance => Core.defaultInstance;
    }
}
