/*
 * FINBOURNE Scheduler API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.586
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
    /// ScanSummary
    /// </summary>
    [DataContract(Name = "ScanSummary")]
    public partial class ScanSummary : IEquatable<ScanSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScanSummary" /> class.
        /// </summary>
        /// <param name="fixable">The number of vulnerabilities that have a known fix.</param>
        /// <param name="total">The total number of vulnerabilities.</param>
        /// <param name="critical">The number of Critical severity vulnerabilities.</param>
        /// <param name="high">The number of High severity vulnerabilities.</param>
        /// <param name="medium">The number of Medium severity vulnerabilities.</param>
        /// <param name="low">The number of Low severity vulnerabilities.</param>
        /// <param name="negligible">The number of Negligible severity vulnerabilities.</param>
        /// <param name="unknown">The number of Unknown severity vulnerabilities.</param>
        public ScanSummary(int? fixable = default(int?), int? total = default(int?), int? critical = default(int?), int? high = default(int?), int? medium = default(int?), int? low = default(int?), int? negligible = default(int?), int? unknown = default(int?))
        {
            this.Fixable = fixable;
            this.Total = total;
            this.Critical = critical;
            this.High = high;
            this.Medium = medium;
            this.Low = low;
            this.Negligible = negligible;
            this.Unknown = unknown;
        }

        /// <summary>
        /// The number of vulnerabilities that have a known fix
        /// </summary>
        /// <value>The number of vulnerabilities that have a known fix</value>
        [DataMember(Name = "fixable", EmitDefaultValue = true)]
        public int? Fixable { get; set; }

        /// <summary>
        /// The total number of vulnerabilities
        /// </summary>
        /// <value>The total number of vulnerabilities</value>
        [DataMember(Name = "total", EmitDefaultValue = true)]
        public int? Total { get; set; }

        /// <summary>
        /// The number of Critical severity vulnerabilities
        /// </summary>
        /// <value>The number of Critical severity vulnerabilities</value>
        [DataMember(Name = "critical", EmitDefaultValue = true)]
        public int? Critical { get; set; }

        /// <summary>
        /// The number of High severity vulnerabilities
        /// </summary>
        /// <value>The number of High severity vulnerabilities</value>
        [DataMember(Name = "high", EmitDefaultValue = true)]
        public int? High { get; set; }

        /// <summary>
        /// The number of Medium severity vulnerabilities
        /// </summary>
        /// <value>The number of Medium severity vulnerabilities</value>
        [DataMember(Name = "medium", EmitDefaultValue = true)]
        public int? Medium { get; set; }

        /// <summary>
        /// The number of Low severity vulnerabilities
        /// </summary>
        /// <value>The number of Low severity vulnerabilities</value>
        [DataMember(Name = "low", EmitDefaultValue = true)]
        public int? Low { get; set; }

        /// <summary>
        /// The number of Negligible severity vulnerabilities
        /// </summary>
        /// <value>The number of Negligible severity vulnerabilities</value>
        [DataMember(Name = "negligible", EmitDefaultValue = true)]
        public int? Negligible { get; set; }

        /// <summary>
        /// The number of Unknown severity vulnerabilities
        /// </summary>
        /// <value>The number of Unknown severity vulnerabilities</value>
        [DataMember(Name = "unknown", EmitDefaultValue = true)]
        public int? Unknown { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScanSummary {\n");
            sb.Append("  Fixable: ").Append(Fixable).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Critical: ").Append(Critical).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Medium: ").Append(Medium).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Negligible: ").Append(Negligible).Append("\n");
            sb.Append("  Unknown: ").Append(Unknown).Append("\n");
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
            return this.Equals(input as ScanSummary);
        }

        /// <summary>
        /// Returns true if ScanSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ScanSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScanSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fixable == input.Fixable ||
                    (this.Fixable != null &&
                    this.Fixable.Equals(input.Fixable))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Critical == input.Critical ||
                    (this.Critical != null &&
                    this.Critical.Equals(input.Critical))
                ) && 
                (
                    this.High == input.High ||
                    (this.High != null &&
                    this.High.Equals(input.High))
                ) && 
                (
                    this.Medium == input.Medium ||
                    (this.Medium != null &&
                    this.Medium.Equals(input.Medium))
                ) && 
                (
                    this.Low == input.Low ||
                    (this.Low != null &&
                    this.Low.Equals(input.Low))
                ) && 
                (
                    this.Negligible == input.Negligible ||
                    (this.Negligible != null &&
                    this.Negligible.Equals(input.Negligible))
                ) && 
                (
                    this.Unknown == input.Unknown ||
                    (this.Unknown != null &&
                    this.Unknown.Equals(input.Unknown))
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
                if (this.Fixable != null)
                    hashCode = hashCode * 59 + this.Fixable.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Critical != null)
                    hashCode = hashCode * 59 + this.Critical.GetHashCode();
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Medium != null)
                    hashCode = hashCode * 59 + this.Medium.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                if (this.Negligible != null)
                    hashCode = hashCode * 59 + this.Negligible.GetHashCode();
                if (this.Unknown != null)
                    hashCode = hashCode * 59 + this.Unknown.GetHashCode();
                return hashCode;
            }
        }

    }
}
