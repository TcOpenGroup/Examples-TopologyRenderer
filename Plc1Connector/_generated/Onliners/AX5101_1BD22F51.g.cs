using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty VendorId \"#x00000002\" } {attribute addProperty BoxType \"AX5101-0000-0214-0214\" } {attribute addProperty Description \"AX5101-0000-0214 EtherCAT Drive (SoE, 1 Ch.)\" } {attribute addProperty Physics \"YY_K\" } {attribute addProperty Id \"AT_xAT %I*AT_x_4EC2E76810MDTAT %Q*MDT_864618EC6WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_F60A43AC11\" } {attribute addProperty CRC \"466759505\" } {attribute addProperty Size \"29\" } {attribute addProperty Name \"\" }", "AX5101_1BD22F51", "Plc1", TypeComplexityEnum.Complex)]
	public partial class AX5101_1BD22F51 : TcoIo.EtcSlaveBoxBase_77A0E4A7, Vortex.Connector.IVortexObject, IAX5101_1BD22F51, IShadowAX5101_1BD22F51, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		AT_x_4EC2E768 _AT_x;
		public AT_x_4EC2E768 AT_x
		{
			get
			{
				return _AT_x;
			}
		}

		IAT_x_4EC2E768 IAX5101_1BD22F51.AT_x
		{
			get
			{
				return AT_x;
			}
		}

		IShadowAT_x_4EC2E768 IShadowAX5101_1BD22F51.AT_x
		{
			get
			{
				return AT_x;
			}
		}

		MDT_864618EC _MDT;
		public MDT_864618EC MDT
		{
			get
			{
				return _MDT;
			}
		}

		IMDT_864618EC IAX5101_1BD22F51.MDT
		{
			get
			{
				return MDT;
			}
		}

		IShadowMDT_864618EC IShadowAX5101_1BD22F51.MDT
		{
			get
			{
				return MDT;
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

		TcoIo.IWcState_9091E0EB IAX5101_1BD22F51.WcState
		{
			get
			{
				return WcState;
			}
		}

		TcoIo.IShadowWcState_9091E0EB IShadowAX5101_1BD22F51.WcState
		{
			get
			{
				return WcState;
			}
		}

		InfoData_F60A43AC _InfoData;
		public InfoData_F60A43AC InfoData
		{
			get
			{
				return _InfoData;
			}
		}

		IInfoData_F60A43AC IAX5101_1BD22F51.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		IShadowInfoData_F60A43AC IShadowAX5101_1BD22F51.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			AT_x.LazyOnlineToShadow();
			MDT.LazyOnlineToShadow();
			WcState.LazyOnlineToShadow();
			InfoData.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			AT_x.LazyShadowToOnline();
			MDT.LazyShadowToOnline();
			WcState.LazyShadowToOnline();
			InfoData.LazyShadowToOnline();
		}

		public new PlainAX5101_1BD22F51 CreatePlainerType()
		{
			var cloned = new PlainAX5101_1BD22F51();
			base.CreatePlainerType(cloned);
			cloned.AT_x = AT_x.CreatePlainerType();
			cloned.MDT = MDT.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		protected PlainAX5101_1BD22F51 CreatePlainerType(PlainAX5101_1BD22F51 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.AT_x = AT_x.CreatePlainerType();
			cloned.MDT = MDT.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainAX5101_1BD22F51 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainAX5101_1BD22F51 source)
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

		public void FlushOnlineToPlain(Plc1.PlainAX5101_1BD22F51 source)
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

		public AX5101_1BD22F51(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_AT_x = new AT_x_4EC2E768(this, "AT_x", "AT_x");
			_AT_x.AttributeName = "AT_x";
			_MDT = new MDT_864618EC(this, "MDT", "MDT");
			_MDT.AttributeName = "MDT";
			_WcState = new TcoIo.WcState_9091E0EB(this, "WcState", "WcState");
			_WcState.AttributeName = "WcState";
			_InfoData = new InfoData_F60A43AC(this, "InfoData", "InfoData");
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "AX5101-0000-0214-0214";
			AttributeDescription = "AX5101-0000-0214 EtherCAT Drive (SoE, 1 Ch.)";
			AttributePhysics = "YY_K";
			AttributeId = "AT_xAT %I*AT_x_4EC2E76810MDTAT %Q*MDT_864618EC6WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_F60A43AC11";
			AttributeCRC = "466759505";
			AttributeSize = "29";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public AX5101_1BD22F51(): base ()
		{
			PexPreConstructorParameterless();
			_AT_x = new AT_x_4EC2E768();
			_AT_x.AttributeName = "AT_x";
			_MDT = new MDT_864618EC();
			_MDT.AttributeName = "MDT";
			_WcState = new TcoIo.WcState_9091E0EB();
			_WcState.AttributeName = "WcState";
			_InfoData = new InfoData_F60A43AC();
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "AX5101-0000-0214-0214";
			AttributeDescription = "AX5101-0000-0214 EtherCAT Drive (SoE, 1 Ch.)";
			AttributePhysics = "YY_K";
			AttributeId = "AT_xAT %I*AT_x_4EC2E76810MDTAT %Q*MDT_864618EC6WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_F60A43AC11";
			AttributeCRC = "466759505";
			AttributeSize = "29";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainAX5101_1BD22F51
	{
		public void CopyPlainToCyclic(Plc1.AX5101_1BD22F51 target)
		{
			base.CopyPlainToCyclic(target);
			AT_x.CopyPlainToCyclic(target.AT_x);
			MDT.CopyPlainToCyclic(target.MDT);
			WcState.CopyPlainToCyclic(target.WcState);
			InfoData.CopyPlainToCyclic(target.InfoData);
		}

		public void CopyPlainToCyclic(Plc1.IAX5101_1BD22F51 target)
		{
			this.CopyPlainToCyclic((Plc1.AX5101_1BD22F51)target);
		}

		public void CopyPlainToShadow(Plc1.AX5101_1BD22F51 target)
		{
			base.CopyPlainToShadow(target);
			AT_x.CopyPlainToShadow(target.AT_x);
			MDT.CopyPlainToShadow(target.MDT);
			WcState.CopyPlainToShadow(target.WcState);
			InfoData.CopyPlainToShadow(target.InfoData);
		}

		public void CopyPlainToShadow(Plc1.IShadowAX5101_1BD22F51 target)
		{
			this.CopyPlainToShadow((Plc1.AX5101_1BD22F51)target);
		}

		public void CopyCyclicToPlain(Plc1.AX5101_1BD22F51 source)
		{
			base.CopyCyclicToPlain(source);
			AT_x.CopyCyclicToPlain(source.AT_x);
			MDT.CopyCyclicToPlain(source.MDT);
			WcState.CopyCyclicToPlain(source.WcState);
			InfoData.CopyCyclicToPlain(source.InfoData);
		}

		public void CopyCyclicToPlain(Plc1.IAX5101_1BD22F51 source)
		{
			this.CopyCyclicToPlain((Plc1.AX5101_1BD22F51)source);
		}

		public void CopyShadowToPlain(Plc1.AX5101_1BD22F51 source)
		{
			base.CopyShadowToPlain(source);
			AT_x.CopyShadowToPlain(source.AT_x);
			MDT.CopyShadowToPlain(source.MDT);
			WcState.CopyShadowToPlain(source.WcState);
			InfoData.CopyShadowToPlain(source.InfoData);
		}

		public void CopyShadowToPlain(Plc1.IShadowAX5101_1BD22F51 source)
		{
			this.CopyShadowToPlain((Plc1.AX5101_1BD22F51)source);
		}
	}
}