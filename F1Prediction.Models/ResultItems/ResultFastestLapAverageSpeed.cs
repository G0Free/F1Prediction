using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace F1Prediction.Models
{
    [DataContract]
    public class ResultFastestLapAverageSpeed : IEquatable<ResultFastestLapAverageSpeed>
    {
        /// <summary>
        /// Gets or Sets Units
        /// </summary>

        [DataMember(Name = "units")]
        public string Units { get; set; }

        /// <summary>
        /// Gets or Sets Speed
        /// </summary>

        [DataMember(Name = "speed")]
        public string Speed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResultFastestLapAverageSpeed {\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Speed: ").Append(Speed).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ResultFastestLapAverageSpeed)obj);
        }

        /// <summary>
        /// Returns true if ResultFastestLapAverageSpeed instances are equal
        /// </summary>
        /// <param name="other">Instance of ResultFastestLapAverageSpeed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultFastestLapAverageSpeed other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Units == other.Units ||
                    Units != null &&
                    Units.Equals(other.Units)
                ) &&
                (
                    Speed == other.Speed ||
                    Speed != null &&
                    Speed.Equals(other.Speed)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (Units != null)
                    hashCode = hashCode * 59 + Units.GetHashCode();
                if (Speed != null)
                    hashCode = hashCode * 59 + Speed.GetHashCode();
                return hashCode;
            }
        }
    }
}
