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
    /// ContainerStateTerminated is a terminated state of a container.
    /// </summary>
    public partial class Iok8sapicorev1ContainerStateTerminated
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1ContainerStateTerminated class.
        /// </summary>
        public Iok8sapicorev1ContainerStateTerminated()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1ContainerStateTerminated class.
        /// </summary>
        /// <param name="exitCode">Exit status from the last termination of the
        /// container</param>
        /// <param name="containerID">Container's ID in the format
        /// 'docker://&lt;container_id&gt;'</param>
        /// <param name="finishedAt">Time at which the container last
        /// terminated</param>
        /// <param name="message">Message regarding the last termination of the
        /// container</param>
        /// <param name="reason">(brief) reason from the last termination of
        /// the container</param>
        /// <param name="signal">Signal from the last termination of the
        /// container</param>
        /// <param name="startedAt">Time at which previous execution of the
        /// container started</param>
        public Iok8sapicorev1ContainerStateTerminated(int exitCode, string containerID = default(string), System.DateTime? finishedAt = default(System.DateTime?), string message = default(string), string reason = default(string), int? signal = default(int?), System.DateTime? startedAt = default(System.DateTime?))
        {
            ContainerID = containerID;
            ExitCode = exitCode;
            FinishedAt = finishedAt;
            Message = message;
            Reason = reason;
            Signal = signal;
            StartedAt = startedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets container's ID in the format
        /// 'docker://&amp;lt;container_id&amp;gt;'
        /// </summary>
        [JsonProperty(PropertyName = "containerID")]
        public string ContainerID { get; set; }

        /// <summary>
        /// Gets or sets exit status from the last termination of the container
        /// </summary>
        [JsonProperty(PropertyName = "exitCode")]
        public int ExitCode { get; set; }

        /// <summary>
        /// Gets or sets time at which the container last terminated
        /// </summary>
        [JsonProperty(PropertyName = "finishedAt")]
        public System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Gets or sets message regarding the last termination of the
        /// container
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets (brief) reason from the last termination of the
        /// container
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets signal from the last termination of the container
        /// </summary>
        [JsonProperty(PropertyName = "signal")]
        public int? Signal { get; set; }

        /// <summary>
        /// Gets or sets time at which previous execution of the container
        /// started
        /// </summary>
        [JsonProperty(PropertyName = "startedAt")]
        public System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
