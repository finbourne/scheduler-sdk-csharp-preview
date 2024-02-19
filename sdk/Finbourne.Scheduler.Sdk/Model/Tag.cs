/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.852
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
    /// Represents data of an image&#39;s tag
    /// </summary>
    [DataContract(Name = "Tag")]
    public partial class Tag : IEquatable<Tag>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tag" /> class.
        /// </summary>
        /// <param name="name">The name of the tag.</param>
        /// <param name="pullTime">The latest pull time.</param>
        /// <param name="pushTime">The date of the tag&#39;s push.</param>
        /// <param name="signed">Indicates whether the tag is signed.</param>
        /// <param name="immutable">Indicates whether the tag is immutable.</param>
        public Tag(string name = default(string), DateTimeOffset pullTime = default(DateTimeOffset), DateTimeOffset pushTime = default(DateTimeOffset), bool signed = default(bool), bool immutable = default(bool))
        {
            this.Name = name;
            this.PullTime = pullTime;
            this.PushTime = pushTime;
            this.Signed = signed;
            this.Immutable = immutable;
        }

        /// <summary>
        /// The name of the tag
        /// </summary>
        /// <value>The name of the tag</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The latest pull time
        /// </summary>
        /// <value>The latest pull time</value>
        [DataMember(Name = "pullTime", EmitDefaultValue = false)]
        public DateTimeOffset PullTime { get; set; }

        /// <summary>
        /// The date of the tag&#39;s push
        /// </summary>
        /// <value>The date of the tag&#39;s push</value>
        [DataMember(Name = "pushTime", EmitDefaultValue = false)]
        public DateTimeOffset PushTime { get; set; }

        /// <summary>
        /// Indicates whether the tag is signed
        /// </summary>
        /// <value>Indicates whether the tag is signed</value>
        [DataMember(Name = "signed", EmitDefaultValue = true)]
        public bool Signed { get; set; }

        /// <summary>
        /// Indicates whether the tag is immutable
        /// </summary>
        /// <value>Indicates whether the tag is immutable</value>
        [DataMember(Name = "immutable", EmitDefaultValue = true)]
        public bool Immutable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tag {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PullTime: ").Append(PullTime).Append("\n");
            sb.Append("  PushTime: ").Append(PushTime).Append("\n");
            sb.Append("  Signed: ").Append(Signed).Append("\n");
            sb.Append("  Immutable: ").Append(Immutable).Append("\n");
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
            return this.Equals(input as Tag);
        }

        /// <summary>
        /// Returns true if Tag instances are equal
        /// </summary>
        /// <param name="input">Instance of Tag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tag input)
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
                    this.PullTime == input.PullTime ||
                    (this.PullTime != null &&
                    this.PullTime.Equals(input.PullTime))
                ) && 
                (
                    this.PushTime == input.PushTime ||
                    (this.PushTime != null &&
                    this.PushTime.Equals(input.PushTime))
                ) && 
                (
                    this.Signed == input.Signed ||
                    this.Signed.Equals(input.Signed)
                ) && 
                (
                    this.Immutable == input.Immutable ||
                    this.Immutable.Equals(input.Immutable)
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
                if (this.PullTime != null)
                    hashCode = hashCode * 59 + this.PullTime.GetHashCode();
                if (this.PushTime != null)
                    hashCode = hashCode * 59 + this.PushTime.GetHashCode();
                hashCode = hashCode * 59 + this.Signed.GetHashCode();
                hashCode = hashCode * 59 + this.Immutable.GetHashCode();
                return hashCode;
            }
        }

    }
}
