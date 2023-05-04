/*
 * Delft-FEWS Web Services REST API v1
 *
 * Delft-FEWS Web Services REST API v1. For more information see: https://publicwiki.deltares.nl/x/fwNdBw
 *
 * The version of the OpenAPI document: v1-2023-05-03T00:04:18Z
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Domain Axis Event Array
    /// </summary>
    [DataContract(Name = "DomainAxisEvent")]
    public partial class DomainAxisEvent : IEquatable<DomainAxisEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainAxisEvent" /> class.
        /// </summary>
        /// <param name="date">Date.</param>
        /// <param name="time">Time.</param>
        /// <param name="flag">Flag.</param>
        /// <param name="values">array of arrays.</param>
        public DomainAxisEvent(string date = default(string), string time = default(string), string flag = default(string), List<List<string>> values = default(List<List<string>>))
        {
            this.Date = date;
            this.Time = time;
            this.Flag = flag;
            this.Values = values;
        }

        /// <summary>
        /// Date
        /// </summary>
        /// <value>Date</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public string Date { get; set; }

        /// <summary>
        /// Time
        /// </summary>
        /// <value>Time</value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        public string Time { get; set; }

        /// <summary>
        /// Flag
        /// </summary>
        /// <value>Flag</value>
        [DataMember(Name = "flag", EmitDefaultValue = false)]
        public string Flag { get; set; }

        /// <summary>
        /// array of arrays
        /// </summary>
        /// <value>array of arrays</value>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public List<List<string>> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DomainAxisEvent {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Flag: ").Append(Flag).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as DomainAxisEvent);
        }

        /// <summary>
        /// Returns true if DomainAxisEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainAxisEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainAxisEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Flag == input.Flag ||
                    (this.Flag != null &&
                    this.Flag.Equals(input.Flag))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.Time != null)
                {
                    hashCode = (hashCode * 59) + this.Time.GetHashCode();
                }
                if (this.Flag != null)
                {
                    hashCode = (hashCode * 59) + this.Flag.GetHashCode();
                }
                if (this.Values != null)
                {
                    hashCode = (hashCode * 59) + this.Values.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
