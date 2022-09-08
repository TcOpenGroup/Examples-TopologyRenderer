using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty VendorId \"#x00000002\" } {attribute addProperty BoxType \"EL6002-0000-0019\" } {attribute addProperty Description \"EL6002 Interface 2Ch. (RS232)\" } {attribute addProperty Physics \"KK\" } {attribute addProperty Id \"COM_TxPDO_Map_Inputs_Channel_1AT %I*COM_TxPDO_Map_Inputs_Channel_3801C95E30COM_TxPDO_Map_Inputs_Channel_2AT %I*COM_TxPDO_Map_Inputs_Channel_3801C95E30COM_RxPDO_Map_Outputs_Channel_1AT %Q*COM_RxPDO_Map_Outputs_Channel_EADA2E0D27COM_RxPDO_Map_Outputs_Channel_2AT %Q*COM_RxPDO_Map_Outputs_Channel_EADA2E0D27WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_23CBA8372\" } {attribute addProperty CRC \"3448337973\" } {attribute addProperty Size \"118\" } {attribute addProperty Name \"\" }", "EL6002_CD897635", "Plc1", TypeComplexityEnum.Complex)]
	public partial class EL6002_CD897635 : TcoIo.EtcSlaveTerminalBase_947E5A46, Vortex.Connector.IVortexObject, IEL6002_CD897635, IShadowEL6002_CD897635, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		COM_TxPDO_Map_Inputs_Channel_3801C95E _COM_TxPDO_Map_Inputs_Channel_1;
		public COM_TxPDO_Map_Inputs_Channel_3801C95E COM_TxPDO_Map_Inputs_Channel_1
		{
			get
			{
				return _COM_TxPDO_Map_Inputs_Channel_1;
			}
		}

		ICOM_TxPDO_Map_Inputs_Channel_3801C95E IEL6002_CD897635.COM_TxPDO_Map_Inputs_Channel_1
		{
			get
			{
				return COM_TxPDO_Map_Inputs_Channel_1;
			}
		}

		IShadowCOM_TxPDO_Map_Inputs_Channel_3801C95E IShadowEL6002_CD897635.COM_TxPDO_Map_Inputs_Channel_1
		{
			get
			{
				return COM_TxPDO_Map_Inputs_Channel_1;
			}
		}

		COM_TxPDO_Map_Inputs_Channel_3801C95E _COM_TxPDO_Map_Inputs_Channel_2;
		public COM_TxPDO_Map_Inputs_Channel_3801C95E COM_TxPDO_Map_Inputs_Channel_2
		{
			get
			{
				return _COM_TxPDO_Map_Inputs_Channel_2;
			}
		}

		ICOM_TxPDO_Map_Inputs_Channel_3801C95E IEL6002_CD897635.COM_TxPDO_Map_Inputs_Channel_2
		{
			get
			{
				return COM_TxPDO_Map_Inputs_Channel_2;
			}
		}

		IShadowCOM_TxPDO_Map_Inputs_Channel_3801C95E IShadowEL6002_CD897635.COM_TxPDO_Map_Inputs_Channel_2
		{
			get
			{
				return COM_TxPDO_Map_Inputs_Channel_2;
			}
		}

		COM_RxPDO_Map_Outputs_Channel_EADA2E0D _COM_RxPDO_Map_Outputs_Channel_1;
		public COM_RxPDO_Map_Outputs_Channel_EADA2E0D COM_RxPDO_Map_Outputs_Channel_1
		{
			get
			{
				return _COM_RxPDO_Map_Outputs_Channel_1;
			}
		}

		ICOM_RxPDO_Map_Outputs_Channel_EADA2E0D IEL6002_CD897635.COM_RxPDO_Map_Outputs_Channel_1
		{
			get
			{
				return COM_RxPDO_Map_Outputs_Channel_1;
			}
		}

		IShadowCOM_RxPDO_Map_Outputs_Channel_EADA2E0D IShadowEL6002_CD897635.COM_RxPDO_Map_Outputs_Channel_1
		{
			get
			{
				return COM_RxPDO_Map_Outputs_Channel_1;
			}
		}

		COM_RxPDO_Map_Outputs_Channel_EADA2E0D _COM_RxPDO_Map_Outputs_Channel_2;
		public COM_RxPDO_Map_Outputs_Channel_EADA2E0D COM_RxPDO_Map_Outputs_Channel_2
		{
			get
			{
				return _COM_RxPDO_Map_Outputs_Channel_2;
			}
		}

		ICOM_RxPDO_Map_Outputs_Channel_EADA2E0D IEL6002_CD897635.COM_RxPDO_Map_Outputs_Channel_2
		{
			get
			{
				return COM_RxPDO_Map_Outputs_Channel_2;
			}
		}

		IShadowCOM_RxPDO_Map_Outputs_Channel_EADA2E0D IShadowEL6002_CD897635.COM_RxPDO_Map_Outputs_Channel_2
		{
			get
			{
				return COM_RxPDO_Map_Outputs_Channel_2;
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

		TcoIo.IWcState_9091E0EB IEL6002_CD897635.WcState
		{
			get
			{
				return WcState;
			}
		}

		TcoIo.IShadowWcState_9091E0EB IShadowEL6002_CD897635.WcState
		{
			get
			{
				return WcState;
			}
		}

		TcoIo.InfoData_23CBA837 _InfoData;
		public TcoIo.InfoData_23CBA837 InfoData
		{
			get
			{
				return _InfoData;
			}
		}

		TcoIo.IInfoData_23CBA837 IEL6002_CD897635.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		TcoIo.IShadowInfoData_23CBA837 IShadowEL6002_CD897635.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			COM_TxPDO_Map_Inputs_Channel_1.LazyOnlineToShadow();
			COM_TxPDO_Map_Inputs_Channel_2.LazyOnlineToShadow();
			COM_RxPDO_Map_Outputs_Channel_1.LazyOnlineToShadow();
			COM_RxPDO_Map_Outputs_Channel_2.LazyOnlineToShadow();
			WcState.LazyOnlineToShadow();
			InfoData.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			COM_TxPDO_Map_Inputs_Channel_1.LazyShadowToOnline();
			COM_TxPDO_Map_Inputs_Channel_2.LazyShadowToOnline();
			COM_RxPDO_Map_Outputs_Channel_1.LazyShadowToOnline();
			COM_RxPDO_Map_Outputs_Channel_2.LazyShadowToOnline();
			WcState.LazyShadowToOnline();
			InfoData.LazyShadowToOnline();
		}

		public new PlainEL6002_CD897635 CreatePlainerType()
		{
			var cloned = new PlainEL6002_CD897635();
			base.CreatePlainerType(cloned);
			cloned.COM_TxPDO_Map_Inputs_Channel_1 = COM_TxPDO_Map_Inputs_Channel_1.CreatePlainerType();
			cloned.COM_TxPDO_Map_Inputs_Channel_2 = COM_TxPDO_Map_Inputs_Channel_2.CreatePlainerType();
			cloned.COM_RxPDO_Map_Outputs_Channel_1 = COM_RxPDO_Map_Outputs_Channel_1.CreatePlainerType();
			cloned.COM_RxPDO_Map_Outputs_Channel_2 = COM_RxPDO_Map_Outputs_Channel_2.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		protected PlainEL6002_CD897635 CreatePlainerType(PlainEL6002_CD897635 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.COM_TxPDO_Map_Inputs_Channel_1 = COM_TxPDO_Map_Inputs_Channel_1.CreatePlainerType();
			cloned.COM_TxPDO_Map_Inputs_Channel_2 = COM_TxPDO_Map_Inputs_Channel_2.CreatePlainerType();
			cloned.COM_RxPDO_Map_Outputs_Channel_1 = COM_RxPDO_Map_Outputs_Channel_1.CreatePlainerType();
			cloned.COM_RxPDO_Map_Outputs_Channel_2 = COM_RxPDO_Map_Outputs_Channel_2.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainEL6002_CD897635 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainEL6002_CD897635 source)
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

		public void FlushOnlineToPlain(Plc1.PlainEL6002_CD897635 source)
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

		public EL6002_CD897635(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_COM_TxPDO_Map_Inputs_Channel_1 = new COM_TxPDO_Map_Inputs_Channel_3801C95E(this, "COM_TxPDO_Map_Inputs_Channel_1", "COM_TxPDO_Map_Inputs_Channel_1");
			_COM_TxPDO_Map_Inputs_Channel_1.AttributeName = "COM_TxPDO_Map_Inputs_Channel_1";
			_COM_TxPDO_Map_Inputs_Channel_2 = new COM_TxPDO_Map_Inputs_Channel_3801C95E(this, "COM_TxPDO_Map_Inputs_Channel_2", "COM_TxPDO_Map_Inputs_Channel_2");
			_COM_TxPDO_Map_Inputs_Channel_2.AttributeName = "COM_TxPDO_Map_Inputs_Channel_2";
			_COM_RxPDO_Map_Outputs_Channel_1 = new COM_RxPDO_Map_Outputs_Channel_EADA2E0D(this, "COM_RxPDO_Map_Outputs_Channel_1", "COM_RxPDO_Map_Outputs_Channel_1");
			_COM_RxPDO_Map_Outputs_Channel_1.AttributeName = "COM_RxPDO_Map_Outputs_Channel_1";
			_COM_RxPDO_Map_Outputs_Channel_2 = new COM_RxPDO_Map_Outputs_Channel_EADA2E0D(this, "COM_RxPDO_Map_Outputs_Channel_2", "COM_RxPDO_Map_Outputs_Channel_2");
			_COM_RxPDO_Map_Outputs_Channel_2.AttributeName = "COM_RxPDO_Map_Outputs_Channel_2";
			_WcState = new TcoIo.WcState_9091E0EB(this, "WcState", "WcState");
			_WcState.AttributeName = "WcState";
			_InfoData = new TcoIo.InfoData_23CBA837(this, "InfoData", "InfoData");
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL6002-0000-0019";
			AttributeDescription = "EL6002 Interface 2Ch. (RS232)";
			AttributePhysics = "KK";
			AttributeId = "COM_TxPDO_Map_Inputs_Channel_1AT %I*COM_TxPDO_Map_Inputs_Channel_3801C95E30COM_TxPDO_Map_Inputs_Channel_2AT %I*COM_TxPDO_Map_Inputs_Channel_3801C95E30COM_RxPDO_Map_Outputs_Channel_1AT %Q*COM_RxPDO_Map_Outputs_Channel_EADA2E0D27COM_RxPDO_Map_Outputs_Channel_2AT %Q*COM_RxPDO_Map_Outputs_Channel_EADA2E0D27WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_23CBA8372";
			AttributeCRC = "3448337973";
			AttributeSize = "118";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public EL6002_CD897635(): base ()
		{
			PexPreConstructorParameterless();
			_COM_TxPDO_Map_Inputs_Channel_1 = new COM_TxPDO_Map_Inputs_Channel_3801C95E();
			_COM_TxPDO_Map_Inputs_Channel_1.AttributeName = "COM_TxPDO_Map_Inputs_Channel_1";
			_COM_TxPDO_Map_Inputs_Channel_2 = new COM_TxPDO_Map_Inputs_Channel_3801C95E();
			_COM_TxPDO_Map_Inputs_Channel_2.AttributeName = "COM_TxPDO_Map_Inputs_Channel_2";
			_COM_RxPDO_Map_Outputs_Channel_1 = new COM_RxPDO_Map_Outputs_Channel_EADA2E0D();
			_COM_RxPDO_Map_Outputs_Channel_1.AttributeName = "COM_RxPDO_Map_Outputs_Channel_1";
			_COM_RxPDO_Map_Outputs_Channel_2 = new COM_RxPDO_Map_Outputs_Channel_EADA2E0D();
			_COM_RxPDO_Map_Outputs_Channel_2.AttributeName = "COM_RxPDO_Map_Outputs_Channel_2";
			_WcState = new TcoIo.WcState_9091E0EB();
			_WcState.AttributeName = "WcState";
			_InfoData = new TcoIo.InfoData_23CBA837();
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL6002-0000-0019";
			AttributeDescription = "EL6002 Interface 2Ch. (RS232)";
			AttributePhysics = "KK";
			AttributeId = "COM_TxPDO_Map_Inputs_Channel_1AT %I*COM_TxPDO_Map_Inputs_Channel_3801C95E30COM_TxPDO_Map_Inputs_Channel_2AT %I*COM_TxPDO_Map_Inputs_Channel_3801C95E30COM_RxPDO_Map_Outputs_Channel_1AT %Q*COM_RxPDO_Map_Outputs_Channel_EADA2E0D27COM_RxPDO_Map_Outputs_Channel_2AT %Q*COM_RxPDO_Map_Outputs_Channel_EADA2E0D27WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_23CBA8372";
			AttributeCRC = "3448337973";
			AttributeSize = "118";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL6002_CD897635
	{
		public void CopyPlainToCyclic(Plc1.EL6002_CD897635 target)
		{
			base.CopyPlainToCyclic(target);
			COM_TxPDO_Map_Inputs_Channel_1.CopyPlainToCyclic(target.COM_TxPDO_Map_Inputs_Channel_1);
			COM_TxPDO_Map_Inputs_Channel_2.CopyPlainToCyclic(target.COM_TxPDO_Map_Inputs_Channel_2);
			COM_RxPDO_Map_Outputs_Channel_1.CopyPlainToCyclic(target.COM_RxPDO_Map_Outputs_Channel_1);
			COM_RxPDO_Map_Outputs_Channel_2.CopyPlainToCyclic(target.COM_RxPDO_Map_Outputs_Channel_2);
			WcState.CopyPlainToCyclic(target.WcState);
			InfoData.CopyPlainToCyclic(target.InfoData);
		}

		public void CopyPlainToCyclic(Plc1.IEL6002_CD897635 target)
		{
			this.CopyPlainToCyclic((Plc1.EL6002_CD897635)target);
		}

		public void CopyPlainToShadow(Plc1.EL6002_CD897635 target)
		{
			base.CopyPlainToShadow(target);
			COM_TxPDO_Map_Inputs_Channel_1.CopyPlainToShadow(target.COM_TxPDO_Map_Inputs_Channel_1);
			COM_TxPDO_Map_Inputs_Channel_2.CopyPlainToShadow(target.COM_TxPDO_Map_Inputs_Channel_2);
			COM_RxPDO_Map_Outputs_Channel_1.CopyPlainToShadow(target.COM_RxPDO_Map_Outputs_Channel_1);
			COM_RxPDO_Map_Outputs_Channel_2.CopyPlainToShadow(target.COM_RxPDO_Map_Outputs_Channel_2);
			WcState.CopyPlainToShadow(target.WcState);
			InfoData.CopyPlainToShadow(target.InfoData);
		}

		public void CopyPlainToShadow(Plc1.IShadowEL6002_CD897635 target)
		{
			this.CopyPlainToShadow((Plc1.EL6002_CD897635)target);
		}

		public void CopyCyclicToPlain(Plc1.EL6002_CD897635 source)
		{
			base.CopyCyclicToPlain(source);
			COM_TxPDO_Map_Inputs_Channel_1.CopyCyclicToPlain(source.COM_TxPDO_Map_Inputs_Channel_1);
			COM_TxPDO_Map_Inputs_Channel_2.CopyCyclicToPlain(source.COM_TxPDO_Map_Inputs_Channel_2);
			COM_RxPDO_Map_Outputs_Channel_1.CopyCyclicToPlain(source.COM_RxPDO_Map_Outputs_Channel_1);
			COM_RxPDO_Map_Outputs_Channel_2.CopyCyclicToPlain(source.COM_RxPDO_Map_Outputs_Channel_2);
			WcState.CopyCyclicToPlain(source.WcState);
			InfoData.CopyCyclicToPlain(source.InfoData);
		}

		public void CopyCyclicToPlain(Plc1.IEL6002_CD897635 source)
		{
			this.CopyCyclicToPlain((Plc1.EL6002_CD897635)source);
		}

		public void CopyShadowToPlain(Plc1.EL6002_CD897635 source)
		{
			base.CopyShadowToPlain(source);
			COM_TxPDO_Map_Inputs_Channel_1.CopyShadowToPlain(source.COM_TxPDO_Map_Inputs_Channel_1);
			COM_TxPDO_Map_Inputs_Channel_2.CopyShadowToPlain(source.COM_TxPDO_Map_Inputs_Channel_2);
			COM_RxPDO_Map_Outputs_Channel_1.CopyShadowToPlain(source.COM_RxPDO_Map_Outputs_Channel_1);
			COM_RxPDO_Map_Outputs_Channel_2.CopyShadowToPlain(source.COM_RxPDO_Map_Outputs_Channel_2);
			WcState.CopyShadowToPlain(source.WcState);
			InfoData.CopyShadowToPlain(source.InfoData);
		}

		public void CopyShadowToPlain(Plc1.IShadowEL6002_CD897635 source)
		{
			this.CopyShadowToPlain((Plc1.EL6002_CD897635)source);
		}
	}
}