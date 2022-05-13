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
    /// ProgramMappings
    /// </summary>
    [DataContract]
    public partial class ProgramMappings :  IEquatable<ProgramMappings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramMappings" /> class.
        /// </summary>
        /// <param name="Program">Program.</param>
        /// <param name="Queues">Queues.</param>
        /// <param name="Flows">Flows.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public ProgramMappings(BaseProgramEntity Program = null, List<AddressableEntityRef> Queues = null, List<AddressableEntityRef> Flows = null, AddressableEntityRef ModifiedBy = null, DateTime? DateModified = null)
        {
            this.Program = Program;
            this.Queues = Queues;
            this.Flows = Flows;
            this.ModifiedBy = ModifiedBy;
            this.DateModified = DateModified;
            
        }
        


        /// <summary>
        /// Gets or Sets Program
        /// </summary>
        [DataMember(Name="program", EmitDefaultValue=false)]
        public BaseProgramEntity Program { get; set; }



        /// <summary>
        /// Gets or Sets Queues
        /// </summary>
        [DataMember(Name="queues", EmitDefaultValue=false)]
        public List<AddressableEntityRef> Queues { get; set; }



        /// <summary>
        /// Gets or Sets Flows
        /// </summary>
        [DataMember(Name="flows", EmitDefaultValue=false)]
        public List<AddressableEntityRef> Flows { get; set; }



        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public AddressableEntityRef ModifiedBy { get; set; }



        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgramMappings {\n");

            sb.Append("  Program: ").Append(Program).Append("\n");
            sb.Append("  Queues: ").Append(Queues).Append("\n");
            sb.Append("  Flows: ").Append(Flows).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
            return this.Equals(obj as ProgramMappings);
        }

        /// <summary>
        /// Returns true if ProgramMappings instances are equal
        /// </summary>
        /// <param name="other">Instance of ProgramMappings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgramMappings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Program == other.Program ||
                    this.Program != null &&
                    this.Program.Equals(other.Program)
                ) &&
                (
                    this.Queues == other.Queues ||
                    this.Queues != null &&
                    this.Queues.SequenceEqual(other.Queues)
                ) &&
                (
                    this.Flows == other.Flows ||
                    this.Flows != null &&
                    this.Flows.SequenceEqual(other.Flows)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
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
                if (this.Program != null)
                    hash = hash * 59 + this.Program.GetHashCode();

                if (this.Queues != null)
                    hash = hash * 59 + this.Queues.GetHashCode();

                if (this.Flows != null)
                    hash = hash * 59 + this.Flows.GetHashCode();

                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                return hash;
            }
        }
    }

}
