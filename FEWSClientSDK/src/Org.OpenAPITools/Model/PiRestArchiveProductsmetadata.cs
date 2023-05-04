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
    /// ArchiveProductsMetadataResponse PI_JSON
    /// </summary>
    [DataContract(Name = "pi_rest_archive_productsmetadata")]
    public partial class PiRestArchiveProductsmetadata : IEquatable<PiRestArchiveProductsmetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PiRestArchiveProductsmetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PiRestArchiveProductsmetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PiRestArchiveProductsmetadata" /> class.
        /// </summary>
        /// <param name="productsMetadata">Archive Products Metadata (required).</param>
        public PiRestArchiveProductsmetadata(List<ArchiveProductsMetadataEntry> productsMetadata = default(List<ArchiveProductsMetadataEntry>))
        {
            // to ensure "productsMetadata" is required (not null)
            if (productsMetadata == null)
            {
                throw new ArgumentNullException("productsMetadata is a required property for PiRestArchiveProductsmetadata and cannot be null");
            }
            this.ProductsMetadata = productsMetadata;
        }

        /// <summary>
        /// Archive Products Metadata
        /// </summary>
        /// <value>Archive Products Metadata</value>
        [DataMember(Name = "productsMetadata", IsRequired = true, EmitDefaultValue = true)]
        public List<ArchiveProductsMetadataEntry> ProductsMetadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PiRestArchiveProductsmetadata {\n");
            sb.Append("  ProductsMetadata: ").Append(ProductsMetadata).Append("\n");
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
            return this.Equals(input as PiRestArchiveProductsmetadata);
        }

        /// <summary>
        /// Returns true if PiRestArchiveProductsmetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of PiRestArchiveProductsmetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PiRestArchiveProductsmetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProductsMetadata == input.ProductsMetadata ||
                    this.ProductsMetadata != null &&
                    input.ProductsMetadata != null &&
                    this.ProductsMetadata.SequenceEqual(input.ProductsMetadata)
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
                if (this.ProductsMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.ProductsMetadata.GetHashCode();
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