/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.621
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
    /// A file based triggered constrained by a time window  Supports the ability to specify multiple trigger files,  to choose whether a schedule is triggered for every file or first file,  has the option to trigger the schedule at the end of the time window, if any or no files arrived
    /// </summary>
    [DataContract(Name = "CombinedTrigger")]
    public partial class CombinedTrigger : IEquatable<CombinedTrigger>
    {

        /// <summary>
        /// Gets or Sets DaysAvailable
        /// </summary>
        [DataMember(Name = "daysAvailable", IsRequired = true, EmitDefaultValue = false)]
        public DaysOfWeek DaysAvailable { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedTrigger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CombinedTrigger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedTrigger" /> class.
        /// </summary>
        /// <param name="startTime">The start of the time window when a file can arrive to trigger the schedule  Cannot exceed 24 hours (required).</param>
        /// <param name="endTime">The end of the time window when a file can arrive to trigger the schedule  Must be after the Finbourne.Scheduler.WebApi.Dtos.CombinedTrigger.StartTime and cannot exceed 24 hours (required).</param>
        /// <param name="file">The file name or partial path of the file that will trigger the job  E.G: &#x60;fileName&#x60; or &#x60;folder1/folder2/someFileName&#x60; (required).</param>
        /// <param name="pollPeriod">The frequency, in seconds, at which to poll the S3 bucket for the file.  Must be lower than the difference in seconds between Finbourne.Scheduler.WebApi.Dtos.CombinedTrigger.EndTime and Finbourne.Scheduler.WebApi.Dtos.CombinedTrigger.StartTime  Defaults to 5..</param>
        /// <param name="bucket">The S3 bucket where to watch for the trigger file (required).</param>
        /// <param name="triggerEveryFile">Specify whether to trigger every time the file is updated.</param>
        /// <param name="endOfTimeWindowOption">Specifies the behaviour of the trigger when the time window ends  Available options are \&quot;Always\&quot;, \&quot;NoFile\&quot;, \&quot;FileReceived\&quot;, \&quot;Never\&quot;  Finbourne.Scheduler.WebApi.Dtos.CombinedTrigger.EndOfTimeWindowOption (required).</param>
        /// <param name="daysAvailable">daysAvailable (required).</param>
        public CombinedTrigger(string startTime = default(string), string endTime = default(string), string file = default(string), int pollPeriod = default(int), string bucket = default(string), bool triggerEveryFile = default(bool), string endOfTimeWindowOption = default(string), DaysOfWeek daysAvailable = default(DaysOfWeek))
        {
            // to ensure "startTime" is required (not null)
            this.StartTime = startTime ?? throw new ArgumentNullException("startTime is a required property for CombinedTrigger and cannot be null");
            // to ensure "endTime" is required (not null)
            this.EndTime = endTime ?? throw new ArgumentNullException("endTime is a required property for CombinedTrigger and cannot be null");
            // to ensure "file" is required (not null)
            this.File = file ?? throw new ArgumentNullException("file is a required property for CombinedTrigger and cannot be null");
            // to ensure "bucket" is required (not null)
            this.Bucket = bucket ?? throw new ArgumentNullException("bucket is a required property for CombinedTrigger and cannot be null");
            // to ensure "endOfTimeWindowOption" is required (not null)
            this.EndOfTimeWindowOption = endOfTimeWindowOption ?? throw new ArgumentNullException("endOfTimeWindowOption is a required property for CombinedTrigger and cannot be null");
            this.DaysAvailable = daysAvailable;
            this.PollPeriod = pollPeriod;
            this.TriggerEveryFile = triggerEveryFile;
        }

        /// <summary>
        /// The start of the time window when a file can arrive to trigger the schedule  Cannot exceed 24 hours
        /// </summary>
        /// <value>The start of the time window when a file can arrive to trigger the schedule  Cannot exceed 24 hours</value>
        [DataMember(Name = "startTime", IsRequired = true, EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The end of the time window when a file can arrive to trigger the schedule  Must be after the Finbourne.Scheduler.WebApi.Dtos.CombinedTrigger.StartTime and cannot exceed 24 hours
        /// </summary>
        /// <value>The end of the time window when a file can arrive to trigger the schedule  Must be after the Finbourne.Scheduler.WebApi.Dtos.CombinedTrigger.StartTime and cannot exceed 24 hours</value>
        [DataMember(Name = "endTime", IsRequired = true, EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The file name or partial path of the file that will trigger the job  E.G: &#x60;fileName&#x60; or &#x60;folder1/folder2/someFileName&#x60;
        /// </summary>
        /// <value>The file name or partial path of the file that will trigger the job  E.G: &#x60;fileName&#x60; or &#x60;folder1/folder2/someFileName&#x60;</value>
        [DataMember(Name = "file", IsRequired = true, EmitDefaultValue = false)]
        public string File { get; set; }

        /// <summary>
        /// The frequency, in seconds, at which to poll the S3 bucket for the file.  Must be lower than the difference in seconds between Finbourne.Scheduler.WebApi.Dtos.CombinedTrigger.EndTime and Finbourne.Scheduler.WebApi.Dtos.CombinedTrigger.StartTime  Defaults to 5.
        /// </summary>
        /// <value>The frequency, in seconds, at which to poll the S3 bucket for the file.  Must be lower than the difference in seconds between Finbourne.Scheduler.WebApi.Dtos.CombinedTrigger.EndTime and Finbourne.Scheduler.WebApi.Dtos.CombinedTrigger.StartTime  Defaults to 5.</value>
        [DataMember(Name = "pollPeriod", EmitDefaultValue = true)]
        public int PollPeriod { get; set; }

        /// <summary>
        /// The S3 bucket where to watch for the trigger file
        /// </summary>
        /// <value>The S3 bucket where to watch for the trigger file</value>
        [DataMember(Name = "bucket", IsRequired = true, EmitDefaultValue = false)]
        public string Bucket { get; set; }

        /// <summary>
        /// Specify whether to trigger every time the file is updated
        /// </summary>
        /// <value>Specify whether to trigger every time the file is updated</value>
        [DataMember(Name = "triggerEveryFile", EmitDefaultValue = true)]
        public bool TriggerEveryFile { get; set; }

        /// <summary>
        /// Specifies the behaviour of the trigger when the time window ends  Available options are \&quot;Always\&quot;, \&quot;NoFile\&quot;, \&quot;FileReceived\&quot;, \&quot;Never\&quot;  Finbourne.Scheduler.WebApi.Dtos.CombinedTrigger.EndOfTimeWindowOption
        /// </summary>
        /// <value>Specifies the behaviour of the trigger when the time window ends  Available options are \&quot;Always\&quot;, \&quot;NoFile\&quot;, \&quot;FileReceived\&quot;, \&quot;Never\&quot;  Finbourne.Scheduler.WebApi.Dtos.CombinedTrigger.EndOfTimeWindowOption</value>
        [DataMember(Name = "endOfTimeWindowOption", IsRequired = true, EmitDefaultValue = false)]
        public string EndOfTimeWindowOption { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CombinedTrigger {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  PollPeriod: ").Append(PollPeriod).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
            sb.Append("  TriggerEveryFile: ").Append(TriggerEveryFile).Append("\n");
            sb.Append("  EndOfTimeWindowOption: ").Append(EndOfTimeWindowOption).Append("\n");
            sb.Append("  DaysAvailable: ").Append(DaysAvailable).Append("\n");
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
            return this.Equals(input as CombinedTrigger);
        }

        /// <summary>
        /// Returns true if CombinedTrigger instances are equal
        /// </summary>
        /// <param name="input">Instance of CombinedTrigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CombinedTrigger input)
        {
            if (input == null)
                return false;

            return 
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
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.PollPeriod == input.PollPeriod ||
                    this.PollPeriod.Equals(input.PollPeriod)
                ) && 
                (
                    this.Bucket == input.Bucket ||
                    (this.Bucket != null &&
                    this.Bucket.Equals(input.Bucket))
                ) && 
                (
                    this.TriggerEveryFile == input.TriggerEveryFile ||
                    this.TriggerEveryFile.Equals(input.TriggerEveryFile)
                ) && 
                (
                    this.EndOfTimeWindowOption == input.EndOfTimeWindowOption ||
                    (this.EndOfTimeWindowOption != null &&
                    this.EndOfTimeWindowOption.Equals(input.EndOfTimeWindowOption))
                ) && 
                (
                    this.DaysAvailable == input.DaysAvailable ||
                    this.DaysAvailable.Equals(input.DaysAvailable)
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                hashCode = hashCode * 59 + this.PollPeriod.GetHashCode();
                if (this.Bucket != null)
                    hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerEveryFile.GetHashCode();
                if (this.EndOfTimeWindowOption != null)
                    hashCode = hashCode * 59 + this.EndOfTimeWindowOption.GetHashCode();
                hashCode = hashCode * 59 + this.DaysAvailable.GetHashCode();
                return hashCode;
            }
        }

    }
}
