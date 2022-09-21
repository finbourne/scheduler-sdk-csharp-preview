/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.616
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
    /// UploadImageInstructions
    /// </summary>
    [DataContract(Name = "UploadImageInstructions")]
    public partial class UploadImageInstructions : IEquatable<UploadImageInstructions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadImageInstructions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UploadImageInstructions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadImageInstructions" /> class.
        /// </summary>
        /// <param name="dockerLoginCommand">dockerLoginCommand (required).</param>
        /// <param name="buildVersionedDockerImageCommand">buildVersionedDockerImageCommand (required).</param>
        /// <param name="tagVersionedDockerImageCommand">tagVersionedDockerImageCommand (required).</param>
        /// <param name="pushVersionedDockerImageCommand">pushVersionedDockerImageCommand (required).</param>
        /// <param name="tagLatestDockerImageCommand">tagLatestDockerImageCommand.</param>
        /// <param name="pushLatestDockerImageCommand">pushLatestDockerImageCommand.</param>
        /// <param name="expiryTime">expiryTime.</param>
        public UploadImageInstructions(string dockerLoginCommand = default(string), string buildVersionedDockerImageCommand = default(string), string tagVersionedDockerImageCommand = default(string), string pushVersionedDockerImageCommand = default(string), string tagLatestDockerImageCommand = default(string), string pushLatestDockerImageCommand = default(string), DateTimeOffset expiryTime = default(DateTimeOffset))
        {
            // to ensure "dockerLoginCommand" is required (not null)
            this.DockerLoginCommand = dockerLoginCommand ?? throw new ArgumentNullException("dockerLoginCommand is a required property for UploadImageInstructions and cannot be null");
            // to ensure "buildVersionedDockerImageCommand" is required (not null)
            this.BuildVersionedDockerImageCommand = buildVersionedDockerImageCommand ?? throw new ArgumentNullException("buildVersionedDockerImageCommand is a required property for UploadImageInstructions and cannot be null");
            // to ensure "tagVersionedDockerImageCommand" is required (not null)
            this.TagVersionedDockerImageCommand = tagVersionedDockerImageCommand ?? throw new ArgumentNullException("tagVersionedDockerImageCommand is a required property for UploadImageInstructions and cannot be null");
            // to ensure "pushVersionedDockerImageCommand" is required (not null)
            this.PushVersionedDockerImageCommand = pushVersionedDockerImageCommand ?? throw new ArgumentNullException("pushVersionedDockerImageCommand is a required property for UploadImageInstructions and cannot be null");
            this.TagLatestDockerImageCommand = tagLatestDockerImageCommand;
            this.PushLatestDockerImageCommand = pushLatestDockerImageCommand;
            this.ExpiryTime = expiryTime;
        }

        /// <summary>
        /// Gets or Sets DockerLoginCommand
        /// </summary>
        [DataMember(Name = "dockerLoginCommand", IsRequired = true, EmitDefaultValue = false)]
        public string DockerLoginCommand { get; set; }

        /// <summary>
        /// Gets or Sets BuildVersionedDockerImageCommand
        /// </summary>
        [DataMember(Name = "buildVersionedDockerImageCommand", IsRequired = true, EmitDefaultValue = false)]
        public string BuildVersionedDockerImageCommand { get; set; }

        /// <summary>
        /// Gets or Sets TagVersionedDockerImageCommand
        /// </summary>
        [DataMember(Name = "tagVersionedDockerImageCommand", IsRequired = true, EmitDefaultValue = false)]
        public string TagVersionedDockerImageCommand { get; set; }

        /// <summary>
        /// Gets or Sets PushVersionedDockerImageCommand
        /// </summary>
        [DataMember(Name = "pushVersionedDockerImageCommand", IsRequired = true, EmitDefaultValue = false)]
        public string PushVersionedDockerImageCommand { get; set; }

        /// <summary>
        /// Gets or Sets TagLatestDockerImageCommand
        /// </summary>
        [DataMember(Name = "tagLatestDockerImageCommand", EmitDefaultValue = true)]
        public string TagLatestDockerImageCommand { get; set; }

        /// <summary>
        /// Gets or Sets PushLatestDockerImageCommand
        /// </summary>
        [DataMember(Name = "pushLatestDockerImageCommand", EmitDefaultValue = true)]
        public string PushLatestDockerImageCommand { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryTime
        /// </summary>
        [DataMember(Name = "expiryTime", EmitDefaultValue = false)]
        public DateTimeOffset ExpiryTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadImageInstructions {\n");
            sb.Append("  DockerLoginCommand: ").Append(DockerLoginCommand).Append("\n");
            sb.Append("  BuildVersionedDockerImageCommand: ").Append(BuildVersionedDockerImageCommand).Append("\n");
            sb.Append("  TagVersionedDockerImageCommand: ").Append(TagVersionedDockerImageCommand).Append("\n");
            sb.Append("  PushVersionedDockerImageCommand: ").Append(PushVersionedDockerImageCommand).Append("\n");
            sb.Append("  TagLatestDockerImageCommand: ").Append(TagLatestDockerImageCommand).Append("\n");
            sb.Append("  PushLatestDockerImageCommand: ").Append(PushLatestDockerImageCommand).Append("\n");
            sb.Append("  ExpiryTime: ").Append(ExpiryTime).Append("\n");
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
            return this.Equals(input as UploadImageInstructions);
        }

        /// <summary>
        /// Returns true if UploadImageInstructions instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadImageInstructions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadImageInstructions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DockerLoginCommand == input.DockerLoginCommand ||
                    (this.DockerLoginCommand != null &&
                    this.DockerLoginCommand.Equals(input.DockerLoginCommand))
                ) && 
                (
                    this.BuildVersionedDockerImageCommand == input.BuildVersionedDockerImageCommand ||
                    (this.BuildVersionedDockerImageCommand != null &&
                    this.BuildVersionedDockerImageCommand.Equals(input.BuildVersionedDockerImageCommand))
                ) && 
                (
                    this.TagVersionedDockerImageCommand == input.TagVersionedDockerImageCommand ||
                    (this.TagVersionedDockerImageCommand != null &&
                    this.TagVersionedDockerImageCommand.Equals(input.TagVersionedDockerImageCommand))
                ) && 
                (
                    this.PushVersionedDockerImageCommand == input.PushVersionedDockerImageCommand ||
                    (this.PushVersionedDockerImageCommand != null &&
                    this.PushVersionedDockerImageCommand.Equals(input.PushVersionedDockerImageCommand))
                ) && 
                (
                    this.TagLatestDockerImageCommand == input.TagLatestDockerImageCommand ||
                    (this.TagLatestDockerImageCommand != null &&
                    this.TagLatestDockerImageCommand.Equals(input.TagLatestDockerImageCommand))
                ) && 
                (
                    this.PushLatestDockerImageCommand == input.PushLatestDockerImageCommand ||
                    (this.PushLatestDockerImageCommand != null &&
                    this.PushLatestDockerImageCommand.Equals(input.PushLatestDockerImageCommand))
                ) && 
                (
                    this.ExpiryTime == input.ExpiryTime ||
                    (this.ExpiryTime != null &&
                    this.ExpiryTime.Equals(input.ExpiryTime))
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
                if (this.DockerLoginCommand != null)
                    hashCode = hashCode * 59 + this.DockerLoginCommand.GetHashCode();
                if (this.BuildVersionedDockerImageCommand != null)
                    hashCode = hashCode * 59 + this.BuildVersionedDockerImageCommand.GetHashCode();
                if (this.TagVersionedDockerImageCommand != null)
                    hashCode = hashCode * 59 + this.TagVersionedDockerImageCommand.GetHashCode();
                if (this.PushVersionedDockerImageCommand != null)
                    hashCode = hashCode * 59 + this.PushVersionedDockerImageCommand.GetHashCode();
                if (this.TagLatestDockerImageCommand != null)
                    hashCode = hashCode * 59 + this.TagLatestDockerImageCommand.GetHashCode();
                if (this.PushLatestDockerImageCommand != null)
                    hashCode = hashCode * 59 + this.PushLatestDockerImageCommand.GetHashCode();
                if (this.ExpiryTime != null)
                    hashCode = hashCode * 59 + this.ExpiryTime.GetHashCode();
                return hashCode;
            }
        }

    }
}
