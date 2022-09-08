using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL6002-0000-0019\" } {attribute addProperty Id \"CtrlAT %Q*Ctrl_1EFB4D3B5Data_OutAT %Q*ARRAY[0..21] OF USINT22\" } {attribute addProperty CRC \"3494673196\" } {attribute addProperty Size \"27\" } {attribute addProperty Name \"\" }", "COM_RxPDO_Map_Outputs_Channel_EADA2E0D", "Plc1", TypeComplexityEnum.Complex)]
	public partial class COM_RxPDO_Map_Outputs_Channel_EADA2E0D : TcoIo.OutputBase_10CEE7DE, Vortex.Connector.IVortexObject, ICOM_RxPDO_Map_Outputs_Channel_EADA2E0D, IShadowCOM_RxPDO_Map_Outputs_Channel_EADA2E0D, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Ctrl_1EFB4D3B _Ctrl;
		[IoLinkable("Outputs")]
		public Ctrl_1EFB4D3B Ctrl
		{
			get
			{
				return _Ctrl;
			}
		}

		[IoLinkable("Outputs")]
		ICtrl_1EFB4D3B ICOM_RxPDO_Map_Outputs_Channel_EADA2E0D.Ctrl
		{
			get
			{
				return Ctrl;
			}
		}

		[IoLinkable("Outputs")]
		IShadowCtrl_1EFB4D3B IShadowCOM_RxPDO_Map_Outputs_Channel_EADA2E0D.Ctrl
		{
			get
			{
				return Ctrl;
			}
		}

		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerUSInt[] Data_Out
		{
			get;
			set;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineUSInt[] ICOM_RxPDO_Map_Outputs_Channel_EADA2E0D.Data_Out
		{
			get
			{
				return Data_Out;
			}

			set
			{
				Data_Out = (Vortex.Connector.ValueTypes.OnlinerUSInt[])value;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt[] IShadowCOM_RxPDO_Map_Outputs_Channel_EADA2E0D.Data_Out
		{
			get
			{
				return Data_Out;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Ctrl.LazyOnlineToShadow();
			Vortex.Connector.BuilderHelpers.Arrays.CopyCyclicToShadowPrimitive<Vortex.Connector.ValueTypes.OnlinerUSInt>(Data_Out);
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Ctrl.LazyShadowToOnline();
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToCyclicPrimitive<Vortex.Connector.ValueTypes.OnlinerUSInt>(Data_Out);
		}

		public new PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D CreatePlainerType()
		{
			var cloned = new PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D();
			base.CreatePlainerType(cloned);
			cloned.Ctrl = Ctrl.CreatePlainerType();
			cloned.Data_Out = new System.Byte[22];
			return cloned;
		}

		protected PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D CreatePlainerType(PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Ctrl = Ctrl.CreatePlainerType();
			cloned.Data_Out = new System.Byte[22];
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D source)
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

		public void FlushOnlineToPlain(Plc1.PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D source)
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

		public COM_RxPDO_Map_Outputs_Channel_EADA2E0D(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Ctrl = new Ctrl_1EFB4D3B(this, "Ctrl", "Ctrl");
			_Ctrl.AttributeName = "Ctrl";
			Data_Out = new Vortex.Connector.ValueTypes.OnlinerUSInt[22];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(Data_Out, this, "Data_Out", "Data_Out", (p, rt, st) => @Connector.Online.Adapter.CreateUSINT(p, rt, st));
			AttributeBoxType = "EL6002-0000-0019";
			AttributeId = "CtrlAT %Q*Ctrl_1EFB4D3B5Data_OutAT %Q*ARRAY[0..21] OF USINT22";
			AttributeCRC = "3494673196";
			AttributeSize = "27";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public COM_RxPDO_Map_Outputs_Channel_EADA2E0D(): base ()
		{
			PexPreConstructorParameterless();
			_Ctrl = new Ctrl_1EFB4D3B();
			_Ctrl.AttributeName = "Ctrl";
			Data_Out = new Vortex.Connector.ValueTypes.OnlinerUSInt[22];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(Data_Out, () => Vortex.Connector.IConnectorFactory.CreateUSINT());
			AttributeBoxType = "EL6002-0000-0019";
			AttributeId = "CtrlAT %Q*Ctrl_1EFB4D3B5Data_OutAT %Q*ARRAY[0..21] OF USINT22";
			AttributeCRC = "3494673196";
			AttributeSize = "27";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainCOM_RxPDO_Map_Outputs_Channel_EADA2E0D
	{
		public void CopyPlainToCyclic(Plc1.COM_RxPDO_Map_Outputs_Channel_EADA2E0D target)
		{
			base.CopyPlainToCyclic(target);
			Ctrl.CopyPlainToCyclic(target.Ctrl);
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToOnline<System.Byte, Vortex.Connector.ValueTypes.OnlinerUSInt>(Data_Out, target.Data_Out);
		}

		public void CopyPlainToCyclic(Plc1.ICOM_RxPDO_Map_Outputs_Channel_EADA2E0D target)
		{
			this.CopyPlainToCyclic((Plc1.COM_RxPDO_Map_Outputs_Channel_EADA2E0D)target);
		}

		public void CopyPlainToShadow(Plc1.COM_RxPDO_Map_Outputs_Channel_EADA2E0D target)
		{
			base.CopyPlainToShadow(target);
			Ctrl.CopyPlainToShadow(target.Ctrl);
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToShadow<System.Byte, Vortex.Connector.ValueTypes.OnlinerUSInt>(Data_Out, target.Data_Out);
		}

		public void CopyPlainToShadow(Plc1.IShadowCOM_RxPDO_Map_Outputs_Channel_EADA2E0D target)
		{
			this.CopyPlainToShadow((Plc1.COM_RxPDO_Map_Outputs_Channel_EADA2E0D)target);
		}

		public void CopyCyclicToPlain(Plc1.COM_RxPDO_Map_Outputs_Channel_EADA2E0D source)
		{
			base.CopyCyclicToPlain(source);
			Ctrl.CopyCyclicToPlain(source.Ctrl);
			Vortex.Connector.BuilderHelpers.Arrays.CopyOnlineToPlain<Vortex.Connector.ValueTypes.OnlinerUSInt, System.Byte>(source.Data_Out, Data_Out);
		}

		public void CopyCyclicToPlain(Plc1.ICOM_RxPDO_Map_Outputs_Channel_EADA2E0D source)
		{
			this.CopyCyclicToPlain((Plc1.COM_RxPDO_Map_Outputs_Channel_EADA2E0D)source);
		}

		public void CopyShadowToPlain(Plc1.COM_RxPDO_Map_Outputs_Channel_EADA2E0D source)
		{
			base.CopyShadowToPlain(source);
			Ctrl.CopyShadowToPlain(source.Ctrl);
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToPlain<Vortex.Connector.ValueTypes.OnlinerUSInt, System.Byte>(source.Data_Out, Data_Out);
		}

		public void CopyShadowToPlain(Plc1.IShadowCOM_RxPDO_Map_Outputs_Channel_EADA2E0D source)
		{
			this.CopyShadowToPlain((Plc1.COM_RxPDO_Map_Outputs_Channel_EADA2E0D)source);
		}
	}
}