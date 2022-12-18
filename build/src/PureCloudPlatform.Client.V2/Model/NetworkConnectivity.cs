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
    /// NetworkConnectivity
    /// </summary>
    [DataContract]
    public partial class NetworkConnectivity :  IEquatable<NetworkConnectivity>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkConnectivity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NetworkConnectivity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkConnectivity" /> class.
        /// </summary>
        /// <param name="Carrier">The name of the network carrier..</param>
        /// <param name="BluetoothEnabled">Whether Bluetooth is enabled. (required).</param>
        /// <param name="CellularEnabled">Whether Cellular is enabled. (required).</param>
        /// <param name="WifiEnabled">Whether Wi-Fi is enabled. (required).</param>
        public NetworkConnectivity(string Carrier = null, bool? BluetoothEnabled = null, bool? CellularEnabled = null, bool? WifiEnabled = null)
        {
            this.Carrier = Carrier;
            this.BluetoothEnabled = BluetoothEnabled;
            this.CellularEnabled = CellularEnabled;
            this.WifiEnabled = WifiEnabled;
            
        }
        


        /// <summary>
        /// The name of the network carrier.
        /// </summary>
        /// <value>The name of the network carrier.</value>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public string Carrier { get; set; }



        /// <summary>
        /// Whether Bluetooth is enabled.
        /// </summary>
        /// <value>Whether Bluetooth is enabled.</value>
        [DataMember(Name="bluetoothEnabled", EmitDefaultValue=false)]
        public bool? BluetoothEnabled { get; set; }



        /// <summary>
        /// Whether Cellular is enabled.
        /// </summary>
        /// <value>Whether Cellular is enabled.</value>
        [DataMember(Name="cellularEnabled", EmitDefaultValue=false)]
        public bool? CellularEnabled { get; set; }



        /// <summary>
        /// Whether Wi-Fi is enabled.
        /// </summary>
        /// <value>Whether Wi-Fi is enabled.</value>
        [DataMember(Name="wifiEnabled", EmitDefaultValue=false)]
        public bool? WifiEnabled { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkConnectivity {\n");

            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  BluetoothEnabled: ").Append(BluetoothEnabled).Append("\n");
            sb.Append("  CellularEnabled: ").Append(CellularEnabled).Append("\n");
            sb.Append("  WifiEnabled: ").Append(WifiEnabled).Append("\n");
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
            return this.Equals(obj as NetworkConnectivity);
        }

        /// <summary>
        /// Returns true if NetworkConnectivity instances are equal
        /// </summary>
        /// <param name="other">Instance of NetworkConnectivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkConnectivity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Carrier == other.Carrier ||
                    this.Carrier != null &&
                    this.Carrier.Equals(other.Carrier)
                ) &&
                (
                    this.BluetoothEnabled == other.BluetoothEnabled ||
                    this.BluetoothEnabled != null &&
                    this.BluetoothEnabled.Equals(other.BluetoothEnabled)
                ) &&
                (
                    this.CellularEnabled == other.CellularEnabled ||
                    this.CellularEnabled != null &&
                    this.CellularEnabled.Equals(other.CellularEnabled)
                ) &&
                (
                    this.WifiEnabled == other.WifiEnabled ||
                    this.WifiEnabled != null &&
                    this.WifiEnabled.Equals(other.WifiEnabled)
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
                if (this.Carrier != null)
                    hash = hash * 59 + this.Carrier.GetHashCode();

                if (this.BluetoothEnabled != null)
                    hash = hash * 59 + this.BluetoothEnabled.GetHashCode();

                if (this.CellularEnabled != null)
                    hash = hash * 59 + this.CellularEnabled.GetHashCode();

                if (this.WifiEnabled != null)
                    hash = hash * 59 + this.WifiEnabled.GetHashCode();

                return hash;
            }
        }
    }

}
