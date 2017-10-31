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
    /// EventSource contains information for an event.
    /// </summary>
    public partial class Iok8sapicorev1EventSource
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1EventSource class.
        /// </summary>
        public Iok8sapicorev1EventSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1EventSource class.
        /// </summary>
        /// <param name="component">Component from which the event is
        /// generated.</param>
        /// <param name="host">Node name on which the event is
        /// generated.</param>
        public Iok8sapicorev1EventSource(string component = default(string), string host = default(string))
        {
            Component = component;
            Host = host;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets component from which the event is generated.
        /// </summary>
        [JsonProperty(PropertyName = "component")]
        public string Component { get; set; }

        /// <summary>
        /// Gets or sets node name on which the event is generated.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }

    }
}
