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
    /// TimeStepOneOf2
    /// </summary>
    [DataContract(Name = "TimeStep_oneOf_2")]
    public partial class TimeStepOneOf2 : IEquatable<TimeStepOneOf2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeStepOneOf2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimeStepOneOf2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeStepOneOf2" /> class.
        /// </summary>
        /// <param name="minutes">Minutes (required).</param>
        public TimeStepOneOf2(string minutes = default(string))
        {
            // to ensure "minutes" is required (not null)
            if (minutes == null)
            {
                throw new ArgumentNullException("minutes is a required property for TimeStepOneOf2 and cannot be null");
            }
            this.Minutes = minutes;
        }

        /// <summary>
        /// Minutes
        /// </summary>
        /// <value>Minutes</value>
        [DataMember(Name = "minutes", IsRequired = true, EmitDefaultValue = true)]
        public string Minutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimeStepOneOf2 {\n");
            sb.Append("  Minutes: ").Append(Minutes).Append("\n");
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
            return this.Equals(input as TimeStepOneOf2);
        }

        /// <summary>
        /// Returns true if TimeStepOneOf2 instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeStepOneOf2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeStepOneOf2 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Minutes == input.Minutes ||
                    (this.Minutes != null &&
                    this.Minutes.Equals(input.Minutes))
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
                if (this.Minutes != null)
                {
                    hashCode = (hashCode * 59) + this.Minutes.GetHashCode();
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