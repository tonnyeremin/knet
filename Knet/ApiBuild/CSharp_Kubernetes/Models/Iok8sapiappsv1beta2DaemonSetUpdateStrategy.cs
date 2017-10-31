// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace KuberentesService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// DaemonSetUpdateStrategy is a struct used to control the update strategy
    /// for a DaemonSet.
    /// </summary>
    public partial class Iok8sapiappsv1beta2DaemonSetUpdateStrategy
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiappsv1beta2DaemonSetUpdateStrategy class.
        /// </summary>
        public Iok8sapiappsv1beta2DaemonSetUpdateStrategy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiappsv1beta2DaemonSetUpdateStrategy class.
        /// </summary>
        /// <param name="rollingUpdate">Rolling update config params. Present
        /// only if type = "RollingUpdate".</param>
        /// <param name="type">Type of daemon set update. Can be
        /// "RollingUpdate" or "OnDelete". Default is RollingUpdate.</param>
        public Iok8sapiappsv1beta2DaemonSetUpdateStrategy(Iok8sapiappsv1beta2RollingUpdateDaemonSet rollingUpdate = default(Iok8sapiappsv1beta2RollingUpdateDaemonSet), string type = default(string))
        {
            RollingUpdate = rollingUpdate;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets rolling update config params. Present only if type =
        /// "RollingUpdate".
        /// </summary>
        [JsonProperty(PropertyName = "rollingUpdate")]
        public Iok8sapiappsv1beta2RollingUpdateDaemonSet RollingUpdate { get; set; }

        /// <summary>
        /// Gets or sets type of daemon set update. Can be "RollingUpdate" or
        /// "OnDelete". Default is RollingUpdate.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
