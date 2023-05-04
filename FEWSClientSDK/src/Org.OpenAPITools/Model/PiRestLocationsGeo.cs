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
    /// LocationsResponse GEO_JSON
    /// </summary>
    [DataContract(Name = "pi_rest_locations.geo")]
    public partial class PiRestLocationsGeo : IEquatable<PiRestLocationsGeo>, IValidatableObject
    {
        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum FeatureCollection for value: FeatureCollection
            /// </summary>
            [EnumMember(Value = "FeatureCollection")]
            FeatureCollection = 1

        }


        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PiRestLocationsGeo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PiRestLocationsGeo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PiRestLocationsGeo" /> class.
        /// </summary>
        /// <param name="type">Type (required).</param>
        /// <param name="crs">The geo datum (required).</param>
        /// <param name="features">LocationGeoJsonFeatures (required).</param>
        public PiRestLocationsGeo(TypeEnum type = default(TypeEnum), LocationGeoJsonCrs crs = default(LocationGeoJsonCrs), List<LocationGeoJsonFeature> features = default(List<LocationGeoJsonFeature>))
        {
            this.Type = type;
            // to ensure "crs" is required (not null)
            if (crs == null)
            {
                throw new ArgumentNullException("crs is a required property for PiRestLocationsGeo and cannot be null");
            }
            this.Crs = crs;
            // to ensure "features" is required (not null)
            if (features == null)
            {
                throw new ArgumentNullException("features is a required property for PiRestLocationsGeo and cannot be null");
            }
            this.Features = features;
        }

        /// <summary>
        /// The geo datum
        /// </summary>
        /// <value>The geo datum</value>
        [DataMember(Name = "crs", IsRequired = true, EmitDefaultValue = true)]
        public LocationGeoJsonCrs Crs { get; set; }

        /// <summary>
        /// LocationGeoJsonFeatures
        /// </summary>
        /// <value>LocationGeoJsonFeatures</value>
        [DataMember(Name = "features", IsRequired = true, EmitDefaultValue = true)]
        public List<LocationGeoJsonFeature> Features { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PiRestLocationsGeo {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Crs: ").Append(Crs).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
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
            return this.Equals(input as PiRestLocationsGeo);
        }

        /// <summary>
        /// Returns true if PiRestLocationsGeo instances are equal
        /// </summary>
        /// <param name="input">Instance of PiRestLocationsGeo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PiRestLocationsGeo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Crs == input.Crs ||
                    (this.Crs != null &&
                    this.Crs.Equals(input.Crs))
                ) && 
                (
                    this.Features == input.Features ||
                    this.Features != null &&
                    input.Features != null &&
                    this.Features.SequenceEqual(input.Features)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Crs != null)
                {
                    hashCode = (hashCode * 59) + this.Crs.GetHashCode();
                }
                if (this.Features != null)
                {
                    hashCode = (hashCode * 59) + this.Features.GetHashCode();
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