/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.58
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
    /// ClientProjectPatch
    /// </summary>
    [DataContract(Name = "projectPatch")]
    public partial class ClientProjectPatch : IEquatable<ClientProjectPatch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProjectPatch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientProjectPatch()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProjectPatch" /> class.
        /// </summary>
        /// <param name="apiUrl">URL of Project API  In the future will allow to override Kratos project URL. If set, error is returned. If left empty our hosted URL is used.</param>
        /// <param name="applicationUrl">URL where your application is available.  Your users will be redirected to this URL when they successfully complete a login, logout, verification, recovery, or registration flow. More fine-grained redirection patterns are available for the individual flows (login, registration, ...).  If left empty, our hosted URL will be used instead. It contains technical information on the identities and is useful when developing a new project or trying out Ory Cloud..</param>
        /// <param name="defaultIdentitySchemaUrl">Default Identity Schema URL  This represents your Ory Kratos Default Identity Schema. It is your identity&#39;s default schema. This allows setting custom fields such as \&quot;address\&quot;, specifying whether you want to log in using email or a username, and more. For more information on this topic, please check out the identity documentation.  If KratosCustomSchemaID is also added to the payload, it will be preferred and replace the value of DefaultIdentitySchemaURL set by the client.  The value of this field can be either any \&quot;https://\&quot; URL - for example a file hosted at GitHub, or a &#x60;preset://&#x60;-prefixed string.  Available presets are:  preset://email preset://username preset://basic preset://blank.</param>
        /// <param name="errorUiUrl">Self-Service Error UI URL  Sets the UI URL for the error UI. If left empty, this will use Ory&#39;s hosted pages. (required).</param>
        /// <param name="kratosCustomSchemaId">The Custom Schema ID  The custom schema ID is a preferred field over DefaultIdentitySchemaURL, meaning it will override the DefaultIdentitySchemaURL with the custom schema&#39;s URL instead of accepting it from the client-side. Once this field is set the given custom schema will be associated with this project..</param>
        /// <param name="loginUiUrl">Self-Service Login UI URL  Sets the UI URL for the login UI. If left empty, this will use Ory&#39;s hosted pages. (required).</param>
        /// <param name="lookupSecret">lookupSecret (required).</param>
        /// <param name="name">The project name.  Helps you identify your project.  in: body.</param>
        /// <param name="password">password (required).</param>
        /// <param name="recovery">recovery (required).</param>
        /// <param name="recoveryUiUrl">Self-Service Login UI URL  Sets the UI URL for the recovery UI. If left empty, this will use Ory&#39;s hosted pages. (required).</param>
        /// <param name="redirectionConfig">redirectionConfig.</param>
        /// <param name="registrationUiUrl">Self-Service Login UI URL  Sets the UI URL for the registration UI. If left empty, this will use Ory&#39;s hosted pages. (required).</param>
        /// <param name="sessionAfterSignUp">Issue Session after Sign Up  If set to true, users will receive a session after they successfully signed up. Enabling this option allows account enumeration during registration flows. Read more: https://www.ory.sh/kratos/docs/self-service/flows/user-registration#successful-registration (required).</param>
        /// <param name="sessionSoft2fa">Enable Soft 2FA for Login Sessions (required).</param>
        /// <param name="settingsPrivilegedSessionMaxAgeSeconds">Duration in Seconds of how long a Session is Privileged  Defines how long a session is considered privileged in seconds. If the session&#39;s authenticated_at is older than the value specified here, the user needs to re-authenticate to perform certain actions (e.g. password change). (required).</param>
        /// <param name="settingsSoft2fa">Enable Soft 2FA for Self-Service Settings Flows (required).</param>
        /// <param name="settingsUiUrl">Self-Service Settings UI URL  Sets the UI URL for the settings UI. If left empty, this will use Ory&#39;s hosted pages. (required).</param>
        /// <param name="totp">totp (required).</param>
        /// <param name="verification">verification (required).</param>
        /// <param name="verificationUiUrl">Self-Service Login UI URL  Sets the UI URL for the verification UI. If left empty, this will use Ory&#39;s hosted pages. (required).</param>
        /// <param name="webauthn">webauthn (required).</param>
        public ClientProjectPatch(string apiUrl = default(string), string applicationUrl = default(string), string defaultIdentitySchemaUrl = default(string), string errorUiUrl = default(string), string kratosCustomSchemaId = default(string), string loginUiUrl = default(string), ClientProjectLookupSecretConfig lookupSecret = default(ClientProjectLookupSecretConfig), string name = default(string), ClientProjectPasswordConfig password = default(ClientProjectPasswordConfig), ClientProjectRecoveryConfig recovery = default(ClientProjectRecoveryConfig), string recoveryUiUrl = default(string), ClientRedirectionConfig redirectionConfig = default(ClientRedirectionConfig), string registrationUiUrl = default(string), bool sessionAfterSignUp = default(bool), bool sessionSoft2fa = default(bool), long settingsPrivilegedSessionMaxAgeSeconds = default(long), bool settingsSoft2fa = default(bool), string settingsUiUrl = default(string), ClientProjectTotpConfig totp = default(ClientProjectTotpConfig), ClientProjectVerificationConfig verification = default(ClientProjectVerificationConfig), string verificationUiUrl = default(string), ClientProjectWebAuthnConfig webauthn = default(ClientProjectWebAuthnConfig))
        {
            // to ensure "errorUiUrl" is required (not null)
            if (errorUiUrl == null) {
                throw new ArgumentNullException("errorUiUrl is a required property for ClientProjectPatch and cannot be null");
            }
            this.ErrorUiUrl = errorUiUrl;
            // to ensure "loginUiUrl" is required (not null)
            if (loginUiUrl == null) {
                throw new ArgumentNullException("loginUiUrl is a required property for ClientProjectPatch and cannot be null");
            }
            this.LoginUiUrl = loginUiUrl;
            // to ensure "lookupSecret" is required (not null)
            if (lookupSecret == null) {
                throw new ArgumentNullException("lookupSecret is a required property for ClientProjectPatch and cannot be null");
            }
            this.LookupSecret = lookupSecret;
            // to ensure "password" is required (not null)
            if (password == null) {
                throw new ArgumentNullException("password is a required property for ClientProjectPatch and cannot be null");
            }
            this.Password = password;
            // to ensure "recovery" is required (not null)
            if (recovery == null) {
                throw new ArgumentNullException("recovery is a required property for ClientProjectPatch and cannot be null");
            }
            this.Recovery = recovery;
            // to ensure "recoveryUiUrl" is required (not null)
            if (recoveryUiUrl == null) {
                throw new ArgumentNullException("recoveryUiUrl is a required property for ClientProjectPatch and cannot be null");
            }
            this.RecoveryUiUrl = recoveryUiUrl;
            // to ensure "registrationUiUrl" is required (not null)
            if (registrationUiUrl == null) {
                throw new ArgumentNullException("registrationUiUrl is a required property for ClientProjectPatch and cannot be null");
            }
            this.RegistrationUiUrl = registrationUiUrl;
            this.SessionAfterSignUp = sessionAfterSignUp;
            this.SessionSoft2fa = sessionSoft2fa;
            this.SettingsPrivilegedSessionMaxAgeSeconds = settingsPrivilegedSessionMaxAgeSeconds;
            this.SettingsSoft2fa = settingsSoft2fa;
            // to ensure "settingsUiUrl" is required (not null)
            if (settingsUiUrl == null) {
                throw new ArgumentNullException("settingsUiUrl is a required property for ClientProjectPatch and cannot be null");
            }
            this.SettingsUiUrl = settingsUiUrl;
            // to ensure "totp" is required (not null)
            if (totp == null) {
                throw new ArgumentNullException("totp is a required property for ClientProjectPatch and cannot be null");
            }
            this.Totp = totp;
            // to ensure "verification" is required (not null)
            if (verification == null) {
                throw new ArgumentNullException("verification is a required property for ClientProjectPatch and cannot be null");
            }
            this.Verification = verification;
            // to ensure "verificationUiUrl" is required (not null)
            if (verificationUiUrl == null) {
                throw new ArgumentNullException("verificationUiUrl is a required property for ClientProjectPatch and cannot be null");
            }
            this.VerificationUiUrl = verificationUiUrl;
            // to ensure "webauthn" is required (not null)
            if (webauthn == null) {
                throw new ArgumentNullException("webauthn is a required property for ClientProjectPatch and cannot be null");
            }
            this.Webauthn = webauthn;
            this.ApiUrl = apiUrl;
            this.ApplicationUrl = applicationUrl;
            this.DefaultIdentitySchemaUrl = defaultIdentitySchemaUrl;
            this.KratosCustomSchemaId = kratosCustomSchemaId;
            this.Name = name;
            this.RedirectionConfig = redirectionConfig;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// URL of Project API  In the future will allow to override Kratos project URL. If set, error is returned. If left empty our hosted URL is used
        /// </summary>
        /// <value>URL of Project API  In the future will allow to override Kratos project URL. If set, error is returned. If left empty our hosted URL is used</value>
        [DataMember(Name = "api_url", EmitDefaultValue = false)]
        public string ApiUrl { get; set; }

        /// <summary>
        /// URL where your application is available.  Your users will be redirected to this URL when they successfully complete a login, logout, verification, recovery, or registration flow. More fine-grained redirection patterns are available for the individual flows (login, registration, ...).  If left empty, our hosted URL will be used instead. It contains technical information on the identities and is useful when developing a new project or trying out Ory Cloud.
        /// </summary>
        /// <value>URL where your application is available.  Your users will be redirected to this URL when they successfully complete a login, logout, verification, recovery, or registration flow. More fine-grained redirection patterns are available for the individual flows (login, registration, ...).  If left empty, our hosted URL will be used instead. It contains technical information on the identities and is useful when developing a new project or trying out Ory Cloud.</value>
        [DataMember(Name = "application_url", EmitDefaultValue = false)]
        public string ApplicationUrl { get; set; }

        /// <summary>
        /// Default Identity Schema URL  This represents your Ory Kratos Default Identity Schema. It is your identity&#39;s default schema. This allows setting custom fields such as \&quot;address\&quot;, specifying whether you want to log in using email or a username, and more. For more information on this topic, please check out the identity documentation.  If KratosCustomSchemaID is also added to the payload, it will be preferred and replace the value of DefaultIdentitySchemaURL set by the client.  The value of this field can be either any \&quot;https://\&quot; URL - for example a file hosted at GitHub, or a &#x60;preset://&#x60;-prefixed string.  Available presets are:  preset://email preset://username preset://basic preset://blank
        /// </summary>
        /// <value>Default Identity Schema URL  This represents your Ory Kratos Default Identity Schema. It is your identity&#39;s default schema. This allows setting custom fields such as \&quot;address\&quot;, specifying whether you want to log in using email or a username, and more. For more information on this topic, please check out the identity documentation.  If KratosCustomSchemaID is also added to the payload, it will be preferred and replace the value of DefaultIdentitySchemaURL set by the client.  The value of this field can be either any \&quot;https://\&quot; URL - for example a file hosted at GitHub, or a &#x60;preset://&#x60;-prefixed string.  Available presets are:  preset://email preset://username preset://basic preset://blank</value>
        [DataMember(Name = "default_identity_schema_url", EmitDefaultValue = false)]
        public string DefaultIdentitySchemaUrl { get; set; }

        /// <summary>
        /// Self-Service Error UI URL  Sets the UI URL for the error UI. If left empty, this will use Ory&#39;s hosted pages.
        /// </summary>
        /// <value>Self-Service Error UI URL  Sets the UI URL for the error UI. If left empty, this will use Ory&#39;s hosted pages.</value>
        [DataMember(Name = "error_ui_url", IsRequired = true, EmitDefaultValue = false)]
        public string ErrorUiUrl { get; set; }

        /// <summary>
        /// The Custom Schema ID  The custom schema ID is a preferred field over DefaultIdentitySchemaURL, meaning it will override the DefaultIdentitySchemaURL with the custom schema&#39;s URL instead of accepting it from the client-side. Once this field is set the given custom schema will be associated with this project.
        /// </summary>
        /// <value>The Custom Schema ID  The custom schema ID is a preferred field over DefaultIdentitySchemaURL, meaning it will override the DefaultIdentitySchemaURL with the custom schema&#39;s URL instead of accepting it from the client-side. Once this field is set the given custom schema will be associated with this project.</value>
        [DataMember(Name = "kratos_custom_schema_id", EmitDefaultValue = false)]
        public string KratosCustomSchemaId { get; set; }

        /// <summary>
        /// Self-Service Login UI URL  Sets the UI URL for the login UI. If left empty, this will use Ory&#39;s hosted pages.
        /// </summary>
        /// <value>Self-Service Login UI URL  Sets the UI URL for the login UI. If left empty, this will use Ory&#39;s hosted pages.</value>
        [DataMember(Name = "login_ui_url", IsRequired = true, EmitDefaultValue = false)]
        public string LoginUiUrl { get; set; }

        /// <summary>
        /// Gets or Sets LookupSecret
        /// </summary>
        [DataMember(Name = "lookup_secret", IsRequired = true, EmitDefaultValue = false)]
        public ClientProjectLookupSecretConfig LookupSecret { get; set; }

        /// <summary>
        /// The project name.  Helps you identify your project.  in: body
        /// </summary>
        /// <value>The project name.  Helps you identify your project.  in: body</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = false)]
        public ClientProjectPasswordConfig Password { get; set; }

        /// <summary>
        /// Gets or Sets Recovery
        /// </summary>
        [DataMember(Name = "recovery", IsRequired = true, EmitDefaultValue = false)]
        public ClientProjectRecoveryConfig Recovery { get; set; }

        /// <summary>
        /// Self-Service Login UI URL  Sets the UI URL for the recovery UI. If left empty, this will use Ory&#39;s hosted pages.
        /// </summary>
        /// <value>Self-Service Login UI URL  Sets the UI URL for the recovery UI. If left empty, this will use Ory&#39;s hosted pages.</value>
        [DataMember(Name = "recovery_ui_url", IsRequired = true, EmitDefaultValue = false)]
        public string RecoveryUiUrl { get; set; }

        /// <summary>
        /// Gets or Sets RedirectionConfig
        /// </summary>
        [DataMember(Name = "redirection_config", EmitDefaultValue = false)]
        public ClientRedirectionConfig RedirectionConfig { get; set; }

        /// <summary>
        /// Self-Service Login UI URL  Sets the UI URL for the registration UI. If left empty, this will use Ory&#39;s hosted pages.
        /// </summary>
        /// <value>Self-Service Login UI URL  Sets the UI URL for the registration UI. If left empty, this will use Ory&#39;s hosted pages.</value>
        [DataMember(Name = "registration_ui_url", IsRequired = true, EmitDefaultValue = false)]
        public string RegistrationUiUrl { get; set; }

        /// <summary>
        /// Issue Session after Sign Up  If set to true, users will receive a session after they successfully signed up. Enabling this option allows account enumeration during registration flows. Read more: https://www.ory.sh/kratos/docs/self-service/flows/user-registration#successful-registration
        /// </summary>
        /// <value>Issue Session after Sign Up  If set to true, users will receive a session after they successfully signed up. Enabling this option allows account enumeration during registration flows. Read more: https://www.ory.sh/kratos/docs/self-service/flows/user-registration#successful-registration</value>
        [DataMember(Name = "session_after_sign_up", IsRequired = true, EmitDefaultValue = true)]
        public bool SessionAfterSignUp { get; set; }

        /// <summary>
        /// Enable Soft 2FA for Login Sessions
        /// </summary>
        /// <value>Enable Soft 2FA for Login Sessions</value>
        [DataMember(Name = "session_soft_2fa", IsRequired = true, EmitDefaultValue = true)]
        public bool SessionSoft2fa { get; set; }

        /// <summary>
        /// Duration in Seconds of how long a Session is Privileged  Defines how long a session is considered privileged in seconds. If the session&#39;s authenticated_at is older than the value specified here, the user needs to re-authenticate to perform certain actions (e.g. password change).
        /// </summary>
        /// <value>Duration in Seconds of how long a Session is Privileged  Defines how long a session is considered privileged in seconds. If the session&#39;s authenticated_at is older than the value specified here, the user needs to re-authenticate to perform certain actions (e.g. password change).</value>
        [DataMember(Name = "settings_privileged_session_max_age_seconds", IsRequired = true, EmitDefaultValue = false)]
        public long SettingsPrivilegedSessionMaxAgeSeconds { get; set; }

        /// <summary>
        /// Enable Soft 2FA for Self-Service Settings Flows
        /// </summary>
        /// <value>Enable Soft 2FA for Self-Service Settings Flows</value>
        [DataMember(Name = "settings_soft_2fa", IsRequired = true, EmitDefaultValue = true)]
        public bool SettingsSoft2fa { get; set; }

        /// <summary>
        /// Self-Service Settings UI URL  Sets the UI URL for the settings UI. If left empty, this will use Ory&#39;s hosted pages.
        /// </summary>
        /// <value>Self-Service Settings UI URL  Sets the UI URL for the settings UI. If left empty, this will use Ory&#39;s hosted pages.</value>
        [DataMember(Name = "settings_ui_url", IsRequired = true, EmitDefaultValue = false)]
        public string SettingsUiUrl { get; set; }

        /// <summary>
        /// Gets or Sets Totp
        /// </summary>
        [DataMember(Name = "totp", IsRequired = true, EmitDefaultValue = false)]
        public ClientProjectTotpConfig Totp { get; set; }

        /// <summary>
        /// Gets or Sets Verification
        /// </summary>
        [DataMember(Name = "verification", IsRequired = true, EmitDefaultValue = false)]
        public ClientProjectVerificationConfig Verification { get; set; }

        /// <summary>
        /// Self-Service Login UI URL  Sets the UI URL for the verification UI. If left empty, this will use Ory&#39;s hosted pages.
        /// </summary>
        /// <value>Self-Service Login UI URL  Sets the UI URL for the verification UI. If left empty, this will use Ory&#39;s hosted pages.</value>
        [DataMember(Name = "verification_ui_url", IsRequired = true, EmitDefaultValue = false)]
        public string VerificationUiUrl { get; set; }

        /// <summary>
        /// Gets or Sets Webauthn
        /// </summary>
        [DataMember(Name = "webauthn", IsRequired = true, EmitDefaultValue = false)]
        public ClientProjectWebAuthnConfig Webauthn { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class ClientProjectPatch {\n");
            sb.Append("  ApiUrl: ").Append(ApiUrl).Append("\n");
            sb.Append("  ApplicationUrl: ").Append(ApplicationUrl).Append("\n");
            sb.Append("  DefaultIdentitySchemaUrl: ").Append(DefaultIdentitySchemaUrl).Append("\n");
            sb.Append("  ErrorUiUrl: ").Append(ErrorUiUrl).Append("\n");
            sb.Append("  KratosCustomSchemaId: ").Append(KratosCustomSchemaId).Append("\n");
            sb.Append("  LoginUiUrl: ").Append(LoginUiUrl).Append("\n");
            sb.Append("  LookupSecret: ").Append(LookupSecret).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Recovery: ").Append(Recovery).Append("\n");
            sb.Append("  RecoveryUiUrl: ").Append(RecoveryUiUrl).Append("\n");
            sb.Append("  RedirectionConfig: ").Append(RedirectionConfig).Append("\n");
            sb.Append("  RegistrationUiUrl: ").Append(RegistrationUiUrl).Append("\n");
            sb.Append("  SessionAfterSignUp: ").Append(SessionAfterSignUp).Append("\n");
            sb.Append("  SessionSoft2fa: ").Append(SessionSoft2fa).Append("\n");
            sb.Append("  SettingsPrivilegedSessionMaxAgeSeconds: ").Append(SettingsPrivilegedSessionMaxAgeSeconds).Append("\n");
            sb.Append("  SettingsSoft2fa: ").Append(SettingsSoft2fa).Append("\n");
            sb.Append("  SettingsUiUrl: ").Append(SettingsUiUrl).Append("\n");
            sb.Append("  Totp: ").Append(Totp).Append("\n");
            sb.Append("  Verification: ").Append(Verification).Append("\n");
            sb.Append("  VerificationUiUrl: ").Append(VerificationUiUrl).Append("\n");
            sb.Append("  Webauthn: ").Append(Webauthn).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientProjectPatch);
        }

        /// <summary>
        /// Returns true if ClientProjectPatch instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientProjectPatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientProjectPatch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiUrl == input.ApiUrl ||
                    (this.ApiUrl != null &&
                    this.ApiUrl.Equals(input.ApiUrl))
                ) && 
                (
                    this.ApplicationUrl == input.ApplicationUrl ||
                    (this.ApplicationUrl != null &&
                    this.ApplicationUrl.Equals(input.ApplicationUrl))
                ) && 
                (
                    this.DefaultIdentitySchemaUrl == input.DefaultIdentitySchemaUrl ||
                    (this.DefaultIdentitySchemaUrl != null &&
                    this.DefaultIdentitySchemaUrl.Equals(input.DefaultIdentitySchemaUrl))
                ) && 
                (
                    this.ErrorUiUrl == input.ErrorUiUrl ||
                    (this.ErrorUiUrl != null &&
                    this.ErrorUiUrl.Equals(input.ErrorUiUrl))
                ) && 
                (
                    this.KratosCustomSchemaId == input.KratosCustomSchemaId ||
                    (this.KratosCustomSchemaId != null &&
                    this.KratosCustomSchemaId.Equals(input.KratosCustomSchemaId))
                ) && 
                (
                    this.LoginUiUrl == input.LoginUiUrl ||
                    (this.LoginUiUrl != null &&
                    this.LoginUiUrl.Equals(input.LoginUiUrl))
                ) && 
                (
                    this.LookupSecret == input.LookupSecret ||
                    (this.LookupSecret != null &&
                    this.LookupSecret.Equals(input.LookupSecret))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Recovery == input.Recovery ||
                    (this.Recovery != null &&
                    this.Recovery.Equals(input.Recovery))
                ) && 
                (
                    this.RecoveryUiUrl == input.RecoveryUiUrl ||
                    (this.RecoveryUiUrl != null &&
                    this.RecoveryUiUrl.Equals(input.RecoveryUiUrl))
                ) && 
                (
                    this.RedirectionConfig == input.RedirectionConfig ||
                    (this.RedirectionConfig != null &&
                    this.RedirectionConfig.Equals(input.RedirectionConfig))
                ) && 
                (
                    this.RegistrationUiUrl == input.RegistrationUiUrl ||
                    (this.RegistrationUiUrl != null &&
                    this.RegistrationUiUrl.Equals(input.RegistrationUiUrl))
                ) && 
                (
                    this.SessionAfterSignUp == input.SessionAfterSignUp ||
                    this.SessionAfterSignUp.Equals(input.SessionAfterSignUp)
                ) && 
                (
                    this.SessionSoft2fa == input.SessionSoft2fa ||
                    this.SessionSoft2fa.Equals(input.SessionSoft2fa)
                ) && 
                (
                    this.SettingsPrivilegedSessionMaxAgeSeconds == input.SettingsPrivilegedSessionMaxAgeSeconds ||
                    this.SettingsPrivilegedSessionMaxAgeSeconds.Equals(input.SettingsPrivilegedSessionMaxAgeSeconds)
                ) && 
                (
                    this.SettingsSoft2fa == input.SettingsSoft2fa ||
                    this.SettingsSoft2fa.Equals(input.SettingsSoft2fa)
                ) && 
                (
                    this.SettingsUiUrl == input.SettingsUiUrl ||
                    (this.SettingsUiUrl != null &&
                    this.SettingsUiUrl.Equals(input.SettingsUiUrl))
                ) && 
                (
                    this.Totp == input.Totp ||
                    (this.Totp != null &&
                    this.Totp.Equals(input.Totp))
                ) && 
                (
                    this.Verification == input.Verification ||
                    (this.Verification != null &&
                    this.Verification.Equals(input.Verification))
                ) && 
                (
                    this.VerificationUiUrl == input.VerificationUiUrl ||
                    (this.VerificationUiUrl != null &&
                    this.VerificationUiUrl.Equals(input.VerificationUiUrl))
                ) && 
                (
                    this.Webauthn == input.Webauthn ||
                    (this.Webauthn != null &&
                    this.Webauthn.Equals(input.Webauthn))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
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
                if (this.ApiUrl != null)
                    hashCode = hashCode * 59 + this.ApiUrl.GetHashCode();
                if (this.ApplicationUrl != null)
                    hashCode = hashCode * 59 + this.ApplicationUrl.GetHashCode();
                if (this.DefaultIdentitySchemaUrl != null)
                    hashCode = hashCode * 59 + this.DefaultIdentitySchemaUrl.GetHashCode();
                if (this.ErrorUiUrl != null)
                    hashCode = hashCode * 59 + this.ErrorUiUrl.GetHashCode();
                if (this.KratosCustomSchemaId != null)
                    hashCode = hashCode * 59 + this.KratosCustomSchemaId.GetHashCode();
                if (this.LoginUiUrl != null)
                    hashCode = hashCode * 59 + this.LoginUiUrl.GetHashCode();
                if (this.LookupSecret != null)
                    hashCode = hashCode * 59 + this.LookupSecret.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Recovery != null)
                    hashCode = hashCode * 59 + this.Recovery.GetHashCode();
                if (this.RecoveryUiUrl != null)
                    hashCode = hashCode * 59 + this.RecoveryUiUrl.GetHashCode();
                if (this.RedirectionConfig != null)
                    hashCode = hashCode * 59 + this.RedirectionConfig.GetHashCode();
                if (this.RegistrationUiUrl != null)
                    hashCode = hashCode * 59 + this.RegistrationUiUrl.GetHashCode();
                hashCode = hashCode * 59 + this.SessionAfterSignUp.GetHashCode();
                hashCode = hashCode * 59 + this.SessionSoft2fa.GetHashCode();
                hashCode = hashCode * 59 + this.SettingsPrivilegedSessionMaxAgeSeconds.GetHashCode();
                hashCode = hashCode * 59 + this.SettingsSoft2fa.GetHashCode();
                if (this.SettingsUiUrl != null)
                    hashCode = hashCode * 59 + this.SettingsUiUrl.GetHashCode();
                if (this.Totp != null)
                    hashCode = hashCode * 59 + this.Totp.GetHashCode();
                if (this.Verification != null)
                    hashCode = hashCode * 59 + this.Verification.GetHashCode();
                if (this.VerificationUiUrl != null)
                    hashCode = hashCode * 59 + this.VerificationUiUrl.GetHashCode();
                if (this.Webauthn != null)
                    hashCode = hashCode * 59 + this.Webauthn.GetHashCode();
                if (this.AdditionalProperties != null)
                    hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
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

}
