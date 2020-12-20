/*
 * Revenue Management System
 *
 * Florida Fish and Wildlife Conservation Commision - Revenue Management System.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@fwc.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace FWC.RMS.ApplicationCore.DTOs
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class UpdateTransmittalRequest : IEquatable<UpdateTransmittalRequest>
    { 
        /// <summary>
        /// Gets or Sets TransmittalTotalCount
        /// </summary>
        [DataMember(Name="transmittalTotalCount")]
        public int? TransmittalTotalCount { get; set; }

        /// <summary>
        /// Gets or Sets TransmittalTotal
        /// </summary>
        [DataMember(Name="transmittalTotal")]
        public decimal? TransmittalTotal { get; set; }

        /// <summary>
        /// Gets or Sets TransmittalStatus
        /// </summary>
        [DataMember(Name="transmittalStatus")]
        public string TransmittalStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTransmittalRequest {\n");
            sb.Append("  TransmittalTotalCount: ").Append(TransmittalTotalCount).Append("\n");
            sb.Append("  TransmittalTotal: ").Append(TransmittalTotal).Append("\n");
            sb.Append("  TransmittalStatus: ").Append(TransmittalStatus).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UpdateTransmittalRequest)obj);
        }

        /// <summary>
        /// Returns true if UpdateTransmittalRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateTransmittalRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateTransmittalRequest other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TransmittalTotalCount == other.TransmittalTotalCount ||
                    TransmittalTotalCount != null &&
                    TransmittalTotalCount.Equals(other.TransmittalTotalCount)
                ) && 
                (
                    TransmittalTotal == other.TransmittalTotal ||
                    TransmittalTotal != null &&
                    TransmittalTotal.Equals(other.TransmittalTotal)
                ) && 
                (
                    TransmittalStatus == other.TransmittalStatus ||
                    TransmittalStatus != null &&
                    TransmittalStatus.Equals(other.TransmittalStatus)
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
                    if (TransmittalTotalCount != null)
                    hashCode = hashCode * 59 + TransmittalTotalCount.GetHashCode();
                    if (TransmittalTotal != null)
                    hashCode = hashCode * 59 + TransmittalTotal.GetHashCode();
                    if (TransmittalStatus != null)
                    hashCode = hashCode * 59 + TransmittalStatus.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UpdateTransmittalRequest left, UpdateTransmittalRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UpdateTransmittalRequest left, UpdateTransmittalRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}