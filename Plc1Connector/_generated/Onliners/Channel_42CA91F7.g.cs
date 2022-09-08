using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL2809-0000-0018\" } {attribute addProperty Id \"OutputAT %Q*BOOL1\" } {attribute addProperty CRC \"1120571895\" } {attribute addProperty Size \"1\" } {attribute addProperty Name \"\" }", "Channel_42CA91F7", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Channel_42CA91F7 : TcoIo.OutputBase_10CEE7DE, Vortex.Connector.IVortexObject, IChannel_42CA91F7, IShadowChannel_42CA91F7, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerBool _Output;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool Output
		{
			get
			{
				return _Output;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IChannel_42CA91F7.Output
		{
			get
			{
				return Output;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowChannel_42CA91F7.Output
		{
			get
			{
				return Output;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Output.Shadow = Output.LastValue;
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Output.Cyclic = Output.Shadow;
		}

		public new PlainChannel_42CA91F7 CreatePlainerType()
		{
			var cloned = new PlainChannel_42CA91F7();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainChannel_42CA91F7 CreatePlainerType(PlainChannel_42CA91F7 cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainChannel_42CA91F7 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainChannel_42CA91F7 source)
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

		public void FlushOnlineToPlain(Plc1.PlainChannel_42CA91F7 source)
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

		public Channel_42CA91F7(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Output = @Connector.Online.Adapter.CreateBOOL(this, "Output", "Output");
			Output.AttributeName = "Output";
			AttributeBoxType = "EL2809-0000-0018";
			AttributeId = "OutputAT %Q*BOOL1";
			AttributeCRC = "1120571895";
			AttributeSize = "1";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Channel_42CA91F7(): base ()
		{
			PexPreConstructorParameterless();
			_Output = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Output.AttributeName = "Output";
			AttributeBoxType = "EL2809-0000-0018";
			AttributeId = "OutputAT %Q*BOOL1";
			AttributeCRC = "1120571895";
			AttributeSize = "1";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainChannel_42CA91F7
	{
		public void CopyPlainToCyclic(Plc1.Channel_42CA91F7 target)
		{
			base.CopyPlainToCyclic(target);
			target.Output.Cyclic = Output;
		}

		public void CopyPlainToCyclic(Plc1.IChannel_42CA91F7 target)
		{
			this.CopyPlainToCyclic((Plc1.Channel_42CA91F7)target);
		}

		public void CopyPlainToShadow(Plc1.Channel_42CA91F7 target)
		{
			base.CopyPlainToShadow(target);
			target.Output.Shadow = Output;
		}

		public void CopyPlainToShadow(Plc1.IShadowChannel_42CA91F7 target)
		{
			this.CopyPlainToShadow((Plc1.Channel_42CA91F7)target);
		}

		public void CopyCyclicToPlain(Plc1.Channel_42CA91F7 source)
		{
			base.CopyCyclicToPlain(source);
			Output = source.Output.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.IChannel_42CA91F7 source)
		{
			this.CopyCyclicToPlain((Plc1.Channel_42CA91F7)source);
		}

		public void CopyShadowToPlain(Plc1.Channel_42CA91F7 source)
		{
			base.CopyShadowToPlain(source);
			Output = source.Output.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowChannel_42CA91F7 source)
		{
			this.CopyShadowToPlain((Plc1.Channel_42CA91F7)source);
		}
	}
}