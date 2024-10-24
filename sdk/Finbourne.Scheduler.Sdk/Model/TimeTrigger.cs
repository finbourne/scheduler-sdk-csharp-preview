/*
 * FINBOURNE Scheduler API
 *
 *  Scheduler is a job automation tool for LUSID. You can write code to perform operations, create jobs with container images, and schedule them to run automatically.  ### Error Codes  | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"152\">152</a>|Action Execution Failure|  | | <a name=\"157\">157</a>|Invalid Request|  | | <a name=\"186\">186</a>|Access Denied|  | | <a name=\"187\">187</a>|Invalid Identity Token|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"704\">704</a>|Cannot Delete Job|  | | <a name=\"731\">731</a>|Unable to process images associated with request.|  | | <a name=\"756\">756</a>|Image Scan Failure|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | 
 *
 * The version of the OpenAPI document: 0.0.944
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
        /// <param name="timeZone">Time zone of the Cron expression. If not provided, defaults to UTC.</param>
        public TimeTrigger(string expression = default(string), string timeZone = default(string))
        {
            this.Expression = expression;
            this.TimeZone = timeZone;
        }

        /// <summary>
        /// Cron expression
        /// </summary>
        /// <value>Cron expression</value>
        [DataMember(Name = "expression", EmitDefaultValue = true)]
        public string Expression { get; set; }

        /// <summary>
        /// Time zone of the Cron expression. If not provided, defaults to UTC
        /// </summary>
        /// <value>Time zone of the Cron expression. If not provided, defaults to UTC</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = true)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeTrigger {\n");
            sb.Append("  Expression: ").Append(Expression).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
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
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                return hashCode;
            }
        }

    }
}
