/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.798
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
    /// Schedule
    /// </summary>
    [DataContract(Name = "ScheduleDefinition")]
    public partial class ScheduleDefinition : IEquatable<ScheduleDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleDefinition" /> class.
        /// </summary>
        /// <param name="scheduleIdentifier">scheduleIdentifier (required).</param>
        /// <param name="jobId">jobId.</param>
        /// <param name="name">A display name for this Schedule.</param>
        /// <param name="description">A description of the Schedule.</param>
        /// <param name="author">Name of the author of this schedule.</param>
        /// <param name="owner">Name of owner of this schedule.</param>
        /// <param name="useAsAuth">User to runs schedule when automatically run and authenticates   requests in the schedule.</param>
        /// <param name="arguments">All arguments specified by this Schedule that will be passed in to the Job.</param>
        /// <param name="trigger">trigger.</param>
        /// <param name="notifications">Notifications for this Schedule.</param>
        /// <param name="enabled">The status of this schedule.</param>
        public ScheduleDefinition(ResourceId scheduleIdentifier = default(ResourceId), ResourceId jobId = default(ResourceId), string name = default(string), string description = default(string), string author = default(string), string owner = default(string), string useAsAuth = default(string), Dictionary<string, string> arguments = default(Dictionary<string, string>), Trigger trigger = default(Trigger), List<Notification> notifications = default(List<Notification>), bool enabled = default(bool))
        {
            // to ensure "scheduleIdentifier" is required (not null)
            this.ScheduleIdentifier = scheduleIdentifier ?? throw new ArgumentNullException("scheduleIdentifier is a required property for ScheduleDefinition and cannot be null");
            this.JobId = jobId;
            this.Name = name;
            this.Description = description;
            this.Author = author;
            this.Owner = owner;
            this.UseAsAuth = useAsAuth;
            this.Arguments = arguments;
            this.Trigger = trigger;
            this.Notifications = notifications;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Gets or Sets ScheduleIdentifier
        /// </summary>
        [DataMember(Name = "scheduleIdentifier", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId ScheduleIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", EmitDefaultValue = false)]
        public ResourceId JobId { get; set; }

        /// <summary>
        /// A display name for this Schedule
        /// </summary>
        /// <value>A display name for this Schedule</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// A description of the Schedule
        /// </summary>
        /// <value>A description of the Schedule</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Name of the author of this schedule
        /// </summary>
        /// <value>Name of the author of this schedule</value>
        [DataMember(Name = "author", EmitDefaultValue = true)]
        public string Author { get; set; }

        /// <summary>
        /// Name of owner of this schedule
        /// </summary>
        /// <value>Name of owner of this schedule</value>
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public string Owner { get; set; }

        /// <summary>
        /// User to runs schedule when automatically run and authenticates   requests in the schedule
        /// </summary>
        /// <value>User to runs schedule when automatically run and authenticates   requests in the schedule</value>
        [DataMember(Name = "useAsAuth", EmitDefaultValue = true)]
        public string UseAsAuth { get; set; }

        /// <summary>
        /// All arguments specified by this Schedule that will be passed in to the Job
        /// </summary>
        /// <value>All arguments specified by this Schedule that will be passed in to the Job</value>
        [DataMember(Name = "arguments", EmitDefaultValue = true)]
        public Dictionary<string, string> Arguments { get; set; }

        /// <summary>
        /// Gets or Sets Trigger
        /// </summary>
        [DataMember(Name = "trigger", EmitDefaultValue = false)]
        public Trigger Trigger { get; set; }

        /// <summary>
        /// Notifications for this Schedule
        /// </summary>
        /// <value>Notifications for this Schedule</value>
        [DataMember(Name = "notifications", EmitDefaultValue = true)]
        public List<Notification> Notifications { get; set; }

        /// <summary>
        /// The status of this schedule
        /// </summary>
        /// <value>The status of this schedule</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleDefinition {\n");
            sb.Append("  ScheduleIdentifier: ").Append(ScheduleIdentifier).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  UseAsAuth: ").Append(UseAsAuth).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
            sb.Append("  Notifications: ").Append(Notifications).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as ScheduleDefinition);
        }

        /// <summary>
        /// Returns true if ScheduleDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScheduleIdentifier == input.ScheduleIdentifier ||
                    (this.ScheduleIdentifier != null &&
                    this.ScheduleIdentifier.Equals(input.ScheduleIdentifier))
                ) && 
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
                    this.UseAsAuth == input.UseAsAuth ||
                    (this.UseAsAuth != null &&
                    this.UseAsAuth.Equals(input.UseAsAuth))
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
                if (this.ScheduleIdentifier != null)
                    hashCode = hashCode * 59 + this.ScheduleIdentifier.GetHashCode();
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
                if (this.UseAsAuth != null)
                    hashCode = hashCode * 59 + this.UseAsAuth.GetHashCode();
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.Trigger != null)
                    hashCode = hashCode * 59 + this.Trigger.GetHashCode();
                if (this.Notifications != null)
                    hashCode = hashCode * 59 + this.Notifications.GetHashCode();
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                return hashCode;
            }
        }

    }
}
