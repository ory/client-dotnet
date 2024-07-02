/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.12.2
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
    /// ClientQuotaUsage
    /// </summary>
    [DataContract(Name = "quotaUsage")]
    public partial class ClientQuotaUsage : IValidatableObject
    {
        /// <summary>
        ///  production_projects ProductionProjects staging_projects StagingProjects development_projects DevelopmentProjects daily_active_users DailyActiveUsers custom_domains CustomDomains event_streams EventStreams event_stream_events EventStreamEvents sla SLA collaborator_seats CollaboratorSeats edge_cache EdgeCache branding_themes BrandingThemes zendesk_support ZendeskSupport project_metrics ProjectMetrics project_metrics_time_window ProjectMetricsTimeWindow project_metrics_events_history ProjectMetricsEventsHistory organizations Organizations rop_grant ResourceOwnerPasswordGrant concierge_onboarding ConciergeOnboarding credit Credit data_location_global DataLocationGlobal m2m_token_issuance M2MTokenIssuance permission_checks PermissionChecks data_location_regional DataLocationRegional  Required Features rate_limit_tier RateLimitTier session_rate_limit_tier RateLimitTierSessions identities_list_rate_limit_tier RateLimitTierIdentitiesList permission_checks_rate_limit_tier RateLimitTierPermissionChecks oauth2_introspect_rate_limit_tier RateLimitTierOAuth2Introspect
        /// </summary>
        /// <value> production_projects ProductionProjects staging_projects StagingProjects development_projects DevelopmentProjects daily_active_users DailyActiveUsers custom_domains CustomDomains event_streams EventStreams event_stream_events EventStreamEvents sla SLA collaborator_seats CollaboratorSeats edge_cache EdgeCache branding_themes BrandingThemes zendesk_support ZendeskSupport project_metrics ProjectMetrics project_metrics_time_window ProjectMetricsTimeWindow project_metrics_events_history ProjectMetricsEventsHistory organizations Organizations rop_grant ResourceOwnerPasswordGrant concierge_onboarding ConciergeOnboarding credit Credit data_location_global DataLocationGlobal m2m_token_issuance M2MTokenIssuance permission_checks PermissionChecks data_location_regional DataLocationRegional  Required Features rate_limit_tier RateLimitTier session_rate_limit_tier RateLimitTierSessions identities_list_rate_limit_tier RateLimitTierIdentitiesList permission_checks_rate_limit_tier RateLimitTierPermissionChecks oauth2_introspect_rate_limit_tier RateLimitTierOAuth2Introspect</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FeatureEnum
        {
            /// <summary>
            /// Enum ProductionProjects for value: production_projects
            /// </summary>
            [EnumMember(Value = "production_projects")]
            ProductionProjects = 1,

            /// <summary>
            /// Enum StagingProjects for value: staging_projects
            /// </summary>
            [EnumMember(Value = "staging_projects")]
            StagingProjects = 2,

            /// <summary>
            /// Enum DevelopmentProjects for value: development_projects
            /// </summary>
            [EnumMember(Value = "development_projects")]
            DevelopmentProjects = 3,

            /// <summary>
            /// Enum DailyActiveUsers for value: daily_active_users
            /// </summary>
            [EnumMember(Value = "daily_active_users")]
            DailyActiveUsers = 4,

            /// <summary>
            /// Enum CustomDomains for value: custom_domains
            /// </summary>
            [EnumMember(Value = "custom_domains")]
            CustomDomains = 5,

            /// <summary>
            /// Enum EventStreams for value: event_streams
            /// </summary>
            [EnumMember(Value = "event_streams")]
            EventStreams = 6,

            /// <summary>
            /// Enum EventStreamEvents for value: event_stream_events
            /// </summary>
            [EnumMember(Value = "event_stream_events")]
            EventStreamEvents = 7,

            /// <summary>
            /// Enum Sla for value: sla
            /// </summary>
            [EnumMember(Value = "sla")]
            Sla = 8,

            /// <summary>
            /// Enum CollaboratorSeats for value: collaborator_seats
            /// </summary>
            [EnumMember(Value = "collaborator_seats")]
            CollaboratorSeats = 9,

            /// <summary>
            /// Enum EdgeCache for value: edge_cache
            /// </summary>
            [EnumMember(Value = "edge_cache")]
            EdgeCache = 10,

            /// <summary>
            /// Enum BrandingThemes for value: branding_themes
            /// </summary>
            [EnumMember(Value = "branding_themes")]
            BrandingThemes = 11,

            /// <summary>
            /// Enum ZendeskSupport for value: zendesk_support
            /// </summary>
            [EnumMember(Value = "zendesk_support")]
            ZendeskSupport = 12,

            /// <summary>
            /// Enum ProjectMetrics for value: project_metrics
            /// </summary>
            [EnumMember(Value = "project_metrics")]
            ProjectMetrics = 13,

            /// <summary>
            /// Enum ProjectMetricsTimeWindow for value: project_metrics_time_window
            /// </summary>
            [EnumMember(Value = "project_metrics_time_window")]
            ProjectMetricsTimeWindow = 14,

            /// <summary>
            /// Enum ProjectMetricsEventsHistory for value: project_metrics_events_history
            /// </summary>
            [EnumMember(Value = "project_metrics_events_history")]
            ProjectMetricsEventsHistory = 15,

            /// <summary>
            /// Enum Organizations for value: organizations
            /// </summary>
            [EnumMember(Value = "organizations")]
            Organizations = 16,

            /// <summary>
            /// Enum RopGrant for value: rop_grant
            /// </summary>
            [EnumMember(Value = "rop_grant")]
            RopGrant = 17,

            /// <summary>
            /// Enum ConciergeOnboarding for value: concierge_onboarding
            /// </summary>
            [EnumMember(Value = "concierge_onboarding")]
            ConciergeOnboarding = 18,

            /// <summary>
            /// Enum Credit for value: credit
            /// </summary>
            [EnumMember(Value = "credit")]
            Credit = 19,

            /// <summary>
            /// Enum DataLocationGlobal for value: data_location_global
            /// </summary>
            [EnumMember(Value = "data_location_global")]
            DataLocationGlobal = 20,

            /// <summary>
            /// Enum M2mTokenIssuance for value: m2m_token_issuance
            /// </summary>
            [EnumMember(Value = "m2m_token_issuance")]
            M2mTokenIssuance = 21,

            /// <summary>
            /// Enum PermissionChecks for value: permission_checks
            /// </summary>
            [EnumMember(Value = "permission_checks")]
            PermissionChecks = 22,

            /// <summary>
            /// Enum DataLocationRegional for value: data_location_regional
            /// </summary>
            [EnumMember(Value = "data_location_regional")]
            DataLocationRegional = 23,

            /// <summary>
            /// Enum RateLimitTier for value: rate_limit_tier
            /// </summary>
            [EnumMember(Value = "rate_limit_tier")]
            RateLimitTier = 24,

            /// <summary>
            /// Enum SessionRateLimitTier for value: session_rate_limit_tier
            /// </summary>
            [EnumMember(Value = "session_rate_limit_tier")]
            SessionRateLimitTier = 25,

            /// <summary>
            /// Enum IdentitiesListRateLimitTier for value: identities_list_rate_limit_tier
            /// </summary>
            [EnumMember(Value = "identities_list_rate_limit_tier")]
            IdentitiesListRateLimitTier = 26,

            /// <summary>
            /// Enum PermissionChecksRateLimitTier for value: permission_checks_rate_limit_tier
            /// </summary>
            [EnumMember(Value = "permission_checks_rate_limit_tier")]
            PermissionChecksRateLimitTier = 27,

            /// <summary>
            /// Enum Oauth2IntrospectRateLimitTier for value: oauth2_introspect_rate_limit_tier
            /// </summary>
            [EnumMember(Value = "oauth2_introspect_rate_limit_tier")]
            Oauth2IntrospectRateLimitTier = 28
        }


        /// <summary>
        ///  production_projects ProductionProjects staging_projects StagingProjects development_projects DevelopmentProjects daily_active_users DailyActiveUsers custom_domains CustomDomains event_streams EventStreams event_stream_events EventStreamEvents sla SLA collaborator_seats CollaboratorSeats edge_cache EdgeCache branding_themes BrandingThemes zendesk_support ZendeskSupport project_metrics ProjectMetrics project_metrics_time_window ProjectMetricsTimeWindow project_metrics_events_history ProjectMetricsEventsHistory organizations Organizations rop_grant ResourceOwnerPasswordGrant concierge_onboarding ConciergeOnboarding credit Credit data_location_global DataLocationGlobal m2m_token_issuance M2MTokenIssuance permission_checks PermissionChecks data_location_regional DataLocationRegional  Required Features rate_limit_tier RateLimitTier session_rate_limit_tier RateLimitTierSessions identities_list_rate_limit_tier RateLimitTierIdentitiesList permission_checks_rate_limit_tier RateLimitTierPermissionChecks oauth2_introspect_rate_limit_tier RateLimitTierOAuth2Introspect
        /// </summary>
        /// <value> production_projects ProductionProjects staging_projects StagingProjects development_projects DevelopmentProjects daily_active_users DailyActiveUsers custom_domains CustomDomains event_streams EventStreams event_stream_events EventStreamEvents sla SLA collaborator_seats CollaboratorSeats edge_cache EdgeCache branding_themes BrandingThemes zendesk_support ZendeskSupport project_metrics ProjectMetrics project_metrics_time_window ProjectMetricsTimeWindow project_metrics_events_history ProjectMetricsEventsHistory organizations Organizations rop_grant ResourceOwnerPasswordGrant concierge_onboarding ConciergeOnboarding credit Credit data_location_global DataLocationGlobal m2m_token_issuance M2MTokenIssuance permission_checks PermissionChecks data_location_regional DataLocationRegional  Required Features rate_limit_tier RateLimitTier session_rate_limit_tier RateLimitTierSessions identities_list_rate_limit_tier RateLimitTierIdentitiesList permission_checks_rate_limit_tier RateLimitTierPermissionChecks oauth2_introspect_rate_limit_tier RateLimitTierOAuth2Introspect</value>
        [DataMember(Name = "feature", IsRequired = true, EmitDefaultValue = true)]
        public FeatureEnum Feature { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientQuotaUsage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientQuotaUsage()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientQuotaUsage" /> class.
        /// </summary>
        /// <param name="additionalPrice">The additional price per unit in cents. (required).</param>
        /// <param name="canUseMore">canUseMore (required).</param>
        /// <param name="feature"> production_projects ProductionProjects staging_projects StagingProjects development_projects DevelopmentProjects daily_active_users DailyActiveUsers custom_domains CustomDomains event_streams EventStreams event_stream_events EventStreamEvents sla SLA collaborator_seats CollaboratorSeats edge_cache EdgeCache branding_themes BrandingThemes zendesk_support ZendeskSupport project_metrics ProjectMetrics project_metrics_time_window ProjectMetricsTimeWindow project_metrics_events_history ProjectMetricsEventsHistory organizations Organizations rop_grant ResourceOwnerPasswordGrant concierge_onboarding ConciergeOnboarding credit Credit data_location_global DataLocationGlobal m2m_token_issuance M2MTokenIssuance permission_checks PermissionChecks data_location_regional DataLocationRegional  Required Features rate_limit_tier RateLimitTier session_rate_limit_tier RateLimitTierSessions identities_list_rate_limit_tier RateLimitTierIdentitiesList permission_checks_rate_limit_tier RateLimitTierPermissionChecks oauth2_introspect_rate_limit_tier RateLimitTierOAuth2Introspect (required).</param>
        /// <param name="featureAvailable">featureAvailable (required).</param>
        /// <param name="included">included (required).</param>
        /// <param name="used">used (required).</param>
        public ClientQuotaUsage(string additionalPrice = default(string), bool canUseMore = default(bool), FeatureEnum feature = default(FeatureEnum), bool featureAvailable = default(bool), long included = default(long), long used = default(long))
        {
            // to ensure "additionalPrice" is required (not null)
            if (additionalPrice == null)
            {
                throw new ArgumentNullException("additionalPrice is a required property for ClientQuotaUsage and cannot be null");
            }
            this.AdditionalPrice = additionalPrice;
            this.CanUseMore = canUseMore;
            this.Feature = feature;
            this.FeatureAvailable = featureAvailable;
            this.Included = included;
            this.Used = used;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The additional price per unit in cents.
        /// </summary>
        /// <value>The additional price per unit in cents.</value>
        [DataMember(Name = "additional_price", IsRequired = true, EmitDefaultValue = true)]
        public string AdditionalPrice { get; set; }

        /// <summary>
        /// Gets or Sets CanUseMore
        /// </summary>
        [DataMember(Name = "can_use_more", IsRequired = true, EmitDefaultValue = true)]
        public bool CanUseMore { get; set; }

        /// <summary>
        /// Gets or Sets FeatureAvailable
        /// </summary>
        [DataMember(Name = "feature_available", IsRequired = true, EmitDefaultValue = true)]
        public bool FeatureAvailable { get; set; }

        /// <summary>
        /// Gets or Sets Included
        /// </summary>
        [DataMember(Name = "included", IsRequired = true, EmitDefaultValue = true)]
        public long Included { get; set; }

        /// <summary>
        /// Gets or Sets Used
        /// </summary>
        [DataMember(Name = "used", IsRequired = true, EmitDefaultValue = true)]
        public long Used { get; set; }

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
            sb.Append("class ClientQuotaUsage {\n");
            sb.Append("  AdditionalPrice: ").Append(AdditionalPrice).Append("\n");
            sb.Append("  CanUseMore: ").Append(CanUseMore).Append("\n");
            sb.Append("  Feature: ").Append(Feature).Append("\n");
            sb.Append("  FeatureAvailable: ").Append(FeatureAvailable).Append("\n");
            sb.Append("  Included: ").Append(Included).Append("\n");
            sb.Append("  Used: ").Append(Used).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
