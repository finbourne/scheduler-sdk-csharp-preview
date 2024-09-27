/*
 * FINBOURNE Scheduler API
 *
 * ### Introduction   # Error Codes   | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"152\">152</a>|Action Execution Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"704\">704</a>|Cannot Delete Job|  | | <a name=\"731\">731</a>|Unable to process images associated with request.|  | | <a name=\"756\">756</a>|Image Scan Failure|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | 
 *
 * The version of the OpenAPI document: 0.0.936
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
