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
    /// RoleRef contains information that points to the role being used
    /// </summary>
    public partial class Iok8sapirbacv1beta1RoleRef
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapirbacv1beta1RoleRef class.
        /// </summary>
        public Iok8sapirbacv1beta1RoleRef()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Iok8sapirbacv1beta1RoleRef class.
        /// </summary>
        /// <param name="apiGroup">APIGroup is the group for the resource being
        /// referenced</param>
        /// <param name="kind">Kind is the type of resource being
        /// referenced</param>
        /// <param name="name">Name is the name of resource being
        /// referenced</param>
        public Iok8sapirbacv1beta1RoleRef(string apiGroup, string kind, string name)
        {
            ApiGroup = apiGroup;
            Kind = kind;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIGroup is the group for the resource being
        /// referenced
        /// </summary>
        [JsonProperty(PropertyName = "apiGroup")]
        public string ApiGroup { get; set; }

        /// <summary>
        /// Gets or sets kind is the type of resource being referenced
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets name is the name of resource being referenced
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ApiGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApiGroup");
            }
            if (Kind == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Kind");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
