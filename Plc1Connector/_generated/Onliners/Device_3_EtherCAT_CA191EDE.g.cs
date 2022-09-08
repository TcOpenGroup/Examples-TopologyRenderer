using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"IODEVICETYPE_ETHERCATPROT\" } {attribute addProperty Id \"Term_146_EK1100Term_146_EK1100_439F5464567SyncUnitsSyncUnits_67D36DDA18InputsInputs_A65FACA410OutputsOutputs_23C0ED1D6InfoDataInfoData_84133AC922\" } {attribute addProperty CRC \"3390643934\" } {attribute addProperty Size \"623\" } {attribute addProperty Name \"Device 3 (EtherCAT)\" }", "Device_3_EtherCAT_CA191EDE", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Device_3_EtherCAT_CA191EDE : TcoIo.EtcMasterBase_62654B43, Vortex.Connector.IVortexObject, IDevice_3_EtherCAT_CA191EDE, IShadowDevice_3_EtherCAT_CA191EDE, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_146_EK1100_439F5464 _Term_146_EK1100;
		public Term_146_EK1100_439F5464 Term_146_EK1100
		{
			get
			{
				return _Term_146_EK1100;
			}
		}

		ITerm_146_EK1100_439F5464 IDevice_3_EtherCAT_CA191EDE.Term_146_EK1100
		{
			get
			{
				return Term_146_EK1100;
			}
		}

		IShadowTerm_146_EK1100_439F5464 IShadowDevice_3_EtherCAT_CA191EDE.Term_146_EK1100
		{
			get
			{
				return Term_146_EK1100;
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

		ISyncUnits_67D36DDA IDevice_3_EtherCAT_CA191EDE.SyncUnits
		{
			get
			{
				return SyncUnits;
			}
		}

		IShadowSyncUnits_67D36DDA IShadowDevice_3_EtherCAT_CA191EDE.SyncUnits
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

		TcoIo.IInputs_A65FACA4 IDevice_3_EtherCAT_CA191EDE.Inputs
		{
			get
			{
				return Inputs;
			}
		}

		TcoIo.IShadowInputs_A65FACA4 IShadowDevice_3_EtherCAT_CA191EDE.Inputs
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

		TcoIo.IOutputs_23C0ED1D IDevice_3_EtherCAT_CA191EDE.Outputs
		{
			get
			{
				return Outputs;
			}
		}

		TcoIo.IShadowOutputs_23C0ED1D IShadowDevice_3_EtherCAT_CA191EDE.Outputs
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

		TcoIo.IInfoData_84133AC9 IDevice_3_EtherCAT_CA191EDE.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		TcoIo.IShadowInfoData_84133AC9 IShadowDevice_3_EtherCAT_CA191EDE.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_146_EK1100.LazyOnlineToShadow();
			SyncUnits.LazyOnlineToShadow();
			Inputs.LazyOnlineToShadow();
			Outputs.LazyOnlineToShadow();
			InfoData.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_146_EK1100.LazyShadowToOnline();
			SyncUnits.LazyShadowToOnline();
			Inputs.LazyShadowToOnline();
			Outputs.LazyShadowToOnline();
			InfoData.LazyShadowToOnline();
		}

		public new PlainDevice_3_EtherCAT_CA191EDE CreatePlainerType()
		{
			var cloned = new PlainDevice_3_EtherCAT_CA191EDE();
			base.CreatePlainerType(cloned);
			cloned.Term_146_EK1100 = Term_146_EK1100.CreatePlainerType();
			cloned.SyncUnits = SyncUnits.CreatePlainerType();
			cloned.Inputs = Inputs.CreatePlainerType();
			cloned.Outputs = Outputs.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		protected PlainDevice_3_EtherCAT_CA191EDE CreatePlainerType(PlainDevice_3_EtherCAT_CA191EDE cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_146_EK1100 = Term_146_EK1100.CreatePlainerType();
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
		public void FlushPlainToOnline(Plc1.PlainDevice_3_EtherCAT_CA191EDE source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainDevice_3_EtherCAT_CA191EDE source)
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

		public void FlushOnlineToPlain(Plc1.PlainDevice_3_EtherCAT_CA191EDE source)
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

		public Device_3_EtherCAT_CA191EDE(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_146_EK1100 = new Term_146_EK1100_439F5464(this, "Term 146 (EK1100)", "Term_146_EK1100");
			_Term_146_EK1100.AttributeName = "Term 146 (EK1100)";
			_Term_146_EK1100.AttributePreviousPort = "Device 3 (EtherCAT) : Master";
			_Term_146_EK1100.AttributeSyncUnit = "default";
			_SyncUnits = new SyncUnits_67D36DDA(this, "SyncUnits", "SyncUnits");
			_SyncUnits.AttributeName = "SyncUnits";
			_Inputs = new TcoIo.Inputs_A65FACA4(this, "Inputs", "Inputs");
			_Inputs.AttributeName = "Inputs";
			_Outputs = new TcoIo.Outputs_23C0ED1D(this, "Outputs", "Outputs");
			_Outputs.AttributeName = "Outputs";
			_InfoData = new TcoIo.InfoData_84133AC9(this, "InfoData", "InfoData");
			_InfoData.AttributeName = "InfoData";
			AttributeBoxType = "IODEVICETYPE_ETHERCATPROT";
			AttributeId = "Term_146_EK1100Term_146_EK1100_439F5464567SyncUnitsSyncUnits_67D36DDA18InputsInputs_A65FACA410OutputsOutputs_23C0ED1D6InfoDataInfoData_84133AC922";
			AttributeCRC = "3390643934";
			AttributeSize = "623";
			AttributeName = "Device 3 (EtherCAT)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Device_3_EtherCAT_CA191EDE(): base ()
		{
			PexPreConstructorParameterless();
			_Term_146_EK1100 = new Term_146_EK1100_439F5464();
			_Term_146_EK1100.AttributeName = "Term 146 (EK1100)";
			_Term_146_EK1100.AttributePreviousPort = "Device 3 (EtherCAT) : Master";
			_Term_146_EK1100.AttributeSyncUnit = "default";
			_SyncUnits = new SyncUnits_67D36DDA();
			_SyncUnits.AttributeName = "SyncUnits";
			_Inputs = new TcoIo.Inputs_A65FACA4();
			_Inputs.AttributeName = "Inputs";
			_Outputs = new TcoIo.Outputs_23C0ED1D();
			_Outputs.AttributeName = "Outputs";
			_InfoData = new TcoIo.InfoData_84133AC9();
			_InfoData.AttributeName = "InfoData";
			AttributeBoxType = "IODEVICETYPE_ETHERCATPROT";
			AttributeId = "Term_146_EK1100Term_146_EK1100_439F5464567SyncUnitsSyncUnits_67D36DDA18InputsInputs_A65FACA410OutputsOutputs_23C0ED1D6InfoDataInfoData_84133AC922";
			AttributeCRC = "3390643934";
			AttributeSize = "623";
			AttributeName = "Device 3 (EtherCAT)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainDevice_3_EtherCAT_CA191EDE
	{
		public void CopyPlainToCyclic(Plc1.Device_3_EtherCAT_CA191EDE target)
		{
			base.CopyPlainToCyclic(target);
			Term_146_EK1100.CopyPlainToCyclic(target.Term_146_EK1100);
			SyncUnits.CopyPlainToCyclic(target.SyncUnits);
			Inputs.CopyPlainToCyclic(target.Inputs);
			Outputs.CopyPlainToCyclic(target.Outputs);
			InfoData.CopyPlainToCyclic(target.InfoData);
		}

		public void CopyPlainToCyclic(Plc1.IDevice_3_EtherCAT_CA191EDE target)
		{
			this.CopyPlainToCyclic((Plc1.Device_3_EtherCAT_CA191EDE)target);
		}

		public void CopyPlainToShadow(Plc1.Device_3_EtherCAT_CA191EDE target)
		{
			base.CopyPlainToShadow(target);
			Term_146_EK1100.CopyPlainToShadow(target.Term_146_EK1100);
			SyncUnits.CopyPlainToShadow(target.SyncUnits);
			Inputs.CopyPlainToShadow(target.Inputs);
			Outputs.CopyPlainToShadow(target.Outputs);
			InfoData.CopyPlainToShadow(target.InfoData);
		}

		public void CopyPlainToShadow(Plc1.IShadowDevice_3_EtherCAT_CA191EDE target)
		{
			this.CopyPlainToShadow((Plc1.Device_3_EtherCAT_CA191EDE)target);
		}

		public void CopyCyclicToPlain(Plc1.Device_3_EtherCAT_CA191EDE source)
		{
			base.CopyCyclicToPlain(source);
			Term_146_EK1100.CopyCyclicToPlain(source.Term_146_EK1100);
			SyncUnits.CopyCyclicToPlain(source.SyncUnits);
			Inputs.CopyCyclicToPlain(source.Inputs);
			Outputs.CopyCyclicToPlain(source.Outputs);
			InfoData.CopyCyclicToPlain(source.InfoData);
		}

		public void CopyCyclicToPlain(Plc1.IDevice_3_EtherCAT_CA191EDE source)
		{
			this.CopyCyclicToPlain((Plc1.Device_3_EtherCAT_CA191EDE)source);
		}

		public void CopyShadowToPlain(Plc1.Device_3_EtherCAT_CA191EDE source)
		{
			base.CopyShadowToPlain(source);
			Term_146_EK1100.CopyShadowToPlain(source.Term_146_EK1100);
			SyncUnits.CopyShadowToPlain(source.SyncUnits);
			Inputs.CopyShadowToPlain(source.Inputs);
			Outputs.CopyShadowToPlain(source.Outputs);
			InfoData.CopyShadowToPlain(source.InfoData);
		}

		public void CopyShadowToPlain(Plc1.IShadowDevice_3_EtherCAT_CA191EDE source)
		{
			this.CopyShadowToPlain((Plc1.Device_3_EtherCAT_CA191EDE)source);
		}
	}
}