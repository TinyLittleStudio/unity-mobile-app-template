using UnityEngine;

namespace TinyLittleStudio
{
    public sealed class CoreMono : MonoBehaviour
    {
        public const string OBJECT_NAME = "CoreMono";

        private CoreMono()
        {

        }

        private void Awake()
        {
            if (Core != null)
            {
                Core.Awake();
            }
        }

        private void Start()
        {
            if (Core != null)
            {
                Core.Start();
            }
        }

        private void Update()
        {
            if (Core != null)
            {
                Core.Update();
            }
        }

        private void FixedUpdate()
        {
            if (Core != null)
            {
                Core.FixedUpdate();
            }
        }

        private void LateUpdate()
        {
            if (Core != null)
            {
                Core.LateUpdate();
            }
        }

        private void OnEnable()
        {
            if (Core != null)
            {
                Core.OnEnable();
            }
        }

        private void OnDisable()
        {
            if (Core != null)
            {
                Core.OnDisable();
            }
        }

        private void OnApplicationFocus()
        {
            if (Core != null)
            {
                Core.OnApplicationFocus();
            }
        }

        private void OnApplicationPause()
        {
            if (Core != null)
            {
                Core.OnApplicationPause();
            }
        }

        private void OnApplicationQuit()
        {
            if (Core != null)
            {
                Core.OnApplicationQuit();
            }
        }

        public Core Core => Manager.GetCore();
    }
}
