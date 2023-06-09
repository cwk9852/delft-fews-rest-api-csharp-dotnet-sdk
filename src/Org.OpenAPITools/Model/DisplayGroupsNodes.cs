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
    /// DisplayGroupsNodes
    /// </summary>
    [DataContract(Name = "DisplayGroupsNodes")]
    public partial class DisplayGroupsNodes : IEquatable<DisplayGroupsNodes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayGroupsNodes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DisplayGroupsNodes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayGroupsNodes" /> class.
        /// </summary>
        /// <param name="displayGroupId">displayGroupId (required).</param>
        /// <param name="plotNodes">DisplayGroupsPlotNode.</param>
        /// <param name="displayGroups">DisplayGroupsPlotNode.</param>
        public DisplayGroupsNodes(string displayGroupId = default(string), List<DisplayGroupsPlotNode> plotNodes = default(List<DisplayGroupsPlotNode>), List<DisplayGroupsNodes> displayGroups = default(List<DisplayGroupsNodes>))
        {
            // to ensure "displayGroupId" is required (not null)
            if (displayGroupId == null)
            {
                throw new ArgumentNullException("displayGroupId is a required property for DisplayGroupsNodes and cannot be null");
            }
            this.DisplayGroupId = displayGroupId;
            this.PlotNodes = plotNodes;
            this.DisplayGroups = displayGroups;
        }

        /// <summary>
        /// Gets or Sets DisplayGroupId
        /// </summary>
        [DataMember(Name = "displayGroupId", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayGroupId { get; set; }

        /// <summary>
        /// DisplayGroupsPlotNode
        /// </summary>
        /// <value>DisplayGroupsPlotNode</value>
        [DataMember(Name = "plotNodes", EmitDefaultValue = false)]
        public List<DisplayGroupsPlotNode> PlotNodes { get; set; }

        /// <summary>
        /// DisplayGroupsPlotNode
        /// </summary>
        /// <value>DisplayGroupsPlotNode</value>
        [DataMember(Name = "displayGroups", EmitDefaultValue = false)]
        public List<DisplayGroupsNodes> DisplayGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DisplayGroupsNodes {\n");
            sb.Append("  DisplayGroupId: ").Append(DisplayGroupId).Append("\n");
            sb.Append("  PlotNodes: ").Append(PlotNodes).Append("\n");
            sb.Append("  DisplayGroups: ").Append(DisplayGroups).Append("\n");
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
            return this.Equals(input as DisplayGroupsNodes);
        }

        /// <summary>
        /// Returns true if DisplayGroupsNodes instances are equal
        /// </summary>
        /// <param name="input">Instance of DisplayGroupsNodes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisplayGroupsNodes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayGroupId == input.DisplayGroupId ||
                    (this.DisplayGroupId != null &&
                    this.DisplayGroupId.Equals(input.DisplayGroupId))
                ) && 
                (
                    this.PlotNodes == input.PlotNodes ||
                    this.PlotNodes != null &&
                    input.PlotNodes != null &&
                    this.PlotNodes.SequenceEqual(input.PlotNodes)
                ) && 
                (
                    this.DisplayGroups == input.DisplayGroups ||
                    this.DisplayGroups != null &&
                    input.DisplayGroups != null &&
                    this.DisplayGroups.SequenceEqual(input.DisplayGroups)
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
                if (this.DisplayGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayGroupId.GetHashCode();
                }
                if (this.PlotNodes != null)
                {
                    hashCode = (hashCode * 59) + this.PlotNodes.GetHashCode();
                }
                if (this.DisplayGroups != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayGroups.GetHashCode();
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
