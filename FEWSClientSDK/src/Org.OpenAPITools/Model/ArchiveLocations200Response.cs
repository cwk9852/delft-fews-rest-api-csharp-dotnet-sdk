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
using System.Reflection;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ArchiveLocations200Response
    /// </summary>
    [JsonConverter(typeof(ArchiveLocations200ResponseJsonConverter))]
    [DataContract(Name = "archive_locations_200_response")]
    public partial class ArchiveLocations200Response : AbstractOpenAPISchema, IEquatable<ArchiveLocations200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveLocations200Response" /> class
        /// with the <see cref="PiRestArchiveLocations" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PiRestArchiveLocations.</param>
        public ArchiveLocations200Response(PiRestArchiveLocations actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveLocations200Response" /> class
        /// with the <see cref="Object" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Object.</param>
        public ArchiveLocations200Response(Object actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveLocations200Response" /> class
        /// with the <see cref="Object" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Object.</param>
        public ArchiveLocations200Response(Object actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(Object))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PiRestArchiveLocations))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Object, PiRestArchiveLocations");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `PiRestArchiveLocations`. If the actual instance is not `PiRestArchiveLocations`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PiRestArchiveLocations</returns>
        public PiRestArchiveLocations GetPiRestArchiveLocations()
        {
            return (PiRestArchiveLocations)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Object`. If the actual instance is not `Object`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Object</returns>
        public Object GetObject()
        {
            return (Object)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Object`. If the actual instance is not `Object`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Object</returns>
        public Object GetObject()
        {
            return (Object)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchiveLocations200Response {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, ArchiveLocations200Response.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ArchiveLocations200Response
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ArchiveLocations200Response</returns>
        public static ArchiveLocations200Response FromJson(string jsonString)
        {
            ArchiveLocations200Response newArchiveLocations200Response = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newArchiveLocations200Response;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Object).GetProperty("AdditionalProperties") == null)
                {
                    newArchiveLocations200Response = new ArchiveLocations200Response(JsonConvert.DeserializeObject<Object>(jsonString, ArchiveLocations200Response.SerializerSettings));
                }
                else
                {
                    newArchiveLocations200Response = new ArchiveLocations200Response(JsonConvert.DeserializeObject<Object>(jsonString, ArchiveLocations200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Object");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Object: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PiRestArchiveLocations).GetProperty("AdditionalProperties") == null)
                {
                    newArchiveLocations200Response = new ArchiveLocations200Response(JsonConvert.DeserializeObject<PiRestArchiveLocations>(jsonString, ArchiveLocations200Response.SerializerSettings));
                }
                else
                {
                    newArchiveLocations200Response = new ArchiveLocations200Response(JsonConvert.DeserializeObject<PiRestArchiveLocations>(jsonString, ArchiveLocations200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("PiRestArchiveLocations");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PiRestArchiveLocations: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newArchiveLocations200Response;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ArchiveLocations200Response);
        }

        /// <summary>
        /// Returns true if ArchiveLocations200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of ArchiveLocations200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchiveLocations200Response input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for ArchiveLocations200Response
    /// </summary>
    public class ArchiveLocations200ResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ArchiveLocations200Response).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return ArchiveLocations200Response.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}