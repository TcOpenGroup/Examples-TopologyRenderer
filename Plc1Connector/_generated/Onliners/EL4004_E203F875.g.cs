using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty VendorId \"#x00000002\" } {attribute addProperty BoxType \"EL4004-0000-0020\" } {attribute addProperty Description \"EL4004 4Ch. Ana. Output 0-10V, 12bit\" } {attribute addProperty Physics \"KK\" } {attribute addProperty Id \"AO_Outputs_Channel_1AT %Q*AO_Output_Channel_BA7EBB7C2AO_Outputs_Channel_2AT %Q*AO_Output_Channel_BA7EBB7C2AO_Outputs_Channel_3AT %Q*AO_Output_Channel_BA7EBB7C2AO_Outputs_Channel_4AT %Q*AO_Output_Channel_BA7EBB7C2WcStateAT %I*WcState_0B2B16F91InfoDataAT %I*InfoData_23CBA8372\" } {attribute addProperty CRC \"3791911029\" } {attribute addProperty Size \"11\" } {attribute addProperty Name \"\" }", "EL4004_E203F875", "Plc1", TypeComplexityEnum.Complex)]
	public partial class EL4004_E203F875 : TcoIo.EtcSlaveTerminalBase_947E5A46, Vortex.Connector.IVortexObject, IEL4004_E203F875, IShadowEL4004_E203F875, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		AO_Output_Channel_BA7EBB7C _AO_Outputs_Channel_1;
		public AO_Output_Channel_BA7EBB7C AO_Outputs_Channel_1
		{
			get
			{
				return _AO_Outputs_Channel_1;
			}
		}

		IAO_Output_Channel_BA7EBB7C IEL4004_E203F875.AO_Outputs_Channel_1
		{
			get
			{
				return AO_Outputs_Channel_1;
			}
		}

		IShadowAO_Output_Channel_BA7EBB7C IShadowEL4004_E203F875.AO_Outputs_Channel_1
		{
			get
			{
				return AO_Outputs_Channel_1;
			}
		}

		AO_Output_Channel_BA7EBB7C _AO_Outputs_Channel_2;
		public AO_Output_Channel_BA7EBB7C AO_Outputs_Channel_2
		{
			get
			{
				return _AO_Outputs_Channel_2;
			}
		}

		IAO_Output_Channel_BA7EBB7C IEL4004_E203F875.AO_Outputs_Channel_2
		{
			get
			{
				return AO_Outputs_Channel_2;
			}
		}

		IShadowAO_Output_Channel_BA7EBB7C IShadowEL4004_E203F875.AO_Outputs_Channel_2
		{
			get
			{
				return AO_Outputs_Channel_2;
			}
		}

		AO_Output_Channel_BA7EBB7C _AO_Outputs_Channel_3;
		public AO_Output_Channel_BA7EBB7C AO_Outputs_Channel_3
		{
			get
			{
				return _AO_Outputs_Channel_3;
			}
		}

		IAO_Output_Channel_BA7EBB7C IEL4004_E203F875.AO_Outputs_Channel_3
		{
			get
			{
				return AO_Outputs_Channel_3;
			}
		}

		IShadowAO_Output_Channel_BA7EBB7C IShadowEL4004_E203F875.AO_Outputs_Channel_3
		{
			get
			{
				return AO_Outputs_Channel_3;
			}
		}

		AO_Output_Channel_BA7EBB7C _AO_Outputs_Channel_4;
		public AO_Output_Channel_BA7EBB7C AO_Outputs_Channel_4
		{
			get
			{
				return _AO_Outputs_Channel_4;
			}
		}

		IAO_Output_Channel_BA7EBB7C IEL4004_E203F875.AO_Outputs_Channel_4
		{
			get
			{
				return AO_Outputs_Channel_4;
			}
		}

		IShadowAO_Output_Channel_BA7EBB7C IShadowEL4004_E203F875.AO_Outputs_Channel_4
		{
			get
			{
				return AO_Outputs_Channel_4;
			}
		}

		TcoIo.WcState_0B2B16F9 _WcState;
		public TcoIo.WcState_0B2B16F9 WcState
		{
			get
			{
				return _WcState;
			}
		}

		TcoIo.IWcState_0B2B16F9 IEL4004_E203F875.WcState
		{
			get
			{
				return WcState;
			}
		}

		TcoIo.IShadowWcState_0B2B16F9 IShadowEL4004_E203F875.WcState
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

		TcoIo.IInfoData_23CBA837 IEL4004_E203F875.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		TcoIo.IShadowInfoData_23CBA837 IShadowEL4004_E203F875.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			AO_Outputs_Channel_1.LazyOnlineToShadow();
			AO_Outputs_Channel_2.LazyOnlineToShadow();
			AO_Outputs_Channel_3.LazyOnlineToShadow();
			AO_Outputs_Channel_4.LazyOnlineToShadow();
			WcState.LazyOnlineToShadow();
			InfoData.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			AO_Outputs_Channel_1.LazyShadowToOnline();
			AO_Outputs_Channel_2.LazyShadowToOnline();
			AO_Outputs_Channel_3.LazyShadowToOnline();
			AO_Outputs_Channel_4.LazyShadowToOnline();
			WcState.LazyShadowToOnline();
			InfoData.LazyShadowToOnline();
		}

		public new PlainEL4004_E203F875 CreatePlainerType()
		{
			var cloned = new PlainEL4004_E203F875();
			base.CreatePlainerType(cloned);
			cloned.AO_Outputs_Channel_1 = AO_Outputs_Channel_1.CreatePlainerType();
			cloned.AO_Outputs_Channel_2 = AO_Outputs_Channel_2.CreatePlainerType();
			cloned.AO_Outputs_Channel_3 = AO_Outputs_Channel_3.CreatePlainerType();
			cloned.AO_Outputs_Channel_4 = AO_Outputs_Channel_4.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		protected PlainEL4004_E203F875 CreatePlainerType(PlainEL4004_E203F875 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.AO_Outputs_Channel_1 = AO_Outputs_Channel_1.CreatePlainerType();
			cloned.AO_Outputs_Channel_2 = AO_Outputs_Channel_2.CreatePlainerType();
			cloned.AO_Outputs_Channel_3 = AO_Outputs_Channel_3.CreatePlainerType();
			cloned.AO_Outputs_Channel_4 = AO_Outputs_Channel_4.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainEL4004_E203F875 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainEL4004_E203F875 source)
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

		public void FlushOnlineToPlain(Plc1.PlainEL4004_E203F875 source)
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

		public EL4004_E203F875(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_AO_Outputs_Channel_1 = new AO_Output_Channel_BA7EBB7C(this, "AO_Outputs_Channel_1", "AO_Outputs_Channel_1");
			_AO_Outputs_Channel_1.AttributeName = "AO_Outputs_Channel_1";
			_AO_Outputs_Channel_2 = new AO_Output_Channel_BA7EBB7C(this, "AO_Outputs_Channel_2", "AO_Outputs_Channel_2");
			_AO_Outputs_Channel_2.AttributeName = "AO_Outputs_Channel_2";
			_AO_Outputs_Channel_3 = new AO_Output_Channel_BA7EBB7C(this, "AO_Outputs_Channel_3", "AO_Outputs_Channel_3");
			_AO_Outputs_Channel_3.AttributeName = "AO_Outputs_Channel_3";
			_AO_Outputs_Channel_4 = new AO_Output_Channel_BA7EBB7C(this, "AO_Outputs_Channel_4", "AO_Outputs_Channel_4");
			_AO_Outputs_Channel_4.AttributeName = "AO_Outputs_Channel_4";
			_WcState = new TcoIo.WcState_0B2B16F9(this, "WcState", "WcState");
			_WcState.AttributeName = "WcState";
			_InfoData = new TcoIo.InfoData_23CBA837(this, "InfoData", "InfoData");
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL4004-0000-0020";
			AttributeDescription = "EL4004 4Ch. Ana. Output 0-10V, 12bit";
			AttributePhysics = "KK";
			AttributeId = "AO_Outputs_Channel_1AT %Q*AO_Output_Channel_BA7EBB7C2AO_Outputs_Channel_2AT %Q*AO_Output_Channel_BA7EBB7C2AO_Outputs_Channel_3AT %Q*AO_Output_Channel_BA7EBB7C2AO_Outputs_Channel_4AT %Q*AO_Output_Channel_BA7EBB7C2WcStateAT %I*WcState_0B2B16F91InfoDataAT %I*InfoData_23CBA8372";
			AttributeCRC = "3791911029";
			AttributeSize = "11";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public EL4004_E203F875(): base ()
		{
			PexPreConstructorParameterless();
			_AO_Outputs_Channel_1 = new AO_Output_Channel_BA7EBB7C();
			_AO_Outputs_Channel_1.AttributeName = "AO_Outputs_Channel_1";
			_AO_Outputs_Channel_2 = new AO_Output_Channel_BA7EBB7C();
			_AO_Outputs_Channel_2.AttributeName = "AO_Outputs_Channel_2";
			_AO_Outputs_Channel_3 = new AO_Output_Channel_BA7EBB7C();
			_AO_Outputs_Channel_3.AttributeName = "AO_Outputs_Channel_3";
			_AO_Outputs_Channel_4 = new AO_Output_Channel_BA7EBB7C();
			_AO_Outputs_Channel_4.AttributeName = "AO_Outputs_Channel_4";
			_WcState = new TcoIo.WcState_0B2B16F9();
			_WcState.AttributeName = "WcState";
			_InfoData = new TcoIo.InfoData_23CBA837();
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL4004-0000-0020";
			AttributeDescription = "EL4004 4Ch. Ana. Output 0-10V, 12bit";
			AttributePhysics = "KK";
			AttributeId = "AO_Outputs_Channel_1AT %Q*AO_Output_Channel_BA7EBB7C2AO_Outputs_Channel_2AT %Q*AO_Output_Channel_BA7EBB7C2AO_Outputs_Channel_3AT %Q*AO_Output_Channel_BA7EBB7C2AO_Outputs_Channel_4AT %Q*AO_Output_Channel_BA7EBB7C2WcStateAT %I*WcState_0B2B16F91InfoDataAT %I*InfoData_23CBA8372";
			AttributeCRC = "3791911029";
			AttributeSize = "11";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL4004_E203F875
	{
		public void CopyPlainToCyclic(Plc1.EL4004_E203F875 target)
		{
			base.CopyPlainToCyclic(target);
			AO_Outputs_Channel_1.CopyPlainToCyclic(target.AO_Outputs_Channel_1);
			AO_Outputs_Channel_2.CopyPlainToCyclic(target.AO_Outputs_Channel_2);
			AO_Outputs_Channel_3.CopyPlainToCyclic(target.AO_Outputs_Channel_3);
			AO_Outputs_Channel_4.CopyPlainToCyclic(target.AO_Outputs_Channel_4);
			WcState.CopyPlainToCyclic(target.WcState);
			InfoData.CopyPlainToCyclic(target.InfoData);
		}

		public void CopyPlainToCyclic(Plc1.IEL4004_E203F875 target)
		{
			this.CopyPlainToCyclic((Plc1.EL4004_E203F875)target);
		}

		public void CopyPlainToShadow(Plc1.EL4004_E203F875 target)
		{
			base.CopyPlainToShadow(target);
			AO_Outputs_Channel_1.CopyPlainToShadow(target.AO_Outputs_Channel_1);
			AO_Outputs_Channel_2.CopyPlainToShadow(target.AO_Outputs_Channel_2);
			AO_Outputs_Channel_3.CopyPlainToShadow(target.AO_Outputs_Channel_3);
			AO_Outputs_Channel_4.CopyPlainToShadow(target.AO_Outputs_Channel_4);
			WcState.CopyPlainToShadow(target.WcState);
			InfoData.CopyPlainToShadow(target.InfoData);
		}

		public void CopyPlainToShadow(Plc1.IShadowEL4004_E203F875 target)
		{
			this.CopyPlainToShadow((Plc1.EL4004_E203F875)target);
		}

		public void CopyCyclicToPlain(Plc1.EL4004_E203F875 source)
		{
			base.CopyCyclicToPlain(source);
			AO_Outputs_Channel_1.CopyCyclicToPlain(source.AO_Outputs_Channel_1);
			AO_Outputs_Channel_2.CopyCyclicToPlain(source.AO_Outputs_Channel_2);
			AO_Outputs_Channel_3.CopyCyclicToPlain(source.AO_Outputs_Channel_3);
			AO_Outputs_Channel_4.CopyCyclicToPlain(source.AO_Outputs_Channel_4);
			WcState.CopyCyclicToPlain(source.WcState);
			InfoData.CopyCyclicToPlain(source.InfoData);
		}

		public void CopyCyclicToPlain(Plc1.IEL4004_E203F875 source)
		{
			this.CopyCyclicToPlain((Plc1.EL4004_E203F875)source);
		}

		public void CopyShadowToPlain(Plc1.EL4004_E203F875 source)
		{
			base.CopyShadowToPlain(source);
			AO_Outputs_Channel_1.CopyShadowToPlain(source.AO_Outputs_Channel_1);
			AO_Outputs_Channel_2.CopyShadowToPlain(source.AO_Outputs_Channel_2);
			AO_Outputs_Channel_3.CopyShadowToPlain(source.AO_Outputs_Channel_3);
			AO_Outputs_Channel_4.CopyShadowToPlain(source.AO_Outputs_Channel_4);
			WcState.CopyShadowToPlain(source.WcState);
			InfoData.CopyShadowToPlain(source.InfoData);
		}

		public void CopyShadowToPlain(Plc1.IShadowEL4004_E203F875 source)
		{
			this.CopyShadowToPlain((Plc1.EL4004_E203F875)source);
		}
	}
}