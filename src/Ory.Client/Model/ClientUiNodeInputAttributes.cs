/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.20.3
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
    /// InputAttributes represents the attributes of an input node
    /// </summary>
    [DataContract(Name = "uiNodeInputAttributes")]
    public partial class ClientUiNodeInputAttributes : IValidatableObject
    {
        /// <summary>
        /// The autocomplete attribute for the input. email InputAttributeAutocompleteEmail tel InputAttributeAutocompleteTel url InputAttributeAutocompleteUrl current-password InputAttributeAutocompleteCurrentPassword new-password InputAttributeAutocompleteNewPassword one-time-code InputAttributeAutocompleteOneTimeCode
        /// </summary>
        /// <value>The autocomplete attribute for the input. email InputAttributeAutocompleteEmail tel InputAttributeAutocompleteTel url InputAttributeAutocompleteUrl current-password InputAttributeAutocompleteCurrentPassword new-password InputAttributeAutocompleteNewPassword one-time-code InputAttributeAutocompleteOneTimeCode</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AutocompleteEnum
        {
            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 1,

            /// <summary>
            /// Enum Tel for value: tel
            /// </summary>
            [EnumMember(Value = "tel")]
            Tel = 2,

            /// <summary>
            /// Enum Url for value: url
            /// </summary>
            [EnumMember(Value = "url")]
            Url = 3,

            /// <summary>
            /// Enum CurrentPassword for value: current-password
            /// </summary>
            [EnumMember(Value = "current-password")]
            CurrentPassword = 4,

            /// <summary>
            /// Enum NewPassword for value: new-password
            /// </summary>
            [EnumMember(Value = "new-password")]
            NewPassword = 5,

            /// <summary>
            /// Enum OneTimeCode for value: one-time-code
            /// </summary>
            [EnumMember(Value = "one-time-code")]
            OneTimeCode = 6
        }


        /// <summary>
        /// The autocomplete attribute for the input. email InputAttributeAutocompleteEmail tel InputAttributeAutocompleteTel url InputAttributeAutocompleteUrl current-password InputAttributeAutocompleteCurrentPassword new-password InputAttributeAutocompleteNewPassword one-time-code InputAttributeAutocompleteOneTimeCode
        /// </summary>
        /// <value>The autocomplete attribute for the input. email InputAttributeAutocompleteEmail tel InputAttributeAutocompleteTel url InputAttributeAutocompleteUrl current-password InputAttributeAutocompleteCurrentPassword new-password InputAttributeAutocompleteNewPassword one-time-code InputAttributeAutocompleteOneTimeCode</value>
        [DataMember(Name = "autocomplete", EmitDefaultValue = false)]
        public AutocompleteEnum? Autocomplete { get; set; }
        /// <summary>
        /// NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;input\&quot;. text Text input Input img Image a Anchor script Script div Division
        /// </summary>
        /// <value>NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;input\&quot;. text Text input Input img Image a Anchor script Script div Division</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NodeTypeEnum
        {
            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 1,

            /// <summary>
            /// Enum Input for value: input
            /// </summary>
            [EnumMember(Value = "input")]
            Input = 2,

            /// <summary>
            /// Enum Img for value: img
            /// </summary>
            [EnumMember(Value = "img")]
            Img = 3,

            /// <summary>
            /// Enum A for value: a
            /// </summary>
            [EnumMember(Value = "a")]
            A = 4,

            /// <summary>
            /// Enum Script for value: script
            /// </summary>
            [EnumMember(Value = "script")]
            Script = 5,

            /// <summary>
            /// Enum Div for value: div
            /// </summary>
            [EnumMember(Value = "div")]
            Div = 6
        }


        /// <summary>
        /// NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;input\&quot;. text Text input Input img Image a Anchor script Script div Division
        /// </summary>
        /// <value>NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;input\&quot;. text Text input Input img Image a Anchor script Script div Division</value>
        [DataMember(Name = "node_type", IsRequired = true, EmitDefaultValue = true)]
        public NodeTypeEnum NodeType { get; set; }
        /// <summary>
        /// OnClickTrigger may contain a WebAuthn trigger which should be executed on click.  The trigger maps to a JavaScript function provided by Ory, which triggers actions such as PassKey registration or login. oryWebAuthnRegistration WebAuthnTriggersWebAuthnRegistration oryWebAuthnLogin WebAuthnTriggersWebAuthnLogin oryPasskeyLogin WebAuthnTriggersPasskeyLogin oryPasskeyLoginAutocompleteInit WebAuthnTriggersPasskeyLoginAutocompleteInit oryPasskeyRegistration WebAuthnTriggersPasskeyRegistration oryPasskeySettingsRegistration WebAuthnTriggersPasskeySettingsRegistration
        /// </summary>
        /// <value>OnClickTrigger may contain a WebAuthn trigger which should be executed on click.  The trigger maps to a JavaScript function provided by Ory, which triggers actions such as PassKey registration or login. oryWebAuthnRegistration WebAuthnTriggersWebAuthnRegistration oryWebAuthnLogin WebAuthnTriggersWebAuthnLogin oryPasskeyLogin WebAuthnTriggersPasskeyLogin oryPasskeyLoginAutocompleteInit WebAuthnTriggersPasskeyLoginAutocompleteInit oryPasskeyRegistration WebAuthnTriggersPasskeyRegistration oryPasskeySettingsRegistration WebAuthnTriggersPasskeySettingsRegistration</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OnclickTriggerEnum
        {
            /// <summary>
            /// Enum OryWebAuthnRegistration for value: oryWebAuthnRegistration
            /// </summary>
            [EnumMember(Value = "oryWebAuthnRegistration")]
            OryWebAuthnRegistration = 1,

            /// <summary>
            /// Enum OryWebAuthnLogin for value: oryWebAuthnLogin
            /// </summary>
            [EnumMember(Value = "oryWebAuthnLogin")]
            OryWebAuthnLogin = 2,

            /// <summary>
            /// Enum OryPasskeyLogin for value: oryPasskeyLogin
            /// </summary>
            [EnumMember(Value = "oryPasskeyLogin")]
            OryPasskeyLogin = 3,

            /// <summary>
            /// Enum OryPasskeyLoginAutocompleteInit for value: oryPasskeyLoginAutocompleteInit
            /// </summary>
            [EnumMember(Value = "oryPasskeyLoginAutocompleteInit")]
            OryPasskeyLoginAutocompleteInit = 4,

            /// <summary>
            /// Enum OryPasskeyRegistration for value: oryPasskeyRegistration
            /// </summary>
            [EnumMember(Value = "oryPasskeyRegistration")]
            OryPasskeyRegistration = 5,

            /// <summary>
            /// Enum OryPasskeySettingsRegistration for value: oryPasskeySettingsRegistration
            /// </summary>
            [EnumMember(Value = "oryPasskeySettingsRegistration")]
            OryPasskeySettingsRegistration = 6
        }


        /// <summary>
        /// OnClickTrigger may contain a WebAuthn trigger which should be executed on click.  The trigger maps to a JavaScript function provided by Ory, which triggers actions such as PassKey registration or login. oryWebAuthnRegistration WebAuthnTriggersWebAuthnRegistration oryWebAuthnLogin WebAuthnTriggersWebAuthnLogin oryPasskeyLogin WebAuthnTriggersPasskeyLogin oryPasskeyLoginAutocompleteInit WebAuthnTriggersPasskeyLoginAutocompleteInit oryPasskeyRegistration WebAuthnTriggersPasskeyRegistration oryPasskeySettingsRegistration WebAuthnTriggersPasskeySettingsRegistration
        /// </summary>
        /// <value>OnClickTrigger may contain a WebAuthn trigger which should be executed on click.  The trigger maps to a JavaScript function provided by Ory, which triggers actions such as PassKey registration or login. oryWebAuthnRegistration WebAuthnTriggersWebAuthnRegistration oryWebAuthnLogin WebAuthnTriggersWebAuthnLogin oryPasskeyLogin WebAuthnTriggersPasskeyLogin oryPasskeyLoginAutocompleteInit WebAuthnTriggersPasskeyLoginAutocompleteInit oryPasskeyRegistration WebAuthnTriggersPasskeyRegistration oryPasskeySettingsRegistration WebAuthnTriggersPasskeySettingsRegistration</value>
        [DataMember(Name = "onclickTrigger", EmitDefaultValue = false)]
        public OnclickTriggerEnum? OnclickTrigger { get; set; }
        /// <summary>
        /// OnLoadTrigger may contain a WebAuthn trigger which should be executed on load.  The trigger maps to a JavaScript function provided by Ory, which triggers actions such as PassKey registration or login. oryWebAuthnRegistration WebAuthnTriggersWebAuthnRegistration oryWebAuthnLogin WebAuthnTriggersWebAuthnLogin oryPasskeyLogin WebAuthnTriggersPasskeyLogin oryPasskeyLoginAutocompleteInit WebAuthnTriggersPasskeyLoginAutocompleteInit oryPasskeyRegistration WebAuthnTriggersPasskeyRegistration oryPasskeySettingsRegistration WebAuthnTriggersPasskeySettingsRegistration
        /// </summary>
        /// <value>OnLoadTrigger may contain a WebAuthn trigger which should be executed on load.  The trigger maps to a JavaScript function provided by Ory, which triggers actions such as PassKey registration or login. oryWebAuthnRegistration WebAuthnTriggersWebAuthnRegistration oryWebAuthnLogin WebAuthnTriggersWebAuthnLogin oryPasskeyLogin WebAuthnTriggersPasskeyLogin oryPasskeyLoginAutocompleteInit WebAuthnTriggersPasskeyLoginAutocompleteInit oryPasskeyRegistration WebAuthnTriggersPasskeyRegistration oryPasskeySettingsRegistration WebAuthnTriggersPasskeySettingsRegistration</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OnloadTriggerEnum
        {
            /// <summary>
            /// Enum OryWebAuthnRegistration for value: oryWebAuthnRegistration
            /// </summary>
            [EnumMember(Value = "oryWebAuthnRegistration")]
            OryWebAuthnRegistration = 1,

            /// <summary>
            /// Enum OryWebAuthnLogin for value: oryWebAuthnLogin
            /// </summary>
            [EnumMember(Value = "oryWebAuthnLogin")]
            OryWebAuthnLogin = 2,

            /// <summary>
            /// Enum OryPasskeyLogin for value: oryPasskeyLogin
            /// </summary>
            [EnumMember(Value = "oryPasskeyLogin")]
            OryPasskeyLogin = 3,

            /// <summary>
            /// Enum OryPasskeyLoginAutocompleteInit for value: oryPasskeyLoginAutocompleteInit
            /// </summary>
            [EnumMember(Value = "oryPasskeyLoginAutocompleteInit")]
            OryPasskeyLoginAutocompleteInit = 4,

            /// <summary>
            /// Enum OryPasskeyRegistration for value: oryPasskeyRegistration
            /// </summary>
            [EnumMember(Value = "oryPasskeyRegistration")]
            OryPasskeyRegistration = 5,

            /// <summary>
            /// Enum OryPasskeySettingsRegistration for value: oryPasskeySettingsRegistration
            /// </summary>
            [EnumMember(Value = "oryPasskeySettingsRegistration")]
            OryPasskeySettingsRegistration = 6
        }


        /// <summary>
        /// OnLoadTrigger may contain a WebAuthn trigger which should be executed on load.  The trigger maps to a JavaScript function provided by Ory, which triggers actions such as PassKey registration or login. oryWebAuthnRegistration WebAuthnTriggersWebAuthnRegistration oryWebAuthnLogin WebAuthnTriggersWebAuthnLogin oryPasskeyLogin WebAuthnTriggersPasskeyLogin oryPasskeyLoginAutocompleteInit WebAuthnTriggersPasskeyLoginAutocompleteInit oryPasskeyRegistration WebAuthnTriggersPasskeyRegistration oryPasskeySettingsRegistration WebAuthnTriggersPasskeySettingsRegistration
        /// </summary>
        /// <value>OnLoadTrigger may contain a WebAuthn trigger which should be executed on load.  The trigger maps to a JavaScript function provided by Ory, which triggers actions such as PassKey registration or login. oryWebAuthnRegistration WebAuthnTriggersWebAuthnRegistration oryWebAuthnLogin WebAuthnTriggersWebAuthnLogin oryPasskeyLogin WebAuthnTriggersPasskeyLogin oryPasskeyLoginAutocompleteInit WebAuthnTriggersPasskeyLoginAutocompleteInit oryPasskeyRegistration WebAuthnTriggersPasskeyRegistration oryPasskeySettingsRegistration WebAuthnTriggersPasskeySettingsRegistration</value>
        [DataMember(Name = "onloadTrigger", EmitDefaultValue = false)]
        public OnloadTriggerEnum? OnloadTrigger { get; set; }
        /// <summary>
        /// The input&#39;s element type. text InputAttributeTypeText password InputAttributeTypePassword number InputAttributeTypeNumber checkbox InputAttributeTypeCheckbox hidden InputAttributeTypeHidden email InputAttributeTypeEmail tel InputAttributeTypeTel submit InputAttributeTypeSubmit button InputAttributeTypeButton datetime-local InputAttributeTypeDateTimeLocal date InputAttributeTypeDate url InputAttributeTypeURI
        /// </summary>
        /// <value>The input&#39;s element type. text InputAttributeTypeText password InputAttributeTypePassword number InputAttributeTypeNumber checkbox InputAttributeTypeCheckbox hidden InputAttributeTypeHidden email InputAttributeTypeEmail tel InputAttributeTypeTel submit InputAttributeTypeSubmit button InputAttributeTypeButton datetime-local InputAttributeTypeDateTimeLocal date InputAttributeTypeDate url InputAttributeTypeURI</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 1,

            /// <summary>
            /// Enum Password for value: password
            /// </summary>
            [EnumMember(Value = "password")]
            Password = 2,

            /// <summary>
            /// Enum Number for value: number
            /// </summary>
            [EnumMember(Value = "number")]
            Number = 3,

            /// <summary>
            /// Enum Checkbox for value: checkbox
            /// </summary>
            [EnumMember(Value = "checkbox")]
            Checkbox = 4,

            /// <summary>
            /// Enum Hidden for value: hidden
            /// </summary>
            [EnumMember(Value = "hidden")]
            Hidden = 5,

            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 6,

            /// <summary>
            /// Enum Tel for value: tel
            /// </summary>
            [EnumMember(Value = "tel")]
            Tel = 7,

            /// <summary>
            /// Enum Submit for value: submit
            /// </summary>
            [EnumMember(Value = "submit")]
            Submit = 8,

            /// <summary>
            /// Enum Button for value: button
            /// </summary>
            [EnumMember(Value = "button")]
            Button = 9,

            /// <summary>
            /// Enum DatetimeLocal for value: datetime-local
            /// </summary>
            [EnumMember(Value = "datetime-local")]
            DatetimeLocal = 10,

            /// <summary>
            /// Enum Date for value: date
            /// </summary>
            [EnumMember(Value = "date")]
            Date = 11,

            /// <summary>
            /// Enum Url for value: url
            /// </summary>
            [EnumMember(Value = "url")]
            Url = 12
        }


        /// <summary>
        /// The input&#39;s element type. text InputAttributeTypeText password InputAttributeTypePassword number InputAttributeTypeNumber checkbox InputAttributeTypeCheckbox hidden InputAttributeTypeHidden email InputAttributeTypeEmail tel InputAttributeTypeTel submit InputAttributeTypeSubmit button InputAttributeTypeButton datetime-local InputAttributeTypeDateTimeLocal date InputAttributeTypeDate url InputAttributeTypeURI
        /// </summary>
        /// <value>The input&#39;s element type. text InputAttributeTypeText password InputAttributeTypePassword number InputAttributeTypeNumber checkbox InputAttributeTypeCheckbox hidden InputAttributeTypeHidden email InputAttributeTypeEmail tel InputAttributeTypeTel submit InputAttributeTypeSubmit button InputAttributeTypeButton datetime-local InputAttributeTypeDateTimeLocal date InputAttributeTypeDate url InputAttributeTypeURI</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUiNodeInputAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientUiNodeInputAttributes()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientUiNodeInputAttributes" /> class.
        /// </summary>
        /// <param name="autocomplete">The autocomplete attribute for the input. email InputAttributeAutocompleteEmail tel InputAttributeAutocompleteTel url InputAttributeAutocompleteUrl current-password InputAttributeAutocompleteCurrentPassword new-password InputAttributeAutocompleteNewPassword one-time-code InputAttributeAutocompleteOneTimeCode.</param>
        /// <param name="disabled">Sets the input&#39;s disabled field to true or false. (required).</param>
        /// <param name="label">label.</param>
        /// <param name="maxlength">MaxLength may contain the input&#39;s maximum length..</param>
        /// <param name="name">The input&#39;s element name. (required).</param>
        /// <param name="nodeType">NodeType represents this node&#39;s types. It is a mirror of &#x60;node.type&#x60; and is primarily used to allow compatibility with OpenAPI 3.0.  In this struct it technically always is \&quot;input\&quot;. text Text input Input img Image a Anchor script Script div Division (required).</param>
        /// <param name="onclick">OnClick may contain javascript which should be executed on click. This is primarily used for WebAuthn.  Deprecated: Using OnClick requires the use of eval() which is a security risk. Use OnClickTrigger instead..</param>
        /// <param name="onclickTrigger">OnClickTrigger may contain a WebAuthn trigger which should be executed on click.  The trigger maps to a JavaScript function provided by Ory, which triggers actions such as PassKey registration or login. oryWebAuthnRegistration WebAuthnTriggersWebAuthnRegistration oryWebAuthnLogin WebAuthnTriggersWebAuthnLogin oryPasskeyLogin WebAuthnTriggersPasskeyLogin oryPasskeyLoginAutocompleteInit WebAuthnTriggersPasskeyLoginAutocompleteInit oryPasskeyRegistration WebAuthnTriggersPasskeyRegistration oryPasskeySettingsRegistration WebAuthnTriggersPasskeySettingsRegistration.</param>
        /// <param name="onload">OnLoad may contain javascript which should be executed on load. This is primarily used for WebAuthn.  Deprecated: Using OnLoad requires the use of eval() which is a security risk. Use OnLoadTrigger instead..</param>
        /// <param name="onloadTrigger">OnLoadTrigger may contain a WebAuthn trigger which should be executed on load.  The trigger maps to a JavaScript function provided by Ory, which triggers actions such as PassKey registration or login. oryWebAuthnRegistration WebAuthnTriggersWebAuthnRegistration oryWebAuthnLogin WebAuthnTriggersWebAuthnLogin oryPasskeyLogin WebAuthnTriggersPasskeyLogin oryPasskeyLoginAutocompleteInit WebAuthnTriggersPasskeyLoginAutocompleteInit oryPasskeyRegistration WebAuthnTriggersPasskeyRegistration oryPasskeySettingsRegistration WebAuthnTriggersPasskeySettingsRegistration.</param>
        /// <param name="pattern">The input&#39;s pattern..</param>
        /// <param name="required">Mark this input field as required..</param>
        /// <param name="type">The input&#39;s element type. text InputAttributeTypeText password InputAttributeTypePassword number InputAttributeTypeNumber checkbox InputAttributeTypeCheckbox hidden InputAttributeTypeHidden email InputAttributeTypeEmail tel InputAttributeTypeTel submit InputAttributeTypeSubmit button InputAttributeTypeButton datetime-local InputAttributeTypeDateTimeLocal date InputAttributeTypeDate url InputAttributeTypeURI (required).</param>
        /// <param name="value">The input&#39;s value..</param>
        public ClientUiNodeInputAttributes(AutocompleteEnum? autocomplete = default(AutocompleteEnum?), bool disabled = default(bool), ClientUiText label = default(ClientUiText), long maxlength = default(long), string name = default(string), NodeTypeEnum nodeType = default(NodeTypeEnum), string onclick = default(string), OnclickTriggerEnum? onclickTrigger = default(OnclickTriggerEnum?), string onload = default(string), OnloadTriggerEnum? onloadTrigger = default(OnloadTriggerEnum?), string pattern = default(string), bool required = default(bool), TypeEnum type = default(TypeEnum), Object value = default(Object))
        {
            this.Disabled = disabled;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ClientUiNodeInputAttributes and cannot be null");
            }
            this.Name = name;
            this.NodeType = nodeType;
            this.Type = type;
            this.Autocomplete = autocomplete;
            this.Label = label;
            this.Maxlength = maxlength;
            this.Onclick = onclick;
            this.OnclickTrigger = onclickTrigger;
            this.Onload = onload;
            this.OnloadTrigger = onloadTrigger;
            this.Pattern = pattern;
            this.Required = required;
            this.Value = value;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Sets the input&#39;s disabled field to true or false.
        /// </summary>
        /// <value>Sets the input&#39;s disabled field to true or false.</value>
        [DataMember(Name = "disabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Disabled { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public ClientUiText Label { get; set; }

        /// <summary>
        /// MaxLength may contain the input&#39;s maximum length.
        /// </summary>
        /// <value>MaxLength may contain the input&#39;s maximum length.</value>
        [DataMember(Name = "maxlength", EmitDefaultValue = false)]
        public long Maxlength { get; set; }

        /// <summary>
        /// The input&#39;s element name.
        /// </summary>
        /// <value>The input&#39;s element name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// OnClick may contain javascript which should be executed on click. This is primarily used for WebAuthn.  Deprecated: Using OnClick requires the use of eval() which is a security risk. Use OnClickTrigger instead.
        /// </summary>
        /// <value>OnClick may contain javascript which should be executed on click. This is primarily used for WebAuthn.  Deprecated: Using OnClick requires the use of eval() which is a security risk. Use OnClickTrigger instead.</value>
        [DataMember(Name = "onclick", EmitDefaultValue = false)]
        public string Onclick { get; set; }

        /// <summary>
        /// OnLoad may contain javascript which should be executed on load. This is primarily used for WebAuthn.  Deprecated: Using OnLoad requires the use of eval() which is a security risk. Use OnLoadTrigger instead.
        /// </summary>
        /// <value>OnLoad may contain javascript which should be executed on load. This is primarily used for WebAuthn.  Deprecated: Using OnLoad requires the use of eval() which is a security risk. Use OnLoadTrigger instead.</value>
        [DataMember(Name = "onload", EmitDefaultValue = false)]
        public string Onload { get; set; }

        /// <summary>
        /// The input&#39;s pattern.
        /// </summary>
        /// <value>The input&#39;s pattern.</value>
        [DataMember(Name = "pattern", EmitDefaultValue = false)]
        public string Pattern { get; set; }

        /// <summary>
        /// Mark this input field as required.
        /// </summary>
        /// <value>Mark this input field as required.</value>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// The input&#39;s value.
        /// </summary>
        /// <value>The input&#39;s value.</value>
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
            sb.Append("class ClientUiNodeInputAttributes {\n");
            sb.Append("  Autocomplete: ").Append(Autocomplete).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Maxlength: ").Append(Maxlength).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NodeType: ").Append(NodeType).Append("\n");
            sb.Append("  Onclick: ").Append(Onclick).Append("\n");
            sb.Append("  OnclickTrigger: ").Append(OnclickTrigger).Append("\n");
            sb.Append("  Onload: ").Append(Onload).Append("\n");
            sb.Append("  OnloadTrigger: ").Append(OnloadTrigger).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
