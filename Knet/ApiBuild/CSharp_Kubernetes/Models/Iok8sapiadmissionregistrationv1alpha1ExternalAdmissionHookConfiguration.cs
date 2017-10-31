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
    /// ExternalAdmissionHookConfiguration describes the configuration of
    /// initializers.
    /// </summary>
    public partial class Iok8sapiadmissionregistrationv1alpha1ExternalAdmissionHookConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiadmissionregistrationv1alpha1ExternalAdmissionHookConfiguration
        /// class.
        /// </summary>
        public Iok8sapiadmissionregistrationv1alpha1ExternalAdmissionHookConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiadmissionregistrationv1alpha1ExternalAdmissionHookConfiguration
        /// class.
        /// </summary>
        /// <param name="apiVersion">APIVersion defines the versioned schema of
        /// this representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</param>
        /// <param name="externalAdmissionHooks">ExternalAdmissionHooks is a
        /// list of external admission webhooks and the affected resources and
        /// operations.</param>
        /// <param name="kind">Kind is a string value representing the REST
        /// resource this object represents. Servers may infer this from the
        /// endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</param>
        /// <param name="metadata">Standard object metadata; More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata.</param>
        public Iok8sapiadmissionregistrationv1alpha1ExternalAdmissionHookConfiguration(string apiVersion = default(string), IList<Iok8sapiadmissionregistrationv1alpha1ExternalAdmissionHook> externalAdmissionHooks = default(IList<Iok8sapiadmissionregistrationv1alpha1ExternalAdmissionHook>), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta))
        {
            ApiVersion = apiVersion;
            ExternalAdmissionHooks = externalAdmissionHooks;
            Kind = kind;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIVersion defines the versioned schema of this
        /// representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets externalAdmissionHooks is a list of external admission
        /// webhooks and the affected resources and operations.
        /// </summary>
        [JsonProperty(PropertyName = "externalAdmissionHooks")]
        public IList<Iok8sapiadmissionregistrationv1alpha1ExternalAdmissionHook> ExternalAdmissionHooks { get; set; }

        /// <summary>
        /// Gets or sets kind is a string value representing the REST resource
        /// this object represents. Servers may infer this from the endpoint
        /// the client submits requests to. Cannot be updated. In CamelCase.
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets standard object metadata; More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ExternalAdmissionHooks != null)
            {
                foreach (var element in ExternalAdmissionHooks)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Metadata != null)
            {
                Metadata.Validate();
            }
        }
    }
}
