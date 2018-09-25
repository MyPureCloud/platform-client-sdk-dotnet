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
    /// LineIntegrationRequest
    /// </summary>
    [DataContract]
    public partial class LineIntegrationRequest :  IEquatable<LineIntegrationRequest>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LineIntegrationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LineIntegrationRequest() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LineIntegrationRequest" /> class.
        /// </summary>
        /// <param name="Name">The name of the LINE Integration (required).</param>
        /// <param name="ChannelId">The Channel Id from LINE messenger. New Official LINE account: To create a new official account, LINE requires a Webhook URL. It can be created without specifying Channel Id &amp; Channel Secret. Once the Official account is created by LINE, use the update LINE Integration API to update Channel Id and Channel Secret.  All other accounts: Channel Id is mandatory.</param>
        /// <param name="ChannelSecret">The Channel Secret from LINE messenger. New Official LINE account: To create a new official account, LINE requires a Webhook URL. It can be created without specifying Channel Id &amp; Channel Secret. Once the Official account is created by LINE, use the update LINE Integration API to update Channel Id and Channel Secret.  All other accounts: Channel Secret is mandatory.</param>
        /// <param name="SwitcherSecret">The Switcher Secret from LINE messenger. Some line official accounts are switcher functionality enabled. If the LINE account used for this integration is switcher enabled, then switcher secret is a required field. This secret can be found in your create documentation provided by LINE.</param>
        public LineIntegrationRequest(string Name = null, string ChannelId = null, string ChannelSecret = null, string SwitcherSecret = null)
        {
            this.Name = Name;
            this.ChannelId = ChannelId;
            this.ChannelSecret = ChannelSecret;
            this.SwitcherSecret = SwitcherSecret;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of the LINE Integration
        /// </summary>
        /// <value>The name of the LINE Integration</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The Channel Id from LINE messenger. New Official LINE account: To create a new official account, LINE requires a Webhook URL. It can be created without specifying Channel Id &amp; Channel Secret. Once the Official account is created by LINE, use the update LINE Integration API to update Channel Id and Channel Secret.  All other accounts: Channel Id is mandatory
        /// </summary>
        /// <value>The Channel Id from LINE messenger. New Official LINE account: To create a new official account, LINE requires a Webhook URL. It can be created without specifying Channel Id &amp; Channel Secret. Once the Official account is created by LINE, use the update LINE Integration API to update Channel Id and Channel Secret.  All other accounts: Channel Id is mandatory</value>
        [DataMember(Name="channelId", EmitDefaultValue=false)]
        public string ChannelId { get; set; }
        
        
        
        /// <summary>
        /// The Channel Secret from LINE messenger. New Official LINE account: To create a new official account, LINE requires a Webhook URL. It can be created without specifying Channel Id &amp; Channel Secret. Once the Official account is created by LINE, use the update LINE Integration API to update Channel Id and Channel Secret.  All other accounts: Channel Secret is mandatory
        /// </summary>
        /// <value>The Channel Secret from LINE messenger. New Official LINE account: To create a new official account, LINE requires a Webhook URL. It can be created without specifying Channel Id &amp; Channel Secret. Once the Official account is created by LINE, use the update LINE Integration API to update Channel Id and Channel Secret.  All other accounts: Channel Secret is mandatory</value>
        [DataMember(Name="channelSecret", EmitDefaultValue=false)]
        public string ChannelSecret { get; set; }
        
        
        
        /// <summary>
        /// The Switcher Secret from LINE messenger. Some line official accounts are switcher functionality enabled. If the LINE account used for this integration is switcher enabled, then switcher secret is a required field. This secret can be found in your create documentation provided by LINE
        /// </summary>
        /// <value>The Switcher Secret from LINE messenger. Some line official accounts are switcher functionality enabled. If the LINE account used for this integration is switcher enabled, then switcher secret is a required field. This secret can be found in your create documentation provided by LINE</value>
        [DataMember(Name="switcherSecret", EmitDefaultValue=false)]
        public string SwitcherSecret { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineIntegrationRequest {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
            sb.Append("  ChannelSecret: ").Append(ChannelSecret).Append("\n");
            sb.Append("  SwitcherSecret: ").Append(SwitcherSecret).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as LineIntegrationRequest);
        }

        /// <summary>
        /// Returns true if LineIntegrationRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of LineIntegrationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineIntegrationRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ChannelId == other.ChannelId ||
                    this.ChannelId != null &&
                    this.ChannelId.Equals(other.ChannelId)
                ) &&
                (
                    this.ChannelSecret == other.ChannelSecret ||
                    this.ChannelSecret != null &&
                    this.ChannelSecret.Equals(other.ChannelSecret)
                ) &&
                (
                    this.SwitcherSecret == other.SwitcherSecret ||
                    this.SwitcherSecret != null &&
                    this.SwitcherSecret.Equals(other.SwitcherSecret)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.ChannelId != null)
                    hash = hash * 59 + this.ChannelId.GetHashCode();
                
                if (this.ChannelSecret != null)
                    hash = hash * 59 + this.ChannelSecret.GetHashCode();
                
                if (this.SwitcherSecret != null)
                    hash = hash * 59 + this.SwitcherSecret.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
