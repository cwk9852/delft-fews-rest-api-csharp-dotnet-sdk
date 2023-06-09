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
    /// RatingCurve
    /// </summary>
    [DataContract(Name = "RatingCurve")]
    public partial class RatingCurve : IEquatable<RatingCurve>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RatingCurve" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RatingCurve() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RatingCurve" /> class.
        /// </summary>
        /// <param name="header">header (required).</param>
        /// <param name="table">table.</param>
        /// <param name="equations">equations.</param>
        public RatingCurve(RatingCurveHeader header = default(RatingCurveHeader), RatingCurveTable table = default(RatingCurveTable), List<RatingCurveEquation> equations = default(List<RatingCurveEquation>))
        {
            // to ensure "header" is required (not null)
            if (header == null)
            {
                throw new ArgumentNullException("header is a required property for RatingCurve and cannot be null");
            }
            this.Header = header;
            this.Table = table;
            this.Equations = equations;
        }

        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [DataMember(Name = "header", IsRequired = true, EmitDefaultValue = true)]
        public RatingCurveHeader Header { get; set; }

        /// <summary>
        /// Gets or Sets Table
        /// </summary>
        [DataMember(Name = "table", EmitDefaultValue = false)]
        public RatingCurveTable Table { get; set; }

        /// <summary>
        /// Gets or Sets Equations
        /// </summary>
        [DataMember(Name = "equations", EmitDefaultValue = false)]
        public List<RatingCurveEquation> Equations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RatingCurve {\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
            sb.Append("  Equations: ").Append(Equations).Append("\n");
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
            return this.Equals(input as RatingCurve);
        }

        /// <summary>
        /// Returns true if RatingCurve instances are equal
        /// </summary>
        /// <param name="input">Instance of RatingCurve to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RatingCurve input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Header == input.Header ||
                    (this.Header != null &&
                    this.Header.Equals(input.Header))
                ) && 
                (
                    this.Table == input.Table ||
                    (this.Table != null &&
                    this.Table.Equals(input.Table))
                ) && 
                (
                    this.Equations == input.Equations ||
                    this.Equations != null &&
                    input.Equations != null &&
                    this.Equations.SequenceEqual(input.Equations)
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
                if (this.Header != null)
                {
                    hashCode = (hashCode * 59) + this.Header.GetHashCode();
                }
                if (this.Table != null)
                {
                    hashCode = (hashCode * 59) + this.Table.GetHashCode();
                }
                if (this.Equations != null)
                {
                    hashCode = (hashCode * 59) + this.Equations.GetHashCode();
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
