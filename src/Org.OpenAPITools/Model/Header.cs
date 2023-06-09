/*
 * Delft-FEWS Web Services REST API v1
 *
 * Delft-FEWS Web Services REST API v1. For more information see: https://publicwiki.deltares.nl/x/fwNdBw
 *
 * The version of the OpenAPI document: v1-2023-05-03T00:04:18Z
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// The header
    /// </summary>
    [DataContract(Name = "Header")]
    public partial class Header : IEquatable<Header>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Header" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Header() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Header" /> class.
        /// </summary>
        /// <param name="type">TimeSeries type (required).</param>
        /// <param name="moduleInstanceId">Module Instance Id.</param>
        /// <param name="locationId">Location id (required).</param>
        /// <param name="parameterId">Parameter id (required).</param>
        /// <param name="qualifierId">Qualifier Id.</param>
        /// <param name="ensembleId">Ensemble Id. Can be followed by either a ensembleMemberIndex or ensembleMemberId.</param>
        /// <param name="ensembleMemberIndex">Ensemble Member Index.</param>
        /// <param name="ensembleMemberId">Ensemble Member Id.</param>
        /// <param name="timeStep">timeStep.</param>
        /// <param name="startDate">startDate (required).</param>
        /// <param name="endDate">endDate (required).</param>
        /// <param name="forecastDate">forecastDate.</param>
        /// <param name="missVal">Missing value (required).</param>
        /// <param name="longName">Long name.</param>
        /// <param name="stationName">Station name.</param>
        /// <param name="lat">Latitude.</param>
        /// <param name="lon">Longitude.</param>
        /// <param name="x">X.</param>
        /// <param name="y">Y.</param>
        /// <param name="z">Z.</param>
        /// <param name="units">Units.</param>
        /// <param name="domainAxis">Domain Axis.</param>
        /// <param name="sourceOrganisation">Source Organisation.</param>
        /// <param name="sourceSystem">Source System.</param>
        /// <param name="fileDescription">File Descriptor.</param>
        /// <param name="creationDate">Creation date.</param>
        /// <param name="creationTime">Creation time.</param>
        /// <param name="approvedDate">approvedDate.</param>
        /// <param name="region">Region.</param>
        /// <param name="thresholds">Thresholds.</param>
        /// <param name="firstValueTime">firstValueTime.</param>
        /// <param name="lastValueTime">lastValueTime.</param>
        /// <param name="maxValue">Max value.</param>
        /// <param name="minValue">Min value.</param>
        /// <param name="valueCount">Value count.</param>
        /// <param name="maxWarningLevelName">Max Warning Level Name.</param>
        /// <param name="product">product.</param>
        public Header(string type = default(string), string moduleInstanceId = default(string), string locationId = default(string), string parameterId = default(string), List<string> qualifierId = default(List<string>), string ensembleId = default(string), string ensembleMemberIndex = default(string), string ensembleMemberId = default(string), TimeStep timeStep = default(TimeStep), FewsDate startDate = default(FewsDate), FewsDate endDate = default(FewsDate), FewsDate forecastDate = default(FewsDate), string missVal = default(string), string longName = default(string), string stationName = default(string), string lat = default(string), string lon = default(string), string x = default(string), string y = default(string), string z = default(string), string units = default(string), List<DomainAxis> domainAxis = default(List<DomainAxis>), string sourceOrganisation = default(string), string sourceSystem = default(string), string fileDescription = default(string), string creationDate = default(string), string creationTime = default(string), FewsDate approvedDate = default(FewsDate), string region = default(string), List<TimeSeriesThreshold> thresholds = default(List<TimeSeriesThreshold>), FewsDate firstValueTime = default(FewsDate), FewsDate lastValueTime = default(FewsDate), string maxValue = default(string), string minValue = default(string), string valueCount = default(string), string maxWarningLevelName = default(string), Product product = default(Product))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for Header and cannot be null");
            }
            this.Type = type;
            // to ensure "locationId" is required (not null)
            if (locationId == null)
            {
                throw new ArgumentNullException("locationId is a required property for Header and cannot be null");
            }
            this.LocationId = locationId;
            // to ensure "parameterId" is required (not null)
            if (parameterId == null)
            {
                throw new ArgumentNullException("parameterId is a required property for Header and cannot be null");
            }
            this.ParameterId = parameterId;
            // to ensure "startDate" is required (not null)
            if (startDate == null)
            {
                throw new ArgumentNullException("startDate is a required property for Header and cannot be null");
            }
            this.StartDate = startDate;
            // to ensure "endDate" is required (not null)
            if (endDate == null)
            {
                throw new ArgumentNullException("endDate is a required property for Header and cannot be null");
            }
            this.EndDate = endDate;
            // to ensure "missVal" is required (not null)
            if (missVal == null)
            {
                throw new ArgumentNullException("missVal is a required property for Header and cannot be null");
            }
            this.MissVal = missVal;
            this.ModuleInstanceId = moduleInstanceId;
            this.QualifierId = qualifierId;
            this.EnsembleId = ensembleId;
            this.EnsembleMemberIndex = ensembleMemberIndex;
            this.EnsembleMemberId = ensembleMemberId;
            this.TimeStep = timeStep;
            this.ForecastDate = forecastDate;
            this.LongName = longName;
            this.StationName = stationName;
            this.Lat = lat;
            this.Lon = lon;
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Units = units;
            this.DomainAxis = domainAxis;
            this.SourceOrganisation = sourceOrganisation;
            this.SourceSystem = sourceSystem;
            this.FileDescription = fileDescription;
            this.CreationDate = creationDate;
            this.CreationTime = creationTime;
            this.ApprovedDate = approvedDate;
            this.Region = region;
            this.Thresholds = thresholds;
            this.FirstValueTime = firstValueTime;
            this.LastValueTime = lastValueTime;
            this.MaxValue = maxValue;
            this.MinValue = minValue;
            this.ValueCount = valueCount;
            this.MaxWarningLevelName = maxWarningLevelName;
            this.Product = product;
        }

        /// <summary>
        /// TimeSeries type
        /// </summary>
        /// <value>TimeSeries type</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Module Instance Id
        /// </summary>
        /// <value>Module Instance Id</value>
        [DataMember(Name = "moduleInstanceId", EmitDefaultValue = false)]
        public string ModuleInstanceId { get; set; }

        /// <summary>
        /// Location id
        /// </summary>
        /// <value>Location id</value>
        [DataMember(Name = "locationId", IsRequired = true, EmitDefaultValue = true)]
        public string LocationId { get; set; }

        /// <summary>
        /// Parameter id
        /// </summary>
        /// <value>Parameter id</value>
        [DataMember(Name = "parameterId", IsRequired = true, EmitDefaultValue = true)]
        public string ParameterId { get; set; }

        /// <summary>
        /// Qualifier Id
        /// </summary>
        /// <value>Qualifier Id</value>
        [DataMember(Name = "qualifierId", EmitDefaultValue = false)]
        public List<string> QualifierId { get; set; }

        /// <summary>
        /// Ensemble Id. Can be followed by either a ensembleMemberIndex or ensembleMemberId
        /// </summary>
        /// <value>Ensemble Id. Can be followed by either a ensembleMemberIndex or ensembleMemberId</value>
        [DataMember(Name = "ensembleId", EmitDefaultValue = false)]
        public string EnsembleId { get; set; }

        /// <summary>
        /// Ensemble Member Index
        /// </summary>
        /// <value>Ensemble Member Index</value>
        [DataMember(Name = "ensembleMemberIndex", EmitDefaultValue = false)]
        public string EnsembleMemberIndex { get; set; }

        /// <summary>
        /// Ensemble Member Id
        /// </summary>
        /// <value>Ensemble Member Id</value>
        [DataMember(Name = "ensembleMemberId", EmitDefaultValue = false)]
        public string EnsembleMemberId { get; set; }

        /// <summary>
        /// Gets or Sets TimeStep
        /// </summary>
        [DataMember(Name = "timeStep", EmitDefaultValue = false)]
        public TimeStep TimeStep { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = true)]
        public FewsDate StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", IsRequired = true, EmitDefaultValue = true)]
        public FewsDate EndDate { get; set; }

        /// <summary>
        /// Gets or Sets ForecastDate
        /// </summary>
        [DataMember(Name = "forecastDate", EmitDefaultValue = false)]
        public FewsDate ForecastDate { get; set; }

        /// <summary>
        /// Missing value
        /// </summary>
        /// <value>Missing value</value>
        [DataMember(Name = "missVal", IsRequired = true, EmitDefaultValue = true)]
        public string MissVal { get; set; }

        /// <summary>
        /// Long name
        /// </summary>
        /// <value>Long name</value>
        [DataMember(Name = "longName", EmitDefaultValue = false)]
        public string LongName { get; set; }

        /// <summary>
        /// Station name
        /// </summary>
        /// <value>Station name</value>
        [DataMember(Name = "stationName", EmitDefaultValue = false)]
        public string StationName { get; set; }

        /// <summary>
        /// Latitude
        /// </summary>
        /// <value>Latitude</value>
        [DataMember(Name = "lat", EmitDefaultValue = false)]
        public string Lat { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        /// <value>Longitude</value>
        [DataMember(Name = "lon", EmitDefaultValue = false)]
        public string Lon { get; set; }

        /// <summary>
        /// X
        /// </summary>
        /// <value>X</value>
        [DataMember(Name = "x", EmitDefaultValue = false)]
        public string X { get; set; }

        /// <summary>
        /// Y
        /// </summary>
        /// <value>Y</value>
        [DataMember(Name = "y", EmitDefaultValue = false)]
        public string Y { get; set; }

        /// <summary>
        /// Z
        /// </summary>
        /// <value>Z</value>
        [DataMember(Name = "z", EmitDefaultValue = false)]
        public string Z { get; set; }

        /// <summary>
        /// Units
        /// </summary>
        /// <value>Units</value>
        [DataMember(Name = "units", EmitDefaultValue = false)]
        public string Units { get; set; }

        /// <summary>
        /// Domain Axis
        /// </summary>
        /// <value>Domain Axis</value>
        [DataMember(Name = "domainAxis", EmitDefaultValue = false)]
        public List<DomainAxis> DomainAxis { get; set; }

        /// <summary>
        /// Source Organisation
        /// </summary>
        /// <value>Source Organisation</value>
        [DataMember(Name = "sourceOrganisation", EmitDefaultValue = false)]
        public string SourceOrganisation { get; set; }

        /// <summary>
        /// Source System
        /// </summary>
        /// <value>Source System</value>
        [DataMember(Name = "sourceSystem", EmitDefaultValue = false)]
        public string SourceSystem { get; set; }

        /// <summary>
        /// File Descriptor
        /// </summary>
        /// <value>File Descriptor</value>
        [DataMember(Name = "fileDescription", EmitDefaultValue = false)]
        public string FileDescription { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        /// <value>Creation date</value>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public string CreationDate { get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        /// <value>Creation time</value>
        [DataMember(Name = "creationTime", EmitDefaultValue = false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Gets or Sets ApprovedDate
        /// </summary>
        [DataMember(Name = "approvedDate", EmitDefaultValue = false)]
        public FewsDate ApprovedDate { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        /// <value>Region</value>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// Thresholds
        /// </summary>
        /// <value>Thresholds</value>
        [DataMember(Name = "thresholds", EmitDefaultValue = false)]
        public List<TimeSeriesThreshold> Thresholds { get; set; }

        /// <summary>
        /// Gets or Sets FirstValueTime
        /// </summary>
        [DataMember(Name = "firstValueTime", EmitDefaultValue = false)]
        public FewsDate FirstValueTime { get; set; }

        /// <summary>
        /// Gets or Sets LastValueTime
        /// </summary>
        [DataMember(Name = "lastValueTime", EmitDefaultValue = false)]
        public FewsDate LastValueTime { get; set; }

        /// <summary>
        /// Max value
        /// </summary>
        /// <value>Max value</value>
        [DataMember(Name = "maxValue", EmitDefaultValue = false)]
        public string MaxValue { get; set; }

        /// <summary>
        /// Min value
        /// </summary>
        /// <value>Min value</value>
        [DataMember(Name = "minValue", EmitDefaultValue = false)]
        public string MinValue { get; set; }

        /// <summary>
        /// Value count
        /// </summary>
        /// <value>Value count</value>
        [DataMember(Name = "valueCount", EmitDefaultValue = false)]
        public string ValueCount { get; set; }

        /// <summary>
        /// Max Warning Level Name
        /// </summary>
        /// <value>Max Warning Level Name</value>
        [DataMember(Name = "maxWarningLevelName", EmitDefaultValue = false)]
        public string MaxWarningLevelName { get; set; }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        public Product Product { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Header {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ModuleInstanceId: ").Append(ModuleInstanceId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  ParameterId: ").Append(ParameterId).Append("\n");
            sb.Append("  QualifierId: ").Append(QualifierId).Append("\n");
            sb.Append("  EnsembleId: ").Append(EnsembleId).Append("\n");
            sb.Append("  EnsembleMemberIndex: ").Append(EnsembleMemberIndex).Append("\n");
            sb.Append("  EnsembleMemberId: ").Append(EnsembleMemberId).Append("\n");
            sb.Append("  TimeStep: ").Append(TimeStep).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ForecastDate: ").Append(ForecastDate).Append("\n");
            sb.Append("  MissVal: ").Append(MissVal).Append("\n");
            sb.Append("  LongName: ").Append(LongName).Append("\n");
            sb.Append("  StationName: ").Append(StationName).Append("\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Lon: ").Append(Lon).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Z: ").Append(Z).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  DomainAxis: ").Append(DomainAxis).Append("\n");
            sb.Append("  SourceOrganisation: ").Append(SourceOrganisation).Append("\n");
            sb.Append("  SourceSystem: ").Append(SourceSystem).Append("\n");
            sb.Append("  FileDescription: ").Append(FileDescription).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  ApprovedDate: ").Append(ApprovedDate).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Thresholds: ").Append(Thresholds).Append("\n");
            sb.Append("  FirstValueTime: ").Append(FirstValueTime).Append("\n");
            sb.Append("  LastValueTime: ").Append(LastValueTime).Append("\n");
            sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  MinValue: ").Append(MinValue).Append("\n");
            sb.Append("  ValueCount: ").Append(ValueCount).Append("\n");
            sb.Append("  MaxWarningLevelName: ").Append(MaxWarningLevelName).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Header);
        }

        /// <summary>
        /// Returns true if Header instances are equal
        /// </summary>
        /// <param name="input">Instance of Header to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Header input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ModuleInstanceId == input.ModuleInstanceId ||
                    (this.ModuleInstanceId != null &&
                    this.ModuleInstanceId.Equals(input.ModuleInstanceId))
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.ParameterId == input.ParameterId ||
                    (this.ParameterId != null &&
                    this.ParameterId.Equals(input.ParameterId))
                ) && 
                (
                    this.QualifierId == input.QualifierId ||
                    this.QualifierId != null &&
                    input.QualifierId != null &&
                    this.QualifierId.SequenceEqual(input.QualifierId)
                ) && 
                (
                    this.EnsembleId == input.EnsembleId ||
                    (this.EnsembleId != null &&
                    this.EnsembleId.Equals(input.EnsembleId))
                ) && 
                (
                    this.EnsembleMemberIndex == input.EnsembleMemberIndex ||
                    (this.EnsembleMemberIndex != null &&
                    this.EnsembleMemberIndex.Equals(input.EnsembleMemberIndex))
                ) && 
                (
                    this.EnsembleMemberId == input.EnsembleMemberId ||
                    (this.EnsembleMemberId != null &&
                    this.EnsembleMemberId.Equals(input.EnsembleMemberId))
                ) && 
                (
                    this.TimeStep == input.TimeStep ||
                    (this.TimeStep != null &&
                    this.TimeStep.Equals(input.TimeStep))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.ForecastDate == input.ForecastDate ||
                    (this.ForecastDate != null &&
                    this.ForecastDate.Equals(input.ForecastDate))
                ) && 
                (
                    this.MissVal == input.MissVal ||
                    (this.MissVal != null &&
                    this.MissVal.Equals(input.MissVal))
                ) && 
                (
                    this.LongName == input.LongName ||
                    (this.LongName != null &&
                    this.LongName.Equals(input.LongName))
                ) && 
                (
                    this.StationName == input.StationName ||
                    (this.StationName != null &&
                    this.StationName.Equals(input.StationName))
                ) && 
                (
                    this.Lat == input.Lat ||
                    (this.Lat != null &&
                    this.Lat.Equals(input.Lat))
                ) && 
                (
                    this.Lon == input.Lon ||
                    (this.Lon != null &&
                    this.Lon.Equals(input.Lon))
                ) && 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
                ) && 
                (
                    this.Z == input.Z ||
                    (this.Z != null &&
                    this.Z.Equals(input.Z))
                ) && 
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
                ) && 
                (
                    this.DomainAxis == input.DomainAxis ||
                    this.DomainAxis != null &&
                    input.DomainAxis != null &&
                    this.DomainAxis.SequenceEqual(input.DomainAxis)
                ) && 
                (
                    this.SourceOrganisation == input.SourceOrganisation ||
                    (this.SourceOrganisation != null &&
                    this.SourceOrganisation.Equals(input.SourceOrganisation))
                ) && 
                (
                    this.SourceSystem == input.SourceSystem ||
                    (this.SourceSystem != null &&
                    this.SourceSystem.Equals(input.SourceSystem))
                ) && 
                (
                    this.FileDescription == input.FileDescription ||
                    (this.FileDescription != null &&
                    this.FileDescription.Equals(input.FileDescription))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.ApprovedDate == input.ApprovedDate ||
                    (this.ApprovedDate != null &&
                    this.ApprovedDate.Equals(input.ApprovedDate))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.Thresholds == input.Thresholds ||
                    this.Thresholds != null &&
                    input.Thresholds != null &&
                    this.Thresholds.SequenceEqual(input.Thresholds)
                ) && 
                (
                    this.FirstValueTime == input.FirstValueTime ||
                    (this.FirstValueTime != null &&
                    this.FirstValueTime.Equals(input.FirstValueTime))
                ) && 
                (
                    this.LastValueTime == input.LastValueTime ||
                    (this.LastValueTime != null &&
                    this.LastValueTime.Equals(input.LastValueTime))
                ) && 
                (
                    this.MaxValue == input.MaxValue ||
                    (this.MaxValue != null &&
                    this.MaxValue.Equals(input.MaxValue))
                ) && 
                (
                    this.MinValue == input.MinValue ||
                    (this.MinValue != null &&
                    this.MinValue.Equals(input.MinValue))
                ) && 
                (
                    this.ValueCount == input.ValueCount ||
                    (this.ValueCount != null &&
                    this.ValueCount.Equals(input.ValueCount))
                ) && 
                (
                    this.MaxWarningLevelName == input.MaxWarningLevelName ||
                    (this.MaxWarningLevelName != null &&
                    this.MaxWarningLevelName.Equals(input.MaxWarningLevelName))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
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
                int hashCode = 41;
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.ModuleInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.ModuleInstanceId.GetHashCode();
                }
                if (this.LocationId != null)
                {
                    hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                }
                if (this.ParameterId != null)
                {
                    hashCode = (hashCode * 59) + this.ParameterId.GetHashCode();
                }
                if (this.QualifierId != null)
                {
                    hashCode = (hashCode * 59) + this.QualifierId.GetHashCode();
                }
                if (this.EnsembleId != null)
                {
                    hashCode = (hashCode * 59) + this.EnsembleId.GetHashCode();
                }
                if (this.EnsembleMemberIndex != null)
                {
                    hashCode = (hashCode * 59) + this.EnsembleMemberIndex.GetHashCode();
                }
                if (this.EnsembleMemberId != null)
                {
                    hashCode = (hashCode * 59) + this.EnsembleMemberId.GetHashCode();
                }
                if (this.TimeStep != null)
                {
                    hashCode = (hashCode * 59) + this.TimeStep.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.ForecastDate != null)
                {
                    hashCode = (hashCode * 59) + this.ForecastDate.GetHashCode();
                }
                if (this.MissVal != null)
                {
                    hashCode = (hashCode * 59) + this.MissVal.GetHashCode();
                }
                if (this.LongName != null)
                {
                    hashCode = (hashCode * 59) + this.LongName.GetHashCode();
                }
                if (this.StationName != null)
                {
                    hashCode = (hashCode * 59) + this.StationName.GetHashCode();
                }
                if (this.Lat != null)
                {
                    hashCode = (hashCode * 59) + this.Lat.GetHashCode();
                }
                if (this.Lon != null)
                {
                    hashCode = (hashCode * 59) + this.Lon.GetHashCode();
                }
                if (this.X != null)
                {
                    hashCode = (hashCode * 59) + this.X.GetHashCode();
                }
                if (this.Y != null)
                {
                    hashCode = (hashCode * 59) + this.Y.GetHashCode();
                }
                if (this.Z != null)
                {
                    hashCode = (hashCode * 59) + this.Z.GetHashCode();
                }
                if (this.Units != null)
                {
                    hashCode = (hashCode * 59) + this.Units.GetHashCode();
                }
                if (this.DomainAxis != null)
                {
                    hashCode = (hashCode * 59) + this.DomainAxis.GetHashCode();
                }
                if (this.SourceOrganisation != null)
                {
                    hashCode = (hashCode * 59) + this.SourceOrganisation.GetHashCode();
                }
                if (this.SourceSystem != null)
                {
                    hashCode = (hashCode * 59) + this.SourceSystem.GetHashCode();
                }
                if (this.FileDescription != null)
                {
                    hashCode = (hashCode * 59) + this.FileDescription.GetHashCode();
                }
                if (this.CreationDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreationDate.GetHashCode();
                }
                if (this.CreationTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreationTime.GetHashCode();
                }
                if (this.ApprovedDate != null)
                {
                    hashCode = (hashCode * 59) + this.ApprovedDate.GetHashCode();
                }
                if (this.Region != null)
                {
                    hashCode = (hashCode * 59) + this.Region.GetHashCode();
                }
                if (this.Thresholds != null)
                {
                    hashCode = (hashCode * 59) + this.Thresholds.GetHashCode();
                }
                if (this.FirstValueTime != null)
                {
                    hashCode = (hashCode * 59) + this.FirstValueTime.GetHashCode();
                }
                if (this.LastValueTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastValueTime.GetHashCode();
                }
                if (this.MaxValue != null)
                {
                    hashCode = (hashCode * 59) + this.MaxValue.GetHashCode();
                }
                if (this.MinValue != null)
                {
                    hashCode = (hashCode * 59) + this.MinValue.GetHashCode();
                }
                if (this.ValueCount != null)
                {
                    hashCode = (hashCode * 59) + this.ValueCount.GetHashCode();
                }
                if (this.MaxWarningLevelName != null)
                {
                    hashCode = (hashCode * 59) + this.MaxWarningLevelName.GetHashCode();
                }
                if (this.Product != null)
                {
                    hashCode = (hashCode * 59) + this.Product.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
