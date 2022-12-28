/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.707
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
    /// Holds different kinds of triggers  A schedule may only have one type of trigger
    /// </summary>
    [DataContract(Name = "Trigger")]
    public partial class Trigger : IEquatable<Trigger>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Trigger" /> class.
        /// </summary>
        /// <param name="timeTrigger">timeTrigger.</param>
        public Trigger(TimeTrigger timeTrigger = default(TimeTrigger))
        {
            this.TimeTrigger = timeTrigger;
        }

        /// <summary>
        /// Gets or Sets TimeTrigger
        /// </summary>
        [DataMember(Name = "timeTrigger", EmitDefaultValue = false)]
        public TimeTrigger TimeTrigger { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Trigger {\n");
            sb.Append("  TimeTrigger: ").Append(TimeTrigger).Append("\n");
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
            return this.Equals(input as Trigger);
        }

        /// <summary>
        /// Returns true if Trigger instances are equal
        /// </summary>
        /// <param name="input">Instance of Trigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Trigger input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimeTrigger == input.TimeTrigger ||
                    (this.TimeTrigger != null &&
                    this.TimeTrigger.Equals(input.TimeTrigger))
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
                if (this.TimeTrigger != null)
                    hashCode = hashCode * 59 + this.TimeTrigger.GetHashCode();
                return hashCode;
            }
        }

    }
}
