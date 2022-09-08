using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL4004-0000-0020\" } {attribute addProperty Id \"Analog_outputAT %Q*INT2\" } {attribute addProperty CRC \"3128867708\" } {attribute addProperty Size \"2\" } {attribute addProperty Name \"\" }", "AO_Output_Channel_BA7EBB7C", "Plc1", TypeComplexityEnum.Complex)]
	public partial class AO_Output_Channel_BA7EBB7C : TcoIo.OutputBase_10CEE7DE, Vortex.Connector.IVortexObject, IAO_Output_Channel_BA7EBB7C, IShadowAO_Output_Channel_BA7EBB7C, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerInt _Analog_output;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerInt Analog_output
		{
			get
			{
				return _Analog_output;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineInt IAO_Output_Channel_BA7EBB7C.Analog_output
		{
			get
			{
				return Analog_output;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowAO_Output_Channel_BA7EBB7C.Analog_output
		{
			get
			{
				return Analog_output;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Analog_output.Shadow = Analog_output.LastValue;
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Analog_output.Cyclic = Analog_output.Shadow;
		}

		public new PlainAO_Output_Channel_BA7EBB7C CreatePlainerType()
		{
			var cloned = new PlainAO_Output_Channel_BA7EBB7C();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainAO_Output_Channel_BA7EBB7C CreatePlainerType(PlainAO_Output_Channel_BA7EBB7C cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainAO_Output_Channel_BA7EBB7C source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainAO_Output_Channel_BA7EBB7C source)
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

		public void FlushOnlineToPlain(Plc1.PlainAO_Output_Channel_BA7EBB7C source)
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

		public AO_Output_Channel_BA7EBB7C(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Analog_output = @Connector.Online.Adapter.CreateINT(this, "Analog_output", "Analog_output");
			Analog_output.AttributeName = "Analog_output";
			AttributeBoxType = "EL4004-0000-0020";
			AttributeId = "Analog_outputAT %Q*INT2";
			AttributeCRC = "3128867708";
			AttributeSize = "2";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public AO_Output_Channel_BA7EBB7C(): base ()
		{
			PexPreConstructorParameterless();
			_Analog_output = Vortex.Connector.IConnectorFactory.CreateINT();
			Analog_output.AttributeName = "Analog_output";
			AttributeBoxType = "EL4004-0000-0020";
			AttributeId = "Analog_outputAT %Q*INT2";
			AttributeCRC = "3128867708";
			AttributeSize = "2";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainAO_Output_Channel_BA7EBB7C
	{
		public void CopyPlainToCyclic(Plc1.AO_Output_Channel_BA7EBB7C target)
		{
			base.CopyPlainToCyclic(target);
			target.Analog_output.Cyclic = Analog_output;
		}

		public void CopyPlainToCyclic(Plc1.IAO_Output_Channel_BA7EBB7C target)
		{
			this.CopyPlainToCyclic((Plc1.AO_Output_Channel_BA7EBB7C)target);
		}

		public void CopyPlainToShadow(Plc1.AO_Output_Channel_BA7EBB7C target)
		{
			base.CopyPlainToShadow(target);
			target.Analog_output.Shadow = Analog_output;
		}

		public void CopyPlainToShadow(Plc1.IShadowAO_Output_Channel_BA7EBB7C target)
		{
			this.CopyPlainToShadow((Plc1.AO_Output_Channel_BA7EBB7C)target);
		}

		public void CopyCyclicToPlain(Plc1.AO_Output_Channel_BA7EBB7C source)
		{
			base.CopyCyclicToPlain(source);
			Analog_output = source.Analog_output.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.IAO_Output_Channel_BA7EBB7C source)
		{
			this.CopyCyclicToPlain((Plc1.AO_Output_Channel_BA7EBB7C)source);
		}

		public void CopyShadowToPlain(Plc1.AO_Output_Channel_BA7EBB7C source)
		{
			base.CopyShadowToPlain(source);
			Analog_output = source.Analog_output.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowAO_Output_Channel_BA7EBB7C source)
		{
			this.CopyShadowToPlain((Plc1.AO_Output_Channel_BA7EBB7C)source);
		}
	}
}