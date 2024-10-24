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
    /// Create a schedule definition
    /// </summary>
    [DataContract(Name = "UpdateScheduleRequest")]
    public partial class UpdateScheduleRequest : IEquatable<UpdateScheduleRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateScheduleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateScheduleRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateScheduleRequest" /> class.
        /// </summary>
        /// <param name="jobId">jobId (required).</param>
        /// <param name="name">The updated name of the schedule (required).</param>
        /// <param name="description">The updated description of the schedule (required).</param>
        /// <param name="author">The updated author of the schedule.</param>
        /// <param name="owner">The update owner of the schedule.</param>
        /// <param name="arguments">Updated arguments to be passed to the job  Note: The new arguments will completely replace old arguments.</param>
        /// <param name="trigger">trigger.</param>
        /// <param name="notifications">Updated notifications for this schedule.</param>
        /// <param name="enabled">Specify whether schedule is enabled or not  Defaults to true.</param>
        /// <param name="useAsAuth">Id of user associated with schedule. All calls to FINBOURNE services  as part of execution of this schedule will be authenticated as this   user. Can be null, in which case we&#39;ll default to that of the user   making this request.</param>
        public UpdateScheduleRequest(ResourceId jobId = default(ResourceId), string name = default(string), string description = default(string), string author = default(string), string owner = default(string), Dictionary<string, string> arguments = default(Dictionary<string, string>), Trigger trigger = default(Trigger), List<Notification> notifications = default(List<Notification>), bool enabled = default(bool), string useAsAuth = default(string))
        {
            // to ensure "jobId" is required (not null)
            this.JobId = jobId ?? throw new ArgumentNullException("jobId is a required property for UpdateScheduleRequest and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for UpdateScheduleRequest and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for UpdateScheduleRequest and cannot be null");
            this.Author = author;
            this.Owner = owner;
            this.Arguments = arguments;
            this.Trigger = trigger;
            this.Notifications = notifications;
            this.Enabled = enabled;
            this.UseAsAuth = useAsAuth;
        }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId JobId { get; set; }

        /// <summary>
        /// The updated name of the schedule
        /// </summary>
        /// <value>The updated name of the schedule</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The updated description of the schedule
        /// </summary>
        /// <value>The updated description of the schedule</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The updated author of the schedule
        /// </summary>
        /// <value>The updated author of the schedule</value>
        [DataMember(Name = "author", EmitDefaultValue = true)]
        public string Author { get; set; }

        /// <summary>
        /// The update owner of the schedule
        /// </summary>
        /// <value>The update owner of the schedule</value>
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public string Owner { get; set; }

        /// <summary>
        /// Updated arguments to be passed to the job  Note: The new arguments will completely replace old arguments
        /// </summary>
        /// <value>Updated arguments to be passed to the job  Note: The new arguments will completely replace old arguments</value>
        [DataMember(Name = "arguments", EmitDefaultValue = true)]
        public Dictionary<string, string> Arguments { get; set; }

        /// <summary>
        /// Gets or Sets Trigger
        /// </summary>
        [DataMember(Name = "trigger", EmitDefaultValue = false)]
        public Trigger Trigger { get; set; }

        /// <summary>
        /// Updated notifications for this schedule
        /// </summary>
        /// <value>Updated notifications for this schedule</value>
        [DataMember(Name = "notifications", EmitDefaultValue = true)]
        public List<Notification> Notifications { get; set; }

        /// <summary>
        /// Specify whether schedule is enabled or not  Defaults to true
        /// </summary>
        /// <value>Specify whether schedule is enabled or not  Defaults to true</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

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
            sb.Append("class UpdateScheduleRequest {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
            sb.Append("  Notifications: ").Append(Notifications).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as UpdateScheduleRequest);
        }

        /// <summary>
        /// Returns true if UpdateScheduleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateScheduleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateScheduleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Arguments == input.Arguments ||
                    this.Arguments != null &&
                    input.Arguments != null &&
                    this.Arguments.SequenceEqual(input.Arguments)
                ) && 
                (
                    this.Trigger == input.Trigger ||
                    (this.Trigger != null &&
                    this.Trigger.Equals(input.Trigger))
                ) && 
                (
                    this.Notifications == input.Notifications ||
                    this.Notifications != null &&
                    input.Notifications != null &&
                    this.Notifications.SequenceEqual(input.Notifications)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.Trigger != null)
                    hashCode = hashCode * 59 + this.Trigger.GetHashCode();
                if (this.Notifications != null)
                    hashCode = hashCode * 59 + this.Notifications.GetHashCode();
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.UseAsAuth != null)
                    hashCode = hashCode * 59 + this.UseAsAuth.GetHashCode();
                return hashCode;
            }
        }

    }
}
