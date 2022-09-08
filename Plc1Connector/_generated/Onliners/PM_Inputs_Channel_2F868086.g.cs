using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3403-0000-0023\" } {attribute addProperty Id \"TxPDO_ToggleAT %I*BOOL1CurrentAT %I*DINT4VoltageAT %I*DINT4Active_powerAT %I*DINT4IndexAT %I*USINT1Variant_valueAT %I*DINT4\" } {attribute addProperty CRC \"797343878\" } {attribute addProperty Size \"18\" } {attribute addProperty Name \"\" }", "PM_Inputs_Channel_2F868086", "Plc1", TypeComplexityEnum.Complex)]
	public partial class PM_Inputs_Channel_2F868086 : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IPM_Inputs_Channel_2F868086, IShadowPM_Inputs_Channel_2F868086, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerBool _TxPDO_Toggle;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool TxPDO_Toggle
		{
			get
			{
				return _TxPDO_Toggle;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IPM_Inputs_Channel_2F868086.TxPDO_Toggle
		{
			get
			{
				return TxPDO_Toggle;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowPM_Inputs_Channel_2F868086.TxPDO_Toggle
		{
			get
			{
				return TxPDO_Toggle;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDInt _Current;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerDInt Current
		{
			get
			{
				return _Current;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineDInt IPM_Inputs_Channel_2F868086.Current
		{
			get
			{
				return Current;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowPM_Inputs_Channel_2F868086.Current
		{
			get
			{
				return Current;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDInt _Voltage;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerDInt Voltage
		{
			get
			{
				return _Voltage;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineDInt IPM_Inputs_Channel_2F868086.Voltage
		{
			get
			{
				return Voltage;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowPM_Inputs_Channel_2F868086.Voltage
		{
			get
			{
				return Voltage;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDInt _Active_power;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerDInt Active_power
		{
			get
			{
				return _Active_power;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineDInt IPM_Inputs_Channel_2F868086.Active_power
		{
			get
			{
				return Active_power;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowPM_Inputs_Channel_2F868086.Active_power
		{
			get
			{
				return Active_power;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUSInt _Index;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerUSInt Index
		{
			get
			{
				return _Index;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineUSInt IPM_Inputs_Channel_2F868086.Index
		{
			get
			{
				return Index;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt IShadowPM_Inputs_Channel_2F868086.Index
		{
			get
			{
				return Index;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDInt _Variant_value;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerDInt Variant_value
		{
			get
			{
				return _Variant_value;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineDInt IPM_Inputs_Channel_2F868086.Variant_value
		{
			get
			{
				return Variant_value;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowPM_Inputs_Channel_2F868086.Variant_value
		{
			get
			{
				return Variant_value;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			TxPDO_Toggle.Shadow = TxPDO_Toggle.LastValue;
			Current.Shadow = Current.LastValue;
			Voltage.Shadow = Voltage.LastValue;
			Active_power.Shadow = Active_power.LastValue;
			Index.Shadow = Index.LastValue;
			Variant_value.Shadow = Variant_value.LastValue;
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			TxPDO_Toggle.Cyclic = TxPDO_Toggle.Shadow;
			Current.Cyclic = Current.Shadow;
			Voltage.Cyclic = Voltage.Shadow;
			Active_power.Cyclic = Active_power.Shadow;
			Index.Cyclic = Index.Shadow;
			Variant_value.Cyclic = Variant_value.Shadow;
		}

		public new PlainPM_Inputs_Channel_2F868086 CreatePlainerType()
		{
			var cloned = new PlainPM_Inputs_Channel_2F868086();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainPM_Inputs_Channel_2F868086 CreatePlainerType(PlainPM_Inputs_Channel_2F868086 cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainPM_Inputs_Channel_2F868086 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainPM_Inputs_Channel_2F868086 source)
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

		public void FlushOnlineToPlain(Plc1.PlainPM_Inputs_Channel_2F868086 source)
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

		public PM_Inputs_Channel_2F868086(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_TxPDO_Toggle = @Connector.Online.Adapter.CreateBOOL(this, "TxPDO_Toggle", "TxPDO_Toggle");
			TxPDO_Toggle.AttributeName = "TxPDO_Toggle";
			_Current = @Connector.Online.Adapter.CreateDINT(this, "Current", "Current");
			Current.AttributeName = "Current";
			_Voltage = @Connector.Online.Adapter.CreateDINT(this, "Voltage", "Voltage");
			Voltage.AttributeName = "Voltage";
			_Active_power = @Connector.Online.Adapter.CreateDINT(this, "Active_power", "Active_power");
			Active_power.AttributeName = "Active_power";
			_Index = @Connector.Online.Adapter.CreateUSINT(this, "Index", "Index");
			Index.AttributeName = "Index";
			_Variant_value = @Connector.Online.Adapter.CreateDINT(this, "Variant_value", "Variant_value");
			Variant_value.AttributeName = "Variant_value";
			AttributeBoxType = "EL3403-0000-0023";
			AttributeId = "TxPDO_ToggleAT %I*BOOL1CurrentAT %I*DINT4VoltageAT %I*DINT4Active_powerAT %I*DINT4IndexAT %I*USINT1Variant_valueAT %I*DINT4";
			AttributeCRC = "797343878";
			AttributeSize = "18";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public PM_Inputs_Channel_2F868086(): base ()
		{
			PexPreConstructorParameterless();
			_TxPDO_Toggle = Vortex.Connector.IConnectorFactory.CreateBOOL();
			TxPDO_Toggle.AttributeName = "TxPDO_Toggle";
			_Current = Vortex.Connector.IConnectorFactory.CreateDINT();
			Current.AttributeName = "Current";
			_Voltage = Vortex.Connector.IConnectorFactory.CreateDINT();
			Voltage.AttributeName = "Voltage";
			_Active_power = Vortex.Connector.IConnectorFactory.CreateDINT();
			Active_power.AttributeName = "Active_power";
			_Index = Vortex.Connector.IConnectorFactory.CreateUSINT();
			Index.AttributeName = "Index";
			_Variant_value = Vortex.Connector.IConnectorFactory.CreateDINT();
			Variant_value.AttributeName = "Variant_value";
			AttributeBoxType = "EL3403-0000-0023";
			AttributeId = "TxPDO_ToggleAT %I*BOOL1CurrentAT %I*DINT4VoltageAT %I*DINT4Active_powerAT %I*DINT4IndexAT %I*USINT1Variant_valueAT %I*DINT4";
			AttributeCRC = "797343878";
			AttributeSize = "18";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainPM_Inputs_Channel_2F868086
	{
		public void CopyPlainToCyclic(Plc1.PM_Inputs_Channel_2F868086 target)
		{
			base.CopyPlainToCyclic(target);
			target.TxPDO_Toggle.Cyclic = TxPDO_Toggle;
			target.Current.Cyclic = Current;
			target.Voltage.Cyclic = Voltage;
			target.Active_power.Cyclic = Active_power;
			target.Index.Cyclic = Index;
			target.Variant_value.Cyclic = Variant_value;
		}

		public void CopyPlainToCyclic(Plc1.IPM_Inputs_Channel_2F868086 target)
		{
			this.CopyPlainToCyclic((Plc1.PM_Inputs_Channel_2F868086)target);
		}

		public void CopyPlainToShadow(Plc1.PM_Inputs_Channel_2F868086 target)
		{
			base.CopyPlainToShadow(target);
			target.TxPDO_Toggle.Shadow = TxPDO_Toggle;
			target.Current.Shadow = Current;
			target.Voltage.Shadow = Voltage;
			target.Active_power.Shadow = Active_power;
			target.Index.Shadow = Index;
			target.Variant_value.Shadow = Variant_value;
		}

		public void CopyPlainToShadow(Plc1.IShadowPM_Inputs_Channel_2F868086 target)
		{
			this.CopyPlainToShadow((Plc1.PM_Inputs_Channel_2F868086)target);
		}

		public void CopyCyclicToPlain(Plc1.PM_Inputs_Channel_2F868086 source)
		{
			base.CopyCyclicToPlain(source);
			TxPDO_Toggle = source.TxPDO_Toggle.LastValue;
			Current = source.Current.LastValue;
			Voltage = source.Voltage.LastValue;
			Active_power = source.Active_power.LastValue;
			Index = source.Index.LastValue;
			Variant_value = source.Variant_value.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.IPM_Inputs_Channel_2F868086 source)
		{
			this.CopyCyclicToPlain((Plc1.PM_Inputs_Channel_2F868086)source);
		}

		public void CopyShadowToPlain(Plc1.PM_Inputs_Channel_2F868086 source)
		{
			base.CopyShadowToPlain(source);
			TxPDO_Toggle = source.TxPDO_Toggle.Shadow;
			Current = source.Current.Shadow;
			Voltage = source.Voltage.Shadow;
			Active_power = source.Active_power.Shadow;
			Index = source.Index.Shadow;
			Variant_value = source.Variant_value.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowPM_Inputs_Channel_2F868086 source)
		{
			this.CopyShadowToPlain((Plc1.PM_Inputs_Channel_2F868086)source);
		}
	}
}