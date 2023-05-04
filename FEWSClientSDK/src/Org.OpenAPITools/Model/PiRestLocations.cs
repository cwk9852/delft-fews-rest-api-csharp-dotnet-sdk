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
    /// LocationsResponse PI_JSON
    /// </summary>
    [DataContract(Name = "pi_rest_locations")]
    public partial class PiRestLocations : IEquatable<PiRestLocations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PiRestLocations" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PiRestLocations() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PiRestLocations" /> class.
        /// </summary>
        /// <param name="version">PI Version (required).</param>
        /// <param name="geoDatum">The geo datum (required).</param>
        /// <param name="locations">Locations (required).</param>
        public PiRestLocations(string version = default(string), string geoDatum = default(string), List<Location> locations = default(List<Location>))
        {
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new ArgumentNullException("version is a required property for PiRestLocations and cannot be null");
            }
            this._Version = version;
            // to ensure "geoDatum" is required (not null)
            if (geoDatum == null)
            {
                throw new ArgumentNullException("geoDatum is a required property for PiRestLocations and cannot be null");
            }
            this.GeoDatum = geoDatum;
            // to ensure "locations" is required (not null)
            if (locations == null)
            {
                throw new ArgumentNullException("locations is a required property for PiRestLocations and cannot be null");
            }
            this.Locations = locations;
        }

        /// <summary>
        /// PI Version
        /// </summary>
        /// <value>PI Version</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string _Version { get; set; }

        /// <summary>
        /// The geo datum
        /// </summary>
        /// <value>The geo datum</value>
        [DataMember(Name = "geoDatum", IsRequired = true, EmitDefaultValue = true)]
        public string GeoDatum { get; set; }

        /// <summary>
        /// Locations
        /// </summary>
        /// <value>Locations</value>
        [DataMember(Name = "locations", IsRequired = true, EmitDefaultValue = true)]
        public List<Location> Locations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PiRestLocations {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  GeoDatum: ").Append(GeoDatum).Append("\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
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
            return this.Equals(input as PiRestLocations);
        }

        /// <summary>
        /// Returns true if PiRestLocations instances are equal
        /// </summary>
        /// <param name="input">Instance of PiRestLocations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PiRestLocations input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.GeoDatum == input.GeoDatum ||
                    (this.GeoDatum != null &&
                    this.GeoDatum.Equals(input.GeoDatum))
                ) && 
                (
                    this.Locations == input.Locations ||
                    this.Locations != null &&
                    input.Locations != null &&
                    this.Locations.SequenceEqual(input.Locations)
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
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.GeoDatum != null)
                {
                    hashCode = (hashCode * 59) + this.GeoDatum.GetHashCode();
                }
                if (this.Locations != null)
                {
                    hashCode = (hashCode * 59) + this.Locations.GetHashCode();
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
