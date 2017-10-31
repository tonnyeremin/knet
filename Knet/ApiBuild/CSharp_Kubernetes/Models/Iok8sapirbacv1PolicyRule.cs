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
    /// PolicyRule holds information that describes a policy rule, but does not
    /// contain information about who the rule applies to or which namespace
    /// the rule applies to.
    /// </summary>
    public partial class Iok8sapirbacv1PolicyRule
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapirbacv1PolicyRule class.
        /// </summary>
        public Iok8sapirbacv1PolicyRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Iok8sapirbacv1PolicyRule class.
        /// </summary>
        /// <param name="verbs">Verbs is a list of Verbs that apply to ALL the
        /// ResourceKinds and AttributeRestrictions contained in this rule.
        /// VerbAll represents all kinds.</param>
        /// <param name="apiGroups">APIGroups is the name of the APIGroup that
        /// contains the resources.  If multiple API groups are specified, any
        /// action requested against one of the enumerated resources in any API
        /// group will be allowed.</param>
        /// <param name="nonResourceURLs">NonResourceURLs is a set of partial
        /// urls that a user should have access to.  *s are allowed, but only
        /// as the full, final step in the path Since non-resource URLs are not
        /// namespaced, this field is only applicable for ClusterRoles
        /// referenced from a ClusterRoleBinding. Rules can either apply to API
        /// resources (such as "pods" or "secrets") or non-resource URL paths
        /// (such as "/api"),  but not both.</param>
        /// <param name="resourceNames">ResourceNames is an optional white list
        /// of names that the rule applies to.  An empty set means that
        /// everything is allowed.</param>
        /// <param name="resources">Resources is a list of resources this rule
        /// applies to.  ResourceAll represents all resources.</param>
        public Iok8sapirbacv1PolicyRule(IList<string> verbs, IList<string> apiGroups = default(IList<string>), IList<string> nonResourceURLs = default(IList<string>), IList<string> resourceNames = default(IList<string>), IList<string> resources = default(IList<string>))
        {
            ApiGroups = apiGroups;
            NonResourceURLs = nonResourceURLs;
            ResourceNames = resourceNames;
            Resources = resources;
            Verbs = verbs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIGroups is the name of the APIGroup that contains
        /// the resources.  If multiple API groups are specified, any action
        /// requested against one of the enumerated resources in any API group
        /// will be allowed.
        /// </summary>
        [JsonProperty(PropertyName = "apiGroups")]
        public IList<string> ApiGroups { get; set; }

        /// <summary>
        /// Gets or sets nonResourceURLs is a set of partial urls that a user
        /// should have access to.  *s are allowed, but only as the full, final
        /// step in the path Since non-resource URLs are not namespaced, this
        /// field is only applicable for ClusterRoles referenced from a
        /// ClusterRoleBinding. Rules can either apply to API resources (such
        /// as "pods" or "secrets") or non-resource URL paths (such as "/api"),
        /// but not both.
        /// </summary>
        [JsonProperty(PropertyName = "nonResourceURLs")]
        public IList<string> NonResourceURLs { get; set; }

        /// <summary>
        /// Gets or sets resourceNames is an optional white list of names that
        /// the rule applies to.  An empty set means that everything is
        /// allowed.
        /// </summary>
        [JsonProperty(PropertyName = "resourceNames")]
        public IList<string> ResourceNames { get; set; }

        /// <summary>
        /// Gets or sets resources is a list of resources this rule applies to.
        /// ResourceAll represents all resources.
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<string> Resources { get; set; }

        /// <summary>
        /// Gets or sets verbs is a list of Verbs that apply to ALL the
        /// ResourceKinds and AttributeRestrictions contained in this rule.
        /// VerbAll represents all kinds.
        /// </summary>
        [JsonProperty(PropertyName = "verbs")]
        public IList<string> Verbs { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Verbs == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Verbs");
            }
        }
    }
}
