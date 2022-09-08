using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"I2_SamplesAT %I*I2_Samples_2549228720\" } {attribute addProperty CRC \"2864058222\" } {attribute addProperty Size \"20\" } {attribute addProperty Name \"\" }", "L2_Current_Samples_AAB60F6E", "Plc1", TypeComplexityEnum.Complex)]
	public partial class L2_Current_Samples_AAB60F6E : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IL2_Current_Samples_AAB60F6E, IShadowL2_Current_Samples_AAB60F6E, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		I2_Samples_25492287 _I2_Samples;
		[IoLinkable("Inputs")]
		public I2_Samples_25492287 I2_Samples
		{
			get
			{
				return _I2_Samples;
			}
		}

		[IoLinkable("Inputs")]
		II2_Samples_25492287 IL2_Current_Samples_AAB60F6E.I2_Samples
		{
			get
			{
				return I2_Samples;
			}
		}

		[IoLinkable("Inputs")]
		IShadowI2_Samples_25492287 IShadowL2_Current_Samples_AAB60F6E.I2_Samples
		{
			get
			{
				return I2_Samples;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			I2_Samples.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			I2_Samples.LazyShadowToOnline();
		}

		public new PlainL2_Current_Samples_AAB60F6E CreatePlainerType()
		{
			var cloned = new PlainL2_Current_Samples_AAB60F6E();
			base.CreatePlainerType(cloned);
			cloned.I2_Samples = I2_Samples.CreatePlainerType();
			return cloned;
		}

		protected PlainL2_Current_Samples_AAB60F6E CreatePlainerType(PlainL2_Current_Samples_AAB60F6E cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.I2_Samples = I2_Samples.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainL2_Current_Samples_AAB60F6E source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainL2_Current_Samples_AAB60F6E source)
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

		public void FlushOnlineToPlain(Plc1.PlainL2_Current_Samples_AAB60F6E source)
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

		public L2_Current_Samples_AAB60F6E(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_I2_Samples = new I2_Samples_25492287(this, "I2_Samples", "I2_Samples");
			_I2_Samples.AttributeName = "I2_Samples";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "I2_SamplesAT %I*I2_Samples_2549228720";
			AttributeCRC = "2864058222";
			AttributeSize = "20";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public L2_Current_Samples_AAB60F6E(): base ()
		{
			PexPreConstructorParameterless();
			_I2_Samples = new I2_Samples_25492287();
			_I2_Samples.AttributeName = "I2_Samples";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "I2_SamplesAT %I*I2_Samples_2549228720";
			AttributeCRC = "2864058222";
			AttributeSize = "20";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL2_Current_Samples_AAB60F6E
	{
		public void CopyPlainToCyclic(Plc1.L2_Current_Samples_AAB60F6E target)
		{
			base.CopyPlainToCyclic(target);
			I2_Samples.CopyPlainToCyclic(target.I2_Samples);
		}

		public void CopyPlainToCyclic(Plc1.IL2_Current_Samples_AAB60F6E target)
		{
			this.CopyPlainToCyclic((Plc1.L2_Current_Samples_AAB60F6E)target);
		}

		public void CopyPlainToShadow(Plc1.L2_Current_Samples_AAB60F6E target)
		{
			base.CopyPlainToShadow(target);
			I2_Samples.CopyPlainToShadow(target.I2_Samples);
		}

		public void CopyPlainToShadow(Plc1.IShadowL2_Current_Samples_AAB60F6E target)
		{
			this.CopyPlainToShadow((Plc1.L2_Current_Samples_AAB60F6E)target);
		}

		public void CopyCyclicToPlain(Plc1.L2_Current_Samples_AAB60F6E source)
		{
			base.CopyCyclicToPlain(source);
			I2_Samples.CopyCyclicToPlain(source.I2_Samples);
		}

		public void CopyCyclicToPlain(Plc1.IL2_Current_Samples_AAB60F6E source)
		{
			this.CopyCyclicToPlain((Plc1.L2_Current_Samples_AAB60F6E)source);
		}

		public void CopyShadowToPlain(Plc1.L2_Current_Samples_AAB60F6E source)
		{
			base.CopyShadowToPlain(source);
			I2_Samples.CopyShadowToPlain(source.I2_Samples);
		}

		public void CopyShadowToPlain(Plc1.IShadowL2_Current_Samples_AAB60F6E source)
		{
			this.CopyShadowToPlain((Plc1.L2_Current_Samples_AAB60F6E)source);
		}
	}
}