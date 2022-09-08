using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"AX5101-0000-0214-0214\" } {attribute addProperty Id \"Master_control_wordAT %Q*UINT2Position_command_valueAT %Q*DINT4\" } {attribute addProperty CRC \"2252740844\" } {attribute addProperty Size \"6\" } {attribute addProperty Name \"\" }", "MDT_864618EC", "Plc1", TypeComplexityEnum.Complex)]
	public partial class MDT_864618EC : TcoIo.OutputBase_10CEE7DE, Vortex.Connector.IVortexObject, IMDT_864618EC, IShadowMDT_864618EC, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerUInt _Master_control_word;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerUInt Master_control_word
		{
			get
			{
				return _Master_control_word;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineUInt IMDT_864618EC.Master_control_word
		{
			get
			{
				return Master_control_word;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowMDT_864618EC.Master_control_word
		{
			get
			{
				return Master_control_word;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDInt _Position_command_value;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerDInt Position_command_value
		{
			get
			{
				return _Position_command_value;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineDInt IMDT_864618EC.Position_command_value
		{
			get
			{
				return Position_command_value;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowMDT_864618EC.Position_command_value
		{
			get
			{
				return Position_command_value;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Master_control_word.Shadow = Master_control_word.LastValue;
			Position_command_value.Shadow = Position_command_value.LastValue;
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Master_control_word.Cyclic = Master_control_word.Shadow;
			Position_command_value.Cyclic = Position_command_value.Shadow;
		}

		public new PlainMDT_864618EC CreatePlainerType()
		{
			var cloned = new PlainMDT_864618EC();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainMDT_864618EC CreatePlainerType(PlainMDT_864618EC cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainMDT_864618EC source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainMDT_864618EC source)
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

		public void FlushOnlineToPlain(Plc1.PlainMDT_864618EC source)
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

		public MDT_864618EC(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Master_control_word = @Connector.Online.Adapter.CreateUINT(this, "Master_control_word", "Master_control_word");
			Master_control_word.AttributeName = "Master_control_word";
			_Position_command_value = @Connector.Online.Adapter.CreateDINT(this, "Position_command_value", "Position_command_value");
			Position_command_value.AttributeName = "Position_command_value";
			AttributeBoxType = "AX5101-0000-0214-0214";
			AttributeId = "Master_control_wordAT %Q*UINT2Position_command_valueAT %Q*DINT4";
			AttributeCRC = "2252740844";
			AttributeSize = "6";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public MDT_864618EC(): base ()
		{
			PexPreConstructorParameterless();
			_Master_control_word = Vortex.Connector.IConnectorFactory.CreateUINT();
			Master_control_word.AttributeName = "Master_control_word";
			_Position_command_value = Vortex.Connector.IConnectorFactory.CreateDINT();
			Position_command_value.AttributeName = "Position_command_value";
			AttributeBoxType = "AX5101-0000-0214-0214";
			AttributeId = "Master_control_wordAT %Q*UINT2Position_command_valueAT %Q*DINT4";
			AttributeCRC = "2252740844";
			AttributeSize = "6";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMDT_864618EC
	{
		public void CopyPlainToCyclic(Plc1.MDT_864618EC target)
		{
			base.CopyPlainToCyclic(target);
			target.Master_control_word.Cyclic = Master_control_word;
			target.Position_command_value.Cyclic = Position_command_value;
		}

		public void CopyPlainToCyclic(Plc1.IMDT_864618EC target)
		{
			this.CopyPlainToCyclic((Plc1.MDT_864618EC)target);
		}

		public void CopyPlainToShadow(Plc1.MDT_864618EC target)
		{
			base.CopyPlainToShadow(target);
			target.Master_control_word.Shadow = Master_control_word;
			target.Position_command_value.Shadow = Position_command_value;
		}

		public void CopyPlainToShadow(Plc1.IShadowMDT_864618EC target)
		{
			this.CopyPlainToShadow((Plc1.MDT_864618EC)target);
		}

		public void CopyCyclicToPlain(Plc1.MDT_864618EC source)
		{
			base.CopyCyclicToPlain(source);
			Master_control_word = source.Master_control_word.LastValue;
			Position_command_value = source.Position_command_value.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.IMDT_864618EC source)
		{
			this.CopyCyclicToPlain((Plc1.MDT_864618EC)source);
		}

		public void CopyShadowToPlain(Plc1.MDT_864618EC source)
		{
			base.CopyShadowToPlain(source);
			Master_control_word = source.Master_control_word.Shadow;
			Position_command_value = source.Position_command_value.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowMDT_864618EC source)
		{
			this.CopyShadowToPlain((Plc1.MDT_864618EC)source);
		}
	}
}