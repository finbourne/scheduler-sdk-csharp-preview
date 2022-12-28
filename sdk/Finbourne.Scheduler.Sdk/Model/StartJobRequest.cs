/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.706
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
    /// Job start definition
    /// </summary>
    [DataContract(Name = "StartJobRequest")]
    public partial class StartJobRequest : IEquatable<StartJobRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartJobRequest" /> class.
        /// </summary>
        /// <param name="arguments">All arguments needed for the Job to run.</param>
        /// <param name="notifications">Notifications for this Job.</param>
        public StartJobRequest(Dictionary<string, string> arguments = default(Dictionary<string, string>), List<Notification> notifications = default(List<Notification>))
        {
            this.Arguments = arguments;
            this.Notifications = notifications;
        }

        /// <summary>
        /// All arguments needed for the Job to run
        /// </summary>
        /// <value>All arguments needed for the Job to run</value>
        [DataMember(Name = "arguments", EmitDefaultValue = true)]
        public Dictionary<string, string> Arguments { get; set; }

        /// <summary>
        /// Notifications for this Job
        /// </summary>
        /// <value>Notifications for this Job</value>
        [DataMember(Name = "notifications", EmitDefaultValue = true)]
        public List<Notification> Notifications { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartJobRequest {\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
            sb.Append("  Notifications: ").Append(Notifications).Append("\n");
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
            return this.Equals(input as StartJobRequest);
        }

        /// <summary>
        /// Returns true if StartJobRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StartJobRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartJobRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Arguments == input.Arguments ||
                    this.Arguments != null &&
                    input.Arguments != null &&
                    this.Arguments.SequenceEqual(input.Arguments)
                ) && 
                (
                    this.Notifications == input.Notifications ||
                    this.Notifications != null &&
                    input.Notifications != null &&
                    this.Notifications.SequenceEqual(input.Notifications)
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
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
                if (this.Notifications != null)
                    hashCode = hashCode * 59 + this.Notifications.GetHashCode();
                return hashCode;
            }
        }

    }
}
