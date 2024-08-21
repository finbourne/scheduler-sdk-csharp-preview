/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.931
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
    /// Request to upload image for Scheduler use
    /// </summary>
    [DataContract(Name = "UploadImageRequest")]
    public partial class UploadImageRequest : IEquatable<UploadImageRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadImageRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UploadImageRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadImageRequest" /> class.
        /// </summary>
        /// <param name="imageName">Name of the image to be uploaded (required).</param>
        public UploadImageRequest(string imageName = default(string))
        {
            // to ensure "imageName" is required (not null)
            this.ImageName = imageName ?? throw new ArgumentNullException("imageName is a required property for UploadImageRequest and cannot be null");
        }

        /// <summary>
        /// Name of the image to be uploaded
        /// </summary>
        /// <value>Name of the image to be uploaded</value>
        [DataMember(Name = "imageName", IsRequired = true, EmitDefaultValue = false)]
        public string ImageName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadImageRequest {\n");
            sb.Append("  ImageName: ").Append(ImageName).Append("\n");
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
            return this.Equals(input as UploadImageRequest);
        }

        /// <summary>
        /// Returns true if UploadImageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadImageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadImageRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageName == input.ImageName ||
                    (this.ImageName != null &&
                    this.ImageName.Equals(input.ImageName))
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
                if (this.ImageName != null)
                    hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                return hashCode;
            }
        }

    }
}
