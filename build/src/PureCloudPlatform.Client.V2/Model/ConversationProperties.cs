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
    /// ConversationProperties
    /// </summary>
    [DataContract]
    public partial class ConversationProperties :  IEquatable<ConversationProperties>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationProperties" /> class.
        /// </summary>
        /// <param name="IsWaiting">Indicates filtering for waiting.</param>
        /// <param name="IsActive">Indicates filtering for active.</param>
        /// <param name="IsAcd">Indicates filtering for Acd.</param>
        /// <param name="IsPreferred">Indicates filtering for Preferred Agent Routing.</param>
        /// <param name="IsScreenshare">Indicates filtering for screenshare.</param>
        /// <param name="IsCobrowse">Indicates filtering for Cobrowse.</param>
        /// <param name="IsVoicemail">Indicates filtering for Voice mail.</param>
        /// <param name="IsFlagged">Indicates filtering for flagged.</param>
        /// <param name="FilterWrapUpNotes">Indicates filtering for WrapUpNotes.</param>
        /// <param name="MatchAll">Indicates comparison operation, TRUE indicates filters will use AND logic, FALSE indicates OR logic.</param>
        public ConversationProperties(bool? IsWaiting = null, bool? IsActive = null, bool? IsAcd = null, bool? IsPreferred = null, bool? IsScreenshare = null, bool? IsCobrowse = null, bool? IsVoicemail = null, bool? IsFlagged = null, bool? FilterWrapUpNotes = null, bool? MatchAll = null)
        {
            this.IsWaiting = IsWaiting;
            this.IsActive = IsActive;
            this.IsAcd = IsAcd;
            this.IsPreferred = IsPreferred;
            this.IsScreenshare = IsScreenshare;
            this.IsCobrowse = IsCobrowse;
            this.IsVoicemail = IsVoicemail;
            this.IsFlagged = IsFlagged;
            this.FilterWrapUpNotes = FilterWrapUpNotes;
            this.MatchAll = MatchAll;
            
        }
        
        
        
        /// <summary>
        /// Indicates filtering for waiting
        /// </summary>
        /// <value>Indicates filtering for waiting</value>
        [DataMember(Name="isWaiting", EmitDefaultValue=false)]
        public bool? IsWaiting { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for active
        /// </summary>
        /// <value>Indicates filtering for active</value>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool? IsActive { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for Acd
        /// </summary>
        /// <value>Indicates filtering for Acd</value>
        [DataMember(Name="isAcd", EmitDefaultValue=false)]
        public bool? IsAcd { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for Preferred Agent Routing
        /// </summary>
        /// <value>Indicates filtering for Preferred Agent Routing</value>
        [DataMember(Name="isPreferred", EmitDefaultValue=false)]
        public bool? IsPreferred { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for screenshare
        /// </summary>
        /// <value>Indicates filtering for screenshare</value>
        [DataMember(Name="isScreenshare", EmitDefaultValue=false)]
        public bool? IsScreenshare { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for Cobrowse
        /// </summary>
        /// <value>Indicates filtering for Cobrowse</value>
        [DataMember(Name="isCobrowse", EmitDefaultValue=false)]
        public bool? IsCobrowse { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for Voice mail
        /// </summary>
        /// <value>Indicates filtering for Voice mail</value>
        [DataMember(Name="isVoicemail", EmitDefaultValue=false)]
        public bool? IsVoicemail { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for flagged
        /// </summary>
        /// <value>Indicates filtering for flagged</value>
        [DataMember(Name="isFlagged", EmitDefaultValue=false)]
        public bool? IsFlagged { get; set; }
        
        
        
        /// <summary>
        /// Indicates filtering for WrapUpNotes
        /// </summary>
        /// <value>Indicates filtering for WrapUpNotes</value>
        [DataMember(Name="filterWrapUpNotes", EmitDefaultValue=false)]
        public bool? FilterWrapUpNotes { get; set; }
        
        
        
        /// <summary>
        /// Indicates comparison operation, TRUE indicates filters will use AND logic, FALSE indicates OR logic
        /// </summary>
        /// <value>Indicates comparison operation, TRUE indicates filters will use AND logic, FALSE indicates OR logic</value>
        [DataMember(Name="matchAll", EmitDefaultValue=false)]
        public bool? MatchAll { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationProperties {\n");
            
            sb.Append("  IsWaiting: ").Append(IsWaiting).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsAcd: ").Append(IsAcd).Append("\n");
            sb.Append("  IsPreferred: ").Append(IsPreferred).Append("\n");
            sb.Append("  IsScreenshare: ").Append(IsScreenshare).Append("\n");
            sb.Append("  IsCobrowse: ").Append(IsCobrowse).Append("\n");
            sb.Append("  IsVoicemail: ").Append(IsVoicemail).Append("\n");
            sb.Append("  IsFlagged: ").Append(IsFlagged).Append("\n");
            sb.Append("  FilterWrapUpNotes: ").Append(FilterWrapUpNotes).Append("\n");
            sb.Append("  MatchAll: ").Append(MatchAll).Append("\n");
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
            return this.Equals(obj as ConversationProperties);
        }

        /// <summary>
        /// Returns true if ConversationProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.IsWaiting == other.IsWaiting ||
                    this.IsWaiting != null &&
                    this.IsWaiting.Equals(other.IsWaiting)
                ) &&
                (
                    this.IsActive == other.IsActive ||
                    this.IsActive != null &&
                    this.IsActive.Equals(other.IsActive)
                ) &&
                (
                    this.IsAcd == other.IsAcd ||
                    this.IsAcd != null &&
                    this.IsAcd.Equals(other.IsAcd)
                ) &&
                (
                    this.IsPreferred == other.IsPreferred ||
                    this.IsPreferred != null &&
                    this.IsPreferred.Equals(other.IsPreferred)
                ) &&
                (
                    this.IsScreenshare == other.IsScreenshare ||
                    this.IsScreenshare != null &&
                    this.IsScreenshare.Equals(other.IsScreenshare)
                ) &&
                (
                    this.IsCobrowse == other.IsCobrowse ||
                    this.IsCobrowse != null &&
                    this.IsCobrowse.Equals(other.IsCobrowse)
                ) &&
                (
                    this.IsVoicemail == other.IsVoicemail ||
                    this.IsVoicemail != null &&
                    this.IsVoicemail.Equals(other.IsVoicemail)
                ) &&
                (
                    this.IsFlagged == other.IsFlagged ||
                    this.IsFlagged != null &&
                    this.IsFlagged.Equals(other.IsFlagged)
                ) &&
                (
                    this.FilterWrapUpNotes == other.FilterWrapUpNotes ||
                    this.FilterWrapUpNotes != null &&
                    this.FilterWrapUpNotes.Equals(other.FilterWrapUpNotes)
                ) &&
                (
                    this.MatchAll == other.MatchAll ||
                    this.MatchAll != null &&
                    this.MatchAll.Equals(other.MatchAll)
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
                
                if (this.IsWaiting != null)
                    hash = hash * 59 + this.IsWaiting.GetHashCode();
                
                if (this.IsActive != null)
                    hash = hash * 59 + this.IsActive.GetHashCode();
                
                if (this.IsAcd != null)
                    hash = hash * 59 + this.IsAcd.GetHashCode();
                
                if (this.IsPreferred != null)
                    hash = hash * 59 + this.IsPreferred.GetHashCode();
                
                if (this.IsScreenshare != null)
                    hash = hash * 59 + this.IsScreenshare.GetHashCode();
                
                if (this.IsCobrowse != null)
                    hash = hash * 59 + this.IsCobrowse.GetHashCode();
                
                if (this.IsVoicemail != null)
                    hash = hash * 59 + this.IsVoicemail.GetHashCode();
                
                if (this.IsFlagged != null)
                    hash = hash * 59 + this.IsFlagged.GetHashCode();
                
                if (this.FilterWrapUpNotes != null)
                    hash = hash * 59 + this.FilterWrapUpNotes.GetHashCode();
                
                if (this.MatchAll != null)
                    hash = hash * 59 + this.MatchAll.GetHashCode();
                
                return hash;
            }
        }
    }

}
