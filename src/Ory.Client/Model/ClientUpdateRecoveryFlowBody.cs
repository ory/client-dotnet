/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.9
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
    /// Update Recovery Flow Request Body
    /// </summary>
    [JsonConverter(typeof(ClientUpdateRecoveryFlowBodyJsonConverter))]
    [DataContract(Name = "updateRecoveryFlowBody")]
    public partial class ClientUpdateRecoveryFlowBody : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateRecoveryFlowBody" /> class
        /// with the <see cref="ClientUpdateRecoveryFlowWithLinkMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientUpdateRecoveryFlowWithLinkMethod.</param>
        public ClientUpdateRecoveryFlowBody(ClientUpdateRecoveryFlowWithLinkMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUpdateRecoveryFlowBody" /> class
        /// with the <see cref="ClientUpdateRecoveryFlowWithCodeMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientUpdateRecoveryFlowWithCodeMethod.</param>
        public ClientUpdateRecoveryFlowBody(ClientUpdateRecoveryFlowWithCodeMethod actualInstance)
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
                if (value.GetType() == typeof(ClientUpdateRecoveryFlowWithCodeMethod) || value is ClientUpdateRecoveryFlowWithCodeMethod)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientUpdateRecoveryFlowWithLinkMethod) || value is ClientUpdateRecoveryFlowWithLinkMethod)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ClientUpdateRecoveryFlowWithCodeMethod, ClientUpdateRecoveryFlowWithLinkMethod");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ClientUpdateRecoveryFlowWithLinkMethod`. If the actual instance is not `ClientUpdateRecoveryFlowWithLinkMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientUpdateRecoveryFlowWithLinkMethod</returns>
        public ClientUpdateRecoveryFlowWithLinkMethod GetClientUpdateRecoveryFlowWithLinkMethod()
        {
            return (ClientUpdateRecoveryFlowWithLinkMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientUpdateRecoveryFlowWithCodeMethod`. If the actual instance is not `ClientUpdateRecoveryFlowWithCodeMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientUpdateRecoveryFlowWithCodeMethod</returns>
        public ClientUpdateRecoveryFlowWithCodeMethod GetClientUpdateRecoveryFlowWithCodeMethod()
        {
            return (ClientUpdateRecoveryFlowWithCodeMethod)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientUpdateRecoveryFlowBody {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ClientUpdateRecoveryFlowBody.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ClientUpdateRecoveryFlowBody
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ClientUpdateRecoveryFlowBody</returns>
        public static ClientUpdateRecoveryFlowBody FromJson(string jsonString)
        {
            ClientUpdateRecoveryFlowBody newClientUpdateRecoveryFlowBody = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newClientUpdateRecoveryFlowBody;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientUpdateRecoveryFlowWithCodeMethod).GetProperty("AdditionalProperties") == null)
                {
                    newClientUpdateRecoveryFlowBody = new ClientUpdateRecoveryFlowBody(JsonConvert.DeserializeObject<ClientUpdateRecoveryFlowWithCodeMethod>(jsonString, ClientUpdateRecoveryFlowBody.SerializerSettings));
                }
                else
                {
                    newClientUpdateRecoveryFlowBody = new ClientUpdateRecoveryFlowBody(JsonConvert.DeserializeObject<ClientUpdateRecoveryFlowWithCodeMethod>(jsonString, ClientUpdateRecoveryFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientUpdateRecoveryFlowWithCodeMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientUpdateRecoveryFlowWithCodeMethod: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientUpdateRecoveryFlowWithLinkMethod).GetProperty("AdditionalProperties") == null)
                {
                    newClientUpdateRecoveryFlowBody = new ClientUpdateRecoveryFlowBody(JsonConvert.DeserializeObject<ClientUpdateRecoveryFlowWithLinkMethod>(jsonString, ClientUpdateRecoveryFlowBody.SerializerSettings));
                }
                else
                {
                    newClientUpdateRecoveryFlowBody = new ClientUpdateRecoveryFlowBody(JsonConvert.DeserializeObject<ClientUpdateRecoveryFlowWithLinkMethod>(jsonString, ClientUpdateRecoveryFlowBody.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientUpdateRecoveryFlowWithLinkMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientUpdateRecoveryFlowWithLinkMethod: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newClientUpdateRecoveryFlowBody;
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
    /// Custom JSON converter for ClientUpdateRecoveryFlowBody
    /// </summary>
    public class ClientUpdateRecoveryFlowBodyJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ClientUpdateRecoveryFlowBody).GetMethod("ToJson").Invoke(value, null)));
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
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return ClientUpdateRecoveryFlowBody.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return ClientUpdateRecoveryFlowBody.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
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
