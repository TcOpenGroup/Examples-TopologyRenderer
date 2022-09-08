using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"I1_SamplesAT %I*I1_Samples_2549228720\" } {attribute addProperty CRC \"2663418686\" } {attribute addProperty Size \"20\" } {attribute addProperty Name \"\" }", "L1_Current_Samples_9EC08B3E", "Plc1", TypeComplexityEnum.Complex)]
	public partial class L1_Current_Samples_9EC08B3E : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IL1_Current_Samples_9EC08B3E, IShadowL1_Current_Samples_9EC08B3E, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		I1_Samples_25492287 _I1_Samples;
		[IoLinkable("Inputs")]
		public I1_Samples_25492287 I1_Samples
		{
			get
			{
				return _I1_Samples;
			}
		}

		[IoLinkable("Inputs")]
		II1_Samples_25492287 IL1_Current_Samples_9EC08B3E.I1_Samples
		{
			get
			{
				return I1_Samples;
			}
		}

		[IoLinkable("Inputs")]
		IShadowI1_Samples_25492287 IShadowL1_Current_Samples_9EC08B3E.I1_Samples
		{
			get
			{
				return I1_Samples;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			I1_Samples.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			I1_Samples.LazyShadowToOnline();
		}

		public new PlainL1_Current_Samples_9EC08B3E CreatePlainerType()
		{
			var cloned = new PlainL1_Current_Samples_9EC08B3E();
			base.CreatePlainerType(cloned);
			cloned.I1_Samples = I1_Samples.CreatePlainerType();
			return cloned;
		}

		protected PlainL1_Current_Samples_9EC08B3E CreatePlainerType(PlainL1_Current_Samples_9EC08B3E cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.I1_Samples = I1_Samples.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainL1_Current_Samples_9EC08B3E source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainL1_Current_Samples_9EC08B3E source)
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

		public void FlushOnlineToPlain(Plc1.PlainL1_Current_Samples_9EC08B3E source)
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

		public L1_Current_Samples_9EC08B3E(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_I1_Samples = new I1_Samples_25492287(this, "I1_Samples", "I1_Samples");
			_I1_Samples.AttributeName = "I1_Samples";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "I1_SamplesAT %I*I1_Samples_2549228720";
			AttributeCRC = "2663418686";
			AttributeSize = "20";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public L1_Current_Samples_9EC08B3E(): base ()
		{
			PexPreConstructorParameterless();
			_I1_Samples = new I1_Samples_25492287();
			_I1_Samples.AttributeName = "I1_Samples";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "I1_SamplesAT %I*I1_Samples_2549228720";
			AttributeCRC = "2663418686";
			AttributeSize = "20";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL1_Current_Samples_9EC08B3E
	{
		public void CopyPlainToCyclic(Plc1.L1_Current_Samples_9EC08B3E target)
		{
			base.CopyPlainToCyclic(target);
			I1_Samples.CopyPlainToCyclic(target.I1_Samples);
		}

		public void CopyPlainToCyclic(Plc1.IL1_Current_Samples_9EC08B3E target)
		{
			this.CopyPlainToCyclic((Plc1.L1_Current_Samples_9EC08B3E)target);
		}

		public void CopyPlainToShadow(Plc1.L1_Current_Samples_9EC08B3E target)
		{
			base.CopyPlainToShadow(target);
			I1_Samples.CopyPlainToShadow(target.I1_Samples);
		}

		public void CopyPlainToShadow(Plc1.IShadowL1_Current_Samples_9EC08B3E target)
		{
			this.CopyPlainToShadow((Plc1.L1_Current_Samples_9EC08B3E)target);
		}

		public void CopyCyclicToPlain(Plc1.L1_Current_Samples_9EC08B3E source)
		{
			base.CopyCyclicToPlain(source);
			I1_Samples.CopyCyclicToPlain(source.I1_Samples);
		}

		public void CopyCyclicToPlain(Plc1.IL1_Current_Samples_9EC08B3E source)
		{
			this.CopyCyclicToPlain((Plc1.L1_Current_Samples_9EC08B3E)source);
		}

		public void CopyShadowToPlain(Plc1.L1_Current_Samples_9EC08B3E source)
		{
			base.CopyShadowToPlain(source);
			I1_Samples.CopyShadowToPlain(source.I1_Samples);
		}

		public void CopyShadowToPlain(Plc1.IShadowL1_Current_Samples_9EC08B3E source)
		{
			this.CopyShadowToPlain((Plc1.L1_Current_Samples_9EC08B3E)source);
		}
	}
}