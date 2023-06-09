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
    /// ArchiveAttributesResponse PI_JSON
    /// </summary>
    [DataContract(Name = "pi_rest_archive_attributes")]
    public partial class PiRestArchiveAttributes : IEquatable<PiRestArchiveAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PiRestArchiveAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PiRestArchiveAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PiRestArchiveAttributes" /> class.
        /// </summary>
        /// <param name="archiveAttributes">ArchiveAttributes (required).</param>
        public PiRestArchiveAttributes(List<ArchiveAttribute> archiveAttributes = default(List<ArchiveAttribute>))
        {
            // to ensure "archiveAttributes" is required (not null)
            if (archiveAttributes == null)
            {
                throw new ArgumentNullException("archiveAttributes is a required property for PiRestArchiveAttributes and cannot be null");
            }
            this.ArchiveAttributes = archiveAttributes;
        }

        /// <summary>
        /// ArchiveAttributes
        /// </summary>
        /// <value>ArchiveAttributes</value>
        [DataMember(Name = "archiveAttributes", IsRequired = true, EmitDefaultValue = true)]
        public List<ArchiveAttribute> ArchiveAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PiRestArchiveAttributes {\n");
            sb.Append("  ArchiveAttributes: ").Append(ArchiveAttributes).Append("\n");
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
            return this.Equals(input as PiRestArchiveAttributes);
        }

        /// <summary>
        /// Returns true if PiRestArchiveAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of PiRestArchiveAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PiRestArchiveAttributes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ArchiveAttributes == input.ArchiveAttributes ||
                    this.ArchiveAttributes != null &&
                    input.ArchiveAttributes != null &&
                    this.ArchiveAttributes.SequenceEqual(input.ArchiveAttributes)
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
                if (this.ArchiveAttributes != null)
                {
                    hashCode = (hashCode * 59) + this.ArchiveAttributes.GetHashCode();
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
