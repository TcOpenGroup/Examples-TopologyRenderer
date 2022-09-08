using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3011-0000-0018\" } {attribute addProperty Id \"StatusAT %I*Status_F2CE6D917ValueAT %I*INT2\" } {attribute addProperty CRC \"1245267073\" } {attribute addProperty Size \"9\" } {attribute addProperty Name \"\" }", "AI_Standard_Channel_4A394481", "Plc1", TypeComplexityEnum.Complex)]
	public partial class AI_Standard_Channel_4A394481 : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IAI_Standard_Channel_4A394481, IShadowAI_Standard_Channel_4A394481, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Status_F2CE6D91 _Status;
		[IoLinkable("Inputs")]
		public Status_F2CE6D91 Status
		{
			get
			{
				return _Status;
			}
		}

		[IoLinkable("Inputs")]
		IStatus_F2CE6D91 IAI_Standard_Channel_4A394481.Status
		{
			get
			{
				return Status;
			}
		}

		[IoLinkable("Inputs")]
		IShadowStatus_F2CE6D91 IShadowAI_Standard_Channel_4A394481.Status
		{
			get
			{
				return Status;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _Value;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerInt Value
		{
			get
			{
				return _Value;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineInt IAI_Standard_Channel_4A394481.Value
		{
			get
			{
				return Value;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowAI_Standard_Channel_4A394481.Value
		{
			get
			{
				return Value;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Status.LazyOnlineToShadow();
			Value.Shadow = Value.LastValue;
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Status.LazyShadowToOnline();
			Value.Cyclic = Value.Shadow;
		}

		public new PlainAI_Standard_Channel_4A394481 CreatePlainerType()
		{
			var cloned = new PlainAI_Standard_Channel_4A394481();
			base.CreatePlainerType(cloned);
			cloned.Status = Status.CreatePlainerType();
			return cloned;
		}

		protected PlainAI_Standard_Channel_4A394481 CreatePlainerType(PlainAI_Standard_Channel_4A394481 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Status = Status.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainAI_Standard_Channel_4A394481 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainAI_Standard_Channel_4A394481 source)
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

		public void FlushOnlineToPlain(Plc1.PlainAI_Standard_Channel_4A394481 source)
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

		public AI_Standard_Channel_4A394481(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Status = new Status_F2CE6D91(this, "Status", "Status");
			_Status.AttributeName = "Status";
			_Value = @Connector.Online.Adapter.CreateINT(this, "Value", "Value");
			Value.AttributeName = "Value";
			AttributeBoxType = "EL3011-0000-0018";
			AttributeId = "StatusAT %I*Status_F2CE6D917ValueAT %I*INT2";
			AttributeCRC = "1245267073";
			AttributeSize = "9";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public AI_Standard_Channel_4A394481(): base ()
		{
			PexPreConstructorParameterless();
			_Status = new Status_F2CE6D91();
			_Status.AttributeName = "Status";
			_Value = Vortex.Connector.IConnectorFactory.CreateINT();
			Value.AttributeName = "Value";
			AttributeBoxType = "EL3011-0000-0018";
			AttributeId = "StatusAT %I*Status_F2CE6D917ValueAT %I*INT2";
			AttributeCRC = "1245267073";
			AttributeSize = "9";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainAI_Standard_Channel_4A394481
	{
		public void CopyPlainToCyclic(Plc1.AI_Standard_Channel_4A394481 target)
		{
			base.CopyPlainToCyclic(target);
			Status.CopyPlainToCyclic(target.Status);
			target.Value.Cyclic = Value;
		}

		public void CopyPlainToCyclic(Plc1.IAI_Standard_Channel_4A394481 target)
		{
			this.CopyPlainToCyclic((Plc1.AI_Standard_Channel_4A394481)target);
		}

		public void CopyPlainToShadow(Plc1.AI_Standard_Channel_4A394481 target)
		{
			base.CopyPlainToShadow(target);
			Status.CopyPlainToShadow(target.Status);
			target.Value.Shadow = Value;
		}

		public void CopyPlainToShadow(Plc1.IShadowAI_Standard_Channel_4A394481 target)
		{
			this.CopyPlainToShadow((Plc1.AI_Standard_Channel_4A394481)target);
		}

		public void CopyCyclicToPlain(Plc1.AI_Standard_Channel_4A394481 source)
		{
			base.CopyCyclicToPlain(source);
			Status.CopyCyclicToPlain(source.Status);
			Value = source.Value.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.IAI_Standard_Channel_4A394481 source)
		{
			this.CopyCyclicToPlain((Plc1.AI_Standard_Channel_4A394481)source);
		}

		public void CopyShadowToPlain(Plc1.AI_Standard_Channel_4A394481 source)
		{
			base.CopyShadowToPlain(source);
			Status.CopyShadowToPlain(source.Status);
			Value = source.Value.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowAI_Standard_Channel_4A394481 source)
		{
			this.CopyShadowToPlain((Plc1.AI_Standard_Channel_4A394481)source);
		}
	}
}