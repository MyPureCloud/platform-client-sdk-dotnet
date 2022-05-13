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
    /// UserBestPoints
    /// </summary>
    [DataContract]
    public partial class UserBestPoints :  IEquatable<UserBestPoints>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserBestPoints" /> class.
        /// </summary>
        public UserBestPoints()
        {
            
        }
        


        /// <summary>
        /// The requested user for the best points
        /// </summary>
        /// <value>The requested user for the best points</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserReference User { get; private set; }



        /// <summary>
        /// List of best point for the requested user
        /// </summary>
        /// <value>List of best point for the requested user</value>
        [DataMember(Name="bestPoints", EmitDefaultValue=false)]
        public List<UserBestPointsItem> BestPoints { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserBestPoints {\n");

            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  BestPoints: ").Append(BestPoints).Append("\n");
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
            return this.Equals(obj as UserBestPoints);
        }

        /// <summary>
        /// Returns true if UserBestPoints instances are equal
        /// </summary>
        /// <param name="other">Instance of UserBestPoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserBestPoints other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.BestPoints == other.BestPoints ||
                    this.BestPoints != null &&
                    this.BestPoints.SequenceEqual(other.BestPoints)
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
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();

                if (this.BestPoints != null)
                    hash = hash * 59 + this.BestPoints.GetHashCode();

                return hash;
            }
        }
    }

}
