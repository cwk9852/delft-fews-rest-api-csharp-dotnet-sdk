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
    /// LocationRelation
    /// </summary>
    [DataContract(Name = "LocationRelation")]
    public partial class LocationRelation : IEquatable<LocationRelation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationRelation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LocationRelation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationRelation" /> class.
        /// </summary>
        /// <param name="id">Id.</param>
        /// <param name="relatedLocationId">Related Location Id (required).</param>
        /// <param name="startDateTime">Start date time.</param>
        /// <param name="endDateTime">End date time.</param>
        public LocationRelation(string id = default(string), string relatedLocationId = default(string), string startDateTime = default(string), string endDateTime = default(string))
        {
            // to ensure "relatedLocationId" is required (not null)
            if (relatedLocationId == null)
            {
                throw new ArgumentNullException("relatedLocationId is a required property for LocationRelation and cannot be null");
            }
            this.RelatedLocationId = relatedLocationId;
            this.Id = id;
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
        }

        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Related Location Id
        /// </summary>
        /// <value>Related Location Id</value>
        [DataMember(Name = "relatedLocationId", IsRequired = true, EmitDefaultValue = true)]
        public string RelatedLocationId { get; set; }

        /// <summary>
        /// Start date time
        /// </summary>
        /// <value>Start date time</value>
        [DataMember(Name = "startDateTime", EmitDefaultValue = false)]
        public string StartDateTime { get; set; }

        /// <summary>
        /// End date time
        /// </summary>
        /// <value>End date time</value>
        [DataMember(Name = "endDateTime", EmitDefaultValue = false)]
        public string EndDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LocationRelation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RelatedLocationId: ").Append(RelatedLocationId).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
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
            return this.Equals(input as LocationRelation);
        }

        /// <summary>
        /// Returns true if LocationRelation instances are equal
        /// </summary>
        /// <param name="input">Instance of LocationRelation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationRelation input)
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
                    this.RelatedLocationId == input.RelatedLocationId ||
                    (this.RelatedLocationId != null &&
                    this.RelatedLocationId.Equals(input.RelatedLocationId))
                ) && 
                (
                    this.StartDateTime == input.StartDateTime ||
                    (this.StartDateTime != null &&
                    this.StartDateTime.Equals(input.StartDateTime))
                ) && 
                (
                    this.EndDateTime == input.EndDateTime ||
                    (this.EndDateTime != null &&
                    this.EndDateTime.Equals(input.EndDateTime))
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
                if (this.RelatedLocationId != null)
                {
                    hashCode = (hashCode * 59) + this.RelatedLocationId.GetHashCode();
                }
                if (this.StartDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartDateTime.GetHashCode();
                }
                if (this.EndDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndDateTime.GetHashCode();
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