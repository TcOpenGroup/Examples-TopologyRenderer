using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"U2_SamplesAT %I*U2_Samples_2549228720\" } {attribute addProperty CRC \"1977103279\" } {attribute addProperty Size \"20\" } {attribute addProperty Name \"\" }", "L2_Voltage_Samples_75D833AF", "Plc1", TypeComplexityEnum.Complex)]
	public partial class L2_Voltage_Samples_75D833AF : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IL2_Voltage_Samples_75D833AF, IShadowL2_Voltage_Samples_75D833AF, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		U2_Samples_25492287 _U2_Samples;
		[IoLinkable("Inputs")]
		public U2_Samples_25492287 U2_Samples
		{
			get
			{
				return _U2_Samples;
			}
		}

		[IoLinkable("Inputs")]
		IU2_Samples_25492287 IL2_Voltage_Samples_75D833AF.U2_Samples
		{
			get
			{
				return U2_Samples;
			}
		}

		[IoLinkable("Inputs")]
		IShadowU2_Samples_25492287 IShadowL2_Voltage_Samples_75D833AF.U2_Samples
		{
			get
			{
				return U2_Samples;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			U2_Samples.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			U2_Samples.LazyShadowToOnline();
		}

		public new PlainL2_Voltage_Samples_75D833AF CreatePlainerType()
		{
			var cloned = new PlainL2_Voltage_Samples_75D833AF();
			base.CreatePlainerType(cloned);
			cloned.U2_Samples = U2_Samples.CreatePlainerType();
			return cloned;
		}

		protected PlainL2_Voltage_Samples_75D833AF CreatePlainerType(PlainL2_Voltage_Samples_75D833AF cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.U2_Samples = U2_Samples.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainL2_Voltage_Samples_75D833AF source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainL2_Voltage_Samples_75D833AF source)
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

		public void FlushOnlineToPlain(Plc1.PlainL2_Voltage_Samples_75D833AF source)
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

		public L2_Voltage_Samples_75D833AF(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_U2_Samples = new U2_Samples_25492287(this, "U2_Samples", "U2_Samples");
			_U2_Samples.AttributeName = "U2_Samples";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "U2_SamplesAT %I*U2_Samples_2549228720";
			AttributeCRC = "1977103279";
			AttributeSize = "20";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public L2_Voltage_Samples_75D833AF(): base ()
		{
			PexPreConstructorParameterless();
			_U2_Samples = new U2_Samples_25492287();
			_U2_Samples.AttributeName = "U2_Samples";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "U2_SamplesAT %I*U2_Samples_2549228720";
			AttributeCRC = "1977103279";
			AttributeSize = "20";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL2_Voltage_Samples_75D833AF
	{
		public void CopyPlainToCyclic(Plc1.L2_Voltage_Samples_75D833AF target)
		{
			base.CopyPlainToCyclic(target);
			U2_Samples.CopyPlainToCyclic(target.U2_Samples);
		}

		public void CopyPlainToCyclic(Plc1.IL2_Voltage_Samples_75D833AF target)
		{
			this.CopyPlainToCyclic((Plc1.L2_Voltage_Samples_75D833AF)target);
		}

		public void CopyPlainToShadow(Plc1.L2_Voltage_Samples_75D833AF target)
		{
			base.CopyPlainToShadow(target);
			U2_Samples.CopyPlainToShadow(target.U2_Samples);
		}

		public void CopyPlainToShadow(Plc1.IShadowL2_Voltage_Samples_75D833AF target)
		{
			this.CopyPlainToShadow((Plc1.L2_Voltage_Samples_75D833AF)target);
		}

		public void CopyCyclicToPlain(Plc1.L2_Voltage_Samples_75D833AF source)
		{
			base.CopyCyclicToPlain(source);
			U2_Samples.CopyCyclicToPlain(source.U2_Samples);
		}

		public void CopyCyclicToPlain(Plc1.IL2_Voltage_Samples_75D833AF source)
		{
			this.CopyCyclicToPlain((Plc1.L2_Voltage_Samples_75D833AF)source);
		}

		public void CopyShadowToPlain(Plc1.L2_Voltage_Samples_75D833AF source)
		{
			base.CopyShadowToPlain(source);
			U2_Samples.CopyShadowToPlain(source.U2_Samples);
		}

		public void CopyShadowToPlain(Plc1.IShadowL2_Voltage_Samples_75D833AF source)
		{
			this.CopyShadowToPlain((Plc1.L2_Voltage_Samples_75D833AF)source);
		}
	}
}