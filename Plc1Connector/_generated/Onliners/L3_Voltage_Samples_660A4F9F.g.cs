using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"U3_SamplesAT %I*U3_Samples_2549228720\" } {attribute addProperty CRC \"1711951775\" } {attribute addProperty Size \"20\" } {attribute addProperty Name \"\" }", "L3_Voltage_Samples_660A4F9F", "Plc1", TypeComplexityEnum.Complex)]
	public partial class L3_Voltage_Samples_660A4F9F : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IL3_Voltage_Samples_660A4F9F, IShadowL3_Voltage_Samples_660A4F9F, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		U3_Samples_25492287 _U3_Samples;
		[IoLinkable("Inputs")]
		public U3_Samples_25492287 U3_Samples
		{
			get
			{
				return _U3_Samples;
			}
		}

		[IoLinkable("Inputs")]
		IU3_Samples_25492287 IL3_Voltage_Samples_660A4F9F.U3_Samples
		{
			get
			{
				return U3_Samples;
			}
		}

		[IoLinkable("Inputs")]
		IShadowU3_Samples_25492287 IShadowL3_Voltage_Samples_660A4F9F.U3_Samples
		{
			get
			{
				return U3_Samples;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			U3_Samples.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			U3_Samples.LazyShadowToOnline();
		}

		public new PlainL3_Voltage_Samples_660A4F9F CreatePlainerType()
		{
			var cloned = new PlainL3_Voltage_Samples_660A4F9F();
			base.CreatePlainerType(cloned);
			cloned.U3_Samples = U3_Samples.CreatePlainerType();
			return cloned;
		}

		protected PlainL3_Voltage_Samples_660A4F9F CreatePlainerType(PlainL3_Voltage_Samples_660A4F9F cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.U3_Samples = U3_Samples.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainL3_Voltage_Samples_660A4F9F source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainL3_Voltage_Samples_660A4F9F source)
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

		public void FlushOnlineToPlain(Plc1.PlainL3_Voltage_Samples_660A4F9F source)
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

		public L3_Voltage_Samples_660A4F9F(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_U3_Samples = new U3_Samples_25492287(this, "U3_Samples", "U3_Samples");
			_U3_Samples.AttributeName = "U3_Samples";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "U3_SamplesAT %I*U3_Samples_2549228720";
			AttributeCRC = "1711951775";
			AttributeSize = "20";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public L3_Voltage_Samples_660A4F9F(): base ()
		{
			PexPreConstructorParameterless();
			_U3_Samples = new U3_Samples_25492287();
			_U3_Samples.AttributeName = "U3_Samples";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "U3_SamplesAT %I*U3_Samples_2549228720";
			AttributeCRC = "1711951775";
			AttributeSize = "20";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL3_Voltage_Samples_660A4F9F
	{
		public void CopyPlainToCyclic(Plc1.L3_Voltage_Samples_660A4F9F target)
		{
			base.CopyPlainToCyclic(target);
			U3_Samples.CopyPlainToCyclic(target.U3_Samples);
		}

		public void CopyPlainToCyclic(Plc1.IL3_Voltage_Samples_660A4F9F target)
		{
			this.CopyPlainToCyclic((Plc1.L3_Voltage_Samples_660A4F9F)target);
		}

		public void CopyPlainToShadow(Plc1.L3_Voltage_Samples_660A4F9F target)
		{
			base.CopyPlainToShadow(target);
			U3_Samples.CopyPlainToShadow(target.U3_Samples);
		}

		public void CopyPlainToShadow(Plc1.IShadowL3_Voltage_Samples_660A4F9F target)
		{
			this.CopyPlainToShadow((Plc1.L3_Voltage_Samples_660A4F9F)target);
		}

		public void CopyCyclicToPlain(Plc1.L3_Voltage_Samples_660A4F9F source)
		{
			base.CopyCyclicToPlain(source);
			U3_Samples.CopyCyclicToPlain(source.U3_Samples);
		}

		public void CopyCyclicToPlain(Plc1.IL3_Voltage_Samples_660A4F9F source)
		{
			this.CopyCyclicToPlain((Plc1.L3_Voltage_Samples_660A4F9F)source);
		}

		public void CopyShadowToPlain(Plc1.L3_Voltage_Samples_660A4F9F source)
		{
			base.CopyShadowToPlain(source);
			U3_Samples.CopyShadowToPlain(source.U3_Samples);
		}

		public void CopyShadowToPlain(Plc1.IShadowL3_Voltage_Samples_660A4F9F source)
		{
			this.CopyShadowToPlain((Plc1.L3_Voltage_Samples_660A4F9F)source);
		}
	}
}