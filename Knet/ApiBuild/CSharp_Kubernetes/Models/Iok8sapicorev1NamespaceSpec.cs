// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace KuberentesService.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// NamespaceSpec describes the attributes on a Namespace.
    /// </summary>
    public partial class Iok8sapicorev1NamespaceSpec
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1NamespaceSpec
        /// class.
        /// </summary>
        public Iok8sapicorev1NamespaceSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1NamespaceSpec
        /// class.
        /// </summary>
        /// <param name="finalizers">Finalizers is an opaque list of values
        /// that must be empty to permanently remove object from storage. More
        /// info:
        /// https://kubernetes.io/docs/tasks/administer-cluster/namespaces/</param>
        public Iok8sapicorev1NamespaceSpec(IList<string> finalizers = default(IList<string>))
        {
            Finalizers = finalizers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets finalizers is an opaque list of values that must be
        /// empty to permanently remove object from storage. More info:
        /// https://kubernetes.io/docs/tasks/administer-cluster/namespaces/
        /// </summary>
        [JsonProperty(PropertyName = "finalizers")]
        public IList<string> Finalizers { get; set; }

    }
}
