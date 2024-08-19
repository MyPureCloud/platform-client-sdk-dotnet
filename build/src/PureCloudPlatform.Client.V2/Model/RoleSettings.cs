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
    /// RoleSettings
    /// </summary>
    [DataContract]
    public partial class RoleSettings :  IEquatable<RoleSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleSettings" /> class.
        /// </summary>
        /// <param name="BackfillEnabled">Boolean showing if organization is opted in or not to role backfills.</param>
        /// <param name="AuthorizationGrantDivisionAware">Boolean enabling enforcement of division aware for authorization grant add and delete.</param>
        public RoleSettings(bool? BackfillEnabled = null, bool? AuthorizationGrantDivisionAware = null)
        {
            this.BackfillEnabled = BackfillEnabled;
            this.AuthorizationGrantDivisionAware = AuthorizationGrantDivisionAware;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Boolean showing if organization is opted in or not to role backfills
        /// </summary>
        /// <value>Boolean showing if organization is opted in or not to role backfills</value>
        [DataMember(Name="backfillEnabled", EmitDefaultValue=false)]
        public bool? BackfillEnabled { get; set; }



        /// <summary>
        /// Boolean enabling enforcement of division aware for authorization grant add and delete
        /// </summary>
        /// <value>Boolean enabling enforcement of division aware for authorization grant add and delete</value>
        [DataMember(Name="authorizationGrantDivisionAware", EmitDefaultValue=false)]
        public bool? AuthorizationGrantDivisionAware { get; set; }



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
            sb.Append("class RoleSettings {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BackfillEnabled: ").Append(BackfillEnabled).Append("\n");
            sb.Append("  AuthorizationGrantDivisionAware: ").Append(AuthorizationGrantDivisionAware).Append("\n");
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
            return this.Equals(obj as RoleSettings);
        }

        /// <summary>
        /// Returns true if RoleSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of RoleSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoleSettings other)
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
                    this.BackfillEnabled == other.BackfillEnabled ||
                    this.BackfillEnabled != null &&
                    this.BackfillEnabled.Equals(other.BackfillEnabled)
                ) &&
                (
                    this.AuthorizationGrantDivisionAware == other.AuthorizationGrantDivisionAware ||
                    this.AuthorizationGrantDivisionAware != null &&
                    this.AuthorizationGrantDivisionAware.Equals(other.AuthorizationGrantDivisionAware)
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

                if (this.BackfillEnabled != null)
                    hash = hash * 59 + this.BackfillEnabled.GetHashCode();

                if (this.AuthorizationGrantDivisionAware != null)
                    hash = hash * 59 + this.AuthorizationGrantDivisionAware.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
