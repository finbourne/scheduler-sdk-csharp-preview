/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.661
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
    /// Job run history
    /// </summary>
    [DataContract(Name = "JobHistory")]
    public partial class JobHistory : IEquatable<JobHistory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobHistory" /> class.
        /// </summary>
        /// <param name="runId">Unique id of the job run.</param>
        /// <param name="jobId">jobId.</param>
        /// <param name="name">Name of the job.</param>
        /// <param name="initialisedDate">The date when the job was initialised.</param>
        /// <param name="startDate">The date when the job started running in Scheduler.</param>
        /// <param name="endDate">End date of the job  Defaults to null if the job has not started or not completed yet  If value is null and job has not started, status will be &#x60;Pending&#x60;  If value is null and job has not completed, but is running, status will be &#x60;Running&#x60;.</param>
        /// <param name="arguments">All arguments used in in this job run.</param>
        /// <param name="environmentVariables">All environment variables used in this job run.</param>
        /// <param name="jobStatus">Current job status.</param>
        /// <param name="description">Description of the job.</param>
        /// <param name="scheduleId">scheduleId.</param>
        /// <param name="resultUrl">URI to results. Defaults to null if not available.</param>
        /// <param name="manuallyTriggeredBy">UserId of the user that triggered the job.  Defaults to null if job was ran on a Schedule.</param>
        /// <param name="command">The command used to run the job.</param>
        /// <param name="message">Output message generated by the job runner  Value will be null when the job is in a &#x60;Running&#x60; or &#x60;Pending&#x60; status.</param>
        public JobHistory(string runId = default(string), ResourceId jobId = default(ResourceId), string name = default(string), DateTimeOffset initialisedDate = default(DateTimeOffset), DateTimeOffset? startDate = default(DateTimeOffset?), DateTimeOffset? endDate = default(DateTimeOffset?), Dictionary<string, string> arguments = default(Dictionary<string, string>), Dictionary<string, string> environmentVariables = default(Dictionary<string, string>), string jobStatus = default(string), string description = default(string), ResourceId scheduleId = default(ResourceId), string resultUrl = default(string), string manuallyTriggeredBy = default(string), string command = default(string), string message = default(string))
        {
            this.RunId = runId;
            this.JobId = jobId;
            this.Name = name;
            this.InitialisedDate = initialisedDate;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Arguments = arguments;
            this.EnvironmentVariables = environmentVariables;
            this.JobStatus = jobStatus;
            this.Description = description;
            this.ScheduleId = scheduleId;
            this.ResultUrl = resultUrl;
            this.ManuallyTriggeredBy = manuallyTriggeredBy;
            this.Command = command;
            this.Message = message;
        }

        /// <summary>
        /// Unique id of the job run
        /// </summary>
        /// <value>Unique id of the job run</value>
        [DataMember(Name = "runId", EmitDefaultValue = true)]
        public string RunId { get; set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", EmitDefaultValue = false)]
        public ResourceId JobId { get; set; }

        /// <summary>
        /// Name of the job
        /// </summary>
        /// <value>Name of the job</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The date when the job was initialised
        /// </summary>
        /// <value>The date when the job was initialised</value>
        [DataMember(Name = "initialisedDate", EmitDefaultValue = false)]
        public DateTimeOffset InitialisedDate { get; set; }

        /// <summary>
        /// The date when the job started running in Scheduler
        /// </summary>
        /// <value>The date when the job started running in Scheduler</value>
        [DataMember(Name = "startDate", EmitDefaultValue = true)]
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// End date of the job  Defaults to null if the job has not started or not completed yet  If value is null and job has not started, status will be &#x60;Pending&#x60;  If value is null and job has not completed, but is running, status will be &#x60;Running&#x60;
        /// </summary>
        /// <value>End date of the job  Defaults to null if the job has not started or not completed yet  If value is null and job has not started, status will be &#x60;Pending&#x60;  If value is null and job has not completed, but is running, status will be &#x60;Running&#x60;</value>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        public DateTimeOffset? EndDate { get; set; }

        /// <summary>
        /// All arguments used in in this job run
        /// </summary>
        /// <value>All arguments used in in this job run</value>
        [DataMember(Name = "arguments", EmitDefaultValue = true)]
        public Dictionary<string, string> Arguments { get; set; }

        /// <summary>
        /// All environment variables used in this job run
        /// </summary>
        /// <value>All environment variables used in this job run</value>
        [DataMember(Name = "environmentVariables", EmitDefaultValue = true)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// Current job status
        /// </summary>
        /// <value>Current job status</value>
        [DataMember(Name = "jobStatus", EmitDefaultValue = true)]
        public string JobStatus { get; set; }

        /// <summary>
        /// Description of the job result
        /// </summary>
        /// <value>Description of the job result</value>
        [DataMember(Name = "jobResult", EmitDefaultValue = true)]
        public string JobResult { get; private set; }

        /// <summary>
        /// Returns false as JobResult should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeJobResult()
        {
            return false;
        }

        /// <summary>
        /// Description of the job
        /// </summary>
        /// <value>Description of the job</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ScheduleId
        /// </summary>
        [DataMember(Name = "scheduleId", EmitDefaultValue = false)]
        public ResourceId ScheduleId { get; set; }

        /// <summary>
        /// URI to results. Defaults to null if not available
        /// </summary>
        /// <value>URI to results. Defaults to null if not available</value>
        [DataMember(Name = "resultUrl", EmitDefaultValue = true)]
        public string ResultUrl { get; set; }

        /// <summary>
        /// UserId of the user that triggered the job.  Defaults to null if job was ran on a Schedule
        /// </summary>
        /// <value>UserId of the user that triggered the job.  Defaults to null if job was ran on a Schedule</value>
        [DataMember(Name = "manuallyTriggeredBy", EmitDefaultValue = true)]
        public string ManuallyTriggeredBy { get; set; }

        /// <summary>
        /// The command used to run the job
        /// </summary>
        /// <value>The command used to run the job</value>
        [DataMember(Name = "command", EmitDefaultValue = true)]
        public string Command { get; set; }

        /// <summary>
        /// Output message generated by the job runner  Value will be null when the job is in a &#x60;Running&#x60; or &#x60;Pending&#x60; status
        /// </summary>
        /// <value>Output message generated by the job runner  Value will be null when the job is in a &#x60;Running&#x60; or &#x60;Pending&#x60; status</value>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobHistory {\n");
            sb.Append("  RunId: ").Append(RunId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InitialisedDate: ").Append(InitialisedDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
            sb.Append("  EnvironmentVariables: ").Append(EnvironmentVariables).Append("\n");
            sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  JobResult: ").Append(JobResult).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ScheduleId: ").Append(ScheduleId).Append("\n");
            sb.Append("  ResultUrl: ").Append(ResultUrl).Append("\n");
            sb.Append("  ManuallyTriggeredBy: ").Append(ManuallyTriggeredBy).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as JobHistory);
        }

        /// <summary>
        /// Returns true if JobHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of JobHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobHistory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RunId == input.RunId ||
                    (this.RunId != null &&
                    this.RunId.Equals(input.RunId))
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
                    this.InitialisedDate == input.InitialisedDate ||
                    (this.InitialisedDate != null &&
                    this.InitialisedDate.Equals(input.InitialisedDate))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Arguments == input.Arguments ||
                    this.Arguments != null &&
                    input.Arguments != null &&
                    this.Arguments.SequenceEqual(input.Arguments)
                ) && 
                (
                    this.EnvironmentVariables == input.EnvironmentVariables ||
                    this.EnvironmentVariables != null &&
                    input.EnvironmentVariables != null &&
                    this.EnvironmentVariables.SequenceEqual(input.EnvironmentVariables)
                ) && 
                (
                    this.JobStatus == input.JobStatus ||
                    (this.JobStatus != null &&
                    this.JobStatus.Equals(input.JobStatus))
                ) && 
                (
                    this.JobResult == input.JobResult ||
                    (this.JobResult != null &&
                    this.JobResult.Equals(input.JobResult))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ScheduleId == input.ScheduleId ||
                    (this.ScheduleId != null &&
                    this.ScheduleId.Equals(input.ScheduleId))
                ) && 
                (
                    this.ResultUrl == input.ResultUrl ||
                    (this.ResultUrl != null &&
                    this.ResultUrl.Equals(input.ResultUrl))
                ) && 
                (
                    this.ManuallyTriggeredBy == input.ManuallyTriggeredBy ||
                    (this.ManuallyTriggeredBy != null &&
                    this.ManuallyTriggeredBy.Equals(input.ManuallyTriggeredBy))
                ) && 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.RunId != null)
                    hashCode = hashCode * 59 + this.RunId.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.InitialisedDate != null)
                    hashCode = hashCode * 59 + this.InitialisedDate.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.EnvironmentVariables != null)
                    hashCode = hashCode * 59 + this.EnvironmentVariables.GetHashCode();
                if (this.JobStatus != null)
                    hashCode = hashCode * 59 + this.JobStatus.GetHashCode();
                if (this.JobResult != null)
                    hashCode = hashCode * 59 + this.JobResult.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ScheduleId != null)
                    hashCode = hashCode * 59 + this.ScheduleId.GetHashCode();
                if (this.ResultUrl != null)
                    hashCode = hashCode * 59 + this.ResultUrl.GetHashCode();
                if (this.ManuallyTriggeredBy != null)
                    hashCode = hashCode * 59 + this.ManuallyTriggeredBy.GetHashCode();
                if (this.Command != null)
                    hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }

    }
}
