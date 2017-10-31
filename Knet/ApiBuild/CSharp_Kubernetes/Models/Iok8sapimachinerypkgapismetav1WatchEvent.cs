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
    /// Event represents a single event to a watched resource.
    /// </summary>
    public partial class Iok8sapimachinerypkgapismetav1WatchEvent
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapimachinerypkgapismetav1WatchEvent class.
        /// </summary>
        public Iok8sapimachinerypkgapismetav1WatchEvent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapimachinerypkgapismetav1WatchEvent class.
        /// </summary>
        /// <param name="objectProperty">Object is:
        /// * If Type is Added or Modified: the new state of the object.
        /// * If Type is Deleted: the state of the object immediately before
        /// deletion.
        /// * If Type is Error: *Status is recommended; other types may make
        /// sense
        /// depending on context.</param>
        public Iok8sapimachinerypkgapismetav1WatchEvent(Iok8sapimachinerypkgruntimeRawExtension objectProperty, string type)
        {
            ObjectProperty = objectProperty;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets object is:
        /// * If Type is Added or Modified: the new state of the object.
        /// * If Type is Deleted: the state of the object immediately before
        /// deletion.
        /// * If Type is Error: *Status is recommended; other types may make
        /// sense
        /// depending on context.
        /// </summary>
        [JsonProperty(PropertyName = "object")]
        public Iok8sapimachinerypkgruntimeRawExtension ObjectProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ObjectProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ObjectProperty");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
            if (ObjectProperty != null)
            {
                ObjectProperty.Validate();
            }
        }
    }
}