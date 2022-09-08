using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty VendorId \"#x00000002\" } {attribute addProperty BoxType \"EL6001-0000-0020\" } {attribute addProperty Description \"EL6001 Interface (RS232)\" } {attribute addProperty Physics \"KK\" } {attribute addProperty Id \"COM_InputsAT %I*COM_Inputs_3801C95E30COM_OutputsAT %Q*COM_Outputs_DEF408EC27WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_23CBA8372\" } {attribute addProperty CRC \"232791678\" } {attribute addProperty Size \"61\" } {attribute addProperty Name \"\" }", "EL6001_0DE01E7E", "Plc1", TypeComplexityEnum.Complex)]
	public partial class EL6001_0DE01E7E : TcoIo.EtcSlaveTerminalBase_947E5A46, Vortex.Connector.IVortexObject, IEL6001_0DE01E7E, IShadowEL6001_0DE01E7E, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		COM_Inputs_3801C95E _COM_Inputs;
		public COM_Inputs_3801C95E COM_Inputs
		{
			get
			{
				return _COM_Inputs;
			}
		}

		ICOM_Inputs_3801C95E IEL6001_0DE01E7E.COM_Inputs
		{
			get
			{
				return COM_Inputs;
			}
		}

		IShadowCOM_Inputs_3801C95E IShadowEL6001_0DE01E7E.COM_Inputs
		{
			get
			{
				return COM_Inputs;
			}
		}

		COM_Outputs_DEF408EC _COM_Outputs;
		public COM_Outputs_DEF408EC COM_Outputs
		{
			get
			{
				return _COM_Outputs;
			}
		}

		ICOM_Outputs_DEF408EC IEL6001_0DE01E7E.COM_Outputs
		{
			get
			{
				return COM_Outputs;
			}
		}

		IShadowCOM_Outputs_DEF408EC IShadowEL6001_0DE01E7E.COM_Outputs
		{
			get
			{
				return COM_Outputs;
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

		TcoIo.IWcState_9091E0EB IEL6001_0DE01E7E.WcState
		{
			get
			{
				return WcState;
			}
		}

		TcoIo.IShadowWcState_9091E0EB IShadowEL6001_0DE01E7E.WcState
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

		TcoIo.IInfoData_23CBA837 IEL6001_0DE01E7E.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		TcoIo.IShadowInfoData_23CBA837 IShadowEL6001_0DE01E7E.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			COM_Inputs.LazyOnlineToShadow();
			COM_Outputs.LazyOnlineToShadow();
			WcState.LazyOnlineToShadow();
			InfoData.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			COM_Inputs.LazyShadowToOnline();
			COM_Outputs.LazyShadowToOnline();
			WcState.LazyShadowToOnline();
			InfoData.LazyShadowToOnline();
		}

		public new PlainEL6001_0DE01E7E CreatePlainerType()
		{
			var cloned = new PlainEL6001_0DE01E7E();
			base.CreatePlainerType(cloned);
			cloned.COM_Inputs = COM_Inputs.CreatePlainerType();
			cloned.COM_Outputs = COM_Outputs.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		protected PlainEL6001_0DE01E7E CreatePlainerType(PlainEL6001_0DE01E7E cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.COM_Inputs = COM_Inputs.CreatePlainerType();
			cloned.COM_Outputs = COM_Outputs.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainEL6001_0DE01E7E source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainEL6001_0DE01E7E source)
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

		public void FlushOnlineToPlain(Plc1.PlainEL6001_0DE01E7E source)
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

		public EL6001_0DE01E7E(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_COM_Inputs = new COM_Inputs_3801C95E(this, "COM_Inputs", "COM_Inputs");
			_COM_Inputs.AttributeName = "COM_Inputs";
			_COM_Outputs = new COM_Outputs_DEF408EC(this, "COM_Outputs", "COM_Outputs");
			_COM_Outputs.AttributeName = "COM_Outputs";
			_WcState = new TcoIo.WcState_9091E0EB(this, "WcState", "WcState");
			_WcState.AttributeName = "WcState";
			_InfoData = new TcoIo.InfoData_23CBA837(this, "InfoData", "InfoData");
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL6001-0000-0020";
			AttributeDescription = "EL6001 Interface (RS232)";
			AttributePhysics = "KK";
			AttributeId = "COM_InputsAT %I*COM_Inputs_3801C95E30COM_OutputsAT %Q*COM_Outputs_DEF408EC27WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_23CBA8372";
			AttributeCRC = "232791678";
			AttributeSize = "61";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public EL6001_0DE01E7E(): base ()
		{
			PexPreConstructorParameterless();
			_COM_Inputs = new COM_Inputs_3801C95E();
			_COM_Inputs.AttributeName = "COM_Inputs";
			_COM_Outputs = new COM_Outputs_DEF408EC();
			_COM_Outputs.AttributeName = "COM_Outputs";
			_WcState = new TcoIo.WcState_9091E0EB();
			_WcState.AttributeName = "WcState";
			_InfoData = new TcoIo.InfoData_23CBA837();
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL6001-0000-0020";
			AttributeDescription = "EL6001 Interface (RS232)";
			AttributePhysics = "KK";
			AttributeId = "COM_InputsAT %I*COM_Inputs_3801C95E30COM_OutputsAT %Q*COM_Outputs_DEF408EC27WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_23CBA8372";
			AttributeCRC = "232791678";
			AttributeSize = "61";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL6001_0DE01E7E
	{
		public void CopyPlainToCyclic(Plc1.EL6001_0DE01E7E target)
		{
			base.CopyPlainToCyclic(target);
			COM_Inputs.CopyPlainToCyclic(target.COM_Inputs);
			COM_Outputs.CopyPlainToCyclic(target.COM_Outputs);
			WcState.CopyPlainToCyclic(target.WcState);
			InfoData.CopyPlainToCyclic(target.InfoData);
		}

		public void CopyPlainToCyclic(Plc1.IEL6001_0DE01E7E target)
		{
			this.CopyPlainToCyclic((Plc1.EL6001_0DE01E7E)target);
		}

		public void CopyPlainToShadow(Plc1.EL6001_0DE01E7E target)
		{
			base.CopyPlainToShadow(target);
			COM_Inputs.CopyPlainToShadow(target.COM_Inputs);
			COM_Outputs.CopyPlainToShadow(target.COM_Outputs);
			WcState.CopyPlainToShadow(target.WcState);
			InfoData.CopyPlainToShadow(target.InfoData);
		}

		public void CopyPlainToShadow(Plc1.IShadowEL6001_0DE01E7E target)
		{
			this.CopyPlainToShadow((Plc1.EL6001_0DE01E7E)target);
		}

		public void CopyCyclicToPlain(Plc1.EL6001_0DE01E7E source)
		{
			base.CopyCyclicToPlain(source);
			COM_Inputs.CopyCyclicToPlain(source.COM_Inputs);
			COM_Outputs.CopyCyclicToPlain(source.COM_Outputs);
			WcState.CopyCyclicToPlain(source.WcState);
			InfoData.CopyCyclicToPlain(source.InfoData);
		}

		public void CopyCyclicToPlain(Plc1.IEL6001_0DE01E7E source)
		{
			this.CopyCyclicToPlain((Plc1.EL6001_0DE01E7E)source);
		}

		public void CopyShadowToPlain(Plc1.EL6001_0DE01E7E source)
		{
			base.CopyShadowToPlain(source);
			COM_Inputs.CopyShadowToPlain(source.COM_Inputs);
			COM_Outputs.CopyShadowToPlain(source.COM_Outputs);
			WcState.CopyShadowToPlain(source.WcState);
			InfoData.CopyShadowToPlain(source.InfoData);
		}

		public void CopyShadowToPlain(Plc1.IShadowEL6001_0DE01E7E source)
		{
			this.CopyShadowToPlain((Plc1.EL6001_0DE01E7E)source);
		}
	}
}