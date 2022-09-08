using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL6002-0000-0019\" } {attribute addProperty Id \"Transmit_acceptedBOOL1Receive_requestBOOL1Init_acceptedBOOL1Buffer_fullBOOL1Parity_errorBOOL1Framing_errorBOOL1Overrun_errorBOOL1Input_lengthUSINT1\" } {attribute addProperty CRC \"1032071007\" } {attribute addProperty Size \"8\" } {attribute addProperty Name \"\" }", "Status_3D84275F", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Status_3D84275F : Vortex.Connector.IVortexObject, IStatus_3D84275F, IShadowStatus_3D84275F, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Vortex.Connector.ValueTypes.OnlinerBool _Transmit_accepted;
		public Vortex.Connector.ValueTypes.OnlinerBool Transmit_accepted
		{
			get
			{
				return _Transmit_accepted;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IStatus_3D84275F.Transmit_accepted
		{
			get
			{
				return Transmit_accepted;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowStatus_3D84275F.Transmit_accepted
		{
			get
			{
				return Transmit_accepted;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Receive_request;
		public Vortex.Connector.ValueTypes.OnlinerBool Receive_request
		{
			get
			{
				return _Receive_request;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IStatus_3D84275F.Receive_request
		{
			get
			{
				return Receive_request;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowStatus_3D84275F.Receive_request
		{
			get
			{
				return Receive_request;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Init_accepted;
		public Vortex.Connector.ValueTypes.OnlinerBool Init_accepted
		{
			get
			{
				return _Init_accepted;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IStatus_3D84275F.Init_accepted
		{
			get
			{
				return Init_accepted;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowStatus_3D84275F.Init_accepted
		{
			get
			{
				return Init_accepted;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Buffer_full;
		public Vortex.Connector.ValueTypes.OnlinerBool Buffer_full
		{
			get
			{
				return _Buffer_full;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IStatus_3D84275F.Buffer_full
		{
			get
			{
				return Buffer_full;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowStatus_3D84275F.Buffer_full
		{
			get
			{
				return Buffer_full;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Parity_error;
		public Vortex.Connector.ValueTypes.OnlinerBool Parity_error
		{
			get
			{
				return _Parity_error;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IStatus_3D84275F.Parity_error
		{
			get
			{
				return Parity_error;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowStatus_3D84275F.Parity_error
		{
			get
			{
				return Parity_error;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Framing_error;
		public Vortex.Connector.ValueTypes.OnlinerBool Framing_error
		{
			get
			{
				return _Framing_error;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IStatus_3D84275F.Framing_error
		{
			get
			{
				return Framing_error;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowStatus_3D84275F.Framing_error
		{
			get
			{
				return Framing_error;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Overrun_error;
		public Vortex.Connector.ValueTypes.OnlinerBool Overrun_error
		{
			get
			{
				return _Overrun_error;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IStatus_3D84275F.Overrun_error
		{
			get
			{
				return Overrun_error;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowStatus_3D84275F.Overrun_error
		{
			get
			{
				return Overrun_error;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUSInt _Input_length;
		public Vortex.Connector.ValueTypes.OnlinerUSInt Input_length
		{
			get
			{
				return _Input_length;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUSInt IStatus_3D84275F.Input_length
		{
			get
			{
				return Input_length;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt IShadowStatus_3D84275F.Input_length
		{
			get
			{
				return Input_length;
			}
		}

		public void LazyOnlineToShadow()
		{
			Transmit_accepted.Shadow = Transmit_accepted.LastValue;
			Receive_request.Shadow = Receive_request.LastValue;
			Init_accepted.Shadow = Init_accepted.LastValue;
			Buffer_full.Shadow = Buffer_full.LastValue;
			Parity_error.Shadow = Parity_error.LastValue;
			Framing_error.Shadow = Framing_error.LastValue;
			Overrun_error.Shadow = Overrun_error.LastValue;
			Input_length.Shadow = Input_length.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Transmit_accepted.Cyclic = Transmit_accepted.Shadow;
			Receive_request.Cyclic = Receive_request.Shadow;
			Init_accepted.Cyclic = Init_accepted.Shadow;
			Buffer_full.Cyclic = Buffer_full.Shadow;
			Parity_error.Cyclic = Parity_error.Shadow;
			Framing_error.Cyclic = Framing_error.Shadow;
			Overrun_error.Cyclic = Overrun_error.Shadow;
			Input_length.Cyclic = Input_length.Shadow;
		}

		public PlainStatus_3D84275F CreatePlainerType()
		{
			var cloned = new PlainStatus_3D84275F();
			return cloned;
		}

		protected PlainStatus_3D84275F CreatePlainerType(PlainStatus_3D84275F cloned)
		{
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		private System.Collections.Generic.List<Vortex.Connector.IVortexObject> @Children
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexObject> @GetChildren()
		{
			return this.@Children;
		}

		public void AddChild(Vortex.Connector.IVortexObject vortexObject)
		{
			this.@Children.Add(vortexObject);
		}

		private System.Collections.Generic.List<Vortex.Connector.IVortexElement> Kids
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexElement> GetKids()
		{
			return this.Kids;
		}

		public void AddKid(Vortex.Connector.IVortexElement vortexElement)
		{
			this.Kids.Add(vortexElement);
		}

		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		protected Vortex.Connector.IVortexObject @Parent
		{
			get;
			set;
		}

		public Vortex.Connector.IVortexObject GetParent()
		{
			return this.@Parent;
		}

		private System.Collections.Generic.List<Vortex.Connector.IValueTag> @ValueTags
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IValueTag> GetValueTags()
		{
			return this.@ValueTags;
		}

		public void AddValueTag(Vortex.Connector.IValueTag valueTag)
		{
			this.@ValueTags.Add(valueTag);
		}

		protected Vortex.Connector.IConnector @Connector
		{
			get;
			set;
		}

		public Vortex.Connector.IConnector GetConnector()
		{
			return this.@Connector;
		}

		public void FlushPlainToOnline(Plc1.PlainStatus_3D84275F source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainStatus_3D84275F source)
		{
			source.CopyPlainToShadow(this);
		}

		public void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(Plc1.PlainStatus_3D84275F source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		protected System.String @SymbolTail
		{
			get;
			set;
		}

		public System.String GetSymbolTail()
		{
			return this.SymbolTail;
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

		public System.String AttributeName
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeName, this).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public Status_3D84275F(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			this.Kids = new System.Collections.Generic.List<Vortex.Connector.IVortexElement>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Transmit_accepted = @Connector.Online.Adapter.CreateBOOL(this, "Transmit_accepted", "Transmit_accepted");
			Transmit_accepted.AttributeName = "Transmit_accepted";
			_Receive_request = @Connector.Online.Adapter.CreateBOOL(this, "Receive_request", "Receive_request");
			Receive_request.AttributeName = "Receive_request";
			_Init_accepted = @Connector.Online.Adapter.CreateBOOL(this, "Init_accepted", "Init_accepted");
			Init_accepted.AttributeName = "Init_accepted";
			_Buffer_full = @Connector.Online.Adapter.CreateBOOL(this, "Buffer_full", "Buffer_full");
			Buffer_full.AttributeName = "Buffer_full";
			_Parity_error = @Connector.Online.Adapter.CreateBOOL(this, "Parity_error", "Parity_error");
			Parity_error.AttributeName = "Parity_error";
			_Framing_error = @Connector.Online.Adapter.CreateBOOL(this, "Framing_error", "Framing_error");
			Framing_error.AttributeName = "Framing_error";
			_Overrun_error = @Connector.Online.Adapter.CreateBOOL(this, "Overrun_error", "Overrun_error");
			Overrun_error.AttributeName = "Overrun_error";
			_Input_length = @Connector.Online.Adapter.CreateUSINT(this, "Input_length", "Input_length");
			Input_length.AttributeName = "Input_length";
			AttributeBoxType = "EL6002-0000-0019";
			AttributeId = "Transmit_acceptedBOOL1Receive_requestBOOL1Init_acceptedBOOL1Buffer_fullBOOL1Parity_errorBOOL1Framing_errorBOOL1Overrun_errorBOOL1Input_lengthUSINT1";
			AttributeCRC = "1032071007";
			AttributeSize = "8";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Status_3D84275F()
		{
			PexPreConstructorParameterless();
			_Transmit_accepted = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Transmit_accepted.AttributeName = "Transmit_accepted";
			_Receive_request = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Receive_request.AttributeName = "Receive_request";
			_Init_accepted = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Init_accepted.AttributeName = "Init_accepted";
			_Buffer_full = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Buffer_full.AttributeName = "Buffer_full";
			_Parity_error = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Parity_error.AttributeName = "Parity_error";
			_Framing_error = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Framing_error.AttributeName = "Framing_error";
			_Overrun_error = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Overrun_error.AttributeName = "Overrun_error";
			_Input_length = Vortex.Connector.IConnectorFactory.CreateUSINT();
			Input_length.AttributeName = "Input_length";
			AttributeBoxType = "EL6002-0000-0019";
			AttributeId = "Transmit_acceptedBOOL1Receive_requestBOOL1Init_acceptedBOOL1Buffer_fullBOOL1Parity_errorBOOL1Framing_errorBOOL1Overrun_errorBOOL1Input_lengthUSINT1";
			AttributeCRC = "1032071007";
			AttributeSize = "8";
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainStatus_3D84275F
	{
		public void CopyPlainToCyclic(Plc1.Status_3D84275F target)
		{
			target.Transmit_accepted.Cyclic = Transmit_accepted;
			target.Receive_request.Cyclic = Receive_request;
			target.Init_accepted.Cyclic = Init_accepted;
			target.Buffer_full.Cyclic = Buffer_full;
			target.Parity_error.Cyclic = Parity_error;
			target.Framing_error.Cyclic = Framing_error;
			target.Overrun_error.Cyclic = Overrun_error;
			target.Input_length.Cyclic = Input_length;
		}

		public void CopyPlainToCyclic(Plc1.IStatus_3D84275F target)
		{
			this.CopyPlainToCyclic((Plc1.Status_3D84275F)target);
		}

		public void CopyPlainToShadow(Plc1.Status_3D84275F target)
		{
			target.Transmit_accepted.Shadow = Transmit_accepted;
			target.Receive_request.Shadow = Receive_request;
			target.Init_accepted.Shadow = Init_accepted;
			target.Buffer_full.Shadow = Buffer_full;
			target.Parity_error.Shadow = Parity_error;
			target.Framing_error.Shadow = Framing_error;
			target.Overrun_error.Shadow = Overrun_error;
			target.Input_length.Shadow = Input_length;
		}

		public void CopyPlainToShadow(Plc1.IShadowStatus_3D84275F target)
		{
			this.CopyPlainToShadow((Plc1.Status_3D84275F)target);
		}

		public void CopyCyclicToPlain(Plc1.Status_3D84275F source)
		{
			Transmit_accepted = source.Transmit_accepted.LastValue;
			Receive_request = source.Receive_request.LastValue;
			Init_accepted = source.Init_accepted.LastValue;
			Buffer_full = source.Buffer_full.LastValue;
			Parity_error = source.Parity_error.LastValue;
			Framing_error = source.Framing_error.LastValue;
			Overrun_error = source.Overrun_error.LastValue;
			Input_length = source.Input_length.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.IStatus_3D84275F source)
		{
			this.CopyCyclicToPlain((Plc1.Status_3D84275F)source);
		}

		public void CopyShadowToPlain(Plc1.Status_3D84275F source)
		{
			Transmit_accepted = source.Transmit_accepted.Shadow;
			Receive_request = source.Receive_request.Shadow;
			Init_accepted = source.Init_accepted.Shadow;
			Buffer_full = source.Buffer_full.Shadow;
			Parity_error = source.Parity_error.Shadow;
			Framing_error = source.Framing_error.Shadow;
			Overrun_error = source.Overrun_error.Shadow;
			Input_length = source.Input_length.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowStatus_3D84275F source)
		{
			this.CopyShadowToPlain((Plc1.Status_3D84275F)source);
		}
	}
}