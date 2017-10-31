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
    /// current status of a horizontal pod autoscaler
    /// </summary>
    public partial class Iok8sapiautoscalingv1HorizontalPodAutoscalerStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiautoscalingv1HorizontalPodAutoscalerStatus class.
        /// </summary>
        public Iok8sapiautoscalingv1HorizontalPodAutoscalerStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiautoscalingv1HorizontalPodAutoscalerStatus class.
        /// </summary>
        /// <param name="currentReplicas">current number of replicas of pods
        /// managed by this autoscaler.</param>
        /// <param name="desiredReplicas">desired number of replicas of pods
        /// managed by this autoscaler.</param>
        /// <param name="currentCPUUtilizationPercentage">current average CPU
        /// utilization over all pods, represented as a percentage of requested
        /// CPU, e.g. 70 means that an average pod is using now 70% of its
        /// requested CPU.</param>
        /// <param name="lastScaleTime">last time the HorizontalPodAutoscaler
        /// scaled the number of pods; used by the autoscaler to control how
        /// often the number of pods is changed.</param>
        /// <param name="observedGeneration">most recent generation observed by
        /// this autoscaler.</param>
        public Iok8sapiautoscalingv1HorizontalPodAutoscalerStatus(int currentReplicas, int desiredReplicas, int? currentCPUUtilizationPercentage = default(int?), System.DateTime? lastScaleTime = default(System.DateTime?), long? observedGeneration = default(long?))
        {
            CurrentCPUUtilizationPercentage = currentCPUUtilizationPercentage;
            CurrentReplicas = currentReplicas;
            DesiredReplicas = desiredReplicas;
            LastScaleTime = lastScaleTime;
            ObservedGeneration = observedGeneration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets current average CPU utilization over all pods,
        /// represented as a percentage of requested CPU, e.g. 70 means that an
        /// average pod is using now 70% of its requested CPU.
        /// </summary>
        [JsonProperty(PropertyName = "currentCPUUtilizationPercentage")]
        public int? CurrentCPUUtilizationPercentage { get; set; }

        /// <summary>
        /// Gets or sets current number of replicas of pods managed by this
        /// autoscaler.
        /// </summary>
        [JsonProperty(PropertyName = "currentReplicas")]
        public int CurrentReplicas { get; set; }

        /// <summary>
        /// Gets or sets desired number of replicas of pods managed by this
        /// autoscaler.
        /// </summary>
        [JsonProperty(PropertyName = "desiredReplicas")]
        public int DesiredReplicas { get; set; }

        /// <summary>
        /// Gets or sets last time the HorizontalPodAutoscaler scaled the
        /// number of pods; used by the autoscaler to control how often the
        /// number of pods is changed.
        /// </summary>
        [JsonProperty(PropertyName = "lastScaleTime")]
        public System.DateTime? LastScaleTime { get; set; }

        /// <summary>
        /// Gets or sets most recent generation observed by this autoscaler.
        /// </summary>
        [JsonProperty(PropertyName = "observedGeneration")]
        public long? ObservedGeneration { get; set; }

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
