using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"I3_SamplesAT %I*I3_Samples_2549228720\" } {attribute addProperty CRC \"3110368094\" } {attribute addProperty Size \"20\" } {attribute addProperty Name \"\" }", "L3_Current_Samples_B964735E", "Plc1", TypeComplexityEnum.Complex)]
	public partial class L3_Current_Samples_B964735E : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IL3_Current_Samples_B964735E, IShadowL3_Current_Samples_B964735E, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		I3_Samples_25492287 _I3_Samples;
		[IoLinkable("Inputs")]
		public I3_Samples_25492287 I3_Samples
		{
			get
			{
				return _I3_Samples;
			}
		}

		[IoLinkable("Inputs")]
		II3_Samples_25492287 IL3_Current_Samples_B964735E.I3_Samples
		{
			get
			{
				return I3_Samples;
			}
		}

		[IoLinkable("Inputs")]
		IShadowI3_Samples_25492287 IShadowL3_Current_Samples_B964735E.I3_Samples
		{
			get
			{
				return I3_Samples;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			I3_Samples.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			I3_Samples.LazyShadowToOnline();
		}

		public new PlainL3_Current_Samples_B964735E CreatePlainerType()
		{
			var cloned = new PlainL3_Current_Samples_B964735E();
			base.CreatePlainerType(cloned);
			cloned.I3_Samples = I3_Samples.CreatePlainerType();
			return cloned;
		}

		protected PlainL3_Current_Samples_B964735E CreatePlainerType(PlainL3_Current_Samples_B964735E cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.I3_Samples = I3_Samples.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainL3_Current_Samples_B964735E source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainL3_Current_Samples_B964735E source)
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

		public void FlushOnlineToPlain(Plc1.PlainL3_Current_Samples_B964735E source)
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

		public L3_Current_Samples_B964735E(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_I3_Samples = new I3_Samples_25492287(this, "I3_Samples", "I3_Samples");
			_I3_Samples.AttributeName = "I3_Samples";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "I3_SamplesAT %I*I3_Samples_2549228720";
			AttributeCRC = "3110368094";
			AttributeSize = "20";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public L3_Current_Samples_B964735E(): base ()
		{
			PexPreConstructorParameterless();
			_I3_Samples = new I3_Samples_25492287();
			_I3_Samples.AttributeName = "I3_Samples";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "I3_SamplesAT %I*I3_Samples_2549228720";
			AttributeCRC = "3110368094";
			AttributeSize = "20";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL3_Current_Samples_B964735E
	{
		public void CopyPlainToCyclic(Plc1.L3_Current_Samples_B964735E target)
		{
			base.CopyPlainToCyclic(target);
			I3_Samples.CopyPlainToCyclic(target.I3_Samples);
		}

		public void CopyPlainToCyclic(Plc1.IL3_Current_Samples_B964735E target)
		{
			this.CopyPlainToCyclic((Plc1.L3_Current_Samples_B964735E)target);
		}

		public void CopyPlainToShadow(Plc1.L3_Current_Samples_B964735E target)
		{
			base.CopyPlainToShadow(target);
			I3_Samples.CopyPlainToShadow(target.I3_Samples);
		}

		public void CopyPlainToShadow(Plc1.IShadowL3_Current_Samples_B964735E target)
		{
			this.CopyPlainToShadow((Plc1.L3_Current_Samples_B964735E)target);
		}

		public void CopyCyclicToPlain(Plc1.L3_Current_Samples_B964735E source)
		{
			base.CopyCyclicToPlain(source);
			I3_Samples.CopyCyclicToPlain(source.I3_Samples);
		}

		public void CopyCyclicToPlain(Plc1.IL3_Current_Samples_B964735E source)
		{
			this.CopyCyclicToPlain((Plc1.L3_Current_Samples_B964735E)source);
		}

		public void CopyShadowToPlain(Plc1.L3_Current_Samples_B964735E source)
		{
			base.CopyShadowToPlain(source);
			I3_Samples.CopyShadowToPlain(source.I3_Samples);
		}

		public void CopyShadowToPlain(Plc1.IShadowL3_Current_Samples_B964735E source)
		{
			this.CopyShadowToPlain((Plc1.L3_Current_Samples_B964735E)source);
		}
	}
}