using UnityEngine;

namespace Principle
{
    /// <summary>
    /// kRPC Principia addon.
    /// </summary>
    [KSPAddon(KSPAddon.Startup.SpaceCentre, true)]
    public class Addon : MonoBehaviour
    {
        /// <summary>
        /// Load the Principia API.
        /// </summary>
        public void Start()
        {
            PrincipiaWrapper.InitPrincipia();
        }
    }
}