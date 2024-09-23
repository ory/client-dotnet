/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.3
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
    /// ClientProjectBrandingTheme
    /// </summary>
    [DataContract(Name = "projectBrandingTheme")]
    public partial class ClientProjectBrandingTheme : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProjectBrandingTheme" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientProjectBrandingTheme()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProjectBrandingTheme" /> class.
        /// </summary>
        /// <param name="accentDefaultColor">AccentDefaultColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="accentDisabledColor">AccentDisabledColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="accentEmphasisColor">AccentEmphasisColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="accentMutedColor">AccentMutedColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="accentSubtleColor">AccentSubtleColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="accountExperienceVariables">The Account Experience Theme Variables..</param>
        /// <param name="accountExperienceVariablesStylesheet">AccountExperienceVariableStylesheet holds a reference to the current stylesheet that can be used in the AX.</param>
        /// <param name="backgroundCanvasColor">BackgroundCanvasColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="backgroundSubtleColor">BackgroundSubtleColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="backgroundSurfaceColor">BackgroundSurfaceColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="borderDefaultColor">BorderDefaultColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="errorDefaultColor">ErrorDefaultColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="errorEmphasisColor">ErrorEmphasisColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="errorMutedColor">ErrorMutedColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="errorSubtleColor">ErrorSubtleColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="faviconType">Favicon Type The Favicon mime type..</param>
        /// <param name="faviconUrl">Favicon URL Favicon can be an https:// or base64:// URL. If the URL is not allowed, the favicon will be stored inside the Ory Network storage bucket..</param>
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
        /// <param name="logoType">Logo Type The Logo mime type..</param>
        /// <param name="logoUrl">Logo URL Logo can be an https:// or base64:// URL. If the URL is not allowed, the logo will be stored inside the Ory Network storage bucket..</param>
        /// <param name="name">The customization theme name. (required).</param>
        /// <param name="primaryColor">Primary color is an hsla color value used to derive the other colors from for the Ory Account Experience theme..</param>
        /// <param name="projectBrandingId">The ProjectBranding ID this customization is associated with. (required).</param>
        /// <param name="secondaryColor">Secondary color is a hsla color code used to derive the other colors from for the Ory Account Experience theme..</param>
        /// <param name="successEmphasisColor">SuccessEmphasisColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="textDefaultColor">TextDefaultColor is a hex color code used by the Ory Account Experience theme..</param>
        /// <param name="textDisabledColor">TextDisabledColor is a hex color code used by the Ory Account Experience theme..</param>
        public ClientProjectBrandingTheme(string accentDefaultColor = default(string), string accentDisabledColor = default(string), string accentEmphasisColor = default(string), string accentMutedColor = default(string), string accentSubtleColor = default(string), List<ClientAccountExperienceThemeVariables> accountExperienceVariables = default(List<ClientAccountExperienceThemeVariables>), string accountExperienceVariablesStylesheet = default(string), string backgroundCanvasColor = default(string), string backgroundSubtleColor = default(string), string backgroundSurfaceColor = default(string), string borderDefaultColor = default(string), string errorDefaultColor = default(string), string errorEmphasisColor = default(string), string errorMutedColor = default(string), string errorSubtleColor = default(string), string faviconType = default(string), string faviconUrl = default(string), string foregroundDefaultColor = default(string), string foregroundDisabledColor = default(string), string foregroundMutedColor = default(string), string foregroundOnAccentColor = default(string), string foregroundOnDarkColor = default(string), string foregroundOnDisabledColor = default(string), string foregroundSubtleColor = default(string), string inputBackgroundColor = default(string), string inputDisabledColor = default(string), string inputPlaceholderColor = default(string), string inputTextColor = default(string), string logoType = default(string), string logoUrl = default(string), string name = default(string), string primaryColor = default(string), string projectBrandingId = default(string), string secondaryColor = default(string), string successEmphasisColor = default(string), string textDefaultColor = default(string), string textDisabledColor = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ClientProjectBrandingTheme and cannot be null");
            }
            this.Name = name;
            // to ensure "projectBrandingId" is required (not null)
            if (projectBrandingId == null)
            {
                throw new ArgumentNullException("projectBrandingId is a required property for ClientProjectBrandingTheme and cannot be null");
            }
            this.ProjectBrandingId = projectBrandingId;
            this.AccentDefaultColor = accentDefaultColor;
            this.AccentDisabledColor = accentDisabledColor;
            this.AccentEmphasisColor = accentEmphasisColor;
            this.AccentMutedColor = accentMutedColor;
            this.AccentSubtleColor = accentSubtleColor;
            this.AccountExperienceVariables = accountExperienceVariables;
            this.AccountExperienceVariablesStylesheet = accountExperienceVariablesStylesheet;
            this.BackgroundCanvasColor = backgroundCanvasColor;
            this.BackgroundSubtleColor = backgroundSubtleColor;
            this.BackgroundSurfaceColor = backgroundSurfaceColor;
            this.BorderDefaultColor = borderDefaultColor;
            this.ErrorDefaultColor = errorDefaultColor;
            this.ErrorEmphasisColor = errorEmphasisColor;
            this.ErrorMutedColor = errorMutedColor;
            this.ErrorSubtleColor = errorSubtleColor;
            this.FaviconType = faviconType;
            this.FaviconUrl = faviconUrl;
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
            this.LogoType = logoType;
            this.LogoUrl = logoUrl;
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
        /// The Account Experience Theme Variables.
        /// </summary>
        /// <value>The Account Experience Theme Variables.</value>
        [DataMember(Name = "account_experience_variables", EmitDefaultValue = false)]
        public List<ClientAccountExperienceThemeVariables> AccountExperienceVariables { get; set; }

        /// <summary>
        /// AccountExperienceVariableStylesheet holds a reference to the current stylesheet that can be used in the AX
        /// </summary>
        /// <value>AccountExperienceVariableStylesheet holds a reference to the current stylesheet that can be used in the AX</value>
        [DataMember(Name = "account_experience_variables_stylesheet", EmitDefaultValue = false)]
        public string AccountExperienceVariablesStylesheet { get; set; }

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
        /// The Customization Creation Date.
        /// </summary>
        /// <value>The Customization Creation Date.</value>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
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
        /// Favicon Type The Favicon mime type.
        /// </summary>
        /// <value>Favicon Type The Favicon mime type.</value>
        [DataMember(Name = "favicon_type", EmitDefaultValue = false)]
        public string FaviconType { get; set; }

        /// <summary>
        /// Favicon URL Favicon can be an https:// or base64:// URL. If the URL is not allowed, the favicon will be stored inside the Ory Network storage bucket.
        /// </summary>
        /// <value>Favicon URL Favicon can be an https:// or base64:// URL. If the URL is not allowed, the favicon will be stored inside the Ory Network storage bucket.</value>
        [DataMember(Name = "favicon_url", EmitDefaultValue = false)]
        public string FaviconUrl { get; set; }

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
        /// The customization theme ID.
        /// </summary>
        /// <value>The customization theme ID.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
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
        /// Logo Type The Logo mime type.
        /// </summary>
        /// <value>Logo Type The Logo mime type.</value>
        [DataMember(Name = "logo_type", EmitDefaultValue = false)]
        public string LogoType { get; set; }

        /// <summary>
        /// Logo URL Logo can be an https:// or base64:// URL. If the URL is not allowed, the logo will be stored inside the Ory Network storage bucket.
        /// </summary>
        /// <value>Logo URL Logo can be an https:// or base64:// URL. If the URL is not allowed, the logo will be stored inside the Ory Network storage bucket.</value>
        [DataMember(Name = "logo_url", EmitDefaultValue = false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// The customization theme name.
        /// </summary>
        /// <value>The customization theme name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Primary color is an hsla color value used to derive the other colors from for the Ory Account Experience theme.
        /// </summary>
        /// <value>Primary color is an hsla color value used to derive the other colors from for the Ory Account Experience theme.</value>
        [DataMember(Name = "primary_color", EmitDefaultValue = false)]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// The ProjectBranding ID this customization is associated with.
        /// </summary>
        /// <value>The ProjectBranding ID this customization is associated with.</value>
        [DataMember(Name = "project_branding_id", IsRequired = true, EmitDefaultValue = true)]
        public string ProjectBrandingId { get; set; }

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
        /// Last Time Branding was Updated.
        /// </summary>
        /// <value>Last Time Branding was Updated.</value>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
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
            sb.Append("class ClientProjectBrandingTheme {\n");
            sb.Append("  AccentDefaultColor: ").Append(AccentDefaultColor).Append("\n");
            sb.Append("  AccentDisabledColor: ").Append(AccentDisabledColor).Append("\n");
            sb.Append("  AccentEmphasisColor: ").Append(AccentEmphasisColor).Append("\n");
            sb.Append("  AccentMutedColor: ").Append(AccentMutedColor).Append("\n");
            sb.Append("  AccentSubtleColor: ").Append(AccentSubtleColor).Append("\n");
            sb.Append("  AccountExperienceVariables: ").Append(AccountExperienceVariables).Append("\n");
            sb.Append("  AccountExperienceVariablesStylesheet: ").Append(AccountExperienceVariablesStylesheet).Append("\n");
            sb.Append("  BackgroundCanvasColor: ").Append(BackgroundCanvasColor).Append("\n");
            sb.Append("  BackgroundSubtleColor: ").Append(BackgroundSubtleColor).Append("\n");
            sb.Append("  BackgroundSurfaceColor: ").Append(BackgroundSurfaceColor).Append("\n");
            sb.Append("  BorderDefaultColor: ").Append(BorderDefaultColor).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ErrorDefaultColor: ").Append(ErrorDefaultColor).Append("\n");
            sb.Append("  ErrorEmphasisColor: ").Append(ErrorEmphasisColor).Append("\n");
            sb.Append("  ErrorMutedColor: ").Append(ErrorMutedColor).Append("\n");
            sb.Append("  ErrorSubtleColor: ").Append(ErrorSubtleColor).Append("\n");
            sb.Append("  FaviconType: ").Append(FaviconType).Append("\n");
            sb.Append("  FaviconUrl: ").Append(FaviconUrl).Append("\n");
            sb.Append("  ForegroundDefaultColor: ").Append(ForegroundDefaultColor).Append("\n");
            sb.Append("  ForegroundDisabledColor: ").Append(ForegroundDisabledColor).Append("\n");
            sb.Append("  ForegroundMutedColor: ").Append(ForegroundMutedColor).Append("\n");
            sb.Append("  ForegroundOnAccentColor: ").Append(ForegroundOnAccentColor).Append("\n");
            sb.Append("  ForegroundOnDarkColor: ").Append(ForegroundOnDarkColor).Append("\n");
            sb.Append("  ForegroundOnDisabledColor: ").Append(ForegroundOnDisabledColor).Append("\n");
            sb.Append("  ForegroundSubtleColor: ").Append(ForegroundSubtleColor).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InputBackgroundColor: ").Append(InputBackgroundColor).Append("\n");
            sb.Append("  InputDisabledColor: ").Append(InputDisabledColor).Append("\n");
            sb.Append("  InputPlaceholderColor: ").Append(InputPlaceholderColor).Append("\n");
            sb.Append("  InputTextColor: ").Append(InputTextColor).Append("\n");
            sb.Append("  LogoType: ").Append(LogoType).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PrimaryColor: ").Append(PrimaryColor).Append("\n");
            sb.Append("  ProjectBrandingId: ").Append(ProjectBrandingId).Append("\n");
            sb.Append("  SecondaryColor: ").Append(SecondaryColor).Append("\n");
            sb.Append("  SuccessEmphasisColor: ").Append(SuccessEmphasisColor).Append("\n");
            sb.Append("  TextDefaultColor: ").Append(TextDefaultColor).Append("\n");
            sb.Append("  TextDisabledColor: ").Append(TextDisabledColor).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
