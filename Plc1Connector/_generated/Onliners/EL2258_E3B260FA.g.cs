using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty VendorId \"#x00000002\" } {attribute addProperty BoxType \"EL2258-0000-0017\" } {attribute addProperty Description \"EL2258 8Ch. Dig Output 24V with Multi-Time-Stamp\" } {attribute addProperty Physics \"KK\" } {attribute addProperty Id \"MTO_Inputs_Channel_1AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_2AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_3AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_4AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_5AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_6AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_7AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_8AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Outputs_10x_Channel_1AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_2AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_3AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_4AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_5AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_6AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_7AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_8AT %Q*MTO_Outputs_10x_Channel_A3C0C02256WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_B84DBEC510\" } {attribute addProperty CRC \"3820118266\" } {attribute addProperty Size \"508\" } {attribute addProperty Name \"\" }", "EL2258_E3B260FA", "Plc1", TypeComplexityEnum.Complex)]
	public partial class EL2258_E3B260FA : TcoIo.EtcSlaveTerminalBase_947E5A46, Vortex.Connector.IVortexObject, IEL2258_E3B260FA, IShadowEL2258_E3B260FA, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		MTO_Inputs_Channel_53C09E8B _MTO_Inputs_Channel_1;
		public MTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_1
		{
			get
			{
				return _MTO_Inputs_Channel_1;
			}
		}

		IMTO_Inputs_Channel_53C09E8B IEL2258_E3B260FA.MTO_Inputs_Channel_1
		{
			get
			{
				return MTO_Inputs_Channel_1;
			}
		}

		IShadowMTO_Inputs_Channel_53C09E8B IShadowEL2258_E3B260FA.MTO_Inputs_Channel_1
		{
			get
			{
				return MTO_Inputs_Channel_1;
			}
		}

		MTO_Inputs_Channel_53C09E8B _MTO_Inputs_Channel_2;
		public MTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_2
		{
			get
			{
				return _MTO_Inputs_Channel_2;
			}
		}

		IMTO_Inputs_Channel_53C09E8B IEL2258_E3B260FA.MTO_Inputs_Channel_2
		{
			get
			{
				return MTO_Inputs_Channel_2;
			}
		}

		IShadowMTO_Inputs_Channel_53C09E8B IShadowEL2258_E3B260FA.MTO_Inputs_Channel_2
		{
			get
			{
				return MTO_Inputs_Channel_2;
			}
		}

		MTO_Inputs_Channel_53C09E8B _MTO_Inputs_Channel_3;
		public MTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_3
		{
			get
			{
				return _MTO_Inputs_Channel_3;
			}
		}

		IMTO_Inputs_Channel_53C09E8B IEL2258_E3B260FA.MTO_Inputs_Channel_3
		{
			get
			{
				return MTO_Inputs_Channel_3;
			}
		}

		IShadowMTO_Inputs_Channel_53C09E8B IShadowEL2258_E3B260FA.MTO_Inputs_Channel_3
		{
			get
			{
				return MTO_Inputs_Channel_3;
			}
		}

		MTO_Inputs_Channel_53C09E8B _MTO_Inputs_Channel_4;
		public MTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_4
		{
			get
			{
				return _MTO_Inputs_Channel_4;
			}
		}

		IMTO_Inputs_Channel_53C09E8B IEL2258_E3B260FA.MTO_Inputs_Channel_4
		{
			get
			{
				return MTO_Inputs_Channel_4;
			}
		}

		IShadowMTO_Inputs_Channel_53C09E8B IShadowEL2258_E3B260FA.MTO_Inputs_Channel_4
		{
			get
			{
				return MTO_Inputs_Channel_4;
			}
		}

		MTO_Inputs_Channel_53C09E8B _MTO_Inputs_Channel_5;
		public MTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_5
		{
			get
			{
				return _MTO_Inputs_Channel_5;
			}
		}

		IMTO_Inputs_Channel_53C09E8B IEL2258_E3B260FA.MTO_Inputs_Channel_5
		{
			get
			{
				return MTO_Inputs_Channel_5;
			}
		}

		IShadowMTO_Inputs_Channel_53C09E8B IShadowEL2258_E3B260FA.MTO_Inputs_Channel_5
		{
			get
			{
				return MTO_Inputs_Channel_5;
			}
		}

		MTO_Inputs_Channel_53C09E8B _MTO_Inputs_Channel_6;
		public MTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_6
		{
			get
			{
				return _MTO_Inputs_Channel_6;
			}
		}

		IMTO_Inputs_Channel_53C09E8B IEL2258_E3B260FA.MTO_Inputs_Channel_6
		{
			get
			{
				return MTO_Inputs_Channel_6;
			}
		}

		IShadowMTO_Inputs_Channel_53C09E8B IShadowEL2258_E3B260FA.MTO_Inputs_Channel_6
		{
			get
			{
				return MTO_Inputs_Channel_6;
			}
		}

		MTO_Inputs_Channel_53C09E8B _MTO_Inputs_Channel_7;
		public MTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_7
		{
			get
			{
				return _MTO_Inputs_Channel_7;
			}
		}

		IMTO_Inputs_Channel_53C09E8B IEL2258_E3B260FA.MTO_Inputs_Channel_7
		{
			get
			{
				return MTO_Inputs_Channel_7;
			}
		}

		IShadowMTO_Inputs_Channel_53C09E8B IShadowEL2258_E3B260FA.MTO_Inputs_Channel_7
		{
			get
			{
				return MTO_Inputs_Channel_7;
			}
		}

		MTO_Inputs_Channel_53C09E8B _MTO_Inputs_Channel_8;
		public MTO_Inputs_Channel_53C09E8B MTO_Inputs_Channel_8
		{
			get
			{
				return _MTO_Inputs_Channel_8;
			}
		}

		IMTO_Inputs_Channel_53C09E8B IEL2258_E3B260FA.MTO_Inputs_Channel_8
		{
			get
			{
				return MTO_Inputs_Channel_8;
			}
		}

		IShadowMTO_Inputs_Channel_53C09E8B IShadowEL2258_E3B260FA.MTO_Inputs_Channel_8
		{
			get
			{
				return MTO_Inputs_Channel_8;
			}
		}

		MTO_Outputs_10x_Channel_A3C0C022 _MTO_Outputs_10x_Channel_1;
		public MTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_1
		{
			get
			{
				return _MTO_Outputs_10x_Channel_1;
			}
		}

		IMTO_Outputs_10x_Channel_A3C0C022 IEL2258_E3B260FA.MTO_Outputs_10x_Channel_1
		{
			get
			{
				return MTO_Outputs_10x_Channel_1;
			}
		}

		IShadowMTO_Outputs_10x_Channel_A3C0C022 IShadowEL2258_E3B260FA.MTO_Outputs_10x_Channel_1
		{
			get
			{
				return MTO_Outputs_10x_Channel_1;
			}
		}

		MTO_Outputs_10x_Channel_A3C0C022 _MTO_Outputs_10x_Channel_2;
		public MTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_2
		{
			get
			{
				return _MTO_Outputs_10x_Channel_2;
			}
		}

		IMTO_Outputs_10x_Channel_A3C0C022 IEL2258_E3B260FA.MTO_Outputs_10x_Channel_2
		{
			get
			{
				return MTO_Outputs_10x_Channel_2;
			}
		}

		IShadowMTO_Outputs_10x_Channel_A3C0C022 IShadowEL2258_E3B260FA.MTO_Outputs_10x_Channel_2
		{
			get
			{
				return MTO_Outputs_10x_Channel_2;
			}
		}

		MTO_Outputs_10x_Channel_A3C0C022 _MTO_Outputs_10x_Channel_3;
		public MTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_3
		{
			get
			{
				return _MTO_Outputs_10x_Channel_3;
			}
		}

		IMTO_Outputs_10x_Channel_A3C0C022 IEL2258_E3B260FA.MTO_Outputs_10x_Channel_3
		{
			get
			{
				return MTO_Outputs_10x_Channel_3;
			}
		}

		IShadowMTO_Outputs_10x_Channel_A3C0C022 IShadowEL2258_E3B260FA.MTO_Outputs_10x_Channel_3
		{
			get
			{
				return MTO_Outputs_10x_Channel_3;
			}
		}

		MTO_Outputs_10x_Channel_A3C0C022 _MTO_Outputs_10x_Channel_4;
		public MTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_4
		{
			get
			{
				return _MTO_Outputs_10x_Channel_4;
			}
		}

		IMTO_Outputs_10x_Channel_A3C0C022 IEL2258_E3B260FA.MTO_Outputs_10x_Channel_4
		{
			get
			{
				return MTO_Outputs_10x_Channel_4;
			}
		}

		IShadowMTO_Outputs_10x_Channel_A3C0C022 IShadowEL2258_E3B260FA.MTO_Outputs_10x_Channel_4
		{
			get
			{
				return MTO_Outputs_10x_Channel_4;
			}
		}

		MTO_Outputs_10x_Channel_A3C0C022 _MTO_Outputs_10x_Channel_5;
		public MTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_5
		{
			get
			{
				return _MTO_Outputs_10x_Channel_5;
			}
		}

		IMTO_Outputs_10x_Channel_A3C0C022 IEL2258_E3B260FA.MTO_Outputs_10x_Channel_5
		{
			get
			{
				return MTO_Outputs_10x_Channel_5;
			}
		}

		IShadowMTO_Outputs_10x_Channel_A3C0C022 IShadowEL2258_E3B260FA.MTO_Outputs_10x_Channel_5
		{
			get
			{
				return MTO_Outputs_10x_Channel_5;
			}
		}

		MTO_Outputs_10x_Channel_A3C0C022 _MTO_Outputs_10x_Channel_6;
		public MTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_6
		{
			get
			{
				return _MTO_Outputs_10x_Channel_6;
			}
		}

		IMTO_Outputs_10x_Channel_A3C0C022 IEL2258_E3B260FA.MTO_Outputs_10x_Channel_6
		{
			get
			{
				return MTO_Outputs_10x_Channel_6;
			}
		}

		IShadowMTO_Outputs_10x_Channel_A3C0C022 IShadowEL2258_E3B260FA.MTO_Outputs_10x_Channel_6
		{
			get
			{
				return MTO_Outputs_10x_Channel_6;
			}
		}

		MTO_Outputs_10x_Channel_A3C0C022 _MTO_Outputs_10x_Channel_7;
		public MTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_7
		{
			get
			{
				return _MTO_Outputs_10x_Channel_7;
			}
		}

		IMTO_Outputs_10x_Channel_A3C0C022 IEL2258_E3B260FA.MTO_Outputs_10x_Channel_7
		{
			get
			{
				return MTO_Outputs_10x_Channel_7;
			}
		}

		IShadowMTO_Outputs_10x_Channel_A3C0C022 IShadowEL2258_E3B260FA.MTO_Outputs_10x_Channel_7
		{
			get
			{
				return MTO_Outputs_10x_Channel_7;
			}
		}

		MTO_Outputs_10x_Channel_A3C0C022 _MTO_Outputs_10x_Channel_8;
		public MTO_Outputs_10x_Channel_A3C0C022 MTO_Outputs_10x_Channel_8
		{
			get
			{
				return _MTO_Outputs_10x_Channel_8;
			}
		}

		IMTO_Outputs_10x_Channel_A3C0C022 IEL2258_E3B260FA.MTO_Outputs_10x_Channel_8
		{
			get
			{
				return MTO_Outputs_10x_Channel_8;
			}
		}

		IShadowMTO_Outputs_10x_Channel_A3C0C022 IShadowEL2258_E3B260FA.MTO_Outputs_10x_Channel_8
		{
			get
			{
				return MTO_Outputs_10x_Channel_8;
			}
		}

		TcoIo.WcState_9091E0EB _WcState;
		public TcoIo.WcState_9091E0EB WcState
		{
			get
			{
				return _WcState;
			}
		}

		TcoIo.IWcState_9091E0EB IEL2258_E3B260FA.WcState
		{
			get
			{
				return WcState;
			}
		}

		TcoIo.IShadowWcState_9091E0EB IShadowEL2258_E3B260FA.WcState
		{
			get
			{
				return WcState;
			}
		}

		InfoData_B84DBEC5 _InfoData;
		public InfoData_B84DBEC5 InfoData
		{
			get
			{
				return _InfoData;
			}
		}

		IInfoData_B84DBEC5 IEL2258_E3B260FA.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		IShadowInfoData_B84DBEC5 IShadowEL2258_E3B260FA.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			MTO_Inputs_Channel_1.LazyOnlineToShadow();
			MTO_Inputs_Channel_2.LazyOnlineToShadow();
			MTO_Inputs_Channel_3.LazyOnlineToShadow();
			MTO_Inputs_Channel_4.LazyOnlineToShadow();
			MTO_Inputs_Channel_5.LazyOnlineToShadow();
			MTO_Inputs_Channel_6.LazyOnlineToShadow();
			MTO_Inputs_Channel_7.LazyOnlineToShadow();
			MTO_Inputs_Channel_8.LazyOnlineToShadow();
			MTO_Outputs_10x_Channel_1.LazyOnlineToShadow();
			MTO_Outputs_10x_Channel_2.LazyOnlineToShadow();
			MTO_Outputs_10x_Channel_3.LazyOnlineToShadow();
			MTO_Outputs_10x_Channel_4.LazyOnlineToShadow();
			MTO_Outputs_10x_Channel_5.LazyOnlineToShadow();
			MTO_Outputs_10x_Channel_6.LazyOnlineToShadow();
			MTO_Outputs_10x_Channel_7.LazyOnlineToShadow();
			MTO_Outputs_10x_Channel_8.LazyOnlineToShadow();
			WcState.LazyOnlineToShadow();
			InfoData.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			MTO_Inputs_Channel_1.LazyShadowToOnline();
			MTO_Inputs_Channel_2.LazyShadowToOnline();
			MTO_Inputs_Channel_3.LazyShadowToOnline();
			MTO_Inputs_Channel_4.LazyShadowToOnline();
			MTO_Inputs_Channel_5.LazyShadowToOnline();
			MTO_Inputs_Channel_6.LazyShadowToOnline();
			MTO_Inputs_Channel_7.LazyShadowToOnline();
			MTO_Inputs_Channel_8.LazyShadowToOnline();
			MTO_Outputs_10x_Channel_1.LazyShadowToOnline();
			MTO_Outputs_10x_Channel_2.LazyShadowToOnline();
			MTO_Outputs_10x_Channel_3.LazyShadowToOnline();
			MTO_Outputs_10x_Channel_4.LazyShadowToOnline();
			MTO_Outputs_10x_Channel_5.LazyShadowToOnline();
			MTO_Outputs_10x_Channel_6.LazyShadowToOnline();
			MTO_Outputs_10x_Channel_7.LazyShadowToOnline();
			MTO_Outputs_10x_Channel_8.LazyShadowToOnline();
			WcState.LazyShadowToOnline();
			InfoData.LazyShadowToOnline();
		}

		public new PlainEL2258_E3B260FA CreatePlainerType()
		{
			var cloned = new PlainEL2258_E3B260FA();
			base.CreatePlainerType(cloned);
			cloned.MTO_Inputs_Channel_1 = MTO_Inputs_Channel_1.CreatePlainerType();
			cloned.MTO_Inputs_Channel_2 = MTO_Inputs_Channel_2.CreatePlainerType();
			cloned.MTO_Inputs_Channel_3 = MTO_Inputs_Channel_3.CreatePlainerType();
			cloned.MTO_Inputs_Channel_4 = MTO_Inputs_Channel_4.CreatePlainerType();
			cloned.MTO_Inputs_Channel_5 = MTO_Inputs_Channel_5.CreatePlainerType();
			cloned.MTO_Inputs_Channel_6 = MTO_Inputs_Channel_6.CreatePlainerType();
			cloned.MTO_Inputs_Channel_7 = MTO_Inputs_Channel_7.CreatePlainerType();
			cloned.MTO_Inputs_Channel_8 = MTO_Inputs_Channel_8.CreatePlainerType();
			cloned.MTO_Outputs_10x_Channel_1 = MTO_Outputs_10x_Channel_1.CreatePlainerType();
			cloned.MTO_Outputs_10x_Channel_2 = MTO_Outputs_10x_Channel_2.CreatePlainerType();
			cloned.MTO_Outputs_10x_Channel_3 = MTO_Outputs_10x_Channel_3.CreatePlainerType();
			cloned.MTO_Outputs_10x_Channel_4 = MTO_Outputs_10x_Channel_4.CreatePlainerType();
			cloned.MTO_Outputs_10x_Channel_5 = MTO_Outputs_10x_Channel_5.CreatePlainerType();
			cloned.MTO_Outputs_10x_Channel_6 = MTO_Outputs_10x_Channel_6.CreatePlainerType();
			cloned.MTO_Outputs_10x_Channel_7 = MTO_Outputs_10x_Channel_7.CreatePlainerType();
			cloned.MTO_Outputs_10x_Channel_8 = MTO_Outputs_10x_Channel_8.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		protected PlainEL2258_E3B260FA CreatePlainerType(PlainEL2258_E3B260FA cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.MTO_Inputs_Channel_1 = MTO_Inputs_Channel_1.CreatePlainerType();
			cloned.MTO_Inputs_Channel_2 = MTO_Inputs_Channel_2.CreatePlainerType();
			cloned.MTO_Inputs_Channel_3 = MTO_Inputs_Channel_3.CreatePlainerType();
			cloned.MTO_Inputs_Channel_4 = MTO_Inputs_Channel_4.CreatePlainerType();
			cloned.MTO_Inputs_Channel_5 = MTO_Inputs_Channel_5.CreatePlainerType();
			cloned.MTO_Inputs_Channel_6 = MTO_Inputs_Channel_6.CreatePlainerType();
			cloned.MTO_Inputs_Channel_7 = MTO_Inputs_Channel_7.CreatePlainerType();
			cloned.MTO_Inputs_Channel_8 = MTO_Inputs_Channel_8.CreatePlainerType();
			cloned.MTO_Outputs_10x_Channel_1 = MTO_Outputs_10x_Channel_1.CreatePlainerType();
			cloned.MTO_Outputs_10x_Channel_2 = MTO_Outputs_10x_Channel_2.CreatePlainerType();
			cloned.MTO_Outputs_10x_Channel_3 = MTO_Outputs_10x_Channel_3.CreatePlainerType();
			cloned.MTO_Outputs_10x_Channel_4 = MTO_Outputs_10x_Channel_4.CreatePlainerType();
			cloned.MTO_Outputs_10x_Channel_5 = MTO_Outputs_10x_Channel_5.CreatePlainerType();
			cloned.MTO_Outputs_10x_Channel_6 = MTO_Outputs_10x_Channel_6.CreatePlainerType();
			cloned.MTO_Outputs_10x_Channel_7 = MTO_Outputs_10x_Channel_7.CreatePlainerType();
			cloned.MTO_Outputs_10x_Channel_8 = MTO_Outputs_10x_Channel_8.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainEL2258_E3B260FA source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainEL2258_E3B260FA source)
		{
			source.CopyPlainToShadow(this);
		}

		public new void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public new void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(Plc1.PlainEL2258_E3B260FA source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public System.String AttributeVendorId
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeVendorId, this).Interpolate(this);
			}

			set
			{
				_AttributeVendorId = value;
			}
		}

		private System.String _AttributeVendorId
		{
			get;
			set;
		}

		public System.String AttributeBoxType
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeBoxType, this).Interpolate(this);
			}

			set
			{
				_AttributeBoxType = value;
			}
		}

		private System.String _AttributeBoxType
		{
			get;
			set;
		}

		public System.String AttributeDescription
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeDescription, this).Interpolate(this);
			}

			set
			{
				_AttributeDescription = value;
			}
		}

		private System.String _AttributeDescription
		{
			get;
			set;
		}

		public System.String AttributePhysics
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributePhysics, this).Interpolate(this);
			}

			set
			{
				_AttributePhysics = value;
			}
		}

		private System.String _AttributePhysics
		{
			get;
			set;
		}

		public System.String AttributeId
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeId, this).Interpolate(this);
			}

			set
			{
				_AttributeId = value;
			}
		}

		private System.String _AttributeId
		{
			get;
			set;
		}

		public System.String AttributeCRC
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeCRC, this).Interpolate(this);
			}

			set
			{
				_AttributeCRC = value;
			}
		}

		private System.String _AttributeCRC
		{
			get;
			set;
		}

		public System.String AttributeSize
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeSize, this).Interpolate(this);
			}

			set
			{
				_AttributeSize = value;
			}
		}

		private System.String _AttributeSize
		{
			get;
			set;
		}

		public EL2258_E3B260FA(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_MTO_Inputs_Channel_1 = new MTO_Inputs_Channel_53C09E8B(this, "MTO_Inputs_Channel_1", "MTO_Inputs_Channel_1");
			_MTO_Inputs_Channel_1.AttributeName = "MTO_Inputs_Channel_1";
			_MTO_Inputs_Channel_2 = new MTO_Inputs_Channel_53C09E8B(this, "MTO_Inputs_Channel_2", "MTO_Inputs_Channel_2");
			_MTO_Inputs_Channel_2.AttributeName = "MTO_Inputs_Channel_2";
			_MTO_Inputs_Channel_3 = new MTO_Inputs_Channel_53C09E8B(this, "MTO_Inputs_Channel_3", "MTO_Inputs_Channel_3");
			_MTO_Inputs_Channel_3.AttributeName = "MTO_Inputs_Channel_3";
			_MTO_Inputs_Channel_4 = new MTO_Inputs_Channel_53C09E8B(this, "MTO_Inputs_Channel_4", "MTO_Inputs_Channel_4");
			_MTO_Inputs_Channel_4.AttributeName = "MTO_Inputs_Channel_4";
			_MTO_Inputs_Channel_5 = new MTO_Inputs_Channel_53C09E8B(this, "MTO_Inputs_Channel_5", "MTO_Inputs_Channel_5");
			_MTO_Inputs_Channel_5.AttributeName = "MTO_Inputs_Channel_5";
			_MTO_Inputs_Channel_6 = new MTO_Inputs_Channel_53C09E8B(this, "MTO_Inputs_Channel_6", "MTO_Inputs_Channel_6");
			_MTO_Inputs_Channel_6.AttributeName = "MTO_Inputs_Channel_6";
			_MTO_Inputs_Channel_7 = new MTO_Inputs_Channel_53C09E8B(this, "MTO_Inputs_Channel_7", "MTO_Inputs_Channel_7");
			_MTO_Inputs_Channel_7.AttributeName = "MTO_Inputs_Channel_7";
			_MTO_Inputs_Channel_8 = new MTO_Inputs_Channel_53C09E8B(this, "MTO_Inputs_Channel_8", "MTO_Inputs_Channel_8");
			_MTO_Inputs_Channel_8.AttributeName = "MTO_Inputs_Channel_8";
			_MTO_Outputs_10x_Channel_1 = new MTO_Outputs_10x_Channel_A3C0C022(this, "MTO_Outputs_10x_Channel_1", "MTO_Outputs_10x_Channel_1");
			_MTO_Outputs_10x_Channel_1.AttributeName = "MTO_Outputs_10x_Channel_1";
			_MTO_Outputs_10x_Channel_2 = new MTO_Outputs_10x_Channel_A3C0C022(this, "MTO_Outputs_10x_Channel_2", "MTO_Outputs_10x_Channel_2");
			_MTO_Outputs_10x_Channel_2.AttributeName = "MTO_Outputs_10x_Channel_2";
			_MTO_Outputs_10x_Channel_3 = new MTO_Outputs_10x_Channel_A3C0C022(this, "MTO_Outputs_10x_Channel_3", "MTO_Outputs_10x_Channel_3");
			_MTO_Outputs_10x_Channel_3.AttributeName = "MTO_Outputs_10x_Channel_3";
			_MTO_Outputs_10x_Channel_4 = new MTO_Outputs_10x_Channel_A3C0C022(this, "MTO_Outputs_10x_Channel_4", "MTO_Outputs_10x_Channel_4");
			_MTO_Outputs_10x_Channel_4.AttributeName = "MTO_Outputs_10x_Channel_4";
			_MTO_Outputs_10x_Channel_5 = new MTO_Outputs_10x_Channel_A3C0C022(this, "MTO_Outputs_10x_Channel_5", "MTO_Outputs_10x_Channel_5");
			_MTO_Outputs_10x_Channel_5.AttributeName = "MTO_Outputs_10x_Channel_5";
			_MTO_Outputs_10x_Channel_6 = new MTO_Outputs_10x_Channel_A3C0C022(this, "MTO_Outputs_10x_Channel_6", "MTO_Outputs_10x_Channel_6");
			_MTO_Outputs_10x_Channel_6.AttributeName = "MTO_Outputs_10x_Channel_6";
			_MTO_Outputs_10x_Channel_7 = new MTO_Outputs_10x_Channel_A3C0C022(this, "MTO_Outputs_10x_Channel_7", "MTO_Outputs_10x_Channel_7");
			_MTO_Outputs_10x_Channel_7.AttributeName = "MTO_Outputs_10x_Channel_7";
			_MTO_Outputs_10x_Channel_8 = new MTO_Outputs_10x_Channel_A3C0C022(this, "MTO_Outputs_10x_Channel_8", "MTO_Outputs_10x_Channel_8");
			_MTO_Outputs_10x_Channel_8.AttributeName = "MTO_Outputs_10x_Channel_8";
			_WcState = new TcoIo.WcState_9091E0EB(this, "WcState", "WcState");
			_WcState.AttributeName = "WcState";
			_InfoData = new InfoData_B84DBEC5(this, "InfoData", "InfoData");
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL2258-0000-0017";
			AttributeDescription = "EL2258 8Ch. Dig Output 24V with Multi-Time-Stamp";
			AttributePhysics = "KK";
			AttributeId = "MTO_Inputs_Channel_1AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_2AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_3AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_4AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_5AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_6AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_7AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_8AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Outputs_10x_Channel_1AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_2AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_3AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_4AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_5AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_6AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_7AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_8AT %Q*MTO_Outputs_10x_Channel_A3C0C02256WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_B84DBEC510";
			AttributeCRC = "3820118266";
			AttributeSize = "508";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public EL2258_E3B260FA(): base ()
		{
			PexPreConstructorParameterless();
			_MTO_Inputs_Channel_1 = new MTO_Inputs_Channel_53C09E8B();
			_MTO_Inputs_Channel_1.AttributeName = "MTO_Inputs_Channel_1";
			_MTO_Inputs_Channel_2 = new MTO_Inputs_Channel_53C09E8B();
			_MTO_Inputs_Channel_2.AttributeName = "MTO_Inputs_Channel_2";
			_MTO_Inputs_Channel_3 = new MTO_Inputs_Channel_53C09E8B();
			_MTO_Inputs_Channel_3.AttributeName = "MTO_Inputs_Channel_3";
			_MTO_Inputs_Channel_4 = new MTO_Inputs_Channel_53C09E8B();
			_MTO_Inputs_Channel_4.AttributeName = "MTO_Inputs_Channel_4";
			_MTO_Inputs_Channel_5 = new MTO_Inputs_Channel_53C09E8B();
			_MTO_Inputs_Channel_5.AttributeName = "MTO_Inputs_Channel_5";
			_MTO_Inputs_Channel_6 = new MTO_Inputs_Channel_53C09E8B();
			_MTO_Inputs_Channel_6.AttributeName = "MTO_Inputs_Channel_6";
			_MTO_Inputs_Channel_7 = new MTO_Inputs_Channel_53C09E8B();
			_MTO_Inputs_Channel_7.AttributeName = "MTO_Inputs_Channel_7";
			_MTO_Inputs_Channel_8 = new MTO_Inputs_Channel_53C09E8B();
			_MTO_Inputs_Channel_8.AttributeName = "MTO_Inputs_Channel_8";
			_MTO_Outputs_10x_Channel_1 = new MTO_Outputs_10x_Channel_A3C0C022();
			_MTO_Outputs_10x_Channel_1.AttributeName = "MTO_Outputs_10x_Channel_1";
			_MTO_Outputs_10x_Channel_2 = new MTO_Outputs_10x_Channel_A3C0C022();
			_MTO_Outputs_10x_Channel_2.AttributeName = "MTO_Outputs_10x_Channel_2";
			_MTO_Outputs_10x_Channel_3 = new MTO_Outputs_10x_Channel_A3C0C022();
			_MTO_Outputs_10x_Channel_3.AttributeName = "MTO_Outputs_10x_Channel_3";
			_MTO_Outputs_10x_Channel_4 = new MTO_Outputs_10x_Channel_A3C0C022();
			_MTO_Outputs_10x_Channel_4.AttributeName = "MTO_Outputs_10x_Channel_4";
			_MTO_Outputs_10x_Channel_5 = new MTO_Outputs_10x_Channel_A3C0C022();
			_MTO_Outputs_10x_Channel_5.AttributeName = "MTO_Outputs_10x_Channel_5";
			_MTO_Outputs_10x_Channel_6 = new MTO_Outputs_10x_Channel_A3C0C022();
			_MTO_Outputs_10x_Channel_6.AttributeName = "MTO_Outputs_10x_Channel_6";
			_MTO_Outputs_10x_Channel_7 = new MTO_Outputs_10x_Channel_A3C0C022();
			_MTO_Outputs_10x_Channel_7.AttributeName = "MTO_Outputs_10x_Channel_7";
			_MTO_Outputs_10x_Channel_8 = new MTO_Outputs_10x_Channel_A3C0C022();
			_MTO_Outputs_10x_Channel_8.AttributeName = "MTO_Outputs_10x_Channel_8";
			_WcState = new TcoIo.WcState_9091E0EB();
			_WcState.AttributeName = "WcState";
			_InfoData = new InfoData_B84DBEC5();
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL2258-0000-0017";
			AttributeDescription = "EL2258 8Ch. Dig Output 24V with Multi-Time-Stamp";
			AttributePhysics = "KK";
			AttributeId = "MTO_Inputs_Channel_1AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_2AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_3AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_4AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_5AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_6AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_7AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Inputs_Channel_8AT %I*MTO_Inputs_Channel_53C09E8B6MTO_Outputs_10x_Channel_1AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_2AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_3AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_4AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_5AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_6AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_7AT %Q*MTO_Outputs_10x_Channel_A3C0C02256MTO_Outputs_10x_Channel_8AT %Q*MTO_Outputs_10x_Channel_A3C0C02256WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_B84DBEC510";
			AttributeCRC = "3820118266";
			AttributeSize = "508";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL2258_E3B260FA
	{
		public void CopyPlainToCyclic(Plc1.EL2258_E3B260FA target)
		{
			base.CopyPlainToCyclic(target);
			MTO_Inputs_Channel_1.CopyPlainToCyclic(target.MTO_Inputs_Channel_1);
			MTO_Inputs_Channel_2.CopyPlainToCyclic(target.MTO_Inputs_Channel_2);
			MTO_Inputs_Channel_3.CopyPlainToCyclic(target.MTO_Inputs_Channel_3);
			MTO_Inputs_Channel_4.CopyPlainToCyclic(target.MTO_Inputs_Channel_4);
			MTO_Inputs_Channel_5.CopyPlainToCyclic(target.MTO_Inputs_Channel_5);
			MTO_Inputs_Channel_6.CopyPlainToCyclic(target.MTO_Inputs_Channel_6);
			MTO_Inputs_Channel_7.CopyPlainToCyclic(target.MTO_Inputs_Channel_7);
			MTO_Inputs_Channel_8.CopyPlainToCyclic(target.MTO_Inputs_Channel_8);
			MTO_Outputs_10x_Channel_1.CopyPlainToCyclic(target.MTO_Outputs_10x_Channel_1);
			MTO_Outputs_10x_Channel_2.CopyPlainToCyclic(target.MTO_Outputs_10x_Channel_2);
			MTO_Outputs_10x_Channel_3.CopyPlainToCyclic(target.MTO_Outputs_10x_Channel_3);
			MTO_Outputs_10x_Channel_4.CopyPlainToCyclic(target.MTO_Outputs_10x_Channel_4);
			MTO_Outputs_10x_Channel_5.CopyPlainToCyclic(target.MTO_Outputs_10x_Channel_5);
			MTO_Outputs_10x_Channel_6.CopyPlainToCyclic(target.MTO_Outputs_10x_Channel_6);
			MTO_Outputs_10x_Channel_7.CopyPlainToCyclic(target.MTO_Outputs_10x_Channel_7);
			MTO_Outputs_10x_Channel_8.CopyPlainToCyclic(target.MTO_Outputs_10x_Channel_8);
			WcState.CopyPlainToCyclic(target.WcState);
			InfoData.CopyPlainToCyclic(target.InfoData);
		}

		public void CopyPlainToCyclic(Plc1.IEL2258_E3B260FA target)
		{
			this.CopyPlainToCyclic((Plc1.EL2258_E3B260FA)target);
		}

		public void CopyPlainToShadow(Plc1.EL2258_E3B260FA target)
		{
			base.CopyPlainToShadow(target);
			MTO_Inputs_Channel_1.CopyPlainToShadow(target.MTO_Inputs_Channel_1);
			MTO_Inputs_Channel_2.CopyPlainToShadow(target.MTO_Inputs_Channel_2);
			MTO_Inputs_Channel_3.CopyPlainToShadow(target.MTO_Inputs_Channel_3);
			MTO_Inputs_Channel_4.CopyPlainToShadow(target.MTO_Inputs_Channel_4);
			MTO_Inputs_Channel_5.CopyPlainToShadow(target.MTO_Inputs_Channel_5);
			MTO_Inputs_Channel_6.CopyPlainToShadow(target.MTO_Inputs_Channel_6);
			MTO_Inputs_Channel_7.CopyPlainToShadow(target.MTO_Inputs_Channel_7);
			MTO_Inputs_Channel_8.CopyPlainToShadow(target.MTO_Inputs_Channel_8);
			MTO_Outputs_10x_Channel_1.CopyPlainToShadow(target.MTO_Outputs_10x_Channel_1);
			MTO_Outputs_10x_Channel_2.CopyPlainToShadow(target.MTO_Outputs_10x_Channel_2);
			MTO_Outputs_10x_Channel_3.CopyPlainToShadow(target.MTO_Outputs_10x_Channel_3);
			MTO_Outputs_10x_Channel_4.CopyPlainToShadow(target.MTO_Outputs_10x_Channel_4);
			MTO_Outputs_10x_Channel_5.CopyPlainToShadow(target.MTO_Outputs_10x_Channel_5);
			MTO_Outputs_10x_Channel_6.CopyPlainToShadow(target.MTO_Outputs_10x_Channel_6);
			MTO_Outputs_10x_Channel_7.CopyPlainToShadow(target.MTO_Outputs_10x_Channel_7);
			MTO_Outputs_10x_Channel_8.CopyPlainToShadow(target.MTO_Outputs_10x_Channel_8);
			WcState.CopyPlainToShadow(target.WcState);
			InfoData.CopyPlainToShadow(target.InfoData);
		}

		public void CopyPlainToShadow(Plc1.IShadowEL2258_E3B260FA target)
		{
			this.CopyPlainToShadow((Plc1.EL2258_E3B260FA)target);
		}

		public void CopyCyclicToPlain(Plc1.EL2258_E3B260FA source)
		{
			base.CopyCyclicToPlain(source);
			MTO_Inputs_Channel_1.CopyCyclicToPlain(source.MTO_Inputs_Channel_1);
			MTO_Inputs_Channel_2.CopyCyclicToPlain(source.MTO_Inputs_Channel_2);
			MTO_Inputs_Channel_3.CopyCyclicToPlain(source.MTO_Inputs_Channel_3);
			MTO_Inputs_Channel_4.CopyCyclicToPlain(source.MTO_Inputs_Channel_4);
			MTO_Inputs_Channel_5.CopyCyclicToPlain(source.MTO_Inputs_Channel_5);
			MTO_Inputs_Channel_6.CopyCyclicToPlain(source.MTO_Inputs_Channel_6);
			MTO_Inputs_Channel_7.CopyCyclicToPlain(source.MTO_Inputs_Channel_7);
			MTO_Inputs_Channel_8.CopyCyclicToPlain(source.MTO_Inputs_Channel_8);
			MTO_Outputs_10x_Channel_1.CopyCyclicToPlain(source.MTO_Outputs_10x_Channel_1);
			MTO_Outputs_10x_Channel_2.CopyCyclicToPlain(source.MTO_Outputs_10x_Channel_2);
			MTO_Outputs_10x_Channel_3.CopyCyclicToPlain(source.MTO_Outputs_10x_Channel_3);
			MTO_Outputs_10x_Channel_4.CopyCyclicToPlain(source.MTO_Outputs_10x_Channel_4);
			MTO_Outputs_10x_Channel_5.CopyCyclicToPlain(source.MTO_Outputs_10x_Channel_5);
			MTO_Outputs_10x_Channel_6.CopyCyclicToPlain(source.MTO_Outputs_10x_Channel_6);
			MTO_Outputs_10x_Channel_7.CopyCyclicToPlain(source.MTO_Outputs_10x_Channel_7);
			MTO_Outputs_10x_Channel_8.CopyCyclicToPlain(source.MTO_Outputs_10x_Channel_8);
			WcState.CopyCyclicToPlain(source.WcState);
			InfoData.CopyCyclicToPlain(source.InfoData);
		}

		public void CopyCyclicToPlain(Plc1.IEL2258_E3B260FA source)
		{
			this.CopyCyclicToPlain((Plc1.EL2258_E3B260FA)source);
		}

		public void CopyShadowToPlain(Plc1.EL2258_E3B260FA source)
		{
			base.CopyShadowToPlain(source);
			MTO_Inputs_Channel_1.CopyShadowToPlain(source.MTO_Inputs_Channel_1);
			MTO_Inputs_Channel_2.CopyShadowToPlain(source.MTO_Inputs_Channel_2);
			MTO_Inputs_Channel_3.CopyShadowToPlain(source.MTO_Inputs_Channel_3);
			MTO_Inputs_Channel_4.CopyShadowToPlain(source.MTO_Inputs_Channel_4);
			MTO_Inputs_Channel_5.CopyShadowToPlain(source.MTO_Inputs_Channel_5);
			MTO_Inputs_Channel_6.CopyShadowToPlain(source.MTO_Inputs_Channel_6);
			MTO_Inputs_Channel_7.CopyShadowToPlain(source.MTO_Inputs_Channel_7);
			MTO_Inputs_Channel_8.CopyShadowToPlain(source.MTO_Inputs_Channel_8);
			MTO_Outputs_10x_Channel_1.CopyShadowToPlain(source.MTO_Outputs_10x_Channel_1);
			MTO_Outputs_10x_Channel_2.CopyShadowToPlain(source.MTO_Outputs_10x_Channel_2);
			MTO_Outputs_10x_Channel_3.CopyShadowToPlain(source.MTO_Outputs_10x_Channel_3);
			MTO_Outputs_10x_Channel_4.CopyShadowToPlain(source.MTO_Outputs_10x_Channel_4);
			MTO_Outputs_10x_Channel_5.CopyShadowToPlain(source.MTO_Outputs_10x_Channel_5);
			MTO_Outputs_10x_Channel_6.CopyShadowToPlain(source.MTO_Outputs_10x_Channel_6);
			MTO_Outputs_10x_Channel_7.CopyShadowToPlain(source.MTO_Outputs_10x_Channel_7);
			MTO_Outputs_10x_Channel_8.CopyShadowToPlain(source.MTO_Outputs_10x_Channel_8);
			WcState.CopyShadowToPlain(source.WcState);
			InfoData.CopyShadowToPlain(source.InfoData);
		}

		public void CopyShadowToPlain(Plc1.IShadowEL2258_E3B260FA source)
		{
			this.CopyShadowToPlain((Plc1.EL2258_E3B260FA)source);
		}
	}
}