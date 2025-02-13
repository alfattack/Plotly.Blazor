/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib.MapBoxLib
{
    /// <summary>
    ///     The Bounds class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Bounds : IEquatable<Bounds>
    {
        /// <summary>
        ///     Sets the maximum longitude of the map (in degrees East) if <c>west</c>,
        ///     <c>south</c> and <c>north</c> are declared.
        /// </summary>
        [JsonPropertyName(@"east")]
        public decimal? East { get; set;} 

        /// <summary>
        ///     Sets the maximum latitude of the map (in degrees North) if <c>east</c>,
        ///     <c>west</c> and <c>south</c> are declared.
        /// </summary>
        [JsonPropertyName(@"north")]
        public decimal? North { get; set;} 

        /// <summary>
        ///     Sets the minimum latitude of the map (in degrees North) if <c>east</c>,
        ///     <c>west</c> and <c>north</c> are declared.
        /// </summary>
        [JsonPropertyName(@"south")]
        public decimal? South { get; set;} 

        /// <summary>
        ///     Sets the minimum longitude of the map (in degrees East) if <c>east</c>,
        ///     <c>south</c> and <c>north</c> are declared.
        /// </summary>
        [JsonPropertyName(@"west")]
        public decimal? West { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Bounds other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Bounds other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    East == other.East ||
                    East != null &&
                    East.Equals(other.East)
                ) && 
                (
                    North == other.North ||
                    North != null &&
                    North.Equals(other.North)
                ) && 
                (
                    South == other.South ||
                    South != null &&
                    South.Equals(other.South)
                ) && 
                (
                    West == other.West ||
                    West != null &&
                    West.Equals(other.West)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (East != null) hashCode = hashCode * 59 + East.GetHashCode();
                if (North != null) hashCode = hashCode * 59 + North.GetHashCode();
                if (South != null) hashCode = hashCode * 59 + South.GetHashCode();
                if (West != null) hashCode = hashCode * 59 + West.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Bounds and the right Bounds.
        /// </summary>
        /// <param name="left">Left Bounds.</param>
        /// <param name="right">Right Bounds.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Bounds left, Bounds right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Bounds and the right Bounds.
        /// </summary>
        /// <param name="left">Left Bounds.</param>
        /// <param name="right">Right Bounds.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Bounds left, Bounds right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Bounds</returns>
        public Bounds DeepClone()
        {
            return this.Copy();
        }
    }
}