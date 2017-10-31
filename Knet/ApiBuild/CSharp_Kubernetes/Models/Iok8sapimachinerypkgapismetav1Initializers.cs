// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace KuberentesService.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Initializers tracks the progress of initialization.
    /// </summary>
    public partial class Iok8sapimachinerypkgapismetav1Initializers
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapimachinerypkgapismetav1Initializers class.
        /// </summary>
        public Iok8sapimachinerypkgapismetav1Initializers()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapimachinerypkgapismetav1Initializers class.
        /// </summary>
        /// <param name="pending">Pending is a list of initializers that must
        /// execute in order before this object is visible. When the last
        /// pending initializer is removed, and no failing result is set, the
        /// initializers struct will be set to nil and the object is considered
        /// as initialized and visible to all clients.</param>
        /// <param name="result">If result is set with the Failure field, the
        /// object will be persisted to storage and then deleted, ensuring that
        /// other clients can observe the deletion.</param>
        public Iok8sapimachinerypkgapismetav1Initializers(IList<Iok8sapimachinerypkgapismetav1Initializer> pending, Iok8sapimachinerypkgapismetav1Status result = default(Iok8sapimachinerypkgapismetav1Status))
        {
            Pending = pending;
            Result = result;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets pending is a list of initializers that must execute in
        /// order before this object is visible. When the last pending
        /// initializer is removed, and no failing result is set, the
        /// initializers struct will be set to nil and the object is considered
        /// as initialized and visible to all clients.
        /// </summary>
        [JsonProperty(PropertyName = "pending")]
        public IList<Iok8sapimachinerypkgapismetav1Initializer> Pending { get; set; }

        /// <summary>
        /// Gets or sets if result is set with the Failure field, the object
        /// will be persisted to storage and then deleted, ensuring that other
        /// clients can observe the deletion.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public Iok8sapimachinerypkgapismetav1Status Result { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Pending == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Pending");
            }
            if (Pending != null)
            {
                foreach (var element in Pending)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}