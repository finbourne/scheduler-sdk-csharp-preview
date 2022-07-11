/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.574
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
    /// Trigger based on activity from an S3 bucket
    /// </summary>
    [DataContract(Name = "BucketWatcherTrigger")]
    public partial class BucketWatcherTrigger : IEquatable<BucketWatcherTrigger>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BucketWatcherTrigger" /> class.
        /// </summary>
        /// <param name="file">The file name or partial path of the file that will trigger the job  E.G: &#x60;fileName&#x60; or &#x60;folder1/folder2/someFileName&#x60;.</param>
        /// <param name="pollPeriod">The frequency, in seconds, at which to poll the S3 bucket for the file.  Defaults to 5..</param>
        /// <param name="bucket">The S3 bucket where to watch for the trigger file.</param>
        public BucketWatcherTrigger(string file = default(string), int pollPeriod = default(int), string bucket = default(string))
        {
            this.File = file;
            this.PollPeriod = pollPeriod;
            this.Bucket = bucket;
        }

        /// <summary>
        /// The file name or partial path of the file that will trigger the job  E.G: &#x60;fileName&#x60; or &#x60;folder1/folder2/someFileName&#x60;
        /// </summary>
        /// <value>The file name or partial path of the file that will trigger the job  E.G: &#x60;fileName&#x60; or &#x60;folder1/folder2/someFileName&#x60;</value>
        [DataMember(Name = "file", EmitDefaultValue = true)]
        public string File { get; set; }

        /// <summary>
        /// The frequency, in seconds, at which to poll the S3 bucket for the file.  Defaults to 5.
        /// </summary>
        /// <value>The frequency, in seconds, at which to poll the S3 bucket for the file.  Defaults to 5.</value>
        [DataMember(Name = "pollPeriod", EmitDefaultValue = true)]
        public int PollPeriod { get; set; }

        /// <summary>
        /// The S3 bucket where to watch for the trigger file
        /// </summary>
        /// <value>The S3 bucket where to watch for the trigger file</value>
        [DataMember(Name = "bucket", EmitDefaultValue = true)]
        public string Bucket { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BucketWatcherTrigger {\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  PollPeriod: ").Append(PollPeriod).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
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
            return this.Equals(input as BucketWatcherTrigger);
        }

        /// <summary>
        /// Returns true if BucketWatcherTrigger instances are equal
        /// </summary>
        /// <param name="input">Instance of BucketWatcherTrigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BucketWatcherTrigger input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                hashCode = hashCode * 59 + this.PollPeriod.GetHashCode();
                if (this.Bucket != null)
                    hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                return hashCode;
            }
        }

    }
}
