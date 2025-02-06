/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.16.6
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;

namespace Ory.Client.Model
{
    /// <summary>
    /// Create Event Stream Request Body
    /// </summary>
    [DataContract(Name = "createEventStreamBody")]
    public partial class ClientCreateEventStreamBody : IValidatableObject
    {
        /// <summary>
        /// The type of the event stream (AWS SNS, GCP Pub/Sub, etc).
        /// </summary>
        /// <value>The type of the event stream (AWS SNS, GCP Pub/Sub, etc).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Sns for value: sns
            /// </summary>
            [EnumMember(Value = "sns")]
            Sns = 1
        }


        /// <summary>
        /// The type of the event stream (AWS SNS, GCP Pub/Sub, etc).
        /// </summary>
        /// <value>The type of the event stream (AWS SNS, GCP Pub/Sub, etc).</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCreateEventStreamBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientCreateEventStreamBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCreateEventStreamBody" /> class.
        /// </summary>
        /// <param name="roleArn">The AWS IAM role ARN to assume when publishing to the SNS topic. (required).</param>
        /// <param name="topicArn">The AWS SNS topic ARN. (required).</param>
        /// <param name="type">The type of the event stream (AWS SNS, GCP Pub/Sub, etc). (required).</param>
        public ClientCreateEventStreamBody(string roleArn = default(string), string topicArn = default(string), TypeEnum type = default(TypeEnum))
        {
            // to ensure "roleArn" is required (not null)
            if (roleArn == null)
            {
                throw new ArgumentNullException("roleArn is a required property for ClientCreateEventStreamBody and cannot be null");
            }
            this.RoleArn = roleArn;
            // to ensure "topicArn" is required (not null)
            if (topicArn == null)
            {
                throw new ArgumentNullException("topicArn is a required property for ClientCreateEventStreamBody and cannot be null");
            }
            this.TopicArn = topicArn;
            this.Type = type;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The AWS IAM role ARN to assume when publishing to the SNS topic.
        /// </summary>
        /// <value>The AWS IAM role ARN to assume when publishing to the SNS topic.</value>
        [DataMember(Name = "role_arn", IsRequired = true, EmitDefaultValue = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// The AWS SNS topic ARN.
        /// </summary>
        /// <value>The AWS SNS topic ARN.</value>
        [DataMember(Name = "topic_arn", IsRequired = true, EmitDefaultValue = true)]
        public string TopicArn { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientCreateEventStreamBody {\n");
            sb.Append("  RoleArn: ").Append(RoleArn).Append("\n");
            sb.Append("  TopicArn: ").Append(TopicArn).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
