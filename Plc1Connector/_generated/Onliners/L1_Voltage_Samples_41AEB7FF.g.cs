using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"U1_SamplesAT %I*U1_Samples_2549228720\" } {attribute addProperty CRC \"1101969407\" } {attribute addProperty Size \"20\" } {attribute addProperty Name \"\" }", "L1_Voltage_Samples_41AEB7FF", "Plc1", TypeComplexityEnum.Complex)]
	public partial class L1_Voltage_Samples_41AEB7FF : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IL1_Voltage_Samples_41AEB7FF, IShadowL1_Voltage_Samples_41AEB7FF, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		U1_Samples_25492287 _U1_Samples;
		[IoLinkable("Inputs")]
		public U1_Samples_25492287 U1_Samples
		{
			get
			{
				return _U1_Samples;
			}
		}

		[IoLinkable("Inputs")]
		IU1_Samples_25492287 IL1_Voltage_Samples_41AEB7FF.U1_Samples
		{
			get
			{
				return U1_Samples;
			}
		}

		[IoLinkable("Inputs")]
		IShadowU1_Samples_25492287 IShadowL1_Voltage_Samples_41AEB7FF.U1_Samples
		{
			get
			{
				return U1_Samples;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			U1_Samples.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			U1_Samples.LazyShadowToOnline();
		}

		public new PlainL1_Voltage_Samples_41AEB7FF CreatePlainerType()
		{
			var cloned = new PlainL1_Voltage_Samples_41AEB7FF();
			base.CreatePlainerType(cloned);
			cloned.U1_Samples = U1_Samples.CreatePlainerType();
			return cloned;
		}

		protected PlainL1_Voltage_Samples_41AEB7FF CreatePlainerType(PlainL1_Voltage_Samples_41AEB7FF cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.U1_Samples = U1_Samples.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainL1_Voltage_Samples_41AEB7FF source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainL1_Voltage_Samples_41AEB7FF source)
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

		public void FlushOnlineToPlain(Plc1.PlainL1_Voltage_Samples_41AEB7FF source)
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

		public L1_Voltage_Samples_41AEB7FF(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_U1_Samples = new U1_Samples_25492287(this, "U1_Samples", "U1_Samples");
			_U1_Samples.AttributeName = "U1_Samples";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "U1_SamplesAT %I*U1_Samples_2549228720";
			AttributeCRC = "1101969407";
			AttributeSize = "20";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public L1_Voltage_Samples_41AEB7FF(): base ()
		{
			PexPreConstructorParameterless();
			_U1_Samples = new U1_Samples_25492287();
			_U1_Samples.AttributeName = "U1_Samples";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "U1_SamplesAT %I*U1_Samples_2549228720";
			AttributeCRC = "1101969407";
			AttributeSize = "20";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL1_Voltage_Samples_41AEB7FF
	{
		public void CopyPlainToCyclic(Plc1.L1_Voltage_Samples_41AEB7FF target)
		{
			base.CopyPlainToCyclic(target);
			U1_Samples.CopyPlainToCyclic(target.U1_Samples);
		}

		public void CopyPlainToCyclic(Plc1.IL1_Voltage_Samples_41AEB7FF target)
		{
			this.CopyPlainToCyclic((Plc1.L1_Voltage_Samples_41AEB7FF)target);
		}

		public void CopyPlainToShadow(Plc1.L1_Voltage_Samples_41AEB7FF target)
		{
			base.CopyPlainToShadow(target);
			U1_Samples.CopyPlainToShadow(target.U1_Samples);
		}

		public void CopyPlainToShadow(Plc1.IShadowL1_Voltage_Samples_41AEB7FF target)
		{
			this.CopyPlainToShadow((Plc1.L1_Voltage_Samples_41AEB7FF)target);
		}

		public void CopyCyclicToPlain(Plc1.L1_Voltage_Samples_41AEB7FF source)
		{
			base.CopyCyclicToPlain(source);
			U1_Samples.CopyCyclicToPlain(source.U1_Samples);
		}

		public void CopyCyclicToPlain(Plc1.IL1_Voltage_Samples_41AEB7FF source)
		{
			this.CopyCyclicToPlain((Plc1.L1_Voltage_Samples_41AEB7FF)source);
		}

		public void CopyShadowToPlain(Plc1.L1_Voltage_Samples_41AEB7FF source)
		{
			base.CopyShadowToPlain(source);
			U1_Samples.CopyShadowToPlain(source.U1_Samples);
		}

		public void CopyShadowToPlain(Plc1.IShadowL1_Voltage_Samples_41AEB7FF source)
		{
			this.CopyShadowToPlain((Plc1.L1_Voltage_Samples_41AEB7FF)source);
		}
	}
}