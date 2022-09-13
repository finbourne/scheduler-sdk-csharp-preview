/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.612
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
    [DataContract(Name = "CreateScheduleRequest")]
    public partial class CreateScheduleRequest : IEquatable<CreateScheduleRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScheduleRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateScheduleRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScheduleRequest" /> class.
        /// </summary>
        /// <param name="scheduleId">scheduleId (required).</param>
        /// <param name="jobId">jobId (required).</param>
        /// <param name="name">A display name for this Schedule (required).</param>
        /// <param name="description">A description of the Schedule (required).</param>
        /// <param name="author">Name of the author of this schedule.</param>
        /// <param name="owner">Name of owner of this schedule.</param>
        /// <param name="arguments">All arguments specified by this Schedule that will be passed in to the Job.</param>
        /// <param name="trigger">trigger.</param>
        /// <param name="notifications">Notifications for this Schedule (required).</param>
        /// <param name="enabled">Specify whether schedule is enabled or not  Defaults to true.</param>
        public CreateScheduleRequest(ResourceId scheduleId = default(ResourceId), ResourceId jobId = default(ResourceId), string name = default(string), string description = default(string), string author = default(string), string owner = default(string), Dictionary<string, string> arguments = default(Dictionary<string, string>), Trigger trigger = default(Trigger), List<Notification> notifications = default(List<Notification>), bool enabled = default(bool))
        {
            // to ensure "scheduleId" is required (not null)
            this.ScheduleId = scheduleId ?? throw new ArgumentNullException("scheduleId is a required property for CreateScheduleRequest and cannot be null");
            // to ensure "jobId" is required (not null)
            this.JobId = jobId ?? throw new ArgumentNullException("jobId is a required property for CreateScheduleRequest and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for CreateScheduleRequest and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for CreateScheduleRequest and cannot be null");
            // to ensure "notifications" is required (not null)
            this.Notifications = notifications ?? throw new ArgumentNullException("notifications is a required property for CreateScheduleRequest and cannot be null");
            this.Author = author;
            this.Owner = owner;
            this.Arguments = arguments;
            this.Trigger = trigger;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Gets or Sets ScheduleId
        /// </summary>
        [DataMember(Name = "scheduleId", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId ScheduleId { get; set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId JobId { get; set; }

        /// <summary>
        /// A display name for this Schedule
        /// </summary>
        /// <value>A display name for this Schedule</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A description of the Schedule
        /// </summary>
        /// <value>A description of the Schedule</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
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
        [DataMember(Name = "notifications", IsRequired = true, EmitDefaultValue = false)]
        public List<Notification> Notifications { get; set; }

        /// <summary>
        /// Specify whether schedule is enabled or not  Defaults to true
        /// </summary>
        /// <value>Specify whether schedule is enabled or not  Defaults to true</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateScheduleRequest {\n");
            sb.Append("  ScheduleId: ").Append(ScheduleId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
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
            return this.Equals(input as CreateScheduleRequest);
        }

        /// <summary>
        /// Returns true if CreateScheduleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateScheduleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateScheduleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScheduleId == input.ScheduleId ||
                    (this.ScheduleId != null &&
                    this.ScheduleId.Equals(input.ScheduleId))
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
                if (this.ScheduleId != null)
                    hashCode = hashCode * 59 + this.ScheduleId.GetHashCode();
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
                return hashCode;
            }
        }

    }
}
