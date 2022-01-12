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
    public class ResultFastestLap : IEquatable<ResultFastestLap>
    {
        /// <summary>
        /// Gets or Sets Rank
        /// </summary>

        [DataMember(Name = "rank")]
        public string Rank { get; set; }

        /// <summary>
        /// Gets or Sets Lap
        /// </summary>

        [DataMember(Name = "lap")]
        public string Lap { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>

        [DataMember(Name = "Time")]
        public ResultFastestLapTime Time { get; set; }

        /// <summary>
        /// Gets or Sets AverageSpeed
        /// </summary>

        [DataMember(Name = "AverageSpeed")]
        public ResultFastestLapAverageSpeed AverageSpeed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResultFastestLap {\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Lap: ").Append(Lap).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  AverageSpeed: ").Append(AverageSpeed).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ResultFastestLap)obj);
        }

        /// <summary>
        /// Returns true if ResultFastestLap instances are equal
        /// </summary>
        /// <param name="other">Instance of ResultFastestLap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultFastestLap other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Rank == other.Rank ||
                    Rank != null &&
                    Rank.Equals(other.Rank)
                ) &&
                (
                    Lap == other.Lap ||
                    Lap != null &&
                    Lap.Equals(other.Lap)
                ) &&
                (
                    Time == other.Time ||
                    Time != null &&
                    Time.Equals(other.Time)
                ) &&
                (
                    AverageSpeed == other.AverageSpeed ||
                    AverageSpeed != null &&
                    AverageSpeed.Equals(other.AverageSpeed)
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
                if (Rank != null)
                    hashCode = hashCode * 59 + Rank.GetHashCode();
                if (Lap != null)
                    hashCode = hashCode * 59 + Lap.GetHashCode();
                if (Time != null)
                    hashCode = hashCode * 59 + Time.GetHashCode();
                if (AverageSpeed != null)
                    hashCode = hashCode * 59 + AverageSpeed.GetHashCode();
                return hashCode;
            }
        }
    }
}
