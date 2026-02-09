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
    /// UpdateDecisionTableVersionRequest
    /// </summary>
    [DataContract]
    public partial class UpdateDecisionTableVersionRequest :  IEquatable<UpdateDecisionTableVersionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDecisionTableVersionRequest" /> class.
        /// </summary>
        /// <param name="RowIndexUpdate">An update to a decision table version row index, which moves the row to a new position in the table..</param>
        public UpdateDecisionTableVersionRequest(UpdateRowIndexRequest RowIndexUpdate = null)
        {
            this.RowIndexUpdate = RowIndexUpdate;
            
        }
        


        /// <summary>
        /// An update to a decision table version row index, which moves the row to a new position in the table.
        /// </summary>
        /// <value>An update to a decision table version row index, which moves the row to a new position in the table.</value>
        [DataMember(Name="rowIndexUpdate", EmitDefaultValue=false)]
        public UpdateRowIndexRequest RowIndexUpdate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDecisionTableVersionRequest {\n");

            sb.Append("  RowIndexUpdate: ").Append(RowIndexUpdate).Append("\n");
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
            return this.Equals(obj as UpdateDecisionTableVersionRequest);
        }

        /// <summary>
        /// Returns true if UpdateDecisionTableVersionRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateDecisionTableVersionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateDecisionTableVersionRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.RowIndexUpdate == other.RowIndexUpdate ||
                    this.RowIndexUpdate != null &&
                    this.RowIndexUpdate.Equals(other.RowIndexUpdate)
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
                if (this.RowIndexUpdate != null)
                    hash = hash * 59 + this.RowIndexUpdate.GetHashCode();

                return hash;
            }
        }
    }

}
