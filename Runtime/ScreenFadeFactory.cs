using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ActionCode.ScreenFadeSystem
{
    /// <summary>
    /// Factory for <see cref="AbstractScreenFader"/> implementations.
    /// </summary>
    public static class ScreenFadeFactory
    {
        private readonly static Dictionary<EntityId, GameObject> instances = new();

        /// <summary>
        /// Creates or returns an <see cref="AbstractScreenFader"/> implementation.
        /// </summary>
        /// <param name="faderPrefab">The prefab containing a component implementing <see cref="AbstractScreenFader"/>.</param>
        /// <returns>Always a global instance of <see cref="AbstractScreenFader"/>.</returns>
        public static AbstractScreenFader Create(AbstractScreenFader faderPrefab)
        {
            if (faderPrefab == null) return null;

            var prefabId = faderPrefab.gameObject.GetEntityId();
            var hasInstance = instances.TryGetValue(prefabId, out GameObject prefab) && prefab != null;
            if (hasInstance) return prefab.GetComponent<AbstractScreenFader>();

            prefab = faderPrefab.gameObject;
            var instance = Object.Instantiate(prefab);

            instance.name = prefab.name;

            instances.Remove(prefabId);
            instances.TryAdd(prefabId, instance);

            Object.DontDestroyOnLoad(instance);

            return instance.GetComponent<AbstractScreenFader>();
        }

        /// <summary>
        /// Tries to get the first Screen Fader available.
        /// </summary>
        /// <param name="fader">An AbstractScreenFader implementation instance.</param>
        /// <returns>Whether a fader was found.</returns>
        public static bool TryGetFirst(out AbstractScreenFader fader)
        {
            fader = null;
            var instance = instances.FirstOrDefault().Value;
            return instance && instance.TryGetComponent(out fader);
        }
    }
}