using System;

namespace Plc1
{
	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainInfoData_F60A43AC : TcoIo.PlainInputBase_8311D824
	{
		TcoIo.PlainTcoAmsAddr _AdsAddr;
		public TcoIo.PlainTcoAmsAddr AdsAddr
		{
			get
			{
				return _AdsAddr;
			}

			set
			{
				if (_AdsAddr != value)
				{
					_AdsAddr = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(AdsAddr)));
				}
			}
		}

		System.Int32 _DcOutputShift;
		public System.Int32 DcOutputShift
		{
			get
			{
				return _DcOutputShift;
			}

			set
			{
				if (_DcOutputShift != value)
				{
					_DcOutputShift = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DcOutputShift)));
				}
			}
		}

		System.Int32 _DcInputShift;
		public System.Int32 DcInputShift
		{
			get
			{
				return _DcInputShift;
			}

			set
			{
				if (_DcInputShift != value)
				{
					_DcInputShift = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DcInputShift)));
				}
			}
		}

		System.Byte _Chn0;
		public System.Byte Chn0
		{
			get
			{
				return _Chn0;
			}

			set
			{
				if (_Chn0 != value)
				{
					_Chn0 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Chn0)));
				}
			}
		}

		System.UInt16 _State;
		public System.UInt16 State
		{
			get
			{
				return _State;
			}

			set
			{
				if (_State != value)
				{
					_State = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(State)));
				}
			}
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainInfoData_F60A43AC()
		{
			_AdsAddr = new TcoIo.PlainTcoAmsAddr();
		}
	}
}