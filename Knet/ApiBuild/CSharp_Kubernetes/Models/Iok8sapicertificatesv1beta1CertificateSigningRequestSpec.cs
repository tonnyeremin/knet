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
    /// This information is immutable after the request is created. Only the
    /// Request and Usages fields can be set on creation, other fields are
    /// derived by Kubernetes and cannot be modified by users.
    /// </summary>
    public partial class Iok8sapicertificatesv1beta1CertificateSigningRequestSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicertificatesv1beta1CertificateSigningRequestSpec class.
        /// </summary>
        public Iok8sapicertificatesv1beta1CertificateSigningRequestSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicertificatesv1beta1CertificateSigningRequestSpec class.
        /// </summary>
        /// <param name="request">Base64-encoded PKCS#10 CSR data</param>
        /// <param name="extra">Extra information about the requesting user.
        /// See user.Info interface for details.</param>
        /// <param name="groups">Group information about the requesting user.
        /// See user.Info interface for details.</param>
        /// <param name="uid">UID information about the requesting user. See
        /// user.Info interface for details.</param>
        /// <param name="usages">allowedUsages specifies a set of usage
        /// contexts the key will be valid for. See:
        /// https://tools.ietf.org/html/rfc5280#section-4.2.1.3
        /// https://tools.ietf.org/html/rfc5280#section-4.2.1.12</param>
        /// <param name="username">Information about the requesting user. See
        /// user.Info interface for details.</param>
        public Iok8sapicertificatesv1beta1CertificateSigningRequestSpec(byte[] request, IDictionary<string, IList<string>> extra = default(IDictionary<string, IList<string>>), IList<string> groups = default(IList<string>), string uid = default(string), IList<string> usages = default(IList<string>), string username = default(string))
        {
            Extra = extra;
            Groups = groups;
            Request = request;
            Uid = uid;
            Usages = usages;
            Username = username;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets extra information about the requesting user. See
        /// user.Info interface for details.
        /// </summary>
        [JsonProperty(PropertyName = "extra")]
        public IDictionary<string, IList<string>> Extra { get; set; }

        /// <summary>
        /// Gets or sets group information about the requesting user. See
        /// user.Info interface for details.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<string> Groups { get; set; }

        /// <summary>
        /// Gets or sets base64-encoded PKCS#10 CSR data
        /// </summary>
        [JsonProperty(PropertyName = "request")]
        public byte[] Request { get; set; }

        /// <summary>
        /// Gets or sets UID information about the requesting user. See
        /// user.Info interface for details.
        /// </summary>
        [JsonProperty(PropertyName = "uid")]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets allowedUsages specifies a set of usage contexts the
        /// key will be valid for. See:
        /// https://tools.ietf.org/html/rfc5280#section-4.2.1.3
        /// https://tools.ietf.org/html/rfc5280#section-4.2.1.12
        /// </summary>
        [JsonProperty(PropertyName = "usages")]
        public IList<string> Usages { get; set; }

        /// <summary>
        /// Gets or sets information about the requesting user. See user.Info
        /// interface for details.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Request == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Request");
            }
        }
    }
}
