using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty VendorId \"#x00000002\" } {attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Description \"EL3773 3 Ch. Power Monitoring, Oversample\" } {attribute addProperty Physics \"KK\" } {attribute addProperty Id \"L1_Voltage_StatusAT %I*L1_Voltage_Status_7371B0437L1_Voltage_SamplesAT %I*L1_Voltage_Samples_41AEB7FF20L1_Current_StatusAT %I*L1_Current_Status_82DECBF67L1_Current_SamplesAT %I*L1_Current_Samples_9EC08B3E20L2_Voltage_StatusAT %I*L2_Voltage_Status_0D1813FE7L2_Voltage_SamplesAT %I*L2_Voltage_Samples_75D833AF20L2_Current_StatusAT %I*L2_Current_Status_FCB7684B7L2_Current_SamplesAT %I*L2_Current_Samples_AAB60F6E20L3_Voltage_StatusAT %I*L3_Voltage_Status_273F72957L3_Voltage_SamplesAT %I*L3_Voltage_Samples_660A4F9F20L3_Current_StatusAT %I*L3_Current_Status_D69009207L3_Current_SamplesAT %I*L3_Current_Samples_B964735E20AI_NextSync1TimeAT %I*AI_NextSync1Time_6DC4D2968AI_Sample_CountAT %I*AI_Sample_Count_EA88CAD92WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_B84DBEC510\" } {attribute addProperty CRC \"4045982850\" } {attribute addProperty Size \"184\" } {attribute addProperty Name \"\" }", "EL3773_F128CC82", "Plc1", TypeComplexityEnum.Complex)]
	public partial class EL3773_F128CC82 : TcoIo.EtcSlaveTerminalBase_947E5A46, Vortex.Connector.IVortexObject, IEL3773_F128CC82, IShadowEL3773_F128CC82, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		L1_Voltage_Status_7371B043 _L1_Voltage_Status;
		public L1_Voltage_Status_7371B043 L1_Voltage_Status
		{
			get
			{
				return _L1_Voltage_Status;
			}
		}

		IL1_Voltage_Status_7371B043 IEL3773_F128CC82.L1_Voltage_Status
		{
			get
			{
				return L1_Voltage_Status;
			}
		}

		IShadowL1_Voltage_Status_7371B043 IShadowEL3773_F128CC82.L1_Voltage_Status
		{
			get
			{
				return L1_Voltage_Status;
			}
		}

		L1_Voltage_Samples_41AEB7FF _L1_Voltage_Samples;
		public L1_Voltage_Samples_41AEB7FF L1_Voltage_Samples
		{
			get
			{
				return _L1_Voltage_Samples;
			}
		}

		IL1_Voltage_Samples_41AEB7FF IEL3773_F128CC82.L1_Voltage_Samples
		{
			get
			{
				return L1_Voltage_Samples;
			}
		}

		IShadowL1_Voltage_Samples_41AEB7FF IShadowEL3773_F128CC82.L1_Voltage_Samples
		{
			get
			{
				return L1_Voltage_Samples;
			}
		}

		L1_Current_Status_82DECBF6 _L1_Current_Status;
		public L1_Current_Status_82DECBF6 L1_Current_Status
		{
			get
			{
				return _L1_Current_Status;
			}
		}

		IL1_Current_Status_82DECBF6 IEL3773_F128CC82.L1_Current_Status
		{
			get
			{
				return L1_Current_Status;
			}
		}

		IShadowL1_Current_Status_82DECBF6 IShadowEL3773_F128CC82.L1_Current_Status
		{
			get
			{
				return L1_Current_Status;
			}
		}

		L1_Current_Samples_9EC08B3E _L1_Current_Samples;
		public L1_Current_Samples_9EC08B3E L1_Current_Samples
		{
			get
			{
				return _L1_Current_Samples;
			}
		}

		IL1_Current_Samples_9EC08B3E IEL3773_F128CC82.L1_Current_Samples
		{
			get
			{
				return L1_Current_Samples;
			}
		}

		IShadowL1_Current_Samples_9EC08B3E IShadowEL3773_F128CC82.L1_Current_Samples
		{
			get
			{
				return L1_Current_Samples;
			}
		}

		L2_Voltage_Status_0D1813FE _L2_Voltage_Status;
		public L2_Voltage_Status_0D1813FE L2_Voltage_Status
		{
			get
			{
				return _L2_Voltage_Status;
			}
		}

		IL2_Voltage_Status_0D1813FE IEL3773_F128CC82.L2_Voltage_Status
		{
			get
			{
				return L2_Voltage_Status;
			}
		}

		IShadowL2_Voltage_Status_0D1813FE IShadowEL3773_F128CC82.L2_Voltage_Status
		{
			get
			{
				return L2_Voltage_Status;
			}
		}

		L2_Voltage_Samples_75D833AF _L2_Voltage_Samples;
		public L2_Voltage_Samples_75D833AF L2_Voltage_Samples
		{
			get
			{
				return _L2_Voltage_Samples;
			}
		}

		IL2_Voltage_Samples_75D833AF IEL3773_F128CC82.L2_Voltage_Samples
		{
			get
			{
				return L2_Voltage_Samples;
			}
		}

		IShadowL2_Voltage_Samples_75D833AF IShadowEL3773_F128CC82.L2_Voltage_Samples
		{
			get
			{
				return L2_Voltage_Samples;
			}
		}

		L2_Current_Status_FCB7684B _L2_Current_Status;
		public L2_Current_Status_FCB7684B L2_Current_Status
		{
			get
			{
				return _L2_Current_Status;
			}
		}

		IL2_Current_Status_FCB7684B IEL3773_F128CC82.L2_Current_Status
		{
			get
			{
				return L2_Current_Status;
			}
		}

		IShadowL2_Current_Status_FCB7684B IShadowEL3773_F128CC82.L2_Current_Status
		{
			get
			{
				return L2_Current_Status;
			}
		}

		L2_Current_Samples_AAB60F6E _L2_Current_Samples;
		public L2_Current_Samples_AAB60F6E L2_Current_Samples
		{
			get
			{
				return _L2_Current_Samples;
			}
		}

		IL2_Current_Samples_AAB60F6E IEL3773_F128CC82.L2_Current_Samples
		{
			get
			{
				return L2_Current_Samples;
			}
		}

		IShadowL2_Current_Samples_AAB60F6E IShadowEL3773_F128CC82.L2_Current_Samples
		{
			get
			{
				return L2_Current_Samples;
			}
		}

		L3_Voltage_Status_273F7295 _L3_Voltage_Status;
		public L3_Voltage_Status_273F7295 L3_Voltage_Status
		{
			get
			{
				return _L3_Voltage_Status;
			}
		}

		IL3_Voltage_Status_273F7295 IEL3773_F128CC82.L3_Voltage_Status
		{
			get
			{
				return L3_Voltage_Status;
			}
		}

		IShadowL3_Voltage_Status_273F7295 IShadowEL3773_F128CC82.L3_Voltage_Status
		{
			get
			{
				return L3_Voltage_Status;
			}
		}

		L3_Voltage_Samples_660A4F9F _L3_Voltage_Samples;
		public L3_Voltage_Samples_660A4F9F L3_Voltage_Samples
		{
			get
			{
				return _L3_Voltage_Samples;
			}
		}

		IL3_Voltage_Samples_660A4F9F IEL3773_F128CC82.L3_Voltage_Samples
		{
			get
			{
				return L3_Voltage_Samples;
			}
		}

		IShadowL3_Voltage_Samples_660A4F9F IShadowEL3773_F128CC82.L3_Voltage_Samples
		{
			get
			{
				return L3_Voltage_Samples;
			}
		}

		L3_Current_Status_D6900920 _L3_Current_Status;
		public L3_Current_Status_D6900920 L3_Current_Status
		{
			get
			{
				return _L3_Current_Status;
			}
		}

		IL3_Current_Status_D6900920 IEL3773_F128CC82.L3_Current_Status
		{
			get
			{
				return L3_Current_Status;
			}
		}

		IShadowL3_Current_Status_D6900920 IShadowEL3773_F128CC82.L3_Current_Status
		{
			get
			{
				return L3_Current_Status;
			}
		}

		L3_Current_Samples_B964735E _L3_Current_Samples;
		public L3_Current_Samples_B964735E L3_Current_Samples
		{
			get
			{
				return _L3_Current_Samples;
			}
		}

		IL3_Current_Samples_B964735E IEL3773_F128CC82.L3_Current_Samples
		{
			get
			{
				return L3_Current_Samples;
			}
		}

		IShadowL3_Current_Samples_B964735E IShadowEL3773_F128CC82.L3_Current_Samples
		{
			get
			{
				return L3_Current_Samples;
			}
		}

		AI_NextSync1Time_6DC4D296 _AI_NextSync1Time;
		public AI_NextSync1Time_6DC4D296 AI_NextSync1Time
		{
			get
			{
				return _AI_NextSync1Time;
			}
		}

		IAI_NextSync1Time_6DC4D296 IEL3773_F128CC82.AI_NextSync1Time
		{
			get
			{
				return AI_NextSync1Time;
			}
		}

		IShadowAI_NextSync1Time_6DC4D296 IShadowEL3773_F128CC82.AI_NextSync1Time
		{
			get
			{
				return AI_NextSync1Time;
			}
		}

		AI_Sample_Count_EA88CAD9 _AI_Sample_Count;
		public AI_Sample_Count_EA88CAD9 AI_Sample_Count
		{
			get
			{
				return _AI_Sample_Count;
			}
		}

		IAI_Sample_Count_EA88CAD9 IEL3773_F128CC82.AI_Sample_Count
		{
			get
			{
				return AI_Sample_Count;
			}
		}

		IShadowAI_Sample_Count_EA88CAD9 IShadowEL3773_F128CC82.AI_Sample_Count
		{
			get
			{
				return AI_Sample_Count;
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

		TcoIo.IWcState_9091E0EB IEL3773_F128CC82.WcState
		{
			get
			{
				return WcState;
			}
		}

		TcoIo.IShadowWcState_9091E0EB IShadowEL3773_F128CC82.WcState
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

		IInfoData_B84DBEC5 IEL3773_F128CC82.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		IShadowInfoData_B84DBEC5 IShadowEL3773_F128CC82.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			L1_Voltage_Status.LazyOnlineToShadow();
			L1_Voltage_Samples.LazyOnlineToShadow();
			L1_Current_Status.LazyOnlineToShadow();
			L1_Current_Samples.LazyOnlineToShadow();
			L2_Voltage_Status.LazyOnlineToShadow();
			L2_Voltage_Samples.LazyOnlineToShadow();
			L2_Current_Status.LazyOnlineToShadow();
			L2_Current_Samples.LazyOnlineToShadow();
			L3_Voltage_Status.LazyOnlineToShadow();
			L3_Voltage_Samples.LazyOnlineToShadow();
			L3_Current_Status.LazyOnlineToShadow();
			L3_Current_Samples.LazyOnlineToShadow();
			AI_NextSync1Time.LazyOnlineToShadow();
			AI_Sample_Count.LazyOnlineToShadow();
			WcState.LazyOnlineToShadow();
			InfoData.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			L1_Voltage_Status.LazyShadowToOnline();
			L1_Voltage_Samples.LazyShadowToOnline();
			L1_Current_Status.LazyShadowToOnline();
			L1_Current_Samples.LazyShadowToOnline();
			L2_Voltage_Status.LazyShadowToOnline();
			L2_Voltage_Samples.LazyShadowToOnline();
			L2_Current_Status.LazyShadowToOnline();
			L2_Current_Samples.LazyShadowToOnline();
			L3_Voltage_Status.LazyShadowToOnline();
			L3_Voltage_Samples.LazyShadowToOnline();
			L3_Current_Status.LazyShadowToOnline();
			L3_Current_Samples.LazyShadowToOnline();
			AI_NextSync1Time.LazyShadowToOnline();
			AI_Sample_Count.LazyShadowToOnline();
			WcState.LazyShadowToOnline();
			InfoData.LazyShadowToOnline();
		}

		public new PlainEL3773_F128CC82 CreatePlainerType()
		{
			var cloned = new PlainEL3773_F128CC82();
			base.CreatePlainerType(cloned);
			cloned.L1_Voltage_Status = L1_Voltage_Status.CreatePlainerType();
			cloned.L1_Voltage_Samples = L1_Voltage_Samples.CreatePlainerType();
			cloned.L1_Current_Status = L1_Current_Status.CreatePlainerType();
			cloned.L1_Current_Samples = L1_Current_Samples.CreatePlainerType();
			cloned.L2_Voltage_Status = L2_Voltage_Status.CreatePlainerType();
			cloned.L2_Voltage_Samples = L2_Voltage_Samples.CreatePlainerType();
			cloned.L2_Current_Status = L2_Current_Status.CreatePlainerType();
			cloned.L2_Current_Samples = L2_Current_Samples.CreatePlainerType();
			cloned.L3_Voltage_Status = L3_Voltage_Status.CreatePlainerType();
			cloned.L3_Voltage_Samples = L3_Voltage_Samples.CreatePlainerType();
			cloned.L3_Current_Status = L3_Current_Status.CreatePlainerType();
			cloned.L3_Current_Samples = L3_Current_Samples.CreatePlainerType();
			cloned.AI_NextSync1Time = AI_NextSync1Time.CreatePlainerType();
			cloned.AI_Sample_Count = AI_Sample_Count.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		protected PlainEL3773_F128CC82 CreatePlainerType(PlainEL3773_F128CC82 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.L1_Voltage_Status = L1_Voltage_Status.CreatePlainerType();
			cloned.L1_Voltage_Samples = L1_Voltage_Samples.CreatePlainerType();
			cloned.L1_Current_Status = L1_Current_Status.CreatePlainerType();
			cloned.L1_Current_Samples = L1_Current_Samples.CreatePlainerType();
			cloned.L2_Voltage_Status = L2_Voltage_Status.CreatePlainerType();
			cloned.L2_Voltage_Samples = L2_Voltage_Samples.CreatePlainerType();
			cloned.L2_Current_Status = L2_Current_Status.CreatePlainerType();
			cloned.L2_Current_Samples = L2_Current_Samples.CreatePlainerType();
			cloned.L3_Voltage_Status = L3_Voltage_Status.CreatePlainerType();
			cloned.L3_Voltage_Samples = L3_Voltage_Samples.CreatePlainerType();
			cloned.L3_Current_Status = L3_Current_Status.CreatePlainerType();
			cloned.L3_Current_Samples = L3_Current_Samples.CreatePlainerType();
			cloned.AI_NextSync1Time = AI_NextSync1Time.CreatePlainerType();
			cloned.AI_Sample_Count = AI_Sample_Count.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainEL3773_F128CC82 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainEL3773_F128CC82 source)
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

		public void FlushOnlineToPlain(Plc1.PlainEL3773_F128CC82 source)
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

		public EL3773_F128CC82(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_L1_Voltage_Status = new L1_Voltage_Status_7371B043(this, "L1_Voltage_Status", "L1_Voltage_Status");
			_L1_Voltage_Status.AttributeName = "L1_Voltage_Status";
			_L1_Voltage_Samples = new L1_Voltage_Samples_41AEB7FF(this, "L1_Voltage_Samples", "L1_Voltage_Samples");
			_L1_Voltage_Samples.AttributeName = "L1_Voltage_Samples";
			_L1_Current_Status = new L1_Current_Status_82DECBF6(this, "L1_Current_Status", "L1_Current_Status");
			_L1_Current_Status.AttributeName = "L1_Current_Status";
			_L1_Current_Samples = new L1_Current_Samples_9EC08B3E(this, "L1_Current_Samples", "L1_Current_Samples");
			_L1_Current_Samples.AttributeName = "L1_Current_Samples";
			_L2_Voltage_Status = new L2_Voltage_Status_0D1813FE(this, "L2_Voltage_Status", "L2_Voltage_Status");
			_L2_Voltage_Status.AttributeName = "L2_Voltage_Status";
			_L2_Voltage_Samples = new L2_Voltage_Samples_75D833AF(this, "L2_Voltage_Samples", "L2_Voltage_Samples");
			_L2_Voltage_Samples.AttributeName = "L2_Voltage_Samples";
			_L2_Current_Status = new L2_Current_Status_FCB7684B(this, "L2_Current_Status", "L2_Current_Status");
			_L2_Current_Status.AttributeName = "L2_Current_Status";
			_L2_Current_Samples = new L2_Current_Samples_AAB60F6E(this, "L2_Current_Samples", "L2_Current_Samples");
			_L2_Current_Samples.AttributeName = "L2_Current_Samples";
			_L3_Voltage_Status = new L3_Voltage_Status_273F7295(this, "L3_Voltage_Status", "L3_Voltage_Status");
			_L3_Voltage_Status.AttributeName = "L3_Voltage_Status";
			_L3_Voltage_Samples = new L3_Voltage_Samples_660A4F9F(this, "L3_Voltage_Samples", "L3_Voltage_Samples");
			_L3_Voltage_Samples.AttributeName = "L3_Voltage_Samples";
			_L3_Current_Status = new L3_Current_Status_D6900920(this, "L3_Current_Status", "L3_Current_Status");
			_L3_Current_Status.AttributeName = "L3_Current_Status";
			_L3_Current_Samples = new L3_Current_Samples_B964735E(this, "L3_Current_Samples", "L3_Current_Samples");
			_L3_Current_Samples.AttributeName = "L3_Current_Samples";
			_AI_NextSync1Time = new AI_NextSync1Time_6DC4D296(this, "AI_NextSync1Time", "AI_NextSync1Time");
			_AI_NextSync1Time.AttributeName = "AI_NextSync1Time";
			_AI_Sample_Count = new AI_Sample_Count_EA88CAD9(this, "AI_Sample_Count", "AI_Sample_Count");
			_AI_Sample_Count.AttributeName = "AI_Sample_Count";
			_WcState = new TcoIo.WcState_9091E0EB(this, "WcState", "WcState");
			_WcState.AttributeName = "WcState";
			_InfoData = new InfoData_B84DBEC5(this, "InfoData", "InfoData");
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeDescription = "EL3773 3 Ch. Power Monitoring, Oversample";
			AttributePhysics = "KK";
			AttributeId = "L1_Voltage_StatusAT %I*L1_Voltage_Status_7371B0437L1_Voltage_SamplesAT %I*L1_Voltage_Samples_41AEB7FF20L1_Current_StatusAT %I*L1_Current_Status_82DECBF67L1_Current_SamplesAT %I*L1_Current_Samples_9EC08B3E20L2_Voltage_StatusAT %I*L2_Voltage_Status_0D1813FE7L2_Voltage_SamplesAT %I*L2_Voltage_Samples_75D833AF20L2_Current_StatusAT %I*L2_Current_Status_FCB7684B7L2_Current_SamplesAT %I*L2_Current_Samples_AAB60F6E20L3_Voltage_StatusAT %I*L3_Voltage_Status_273F72957L3_Voltage_SamplesAT %I*L3_Voltage_Samples_660A4F9F20L3_Current_StatusAT %I*L3_Current_Status_D69009207L3_Current_SamplesAT %I*L3_Current_Samples_B964735E20AI_NextSync1TimeAT %I*AI_NextSync1Time_6DC4D2968AI_Sample_CountAT %I*AI_Sample_Count_EA88CAD92WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_B84DBEC510";
			AttributeCRC = "4045982850";
			AttributeSize = "184";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public EL3773_F128CC82(): base ()
		{
			PexPreConstructorParameterless();
			_L1_Voltage_Status = new L1_Voltage_Status_7371B043();
			_L1_Voltage_Status.AttributeName = "L1_Voltage_Status";
			_L1_Voltage_Samples = new L1_Voltage_Samples_41AEB7FF();
			_L1_Voltage_Samples.AttributeName = "L1_Voltage_Samples";
			_L1_Current_Status = new L1_Current_Status_82DECBF6();
			_L1_Current_Status.AttributeName = "L1_Current_Status";
			_L1_Current_Samples = new L1_Current_Samples_9EC08B3E();
			_L1_Current_Samples.AttributeName = "L1_Current_Samples";
			_L2_Voltage_Status = new L2_Voltage_Status_0D1813FE();
			_L2_Voltage_Status.AttributeName = "L2_Voltage_Status";
			_L2_Voltage_Samples = new L2_Voltage_Samples_75D833AF();
			_L2_Voltage_Samples.AttributeName = "L2_Voltage_Samples";
			_L2_Current_Status = new L2_Current_Status_FCB7684B();
			_L2_Current_Status.AttributeName = "L2_Current_Status";
			_L2_Current_Samples = new L2_Current_Samples_AAB60F6E();
			_L2_Current_Samples.AttributeName = "L2_Current_Samples";
			_L3_Voltage_Status = new L3_Voltage_Status_273F7295();
			_L3_Voltage_Status.AttributeName = "L3_Voltage_Status";
			_L3_Voltage_Samples = new L3_Voltage_Samples_660A4F9F();
			_L3_Voltage_Samples.AttributeName = "L3_Voltage_Samples";
			_L3_Current_Status = new L3_Current_Status_D6900920();
			_L3_Current_Status.AttributeName = "L3_Current_Status";
			_L3_Current_Samples = new L3_Current_Samples_B964735E();
			_L3_Current_Samples.AttributeName = "L3_Current_Samples";
			_AI_NextSync1Time = new AI_NextSync1Time_6DC4D296();
			_AI_NextSync1Time.AttributeName = "AI_NextSync1Time";
			_AI_Sample_Count = new AI_Sample_Count_EA88CAD9();
			_AI_Sample_Count.AttributeName = "AI_Sample_Count";
			_WcState = new TcoIo.WcState_9091E0EB();
			_WcState.AttributeName = "WcState";
			_InfoData = new InfoData_B84DBEC5();
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeDescription = "EL3773 3 Ch. Power Monitoring, Oversample";
			AttributePhysics = "KK";
			AttributeId = "L1_Voltage_StatusAT %I*L1_Voltage_Status_7371B0437L1_Voltage_SamplesAT %I*L1_Voltage_Samples_41AEB7FF20L1_Current_StatusAT %I*L1_Current_Status_82DECBF67L1_Current_SamplesAT %I*L1_Current_Samples_9EC08B3E20L2_Voltage_StatusAT %I*L2_Voltage_Status_0D1813FE7L2_Voltage_SamplesAT %I*L2_Voltage_Samples_75D833AF20L2_Current_StatusAT %I*L2_Current_Status_FCB7684B7L2_Current_SamplesAT %I*L2_Current_Samples_AAB60F6E20L3_Voltage_StatusAT %I*L3_Voltage_Status_273F72957L3_Voltage_SamplesAT %I*L3_Voltage_Samples_660A4F9F20L3_Current_StatusAT %I*L3_Current_Status_D69009207L3_Current_SamplesAT %I*L3_Current_Samples_B964735E20AI_NextSync1TimeAT %I*AI_NextSync1Time_6DC4D2968AI_Sample_CountAT %I*AI_Sample_Count_EA88CAD92WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_B84DBEC510";
			AttributeCRC = "4045982850";
			AttributeSize = "184";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL3773_F128CC82
	{
		public void CopyPlainToCyclic(Plc1.EL3773_F128CC82 target)
		{
			base.CopyPlainToCyclic(target);
			L1_Voltage_Status.CopyPlainToCyclic(target.L1_Voltage_Status);
			L1_Voltage_Samples.CopyPlainToCyclic(target.L1_Voltage_Samples);
			L1_Current_Status.CopyPlainToCyclic(target.L1_Current_Status);
			L1_Current_Samples.CopyPlainToCyclic(target.L1_Current_Samples);
			L2_Voltage_Status.CopyPlainToCyclic(target.L2_Voltage_Status);
			L2_Voltage_Samples.CopyPlainToCyclic(target.L2_Voltage_Samples);
			L2_Current_Status.CopyPlainToCyclic(target.L2_Current_Status);
			L2_Current_Samples.CopyPlainToCyclic(target.L2_Current_Samples);
			L3_Voltage_Status.CopyPlainToCyclic(target.L3_Voltage_Status);
			L3_Voltage_Samples.CopyPlainToCyclic(target.L3_Voltage_Samples);
			L3_Current_Status.CopyPlainToCyclic(target.L3_Current_Status);
			L3_Current_Samples.CopyPlainToCyclic(target.L3_Current_Samples);
			AI_NextSync1Time.CopyPlainToCyclic(target.AI_NextSync1Time);
			AI_Sample_Count.CopyPlainToCyclic(target.AI_Sample_Count);
			WcState.CopyPlainToCyclic(target.WcState);
			InfoData.CopyPlainToCyclic(target.InfoData);
		}

		public void CopyPlainToCyclic(Plc1.IEL3773_F128CC82 target)
		{
			this.CopyPlainToCyclic((Plc1.EL3773_F128CC82)target);
		}

		public void CopyPlainToShadow(Plc1.EL3773_F128CC82 target)
		{
			base.CopyPlainToShadow(target);
			L1_Voltage_Status.CopyPlainToShadow(target.L1_Voltage_Status);
			L1_Voltage_Samples.CopyPlainToShadow(target.L1_Voltage_Samples);
			L1_Current_Status.CopyPlainToShadow(target.L1_Current_Status);
			L1_Current_Samples.CopyPlainToShadow(target.L1_Current_Samples);
			L2_Voltage_Status.CopyPlainToShadow(target.L2_Voltage_Status);
			L2_Voltage_Samples.CopyPlainToShadow(target.L2_Voltage_Samples);
			L2_Current_Status.CopyPlainToShadow(target.L2_Current_Status);
			L2_Current_Samples.CopyPlainToShadow(target.L2_Current_Samples);
			L3_Voltage_Status.CopyPlainToShadow(target.L3_Voltage_Status);
			L3_Voltage_Samples.CopyPlainToShadow(target.L3_Voltage_Samples);
			L3_Current_Status.CopyPlainToShadow(target.L3_Current_Status);
			L3_Current_Samples.CopyPlainToShadow(target.L3_Current_Samples);
			AI_NextSync1Time.CopyPlainToShadow(target.AI_NextSync1Time);
			AI_Sample_Count.CopyPlainToShadow(target.AI_Sample_Count);
			WcState.CopyPlainToShadow(target.WcState);
			InfoData.CopyPlainToShadow(target.InfoData);
		}

		public void CopyPlainToShadow(Plc1.IShadowEL3773_F128CC82 target)
		{
			this.CopyPlainToShadow((Plc1.EL3773_F128CC82)target);
		}

		public void CopyCyclicToPlain(Plc1.EL3773_F128CC82 source)
		{
			base.CopyCyclicToPlain(source);
			L1_Voltage_Status.CopyCyclicToPlain(source.L1_Voltage_Status);
			L1_Voltage_Samples.CopyCyclicToPlain(source.L1_Voltage_Samples);
			L1_Current_Status.CopyCyclicToPlain(source.L1_Current_Status);
			L1_Current_Samples.CopyCyclicToPlain(source.L1_Current_Samples);
			L2_Voltage_Status.CopyCyclicToPlain(source.L2_Voltage_Status);
			L2_Voltage_Samples.CopyCyclicToPlain(source.L2_Voltage_Samples);
			L2_Current_Status.CopyCyclicToPlain(source.L2_Current_Status);
			L2_Current_Samples.CopyCyclicToPlain(source.L2_Current_Samples);
			L3_Voltage_Status.CopyCyclicToPlain(source.L3_Voltage_Status);
			L3_Voltage_Samples.CopyCyclicToPlain(source.L3_Voltage_Samples);
			L3_Current_Status.CopyCyclicToPlain(source.L3_Current_Status);
			L3_Current_Samples.CopyCyclicToPlain(source.L3_Current_Samples);
			AI_NextSync1Time.CopyCyclicToPlain(source.AI_NextSync1Time);
			AI_Sample_Count.CopyCyclicToPlain(source.AI_Sample_Count);
			WcState.CopyCyclicToPlain(source.WcState);
			InfoData.CopyCyclicToPlain(source.InfoData);
		}

		public void CopyCyclicToPlain(Plc1.IEL3773_F128CC82 source)
		{
			this.CopyCyclicToPlain((Plc1.EL3773_F128CC82)source);
		}

		public void CopyShadowToPlain(Plc1.EL3773_F128CC82 source)
		{
			base.CopyShadowToPlain(source);
			L1_Voltage_Status.CopyShadowToPlain(source.L1_Voltage_Status);
			L1_Voltage_Samples.CopyShadowToPlain(source.L1_Voltage_Samples);
			L1_Current_Status.CopyShadowToPlain(source.L1_Current_Status);
			L1_Current_Samples.CopyShadowToPlain(source.L1_Current_Samples);
			L2_Voltage_Status.CopyShadowToPlain(source.L2_Voltage_Status);
			L2_Voltage_Samples.CopyShadowToPlain(source.L2_Voltage_Samples);
			L2_Current_Status.CopyShadowToPlain(source.L2_Current_Status);
			L2_Current_Samples.CopyShadowToPlain(source.L2_Current_Samples);
			L3_Voltage_Status.CopyShadowToPlain(source.L3_Voltage_Status);
			L3_Voltage_Samples.CopyShadowToPlain(source.L3_Voltage_Samples);
			L3_Current_Status.CopyShadowToPlain(source.L3_Current_Status);
			L3_Current_Samples.CopyShadowToPlain(source.L3_Current_Samples);
			AI_NextSync1Time.CopyShadowToPlain(source.AI_NextSync1Time);
			AI_Sample_Count.CopyShadowToPlain(source.AI_Sample_Count);
			WcState.CopyShadowToPlain(source.WcState);
			InfoData.CopyShadowToPlain(source.InfoData);
		}

		public void CopyShadowToPlain(Plc1.IShadowEL3773_F128CC82 source)
		{
			this.CopyShadowToPlain((Plc1.EL3773_F128CC82)source);
		}
	}
}