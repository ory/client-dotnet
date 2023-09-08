/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.2.4
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
    /// ClientUpdateLoginFlowBody
    /// </summary>
    [JsonConverter(typeof(ClientUpdateLoginFlowBodyJsonConverter))]
    [DataContract(Name = "updateLoginFlowBody")]
    public partial class ClientUpdateLoginFlowBody : AbstractOpenAPISchema, IEquatable<ClientUpdateLoginFlowBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateLoginFlowBody" /> class
        /// with the <see cref="ClientUpdateLoginFlowWithCodeMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientUpdateLoginFlowWithCodeMethod.</param>
        public ClientUpdateLoginFlowBody(ClientUpdateLoginFlowWithCodeMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateLoginFlowBody" /> class
        /// with the <see cref="ClientUpdateLoginFlowWithLookupSecretMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientUpdateLoginFlowWithLookupSecretMethod.</param>
        public ClientUpdateLoginFlowBody(ClientUpdateLoginFlowWithLookupSecretMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateLoginFlowBody" /> class
        /// with the <see cref="ClientUpdateLoginFlowWithOidcMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientUpdateLoginFlowWithOidcMethod.</param>
        public ClientUpdateLoginFlowBody(ClientUpdateLoginFlowWithOidcMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateLoginFlowBody" /> class
        /// with the <see cref="ClientUpdateLoginFlowWithPasswordMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientUpdateLoginFlowWithPasswordMethod.</param>
        public ClientUpdateLoginFlowBody(ClientUpdateLoginFlowWithPasswordMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateLoginFlowBody" /> class
        /// with the <see cref="ClientUpdateLoginFlowWithTotpMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientUpdateLoginFlowWithTotpMethod.</param>
        public ClientUpdateLoginFlowBody(ClientUpdateLoginFlowWithTotpMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateLoginFlowBody" /> class
        /// with the <see cref="ClientUpdateLoginFlowWithWebAuthnMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientUpdateLoginFlowWithWebAuthnMethod.</param>
        public ClientUpdateLoginFlowBody(ClientUpdateLoginFlowWithWebAuthnMethod actualInstance)
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
                if (value.GetType() == typeof(ClientUpdateLoginFlowWithCodeMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientUpdateLoginFlowWithLookupSecretMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientUpdateLoginFlowWithOidcMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientUpdateLoginFlowWithPasswordMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientUpdateLoginFlowWithTotpMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientUpdateLoginFlowWithWebAuthnMethod))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ClientUpdateLoginFlowWithCodeMethod, ClientUpdateLoginFlowWithLookupSecretMethod, ClientUpdateLoginFlowWithOidcMethod, ClientUpdateLoginFlowWithPasswordMethod, ClientUpdateLoginFlowWithTotpMethod, ClientUpdateLoginFlowWithWebAuthnMethod");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ClientUpdateLoginFlowWithCodeMethod`. If the actual instance is not `ClientUpdateLoginFlowWithCodeMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientUpdateLoginFlowWithCodeMethod</returns>
        public ClientUpdateLoginFlowWithCodeMethod GetClientUpdateLoginFlowWithCodeMethod()
        {
            return (ClientUpdateLoginFlowWithCodeMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientUpdateLoginFlowWithLookupSecretMethod`. If the actual instance is not `ClientUpdateLoginFlowWithLookupSecretMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientUpdateLoginFlowWithLookupSecretMethod</returns>
        public ClientUpdateLoginFlowWithLookupSecretMethod GetClientUpdateLoginFlowWithLookupSecretMethod()
        {
            return (ClientUpdateLoginFlowWithLookupSecretMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientUpdateLoginFlowWithOidcMethod`. If the actual instance is not `ClientUpdateLoginFlowWithOidcMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientUpdateLoginFlowWithOidcMethod</returns>
        public ClientUpdateLoginFlowWithOidcMethod GetClientUpdateLoginFlowWithOidcMethod()
        {
            return (ClientUpdateLoginFlowWithOidcMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientUpdateLoginFlowWithPasswordMethod`. If the actual instance is not `ClientUpdateLoginFlowWithPasswordMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientUpdateLoginFlowWithPasswordMethod</returns>
        public ClientUpdateLoginFlowWithPasswordMethod GetClientUpdateLoginFlowWithPasswordMethod()
        {
            return (ClientUpdateLoginFlowWithPasswordMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientUpdateLoginFlowWithTotpMethod`. If the actual instance is not `ClientUpdateLoginFlowWithTotpMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientUpdateLoginFlowWithTotpMethod</returns>
        public ClientUpdateLoginFlowWithTotpMethod GetClientUpdateLoginFlowWithTotpMethod()
        {
            return (ClientUpdateLoginFlowWithTotpMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientUpdateLoginFlowWithWebAuthnMethod`. If the actual instance is not `ClientUpdateLoginFlowWithWebAuthnMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientUpdateLoginFlowWithWebAuthnMethod</returns>
        public ClientUpdateLoginFlowWithWebAuthnMethod GetClientUpdateLoginFlowWithWebAuthnMethod()
        {
            return (ClientUpdateLoginFlowWithWebAuthnMethod)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientUpdateLoginFlowBody {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ClientUpdateLoginFlowBody.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ClientUpdateLoginFlowBody
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ClientUpdateLoginFlowBody</returns>
        public static ClientUpdateLoginFlowBody FromJson(string jsonString)
        {
            ClientUpdateLoginFlowBody newClientUpdateLoginFlowBody = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newClientUpdateLoginFlowBody;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientUpdateLoginFlowWithCodeMethod).GetProperty("AdditionalProperties") == null)
                {
                    newClientUpdateLoginFlowBody = new ClientUpdateLoginFlowBody(JsonConvert.DeserializeObject<ClientUpdateLoginFlowWithCodeMethod>(jsonString, ClientUpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newClientUpdateLoginFlowBody = new ClientUpdateLoginFlowBody(JsonConvert.DeserializeObject<ClientUpdateLoginFlowWithCodeMethod>(jsonString, ClientUpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientUpdateLoginFlowWithCodeMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientUpdateLoginFlowWithCodeMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientUpdateLoginFlowWithLookupSecretMethod).GetProperty("AdditionalProperties") == null)
                {
                    newClientUpdateLoginFlowBody = new ClientUpdateLoginFlowBody(JsonConvert.DeserializeObject<ClientUpdateLoginFlowWithLookupSecretMethod>(jsonString, ClientUpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newClientUpdateLoginFlowBody = new ClientUpdateLoginFlowBody(JsonConvert.DeserializeObject<ClientUpdateLoginFlowWithLookupSecretMethod>(jsonString, ClientUpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientUpdateLoginFlowWithLookupSecretMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientUpdateLoginFlowWithLookupSecretMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientUpdateLoginFlowWithOidcMethod).GetProperty("AdditionalProperties") == null)
                {
                    newClientUpdateLoginFlowBody = new ClientUpdateLoginFlowBody(JsonConvert.DeserializeObject<ClientUpdateLoginFlowWithOidcMethod>(jsonString, ClientUpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newClientUpdateLoginFlowBody = new ClientUpdateLoginFlowBody(JsonConvert.DeserializeObject<ClientUpdateLoginFlowWithOidcMethod>(jsonString, ClientUpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientUpdateLoginFlowWithOidcMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientUpdateLoginFlowWithOidcMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientUpdateLoginFlowWithPasswordMethod).GetProperty("AdditionalProperties") == null)
                {
                    newClientUpdateLoginFlowBody = new ClientUpdateLoginFlowBody(JsonConvert.DeserializeObject<ClientUpdateLoginFlowWithPasswordMethod>(jsonString, ClientUpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newClientUpdateLoginFlowBody = new ClientUpdateLoginFlowBody(JsonConvert.DeserializeObject<ClientUpdateLoginFlowWithPasswordMethod>(jsonString, ClientUpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientUpdateLoginFlowWithPasswordMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientUpdateLoginFlowWithPasswordMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientUpdateLoginFlowWithTotpMethod).GetProperty("AdditionalProperties") == null)
                {
                    newClientUpdateLoginFlowBody = new ClientUpdateLoginFlowBody(JsonConvert.DeserializeObject<ClientUpdateLoginFlowWithTotpMethod>(jsonString, ClientUpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newClientUpdateLoginFlowBody = new ClientUpdateLoginFlowBody(JsonConvert.DeserializeObject<ClientUpdateLoginFlowWithTotpMethod>(jsonString, ClientUpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientUpdateLoginFlowWithTotpMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientUpdateLoginFlowWithTotpMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientUpdateLoginFlowWithWebAuthnMethod).GetProperty("AdditionalProperties") == null)
                {
                    newClientUpdateLoginFlowBody = new ClientUpdateLoginFlowBody(JsonConvert.DeserializeObject<ClientUpdateLoginFlowWithWebAuthnMethod>(jsonString, ClientUpdateLoginFlowBody.SerializerSettings));
                }
                else
                {
                    newClientUpdateLoginFlowBody = new ClientUpdateLoginFlowBody(JsonConvert.DeserializeObject<ClientUpdateLoginFlowWithWebAuthnMethod>(jsonString, ClientUpdateLoginFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientUpdateLoginFlowWithWebAuthnMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientUpdateLoginFlowWithWebAuthnMethod: {1}", jsonString, exception.ToString()));
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
            return newClientUpdateLoginFlowBody;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientUpdateLoginFlowBody);
        }

        /// <summary>
        /// Returns true if ClientUpdateLoginFlowBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientUpdateLoginFlowBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientUpdateLoginFlowBody input)
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
    /// Custom JSON converter for ClientUpdateLoginFlowBody
    /// </summary>
    public class ClientUpdateLoginFlowBodyJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ClientUpdateLoginFlowBody).GetMethod("ToJson").Invoke(value, null)));
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
                return ClientUpdateLoginFlowBody.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
