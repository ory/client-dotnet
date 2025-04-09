/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.20.5
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
    /// A JSONPatch document as defined by RFC 6902
    /// </summary>
    [DataContract(Name = "jsonPatch")]
    public partial class ClientJsonPatch : IValidatableObject
    {
        /// <summary>
        /// The operation to be performed. One of \&quot;add\&quot;, \&quot;remove\&quot;, \&quot;replace\&quot;, \&quot;move\&quot;, \&quot;copy\&quot;, or \&quot;test\&quot;.
        /// </summary>
        /// <value>The operation to be performed. One of \&quot;add\&quot;, \&quot;remove\&quot;, \&quot;replace\&quot;, \&quot;move\&quot;, \&quot;copy\&quot;, or \&quot;test\&quot;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OpEnum
        {
            /// <summary>
            /// Enum Add for value: add
            /// </summary>
            [EnumMember(Value = "add")]
            Add = 1,

            /// <summary>
            /// Enum Remove for value: remove
            /// </summary>
            [EnumMember(Value = "remove")]
            Remove = 2,

            /// <summary>
            /// Enum Replace for value: replace
            /// </summary>
            [EnumMember(Value = "replace")]
            Replace = 3,

            /// <summary>
            /// Enum Move for value: move
            /// </summary>
            [EnumMember(Value = "move")]
            Move = 4,

            /// <summary>
            /// Enum Copy for value: copy
            /// </summary>
            [EnumMember(Value = "copy")]
            Copy = 5,

            /// <summary>
            /// Enum Test for value: test
            /// </summary>
            [EnumMember(Value = "test")]
            Test = 6
        }


        /// <summary>
        /// The operation to be performed. One of \&quot;add\&quot;, \&quot;remove\&quot;, \&quot;replace\&quot;, \&quot;move\&quot;, \&quot;copy\&quot;, or \&quot;test\&quot;.
        /// </summary>
        /// <value>The operation to be performed. One of \&quot;add\&quot;, \&quot;remove\&quot;, \&quot;replace\&quot;, \&quot;move\&quot;, \&quot;copy\&quot;, or \&quot;test\&quot;.</value>
        /*
        <example>replace</example>
        */
        [DataMember(Name = "op", IsRequired = true, EmitDefaultValue = true)]
        public OpEnum Op { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientJsonPatch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientJsonPatch()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientJsonPatch" /> class.
        /// </summary>
        /// <param name="from">This field is used together with operation \&quot;move\&quot; and uses JSON Pointer notation.  Learn more [about JSON Pointers](https://datatracker.ietf.org/doc/html/rfc6901#section-5)..</param>
        /// <param name="op">The operation to be performed. One of \&quot;add\&quot;, \&quot;remove\&quot;, \&quot;replace\&quot;, \&quot;move\&quot;, \&quot;copy\&quot;, or \&quot;test\&quot;. (required).</param>
        /// <param name="path">The path to the target path. Uses JSON pointer notation.  Learn more [about JSON Pointers](https://datatracker.ietf.org/doc/html/rfc6901#section-5). (required).</param>
        /// <param name="value">The value to be used within the operations.  Learn more [about JSON Pointers](https://datatracker.ietf.org/doc/html/rfc6901#section-5)..</param>
        public ClientJsonPatch(string from = default(string), OpEnum op = default(OpEnum), string path = default(string), Object value = default(Object))
        {
            this.Op = op;
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new ArgumentNullException("path is a required property for ClientJsonPatch and cannot be null");
            }
            this.Path = path;
            this.From = from;
            this.Value = value;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// This field is used together with operation \&quot;move\&quot; and uses JSON Pointer notation.  Learn more [about JSON Pointers](https://datatracker.ietf.org/doc/html/rfc6901#section-5).
        /// </summary>
        /// <value>This field is used together with operation \&quot;move\&quot; and uses JSON Pointer notation.  Learn more [about JSON Pointers](https://datatracker.ietf.org/doc/html/rfc6901#section-5).</value>
        /*
        <example>/name</example>
        */
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// The path to the target path. Uses JSON pointer notation.  Learn more [about JSON Pointers](https://datatracker.ietf.org/doc/html/rfc6901#section-5).
        /// </summary>
        /// <value>The path to the target path. Uses JSON pointer notation.  Learn more [about JSON Pointers](https://datatracker.ietf.org/doc/html/rfc6901#section-5).</value>
        /*
        <example>/name</example>
        */
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// The value to be used within the operations.  Learn more [about JSON Pointers](https://datatracker.ietf.org/doc/html/rfc6901#section-5).
        /// </summary>
        /// <value>The value to be used within the operations.  Learn more [about JSON Pointers](https://datatracker.ietf.org/doc/html/rfc6901#section-5).</value>
        /*
        <example>foobar</example>
        */
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public Object Value { get; set; }

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
            sb.Append("class ClientJsonPatch {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Op: ").Append(Op).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
