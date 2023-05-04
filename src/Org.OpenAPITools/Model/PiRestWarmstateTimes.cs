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
    /// WarmStateTimesResponse PI_JSON
    /// </summary>
    [DataContract(Name = "pi_rest_warmstate_times")]
    public partial class PiRestWarmstateTimes : IEquatable<PiRestWarmstateTimes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PiRestWarmstateTimes" /> class.
        /// </summary>
        /// <param name="warmStateTimes">warmStateTimes.</param>
        public PiRestWarmstateTimes(List<WarmStateTime> warmStateTimes = default(List<WarmStateTime>))
        {
            this.WarmStateTimes = warmStateTimes;
        }

        /// <summary>
        /// Gets or Sets WarmStateTimes
        /// </summary>
        [DataMember(Name = "warmStateTimes", EmitDefaultValue = false)]
        public List<WarmStateTime> WarmStateTimes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PiRestWarmstateTimes {\n");
            sb.Append("  WarmStateTimes: ").Append(WarmStateTimes).Append("\n");
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
            return this.Equals(input as PiRestWarmstateTimes);
        }

        /// <summary>
        /// Returns true if PiRestWarmstateTimes instances are equal
        /// </summary>
        /// <param name="input">Instance of PiRestWarmstateTimes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PiRestWarmstateTimes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WarmStateTimes == input.WarmStateTimes ||
                    this.WarmStateTimes != null &&
                    input.WarmStateTimes != null &&
                    this.WarmStateTimes.SequenceEqual(input.WarmStateTimes)
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
                if (this.WarmStateTimes != null)
                {
                    hashCode = (hashCode * 59) + this.WarmStateTimes.GetHashCode();
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