using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty VendorId \"#x00000002\" } {attribute addProperty BoxType \"EL1809-0000-0018\" } {attribute addProperty Description \"EL1809 16Ch. Dig. Input 24V, 3ms\" } {attribute addProperty Physics \"KK\" } {attribute addProperty Id \"Channel_1AT %I*Channel_830843C11Channel_2AT %I*Channel_830843C11Channel_3AT %I*Channel_830843C11Channel_4AT %I*Channel_830843C11Channel_5AT %I*Channel_830843C11Channel_6AT %I*Channel_830843C11Channel_7AT %I*Channel_830843C11Channel_8AT %I*Channel_830843C11Channel_9AT %I*Channel_830843C11Channel_10AT %I*Channel_830843C11Channel_11AT %I*Channel_830843C11Channel_12AT %I*Channel_830843C11Channel_13AT %I*Channel_830843C11Channel_14AT %I*Channel_830843C11Channel_15AT %I*Channel_830843C11Channel_16AT %I*Channel_830843C11WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_6F19DB2B2\" } {attribute addProperty CRC \"840269053\" } {attribute addProperty Size \"20\" } {attribute addProperty Name \"\" }", "EL1809_32157CFD", "Plc1", TypeComplexityEnum.Complex)]
	public partial class EL1809_32157CFD : TcoIo.EtcSlaveTerminalBase_947E5A46, Vortex.Connector.IVortexObject, IEL1809_32157CFD, IShadowEL1809_32157CFD, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Channel_830843C1 _Channel_1;
		public Channel_830843C1 Channel_1
		{
			get
			{
				return _Channel_1;
			}
		}

		IChannel_830843C1 IEL1809_32157CFD.Channel_1
		{
			get
			{
				return Channel_1;
			}
		}

		IShadowChannel_830843C1 IShadowEL1809_32157CFD.Channel_1
		{
			get
			{
				return Channel_1;
			}
		}

		Channel_830843C1 _Channel_2;
		public Channel_830843C1 Channel_2
		{
			get
			{
				return _Channel_2;
			}
		}

		IChannel_830843C1 IEL1809_32157CFD.Channel_2
		{
			get
			{
				return Channel_2;
			}
		}

		IShadowChannel_830843C1 IShadowEL1809_32157CFD.Channel_2
		{
			get
			{
				return Channel_2;
			}
		}

		Channel_830843C1 _Channel_3;
		public Channel_830843C1 Channel_3
		{
			get
			{
				return _Channel_3;
			}
		}

		IChannel_830843C1 IEL1809_32157CFD.Channel_3
		{
			get
			{
				return Channel_3;
			}
		}

		IShadowChannel_830843C1 IShadowEL1809_32157CFD.Channel_3
		{
			get
			{
				return Channel_3;
			}
		}

		Channel_830843C1 _Channel_4;
		public Channel_830843C1 Channel_4
		{
			get
			{
				return _Channel_4;
			}
		}

		IChannel_830843C1 IEL1809_32157CFD.Channel_4
		{
			get
			{
				return Channel_4;
			}
		}

		IShadowChannel_830843C1 IShadowEL1809_32157CFD.Channel_4
		{
			get
			{
				return Channel_4;
			}
		}

		Channel_830843C1 _Channel_5;
		public Channel_830843C1 Channel_5
		{
			get
			{
				return _Channel_5;
			}
		}

		IChannel_830843C1 IEL1809_32157CFD.Channel_5
		{
			get
			{
				return Channel_5;
			}
		}

		IShadowChannel_830843C1 IShadowEL1809_32157CFD.Channel_5
		{
			get
			{
				return Channel_5;
			}
		}

		Channel_830843C1 _Channel_6;
		public Channel_830843C1 Channel_6
		{
			get
			{
				return _Channel_6;
			}
		}

		IChannel_830843C1 IEL1809_32157CFD.Channel_6
		{
			get
			{
				return Channel_6;
			}
		}

		IShadowChannel_830843C1 IShadowEL1809_32157CFD.Channel_6
		{
			get
			{
				return Channel_6;
			}
		}

		Channel_830843C1 _Channel_7;
		public Channel_830843C1 Channel_7
		{
			get
			{
				return _Channel_7;
			}
		}

		IChannel_830843C1 IEL1809_32157CFD.Channel_7
		{
			get
			{
				return Channel_7;
			}
		}

		IShadowChannel_830843C1 IShadowEL1809_32157CFD.Channel_7
		{
			get
			{
				return Channel_7;
			}
		}

		Channel_830843C1 _Channel_8;
		public Channel_830843C1 Channel_8
		{
			get
			{
				return _Channel_8;
			}
		}

		IChannel_830843C1 IEL1809_32157CFD.Channel_8
		{
			get
			{
				return Channel_8;
			}
		}

		IShadowChannel_830843C1 IShadowEL1809_32157CFD.Channel_8
		{
			get
			{
				return Channel_8;
			}
		}

		Channel_830843C1 _Channel_9;
		public Channel_830843C1 Channel_9
		{
			get
			{
				return _Channel_9;
			}
		}

		IChannel_830843C1 IEL1809_32157CFD.Channel_9
		{
			get
			{
				return Channel_9;
			}
		}

		IShadowChannel_830843C1 IShadowEL1809_32157CFD.Channel_9
		{
			get
			{
				return Channel_9;
			}
		}

		Channel_830843C1 _Channel_10;
		public Channel_830843C1 Channel_10
		{
			get
			{
				return _Channel_10;
			}
		}

		IChannel_830843C1 IEL1809_32157CFD.Channel_10
		{
			get
			{
				return Channel_10;
			}
		}

		IShadowChannel_830843C1 IShadowEL1809_32157CFD.Channel_10
		{
			get
			{
				return Channel_10;
			}
		}

		Channel_830843C1 _Channel_11;
		public Channel_830843C1 Channel_11
		{
			get
			{
				return _Channel_11;
			}
		}

		IChannel_830843C1 IEL1809_32157CFD.Channel_11
		{
			get
			{
				return Channel_11;
			}
		}

		IShadowChannel_830843C1 IShadowEL1809_32157CFD.Channel_11
		{
			get
			{
				return Channel_11;
			}
		}

		Channel_830843C1 _Channel_12;
		public Channel_830843C1 Channel_12
		{
			get
			{
				return _Channel_12;
			}
		}

		IChannel_830843C1 IEL1809_32157CFD.Channel_12
		{
			get
			{
				return Channel_12;
			}
		}

		IShadowChannel_830843C1 IShadowEL1809_32157CFD.Channel_12
		{
			get
			{
				return Channel_12;
			}
		}

		Channel_830843C1 _Channel_13;
		public Channel_830843C1 Channel_13
		{
			get
			{
				return _Channel_13;
			}
		}

		IChannel_830843C1 IEL1809_32157CFD.Channel_13
		{
			get
			{
				return Channel_13;
			}
		}

		IShadowChannel_830843C1 IShadowEL1809_32157CFD.Channel_13
		{
			get
			{
				return Channel_13;
			}
		}

		Channel_830843C1 _Channel_14;
		public Channel_830843C1 Channel_14
		{
			get
			{
				return _Channel_14;
			}
		}

		IChannel_830843C1 IEL1809_32157CFD.Channel_14
		{
			get
			{
				return Channel_14;
			}
		}

		IShadowChannel_830843C1 IShadowEL1809_32157CFD.Channel_14
		{
			get
			{
				return Channel_14;
			}
		}

		Channel_830843C1 _Channel_15;
		public Channel_830843C1 Channel_15
		{
			get
			{
				return _Channel_15;
			}
		}

		IChannel_830843C1 IEL1809_32157CFD.Channel_15
		{
			get
			{
				return Channel_15;
			}
		}

		IShadowChannel_830843C1 IShadowEL1809_32157CFD.Channel_15
		{
			get
			{
				return Channel_15;
			}
		}

		Channel_830843C1 _Channel_16;
		public Channel_830843C1 Channel_16
		{
			get
			{
				return _Channel_16;
			}
		}

		IChannel_830843C1 IEL1809_32157CFD.Channel_16
		{
			get
			{
				return Channel_16;
			}
		}

		IShadowChannel_830843C1 IShadowEL1809_32157CFD.Channel_16
		{
			get
			{
				return Channel_16;
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

		TcoIo.IWcState_9091E0EB IEL1809_32157CFD.WcState
		{
			get
			{
				return WcState;
			}
		}

		TcoIo.IShadowWcState_9091E0EB IShadowEL1809_32157CFD.WcState
		{
			get
			{
				return WcState;
			}
		}

		TcoIo.InfoData_6F19DB2B _InfoData;
		public TcoIo.InfoData_6F19DB2B InfoData
		{
			get
			{
				return _InfoData;
			}
		}

		TcoIo.IInfoData_6F19DB2B IEL1809_32157CFD.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		TcoIo.IShadowInfoData_6F19DB2B IShadowEL1809_32157CFD.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Channel_1.LazyOnlineToShadow();
			Channel_2.LazyOnlineToShadow();
			Channel_3.LazyOnlineToShadow();
			Channel_4.LazyOnlineToShadow();
			Channel_5.LazyOnlineToShadow();
			Channel_6.LazyOnlineToShadow();
			Channel_7.LazyOnlineToShadow();
			Channel_8.LazyOnlineToShadow();
			Channel_9.LazyOnlineToShadow();
			Channel_10.LazyOnlineToShadow();
			Channel_11.LazyOnlineToShadow();
			Channel_12.LazyOnlineToShadow();
			Channel_13.LazyOnlineToShadow();
			Channel_14.LazyOnlineToShadow();
			Channel_15.LazyOnlineToShadow();
			Channel_16.LazyOnlineToShadow();
			WcState.LazyOnlineToShadow();
			InfoData.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Channel_1.LazyShadowToOnline();
			Channel_2.LazyShadowToOnline();
			Channel_3.LazyShadowToOnline();
			Channel_4.LazyShadowToOnline();
			Channel_5.LazyShadowToOnline();
			Channel_6.LazyShadowToOnline();
			Channel_7.LazyShadowToOnline();
			Channel_8.LazyShadowToOnline();
			Channel_9.LazyShadowToOnline();
			Channel_10.LazyShadowToOnline();
			Channel_11.LazyShadowToOnline();
			Channel_12.LazyShadowToOnline();
			Channel_13.LazyShadowToOnline();
			Channel_14.LazyShadowToOnline();
			Channel_15.LazyShadowToOnline();
			Channel_16.LazyShadowToOnline();
			WcState.LazyShadowToOnline();
			InfoData.LazyShadowToOnline();
		}

		public new PlainEL1809_32157CFD CreatePlainerType()
		{
			var cloned = new PlainEL1809_32157CFD();
			base.CreatePlainerType(cloned);
			cloned.Channel_1 = Channel_1.CreatePlainerType();
			cloned.Channel_2 = Channel_2.CreatePlainerType();
			cloned.Channel_3 = Channel_3.CreatePlainerType();
			cloned.Channel_4 = Channel_4.CreatePlainerType();
			cloned.Channel_5 = Channel_5.CreatePlainerType();
			cloned.Channel_6 = Channel_6.CreatePlainerType();
			cloned.Channel_7 = Channel_7.CreatePlainerType();
			cloned.Channel_8 = Channel_8.CreatePlainerType();
			cloned.Channel_9 = Channel_9.CreatePlainerType();
			cloned.Channel_10 = Channel_10.CreatePlainerType();
			cloned.Channel_11 = Channel_11.CreatePlainerType();
			cloned.Channel_12 = Channel_12.CreatePlainerType();
			cloned.Channel_13 = Channel_13.CreatePlainerType();
			cloned.Channel_14 = Channel_14.CreatePlainerType();
			cloned.Channel_15 = Channel_15.CreatePlainerType();
			cloned.Channel_16 = Channel_16.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		protected PlainEL1809_32157CFD CreatePlainerType(PlainEL1809_32157CFD cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Channel_1 = Channel_1.CreatePlainerType();
			cloned.Channel_2 = Channel_2.CreatePlainerType();
			cloned.Channel_3 = Channel_3.CreatePlainerType();
			cloned.Channel_4 = Channel_4.CreatePlainerType();
			cloned.Channel_5 = Channel_5.CreatePlainerType();
			cloned.Channel_6 = Channel_6.CreatePlainerType();
			cloned.Channel_7 = Channel_7.CreatePlainerType();
			cloned.Channel_8 = Channel_8.CreatePlainerType();
			cloned.Channel_9 = Channel_9.CreatePlainerType();
			cloned.Channel_10 = Channel_10.CreatePlainerType();
			cloned.Channel_11 = Channel_11.CreatePlainerType();
			cloned.Channel_12 = Channel_12.CreatePlainerType();
			cloned.Channel_13 = Channel_13.CreatePlainerType();
			cloned.Channel_14 = Channel_14.CreatePlainerType();
			cloned.Channel_15 = Channel_15.CreatePlainerType();
			cloned.Channel_16 = Channel_16.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainEL1809_32157CFD source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainEL1809_32157CFD source)
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

		public void FlushOnlineToPlain(Plc1.PlainEL1809_32157CFD source)
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

		public EL1809_32157CFD(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Channel_1 = new Channel_830843C1(this, "Channel_1", "Channel_1");
			_Channel_1.AttributeName = "Channel_1";
			_Channel_2 = new Channel_830843C1(this, "Channel_2", "Channel_2");
			_Channel_2.AttributeName = "Channel_2";
			_Channel_3 = new Channel_830843C1(this, "Channel_3", "Channel_3");
			_Channel_3.AttributeName = "Channel_3";
			_Channel_4 = new Channel_830843C1(this, "Channel_4", "Channel_4");
			_Channel_4.AttributeName = "Channel_4";
			_Channel_5 = new Channel_830843C1(this, "Channel_5", "Channel_5");
			_Channel_5.AttributeName = "Channel_5";
			_Channel_6 = new Channel_830843C1(this, "Channel_6", "Channel_6");
			_Channel_6.AttributeName = "Channel_6";
			_Channel_7 = new Channel_830843C1(this, "Channel_7", "Channel_7");
			_Channel_7.AttributeName = "Channel_7";
			_Channel_8 = new Channel_830843C1(this, "Channel_8", "Channel_8");
			_Channel_8.AttributeName = "Channel_8";
			_Channel_9 = new Channel_830843C1(this, "Channel_9", "Channel_9");
			_Channel_9.AttributeName = "Channel_9";
			_Channel_10 = new Channel_830843C1(this, "Channel_10", "Channel_10");
			_Channel_10.AttributeName = "Channel_10";
			_Channel_11 = new Channel_830843C1(this, "Channel_11", "Channel_11");
			_Channel_11.AttributeName = "Channel_11";
			_Channel_12 = new Channel_830843C1(this, "Channel_12", "Channel_12");
			_Channel_12.AttributeName = "Channel_12";
			_Channel_13 = new Channel_830843C1(this, "Channel_13", "Channel_13");
			_Channel_13.AttributeName = "Channel_13";
			_Channel_14 = new Channel_830843C1(this, "Channel_14", "Channel_14");
			_Channel_14.AttributeName = "Channel_14";
			_Channel_15 = new Channel_830843C1(this, "Channel_15", "Channel_15");
			_Channel_15.AttributeName = "Channel_15";
			_Channel_16 = new Channel_830843C1(this, "Channel_16", "Channel_16");
			_Channel_16.AttributeName = "Channel_16";
			_WcState = new TcoIo.WcState_9091E0EB(this, "WcState", "WcState");
			_WcState.AttributeName = "WcState";
			_InfoData = new TcoIo.InfoData_6F19DB2B(this, "InfoData", "InfoData");
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL1809-0000-0018";
			AttributeDescription = "EL1809 16Ch. Dig. Input 24V, 3ms";
			AttributePhysics = "KK";
			AttributeId = "Channel_1AT %I*Channel_830843C11Channel_2AT %I*Channel_830843C11Channel_3AT %I*Channel_830843C11Channel_4AT %I*Channel_830843C11Channel_5AT %I*Channel_830843C11Channel_6AT %I*Channel_830843C11Channel_7AT %I*Channel_830843C11Channel_8AT %I*Channel_830843C11Channel_9AT %I*Channel_830843C11Channel_10AT %I*Channel_830843C11Channel_11AT %I*Channel_830843C11Channel_12AT %I*Channel_830843C11Channel_13AT %I*Channel_830843C11Channel_14AT %I*Channel_830843C11Channel_15AT %I*Channel_830843C11Channel_16AT %I*Channel_830843C11WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_6F19DB2B2";
			AttributeCRC = "840269053";
			AttributeSize = "20";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public EL1809_32157CFD(): base ()
		{
			PexPreConstructorParameterless();
			_Channel_1 = new Channel_830843C1();
			_Channel_1.AttributeName = "Channel_1";
			_Channel_2 = new Channel_830843C1();
			_Channel_2.AttributeName = "Channel_2";
			_Channel_3 = new Channel_830843C1();
			_Channel_3.AttributeName = "Channel_3";
			_Channel_4 = new Channel_830843C1();
			_Channel_4.AttributeName = "Channel_4";
			_Channel_5 = new Channel_830843C1();
			_Channel_5.AttributeName = "Channel_5";
			_Channel_6 = new Channel_830843C1();
			_Channel_6.AttributeName = "Channel_6";
			_Channel_7 = new Channel_830843C1();
			_Channel_7.AttributeName = "Channel_7";
			_Channel_8 = new Channel_830843C1();
			_Channel_8.AttributeName = "Channel_8";
			_Channel_9 = new Channel_830843C1();
			_Channel_9.AttributeName = "Channel_9";
			_Channel_10 = new Channel_830843C1();
			_Channel_10.AttributeName = "Channel_10";
			_Channel_11 = new Channel_830843C1();
			_Channel_11.AttributeName = "Channel_11";
			_Channel_12 = new Channel_830843C1();
			_Channel_12.AttributeName = "Channel_12";
			_Channel_13 = new Channel_830843C1();
			_Channel_13.AttributeName = "Channel_13";
			_Channel_14 = new Channel_830843C1();
			_Channel_14.AttributeName = "Channel_14";
			_Channel_15 = new Channel_830843C1();
			_Channel_15.AttributeName = "Channel_15";
			_Channel_16 = new Channel_830843C1();
			_Channel_16.AttributeName = "Channel_16";
			_WcState = new TcoIo.WcState_9091E0EB();
			_WcState.AttributeName = "WcState";
			_InfoData = new TcoIo.InfoData_6F19DB2B();
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL1809-0000-0018";
			AttributeDescription = "EL1809 16Ch. Dig. Input 24V, 3ms";
			AttributePhysics = "KK";
			AttributeId = "Channel_1AT %I*Channel_830843C11Channel_2AT %I*Channel_830843C11Channel_3AT %I*Channel_830843C11Channel_4AT %I*Channel_830843C11Channel_5AT %I*Channel_830843C11Channel_6AT %I*Channel_830843C11Channel_7AT %I*Channel_830843C11Channel_8AT %I*Channel_830843C11Channel_9AT %I*Channel_830843C11Channel_10AT %I*Channel_830843C11Channel_11AT %I*Channel_830843C11Channel_12AT %I*Channel_830843C11Channel_13AT %I*Channel_830843C11Channel_14AT %I*Channel_830843C11Channel_15AT %I*Channel_830843C11Channel_16AT %I*Channel_830843C11WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_6F19DB2B2";
			AttributeCRC = "840269053";
			AttributeSize = "20";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL1809_32157CFD
	{
		public void CopyPlainToCyclic(Plc1.EL1809_32157CFD target)
		{
			base.CopyPlainToCyclic(target);
			Channel_1.CopyPlainToCyclic(target.Channel_1);
			Channel_2.CopyPlainToCyclic(target.Channel_2);
			Channel_3.CopyPlainToCyclic(target.Channel_3);
			Channel_4.CopyPlainToCyclic(target.Channel_4);
			Channel_5.CopyPlainToCyclic(target.Channel_5);
			Channel_6.CopyPlainToCyclic(target.Channel_6);
			Channel_7.CopyPlainToCyclic(target.Channel_7);
			Channel_8.CopyPlainToCyclic(target.Channel_8);
			Channel_9.CopyPlainToCyclic(target.Channel_9);
			Channel_10.CopyPlainToCyclic(target.Channel_10);
			Channel_11.CopyPlainToCyclic(target.Channel_11);
			Channel_12.CopyPlainToCyclic(target.Channel_12);
			Channel_13.CopyPlainToCyclic(target.Channel_13);
			Channel_14.CopyPlainToCyclic(target.Channel_14);
			Channel_15.CopyPlainToCyclic(target.Channel_15);
			Channel_16.CopyPlainToCyclic(target.Channel_16);
			WcState.CopyPlainToCyclic(target.WcState);
			InfoData.CopyPlainToCyclic(target.InfoData);
		}

		public void CopyPlainToCyclic(Plc1.IEL1809_32157CFD target)
		{
			this.CopyPlainToCyclic((Plc1.EL1809_32157CFD)target);
		}

		public void CopyPlainToShadow(Plc1.EL1809_32157CFD target)
		{
			base.CopyPlainToShadow(target);
			Channel_1.CopyPlainToShadow(target.Channel_1);
			Channel_2.CopyPlainToShadow(target.Channel_2);
			Channel_3.CopyPlainToShadow(target.Channel_3);
			Channel_4.CopyPlainToShadow(target.Channel_4);
			Channel_5.CopyPlainToShadow(target.Channel_5);
			Channel_6.CopyPlainToShadow(target.Channel_6);
			Channel_7.CopyPlainToShadow(target.Channel_7);
			Channel_8.CopyPlainToShadow(target.Channel_8);
			Channel_9.CopyPlainToShadow(target.Channel_9);
			Channel_10.CopyPlainToShadow(target.Channel_10);
			Channel_11.CopyPlainToShadow(target.Channel_11);
			Channel_12.CopyPlainToShadow(target.Channel_12);
			Channel_13.CopyPlainToShadow(target.Channel_13);
			Channel_14.CopyPlainToShadow(target.Channel_14);
			Channel_15.CopyPlainToShadow(target.Channel_15);
			Channel_16.CopyPlainToShadow(target.Channel_16);
			WcState.CopyPlainToShadow(target.WcState);
			InfoData.CopyPlainToShadow(target.InfoData);
		}

		public void CopyPlainToShadow(Plc1.IShadowEL1809_32157CFD target)
		{
			this.CopyPlainToShadow((Plc1.EL1809_32157CFD)target);
		}

		public void CopyCyclicToPlain(Plc1.EL1809_32157CFD source)
		{
			base.CopyCyclicToPlain(source);
			Channel_1.CopyCyclicToPlain(source.Channel_1);
			Channel_2.CopyCyclicToPlain(source.Channel_2);
			Channel_3.CopyCyclicToPlain(source.Channel_3);
			Channel_4.CopyCyclicToPlain(source.Channel_4);
			Channel_5.CopyCyclicToPlain(source.Channel_5);
			Channel_6.CopyCyclicToPlain(source.Channel_6);
			Channel_7.CopyCyclicToPlain(source.Channel_7);
			Channel_8.CopyCyclicToPlain(source.Channel_8);
			Channel_9.CopyCyclicToPlain(source.Channel_9);
			Channel_10.CopyCyclicToPlain(source.Channel_10);
			Channel_11.CopyCyclicToPlain(source.Channel_11);
			Channel_12.CopyCyclicToPlain(source.Channel_12);
			Channel_13.CopyCyclicToPlain(source.Channel_13);
			Channel_14.CopyCyclicToPlain(source.Channel_14);
			Channel_15.CopyCyclicToPlain(source.Channel_15);
			Channel_16.CopyCyclicToPlain(source.Channel_16);
			WcState.CopyCyclicToPlain(source.WcState);
			InfoData.CopyCyclicToPlain(source.InfoData);
		}

		public void CopyCyclicToPlain(Plc1.IEL1809_32157CFD source)
		{
			this.CopyCyclicToPlain((Plc1.EL1809_32157CFD)source);
		}

		public void CopyShadowToPlain(Plc1.EL1809_32157CFD source)
		{
			base.CopyShadowToPlain(source);
			Channel_1.CopyShadowToPlain(source.Channel_1);
			Channel_2.CopyShadowToPlain(source.Channel_2);
			Channel_3.CopyShadowToPlain(source.Channel_3);
			Channel_4.CopyShadowToPlain(source.Channel_4);
			Channel_5.CopyShadowToPlain(source.Channel_5);
			Channel_6.CopyShadowToPlain(source.Channel_6);
			Channel_7.CopyShadowToPlain(source.Channel_7);
			Channel_8.CopyShadowToPlain(source.Channel_8);
			Channel_9.CopyShadowToPlain(source.Channel_9);
			Channel_10.CopyShadowToPlain(source.Channel_10);
			Channel_11.CopyShadowToPlain(source.Channel_11);
			Channel_12.CopyShadowToPlain(source.Channel_12);
			Channel_13.CopyShadowToPlain(source.Channel_13);
			Channel_14.CopyShadowToPlain(source.Channel_14);
			Channel_15.CopyShadowToPlain(source.Channel_15);
			Channel_16.CopyShadowToPlain(source.Channel_16);
			WcState.CopyShadowToPlain(source.WcState);
			InfoData.CopyShadowToPlain(source.InfoData);
		}

		public void CopyShadowToPlain(Plc1.IShadowEL1809_32157CFD source)
		{
			this.CopyShadowToPlain((Plc1.EL1809_32157CFD)source);
		}
	}
}