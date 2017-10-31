// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace KuberentesService.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ContainerStatus contains details for the current status of this
    /// container.
    /// </summary>
    public partial class Iok8sapicorev1ContainerStatus
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1ContainerStatus
        /// class.
        /// </summary>
        public Iok8sapicorev1ContainerStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1ContainerStatus
        /// class.
        /// </summary>
        /// <param name="image">The image the container is running. More info:
        /// https://kubernetes.io/docs/concepts/containers/images</param>
        /// <param name="imageID">ImageID of the container's image.</param>
        /// <param name="name">This must be a DNS_LABEL. Each container in a
        /// pod must have a unique name. Cannot be updated.</param>
        /// <param name="ready">Specifies whether the container has passed its
        /// readiness probe.</param>
        /// <param name="restartCount">The number of times the container has
        /// been restarted, currently based on the number of dead containers
        /// that have not yet been removed. Note that this is calculated from
        /// dead containers. But those containers are subject to garbage
        /// collection. This value will get capped at 5 by GC.</param>
        /// <param name="containerID">Container's ID in the format
        /// 'docker://&lt;container_id&gt;'.</param>
        /// <param name="lastState">Details about the container's last
        /// termination condition.</param>
        /// <param name="state">Details about the container's current
        /// condition.</param>
        public Iok8sapicorev1ContainerStatus(string image, string imageID, string name, bool ready, int restartCount, string containerID = default(string), Iok8sapicorev1ContainerState lastState = default(Iok8sapicorev1ContainerState), Iok8sapicorev1ContainerState state = default(Iok8sapicorev1ContainerState))
        {
            ContainerID = containerID;
            Image = image;
            ImageID = imageID;
            LastState = lastState;
            Name = name;
            Ready = ready;
            RestartCount = restartCount;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets container's ID in the format
        /// 'docker://&amp;lt;container_id&amp;gt;'.
        /// </summary>
        [JsonProperty(PropertyName = "containerID")]
        public string ContainerID { get; set; }

        /// <summary>
        /// Gets or sets the image the container is running. More info:
        /// https://kubernetes.io/docs/concepts/containers/images
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets imageID of the container's image.
        /// </summary>
        [JsonProperty(PropertyName = "imageID")]
        public string ImageID { get; set; }

        /// <summary>
        /// Gets or sets details about the container's last termination
        /// condition.
        /// </summary>
        [JsonProperty(PropertyName = "lastState")]
        public Iok8sapicorev1ContainerState LastState { get; set; }

        /// <summary>
        /// Gets or sets this must be a DNS_LABEL. Each container in a pod must
        /// have a unique name. Cannot be updated.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the container has passed its
        /// readiness probe.
        /// </summary>
        [JsonProperty(PropertyName = "ready")]
        public bool Ready { get; set; }

        /// <summary>
        /// Gets or sets the number of times the container has been restarted,
        /// currently based on the number of dead containers that have not yet
        /// been removed. Note that this is calculated from dead containers.
        /// But those containers are subject to garbage collection. This value
        /// will get capped at 5 by GC.
        /// </summary>
        [JsonProperty(PropertyName = "restartCount")]
        public int RestartCount { get; set; }

        /// <summary>
        /// Gets or sets details about the container's current condition.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public Iok8sapicorev1ContainerState State { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Image == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Image");
            }
            if (ImageID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ImageID");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (LastState != null)
            {
                LastState.Validate();
            }
            if (State != null)
            {
                State.Validate();
            }
        }
    }
}
