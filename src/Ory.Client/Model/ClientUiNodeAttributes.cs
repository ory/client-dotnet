/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.54
 * Contact: support@ory.sh
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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Ory.Client.Model
{
    /// <summary>
    /// ClientUiNodeAttributes
    /// </summary>
    [JsonConverter(typeof(ClientUiNodeAttributesJsonConverter))]
    [DataContract(Name = "uiNodeAttributes")]
    public partial class ClientUiNodeAttributes : AbstractOpenAPISchema, IEquatable<ClientUiNodeAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUiNodeAttributes" /> class
        /// with the <see cref="ClientUiNodeAnchorAttributes" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientUiNodeAnchorAttributes.</param>
        public ClientUiNodeAttributes(ClientUiNodeAnchorAttributes actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUiNodeAttributes" /> class
        /// with the <see cref="ClientUiNodeImageAttributes" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientUiNodeImageAttributes.</param>
        public ClientUiNodeAttributes(ClientUiNodeImageAttributes actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUiNodeAttributes" /> class
        /// with the <see cref="ClientUiNodeInputAttributes" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientUiNodeInputAttributes.</param>
        public ClientUiNodeAttributes(ClientUiNodeInputAttributes actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUiNodeAttributes" /> class
        /// with the <see cref="ClientUiNodeScriptAttributes" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientUiNodeScriptAttributes.</param>
        public ClientUiNodeAttributes(ClientUiNodeScriptAttributes actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUiNodeAttributes" /> class
        /// with the <see cref="ClientUiNodeTextAttributes" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientUiNodeTextAttributes.</param>
        public ClientUiNodeAttributes(ClientUiNodeTextAttributes actualInstance)
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
                if (value.GetType() == typeof(ClientUiNodeAnchorAttributes))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientUiNodeImageAttributes))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientUiNodeInputAttributes))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientUiNodeScriptAttributes))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientUiNodeTextAttributes))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ClientUiNodeAnchorAttributes, ClientUiNodeImageAttributes, ClientUiNodeInputAttributes, ClientUiNodeScriptAttributes, ClientUiNodeTextAttributes");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ClientUiNodeAnchorAttributes`. If the actual instance is not `ClientUiNodeAnchorAttributes`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientUiNodeAnchorAttributes</returns>
        public ClientUiNodeAnchorAttributes GetClientUiNodeAnchorAttributes()
        {
            return (ClientUiNodeAnchorAttributes)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientUiNodeImageAttributes`. If the actual instance is not `ClientUiNodeImageAttributes`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientUiNodeImageAttributes</returns>
        public ClientUiNodeImageAttributes GetClientUiNodeImageAttributes()
        {
            return (ClientUiNodeImageAttributes)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientUiNodeInputAttributes`. If the actual instance is not `ClientUiNodeInputAttributes`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientUiNodeInputAttributes</returns>
        public ClientUiNodeInputAttributes GetClientUiNodeInputAttributes()
        {
            return (ClientUiNodeInputAttributes)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientUiNodeScriptAttributes`. If the actual instance is not `ClientUiNodeScriptAttributes`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientUiNodeScriptAttributes</returns>
        public ClientUiNodeScriptAttributes GetClientUiNodeScriptAttributes()
        {
            return (ClientUiNodeScriptAttributes)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientUiNodeTextAttributes`. If the actual instance is not `ClientUiNodeTextAttributes`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientUiNodeTextAttributes</returns>
        public ClientUiNodeTextAttributes GetClientUiNodeTextAttributes()
        {
            return (ClientUiNodeTextAttributes)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientUiNodeAttributes {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ClientUiNodeAttributes.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ClientUiNodeAttributes
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ClientUiNodeAttributes</returns>
        public static ClientUiNodeAttributes FromJson(string jsonString)
        {
            ClientUiNodeAttributes newClientUiNodeAttributes = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newClientUiNodeAttributes;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientUiNodeAnchorAttributes).GetProperty("AdditionalProperties") == null)
                {
                    newClientUiNodeAttributes = new ClientUiNodeAttributes(JsonConvert.DeserializeObject<ClientUiNodeAnchorAttributes>(jsonString, ClientUiNodeAttributes.SerializerSettings));
                }
                else
                {
                    newClientUiNodeAttributes = new ClientUiNodeAttributes(JsonConvert.DeserializeObject<ClientUiNodeAnchorAttributes>(jsonString, ClientUiNodeAttributes.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientUiNodeAnchorAttributes");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientUiNodeAnchorAttributes: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientUiNodeImageAttributes).GetProperty("AdditionalProperties") == null)
                {
                    newClientUiNodeAttributes = new ClientUiNodeAttributes(JsonConvert.DeserializeObject<ClientUiNodeImageAttributes>(jsonString, ClientUiNodeAttributes.SerializerSettings));
                }
                else
                {
                    newClientUiNodeAttributes = new ClientUiNodeAttributes(JsonConvert.DeserializeObject<ClientUiNodeImageAttributes>(jsonString, ClientUiNodeAttributes.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientUiNodeImageAttributes");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientUiNodeImageAttributes: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientUiNodeInputAttributes).GetProperty("AdditionalProperties") == null)
                {
                    newClientUiNodeAttributes = new ClientUiNodeAttributes(JsonConvert.DeserializeObject<ClientUiNodeInputAttributes>(jsonString, ClientUiNodeAttributes.SerializerSettings));
                }
                else
                {
                    newClientUiNodeAttributes = new ClientUiNodeAttributes(JsonConvert.DeserializeObject<ClientUiNodeInputAttributes>(jsonString, ClientUiNodeAttributes.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientUiNodeInputAttributes");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientUiNodeInputAttributes: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientUiNodeScriptAttributes).GetProperty("AdditionalProperties") == null)
                {
                    newClientUiNodeAttributes = new ClientUiNodeAttributes(JsonConvert.DeserializeObject<ClientUiNodeScriptAttributes>(jsonString, ClientUiNodeAttributes.SerializerSettings));
                }
                else
                {
                    newClientUiNodeAttributes = new ClientUiNodeAttributes(JsonConvert.DeserializeObject<ClientUiNodeScriptAttributes>(jsonString, ClientUiNodeAttributes.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientUiNodeScriptAttributes");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientUiNodeScriptAttributes: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientUiNodeTextAttributes).GetProperty("AdditionalProperties") == null)
                {
                    newClientUiNodeAttributes = new ClientUiNodeAttributes(JsonConvert.DeserializeObject<ClientUiNodeTextAttributes>(jsonString, ClientUiNodeAttributes.SerializerSettings));
                }
                else
                {
                    newClientUiNodeAttributes = new ClientUiNodeAttributes(JsonConvert.DeserializeObject<ClientUiNodeTextAttributes>(jsonString, ClientUiNodeAttributes.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientUiNodeTextAttributes");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientUiNodeTextAttributes: {1}", jsonString, exception.ToString()));
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
            return newClientUiNodeAttributes;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientUiNodeAttributes);
        }

        /// <summary>
        /// Returns true if ClientUiNodeAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientUiNodeAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientUiNodeAttributes input)
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
    /// Custom JSON converter for ClientUiNodeAttributes
    /// </summary>
    public class ClientUiNodeAttributesJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ClientUiNodeAttributes).GetMethod("ToJson").Invoke(value, null)));
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
                return ClientUiNodeAttributes.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
