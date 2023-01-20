using System.Collections;
using System.Collections.Generic;
using GeoJSON.Net.Feature;
using GeoJSON.Net.Geometry;
using Newtonsoft.Json;

namespace TacticalJSON.Net
{
    /// <summary>
    ///     Represents a <see cref="TacticalFeature" /> for providing TacticalJSON data.
    /// </summary>
    public class TacticalFeature : Feature
    {
        /// <summary>
        ///     Specifies the key for the <see cref="SymbolIdentificationCode" /> property.
        /// </summary>
        public const string SymbolIdentificationCodeKey = "sidc";

        /// <summary>
        ///     Specifies the key for the <see cref="Quantity" /> property.
        /// </summary>
        public const string QuantityKey = "quantity";

        /// <summary>
        ///     Specifies the key for the <see cref="ReinforcedReduced" /> property.
        /// </summary>
        public const string ReinforcedReducedKey = "reinforcedReduced";

        /// <summary>
        ///     Specifies the key for the <see cref="StaffComments" /> property.
        /// </summary>
        public const string StaffCommentsKey = "reinforcedReduced";

        /// <summary>
        ///     Specifies the key for the <see cref="AdditionalInformation" /> property.
        /// </summary>
        public const string AdditionalInformationKey = "additionalInformation";

        /// <summary>
        ///     Specifies the key for the <see cref="AdditionalInformation1" /> property.
        /// </summary>
        public const string AdditionalInformation1Key = "additionalInformation1";

        /// <summary>
        ///     Specifies the key for the <see cref="EvaluationRating" /> property.
        /// </summary>
        public const string EvaluationRatingKey = "evaluationRating";

        /// <summary>
        ///     Specifies the key for the <see cref="CombatEffectiveness" /> property.
        /// </summary>
        public const string CombatEffectivenessKey = "combatEffectiveness";

        /// <summary>
        ///     Specifies the key for the <see cref="SignatureEquipment" /> property.
        /// </summary>
        public const string SignatureEquipmentKey = "signatureEquipment";

        /// <summary>
        ///     Specifies the key for the <see cref="HigherFormation" /> property.
        /// </summary>
        public const string HigherFormationKey = "higherFormation";

        /// <summary>
        ///     Specifies the key for the <see cref="Hostile" /> property.
        /// </summary>
        public const string HostileKey = "hostile";

        /// <summary>
        ///     Specifies the key for the <see cref="IffSif" /> property.
        /// </summary>
        public const string IffSifKey = "iffSif";

        /// <summary>
        ///     Specifies the key for the <see cref="Direction" /> property.
        /// </summary>
        public const string DirectionKey = "direction";

        /// <summary>
        ///     Specifies the key for the <see cref="SigInt" /> property.
        /// </summary>
        public const string SigIntKey = "sigint";

        /// <summary>
        ///     Specifies the key for the <see cref="UniqueDesignation" /> property.
        /// </summary>
        public const string UniqueDesignationKey = "uniqueDesignation";

        /// <summary>
        ///     Specifies the key for the <see cref="UniqueDesignation1" /> property.
        /// </summary>
        public const string UniqueDesignation1Key = "uniqueDesignation1";

        /// <summary>
        ///     Specifies the key for the <see cref="EquipmentType" /> property.
        /// </summary>
        public const string EquipmentTypeKey = "type";

        /// <summary>
        ///     Specifies the key for the <see cref="DateTimeGroup" /> property.
        /// </summary>
        public const string DateTimeGroupKey = "dtg";

        /// <summary>
        ///     Specifies the key for the <see cref="DateTimeGroup1" /> property.
        /// </summary>
        public const string DateTimeGroup1Key = "dtg1";

        /// <summary>
        ///     Specifies the key for the <see cref="AltitudeDepth" /> property.
        /// </summary>
        public const string AltitudeDepthKey = "altitudeDepth";

        /// <summary>
        ///     Specifies the key for the <see cref="Location" /> property.
        /// </summary>
        public const string LocationKey = "location";

        /// <summary>
        ///     Specifies the key for the <see cref="Speed" /> property.
        /// </summary>
        public const string SpeedKey = "speed";

        /// <summary>
        ///     Specifies the key for the <see cref="SpecialHeadquarters" /> property.
        /// </summary>
        public const string SpecialHeadquartersKey = "specialHeadquarters";

        /// <summary>
        ///     Specifies the key for the <see cref="PlatformType" /> property.
        /// </summary>
        public const string PlatformTypeKey = "platformType";

        /// <summary>
        ///     Specifies the key for the <see cref="EquipmentTeardownTime" /> property.
        /// </summary>
        public const string EquipmentTeardownTimeKey = "equipmentTeardownTime";

        /// <summary>
        ///     Specifies the key for the <see cref="CommonIdentifier" /> property.
        /// </summary>
        public const string CommonIdentifierKey = "commonIdentifier";

        /// <summary>
        ///     Specifies the key for the <see cref="Distance" /> property.
        /// </summary>
        public const string DistanceKey = "distance";

        /// <summary>
        ///     Specifies the key for the <see cref="Azimuth" /> property.
        /// </summary>
        public const string AzimuthKey = "azimuth";

        /// <summary>
        ///     Specifies the key for the <see cref="TargetNumber" /> property.
        /// </summary>
        public const string TargetNumberKey = "targetNumber";

        /// <summary>
        ///     Gets or sets the Symbol Identification Code for the symbol or graphic (SIDC).
        /// </summary>
        [JsonIgnore]
        public string SymbolIdentificationCode
        {
            get => Properties[SymbolIdentificationCodeKey].ConvertToOrDefault<string>();
            set => Properties[SymbolIdentificationCodeKey] = value;
        }

        /// <summary>
        ///     Gets or sets a text amplifier in an equipment symbol that identifies the number of items present.
        /// </summary>
        [JsonIgnore]
        public string Quantity
        {
            get => Properties[QuantityKey].ConvertToOrDefault<string>();
            set => Properties[QuantityKey] = value;
        }

        /// <summary>
        ///     Gets or sets a text amplifier in a unit symbol that displays (+) for reinforced, (-) for reduced, (+) reinforced
        ///     and reduced.
        /// </summary>
        [JsonIgnore]
        public string ReinforcedReduced
        {
            get => Properties[ReinforcedReducedKey].ConvertToOrDefault<string>();
            set => Properties[ReinforcedReducedKey] = value;
        }

        /// <summary>
        ///     Gets or sets a text amplifier for units, equipment and installations; content is implementation specific.
        /// </summary>
        [JsonIgnore]
        public string StaffComments
        {
            get => Properties[StaffCommentsKey].ConvertToOrDefault<string>();
            set => Properties[StaffCommentsKey] = value;
        }

        /// <summary>
        ///     Gets or sets a text amplifier for units, equipment and installations; content is implementation specific.
        /// </summary>
        [JsonIgnore]
        public string AdditionalInformation
        {
            get => Properties[AdditionalInformationKey].ConvertToOrDefault<string>();
            set => Properties[AdditionalInformationKey] = value;
        }

        /// <summary>
        ///     Gets or sets a text amplifier for units, equipment and installations; content is implementation specific.
        /// </summary>
        [JsonIgnore]
        public string AdditionalInformation1
        {
            get => Properties[AdditionalInformation1Key].ConvertToOrDefault<string>();
            set => Properties[AdditionalInformation1Key] = value;
        }

        /// <summary>
        ///     Gets or sets a <see cref="Net.EvaluationRating" />
        /// </summary>
        [JsonIgnore]
        public EvaluationRating? EvaluationRating
        {
            get => Net.EvaluationRating.TryParse((string)Properties[EvaluationRatingKey], out var rating)
                ? rating
                : null;
            set => Properties[EvaluationRatingKey] = value?.ToString();
        }

        /// <summary>
        ///     Gets or sets a text amplifier for units and installations that indicates unit effectiveness or installation
        ///     capability.
        /// </summary>
        [JsonIgnore]
        public string CombatEffectiveness
        {
            get => Properties[CombatEffectivenessKey].ConvertToOrDefault<string>();
            set => Properties[CombatEffectivenessKey] = value;
        }

        /// <summary>
        ///     Gets or sets a text amplifier for hostile equipment. "!" indicates detectable electronic signatures.
        /// </summary>
        [JsonIgnore]
        public string SignatureEquipment
        {
            get => Properties[SignatureEquipmentKey].ConvertToOrDefault<string>();
            set => Properties[SignatureEquipmentKey] = value;
        }

        /// <summary>
        ///     Gets or sets a text amplifier for units that indicates number or title of higher echelon command (corps are
        ///     designated by Roman numerals).
        /// </summary>
        [JsonIgnore]
        public string HigherFormation
        {
            get => Properties[SignatureEquipmentKey].ConvertToOrDefault<string>();
            set => Properties[SignatureEquipmentKey] = value;
        }

        /// <summary>
        ///     Gets or sets a text amplifier for equipment; letters "ENY" denote hostile symbols.
        /// </summary>
        [JsonIgnore]
        public string Hostile
        {
            get => Properties[HostileKey].ConvertToOrDefault<string>();
            set => Properties[HostileKey] = value;
        }

        /// <summary>
        ///     Gets or sets a text amplifier displaying IFF/SIF/AIS Identification modes and codes.
        /// </summary>
        [JsonIgnore]
        public string IffSif
        {
            get => Properties[IffSifKey].ConvertToOrDefault<string>();
            set => Properties[IffSifKey] = value;
        }

        /// <summary>
        ///     Gets or sets a graphic amplifier that identifies the direction of movement or intended movement of an object
        /// </summary>
        [JsonIgnore]
        public double? Direction
        {
            get => Properties[DirectionKey].ConvertToOrDefault<double?>();
            set => Properties[DirectionKey] = value;
        }

        /// <summary>
        ///     Gets or sets a SIGINT Mobility Indicator.
        /// </summary>
        [JsonIgnore]
        public string SigInt
        {
            get => Properties[SigIntKey].ConvertToOrDefault<string>();
            set => Properties[SigIntKey] = value;
        }

        /// <summary>
        ///     Gets or sets a text amplifier for units, equipment and installations that uniquely identifies a particular symbol
        ///     or track number.
        ///     Identifies acquisitions number when used with SIGINT symbology.
        /// </summary>
        [JsonIgnore]
        public string UniqueDesignation
        {
            get => Properties[UniqueDesignationKey].ConvertToOrDefault<string>();
            set => Properties[UniqueDesignationKey] = value;
        }

        /// <summary>
        ///     Gets or sets a text amplifier for units, equipment and installations that uniquely identifies a particular symbol
        ///     or track number.
        ///     Identifies acquisitions number when used with SIGINT symbology.
        /// </summary>
        [JsonIgnore]
        public string UniqueDesignation1
        {
            get => Properties[UniqueDesignation1Key].ConvertToOrDefault<string>();
            set => Properties[UniqueDesignation1Key] = value;
        }

        /// <summary>
        ///     Gets or sets a text amplifier for equipment that indicates types of equipment.
        /// </summary>
        [JsonIgnore]
        public string EquipmentType
        {
            get => Properties[EquipmentTypeKey].ConvertToOrDefault<string>();
            set => Properties[EquipmentTypeKey] = value;
        }

        /// <summary>
        ///     Gets or sets an alphanumeric designator for displaying a date-time group (DDHHMMSSZMONYYYY) or “O/O” for on order.
        /// </summary>
        [JsonIgnore]
        public string DateTimeGroup
        {
            get => Properties[DateTimeGroupKey].ConvertToOrDefault<string>();
            set => Properties[DateTimeGroupKey] = value;
        }

        /// <summary>
        ///     Gets or sets an alphanumeric designator for displaying a date-time group (DDHHMMSSZMONYYYY) or “O/O” for on order.
        /// </summary>
        [JsonIgnore]
        public string DateTimeGroup1
        {
            get => Properties[DateTimeGroup1Key].ConvertToOrDefault<string>();
            set => Properties[DateTimeGroup1Key] = value;
        }

        /// <summary>
        ///     Gets or sets a text amplifier for units, equipment and installations, that displays either altitude,
        ///     flight level, depth for submerged objects; or height of equipment or structures on the ground.
        /// </summary>
        [JsonIgnore]
        public string AltitudeDepth
        {
            get => Properties[AltitudeDepthKey].ConvertToOrDefault<string>();
            set => Properties[AltitudeDepthKey] = value;
        }

        /// <summary>
        ///     Gets or sets a text amplifier for units, equipment and installations that displays a symbol’s location in degrees,
        ///     minutes and decimal minutes (or in MGRS, GARS, or other applicable display formats).
        /// </summary>
        [JsonIgnore]
        public string Location
        {
            get => Properties[LocationKey].ConvertToOrDefault<string>();
            set => Properties[LocationKey] = value;
        }

        /// <summary>
        ///     Gets or sets a text amplifier for units and equipment that displays velocity.
        /// </summary>
        [JsonIgnore]
        public string Speed
        {
            get => Properties[SpeedKey].ConvertToOrDefault<string>();
            set => Properties[SpeedKey] = value;
        }

        /// <summary>
        ///     Gets or sets a text modifier for units; indicator is contained inside the frame; contains the name of the special
        ///     C2 Headquarters.
        /// </summary>
        [JsonIgnore]
        public string SpecialHeadquarters
        {
            get => Properties[SpecialHeadquartersKey].ConvertToOrDefault<string>();
            set => Properties[SpecialHeadquartersKey] = value;
        }

        /// <summary>
        ///     Gets or sets a text modifier indicating electronic intelligence notation (ELNOT) or communications intelligence
        ///     notation (CENOT).
        /// </summary>
        [JsonIgnore]
        public string PlatformType
        {
            get => Properties[PlatformTypeKey].ConvertToOrDefault<string>();
            set => Properties[PlatformTypeKey] = value;
        }

        /// <summary>
        ///     Gets or sets an equipment teardown time in minutes.
        /// </summary>
        [JsonIgnore]
        public int? EquipmentTeardownTime
        {
            get => Properties[EquipmentTeardownTimeKey].ConvertToOrDefault<int?>();
            set => Properties[EquipmentTeardownTimeKey] = value;
        }

        /// <summary>
        ///     Gets or sets a common identifier, e.g. “Hawk” for Hawk SAM system.
        /// </summary>
        [JsonIgnore]
        public string CommonIdentifier
        {
            get => Properties[CommonIdentifierKey].ConvertToOrDefault<string>();
            set => Properties[CommonIdentifierKey] = value;
        }

        /// <summary>
        ///     Gets or sets a numeric amplifier that displays a minimum, maximum, or a specific distance (range, radius, width,
        ///     length, etc.), in meters.
        /// </summary>
        [JsonIgnore]
        public double? Distance
        {
            get => Properties[DistanceKey].ConvertToOrDefault<double?>();
            set => Properties[DistanceKey] = value;
        }

        /// <summary>
        ///     Gets or sets a numeric amplifier that displays an angle measured from true north to any other line in degrees.
        /// </summary>
        [JsonIgnore]
        public double? Azimuth
        {
            get => Properties[AzimuthKey].ConvertToOrDefault<double?>();
            set => Properties[AzimuthKey] = value;
        }

        /// <summary>
        ///     Gets or sets A six character text modifier used in Fire Support operations
        ///     to uniquely designate targets in accordance with STANAG 2147, where characters 1 and 2
        ///     are alphabetic, and characters 3-6 are numeric: AANNNN.
        /// </summary>
        [JsonIgnore]
        public string TargetNumber
        {
            get => Properties[TargetNumberKey].ConvertToOrDefault<string>();
            set => Properties[TargetNumberKey] = value;
        }

        /// <inheritdoc />
        public TacticalFeature(IGeometryObject geometry, IDictionary properties = null, string id = null)
            : base(geometry, properties ?? new Dictionary<string, object>(), id)
        {
        }
    }
}