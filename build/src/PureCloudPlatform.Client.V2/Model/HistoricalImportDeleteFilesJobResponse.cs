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
    /// HistoricalImportDeleteFilesJobResponse
    /// </summary>
    [DataContract]
    public partial class HistoricalImportDeleteFilesJobResponse :  IEquatable<HistoricalImportDeleteFilesJobResponse>
    {
        /// <summary>
        /// Property denoting the state of the remove request
        /// </summary>
        /// <value>Property denoting the state of the remove request</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete,
            
            /// <summary>
            /// Enum Error for "Error"
            /// </summary>
            [EnumMember(Value = "Error")]
            Error
        }
        /// <summary>
        /// Property denoting the state of the remove request
        /// </summary>
        /// <value>Property denoting the state of the remove request</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricalImportDeleteFilesJobResponse" /> class.
        /// </summary>
        /// <param name="State">Property denoting the state of the remove request.</param>
        /// <param name="Entities">The request entities that got deleted.</param>
        /// <param name="DisallowedEntities">The request entities that were disallowed to be deleted.</param>
        public HistoricalImportDeleteFilesJobResponse(StateEnum? State = null, List<HistoricalDataDeleteEntity> Entities = null, List<HistoricalDataDisallowedDeleteEntity> DisallowedEntities = null)
        {
            this.State = State;
            this.Entities = Entities;
            this.DisallowedEntities = DisallowedEntities;
            
        }
        


        /// <summary>
        /// The Job Id Request
        /// </summary>
        /// <value>The Job Id Request</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }





        /// <summary>
        /// The request entities that got deleted
        /// </summary>
        /// <value>The request entities that got deleted</value>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<HistoricalDataDeleteEntity> Entities { get; set; }



        /// <summary>
        /// The request entities that were disallowed to be deleted
        /// </summary>
        /// <value>The request entities that were disallowed to be deleted</value>
        [DataMember(Name="disallowedEntities", EmitDefaultValue=false)]
        public List<HistoricalDataDisallowedDeleteEntity> DisallowedEntities { get; set; }



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
            sb.Append("class HistoricalImportDeleteFilesJobResponse {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  DisallowedEntities: ").Append(DisallowedEntities).Append("\n");
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
            return this.Equals(obj as HistoricalImportDeleteFilesJobResponse);
        }

        /// <summary>
        /// Returns true if HistoricalImportDeleteFilesJobResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of HistoricalImportDeleteFilesJobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricalImportDeleteFilesJobResponse other)
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
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
                ) &&
                (
                    this.DisallowedEntities == other.DisallowedEntities ||
                    this.DisallowedEntities != null &&
                    this.DisallowedEntities.SequenceEqual(other.DisallowedEntities)
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

                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();

                if (this.Entities != null)
                    hash = hash * 59 + this.Entities.GetHashCode();

                if (this.DisallowedEntities != null)
                    hash = hash * 59 + this.DisallowedEntities.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
