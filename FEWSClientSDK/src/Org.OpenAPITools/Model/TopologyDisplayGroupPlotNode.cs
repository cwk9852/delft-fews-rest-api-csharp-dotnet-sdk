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
    /// TopologyDisplayGroupPlotNode
    /// </summary>
    [DataContract(Name = "TopologyDisplayGroupPlotNode")]
    public partial class TopologyDisplayGroupPlotNode : IEquatable<TopologyDisplayGroupPlotNode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopologyDisplayGroupPlotNode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TopologyDisplayGroupPlotNode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TopologyDisplayGroupPlotNode" /> class.
        /// </summary>
        /// <param name="displayId">displayId (required).</param>
        /// <param name="displayName">displayName.</param>
        public TopologyDisplayGroupPlotNode(string displayId = default(string), string displayName = default(string))
        {
            // to ensure "displayId" is required (not null)
            if (displayId == null)
            {
                throw new ArgumentNullException("displayId is a required property for TopologyDisplayGroupPlotNode and cannot be null");
            }
            this.DisplayId = displayId;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Gets or Sets DisplayId
        /// </summary>
        [DataMember(Name = "displayId", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayId { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TopologyDisplayGroupPlotNode {\n");
            sb.Append("  DisplayId: ").Append(DisplayId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
            return this.Equals(input as TopologyDisplayGroupPlotNode);
        }

        /// <summary>
        /// Returns true if TopologyDisplayGroupPlotNode instances are equal
        /// </summary>
        /// <param name="input">Instance of TopologyDisplayGroupPlotNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopologyDisplayGroupPlotNode input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayId == input.DisplayId ||
                    (this.DisplayId != null &&
                    this.DisplayId.Equals(input.DisplayId))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                if (this.DisplayId != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayId.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
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