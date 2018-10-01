namespace TinyLittleStudio
{
    public abstract class Module
    {
        protected readonly string name;

        protected Module(string name)
        {
            this.name = name;
        }

        public string Name => name;

        public virtual bool Load() { return true; }

        public virtual bool Unload() { return true; }

        public virtual void OnEnable() { }

        public virtual void OnDisable() { }

        public void Enable()
        {
            OnEnable();
            IsEnabled = true;
        }

        public void Disable()
        {
            OnDisable();
            IsEnabled = false;
        }

        public bool IsEnabled { get; private set; }

        public override string ToString()
        {
            return name;
        }
    }
}
