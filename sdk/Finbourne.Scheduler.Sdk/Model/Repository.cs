/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.841
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
    /// An object representation of a repository
    /// </summary>
    [DataContract(Name = "Repository")]
    public partial class Repository : IEquatable<Repository>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Repository" /> class.
        /// </summary>
        /// <param name="name">The identifier of the repository.</param>
        /// <param name="creationTime">Date of  repository creation.</param>
        /// <param name="lastUpdate">The last update of the repository.</param>
        /// <param name="description">Description of the repository.</param>
        /// <param name="pullCount">Number of times images were pulled from this repository.</param>
        /// <param name="imageCount">The number of versions of this image.</param>
        /// <param name="images">images.</param>
        /// <param name="links">links.</param>
        public Repository(string name = default(string), DateTimeOffset creationTime = default(DateTimeOffset), DateTimeOffset lastUpdate = default(DateTimeOffset), string description = default(string), long pullCount = default(long), long imageCount = default(long), Link images = default(Link), List<Link> links = default(List<Link>))
        {
            this.Name = name;
            this.CreationTime = creationTime;
            this.LastUpdate = lastUpdate;
            this.Description = description;
            this.PullCount = pullCount;
            this.ImageCount = imageCount;
            this.Images = images;
            this.Links = links;
        }

        /// <summary>
        /// The identifier of the repository
        /// </summary>
        /// <value>The identifier of the repository</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Date of  repository creation
        /// </summary>
        /// <value>Date of  repository creation</value>
        [DataMember(Name = "creationTime", EmitDefaultValue = false)]
        public DateTimeOffset CreationTime { get; set; }

        /// <summary>
        /// The last update of the repository
        /// </summary>
        /// <value>The last update of the repository</value>
        [DataMember(Name = "lastUpdate", EmitDefaultValue = false)]
        public DateTimeOffset LastUpdate { get; set; }

        /// <summary>
        /// Description of the repository
        /// </summary>
        /// <value>Description of the repository</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Number of times images were pulled from this repository
        /// </summary>
        /// <value>Number of times images were pulled from this repository</value>
        [DataMember(Name = "pullCount", EmitDefaultValue = false)]
        public long PullCount { get; set; }

        /// <summary>
        /// The number of versions of this image
        /// </summary>
        /// <value>The number of versions of this image</value>
        [DataMember(Name = "imageCount", EmitDefaultValue = false)]
        public long ImageCount { get; set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public Link Images { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Repository {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PullCount: ").Append(PullCount).Append("\n");
            sb.Append("  ImageCount: ").Append(ImageCount).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as Repository);
        }

        /// <summary>
        /// Returns true if Repository instances are equal
        /// </summary>
        /// <param name="input">Instance of Repository to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Repository input)
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
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.LastUpdate == input.LastUpdate ||
                    (this.LastUpdate != null &&
                    this.LastUpdate.Equals(input.LastUpdate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PullCount == input.PullCount ||
                    this.PullCount.Equals(input.PullCount)
                ) && 
                (
                    this.ImageCount == input.ImageCount ||
                    this.ImageCount.Equals(input.ImageCount)
                ) && 
                (
                    this.Images == input.Images ||
                    (this.Images != null &&
                    this.Images.Equals(input.Images))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.LastUpdate != null)
                    hashCode = hashCode * 59 + this.LastUpdate.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.PullCount.GetHashCode();
                hashCode = hashCode * 59 + this.ImageCount.GetHashCode();
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
