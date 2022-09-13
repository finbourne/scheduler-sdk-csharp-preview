/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.613
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
    /// Represents the details of a security scan of an image
    /// </summary>
    [DataContract(Name = "ScanReport")]
    public partial class ScanReport : IEquatable<ScanReport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScanReport" /> class.
        /// </summary>
        /// <param name="severity">The overall severity. For example : \&quot;High\&quot; or \&quot;None\&quot;.</param>
        /// <param name="status">The status of the report.</param>
        /// <param name="startTime">The start time of the scanning process.</param>
        /// <param name="endTime">The end time of the scanning process.</param>
        /// <param name="scanDuration">The duration of the scan in seconds.</param>
        /// <param name="summary">summary.</param>
        /// <param name="vulnerabilities">List of Finbourne.Scheduler.WebApi.Dtos.Harbor.Vulnerability.</param>
        public ScanReport(string severity = default(string), string status = default(string), DateTimeOffset? startTime = default(DateTimeOffset?), DateTimeOffset? endTime = default(DateTimeOffset?), int? scanDuration = default(int?), ScanSummary summary = default(ScanSummary), List<Vulnerability> vulnerabilities = default(List<Vulnerability>))
        {
            this.Severity = severity;
            this.Status = status;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.ScanDuration = scanDuration;
            this.Summary = summary;
            this.Vulnerabilities = vulnerabilities;
        }

        /// <summary>
        /// The overall severity. For example : \&quot;High\&quot; or \&quot;None\&quot;
        /// </summary>
        /// <value>The overall severity. For example : \&quot;High\&quot; or \&quot;None\&quot;</value>
        [DataMember(Name = "severity", EmitDefaultValue = true)]
        public string Severity { get; set; }

        /// <summary>
        /// The status of the report
        /// </summary>
        /// <value>The status of the report</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// The start time of the scanning process
        /// </summary>
        /// <value>The start time of the scanning process</value>
        [DataMember(Name = "startTime", EmitDefaultValue = true)]
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// The end time of the scanning process
        /// </summary>
        /// <value>The end time of the scanning process</value>
        [DataMember(Name = "endTime", EmitDefaultValue = true)]
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// The duration of the scan in seconds
        /// </summary>
        /// <value>The duration of the scan in seconds</value>
        [DataMember(Name = "scanDuration", EmitDefaultValue = true)]
        public int? ScanDuration { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public ScanSummary Summary { get; set; }

        /// <summary>
        /// List of Finbourne.Scheduler.WebApi.Dtos.Harbor.Vulnerability
        /// </summary>
        /// <value>List of Finbourne.Scheduler.WebApi.Dtos.Harbor.Vulnerability</value>
        [DataMember(Name = "vulnerabilities", EmitDefaultValue = true)]
        public List<Vulnerability> Vulnerabilities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScanReport {\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  ScanDuration: ").Append(ScanDuration).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Vulnerabilities: ").Append(Vulnerabilities).Append("\n");
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
            return this.Equals(input as ScanReport);
        }

        /// <summary>
        /// Returns true if ScanReport instances are equal
        /// </summary>
        /// <param name="input">Instance of ScanReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScanReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.ScanDuration == input.ScanDuration ||
                    (this.ScanDuration != null &&
                    this.ScanDuration.Equals(input.ScanDuration))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Vulnerabilities == input.Vulnerabilities ||
                    this.Vulnerabilities != null &&
                    input.Vulnerabilities != null &&
                    this.Vulnerabilities.SequenceEqual(input.Vulnerabilities)
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
                if (this.Severity != null)
                    hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ScanDuration != null)
                    hashCode = hashCode * 59 + this.ScanDuration.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Vulnerabilities != null)
                    hashCode = hashCode * 59 + this.Vulnerabilities.GetHashCode();
                return hashCode;
            }
        }

    }
}
