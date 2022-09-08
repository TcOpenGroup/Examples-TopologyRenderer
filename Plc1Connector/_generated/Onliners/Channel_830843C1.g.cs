using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL1809-0000-0018\" } {attribute addProperty Id \"InputAT %I*BOOL1\" } {attribute addProperty CRC \"2198356929\" } {attribute addProperty Size \"1\" } {attribute addProperty Name \"\" }", "Channel_830843C1", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Channel_830843C1 : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IChannel_830843C1, IShadowChannel_830843C1, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerBool _Input;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool Input
		{
			get
			{
				return _Input;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IChannel_830843C1.Input
		{
			get
			{
				return Input;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowChannel_830843C1.Input
		{
			get
			{
				return Input;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Input.Shadow = Input.LastValue;
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Input.Cyclic = Input.Shadow;
		}

		public new PlainChannel_830843C1 CreatePlainerType()
		{
			var cloned = new PlainChannel_830843C1();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainChannel_830843C1 CreatePlainerType(PlainChannel_830843C1 cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainChannel_830843C1 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainChannel_830843C1 source)
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

		public void FlushOnlineToPlain(Plc1.PlainChannel_830843C1 source)
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

		public Channel_830843C1(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Input = @Connector.Online.Adapter.CreateBOOL(this, "Input", "Input");
			Input.AttributeName = "Input";
			AttributeBoxType = "EL1809-0000-0018";
			AttributeId = "InputAT %I*BOOL1";
			AttributeCRC = "2198356929";
			AttributeSize = "1";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Channel_830843C1(): base ()
		{
			PexPreConstructorParameterless();
			_Input = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Input.AttributeName = "Input";
			AttributeBoxType = "EL1809-0000-0018";
			AttributeId = "InputAT %I*BOOL1";
			AttributeCRC = "2198356929";
			AttributeSize = "1";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainChannel_830843C1
	{
		public void CopyPlainToCyclic(Plc1.Channel_830843C1 target)
		{
			base.CopyPlainToCyclic(target);
			target.Input.Cyclic = Input;
		}

		public void CopyPlainToCyclic(Plc1.IChannel_830843C1 target)
		{
			this.CopyPlainToCyclic((Plc1.Channel_830843C1)target);
		}

		public void CopyPlainToShadow(Plc1.Channel_830843C1 target)
		{
			base.CopyPlainToShadow(target);
			target.Input.Shadow = Input;
		}

		public void CopyPlainToShadow(Plc1.IShadowChannel_830843C1 target)
		{
			this.CopyPlainToShadow((Plc1.Channel_830843C1)target);
		}

		public void CopyCyclicToPlain(Plc1.Channel_830843C1 source)
		{
			base.CopyCyclicToPlain(source);
			Input = source.Input.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.IChannel_830843C1 source)
		{
			this.CopyCyclicToPlain((Plc1.Channel_830843C1)source);
		}

		public void CopyShadowToPlain(Plc1.Channel_830843C1 source)
		{
			base.CopyShadowToPlain(source);
			Input = source.Input.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowChannel_830843C1 source)
		{
			this.CopyShadowToPlain((Plc1.Channel_830843C1)source);
		}
	}
}