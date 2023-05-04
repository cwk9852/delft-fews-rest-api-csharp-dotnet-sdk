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
    /// DomainAxis
    /// </summary>
    [DataContract(Name = "DomainAxis")]
    public partial class DomainAxis : IEquatable<DomainAxis>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainAxis" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DomainAxis() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainAxis" /> class.
        /// </summary>
        /// <param name="parameterId">Parameter Id (required).</param>
        /// <param name="units">Units.</param>
        public DomainAxis(string parameterId = default(string), string units = default(string))
        {
            // to ensure "parameterId" is required (not null)
            if (parameterId == null)
            {
                throw new ArgumentNullException("parameterId is a required property for DomainAxis and cannot be null");
            }
            this.ParameterId = parameterId;
            this.Units = units;
        }

        /// <summary>
        /// Parameter Id
        /// </summary>
        /// <value>Parameter Id</value>
        [DataMember(Name = "parameterId", IsRequired = true, EmitDefaultValue = true)]
        public string ParameterId { get; set; }

        /// <summary>
        /// Units
        /// </summary>
        /// <value>Units</value>
        [DataMember(Name = "units", EmitDefaultValue = false)]
        public string Units { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DomainAxis {\n");
            sb.Append("  ParameterId: ").Append(ParameterId).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
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
            return this.Equals(input as DomainAxis);
        }

        /// <summary>
        /// Returns true if DomainAxis instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainAxis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainAxis input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ParameterId == input.ParameterId ||
                    (this.ParameterId != null &&
                    this.ParameterId.Equals(input.ParameterId))
                ) && 
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
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
                if (this.ParameterId != null)
                {
                    hashCode = (hashCode * 59) + this.ParameterId.GetHashCode();
                }
                if (this.Units != null)
                {
                    hashCode = (hashCode * 59) + this.Units.GetHashCode();
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
