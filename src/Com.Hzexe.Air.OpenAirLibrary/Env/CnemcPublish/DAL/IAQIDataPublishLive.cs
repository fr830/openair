﻿namespace Env.CnemcPublish.DAL
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using OpenRiaServices.DomainServices.Client;

    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/Env.CnemcPublish.DAL")]
    public sealed class IAQIDataPublishLive : Entity
    {
        private string _area;
        private string _ico;
        private string _ino2;
        private string _io3;
        private string _io3_8h;
        private string _ipm10;
        private string _ipm2_5;
        private string _iso2;
        private string _latitude;
        private string _longitude;
        private string[] _openAccessGenerated;
        private string _positionName;
        private string _stationCode;
        private DateTime _timePoint;

        public override object GetIdentity()
        {
            return this._stationCode;
        }

        [ConcurrencyCheck, StringLength(10), DataMember, RoundtripOriginal]
        public string Area
        {
            get
            {
                return this._area;
            }
            set
            {
                if (this._area != value)
                {
                    base.RaiseDataMemberChanging("Area");
                    base.ValidateProperty("Area", value);
                    this._area = value;
                    base.RaiseDataMemberChanged("Area");
                }
            }
        }

        [DataMember, ConcurrencyCheck, StringLength(8), RoundtripOriginal]
        public string ICO
        {
            get
            {
                return this._ico;
            }
            set
            {
                if (this._ico != value)
                {
                    base.RaiseDataMemberChanging("ICO");
                    base.ValidateProperty("ICO", value);
                    this._ico = value;
                    base.RaiseDataMemberChanged("ICO");
                }
            }
        }

        [ConcurrencyCheck, StringLength(5), DataMember, RoundtripOriginal]
        public string INO2
        {
            get
            {
                return this._ino2;
            }
            set
            {
                if (this._ino2 != value)
                {
                    base.RaiseDataMemberChanging("INO2");
                    base.ValidateProperty("INO2", value);
                    this._ino2 = value;
                    base.RaiseDataMemberChanged("INO2");
                }
            }
        }

        [ConcurrencyCheck, StringLength(5), DataMember, RoundtripOriginal]
        public string IO3
        {
            get
            {
                return this._io3;
            }
            set
            {
                if (this._io3 != value)
                {
                    base.RaiseDataMemberChanging("IO3");
                    base.ValidateProperty("IO3", value);
                    this._io3 = value;
                    base.RaiseDataMemberChanged("IO3");
                }
            }
        }

        [StringLength(5), ConcurrencyCheck, DataMember, RoundtripOriginal]
        public string IO3_8h
        {
            get
            {
                return this._io3_8h;
            }
            set
            {
                if (this._io3_8h != value)
                {
                    base.RaiseDataMemberChanging("IO3_8h");
                    base.ValidateProperty("IO3_8h", value);
                    this._io3_8h = value;
                    base.RaiseDataMemberChanged("IO3_8h");
                }
            }
        }

        [StringLength(5), ConcurrencyCheck, DataMember, RoundtripOriginal]
        public string IPM10
        {
            get
            {
                return this._ipm10;
            }
            set
            {
                if (this._ipm10 != value)
                {
                    base.RaiseDataMemberChanging("IPM10");
                    base.ValidateProperty("IPM10", value);
                    this._ipm10 = value;
                    base.RaiseDataMemberChanged("IPM10");
                }
            }
        }

        [StringLength(5), ConcurrencyCheck, DataMember, RoundtripOriginal]
        public string IPM2_5
        {
            get
            {
                return this._ipm2_5;
            }
            set
            {
                if (this._ipm2_5 != value)
                {
                    base.RaiseDataMemberChanging("IPM2_5");
                    base.ValidateProperty("IPM2_5", value);
                    this._ipm2_5 = value;
                    base.RaiseDataMemberChanged("IPM2_5");
                }
            }
        }

        [DataMember, ConcurrencyCheck, StringLength(5), RoundtripOriginal]
        public string ISO2
        {
            get
            {
                return this._iso2;
            }
            set
            {
                if (this._iso2 != value)
                {
                    base.RaiseDataMemberChanging("ISO2");
                    base.ValidateProperty("ISO2", value);
                    this._iso2 = value;
                    base.RaiseDataMemberChanged("ISO2");
                }
            }
        }

        [ConcurrencyCheck, StringLength(15), DataMember, RoundtripOriginal]
        public string Latitude
        {
            get
            {
                return this._latitude;
            }
            set
            {
                if (this._latitude != value)
                {
                    base.RaiseDataMemberChanging("Latitude");
                    base.ValidateProperty("Latitude", value);
                    this._latitude = value;
                    base.RaiseDataMemberChanged("Latitude");
                }
            }
        }

        [StringLength(15), ConcurrencyCheck, DataMember, RoundtripOriginal]
        public string Longitude
        {
            get
            {
                return this._longitude;
            }
            set
            {
                if (this._longitude != value)
                {
                    base.RaiseDataMemberChanging("Longitude");
                    base.ValidateProperty("Longitude", value);
                    this._longitude = value;
                    base.RaiseDataMemberChanged("Longitude");
                }
            }
        }

        [DataMember, Display(AutoGenerateField=false, AutoGenerateFilter=false, Description="OpenAccess Key", Name="-ID-"), Editable(false), ReadOnly(true), RoundtripOriginal]
        public string[] OpenAccessGenerated
        {
            get
            {
                return this._openAccessGenerated;
            }
            set
            {
                if (this._openAccessGenerated != value)
                {
                    base.ValidateProperty("OpenAccessGenerated", value);
                    this._openAccessGenerated = value;
                    base.RaisePropertyChanged("OpenAccessGenerated");
                }
            }
        }

        [StringLength(40), DataMember, RoundtripOriginal, ConcurrencyCheck]
        public string PositionName
        {
            get
            {
                return this._positionName;
            }
            set
            {
                if (this._positionName != value)
                {
                    base.RaiseDataMemberChanging("PositionName");
                    base.ValidateProperty("PositionName", value);
                    this._positionName = value;
                    base.RaiseDataMemberChanged("PositionName");
                }
            }
        }

        [RoundtripOriginal, DataMember, Editable(false, AllowInitialValue=true), Key, ConcurrencyCheck, StringLength(5)]
        public string StationCode
        {
            get
            {
                return this._stationCode;
            }
            set
            {
                if (this._stationCode != value)
                {
                    base.ValidateProperty("StationCode", value);
                    this._stationCode = value;
                    base.RaisePropertyChanged("StationCode");
                }
            }
        }

        [ConcurrencyCheck, DataMember, RoundtripOriginal]
        public DateTime TimePoint
        {
            get
            {
                return this._timePoint;
            }
            set
            {
                if (this._timePoint != value)
                {
                    base.RaiseDataMemberChanging("TimePoint");
                    base.ValidateProperty("TimePoint", value);
                    this._timePoint = value;
                    base.RaiseDataMemberChanged("TimePoint");
                }
            }
        }
    }
}

