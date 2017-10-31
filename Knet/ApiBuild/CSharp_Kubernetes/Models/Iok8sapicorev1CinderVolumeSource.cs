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
    /// Represents a cinder volume resource in Openstack. A Cinder volume must
    /// exist before mounting to a container. The volume must also be in the
    /// same region as the kubelet. Cinder volumes support ownership management
    /// and SELinux relabeling.
    /// </summary>
    public partial class Iok8sapicorev1CinderVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1CinderVolumeSource
        /// class.
        /// </summary>
        public Iok8sapicorev1CinderVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1CinderVolumeSource
        /// class.
        /// </summary>
        /// <param name="volumeID">volume id used to identify the volume in
        /// cinder More info:
        /// https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</param>
        /// <param name="fsType">Filesystem type to mount. Must be a filesystem
        /// type supported by the host operating system. Examples: "ext4",
        /// "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        /// More info:
        /// https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</param>
        /// <param name="readOnlyProperty">Optional: Defaults to false
        /// (read/write). ReadOnly here will force the ReadOnly setting in
        /// VolumeMounts. More info:
        /// https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</param>
        public Iok8sapicorev1CinderVolumeSource(string volumeID, string fsType = default(string), bool? readOnlyProperty = default(bool?))
        {
            FsType = fsType;
            ReadOnlyProperty = readOnlyProperty;
            VolumeID = volumeID;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets filesystem type to mount. Must be a filesystem type
        /// supported by the host operating system. Examples: "ext4", "xfs",
        /// "ntfs". Implicitly inferred to be "ext4" if unspecified. More info:
        /// https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
        /// </summary>
        [JsonProperty(PropertyName = "fsType")]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or sets optional: Defaults to false (read/write). ReadOnly
        /// here will force the ReadOnly setting in VolumeMounts. More info:
        /// https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Gets or sets volume id used to identify the volume in cinder More
        /// info:
        /// https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
        /// </summary>
        [JsonProperty(PropertyName = "volumeID")]
        public string VolumeID { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VolumeID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VolumeID");
            }
        }
    }
}
