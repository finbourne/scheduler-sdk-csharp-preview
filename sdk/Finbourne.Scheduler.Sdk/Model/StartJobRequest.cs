/*
 * FINBOURNE Scheduler API
 *
 *  Scheduler is a job automation tool for LUSID. You can write code to perform operations, create jobs with container images, and schedule them to run automatically.  ### Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"152\">152</a>|Action Execution Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"704\">704</a>|Cannot Delete Job|  | | <a name=\"731\">731</a>|Unable to process images associated with request.|  | | <a name=\"756\">756</a>|Image Scan Failure|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | 
 *
 * The version of the OpenAPI document: 0.0.944
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Scheduler.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Scheduler.Sdk.Model
{
    /// <summary>
    /// Job start definition
    /// </summary>
    [DataContract(Name = "StartJobRequest")]
    public partial class StartJobRequest : IEquatable<StartJobRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartJobRequest" /> class.
        /// </summary>
        /// <param name="arguments">All arguments needed for the Job to run.</param>
        /// <param name="notifications">Notifications for this Job.</param>
        /// <param name="useAsAuth">Id of user associated with schedule. All calls to FINBOURNE services  as part of execution of this schedule will be authenticated as this   user. Can be null, in which case we&#39;ll default to that of the user   making this request.</param>
        public StartJobRequest(Dictionary<string, string> arguments = default(Dictionary<string, string>), List<Notification> notifications = default(List<Notification>), string useAsAuth = default(string))
        {
            this.Arguments = arguments;
            this.Notifications = notifications;
            this.UseAsAuth = useAsAuth;
        }

        /// <summary>
        /// All arguments needed for the Job to run
        /// </summary>
        /// <value>All arguments needed for the Job to run</value>
        [DataMember(Name = "arguments", EmitDefaultValue = true)]
        public Dictionary<string, string> Arguments { get; set; }

        /// <summary>
        /// Notifications for this Job
        /// </summary>
        /// <value>Notifications for this Job</value>
        [DataMember(Name = "notifications", EmitDefaultValue = true)]
        public List<Notification> Notifications { get; set; }

        /// <summary>
        /// Id of user associated with schedule. All calls to FINBOURNE services  as part of execution of this schedule will be authenticated as this   user. Can be null, in which case we&#39;ll default to that of the user   making this request
        /// </summary>
        /// <value>Id of user associated with schedule. All calls to FINBOURNE services  as part of execution of this schedule will be authenticated as this   user. Can be null, in which case we&#39;ll default to that of the user   making this request</value>
        [DataMember(Name = "useAsAuth", EmitDefaultValue = true)]
        public string UseAsAuth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartJobRequest {\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
            sb.Append("  Notifications: ").Append(Notifications).Append("\n");
            sb.Append("  UseAsAuth: ").Append(UseAsAuth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartJobRequest);
        }

        /// <summary>
        /// Returns true if StartJobRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StartJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartJobRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Arguments == input.Arguments ||
                    this.Arguments != null &&
                    input.Arguments != null &&
                    this.Arguments.SequenceEqual(input.Arguments)
                ) && 
                (
                    this.Notifications == input.Notifications ||
                    this.Notifications != null &&
                    input.Notifications != null &&
                    this.Notifications.SequenceEqual(input.Notifications)
                ) && 
                (
                    this.UseAsAuth == input.UseAsAuth ||
                    (this.UseAsAuth != null &&
                    this.UseAsAuth.Equals(input.UseAsAuth))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.Notifications != null)
                    hashCode = hashCode * 59 + this.Notifications.GetHashCode();
                if (this.UseAsAuth != null)
                    hashCode = hashCode * 59 + this.UseAsAuth.GetHashCode();
                return hashCode;
            }
        }

    }
}
