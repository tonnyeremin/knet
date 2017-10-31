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
    /// DeploymentSpec is the specification of the desired behavior of the
    /// Deployment.
    /// </summary>
    public partial class Iok8sapiappsv1beta2DeploymentSpec
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapiappsv1beta2DeploymentSpec
        /// class.
        /// </summary>
        public Iok8sapiappsv1beta2DeploymentSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Iok8sapiappsv1beta2DeploymentSpec
        /// class.
        /// </summary>
        /// <param name="template">Template describes the pods that will be
        /// created.</param>
        /// <param name="minReadySeconds">Minimum number of seconds for which a
        /// newly created pod should be ready without any of its container
        /// crashing, for it to be considered available. Defaults to 0 (pod
        /// will be considered available as soon as it is ready)</param>
        /// <param name="paused">Indicates that the deployment is
        /// paused.</param>
        /// <param name="progressDeadlineSeconds">The maximum time in seconds
        /// for a deployment to make progress before it is considered to be
        /// failed. The deployment controller will continue to process failed
        /// deployments and a condition with a ProgressDeadlineExceeded reason
        /// will be surfaced in the deployment status. Note that progress will
        /// not be estimated during the time a deployment is paused. Defaults
        /// to 600s.</param>
        /// <param name="replicas">Number of desired pods. This is a pointer to
        /// distinguish between explicit zero and not specified. Defaults to
        /// 1.</param>
        /// <param name="revisionHistoryLimit">The number of old ReplicaSets to
        /// retain to allow rollback. This is a pointer to distinguish between
        /// explicit zero and not specified. Defaults to 10.</param>
        /// <param name="selector">Label selector for pods. Existing
        /// ReplicaSets whose pods are selected by this will be the ones
        /// affected by this deployment.</param>
        /// <param name="strategy">The deployment strategy to use to replace
        /// existing pods with new ones.</param>
        public Iok8sapiappsv1beta2DeploymentSpec(Iok8sapicorev1PodTemplateSpec template, int? minReadySeconds = default(int?), bool? paused = default(bool?), int? progressDeadlineSeconds = default(int?), int? replicas = default(int?), int? revisionHistoryLimit = default(int?), Iok8sapimachinerypkgapismetav1LabelSelector selector = default(Iok8sapimachinerypkgapismetav1LabelSelector), Iok8sapiappsv1beta2DeploymentStrategy strategy = default(Iok8sapiappsv1beta2DeploymentStrategy))
        {
            MinReadySeconds = minReadySeconds;
            Paused = paused;
            ProgressDeadlineSeconds = progressDeadlineSeconds;
            Replicas = replicas;
            RevisionHistoryLimit = revisionHistoryLimit;
            Selector = selector;
            Strategy = strategy;
            Template = template;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets minimum number of seconds for which a newly created
        /// pod should be ready without any of its container crashing, for it
        /// to be considered available. Defaults to 0 (pod will be considered
        /// available as soon as it is ready)
        /// </summary>
        [JsonProperty(PropertyName = "minReadySeconds")]
        public int? MinReadySeconds { get; set; }

        /// <summary>
        /// Gets or sets indicates that the deployment is paused.
        /// </summary>
        [JsonProperty(PropertyName = "paused")]
        public bool? Paused { get; set; }

        /// <summary>
        /// Gets or sets the maximum time in seconds for a deployment to make
        /// progress before it is considered to be failed. The deployment
        /// controller will continue to process failed deployments and a
        /// condition with a ProgressDeadlineExceeded reason will be surfaced
        /// in the deployment status. Note that progress will not be estimated
        /// during the time a deployment is paused. Defaults to 600s.
        /// </summary>
        [JsonProperty(PropertyName = "progressDeadlineSeconds")]
        public int? ProgressDeadlineSeconds { get; set; }

        /// <summary>
        /// Gets or sets number of desired pods. This is a pointer to
        /// distinguish between explicit zero and not specified. Defaults to 1.
        /// </summary>
        [JsonProperty(PropertyName = "replicas")]
        public int? Replicas { get; set; }

        /// <summary>
        /// Gets or sets the number of old ReplicaSets to retain to allow
        /// rollback. This is a pointer to distinguish between explicit zero
        /// and not specified. Defaults to 10.
        /// </summary>
        [JsonProperty(PropertyName = "revisionHistoryLimit")]
        public int? RevisionHistoryLimit { get; set; }

        /// <summary>
        /// Gets or sets label selector for pods. Existing ReplicaSets whose
        /// pods are selected by this will be the ones affected by this
        /// deployment.
        /// </summary>
        [JsonProperty(PropertyName = "selector")]
        public Iok8sapimachinerypkgapismetav1LabelSelector Selector { get; set; }

        /// <summary>
        /// Gets or sets the deployment strategy to use to replace existing
        /// pods with new ones.
        /// </summary>
        [JsonProperty(PropertyName = "strategy")]
        public Iok8sapiappsv1beta2DeploymentStrategy Strategy { get; set; }

        /// <summary>
        /// Gets or sets template describes the pods that will be created.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public Iok8sapicorev1PodTemplateSpec Template { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Template == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Template");
            }
            if (Template != null)
            {
                Template.Validate();
            }
        }
    }
}
