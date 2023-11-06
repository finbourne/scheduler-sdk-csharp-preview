/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.835
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
    /// Represents the metadata of an image
    /// </summary>
    [DataContract(Name = "Image")]
    public partial class Image : IEquatable<Image>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        /// <param name="name">Name of the image.</param>
        /// <param name="pushTime">The push time of the image.</param>
        /// <param name="pullTime">The latest pull time of the image.</param>
        /// <param name="digest">The digest of the image.</param>
        /// <param name="size">The size of the image (in bytes).</param>
        /// <param name="tags">The tags of the image.</param>
        /// <param name="scanReport">scanReport.</param>
        public Image(string name = default(string), DateTimeOffset? pushTime = default(DateTimeOffset?), DateTimeOffset? pullTime = default(DateTimeOffset?), string digest = default(string), long? size = default(long?), List<Tag> tags = default(List<Tag>), ScanReport scanReport = default(ScanReport))
        {
            this.Name = name;
            this.PushTime = pushTime;
            this.PullTime = pullTime;
            this.Digest = digest;
            this.Size = size;
            this.Tags = tags;
            this.ScanReport = scanReport;
        }

        /// <summary>
        /// Name of the image
        /// </summary>
        /// <value>Name of the image</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The push time of the image
        /// </summary>
        /// <value>The push time of the image</value>
        [DataMember(Name = "pushTime", EmitDefaultValue = true)]
        public DateTimeOffset? PushTime { get; set; }

        /// <summary>
        /// The latest pull time of the image
        /// </summary>
        /// <value>The latest pull time of the image</value>
        [DataMember(Name = "pullTime", EmitDefaultValue = true)]
        public DateTimeOffset? PullTime { get; set; }

        /// <summary>
        /// The digest of the image
        /// </summary>
        /// <value>The digest of the image</value>
        [DataMember(Name = "digest", EmitDefaultValue = true)]
        public string Digest { get; set; }

        /// <summary>
        /// The size of the image (in bytes)
        /// </summary>
        /// <value>The size of the image (in bytes)</value>
        [DataMember(Name = "size", EmitDefaultValue = true)]
        public long? Size { get; set; }

        /// <summary>
        /// The tags of the image
        /// </summary>
        /// <value>The tags of the image</value>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Gets or Sets ScanReport
        /// </summary>
        [DataMember(Name = "scanReport", EmitDefaultValue = false)]
        public ScanReport ScanReport { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Image {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PushTime: ").Append(PushTime).Append("\n");
            sb.Append("  PullTime: ").Append(PullTime).Append("\n");
            sb.Append("  Digest: ").Append(Digest).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ScanReport: ").Append(ScanReport).Append("\n");
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
            return this.Equals(input as Image);
        }

        /// <summary>
        /// Returns true if Image instances are equal
        /// </summary>
        /// <param name="input">Instance of Image to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Image input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PushTime == input.PushTime ||
                    (this.PushTime != null &&
                    this.PushTime.Equals(input.PushTime))
                ) && 
                (
                    this.PullTime == input.PullTime ||
                    (this.PullTime != null &&
                    this.PullTime.Equals(input.PullTime))
                ) && 
                (
                    this.Digest == input.Digest ||
                    (this.Digest != null &&
                    this.Digest.Equals(input.Digest))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.ScanReport == input.ScanReport ||
                    (this.ScanReport != null &&
                    this.ScanReport.Equals(input.ScanReport))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PushTime != null)
                    hashCode = hashCode * 59 + this.PushTime.GetHashCode();
                if (this.PullTime != null)
                    hashCode = hashCode * 59 + this.PullTime.GetHashCode();
                if (this.Digest != null)
                    hashCode = hashCode * 59 + this.Digest.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ScanReport != null)
                    hashCode = hashCode * 59 + this.ScanReport.GetHashCode();
                return hashCode;
            }
        }

    }
}
