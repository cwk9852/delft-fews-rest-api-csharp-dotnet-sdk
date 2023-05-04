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
    /// TimeSeriesEnsemblesMembers PI_JSON
    /// </summary>
    [DataContract(Name = "pi_rest_timeseries_ensembles_members")]
    public partial class PiRestTimeseriesEnsemblesMembers : IEquatable<PiRestTimeseriesEnsemblesMembers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PiRestTimeseriesEnsemblesMembers" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PiRestTimeseriesEnsemblesMembers() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PiRestTimeseriesEnsemblesMembers" /> class.
        /// </summary>
        /// <param name="ensembles">Ensemble Members (required).</param>
        public PiRestTimeseriesEnsemblesMembers(List<TimeSeriesEnsembleMember> ensembles = default(List<TimeSeriesEnsembleMember>))
        {
            // to ensure "ensembles" is required (not null)
            if (ensembles == null)
            {
                throw new ArgumentNullException("ensembles is a required property for PiRestTimeseriesEnsemblesMembers and cannot be null");
            }
            this.Ensembles = ensembles;
        }

        /// <summary>
        /// Ensemble Members
        /// </summary>
        /// <value>Ensemble Members</value>
        [DataMember(Name = "ensembles", IsRequired = true, EmitDefaultValue = true)]
        public List<TimeSeriesEnsembleMember> Ensembles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PiRestTimeseriesEnsemblesMembers {\n");
            sb.Append("  Ensembles: ").Append(Ensembles).Append("\n");
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
            return this.Equals(input as PiRestTimeseriesEnsemblesMembers);
        }

        /// <summary>
        /// Returns true if PiRestTimeseriesEnsemblesMembers instances are equal
        /// </summary>
        /// <param name="input">Instance of PiRestTimeseriesEnsemblesMembers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PiRestTimeseriesEnsemblesMembers input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ensembles == input.Ensembles ||
                    this.Ensembles != null &&
                    input.Ensembles != null &&
                    this.Ensembles.SequenceEqual(input.Ensembles)
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
                if (this.Ensembles != null)
                {
                    hashCode = (hashCode * 59) + this.Ensembles.GetHashCode();
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
