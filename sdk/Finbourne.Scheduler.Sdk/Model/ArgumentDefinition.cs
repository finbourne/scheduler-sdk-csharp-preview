/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.823
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
    /// Job argument definition
    /// </summary>
    [DataContract(Name = "ArgumentDefinition")]
    public partial class ArgumentDefinition : IEquatable<ArgumentDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ArgumentDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentDefinition" /> class.
        /// </summary>
        /// <param name="dataType">Data type of the argument (required).</param>
        /// <param name="required">Optionality of the argument.</param>
        /// <param name="description">Argument description (required).</param>
        /// <param name="order">The order of the argument (required).</param>
        /// <param name="constraints">Constrains of the argument value.</param>
        /// <param name="passedAs">Specifies how this argument should be passed in  Allowed values are: CommandLine or EnvironmentVariable    Defaults to: CommandLine (required).</param>
        /// <param name="defaultValue">Specify a default value for this argument if no value is provided  The value needs to be convertible to the associated data type.</param>
        public ArgumentDefinition(string dataType = default(string), bool required = default(bool), string description = default(string), int order = default(int), string constraints = default(string), string passedAs = default(string), string defaultValue = default(string))
        {
            // to ensure "dataType" is required (not null)
            this.DataType = dataType ?? throw new ArgumentNullException("dataType is a required property for ArgumentDefinition and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for ArgumentDefinition and cannot be null");
            this.Order = order;
            // to ensure "passedAs" is required (not null)
            this.PassedAs = passedAs ?? throw new ArgumentNullException("passedAs is a required property for ArgumentDefinition and cannot be null");
            this.Required = required;
            this.Constraints = constraints;
            this.DefaultValue = defaultValue;
        }

        /// <summary>
        /// Data type of the argument
        /// </summary>
        /// <value>Data type of the argument</value>
        [DataMember(Name = "dataType", IsRequired = true, EmitDefaultValue = false)]
        public string DataType { get; set; }

        /// <summary>
        /// Optionality of the argument
        /// </summary>
        /// <value>Optionality of the argument</value>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// Argument description
        /// </summary>
        /// <value>Argument description</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The order of the argument
        /// </summary>
        /// <value>The order of the argument</value>
        [DataMember(Name = "order", IsRequired = true, EmitDefaultValue = true)]
        public int Order { get; set; }

        /// <summary>
        /// Constrains of the argument value
        /// </summary>
        /// <value>Constrains of the argument value</value>
        [DataMember(Name = "constraints", EmitDefaultValue = true)]
        public string Constraints { get; set; }

        /// <summary>
        /// Specifies how this argument should be passed in  Allowed values are: CommandLine or EnvironmentVariable    Defaults to: CommandLine
        /// </summary>
        /// <value>Specifies how this argument should be passed in  Allowed values are: CommandLine or EnvironmentVariable    Defaults to: CommandLine</value>
        [DataMember(Name = "passedAs", IsRequired = true, EmitDefaultValue = false)]
        public string PassedAs { get; set; }

        /// <summary>
        /// Specify a default value for this argument if no value is provided  The value needs to be convertible to the associated data type
        /// </summary>
        /// <value>Specify a default value for this argument if no value is provided  The value needs to be convertible to the associated data type</value>
        [DataMember(Name = "defaultValue", EmitDefaultValue = true)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArgumentDefinition {\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Constraints: ").Append(Constraints).Append("\n");
            sb.Append("  PassedAs: ").Append(PassedAs).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
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
            return this.Equals(input as ArgumentDefinition);
        }

        /// <summary>
        /// Returns true if ArgumentDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of ArgumentDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArgumentDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.Required == input.Required ||
                    this.Required.Equals(input.Required)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.Constraints == input.Constraints ||
                    (this.Constraints != null &&
                    this.Constraints.Equals(input.Constraints))
                ) && 
                (
                    this.PassedAs == input.PassedAs ||
                    (this.PassedAs != null &&
                    this.PassedAs.Equals(input.PassedAs))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
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
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Constraints != null)
                    hashCode = hashCode * 59 + this.Constraints.GetHashCode();
                if (this.PassedAs != null)
                    hashCode = hashCode * 59 + this.PassedAs.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                return hashCode;
            }
        }

    }
}
