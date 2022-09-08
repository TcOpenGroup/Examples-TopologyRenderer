using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"IODEVICETYPE_ETHERCATPROT\" } {attribute addProperty Id \"Term_1_EK1200Term_1_EK1200_B38DC9A8248SyncUnitsSyncUnits_67D36DDA18InputsInputs_A65FACA410OutputsOutputs_23C0ED1D6InfoDataInfoData_84133AC922\" } {attribute addProperty CRC \"3042432710\" } {attribute addProperty Size \"304\" } {attribute addProperty Name \"Device 1 (EtherCAT)\" }", "Device_1_EtherCAT_B557D6C6", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Device_1_EtherCAT_B557D6C6 : TcoIo.EtcMasterBase_62654B43, Vortex.Connector.IVortexObject, IDevice_1_EtherCAT_B557D6C6, IShadowDevice_1_EtherCAT_B557D6C6, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_1_EK1200_B38DC9A8 _Term_1_EK1200;
		public Term_1_EK1200_B38DC9A8 Term_1_EK1200
		{
			get
			{
				return _Term_1_EK1200;
			}
		}

		ITerm_1_EK1200_B38DC9A8 IDevice_1_EtherCAT_B557D6C6.Term_1_EK1200
		{
			get
			{
				return Term_1_EK1200;
			}
		}

		IShadowTerm_1_EK1200_B38DC9A8 IShadowDevice_1_EtherCAT_B557D6C6.Term_1_EK1200
		{
			get
			{
				return Term_1_EK1200;
			}
		}

		SyncUnits_67D36DDA _SyncUnits;
		public SyncUnits_67D36DDA SyncUnits
		{
			get
			{
				return _SyncUnits;
			}
		}

		ISyncUnits_67D36DDA IDevice_1_EtherCAT_B557D6C6.SyncUnits
		{
			get
			{
				return SyncUnits;
			}
		}

		IShadowSyncUnits_67D36DDA IShadowDevice_1_EtherCAT_B557D6C6.SyncUnits
		{
			get
			{
				return SyncUnits;
			}
		}

		TcoIo.Inputs_A65FACA4 _Inputs;
		public TcoIo.Inputs_A65FACA4 Inputs
		{
			get
			{
				return _Inputs;
			}
		}

		TcoIo.IInputs_A65FACA4 IDevice_1_EtherCAT_B557D6C6.Inputs
		{
			get
			{
				return Inputs;
			}
		}

		TcoIo.IShadowInputs_A65FACA4 IShadowDevice_1_EtherCAT_B557D6C6.Inputs
		{
			get
			{
				return Inputs;
			}
		}

		TcoIo.Outputs_23C0ED1D _Outputs;
		public TcoIo.Outputs_23C0ED1D Outputs
		{
			get
			{
				return _Outputs;
			}
		}

		TcoIo.IOutputs_23C0ED1D IDevice_1_EtherCAT_B557D6C6.Outputs
		{
			get
			{
				return Outputs;
			}
		}

		TcoIo.IShadowOutputs_23C0ED1D IShadowDevice_1_EtherCAT_B557D6C6.Outputs
		{
			get
			{
				return Outputs;
			}
		}

		TcoIo.InfoData_84133AC9 _InfoData;
		public TcoIo.InfoData_84133AC9 InfoData
		{
			get
			{
				return _InfoData;
			}
		}

		TcoIo.IInfoData_84133AC9 IDevice_1_EtherCAT_B557D6C6.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		TcoIo.IShadowInfoData_84133AC9 IShadowDevice_1_EtherCAT_B557D6C6.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_1_EK1200.LazyOnlineToShadow();
			SyncUnits.LazyOnlineToShadow();
			Inputs.LazyOnlineToShadow();
			Outputs.LazyOnlineToShadow();
			InfoData.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_1_EK1200.LazyShadowToOnline();
			SyncUnits.LazyShadowToOnline();
			Inputs.LazyShadowToOnline();
			Outputs.LazyShadowToOnline();
			InfoData.LazyShadowToOnline();
		}

		public new PlainDevice_1_EtherCAT_B557D6C6 CreatePlainerType()
		{
			var cloned = new PlainDevice_1_EtherCAT_B557D6C6();
			base.CreatePlainerType(cloned);
			cloned.Term_1_EK1200 = Term_1_EK1200.CreatePlainerType();
			cloned.SyncUnits = SyncUnits.CreatePlainerType();
			cloned.Inputs = Inputs.CreatePlainerType();
			cloned.Outputs = Outputs.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		protected PlainDevice_1_EtherCAT_B557D6C6 CreatePlainerType(PlainDevice_1_EtherCAT_B557D6C6 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_1_EK1200 = Term_1_EK1200.CreatePlainerType();
			cloned.SyncUnits = SyncUnits.CreatePlainerType();
			cloned.Inputs = Inputs.CreatePlainerType();
			cloned.Outputs = Outputs.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainDevice_1_EtherCAT_B557D6C6 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainDevice_1_EtherCAT_B557D6C6 source)
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

		public void FlushOnlineToPlain(Plc1.PlainDevice_1_EtherCAT_B557D6C6 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
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

		public Device_1_EtherCAT_B557D6C6(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_1_EK1200 = new Term_1_EK1200_B38DC9A8(this, "Term 1 (EK1200)", "Term_1_EK1200");
			_Term_1_EK1200.AttributeName = "Term 1 (EK1200)";
			_Term_1_EK1200.AttributePreviousPort = "Device 1 (EtherCAT) : Master";
			_Term_1_EK1200.AttributeSyncUnit = "default";
			_SyncUnits = new SyncUnits_67D36DDA(this, "SyncUnits", "SyncUnits");
			_SyncUnits.AttributeName = "SyncUnits";
			_Inputs = new TcoIo.Inputs_A65FACA4(this, "Inputs", "Inputs");
			_Inputs.AttributeName = "Inputs";
			_Outputs = new TcoIo.Outputs_23C0ED1D(this, "Outputs", "Outputs");
			_Outputs.AttributeName = "Outputs";
			_InfoData = new TcoIo.InfoData_84133AC9(this, "InfoData", "InfoData");
			_InfoData.AttributeName = "InfoData";
			AttributeBoxType = "IODEVICETYPE_ETHERCATPROT";
			AttributeId = "Term_1_EK1200Term_1_EK1200_B38DC9A8248SyncUnitsSyncUnits_67D36DDA18InputsInputs_A65FACA410OutputsOutputs_23C0ED1D6InfoDataInfoData_84133AC922";
			AttributeCRC = "3042432710";
			AttributeSize = "304";
			AttributeName = "Device 1 (EtherCAT)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Device_1_EtherCAT_B557D6C6(): base ()
		{
			PexPreConstructorParameterless();
			_Term_1_EK1200 = new Term_1_EK1200_B38DC9A8();
			_Term_1_EK1200.AttributeName = "Term 1 (EK1200)";
			_Term_1_EK1200.AttributePreviousPort = "Device 1 (EtherCAT) : Master";
			_Term_1_EK1200.AttributeSyncUnit = "default";
			_SyncUnits = new SyncUnits_67D36DDA();
			_SyncUnits.AttributeName = "SyncUnits";
			_Inputs = new TcoIo.Inputs_A65FACA4();
			_Inputs.AttributeName = "Inputs";
			_Outputs = new TcoIo.Outputs_23C0ED1D();
			_Outputs.AttributeName = "Outputs";
			_InfoData = new TcoIo.InfoData_84133AC9();
			_InfoData.AttributeName = "InfoData";
			AttributeBoxType = "IODEVICETYPE_ETHERCATPROT";
			AttributeId = "Term_1_EK1200Term_1_EK1200_B38DC9A8248SyncUnitsSyncUnits_67D36DDA18InputsInputs_A65FACA410OutputsOutputs_23C0ED1D6InfoDataInfoData_84133AC922";
			AttributeCRC = "3042432710";
			AttributeSize = "304";
			AttributeName = "Device 1 (EtherCAT)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainDevice_1_EtherCAT_B557D6C6
	{
		public void CopyPlainToCyclic(Plc1.Device_1_EtherCAT_B557D6C6 target)
		{
			base.CopyPlainToCyclic(target);
			Term_1_EK1200.CopyPlainToCyclic(target.Term_1_EK1200);
			SyncUnits.CopyPlainToCyclic(target.SyncUnits);
			Inputs.CopyPlainToCyclic(target.Inputs);
			Outputs.CopyPlainToCyclic(target.Outputs);
			InfoData.CopyPlainToCyclic(target.InfoData);
		}

		public void CopyPlainToCyclic(Plc1.IDevice_1_EtherCAT_B557D6C6 target)
		{
			this.CopyPlainToCyclic((Plc1.Device_1_EtherCAT_B557D6C6)target);
		}

		public void CopyPlainToShadow(Plc1.Device_1_EtherCAT_B557D6C6 target)
		{
			base.CopyPlainToShadow(target);
			Term_1_EK1200.CopyPlainToShadow(target.Term_1_EK1200);
			SyncUnits.CopyPlainToShadow(target.SyncUnits);
			Inputs.CopyPlainToShadow(target.Inputs);
			Outputs.CopyPlainToShadow(target.Outputs);
			InfoData.CopyPlainToShadow(target.InfoData);
		}

		public void CopyPlainToShadow(Plc1.IShadowDevice_1_EtherCAT_B557D6C6 target)
		{
			this.CopyPlainToShadow((Plc1.Device_1_EtherCAT_B557D6C6)target);
		}

		public void CopyCyclicToPlain(Plc1.Device_1_EtherCAT_B557D6C6 source)
		{
			base.CopyCyclicToPlain(source);
			Term_1_EK1200.CopyCyclicToPlain(source.Term_1_EK1200);
			SyncUnits.CopyCyclicToPlain(source.SyncUnits);
			Inputs.CopyCyclicToPlain(source.Inputs);
			Outputs.CopyCyclicToPlain(source.Outputs);
			InfoData.CopyCyclicToPlain(source.InfoData);
		}

		public void CopyCyclicToPlain(Plc1.IDevice_1_EtherCAT_B557D6C6 source)
		{
			this.CopyCyclicToPlain((Plc1.Device_1_EtherCAT_B557D6C6)source);
		}

		public void CopyShadowToPlain(Plc1.Device_1_EtherCAT_B557D6C6 source)
		{
			base.CopyShadowToPlain(source);
			Term_1_EK1200.CopyShadowToPlain(source.Term_1_EK1200);
			SyncUnits.CopyShadowToPlain(source.SyncUnits);
			Inputs.CopyShadowToPlain(source.Inputs);
			Outputs.CopyShadowToPlain(source.Outputs);
			InfoData.CopyShadowToPlain(source.InfoData);
		}

		public void CopyShadowToPlain(Plc1.IShadowDevice_1_EtherCAT_B557D6C6 source)
		{
			this.CopyShadowToPlain((Plc1.Device_1_EtherCAT_B557D6C6)source);
		}
	}
}