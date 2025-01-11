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
    /// BulkJobAddWorkitemSummary
    /// </summary>
    [DataContract]
    public partial class BulkJobAddWorkitemSummary :  IEquatable<BulkJobAddWorkitemSummary>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkJobAddWorkitemSummary" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Workbin">The workbin of the workitem..</param>
        /// <param name="Type">The worktype of the workitem..</param>
        public BulkJobAddWorkitemSummary(string Name = null, WorkbinReference Workbin = null, WorktypeReference Type = null)
        {
            this.Name = Name;
            this.Workbin = Workbin;
            this.Type = Type;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// The workbin of the workitem.
        /// </summary>
        /// <value>The workbin of the workitem.</value>
        [DataMember(Name="workbin", EmitDefaultValue=false)]
        public WorkbinReference Workbin { get; set; }



        /// <summary>
        /// The worktype of the workitem.
        /// </summary>
        /// <value>The worktype of the workitem.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public WorktypeReference Type { get; set; }



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
            sb.Append("class BulkJobAddWorkitemSummary {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Workbin: ").Append(Workbin).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as BulkJobAddWorkitemSummary);
        }

        /// <summary>
        /// Returns true if BulkJobAddWorkitemSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkJobAddWorkitemSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkJobAddWorkitemSummary other)
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
                    this.Workbin == other.Workbin ||
                    this.Workbin != null &&
                    this.Workbin.Equals(other.Workbin)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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

                if (this.Workbin != null)
                    hash = hash * 59 + this.Workbin.GetHashCode();

                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
