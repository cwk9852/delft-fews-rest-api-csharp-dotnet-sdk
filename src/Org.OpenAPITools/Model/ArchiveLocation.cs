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
    /// ArchiveLocation
    /// </summary>
    [DataContract(Name = "ArchiveLocation")]
    public partial class ArchiveLocation : IEquatable<ArchiveLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveLocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ArchiveLocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveLocation" /> class.
        /// </summary>
        /// <param name="locationId">locationId (required).</param>
        /// <param name="shortName">shortName.</param>
        /// <param name="lat">lat (required).</param>
        /// <param name="lon">lon (required).</param>
        public ArchiveLocation(string locationId = default(string), string shortName = default(string), string lat = default(string), string lon = default(string))
        {
            // to ensure "locationId" is required (not null)
            if (locationId == null)
            {
                throw new ArgumentNullException("locationId is a required property for ArchiveLocation and cannot be null");
            }
            this.LocationId = locationId;
            // to ensure "lat" is required (not null)
            if (lat == null)
            {
                throw new ArgumentNullException("lat is a required property for ArchiveLocation and cannot be null");
            }
            this.Lat = lat;
            // to ensure "lon" is required (not null)
            if (lon == null)
            {
                throw new ArgumentNullException("lon is a required property for ArchiveLocation and cannot be null");
            }
            this.Lon = lon;
            this.ShortName = shortName;
        }

        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name = "locationId", IsRequired = true, EmitDefaultValue = true)]
        public string LocationId { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name = "shortName", EmitDefaultValue = false)]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or Sets Lat
        /// </summary>
        [DataMember(Name = "lat", IsRequired = true, EmitDefaultValue = true)]
        public string Lat { get; set; }

        /// <summary>
        /// Gets or Sets Lon
        /// </summary>
        [DataMember(Name = "lon", IsRequired = true, EmitDefaultValue = true)]
        public string Lon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArchiveLocation {\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Lon: ").Append(Lon).Append("\n");
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
            return this.Equals(input as ArchiveLocation);
        }

        /// <summary>
        /// Returns true if ArchiveLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of ArchiveLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchiveLocation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && 
                (
                    this.Lat == input.Lat ||
                    (this.Lat != null &&
                    this.Lat.Equals(input.Lat))
                ) && 
                (
                    this.Lon == input.Lon ||
                    (this.Lon != null &&
                    this.Lon.Equals(input.Lon))
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
                if (this.LocationId != null)
                {
                    hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                }
                if (this.ShortName != null)
                {
                    hashCode = (hashCode * 59) + this.ShortName.GetHashCode();
                }
                if (this.Lat != null)
                {
                    hashCode = (hashCode * 59) + this.Lat.GetHashCode();
                }
                if (this.Lon != null)
                {
                    hashCode = (hashCode * 59) + this.Lon.GetHashCode();
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