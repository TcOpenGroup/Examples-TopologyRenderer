using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL2258-0000-0017\" } {attribute addProperty Id \"CtrlAT %Q*Ctrl_77460BD36OutputsAT %Q*Outputs_A910484D10Output_event_timeAT %Q*ARRAY[0..9] OF UDINT40\" } {attribute addProperty CRC \"922776817\" } {attribute addProperty Size \"56\" } {attribute addProperty Name \"\" }", "MTO_Outputs_10x_Channel_A3C0C022", "Plc1", TypeComplexityEnum.Complex)]
	public partial class MTO_Outputs_10x_Channel_A3C0C022 : TcoIo.OutputBase_10CEE7DE, Vortex.Connector.IVortexObject, IMTO_Outputs_10x_Channel_A3C0C022, IShadowMTO_Outputs_10x_Channel_A3C0C022, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Ctrl_77460BD3 _Ctrl;
		[IoLinkable("Outputs")]
		public Ctrl_77460BD3 Ctrl
		{
			get
			{
				return _Ctrl;
			}
		}

		[IoLinkable("Outputs")]
		ICtrl_77460BD3 IMTO_Outputs_10x_Channel_A3C0C022.Ctrl
		{
			get
			{
				return Ctrl;
			}
		}

		[IoLinkable("Outputs")]
		IShadowCtrl_77460BD3 IShadowMTO_Outputs_10x_Channel_A3C0C022.Ctrl
		{
			get
			{
				return Ctrl;
			}
		}

		Outputs_A910484D _Outputs;
		[IoLinkable("Outputs")]
		public Outputs_A910484D Outputs
		{
			get
			{
				return _Outputs;
			}
		}

		[IoLinkable("Outputs")]
		IOutputs_A910484D IMTO_Outputs_10x_Channel_A3C0C022.Outputs
		{
			get
			{
				return Outputs;
			}
		}

		[IoLinkable("Outputs")]
		IShadowOutputs_A910484D IShadowMTO_Outputs_10x_Channel_A3C0C022.Outputs
		{
			get
			{
				return Outputs;
			}
		}

		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerUDInt[] Output_event_time
		{
			get;
			set;
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineUDInt[] IMTO_Outputs_10x_Channel_A3C0C022.Output_event_time
		{
			get
			{
				return Output_event_time;
			}

			set
			{
				Output_event_time = (Vortex.Connector.ValueTypes.OnlinerUDInt[])value;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt[] IShadowMTO_Outputs_10x_Channel_A3C0C022.Output_event_time
		{
			get
			{
				return Output_event_time;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Ctrl.LazyOnlineToShadow();
			Outputs.LazyOnlineToShadow();
			Vortex.Connector.BuilderHelpers.Arrays.CopyCyclicToShadowPrimitive<Vortex.Connector.ValueTypes.OnlinerUDInt>(Output_event_time);
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Ctrl.LazyShadowToOnline();
			Outputs.LazyShadowToOnline();
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToCyclicPrimitive<Vortex.Connector.ValueTypes.OnlinerUDInt>(Output_event_time);
		}

		public new PlainMTO_Outputs_10x_Channel_A3C0C022 CreatePlainerType()
		{
			var cloned = new PlainMTO_Outputs_10x_Channel_A3C0C022();
			base.CreatePlainerType(cloned);
			cloned.Ctrl = Ctrl.CreatePlainerType();
			cloned.Outputs = Outputs.CreatePlainerType();
			cloned.Output_event_time = new System.UInt32[10];
			return cloned;
		}

		protected PlainMTO_Outputs_10x_Channel_A3C0C022 CreatePlainerType(PlainMTO_Outputs_10x_Channel_A3C0C022 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Ctrl = Ctrl.CreatePlainerType();
			cloned.Outputs = Outputs.CreatePlainerType();
			cloned.Output_event_time = new System.UInt32[10];
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainMTO_Outputs_10x_Channel_A3C0C022 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainMTO_Outputs_10x_Channel_A3C0C022 source)
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

		public void FlushOnlineToPlain(Plc1.PlainMTO_Outputs_10x_Channel_A3C0C022 source)
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

		public MTO_Outputs_10x_Channel_A3C0C022(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Ctrl = new Ctrl_77460BD3(this, "Ctrl", "Ctrl");
			_Ctrl.AttributeName = "Ctrl";
			_Outputs = new Outputs_A910484D(this, "Outputs", "Outputs");
			_Outputs.AttributeName = "Outputs";
			Output_event_time = new Vortex.Connector.ValueTypes.OnlinerUDInt[10];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(Output_event_time, this, "Output_event_time", "Output_event_time", (p, rt, st) => @Connector.Online.Adapter.CreateUDINT(p, rt, st));
			AttributeBoxType = "EL2258-0000-0017";
			AttributeId = "CtrlAT %Q*Ctrl_77460BD36OutputsAT %Q*Outputs_A910484D10Output_event_timeAT %Q*ARRAY[0..9] OF UDINT40";
			AttributeCRC = "922776817";
			AttributeSize = "56";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public MTO_Outputs_10x_Channel_A3C0C022(): base ()
		{
			PexPreConstructorParameterless();
			_Ctrl = new Ctrl_77460BD3();
			_Ctrl.AttributeName = "Ctrl";
			_Outputs = new Outputs_A910484D();
			_Outputs.AttributeName = "Outputs";
			Output_event_time = new Vortex.Connector.ValueTypes.OnlinerUDInt[10];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(Output_event_time, () => Vortex.Connector.IConnectorFactory.CreateUDINT());
			AttributeBoxType = "EL2258-0000-0017";
			AttributeId = "CtrlAT %Q*Ctrl_77460BD36OutputsAT %Q*Outputs_A910484D10Output_event_timeAT %Q*ARRAY[0..9] OF UDINT40";
			AttributeCRC = "922776817";
			AttributeSize = "56";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMTO_Outputs_10x_Channel_A3C0C022
	{
		public void CopyPlainToCyclic(Plc1.MTO_Outputs_10x_Channel_A3C0C022 target)
		{
			base.CopyPlainToCyclic(target);
			Ctrl.CopyPlainToCyclic(target.Ctrl);
			Outputs.CopyPlainToCyclic(target.Outputs);
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToOnline<System.UInt32, Vortex.Connector.ValueTypes.OnlinerUDInt>(Output_event_time, target.Output_event_time);
		}

		public void CopyPlainToCyclic(Plc1.IMTO_Outputs_10x_Channel_A3C0C022 target)
		{
			this.CopyPlainToCyclic((Plc1.MTO_Outputs_10x_Channel_A3C0C022)target);
		}

		public void CopyPlainToShadow(Plc1.MTO_Outputs_10x_Channel_A3C0C022 target)
		{
			base.CopyPlainToShadow(target);
			Ctrl.CopyPlainToShadow(target.Ctrl);
			Outputs.CopyPlainToShadow(target.Outputs);
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToShadow<System.UInt32, Vortex.Connector.ValueTypes.OnlinerUDInt>(Output_event_time, target.Output_event_time);
		}

		public void CopyPlainToShadow(Plc1.IShadowMTO_Outputs_10x_Channel_A3C0C022 target)
		{
			this.CopyPlainToShadow((Plc1.MTO_Outputs_10x_Channel_A3C0C022)target);
		}

		public void CopyCyclicToPlain(Plc1.MTO_Outputs_10x_Channel_A3C0C022 source)
		{
			base.CopyCyclicToPlain(source);
			Ctrl.CopyCyclicToPlain(source.Ctrl);
			Outputs.CopyCyclicToPlain(source.Outputs);
			Vortex.Connector.BuilderHelpers.Arrays.CopyOnlineToPlain<Vortex.Connector.ValueTypes.OnlinerUDInt, System.UInt32>(source.Output_event_time, Output_event_time);
		}

		public void CopyCyclicToPlain(Plc1.IMTO_Outputs_10x_Channel_A3C0C022 source)
		{
			this.CopyCyclicToPlain((Plc1.MTO_Outputs_10x_Channel_A3C0C022)source);
		}

		public void CopyShadowToPlain(Plc1.MTO_Outputs_10x_Channel_A3C0C022 source)
		{
			base.CopyShadowToPlain(source);
			Ctrl.CopyShadowToPlain(source.Ctrl);
			Outputs.CopyShadowToPlain(source.Outputs);
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToPlain<Vortex.Connector.ValueTypes.OnlinerUDInt, System.UInt32>(source.Output_event_time, Output_event_time);
		}

		public void CopyShadowToPlain(Plc1.IShadowMTO_Outputs_10x_Channel_A3C0C022 source)
		{
			this.CopyShadowToPlain((Plc1.MTO_Outputs_10x_Channel_A3C0C022)source);
		}
	}
}