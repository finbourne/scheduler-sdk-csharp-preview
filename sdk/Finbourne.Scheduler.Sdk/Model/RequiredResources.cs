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
    /// Information related to a jobs required access to resources
    /// </summary>
    [DataContract(Name = "RequiredResources")]
    public partial class RequiredResources : IEquatable<RequiredResources>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredResources" /> class.
        /// </summary>
        /// <param name="lusidApis">List of LUSID APIs the job needs access to.</param>
        /// <param name="lusidFileSystem">List of S3 bucket or folder names that the job can access.</param>
        /// <param name="externalCalls">External URLs that the job can call.</param>
        public RequiredResources(List<string> lusidApis = default(List<string>), List<string> lusidFileSystem = default(List<string>), List<string> externalCalls = default(List<string>))
        {
            this.LusidApis = lusidApis;
            this.LusidFileSystem = lusidFileSystem;
            this.ExternalCalls = externalCalls;
        }

        /// <summary>
        /// List of LUSID APIs the job needs access to
        /// </summary>
        /// <value>List of LUSID APIs the job needs access to</value>
        [DataMember(Name = "lusidApis", EmitDefaultValue = true)]
        public List<string> LusidApis { get; set; }

        /// <summary>
        /// List of S3 bucket or folder names that the job can access
        /// </summary>
        /// <value>List of S3 bucket or folder names that the job can access</value>
        [DataMember(Name = "lusidFileSystem", EmitDefaultValue = true)]
        public List<string> LusidFileSystem { get; set; }

        /// <summary>
        /// External URLs that the job can call
        /// </summary>
        /// <value>External URLs that the job can call</value>
        [DataMember(Name = "externalCalls", EmitDefaultValue = true)]
        public List<string> ExternalCalls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequiredResources {\n");
            sb.Append("  LusidApis: ").Append(LusidApis).Append("\n");
            sb.Append("  LusidFileSystem: ").Append(LusidFileSystem).Append("\n");
            sb.Append("  ExternalCalls: ").Append(ExternalCalls).Append("\n");
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
            return this.Equals(input as RequiredResources);
        }

        /// <summary>
        /// Returns true if RequiredResources instances are equal
        /// </summary>
        /// <param name="input">Instance of RequiredResources to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequiredResources input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LusidApis == input.LusidApis ||
                    this.LusidApis != null &&
                    input.LusidApis != null &&
                    this.LusidApis.SequenceEqual(input.LusidApis)
                ) && 
                (
                    this.LusidFileSystem == input.LusidFileSystem ||
                    this.LusidFileSystem != null &&
                    input.LusidFileSystem != null &&
                    this.LusidFileSystem.SequenceEqual(input.LusidFileSystem)
                ) && 
                (
                    this.ExternalCalls == input.ExternalCalls ||
                    this.ExternalCalls != null &&
                    input.ExternalCalls != null &&
                    this.ExternalCalls.SequenceEqual(input.ExternalCalls)
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
                if (this.LusidApis != null)
                    hashCode = hashCode * 59 + this.LusidApis.GetHashCode();
                if (this.LusidFileSystem != null)
                    hashCode = hashCode * 59 + this.LusidFileSystem.GetHashCode();
                if (this.ExternalCalls != null)
                    hashCode = hashCode * 59 + this.ExternalCalls.GetHashCode();
                return hashCode;
            }
        }

    }
}
