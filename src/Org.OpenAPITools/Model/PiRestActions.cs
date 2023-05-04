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
    /// ActionsResponse PI_JSON
    /// </summary>
    [DataContract(Name = "pi_rest_actions")]
    public partial class PiRestActions : IEquatable<PiRestActions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PiRestActions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PiRestActions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PiRestActions" /> class.
        /// </summary>
        /// <param name="resultsNotAvailableForRequest">resultsNotAvailableForRequest.</param>
        /// <param name="results">ActionsResults (required).</param>
        public PiRestActions(bool resultsNotAvailableForRequest = default(bool), List<ActionResult> results = default(List<ActionResult>))
        {
            // to ensure "results" is required (not null)
            if (results == null)
            {
                throw new ArgumentNullException("results is a required property for PiRestActions and cannot be null");
            }
            this.Results = results;
            this.ResultsNotAvailableForRequest = resultsNotAvailableForRequest;
        }

        /// <summary>
        /// Gets or Sets ResultsNotAvailableForRequest
        /// </summary>
        [DataMember(Name = "resultsNotAvailableForRequest", EmitDefaultValue = true)]
        public bool ResultsNotAvailableForRequest { get; set; }

        /// <summary>
        /// ActionsResults
        /// </summary>
        /// <value>ActionsResults</value>
        [DataMember(Name = "results", IsRequired = true, EmitDefaultValue = true)]
        public List<ActionResult> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PiRestActions {\n");
            sb.Append("  ResultsNotAvailableForRequest: ").Append(ResultsNotAvailableForRequest).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as PiRestActions);
        }

        /// <summary>
        /// Returns true if PiRestActions instances are equal
        /// </summary>
        /// <param name="input">Instance of PiRestActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PiRestActions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ResultsNotAvailableForRequest == input.ResultsNotAvailableForRequest ||
                    this.ResultsNotAvailableForRequest.Equals(input.ResultsNotAvailableForRequest)
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
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
                hashCode = (hashCode * 59) + this.ResultsNotAvailableForRequest.GetHashCode();
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
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