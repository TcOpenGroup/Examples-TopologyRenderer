using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty VendorId \"#x00000002\" } {attribute addProperty BoxType \"EL3403-0000-0023\" } {attribute addProperty Description \"EL3403 3Ch. Power Measuring\" } {attribute addProperty Physics \"KK\" } {attribute addProperty Id \"PM_Inputs_Channel_1AT %I*PM_Inputs_Channel_2F86808618PM_Inputs_Channel_2AT %I*PM_Inputs_Channel_2F86808618PM_Inputs_Channel_3AT %I*PM_Inputs_Channel_2F86808618PM_Status_dataAT %I*PM_Status_data_2A9514CB4PM_Outputs_Channel_1AT %Q*PM_Outputs_Channel_E5FBDE301PM_Outputs_Channel_2AT %Q*PM_Outputs_Channel_E5FBDE301PM_Outputs_Channel_3AT %Q*PM_Outputs_Channel_E5FBDE301WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_23CBA8372\" } {attribute addProperty CRC \"2166980774\" } {attribute addProperty Size \"65\" } {attribute addProperty Name \"\" }", "EL3403_812980A6", "Plc1", TypeComplexityEnum.Complex)]
	public partial class EL3403_812980A6 : TcoIo.EtcSlaveTerminalBase_947E5A46, Vortex.Connector.IVortexObject, IEL3403_812980A6, IShadowEL3403_812980A6, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		PM_Inputs_Channel_2F868086 _PM_Inputs_Channel_1;
		public PM_Inputs_Channel_2F868086 PM_Inputs_Channel_1
		{
			get
			{
				return _PM_Inputs_Channel_1;
			}
		}

		IPM_Inputs_Channel_2F868086 IEL3403_812980A6.PM_Inputs_Channel_1
		{
			get
			{
				return PM_Inputs_Channel_1;
			}
		}

		IShadowPM_Inputs_Channel_2F868086 IShadowEL3403_812980A6.PM_Inputs_Channel_1
		{
			get
			{
				return PM_Inputs_Channel_1;
			}
		}

		PM_Inputs_Channel_2F868086 _PM_Inputs_Channel_2;
		public PM_Inputs_Channel_2F868086 PM_Inputs_Channel_2
		{
			get
			{
				return _PM_Inputs_Channel_2;
			}
		}

		IPM_Inputs_Channel_2F868086 IEL3403_812980A6.PM_Inputs_Channel_2
		{
			get
			{
				return PM_Inputs_Channel_2;
			}
		}

		IShadowPM_Inputs_Channel_2F868086 IShadowEL3403_812980A6.PM_Inputs_Channel_2
		{
			get
			{
				return PM_Inputs_Channel_2;
			}
		}

		PM_Inputs_Channel_2F868086 _PM_Inputs_Channel_3;
		public PM_Inputs_Channel_2F868086 PM_Inputs_Channel_3
		{
			get
			{
				return _PM_Inputs_Channel_3;
			}
		}

		IPM_Inputs_Channel_2F868086 IEL3403_812980A6.PM_Inputs_Channel_3
		{
			get
			{
				return PM_Inputs_Channel_3;
			}
		}

		IShadowPM_Inputs_Channel_2F868086 IShadowEL3403_812980A6.PM_Inputs_Channel_3
		{
			get
			{
				return PM_Inputs_Channel_3;
			}
		}

		PM_Status_data_2A9514CB _PM_Status_data;
		public PM_Status_data_2A9514CB PM_Status_data
		{
			get
			{
				return _PM_Status_data;
			}
		}

		IPM_Status_data_2A9514CB IEL3403_812980A6.PM_Status_data
		{
			get
			{
				return PM_Status_data;
			}
		}

		IShadowPM_Status_data_2A9514CB IShadowEL3403_812980A6.PM_Status_data
		{
			get
			{
				return PM_Status_data;
			}
		}

		PM_Outputs_Channel_E5FBDE30 _PM_Outputs_Channel_1;
		public PM_Outputs_Channel_E5FBDE30 PM_Outputs_Channel_1
		{
			get
			{
				return _PM_Outputs_Channel_1;
			}
		}

		IPM_Outputs_Channel_E5FBDE30 IEL3403_812980A6.PM_Outputs_Channel_1
		{
			get
			{
				return PM_Outputs_Channel_1;
			}
		}

		IShadowPM_Outputs_Channel_E5FBDE30 IShadowEL3403_812980A6.PM_Outputs_Channel_1
		{
			get
			{
				return PM_Outputs_Channel_1;
			}
		}

		PM_Outputs_Channel_E5FBDE30 _PM_Outputs_Channel_2;
		public PM_Outputs_Channel_E5FBDE30 PM_Outputs_Channel_2
		{
			get
			{
				return _PM_Outputs_Channel_2;
			}
		}

		IPM_Outputs_Channel_E5FBDE30 IEL3403_812980A6.PM_Outputs_Channel_2
		{
			get
			{
				return PM_Outputs_Channel_2;
			}
		}

		IShadowPM_Outputs_Channel_E5FBDE30 IShadowEL3403_812980A6.PM_Outputs_Channel_2
		{
			get
			{
				return PM_Outputs_Channel_2;
			}
		}

		PM_Outputs_Channel_E5FBDE30 _PM_Outputs_Channel_3;
		public PM_Outputs_Channel_E5FBDE30 PM_Outputs_Channel_3
		{
			get
			{
				return _PM_Outputs_Channel_3;
			}
		}

		IPM_Outputs_Channel_E5FBDE30 IEL3403_812980A6.PM_Outputs_Channel_3
		{
			get
			{
				return PM_Outputs_Channel_3;
			}
		}

		IShadowPM_Outputs_Channel_E5FBDE30 IShadowEL3403_812980A6.PM_Outputs_Channel_3
		{
			get
			{
				return PM_Outputs_Channel_3;
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

		TcoIo.IWcState_9091E0EB IEL3403_812980A6.WcState
		{
			get
			{
				return WcState;
			}
		}

		TcoIo.IShadowWcState_9091E0EB IShadowEL3403_812980A6.WcState
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

		TcoIo.IInfoData_23CBA837 IEL3403_812980A6.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		TcoIo.IShadowInfoData_23CBA837 IShadowEL3403_812980A6.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			PM_Inputs_Channel_1.LazyOnlineToShadow();
			PM_Inputs_Channel_2.LazyOnlineToShadow();
			PM_Inputs_Channel_3.LazyOnlineToShadow();
			PM_Status_data.LazyOnlineToShadow();
			PM_Outputs_Channel_1.LazyOnlineToShadow();
			PM_Outputs_Channel_2.LazyOnlineToShadow();
			PM_Outputs_Channel_3.LazyOnlineToShadow();
			WcState.LazyOnlineToShadow();
			InfoData.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			PM_Inputs_Channel_1.LazyShadowToOnline();
			PM_Inputs_Channel_2.LazyShadowToOnline();
			PM_Inputs_Channel_3.LazyShadowToOnline();
			PM_Status_data.LazyShadowToOnline();
			PM_Outputs_Channel_1.LazyShadowToOnline();
			PM_Outputs_Channel_2.LazyShadowToOnline();
			PM_Outputs_Channel_3.LazyShadowToOnline();
			WcState.LazyShadowToOnline();
			InfoData.LazyShadowToOnline();
		}

		public new PlainEL3403_812980A6 CreatePlainerType()
		{
			var cloned = new PlainEL3403_812980A6();
			base.CreatePlainerType(cloned);
			cloned.PM_Inputs_Channel_1 = PM_Inputs_Channel_1.CreatePlainerType();
			cloned.PM_Inputs_Channel_2 = PM_Inputs_Channel_2.CreatePlainerType();
			cloned.PM_Inputs_Channel_3 = PM_Inputs_Channel_3.CreatePlainerType();
			cloned.PM_Status_data = PM_Status_data.CreatePlainerType();
			cloned.PM_Outputs_Channel_1 = PM_Outputs_Channel_1.CreatePlainerType();
			cloned.PM_Outputs_Channel_2 = PM_Outputs_Channel_2.CreatePlainerType();
			cloned.PM_Outputs_Channel_3 = PM_Outputs_Channel_3.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		protected PlainEL3403_812980A6 CreatePlainerType(PlainEL3403_812980A6 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.PM_Inputs_Channel_1 = PM_Inputs_Channel_1.CreatePlainerType();
			cloned.PM_Inputs_Channel_2 = PM_Inputs_Channel_2.CreatePlainerType();
			cloned.PM_Inputs_Channel_3 = PM_Inputs_Channel_3.CreatePlainerType();
			cloned.PM_Status_data = PM_Status_data.CreatePlainerType();
			cloned.PM_Outputs_Channel_1 = PM_Outputs_Channel_1.CreatePlainerType();
			cloned.PM_Outputs_Channel_2 = PM_Outputs_Channel_2.CreatePlainerType();
			cloned.PM_Outputs_Channel_3 = PM_Outputs_Channel_3.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainEL3403_812980A6 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainEL3403_812980A6 source)
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

		public void FlushOnlineToPlain(Plc1.PlainEL3403_812980A6 source)
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

		public EL3403_812980A6(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_PM_Inputs_Channel_1 = new PM_Inputs_Channel_2F868086(this, "PM_Inputs_Channel_1", "PM_Inputs_Channel_1");
			_PM_Inputs_Channel_1.AttributeName = "PM_Inputs_Channel_1";
			_PM_Inputs_Channel_2 = new PM_Inputs_Channel_2F868086(this, "PM_Inputs_Channel_2", "PM_Inputs_Channel_2");
			_PM_Inputs_Channel_2.AttributeName = "PM_Inputs_Channel_2";
			_PM_Inputs_Channel_3 = new PM_Inputs_Channel_2F868086(this, "PM_Inputs_Channel_3", "PM_Inputs_Channel_3");
			_PM_Inputs_Channel_3.AttributeName = "PM_Inputs_Channel_3";
			_PM_Status_data = new PM_Status_data_2A9514CB(this, "PM_Status_data", "PM_Status_data");
			_PM_Status_data.AttributeName = "PM_Status_data";
			_PM_Outputs_Channel_1 = new PM_Outputs_Channel_E5FBDE30(this, "PM_Outputs_Channel_1", "PM_Outputs_Channel_1");
			_PM_Outputs_Channel_1.AttributeName = "PM_Outputs_Channel_1";
			_PM_Outputs_Channel_2 = new PM_Outputs_Channel_E5FBDE30(this, "PM_Outputs_Channel_2", "PM_Outputs_Channel_2");
			_PM_Outputs_Channel_2.AttributeName = "PM_Outputs_Channel_2";
			_PM_Outputs_Channel_3 = new PM_Outputs_Channel_E5FBDE30(this, "PM_Outputs_Channel_3", "PM_Outputs_Channel_3");
			_PM_Outputs_Channel_3.AttributeName = "PM_Outputs_Channel_3";
			_WcState = new TcoIo.WcState_9091E0EB(this, "WcState", "WcState");
			_WcState.AttributeName = "WcState";
			_InfoData = new TcoIo.InfoData_23CBA837(this, "InfoData", "InfoData");
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL3403-0000-0023";
			AttributeDescription = "EL3403 3Ch. Power Measuring";
			AttributePhysics = "KK";
			AttributeId = "PM_Inputs_Channel_1AT %I*PM_Inputs_Channel_2F86808618PM_Inputs_Channel_2AT %I*PM_Inputs_Channel_2F86808618PM_Inputs_Channel_3AT %I*PM_Inputs_Channel_2F86808618PM_Status_dataAT %I*PM_Status_data_2A9514CB4PM_Outputs_Channel_1AT %Q*PM_Outputs_Channel_E5FBDE301PM_Outputs_Channel_2AT %Q*PM_Outputs_Channel_E5FBDE301PM_Outputs_Channel_3AT %Q*PM_Outputs_Channel_E5FBDE301WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_23CBA8372";
			AttributeCRC = "2166980774";
			AttributeSize = "65";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public EL3403_812980A6(): base ()
		{
			PexPreConstructorParameterless();
			_PM_Inputs_Channel_1 = new PM_Inputs_Channel_2F868086();
			_PM_Inputs_Channel_1.AttributeName = "PM_Inputs_Channel_1";
			_PM_Inputs_Channel_2 = new PM_Inputs_Channel_2F868086();
			_PM_Inputs_Channel_2.AttributeName = "PM_Inputs_Channel_2";
			_PM_Inputs_Channel_3 = new PM_Inputs_Channel_2F868086();
			_PM_Inputs_Channel_3.AttributeName = "PM_Inputs_Channel_3";
			_PM_Status_data = new PM_Status_data_2A9514CB();
			_PM_Status_data.AttributeName = "PM_Status_data";
			_PM_Outputs_Channel_1 = new PM_Outputs_Channel_E5FBDE30();
			_PM_Outputs_Channel_1.AttributeName = "PM_Outputs_Channel_1";
			_PM_Outputs_Channel_2 = new PM_Outputs_Channel_E5FBDE30();
			_PM_Outputs_Channel_2.AttributeName = "PM_Outputs_Channel_2";
			_PM_Outputs_Channel_3 = new PM_Outputs_Channel_E5FBDE30();
			_PM_Outputs_Channel_3.AttributeName = "PM_Outputs_Channel_3";
			_WcState = new TcoIo.WcState_9091E0EB();
			_WcState.AttributeName = "WcState";
			_InfoData = new TcoIo.InfoData_23CBA837();
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL3403-0000-0023";
			AttributeDescription = "EL3403 3Ch. Power Measuring";
			AttributePhysics = "KK";
			AttributeId = "PM_Inputs_Channel_1AT %I*PM_Inputs_Channel_2F86808618PM_Inputs_Channel_2AT %I*PM_Inputs_Channel_2F86808618PM_Inputs_Channel_3AT %I*PM_Inputs_Channel_2F86808618PM_Status_dataAT %I*PM_Status_data_2A9514CB4PM_Outputs_Channel_1AT %Q*PM_Outputs_Channel_E5FBDE301PM_Outputs_Channel_2AT %Q*PM_Outputs_Channel_E5FBDE301PM_Outputs_Channel_3AT %Q*PM_Outputs_Channel_E5FBDE301WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_23CBA8372";
			AttributeCRC = "2166980774";
			AttributeSize = "65";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL3403_812980A6
	{
		public void CopyPlainToCyclic(Plc1.EL3403_812980A6 target)
		{
			base.CopyPlainToCyclic(target);
			PM_Inputs_Channel_1.CopyPlainToCyclic(target.PM_Inputs_Channel_1);
			PM_Inputs_Channel_2.CopyPlainToCyclic(target.PM_Inputs_Channel_2);
			PM_Inputs_Channel_3.CopyPlainToCyclic(target.PM_Inputs_Channel_3);
			PM_Status_data.CopyPlainToCyclic(target.PM_Status_data);
			PM_Outputs_Channel_1.CopyPlainToCyclic(target.PM_Outputs_Channel_1);
			PM_Outputs_Channel_2.CopyPlainToCyclic(target.PM_Outputs_Channel_2);
			PM_Outputs_Channel_3.CopyPlainToCyclic(target.PM_Outputs_Channel_3);
			WcState.CopyPlainToCyclic(target.WcState);
			InfoData.CopyPlainToCyclic(target.InfoData);
		}

		public void CopyPlainToCyclic(Plc1.IEL3403_812980A6 target)
		{
			this.CopyPlainToCyclic((Plc1.EL3403_812980A6)target);
		}

		public void CopyPlainToShadow(Plc1.EL3403_812980A6 target)
		{
			base.CopyPlainToShadow(target);
			PM_Inputs_Channel_1.CopyPlainToShadow(target.PM_Inputs_Channel_1);
			PM_Inputs_Channel_2.CopyPlainToShadow(target.PM_Inputs_Channel_2);
			PM_Inputs_Channel_3.CopyPlainToShadow(target.PM_Inputs_Channel_3);
			PM_Status_data.CopyPlainToShadow(target.PM_Status_data);
			PM_Outputs_Channel_1.CopyPlainToShadow(target.PM_Outputs_Channel_1);
			PM_Outputs_Channel_2.CopyPlainToShadow(target.PM_Outputs_Channel_2);
			PM_Outputs_Channel_3.CopyPlainToShadow(target.PM_Outputs_Channel_3);
			WcState.CopyPlainToShadow(target.WcState);
			InfoData.CopyPlainToShadow(target.InfoData);
		}

		public void CopyPlainToShadow(Plc1.IShadowEL3403_812980A6 target)
		{
			this.CopyPlainToShadow((Plc1.EL3403_812980A6)target);
		}

		public void CopyCyclicToPlain(Plc1.EL3403_812980A6 source)
		{
			base.CopyCyclicToPlain(source);
			PM_Inputs_Channel_1.CopyCyclicToPlain(source.PM_Inputs_Channel_1);
			PM_Inputs_Channel_2.CopyCyclicToPlain(source.PM_Inputs_Channel_2);
			PM_Inputs_Channel_3.CopyCyclicToPlain(source.PM_Inputs_Channel_3);
			PM_Status_data.CopyCyclicToPlain(source.PM_Status_data);
			PM_Outputs_Channel_1.CopyCyclicToPlain(source.PM_Outputs_Channel_1);
			PM_Outputs_Channel_2.CopyCyclicToPlain(source.PM_Outputs_Channel_2);
			PM_Outputs_Channel_3.CopyCyclicToPlain(source.PM_Outputs_Channel_3);
			WcState.CopyCyclicToPlain(source.WcState);
			InfoData.CopyCyclicToPlain(source.InfoData);
		}

		public void CopyCyclicToPlain(Plc1.IEL3403_812980A6 source)
		{
			this.CopyCyclicToPlain((Plc1.EL3403_812980A6)source);
		}

		public void CopyShadowToPlain(Plc1.EL3403_812980A6 source)
		{
			base.CopyShadowToPlain(source);
			PM_Inputs_Channel_1.CopyShadowToPlain(source.PM_Inputs_Channel_1);
			PM_Inputs_Channel_2.CopyShadowToPlain(source.PM_Inputs_Channel_2);
			PM_Inputs_Channel_3.CopyShadowToPlain(source.PM_Inputs_Channel_3);
			PM_Status_data.CopyShadowToPlain(source.PM_Status_data);
			PM_Outputs_Channel_1.CopyShadowToPlain(source.PM_Outputs_Channel_1);
			PM_Outputs_Channel_2.CopyShadowToPlain(source.PM_Outputs_Channel_2);
			PM_Outputs_Channel_3.CopyShadowToPlain(source.PM_Outputs_Channel_3);
			WcState.CopyShadowToPlain(source.WcState);
			InfoData.CopyShadowToPlain(source.InfoData);
		}

		public void CopyShadowToPlain(Plc1.IShadowEL3403_812980A6 source)
		{
			this.CopyShadowToPlain((Plc1.EL3403_812980A6)source);
		}
	}
}