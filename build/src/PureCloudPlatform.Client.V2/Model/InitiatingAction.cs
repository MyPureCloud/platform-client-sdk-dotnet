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
    /// InitiatingAction
    /// </summary>
    [DataContract]
    public partial class InitiatingAction :  IEquatable<InitiatingAction>
    {
        /// <summary>
        /// Action of the audit initiating the transaction
        /// </summary>
        /// <value>Action of the audit initiating the transaction</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum ActionContextEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Create for "Create"
            /// </summary>
            [EnumMember(Value = "Create")]
            Create,
            
            /// <summary>
            /// Enum View for "View"
            /// </summary>
            [EnumMember(Value = "View")]
            View,
            
            /// <summary>
            /// Enum Update for "Update"
            /// </summary>
            [EnumMember(Value = "Update")]
            Update,
            
            /// <summary>
            /// Enum Move for "Move"
            /// </summary>
            [EnumMember(Value = "Move")]
            Move,
            
            /// <summary>
            /// Enum Copy for "Copy"
            /// </summary>
            [EnumMember(Value = "Copy")]
            Copy,
            
            /// <summary>
            /// Enum Delete for "Delete"
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete,
            
            /// <summary>
            /// Enum Deleteall for "DeleteAll"
            /// </summary>
            [EnumMember(Value = "DeleteAll")]
            Deleteall,
            
            /// <summary>
            /// Enum Fax for "Fax"
            /// </summary>
            [EnumMember(Value = "Fax")]
            Fax,
            
            /// <summary>
            /// Enum Versioncreate for "VersionCreate"
            /// </summary>
            [EnumMember(Value = "VersionCreate")]
            Versioncreate,
            
            /// <summary>
            /// Enum Download for "Download"
            /// </summary>
            [EnumMember(Value = "Download")]
            Download,
            
            /// <summary>
            /// Enum Upload for "Upload"
            /// </summary>
            [EnumMember(Value = "Upload")]
            Upload,
            
            /// <summary>
            /// Enum Memberadd for "MemberAdd"
            /// </summary>
            [EnumMember(Value = "MemberAdd")]
            Memberadd,
            
            /// <summary>
            /// Enum Memberupdate for "MemberUpdate"
            /// </summary>
            [EnumMember(Value = "MemberUpdate")]
            Memberupdate,
            
            /// <summary>
            /// Enum Memberremove for "MemberRemove"
            /// </summary>
            [EnumMember(Value = "MemberRemove")]
            Memberremove,
            
            /// <summary>
            /// Enum Shareadd for "ShareAdd"
            /// </summary>
            [EnumMember(Value = "ShareAdd")]
            Shareadd,
            
            /// <summary>
            /// Enum Shareremove for "ShareRemove"
            /// </summary>
            [EnumMember(Value = "ShareRemove")]
            Shareremove,
            
            /// <summary>
            /// Enum Tagadd for "TagAdd"
            /// </summary>
            [EnumMember(Value = "TagAdd")]
            Tagadd,
            
            /// <summary>
            /// Enum Tagremove for "TagRemove"
            /// </summary>
            [EnumMember(Value = "TagRemove")]
            Tagremove,
            
            /// <summary>
            /// Enum Tagupdate for "TagUpdate"
            /// </summary>
            [EnumMember(Value = "TagUpdate")]
            Tagupdate,
            
            /// <summary>
            /// Enum Read for "Read"
            /// </summary>
            [EnumMember(Value = "Read")]
            Read,
            
            /// <summary>
            /// Enum Readall for "ReadAll"
            /// </summary>
            [EnumMember(Value = "ReadAll")]
            Readall,
            
            /// <summary>
            /// Enum Execute for "Execute"
            /// </summary>
            [EnumMember(Value = "Execute")]
            Execute,
            
            /// <summary>
            /// Enum Applyprotection for "ApplyProtection"
            /// </summary>
            [EnumMember(Value = "ApplyProtection")]
            Applyprotection,
            
            /// <summary>
            /// Enum Revokeprotection for "RevokeProtection"
            /// </summary>
            [EnumMember(Value = "RevokeProtection")]
            Revokeprotection,
            
            /// <summary>
            /// Enum Updateretention for "UpdateRetention"
            /// </summary>
            [EnumMember(Value = "UpdateRetention")]
            Updateretention,
            
            /// <summary>
            /// Enum Abandon for "Abandon"
            /// </summary>
            [EnumMember(Value = "Abandon")]
            Abandon,
            
            /// <summary>
            /// Enum Archive for "Archive"
            /// </summary>
            [EnumMember(Value = "Archive")]
            Archive,
            
            /// <summary>
            /// Enum Restorerequest for "RestoreRequest"
            /// </summary>
            [EnumMember(Value = "RestoreRequest")]
            Restorerequest,
            
            /// <summary>
            /// Enum Restorecomplete for "RestoreComplete"
            /// </summary>
            [EnumMember(Value = "RestoreComplete")]
            Restorecomplete,
            
            /// <summary>
            /// Enum Promote for "Promote"
            /// </summary>
            [EnumMember(Value = "Promote")]
            Promote,
            
            /// <summary>
            /// Enum Publish for "Publish"
            /// </summary>
            [EnumMember(Value = "Publish")]
            Publish,
            
            /// <summary>
            /// Enum Unpublish for "Unpublish"
            /// </summary>
            [EnumMember(Value = "Unpublish")]
            Unpublish,
            
            /// <summary>
            /// Enum Activate for "Activate"
            /// </summary>
            [EnumMember(Value = "Activate")]
            Activate,
            
            /// <summary>
            /// Enum Checkin for "Checkin"
            /// </summary>
            [EnumMember(Value = "Checkin")]
            Checkin,
            
            /// <summary>
            /// Enum Checkout for "Checkout"
            /// </summary>
            [EnumMember(Value = "Checkout")]
            Checkout,
            
            /// <summary>
            /// Enum Deactivate for "Deactivate"
            /// </summary>
            [EnumMember(Value = "Deactivate")]
            Deactivate,
            
            /// <summary>
            /// Enum Debug for "Debug"
            /// </summary>
            [EnumMember(Value = "Debug")]
            Debug,
            
            /// <summary>
            /// Enum Save for "Save"
            /// </summary>
            [EnumMember(Value = "Save")]
            Save,
            
            /// <summary>
            /// Enum Revert for "Revert"
            /// </summary>
            [EnumMember(Value = "Revert")]
            Revert,
            
            /// <summary>
            /// Enum Transcode for "Transcode"
            /// </summary>
            [EnumMember(Value = "Transcode")]
            Transcode,
            
            /// <summary>
            /// Enum Enable for "Enable"
            /// </summary>
            [EnumMember(Value = "Enable")]
            Enable,
            
            /// <summary>
            /// Enum Disable for "Disable"
            /// </summary>
            [EnumMember(Value = "Disable")]
            Disable,
            
            /// <summary>
            /// Enum Authorize for "Authorize"
            /// </summary>
            [EnumMember(Value = "Authorize")]
            Authorize,
            
            /// <summary>
            /// Enum Deauthorize for "Deauthorize"
            /// </summary>
            [EnumMember(Value = "Deauthorize")]
            Deauthorize,
            
            /// <summary>
            /// Enum Authenticate for "Authenticate"
            /// </summary>
            [EnumMember(Value = "Authenticate")]
            Authenticate,
            
            /// <summary>
            /// Enum Changepassword for "ChangePassword"
            /// </summary>
            [EnumMember(Value = "ChangePassword")]
            Changepassword,
            
            /// <summary>
            /// Enum Revoke for "Revoke"
            /// </summary>
            [EnumMember(Value = "Revoke")]
            Revoke,
            
            /// <summary>
            /// Enum Export for "Export"
            /// </summary>
            [EnumMember(Value = "Export")]
            Export,
            
            /// <summary>
            /// Enum Append for "Append"
            /// </summary>
            [EnumMember(Value = "Append")]
            Append,
            
            /// <summary>
            /// Enum Recycle for "Recycle"
            /// </summary>
            [EnumMember(Value = "Recycle")]
            Recycle,
            
            /// <summary>
            /// Enum Open for "Open"
            /// </summary>
            [EnumMember(Value = "Open")]
            Open,
            
            /// <summary>
            /// Enum Approved for "Approved"
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved,
            
            /// <summary>
            /// Enum Rejected for "Rejected"
            /// </summary>
            [EnumMember(Value = "Rejected")]
            Rejected,
            
            /// <summary>
            /// Enum Rollback for "Rollback"
            /// </summary>
            [EnumMember(Value = "Rollback")]
            Rollback,
            
            /// <summary>
            /// Enum Implementingchange for "ImplementingChange"
            /// </summary>
            [EnumMember(Value = "ImplementingChange")]
            Implementingchange,
            
            /// <summary>
            /// Enum Changeimplemented for "ChangeImplemented"
            /// </summary>
            [EnumMember(Value = "ChangeImplemented")]
            Changeimplemented,
            
            /// <summary>
            /// Enum Implementingrollback for "ImplementingRollback"
            /// </summary>
            [EnumMember(Value = "ImplementingRollback")]
            Implementingrollback,
            
            /// <summary>
            /// Enum Rollbackimplemented for "RollbackImplemented"
            /// </summary>
            [EnumMember(Value = "RollbackImplemented")]
            Rollbackimplemented,
            
            /// <summary>
            /// Enum Write for "Write"
            /// </summary>
            [EnumMember(Value = "Write")]
            Write,
            
            /// <summary>
            /// Enum Purge for "Purge"
            /// </summary>
            [EnumMember(Value = "Purge")]
            Purge,
            
            /// <summary>
            /// Enum Processed for "Processed"
            /// </summary>
            [EnumMember(Value = "Processed")]
            Processed,
            
            /// <summary>
            /// Enum Replace for "Replace"
            /// </summary>
            [EnumMember(Value = "Replace")]
            Replace,
            
            /// <summary>
            /// Enum Updateinservice for "UpdateInService"
            /// </summary>
            [EnumMember(Value = "UpdateInService")]
            Updateinservice,
            
            /// <summary>
            /// Enum Updateoutofservice for "UpdateOutOfService"
            /// </summary>
            [EnumMember(Value = "UpdateOutOfService")]
            Updateoutofservice,
            
            /// <summary>
            /// Enum Cycle for "Cycle"
            /// </summary>
            [EnumMember(Value = "Cycle")]
            Cycle,
            
            /// <summary>
            /// Enum Scale for "Scale"
            /// </summary>
            [EnumMember(Value = "Scale")]
            Scale,
            
            /// <summary>
            /// Enum Ipallowlistclear for "IpAllowlistClear"
            /// </summary>
            [EnumMember(Value = "IpAllowlistClear")]
            Ipallowlistclear,
            
            /// <summary>
            /// Enum Addpairingrole for "AddPairingRole"
            /// </summary>
            [EnumMember(Value = "AddPairingRole")]
            Addpairingrole,
            
            /// <summary>
            /// Enum Add for "Add"
            /// </summary>
            [EnumMember(Value = "Add")]
            Add,
            
            /// <summary>
            /// Enum Verify for "Verify"
            /// </summary>
            [EnumMember(Value = "Verify")]
            Verify,
            
            /// <summary>
            /// Enum Assign for "Assign"
            /// </summary>
            [EnumMember(Value = "Assign")]
            Assign,
            
            /// <summary>
            /// Enum Unassign for "Unassign"
            /// </summary>
            [EnumMember(Value = "Unassign")]
            Unassign,
            
            /// <summary>
            /// Enum Reassign for "Reassign"
            /// </summary>
            [EnumMember(Value = "Reassign")]
            Reassign,
            
            /// <summary>
            /// Enum Reschedule for "Reschedule"
            /// </summary>
            [EnumMember(Value = "Reschedule")]
            Reschedule,
            
            /// <summary>
            /// Enum Cancel for "Cancel"
            /// </summary>
            [EnumMember(Value = "Cancel")]
            Cancel,
            
            /// <summary>
            /// Enum Softdelete for "SoftDelete"
            /// </summary>
            [EnumMember(Value = "SoftDelete")]
            Softdelete,
            
            /// <summary>
            /// Enum Harddelete for "HardDelete"
            /// </summary>
            [EnumMember(Value = "HardDelete")]
            Harddelete,
            
            /// <summary>
            /// Enum Reset for "Reset"
            /// </summary>
            [EnumMember(Value = "Reset")]
            Reset,
            
            /// <summary>
            /// Enum Rotate for "Rotate"
            /// </summary>
            [EnumMember(Value = "Rotate")]
            Rotate,
            
            /// <summary>
            /// Enum Restore for "Restore"
            /// </summary>
            [EnumMember(Value = "Restore")]
            Restore,
            
            /// <summary>
            /// Enum Unarchive for "Unarchive"
            /// </summary>
            [EnumMember(Value = "Unarchive")]
            Unarchive,
            
            /// <summary>
            /// Enum Enablecapture for "EnableCapture"
            /// </summary>
            [EnumMember(Value = "EnableCapture")]
            Enablecapture,
            
            /// <summary>
            /// Enum Downloadcapture for "DownloadCapture"
            /// </summary>
            [EnumMember(Value = "DownloadCapture")]
            Downloadcapture
        }
        /// <summary>
        /// Action of the audit initiating the transaction
        /// </summary>
        /// <value>Action of the audit initiating the transaction</value>
        [DataMember(Name="actionContext", EmitDefaultValue=false)]
        public ActionContextEnum? ActionContext { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiatingAction" /> class.
        /// </summary>
        /// <param name="TransactionId">Id of the audit initiating the transaction.</param>
        /// <param name="ActionContext">Action of the audit initiating the transaction.</param>
        public InitiatingAction(string TransactionId = null, ActionContextEnum? ActionContext = null)
        {
            this.TransactionId = TransactionId;
            this.ActionContext = ActionContext;
            
        }
        


        /// <summary>
        /// Id of the audit initiating the transaction
        /// </summary>
        /// <value>Id of the audit initiating the transaction</value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitiatingAction {\n");

            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  ActionContext: ").Append(ActionContext).Append("\n");
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
            return this.Equals(obj as InitiatingAction);
        }

        /// <summary>
        /// Returns true if InitiatingAction instances are equal
        /// </summary>
        /// <param name="other">Instance of InitiatingAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitiatingAction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
                ) &&
                (
                    this.ActionContext == other.ActionContext ||
                    this.ActionContext != null &&
                    this.ActionContext.Equals(other.ActionContext)
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
                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();

                if (this.ActionContext != null)
                    hash = hash * 59 + this.ActionContext.GetHashCode();

                return hash;
            }
        }
    }

}
