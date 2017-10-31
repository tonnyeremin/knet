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
    /// ExecAction describes a "run in container" action.
    /// </summary>
    public partial class Iok8sapicorev1ExecAction
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1ExecAction class.
        /// </summary>
        public Iok8sapicorev1ExecAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1ExecAction class.
        /// </summary>
        /// <param name="command">Command is the command line to execute inside
        /// the container, the working directory for the command  is root ('/')
        /// in the container's filesystem. The command is simply exec'd, it is
        /// not run inside a shell, so traditional shell instructions ('|',
        /// etc) won't work. To use a shell, you need to explicitly call out to
        /// that shell. Exit status of 0 is treated as live/healthy and
        /// non-zero is unhealthy.</param>
        public Iok8sapicorev1ExecAction(IList<string> command = default(IList<string>))
        {
            Command = command;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets command is the command line to execute inside the
        /// container, the working directory for the command  is root ('/') in
        /// the container's filesystem. The command is simply exec'd, it is not
        /// run inside a shell, so traditional shell instructions ('|', etc)
        /// won't work. To use a shell, you need to explicitly call out to that
        /// shell. Exit status of 0 is treated as live/healthy and non-zero is
        /// unhealthy.
        /// </summary>
        [JsonProperty(PropertyName = "command")]
        public IList<string> Command { get; set; }

    }
}
