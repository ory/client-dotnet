/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.17.1
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
    /// ClientContinueWith
    /// </summary>
    [JsonConverter(typeof(ClientContinueWithJsonConverter))]
    [DataContract(Name = "continueWith")]
    public partial class ClientContinueWith : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientContinueWith" /> class
        /// with the <see cref="ClientContinueWithVerificationUi" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientContinueWithVerificationUi.</param>
        public ClientContinueWith(ClientContinueWithVerificationUi actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientContinueWith" /> class
        /// with the <see cref="ClientContinueWithSetOrySessionToken" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientContinueWithSetOrySessionToken.</param>
        public ClientContinueWith(ClientContinueWithSetOrySessionToken actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientContinueWith" /> class
        /// with the <see cref="ClientContinueWithSettingsUi" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientContinueWithSettingsUi.</param>
        public ClientContinueWith(ClientContinueWithSettingsUi actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientContinueWith" /> class
        /// with the <see cref="ClientContinueWithRecoveryUi" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientContinueWithRecoveryUi.</param>
        public ClientContinueWith(ClientContinueWithRecoveryUi actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientContinueWith" /> class
        /// with the <see cref="ClientContinueWithRedirectBrowserTo" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ClientContinueWithRedirectBrowserTo.</param>
        public ClientContinueWith(ClientContinueWithRedirectBrowserTo actualInstance)
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
                if (value.GetType() == typeof(ClientContinueWithRecoveryUi) || value is ClientContinueWithRecoveryUi)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientContinueWithRedirectBrowserTo) || value is ClientContinueWithRedirectBrowserTo)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientContinueWithSetOrySessionToken) || value is ClientContinueWithSetOrySessionToken)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientContinueWithSettingsUi) || value is ClientContinueWithSettingsUi)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ClientContinueWithVerificationUi) || value is ClientContinueWithVerificationUi)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ClientContinueWithRecoveryUi, ClientContinueWithRedirectBrowserTo, ClientContinueWithSetOrySessionToken, ClientContinueWithSettingsUi, ClientContinueWithVerificationUi");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ClientContinueWithVerificationUi`. If the actual instance is not `ClientContinueWithVerificationUi`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientContinueWithVerificationUi</returns>
        public ClientContinueWithVerificationUi GetClientContinueWithVerificationUi()
        {
            return (ClientContinueWithVerificationUi)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientContinueWithSetOrySessionToken`. If the actual instance is not `ClientContinueWithSetOrySessionToken`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientContinueWithSetOrySessionToken</returns>
        public ClientContinueWithSetOrySessionToken GetClientContinueWithSetOrySessionToken()
        {
            return (ClientContinueWithSetOrySessionToken)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientContinueWithSettingsUi`. If the actual instance is not `ClientContinueWithSettingsUi`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientContinueWithSettingsUi</returns>
        public ClientContinueWithSettingsUi GetClientContinueWithSettingsUi()
        {
            return (ClientContinueWithSettingsUi)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientContinueWithRecoveryUi`. If the actual instance is not `ClientContinueWithRecoveryUi`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientContinueWithRecoveryUi</returns>
        public ClientContinueWithRecoveryUi GetClientContinueWithRecoveryUi()
        {
            return (ClientContinueWithRecoveryUi)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ClientContinueWithRedirectBrowserTo`. If the actual instance is not `ClientContinueWithRedirectBrowserTo`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ClientContinueWithRedirectBrowserTo</returns>
        public ClientContinueWithRedirectBrowserTo GetClientContinueWithRedirectBrowserTo()
        {
            return (ClientContinueWithRedirectBrowserTo)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientContinueWith {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, ClientContinueWith.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ClientContinueWith
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ClientContinueWith</returns>
        public static ClientContinueWith FromJson(string jsonString)
        {
            ClientContinueWith newClientContinueWith = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newClientContinueWith;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientContinueWithRecoveryUi).GetProperty("AdditionalProperties") == null)
                {
                    newClientContinueWith = new ClientContinueWith(JsonConvert.DeserializeObject<ClientContinueWithRecoveryUi>(jsonString, ClientContinueWith.SerializerSettings));
                }
                else
                {
                    newClientContinueWith = new ClientContinueWith(JsonConvert.DeserializeObject<ClientContinueWithRecoveryUi>(jsonString, ClientContinueWith.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientContinueWithRecoveryUi");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientContinueWithRecoveryUi: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientContinueWithRedirectBrowserTo).GetProperty("AdditionalProperties") == null)
                {
                    newClientContinueWith = new ClientContinueWith(JsonConvert.DeserializeObject<ClientContinueWithRedirectBrowserTo>(jsonString, ClientContinueWith.SerializerSettings));
                }
                else
                {
                    newClientContinueWith = new ClientContinueWith(JsonConvert.DeserializeObject<ClientContinueWithRedirectBrowserTo>(jsonString, ClientContinueWith.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientContinueWithRedirectBrowserTo");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientContinueWithRedirectBrowserTo: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientContinueWithSetOrySessionToken).GetProperty("AdditionalProperties") == null)
                {
                    newClientContinueWith = new ClientContinueWith(JsonConvert.DeserializeObject<ClientContinueWithSetOrySessionToken>(jsonString, ClientContinueWith.SerializerSettings));
                }
                else
                {
                    newClientContinueWith = new ClientContinueWith(JsonConvert.DeserializeObject<ClientContinueWithSetOrySessionToken>(jsonString, ClientContinueWith.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientContinueWithSetOrySessionToken");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientContinueWithSetOrySessionToken: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientContinueWithSettingsUi).GetProperty("AdditionalProperties") == null)
                {
                    newClientContinueWith = new ClientContinueWith(JsonConvert.DeserializeObject<ClientContinueWithSettingsUi>(jsonString, ClientContinueWith.SerializerSettings));
                }
                else
                {
                    newClientContinueWith = new ClientContinueWith(JsonConvert.DeserializeObject<ClientContinueWithSettingsUi>(jsonString, ClientContinueWith.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientContinueWithSettingsUi");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientContinueWithSettingsUi: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ClientContinueWithVerificationUi).GetProperty("AdditionalProperties") == null)
                {
                    newClientContinueWith = new ClientContinueWith(JsonConvert.DeserializeObject<ClientContinueWithVerificationUi>(jsonString, ClientContinueWith.SerializerSettings));
                }
                else
                {
                    newClientContinueWith = new ClientContinueWith(JsonConvert.DeserializeObject<ClientContinueWithVerificationUi>(jsonString, ClientContinueWith.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ClientContinueWithVerificationUi");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ClientContinueWithVerificationUi: {1}", jsonString, exception.ToString()));
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
            return newClientContinueWith;
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
    /// Custom JSON converter for ClientContinueWith
    /// </summary>
    public class ClientContinueWithJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ClientContinueWith).GetMethod("ToJson").Invoke(value, null)));
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
                    return ClientContinueWith.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return ClientContinueWith.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
