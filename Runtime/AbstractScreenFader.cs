using UnityEngine;

namespace ActionCode.ScreenFadeSystem
{
    /// <summary>
    /// Abstract component able to fade the screen in and out asynchronously.
    /// </summary>
    public abstract class AbstractScreenFader : MonoBehaviour
    {
        /// <summary>
        /// Fades the screen in (the Scene content will appear).
        /// </summary>
        /// <returns>An awaitable operation.</returns>
        public abstract Awaitable FadeInAsync();

        /// <summary>
        /// Fades the screen out (the Scene content will disappear).
        /// </summary>
        /// <returns>An awaitable operation.</returns>
        public abstract Awaitable FadeOutAsync();
    }
}