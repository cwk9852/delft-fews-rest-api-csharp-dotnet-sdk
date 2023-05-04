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
    /// ActionRequestConfig
    /// </summary>
    [DataContract(Name = "ActionRequestConfig")]
    public partial class ActionRequestConfig : IEquatable<ActionRequestConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionRequestConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActionRequestConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionRequestConfig" /> class.
        /// </summary>
        /// <param name="timeSeriesDisplay">timeSeriesDisplay (required).</param>
        public ActionRequestConfig(TimeSeriesDisplayConfig timeSeriesDisplay = default(TimeSeriesDisplayConfig))
        {
            // to ensure "timeSeriesDisplay" is required (not null)
            if (timeSeriesDisplay == null)
            {
                throw new ArgumentNullException("timeSeriesDisplay is a required property for ActionRequestConfig and cannot be null");
            }
            this.TimeSeriesDisplay = timeSeriesDisplay;
        }

        /// <summary>
        /// Gets or Sets TimeSeriesDisplay
        /// </summary>
        [DataMember(Name = "timeSeriesDisplay", IsRequired = true, EmitDefaultValue = true)]
        public TimeSeriesDisplayConfig TimeSeriesDisplay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActionRequestConfig {\n");
            sb.Append("  TimeSeriesDisplay: ").Append(TimeSeriesDisplay).Append("\n");
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
            return this.Equals(input as ActionRequestConfig);
        }

        /// <summary>
        /// Returns true if ActionRequestConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ActionRequestConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionRequestConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TimeSeriesDisplay == input.TimeSeriesDisplay ||
                    (this.TimeSeriesDisplay != null &&
                    this.TimeSeriesDisplay.Equals(input.TimeSeriesDisplay))
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
                if (this.TimeSeriesDisplay != null)
                {
                    hashCode = (hashCode * 59) + this.TimeSeriesDisplay.GetHashCode();
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