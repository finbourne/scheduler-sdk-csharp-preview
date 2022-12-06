/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.681
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
    /// Notification type
    /// </summary>
    [DataContract(Name = "Notification")]
    public partial class Notification : IEquatable<Notification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        /// <param name="transport">The type of the notification.</param>
        /// <param name="destination">Where the notification should be sent.</param>
        public Notification(string transport = default(string), List<string> destination = default(List<string>))
        {
            this.Transport = transport;
            this.Destination = destination;
        }

        /// <summary>
        /// Condition for the notification
        /// </summary>
        /// <value>Condition for the notification</value>
        [DataMember(Name = "fireOn", EmitDefaultValue = true)]
        public string FireOn { get; private set; }

        /// <summary>
        /// Returns false as FireOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFireOn()
        {
            return false;
        }

        /// <summary>
        /// The type of the notification
        /// </summary>
        /// <value>The type of the notification</value>
        [DataMember(Name = "transport", EmitDefaultValue = true)]
        public string Transport { get; set; }

        /// <summary>
        /// Where the notification should be sent
        /// </summary>
        /// <value>Where the notification should be sent</value>
        [DataMember(Name = "destination", EmitDefaultValue = true)]
        public List<string> Destination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notification {\n");
            sb.Append("  FireOn: ").Append(FireOn).Append("\n");
            sb.Append("  Transport: ").Append(Transport).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
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
            return this.Equals(input as Notification);
        }

        /// <summary>
        /// Returns true if Notification instances are equal
        /// </summary>
        /// <param name="input">Instance of Notification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FireOn == input.FireOn ||
                    (this.FireOn != null &&
                    this.FireOn.Equals(input.FireOn))
                ) && 
                (
                    this.Transport == input.Transport ||
                    (this.Transport != null &&
                    this.Transport.Equals(input.Transport))
                ) && 
                (
                    this.Destination == input.Destination ||
                    this.Destination != null &&
                    input.Destination != null &&
                    this.Destination.SequenceEqual(input.Destination)
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
                if (this.FireOn != null)
                    hashCode = hashCode * 59 + this.FireOn.GetHashCode();
                if (this.Transport != null)
                    hashCode = hashCode * 59 + this.Transport.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                return hashCode;
            }
        }

    }
}
