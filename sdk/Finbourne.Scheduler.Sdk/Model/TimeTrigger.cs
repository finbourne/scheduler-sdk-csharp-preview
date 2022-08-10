/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.600
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
    /// Time-based trigger
    /// </summary>
    [DataContract(Name = "TimeTrigger")]
    public partial class TimeTrigger : IEquatable<TimeTrigger>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeTrigger" /> class.
        /// </summary>
        /// <param name="expression">Cron expression.</param>
        public TimeTrigger(string expression = default(string))
        {
            this.Expression = expression;
        }

        /// <summary>
        /// Cron expression
        /// </summary>
        /// <value>Cron expression</value>
        [DataMember(Name = "expression", EmitDefaultValue = true)]
        public string Expression { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeTrigger {\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
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
            return this.Equals(input as TimeTrigger);
        }

        /// <summary>
        /// Returns true if TimeTrigger instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeTrigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeTrigger input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Expression == input.Expression ||
                    (this.Expression != null &&
                    this.Expression.Equals(input.Expression))
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
                if (this.Expression != null)
                    hashCode = hashCode * 59 + this.Expression.GetHashCode();
                return hashCode;
            }
        }

    }
}
