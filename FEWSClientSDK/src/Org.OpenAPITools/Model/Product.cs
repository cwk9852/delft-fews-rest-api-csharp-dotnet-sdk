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
    /// Date
    /// </summary>
    [DataContract(Name = "Product")]
    public partial class Product : IEquatable<Product>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Product() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        /// <param name="id">Id (required).</param>
        /// <param name="name">Name (required).</param>
        /// <param name="productDate">Product Date (required).</param>
        /// <param name="productTime">Product Time (required).</param>
        /// <param name="category">category (required).</param>
        /// <param name="productInfo">Product Info.</param>
        public Product(string id = default(string), string name = default(string), string productDate = default(string), string productTime = default(string), ProductCategory category = default(ProductCategory), List<Object> productInfo = default(List<Object>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Product and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Product and cannot be null");
            }
            this.Name = name;
            // to ensure "productDate" is required (not null)
            if (productDate == null)
            {
                throw new ArgumentNullException("productDate is a required property for Product and cannot be null");
            }
            this.ProductDate = productDate;
            // to ensure "productTime" is required (not null)
            if (productTime == null)
            {
                throw new ArgumentNullException("productTime is a required property for Product and cannot be null");
            }
            this.ProductTime = productTime;
            // to ensure "category" is required (not null)
            if (category == null)
            {
                throw new ArgumentNullException("category is a required property for Product and cannot be null");
            }
            this.Category = category;
            this.ProductInfo = productInfo;
        }

        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Product Date
        /// </summary>
        /// <value>Product Date</value>
        [DataMember(Name = "productDate", IsRequired = true, EmitDefaultValue = true)]
        public string ProductDate { get; set; }

        /// <summary>
        /// Product Time
        /// </summary>
        /// <value>Product Time</value>
        [DataMember(Name = "productTime", IsRequired = true, EmitDefaultValue = true)]
        public string ProductTime { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = true)]
        public ProductCategory Category { get; set; }

        /// <summary>
        /// Product Info
        /// </summary>
        /// <value>Product Info</value>
        [DataMember(Name = "productInfo", EmitDefaultValue = false)]
        public List<Object> ProductInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProductDate: ").Append(ProductDate).Append("\n");
            sb.Append("  ProductTime: ").Append(ProductTime).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ProductInfo: ").Append(ProductInfo).Append("\n");
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
            return this.Equals(input as Product);
        }

        /// <summary>
        /// Returns true if Product instances are equal
        /// </summary>
        /// <param name="input">Instance of Product to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Product input)
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
                    this.ProductDate == input.ProductDate ||
                    (this.ProductDate != null &&
                    this.ProductDate.Equals(input.ProductDate))
                ) && 
                (
                    this.ProductTime == input.ProductTime ||
                    (this.ProductTime != null &&
                    this.ProductTime.Equals(input.ProductTime))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.ProductInfo == input.ProductInfo ||
                    this.ProductInfo != null &&
                    input.ProductInfo != null &&
                    this.ProductInfo.SequenceEqual(input.ProductInfo)
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
                if (this.ProductDate != null)
                {
                    hashCode = (hashCode * 59) + this.ProductDate.GetHashCode();
                }
                if (this.ProductTime != null)
                {
                    hashCode = (hashCode * 59) + this.ProductTime.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.ProductInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ProductInfo.GetHashCode();
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
