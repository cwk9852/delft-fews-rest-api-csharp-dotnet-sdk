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
    /// TimeSeriesParameter
    /// </summary>
    [DataContract(Name = "TimeSeriesParameter")]
    public partial class TimeSeriesParameter : IEquatable<TimeSeriesParameter>, IValidatableObject
    {
        /// <summary>
        /// Is a datum used
        /// </summary>
        /// <value>Is a datum used</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UsesDatumEnum
        {
            /// <summary>
            /// Enum True for value: true
            /// </summary>
            [EnumMember(Value = "true")]
            True = 1,

            /// <summary>
            /// Enum False for value: false
            /// </summary>
            [EnumMember(Value = "false")]
            False = 2

        }


        /// <summary>
        /// Is a datum used
        /// </summary>
        /// <value>Is a datum used</value>
        [DataMember(Name = "usesDatum", EmitDefaultValue = false)]
        public UsesDatumEnum? UsesDatum { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSeriesParameter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimeSeriesParameter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSeriesParameter" /> class.
        /// </summary>
        /// <param name="id">the id of the parameter (required).</param>
        /// <param name="name">The parameter name.</param>
        /// <param name="parameterType">The parameter type.</param>
        /// <param name="unit">The parameter unit.</param>
        /// <param name="displayUnit">The parameter display unit.</param>
        /// <param name="usesDatum">Is a datum used.</param>
        /// <param name="parameterGroup">The id of the parameter group this parameter is a member of.</param>
        /// <param name="parameterGroupName">The name of parameter group this parameter is a member of.</param>
        /// <param name="shortName">The parameter group this parameter is a member of.</param>
        /// <param name="attributes">Parameter Attributes.</param>
        public TimeSeriesParameter(string id = default(string), string name = default(string), string parameterType = default(string), string unit = default(string), string displayUnit = default(string), UsesDatumEnum? usesDatum = default(UsesDatumEnum?), string parameterGroup = default(string), string parameterGroupName = default(string), string shortName = default(string), List<TimeSeriesParameterAttributes> attributes = default(List<TimeSeriesParameterAttributes>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for TimeSeriesParameter and cannot be null");
            }
            this.Id = id;
            this.Name = name;
            this.ParameterType = parameterType;
            this.Unit = unit;
            this.DisplayUnit = displayUnit;
            this.UsesDatum = usesDatum;
            this.ParameterGroup = parameterGroup;
            this.ParameterGroupName = parameterGroupName;
            this.ShortName = shortName;
            this.Attributes = attributes;
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
        /// The parameter type
        /// </summary>
        /// <value>The parameter type</value>
        [DataMember(Name = "parameterType", EmitDefaultValue = false)]
        public string ParameterType { get; set; }

        /// <summary>
        /// The parameter unit
        /// </summary>
        /// <value>The parameter unit</value>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// The parameter display unit
        /// </summary>
        /// <value>The parameter display unit</value>
        [DataMember(Name = "displayUnit", EmitDefaultValue = false)]
        public string DisplayUnit { get; set; }

        /// <summary>
        /// The id of the parameter group this parameter is a member of
        /// </summary>
        /// <value>The id of the parameter group this parameter is a member of</value>
        [DataMember(Name = "parameterGroup", EmitDefaultValue = false)]
        public string ParameterGroup { get; set; }

        /// <summary>
        /// The name of parameter group this parameter is a member of
        /// </summary>
        /// <value>The name of parameter group this parameter is a member of</value>
        [DataMember(Name = "parameterGroupName", EmitDefaultValue = false)]
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// The parameter group this parameter is a member of
        /// </summary>
        /// <value>The parameter group this parameter is a member of</value>
        [DataMember(Name = "shortName", EmitDefaultValue = false)]
        public string ShortName { get; set; }

        /// <summary>
        /// Parameter Attributes
        /// </summary>
        /// <value>Parameter Attributes</value>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public List<TimeSeriesParameterAttributes> Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimeSeriesParameter {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParameterType: ").Append(ParameterType).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  DisplayUnit: ").Append(DisplayUnit).Append("\n");
            sb.Append("  UsesDatum: ").Append(UsesDatum).Append("\n");
            sb.Append("  ParameterGroup: ").Append(ParameterGroup).Append("\n");
            sb.Append("  ParameterGroupName: ").Append(ParameterGroupName).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(input as TimeSeriesParameter);
        }

        /// <summary>
        /// Returns true if TimeSeriesParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeSeriesParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeSeriesParameter input)
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
                    this.ParameterType == input.ParameterType ||
                    (this.ParameterType != null &&
                    this.ParameterType.Equals(input.ParameterType))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.DisplayUnit == input.DisplayUnit ||
                    (this.DisplayUnit != null &&
                    this.DisplayUnit.Equals(input.DisplayUnit))
                ) && 
                (
                    this.UsesDatum == input.UsesDatum ||
                    this.UsesDatum.Equals(input.UsesDatum)
                ) && 
                (
                    this.ParameterGroup == input.ParameterGroup ||
                    (this.ParameterGroup != null &&
                    this.ParameterGroup.Equals(input.ParameterGroup))
                ) && 
                (
                    this.ParameterGroupName == input.ParameterGroupName ||
                    (this.ParameterGroupName != null &&
                    this.ParameterGroupName.Equals(input.ParameterGroupName))
                ) && 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
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
                if (this.ParameterType != null)
                {
                    hashCode = (hashCode * 59) + this.ParameterType.GetHashCode();
                }
                if (this.Unit != null)
                {
                    hashCode = (hashCode * 59) + this.Unit.GetHashCode();
                }
                if (this.DisplayUnit != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayUnit.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UsesDatum.GetHashCode();
                if (this.ParameterGroup != null)
                {
                    hashCode = (hashCode * 59) + this.ParameterGroup.GetHashCode();
                }
                if (this.ParameterGroupName != null)
                {
                    hashCode = (hashCode * 59) + this.ParameterGroupName.GetHashCode();
                }
                if (this.ShortName != null)
                {
                    hashCode = (hashCode * 59) + this.ShortName.GetHashCode();
                }
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
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