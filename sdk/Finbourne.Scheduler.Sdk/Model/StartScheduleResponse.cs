/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.647
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
    /// Response from a manual run of a schedule
    /// </summary>
    [DataContract(Name = "StartScheduleResponse")]
    public partial class StartScheduleResponse : IEquatable<StartScheduleResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartScheduleResponse" /> class.
        /// </summary>
        /// <param name="scheduleId">scheduleId.</param>
        /// <param name="jobId">jobId.</param>
        /// <param name="runId">Unique RunId of the started schedule.</param>
        /// <param name="status">Status of the started schedule.</param>
        /// <param name="result">Link to the result of the job run when completed.</param>
        public StartScheduleResponse(ResourceId scheduleId = default(ResourceId), ResourceId jobId = default(ResourceId), string runId = default(string), string status = default(string), string result = default(string))
        {
            this.ScheduleId = scheduleId;
            this.JobId = jobId;
            this.RunId = runId;
            this.Status = status;
            this.Result = result;
        }

        /// <summary>
        /// Gets or Sets ScheduleId
        /// </summary>
        [DataMember(Name = "scheduleId", EmitDefaultValue = false)]
        public ResourceId ScheduleId { get; set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", EmitDefaultValue = false)]
        public ResourceId JobId { get; set; }

        /// <summary>
        /// Unique RunId of the started schedule
        /// </summary>
        /// <value>Unique RunId of the started schedule</value>
        [DataMember(Name = "runId", EmitDefaultValue = true)]
        public string RunId { get; set; }

        /// <summary>
        /// Status of the started schedule
        /// </summary>
        /// <value>Status of the started schedule</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Link to the result of the job run when completed
        /// </summary>
        /// <value>Link to the result of the job run when completed</value>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public string Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartScheduleResponse {\n");
            sb.Append("  ScheduleId: ").Append(ScheduleId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  RunId: ").Append(RunId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(input as StartScheduleResponse);
        }

        /// <summary>
        /// Returns true if StartScheduleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of StartScheduleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartScheduleResponse input)
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
                    this.RunId == input.RunId ||
                    (this.RunId != null &&
                    this.RunId.Equals(input.RunId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
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
                if (this.RunId != null)
                    hashCode = hashCode * 59 + this.RunId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                return hashCode;
            }
        }

    }
}
