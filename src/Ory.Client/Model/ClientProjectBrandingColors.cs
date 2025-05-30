/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.20.11
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
    /// ClientProjectBrandingColors
    /// </summary>
    [DataContract(Name = "projectBrandingColors")]
    public partial class ClientProjectBrandingColors : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProjectBrandingColors" /> class.
        /// </summary>
        /// <param name="accentDefaultColor">AccentDefaultColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="accentDisabledColor">AccentDisabledColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="accentEmphasisColor">AccentEmphasisColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="accentMutedColor">AccentMutedColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="accentSubtleColor">AccentSubtleColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="backgroundCanvasColor">BackgroundCanvasColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="backgroundSubtleColor">BackgroundSubtleColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="backgroundSurfaceColor">BackgroundSurfaceColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="borderDefaultColor">BorderDefaultColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="errorDefaultColor">ErrorDefaultColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="errorEmphasisColor">ErrorEmphasisColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="errorMutedColor">ErrorMutedColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="errorSubtleColor">ErrorSubtleColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="foregroundDefaultColor">ForegroundDefaultColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="foregroundDisabledColor">ForegroundDisabledColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="foregroundMutedColor">ForegroundMutedColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="foregroundOnAccentColor">ForegroundOnAccentColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="foregroundOnDarkColor">ForegroundOnDarkColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="foregroundOnDisabledColor">ForegroundOnDisabledColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="foregroundSubtleColor">ForegroundSubtleColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="inputBackgroundColor">InputBackgroundColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="inputDisabledColor">InputDisabledColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="inputPlaceholderColor">InputPlaceholderColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="inputTextColor">InputTextColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="primaryColor">Primary color is an hsla color value used to derive the other colors from for the Ory Account Experience theme..</param>
        /// <param name="secondaryColor">Secondary color is a hsla color code used to derive the other colors from for the Ory Account Experience theme..</param>
        /// <param name="successEmphasisColor">SuccessEmphasisColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="textDefaultColor">TextDefaultColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="textDisabledColor">TextDisabledColor is a hex color code used by the Ory Account Experience theme..</param>
        public ClientProjectBrandingColors(string accentDefaultColor = default(string), string accentDisabledColor = default(string), string accentEmphasisColor = default(string), string accentMutedColor = default(string), string accentSubtleColor = default(string), string backgroundCanvasColor = default(string), string backgroundSubtleColor = default(string), string backgroundSurfaceColor = default(string), string borderDefaultColor = default(string), string errorDefaultColor = default(string), string errorEmphasisColor = default(string), string errorMutedColor = default(string), string errorSubtleColor = default(string), string foregroundDefaultColor = default(string), string foregroundDisabledColor = default(string), string foregroundMutedColor = default(string), string foregroundOnAccentColor = default(string), string foregroundOnDarkColor = default(string), string foregroundOnDisabledColor = default(string), string foregroundSubtleColor = default(string), string inputBackgroundColor = default(string), string inputDisabledColor = default(string), string inputPlaceholderColor = default(string), string inputTextColor = default(string), string primaryColor = default(string), string secondaryColor = default(string), string successEmphasisColor = default(string), string textDefaultColor = default(string), string textDisabledColor = default(string))
        {
            this.AccentDefaultColor = accentDefaultColor;
            this.AccentDisabledColor = accentDisabledColor;
            this.AccentEmphasisColor = accentEmphasisColor;
            this.AccentMutedColor = accentMutedColor;
            this.AccentSubtleColor = accentSubtleColor;
            this.BackgroundCanvasColor = backgroundCanvasColor;
            this.BackgroundSubtleColor = backgroundSubtleColor;
            this.BackgroundSurfaceColor = backgroundSurfaceColor;
            this.BorderDefaultColor = borderDefaultColor;
            this.ErrorDefaultColor = errorDefaultColor;
            this.ErrorEmphasisColor = errorEmphasisColor;
            this.ErrorMutedColor = errorMutedColor;
            this.ErrorSubtleColor = errorSubtleColor;
            this.ForegroundDefaultColor = foregroundDefaultColor;
            this.ForegroundDisabledColor = foregroundDisabledColor;
            this.ForegroundMutedColor = foregroundMutedColor;
            this.ForegroundOnAccentColor = foregroundOnAccentColor;
            this.ForegroundOnDarkColor = foregroundOnDarkColor;
            this.ForegroundOnDisabledColor = foregroundOnDisabledColor;
            this.ForegroundSubtleColor = foregroundSubtleColor;
            this.InputBackgroundColor = inputBackgroundColor;
            this.InputDisabledColor = inputDisabledColor;
            this.InputPlaceholderColor = inputPlaceholderColor;
            this.InputTextColor = inputTextColor;
            this.PrimaryColor = primaryColor;
            this.SecondaryColor = secondaryColor;
            this.SuccessEmphasisColor = successEmphasisColor;
            this.TextDefaultColor = textDefaultColor;
            this.TextDisabledColor = textDisabledColor;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// AccentDefaultColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>AccentDefaultColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "accent_default_color", EmitDefaultValue = false)]
        public string AccentDefaultColor { get; set; }

        /// <summary>
        /// AccentDisabledColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>AccentDisabledColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "accent_disabled_color", EmitDefaultValue = false)]
        public string AccentDisabledColor { get; set; }

        /// <summary>
        /// AccentEmphasisColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>AccentEmphasisColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "accent_emphasis_color", EmitDefaultValue = false)]
        public string AccentEmphasisColor { get; set; }

        /// <summary>
        /// AccentMutedColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>AccentMutedColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "accent_muted_color", EmitDefaultValue = false)]
        public string AccentMutedColor { get; set; }

        /// <summary>
        /// AccentSubtleColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>AccentSubtleColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "accent_subtle_color", EmitDefaultValue = false)]
        public string AccentSubtleColor { get; set; }

        /// <summary>
        /// BackgroundCanvasColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>BackgroundCanvasColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "background_canvas_color", EmitDefaultValue = false)]
        public string BackgroundCanvasColor { get; set; }

        /// <summary>
        /// BackgroundSubtleColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>BackgroundSubtleColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "background_subtle_color", EmitDefaultValue = false)]
        public string BackgroundSubtleColor { get; set; }

        /// <summary>
        /// BackgroundSurfaceColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>BackgroundSurfaceColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "background_surface_color", EmitDefaultValue = false)]
        public string BackgroundSurfaceColor { get; set; }

        /// <summary>
        /// BorderDefaultColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>BorderDefaultColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "border_default_color", EmitDefaultValue = false)]
        public string BorderDefaultColor { get; set; }

        /// <summary>
        /// ErrorDefaultColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>ErrorDefaultColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "error_default_color", EmitDefaultValue = false)]
        public string ErrorDefaultColor { get; set; }

        /// <summary>
        /// ErrorEmphasisColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>ErrorEmphasisColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "error_emphasis_color", EmitDefaultValue = false)]
        public string ErrorEmphasisColor { get; set; }

        /// <summary>
        /// ErrorMutedColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>ErrorMutedColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "error_muted_color", EmitDefaultValue = false)]
        public string ErrorMutedColor { get; set; }

        /// <summary>
        /// ErrorSubtleColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>ErrorSubtleColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "error_subtle_color", EmitDefaultValue = false)]
        public string ErrorSubtleColor { get; set; }

        /// <summary>
        /// ForegroundDefaultColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>ForegroundDefaultColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "foreground_default_color", EmitDefaultValue = false)]
        public string ForegroundDefaultColor { get; set; }

        /// <summary>
        /// ForegroundDisabledColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>ForegroundDisabledColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "foreground_disabled_color", EmitDefaultValue = false)]
        public string ForegroundDisabledColor { get; set; }

        /// <summary>
        /// ForegroundMutedColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>ForegroundMutedColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "foreground_muted_color", EmitDefaultValue = false)]
        public string ForegroundMutedColor { get; set; }

        /// <summary>
        /// ForegroundOnAccentColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>ForegroundOnAccentColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "foreground_on_accent_color", EmitDefaultValue = false)]
        public string ForegroundOnAccentColor { get; set; }

        /// <summary>
        /// ForegroundOnDarkColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>ForegroundOnDarkColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "foreground_on_dark_color", EmitDefaultValue = false)]
        public string ForegroundOnDarkColor { get; set; }

        /// <summary>
        /// ForegroundOnDisabledColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>ForegroundOnDisabledColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "foreground_on_disabled_color", EmitDefaultValue = false)]
        public string ForegroundOnDisabledColor { get; set; }

        /// <summary>
        /// ForegroundSubtleColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>ForegroundSubtleColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "foreground_subtle_color", EmitDefaultValue = false)]
        public string ForegroundSubtleColor { get; set; }

        /// <summary>
        /// InputBackgroundColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>InputBackgroundColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "input_background_color", EmitDefaultValue = false)]
        public string InputBackgroundColor { get; set; }

        /// <summary>
        /// InputDisabledColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>InputDisabledColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "input_disabled_color", EmitDefaultValue = false)]
        public string InputDisabledColor { get; set; }

        /// <summary>
        /// InputPlaceholderColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>InputPlaceholderColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "input_placeholder_color", EmitDefaultValue = false)]
        public string InputPlaceholderColor { get; set; }

        /// <summary>
        /// InputTextColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>InputTextColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "input_text_color", EmitDefaultValue = false)]
        public string InputTextColor { get; set; }

        /// <summary>
        /// Primary color is an hsla color value used to derive the other colors from for the Ory Account Experience theme.
        /// </summary>
        /// <value>Primary color is an hsla color value used to derive the other colors from for the Ory Account Experience theme.</value>
        [DataMember(Name = "primary_color", EmitDefaultValue = false)]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// Secondary color is a hsla color code used to derive the other colors from for the Ory Account Experience theme.
        /// </summary>
        /// <value>Secondary color is a hsla color code used to derive the other colors from for the Ory Account Experience theme.</value>
        [DataMember(Name = "secondary_color", EmitDefaultValue = false)]
        public string SecondaryColor { get; set; }

        /// <summary>
        /// SuccessEmphasisColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>SuccessEmphasisColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "success_emphasis_color", EmitDefaultValue = false)]
        public string SuccessEmphasisColor { get; set; }

        /// <summary>
        /// TextDefaultColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>TextDefaultColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "text_default_color", EmitDefaultValue = false)]
        public string TextDefaultColor { get; set; }

        /// <summary>
        /// TextDisabledColor is a hex color code used by the Ory Account Experience theme.
        /// </summary>
        /// <value>TextDisabledColor is a hex color code used by the Ory Account Experience theme.</value>
        [DataMember(Name = "text_disabled_color", EmitDefaultValue = false)]
        public string TextDisabledColor { get; set; }

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
            sb.Append("class ClientProjectBrandingColors {\n");
            sb.Append("  AccentDefaultColor: ").Append(AccentDefaultColor).Append("\n");
            sb.Append("  AccentDisabledColor: ").Append(AccentDisabledColor).Append("\n");
            sb.Append("  AccentEmphasisColor: ").Append(AccentEmphasisColor).Append("\n");
            sb.Append("  AccentMutedColor: ").Append(AccentMutedColor).Append("\n");
            sb.Append("  AccentSubtleColor: ").Append(AccentSubtleColor).Append("\n");
            sb.Append("  BackgroundCanvasColor: ").Append(BackgroundCanvasColor).Append("\n");
            sb.Append("  BackgroundSubtleColor: ").Append(BackgroundSubtleColor).Append("\n");
            sb.Append("  BackgroundSurfaceColor: ").Append(BackgroundSurfaceColor).Append("\n");
            sb.Append("  BorderDefaultColor: ").Append(BorderDefaultColor).Append("\n");
            sb.Append("  ErrorDefaultColor: ").Append(ErrorDefaultColor).Append("\n");
            sb.Append("  ErrorEmphasisColor: ").Append(ErrorEmphasisColor).Append("\n");
            sb.Append("  ErrorMutedColor: ").Append(ErrorMutedColor).Append("\n");
            sb.Append("  ErrorSubtleColor: ").Append(ErrorSubtleColor).Append("\n");
            sb.Append("  ForegroundDefaultColor: ").Append(ForegroundDefaultColor).Append("\n");
            sb.Append("  ForegroundDisabledColor: ").Append(ForegroundDisabledColor).Append("\n");
            sb.Append("  ForegroundMutedColor: ").Append(ForegroundMutedColor).Append("\n");
            sb.Append("  ForegroundOnAccentColor: ").Append(ForegroundOnAccentColor).Append("\n");
            sb.Append("  ForegroundOnDarkColor: ").Append(ForegroundOnDarkColor).Append("\n");
            sb.Append("  ForegroundOnDisabledColor: ").Append(ForegroundOnDisabledColor).Append("\n");
            sb.Append("  ForegroundSubtleColor: ").Append(ForegroundSubtleColor).Append("\n");
            sb.Append("  InputBackgroundColor: ").Append(InputBackgroundColor).Append("\n");
            sb.Append("  InputDisabledColor: ").Append(InputDisabledColor).Append("\n");
            sb.Append("  InputPlaceholderColor: ").Append(InputPlaceholderColor).Append("\n");
            sb.Append("  InputTextColor: ").Append(InputTextColor).Append("\n");
            sb.Append("  PrimaryColor: ").Append(PrimaryColor).Append("\n");
            sb.Append("  SecondaryColor: ").Append(SecondaryColor).Append("\n");
            sb.Append("  SuccessEmphasisColor: ").Append(SuccessEmphasisColor).Append("\n");
            sb.Append("  TextDefaultColor: ").Append(TextDefaultColor).Append("\n");
            sb.Append("  TextDisabledColor: ").Append(TextDisabledColor).Append("\n");
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
