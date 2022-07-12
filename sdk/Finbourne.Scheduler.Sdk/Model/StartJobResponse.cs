/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.579
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
    /// Response from starting a job
    /// </summary>
    [DataContract(Name = "StartJobResponse")]
    public partial class StartJobResponse : IEquatable<StartJobResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartJobResponse" /> class.
        /// </summary>
        /// <param name="jobId">jobId.</param>
        /// <param name="runId">Unique RunId of the started job run.</param>
        /// <param name="status">Link to the status of the started job.</param>
        /// <param name="result">Link to the result of the job run when completed.</param>
        public StartJobResponse(ResourceId jobId = default(ResourceId), string runId = default(string), string status = default(string), string result = default(string))
        {
            this.JobId = jobId;
            this.RunId = runId;
            this.Status = status;
            this.Result = result;
        }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", EmitDefaultValue = false)]
        public ResourceId JobId { get; set; }

        /// <summary>
        /// Unique RunId of the started job run
        /// </summary>
        /// <value>Unique RunId of the started job run</value>
        [DataMember(Name = "runId", EmitDefaultValue = true)]
        public string RunId { get; set; }

        /// <summary>
        /// Link to the status of the started job
        /// </summary>
        /// <value>Link to the status of the started job</value>
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
            sb.Append("class StartJobResponse {\n");
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
            return this.Equals(input as StartJobResponse);
        }

        /// <summary>
        /// Returns true if StartJobResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of StartJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartJobResponse input)
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
