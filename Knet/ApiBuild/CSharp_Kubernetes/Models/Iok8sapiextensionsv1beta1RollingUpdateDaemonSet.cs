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
    /// Spec to control the desired behavior of daemon set rolling update.
    /// </summary>
    public partial class Iok8sapiextensionsv1beta1RollingUpdateDaemonSet
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiextensionsv1beta1RollingUpdateDaemonSet class.
        /// </summary>
        public Iok8sapiextensionsv1beta1RollingUpdateDaemonSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiextensionsv1beta1RollingUpdateDaemonSet class.
        /// </summary>
        /// <param name="maxUnavailable">The maximum number of DaemonSet pods
        /// that can be unavailable during the update. Value can be an absolute
        /// number (ex: 5) or a percentage of total number of DaemonSet pods at
        /// the start of the update (ex: 10%). Absolute number is calculated
        /// from percentage by rounding up. This cannot be 0. Default value is
        /// 1. Example: when this is set to 30%, at most 30% of the total
        /// number of nodes that should be running the daemon pod (i.e.
        /// status.desiredNumberScheduled) can have their pods stopped for an
        /// update at any given time. The update starts by stopping at most 30%
        /// of those DaemonSet pods and then brings up new DaemonSet pods in
        /// their place. Once the new pods are available, it then proceeds onto
        /// other DaemonSet pods, thus ensuring that at least 70% of original
        /// number of DaemonSet pods are available at all times during the
        /// update.</param>
        public Iok8sapiextensionsv1beta1RollingUpdateDaemonSet(string maxUnavailable = default(string))
        {
            MaxUnavailable = maxUnavailable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the maximum number of DaemonSet pods that can be
        /// unavailable during the update. Value can be an absolute number (ex:
        /// 5) or a percentage of total number of DaemonSet pods at the start
        /// of the update (ex: 10%). Absolute number is calculated from
        /// percentage by rounding up. This cannot be 0. Default value is 1.
        /// Example: when this is set to 30%, at most 30% of the total number
        /// of nodes that should be running the daemon pod (i.e.
        /// status.desiredNumberScheduled) can have their pods stopped for an
        /// update at any given time. The update starts by stopping at most 30%
        /// of those DaemonSet pods and then brings up new DaemonSet pods in
        /// their place. Once the new pods are available, it then proceeds onto
        /// other DaemonSet pods, thus ensuring that at least 70% of original
        /// number of DaemonSet pods are available at all times during the
        /// update.
        /// </summary>
        [JsonProperty(PropertyName = "maxUnavailable")]
        public string MaxUnavailable { get; set; }

    }
}
