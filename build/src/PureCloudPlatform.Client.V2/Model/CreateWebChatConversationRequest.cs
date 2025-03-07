using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// CreateWebChatConversationRequest
    /// </summary>
    [DataContract]
    public partial class CreateWebChatConversationRequest :  IEquatable<CreateWebChatConversationRequest>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebChatConversationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWebChatConversationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebChatConversationRequest" /> class.
        /// </summary>
        /// <param name="OrganizationId">The organization identifier. (required).</param>
        /// <param name="DeploymentId">The web chat Deployment ID which contains the appropriate settings for this chat conversation. (required).</param>
        /// <param name="RoutingTarget">The routing information to use for the new chat conversation. (required).</param>
        /// <param name="MemberInfo">The guest member info to use for the new chat conversation. (required).</param>
        /// <param name="MemberAuthToken">If the guest member is an authenticated member (ie, not anonymous) his JWT is provided here. The token will have been previously generated with the \&quot;POST /api/v2/signeddata\&quot; resource..</param>
        /// <param name="JourneyContext">A subset of the Journey System&#39;s data relevant to this conversation/session request (for external linkage and internal usage/context)..</param>
        public CreateWebChatConversationRequest(string OrganizationId = null, string DeploymentId = null, WebChatRoutingTarget RoutingTarget = null, GuestMemberInfo MemberInfo = null, string MemberAuthToken = null, JourneyContext JourneyContext = null)
        {
            this.OrganizationId = OrganizationId;
            this.DeploymentId = DeploymentId;
            this.RoutingTarget = RoutingTarget;
            this.MemberInfo = MemberInfo;
            this.MemberAuthToken = MemberAuthToken;
            this.JourneyContext = JourneyContext;
            
        }
        


        /// <summary>
        /// The organization identifier.
        /// </summary>
        /// <value>The organization identifier.</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }



        /// <summary>
        /// The web chat Deployment ID which contains the appropriate settings for this chat conversation.
        /// </summary>
        /// <value>The web chat Deployment ID which contains the appropriate settings for this chat conversation.</value>
        [DataMember(Name="deploymentId", EmitDefaultValue=false)]
        public string DeploymentId { get; set; }



        /// <summary>
        /// The routing information to use for the new chat conversation.
        /// </summary>
        /// <value>The routing information to use for the new chat conversation.</value>
        [DataMember(Name="routingTarget", EmitDefaultValue=false)]
        public WebChatRoutingTarget RoutingTarget { get; set; }



        /// <summary>
        /// The guest member info to use for the new chat conversation.
        /// </summary>
        /// <value>The guest member info to use for the new chat conversation.</value>
        [DataMember(Name="memberInfo", EmitDefaultValue=false)]
        public GuestMemberInfo MemberInfo { get; set; }



        /// <summary>
        /// If the guest member is an authenticated member (ie, not anonymous) his JWT is provided here. The token will have been previously generated with the \&quot;POST /api/v2/signeddata\&quot; resource.
        /// </summary>
        /// <value>If the guest member is an authenticated member (ie, not anonymous) his JWT is provided here. The token will have been previously generated with the \&quot;POST /api/v2/signeddata\&quot; resource.</value>
        [DataMember(Name="memberAuthToken", EmitDefaultValue=false)]
        public string MemberAuthToken { get; set; }



        /// <summary>
        /// A subset of the Journey System&#39;s data relevant to this conversation/session request (for external linkage and internal usage/context).
        /// </summary>
        /// <value>A subset of the Journey System&#39;s data relevant to this conversation/session request (for external linkage and internal usage/context).</value>
        [DataMember(Name="journeyContext", EmitDefaultValue=false)]
        public JourneyContext JourneyContext { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWebChatConversationRequest {\n");

            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
            sb.Append("  RoutingTarget: ").Append(RoutingTarget).Append("\n");
            sb.Append("  MemberInfo: ").Append(MemberInfo).Append("\n");
            sb.Append("  MemberAuthToken: ").Append(MemberAuthToken).Append("\n");
            sb.Append("  JourneyContext: ").Append(JourneyContext).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CreateWebChatConversationRequest);
        }

        /// <summary>
        /// Returns true if CreateWebChatConversationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateWebChatConversationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWebChatConversationRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) &&
                (
                    this.DeploymentId == other.DeploymentId ||
                    this.DeploymentId != null &&
                    this.DeploymentId.Equals(other.DeploymentId)
                ) &&
                (
                    this.RoutingTarget == other.RoutingTarget ||
                    this.RoutingTarget != null &&
                    this.RoutingTarget.Equals(other.RoutingTarget)
                ) &&
                (
                    this.MemberInfo == other.MemberInfo ||
                    this.MemberInfo != null &&
                    this.MemberInfo.Equals(other.MemberInfo)
                ) &&
                (
                    this.MemberAuthToken == other.MemberAuthToken ||
                    this.MemberAuthToken != null &&
                    this.MemberAuthToken.Equals(other.MemberAuthToken)
                ) &&
                (
                    this.JourneyContext == other.JourneyContext ||
                    this.JourneyContext != null &&
                    this.JourneyContext.Equals(other.JourneyContext)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();

                if (this.DeploymentId != null)
                    hash = hash * 59 + this.DeploymentId.GetHashCode();

                if (this.RoutingTarget != null)
                    hash = hash * 59 + this.RoutingTarget.GetHashCode();

                if (this.MemberInfo != null)
                    hash = hash * 59 + this.MemberInfo.GetHashCode();

                if (this.MemberAuthToken != null)
                    hash = hash * 59 + this.MemberAuthToken.GetHashCode();

                if (this.JourneyContext != null)
                    hash = hash * 59 + this.JourneyContext.GetHashCode();

                return hash;
            }
        }
    }

}
