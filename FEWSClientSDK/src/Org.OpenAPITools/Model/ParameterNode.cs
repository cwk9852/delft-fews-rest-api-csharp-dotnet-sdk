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
    /// ParameterNode
    /// </summary>
    [DataContract(Name = "parameterNode")]
    public partial class ParameterNode : IEquatable<ParameterNode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterNode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ParameterNode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterNode" /> class.
        /// </summary>
        /// <param name="id">the id of the parameter (required).</param>
        /// <param name="name">The parameter name.</param>
        /// <param name="description">The description.</param>
        /// <param name="parameters">Parameter Attributes.</param>
        /// <param name="children">Parameter Node Children.</param>
        /// <param name="parent">parent.</param>
        public ParameterNode(string id = default(string), string name = default(string), string description = default(string), List<ParameterNodeParameter> parameters = default(List<ParameterNodeParameter>), List<ParameterNodeChild> children = default(List<ParameterNodeChild>), ParameterNodeParent parent = default(ParameterNodeParent))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ParameterNode and cannot be null");
            }
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Parameters = parameters;
            this.Children = children;
            this.Parent = parent;
        }

        /// <summary>
        /// the id of the parameter
        /// </summary>
        /// <value>the id of the parameter</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The parameter name
        /// </summary>
        /// <value>The parameter name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The description
        /// </summary>
        /// <value>The description</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Parameter Attributes
        /// </summary>
        /// <value>Parameter Attributes</value>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<ParameterNodeParameter> Parameters { get; set; }

        /// <summary>
        /// Parameter Node Children
        /// </summary>
        /// <value>Parameter Node Children</value>
        [DataMember(Name = "children", EmitDefaultValue = false)]
        public List<ParameterNodeChild> Children { get; set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        public ParameterNodeParent Parent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ParameterNode {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
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
            return this.Equals(input as ParameterNode);
        }

        /// <summary>
        /// Returns true if ParameterNode instances are equal
        /// </summary>
        /// <param name="input">Instance of ParameterNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParameterNode input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Parameters != null)
                {
                    hashCode = (hashCode * 59) + this.Parameters.GetHashCode();
                }
                if (this.Children != null)
                {
                    hashCode = (hashCode * 59) + this.Children.GetHashCode();
                }
                if (this.Parent != null)
                {
                    hashCode = (hashCode * 59) + this.Parent.GetHashCode();
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