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
    /// TopologyNode
    /// </summary>
    [DataContract(Name = "TopologyNode")]
    public partial class TopologyNode : IEquatable<TopologyNode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopologyNode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TopologyNode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TopologyNode" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="workflowId">workflowId.</param>
        /// <param name="localRun">localRun.</param>
        /// <param name="url">url.</param>
        /// <param name="displayId">displayId.</param>
        /// <param name="displayGroups">Display group item.</param>
        /// <param name="topologyNodes">TopologyNodes.</param>
        public TopologyNode(string id = default(string), string name = default(string), string workflowId = default(string), bool localRun = default(bool), string url = default(string), string displayId = default(string), List<TopologyDisplayGroupItem> displayGroups = default(List<TopologyDisplayGroupItem>), List<TopologyNode> topologyNodes = default(List<TopologyNode>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for TopologyNode and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TopologyNode and cannot be null");
            }
            this.Name = name;
            this.WorkflowId = workflowId;
            this.LocalRun = localRun;
            this.Url = url;
            this.DisplayId = displayId;
            this.DisplayGroups = displayGroups;
            this.TopologyNodes = topologyNodes;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowId
        /// </summary>
        [DataMember(Name = "workflowId", EmitDefaultValue = false)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// Gets or Sets LocalRun
        /// </summary>
        [DataMember(Name = "localRun", EmitDefaultValue = true)]
        public bool LocalRun { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets DisplayId
        /// </summary>
        [DataMember(Name = "displayId", EmitDefaultValue = false)]
        public string DisplayId { get; set; }

        /// <summary>
        /// Display group item
        /// </summary>
        /// <value>Display group item</value>
        [DataMember(Name = "displayGroups", EmitDefaultValue = false)]
        public List<TopologyDisplayGroupItem> DisplayGroups { get; set; }

        /// <summary>
        /// TopologyNodes
        /// </summary>
        /// <value>TopologyNodes</value>
        [DataMember(Name = "topologyNodes", EmitDefaultValue = false)]
        public List<TopologyNode> TopologyNodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TopologyNode {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  LocalRun: ").Append(LocalRun).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  DisplayId: ").Append(DisplayId).Append("\n");
            sb.Append("  DisplayGroups: ").Append(DisplayGroups).Append("\n");
            sb.Append("  TopologyNodes: ").Append(TopologyNodes).Append("\n");
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
            return this.Equals(input as TopologyNode);
        }

        /// <summary>
        /// Returns true if TopologyNode instances are equal
        /// </summary>
        /// <param name="input">Instance of TopologyNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopologyNode input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.WorkflowId == input.WorkflowId ||
                    (this.WorkflowId != null &&
                    this.WorkflowId.Equals(input.WorkflowId))
                ) && 
                (
                    this.LocalRun == input.LocalRun ||
                    this.LocalRun.Equals(input.LocalRun)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.DisplayId == input.DisplayId ||
                    (this.DisplayId != null &&
                    this.DisplayId.Equals(input.DisplayId))
                ) && 
                (
                    this.DisplayGroups == input.DisplayGroups ||
                    this.DisplayGroups != null &&
                    input.DisplayGroups != null &&
                    this.DisplayGroups.SequenceEqual(input.DisplayGroups)
                ) && 
                (
                    this.TopologyNodes == input.TopologyNodes ||
                    this.TopologyNodes != null &&
                    input.TopologyNodes != null &&
                    this.TopologyNodes.SequenceEqual(input.TopologyNodes)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.WorkflowId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LocalRun.GetHashCode();
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.DisplayId != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayId.GetHashCode();
                }
                if (this.DisplayGroups != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayGroups.GetHashCode();
                }
                if (this.TopologyNodes != null)
                {
                    hashCode = (hashCode * 59) + this.TopologyNodes.GetHashCode();
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