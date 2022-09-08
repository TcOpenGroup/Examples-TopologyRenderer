using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL6002-0000-0019\" } {attribute addProperty Id \"Transmit_requestBOOL1Receive_acceptedBOOL1Init_requestBOOL1Send_continuousBOOL1Output_lengthUSINT1\" } {attribute addProperty CRC \"519785787\" } {attribute addProperty Size \"5\" } {attribute addProperty Name \"\" }", "Ctrl_1EFB4D3B", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Ctrl_1EFB4D3B : Vortex.Connector.IVortexObject, ICtrl_1EFB4D3B, IShadowCtrl_1EFB4D3B, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _Transmit_request;
		public Vortex.Connector.ValueTypes.OnlinerBool Transmit_request
		{
			get
			{
				return _Transmit_request;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool ICtrl_1EFB4D3B.Transmit_request
		{
			get
			{
				return Transmit_request;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowCtrl_1EFB4D3B.Transmit_request
		{
			get
			{
				return Transmit_request;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Receive_accepted;
		public Vortex.Connector.ValueTypes.OnlinerBool Receive_accepted
		{
			get
			{
				return _Receive_accepted;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool ICtrl_1EFB4D3B.Receive_accepted
		{
			get
			{
				return Receive_accepted;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowCtrl_1EFB4D3B.Receive_accepted
		{
			get
			{
				return Receive_accepted;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Init_request;
		public Vortex.Connector.ValueTypes.OnlinerBool Init_request
		{
			get
			{
				return _Init_request;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool ICtrl_1EFB4D3B.Init_request
		{
			get
			{
				return Init_request;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowCtrl_1EFB4D3B.Init_request
		{
			get
			{
				return Init_request;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Send_continuous;
		public Vortex.Connector.ValueTypes.OnlinerBool Send_continuous
		{
			get
			{
				return _Send_continuous;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool ICtrl_1EFB4D3B.Send_continuous
		{
			get
			{
				return Send_continuous;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowCtrl_1EFB4D3B.Send_continuous
		{
			get
			{
				return Send_continuous;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUSInt _Output_length;
		public Vortex.Connector.ValueTypes.OnlinerUSInt Output_length
		{
			get
			{
				return _Output_length;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUSInt ICtrl_1EFB4D3B.Output_length
		{
			get
			{
				return Output_length;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt IShadowCtrl_1EFB4D3B.Output_length
		{
			get
			{
				return Output_length;
			}
		}

		public void LazyOnlineToShadow()
		{
			Transmit_request.Shadow = Transmit_request.LastValue;
			Receive_accepted.Shadow = Receive_accepted.LastValue;
			Init_request.Shadow = Init_request.LastValue;
			Send_continuous.Shadow = Send_continuous.LastValue;
			Output_length.Shadow = Output_length.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Transmit_request.Cyclic = Transmit_request.Shadow;
			Receive_accepted.Cyclic = Receive_accepted.Shadow;
			Init_request.Cyclic = Init_request.Shadow;
			Send_continuous.Cyclic = Send_continuous.Shadow;
			Output_length.Cyclic = Output_length.Shadow;
		}

		public PlainCtrl_1EFB4D3B CreatePlainerType()
		{
			var cloned = new PlainCtrl_1EFB4D3B();
			return cloned;
		}

		protected PlainCtrl_1EFB4D3B CreatePlainerType(PlainCtrl_1EFB4D3B cloned)
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

		public void FlushPlainToOnline(Plc1.PlainCtrl_1EFB4D3B source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainCtrl_1EFB4D3B source)
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

		public void FlushOnlineToPlain(Plc1.PlainCtrl_1EFB4D3B source)
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

		public Ctrl_1EFB4D3B(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_Transmit_request = @Connector.Online.Adapter.CreateBOOL(this, "Transmit_request", "Transmit_request");
			Transmit_request.AttributeName = "Transmit_request";
			_Receive_accepted = @Connector.Online.Adapter.CreateBOOL(this, "Receive_accepted", "Receive_accepted");
			Receive_accepted.AttributeName = "Receive_accepted";
			_Init_request = @Connector.Online.Adapter.CreateBOOL(this, "Init_request", "Init_request");
			Init_request.AttributeName = "Init_request";
			_Send_continuous = @Connector.Online.Adapter.CreateBOOL(this, "Send_continuous", "Send_continuous");
			Send_continuous.AttributeName = "Send_continuous";
			_Output_length = @Connector.Online.Adapter.CreateUSINT(this, "Output_length", "Output_length");
			Output_length.AttributeName = "Output_length";
			AttributeBoxType = "EL6002-0000-0019";
			AttributeId = "Transmit_requestBOOL1Receive_acceptedBOOL1Init_requestBOOL1Send_continuousBOOL1Output_lengthUSINT1";
			AttributeCRC = "519785787";
			AttributeSize = "5";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Ctrl_1EFB4D3B()
		{
			PexPreConstructorParameterless();
			_Transmit_request = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Transmit_request.AttributeName = "Transmit_request";
			_Receive_accepted = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Receive_accepted.AttributeName = "Receive_accepted";
			_Init_request = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Init_request.AttributeName = "Init_request";
			_Send_continuous = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Send_continuous.AttributeName = "Send_continuous";
			_Output_length = Vortex.Connector.IConnectorFactory.CreateUSINT();
			Output_length.AttributeName = "Output_length";
			AttributeBoxType = "EL6002-0000-0019";
			AttributeId = "Transmit_requestBOOL1Receive_acceptedBOOL1Init_requestBOOL1Send_continuousBOOL1Output_lengthUSINT1";
			AttributeCRC = "519785787";
			AttributeSize = "5";
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainCtrl_1EFB4D3B
	{
		public void CopyPlainToCyclic(Plc1.Ctrl_1EFB4D3B target)
		{
			target.Transmit_request.Cyclic = Transmit_request;
			target.Receive_accepted.Cyclic = Receive_accepted;
			target.Init_request.Cyclic = Init_request;
			target.Send_continuous.Cyclic = Send_continuous;
			target.Output_length.Cyclic = Output_length;
		}

		public void CopyPlainToCyclic(Plc1.ICtrl_1EFB4D3B target)
		{
			this.CopyPlainToCyclic((Plc1.Ctrl_1EFB4D3B)target);
		}

		public void CopyPlainToShadow(Plc1.Ctrl_1EFB4D3B target)
		{
			target.Transmit_request.Shadow = Transmit_request;
			target.Receive_accepted.Shadow = Receive_accepted;
			target.Init_request.Shadow = Init_request;
			target.Send_continuous.Shadow = Send_continuous;
			target.Output_length.Shadow = Output_length;
		}

		public void CopyPlainToShadow(Plc1.IShadowCtrl_1EFB4D3B target)
		{
			this.CopyPlainToShadow((Plc1.Ctrl_1EFB4D3B)target);
		}

		public void CopyCyclicToPlain(Plc1.Ctrl_1EFB4D3B source)
		{
			Transmit_request = source.Transmit_request.LastValue;
			Receive_accepted = source.Receive_accepted.LastValue;
			Init_request = source.Init_request.LastValue;
			Send_continuous = source.Send_continuous.LastValue;
			Output_length = source.Output_length.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.ICtrl_1EFB4D3B source)
		{
			this.CopyCyclicToPlain((Plc1.Ctrl_1EFB4D3B)source);
		}

		public void CopyShadowToPlain(Plc1.Ctrl_1EFB4D3B source)
		{
			Transmit_request = source.Transmit_request.Shadow;
			Receive_accepted = source.Receive_accepted.Shadow;
			Init_request = source.Init_request.Shadow;
			Send_continuous = source.Send_continuous.Shadow;
			Output_length = source.Output_length.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowCtrl_1EFB4D3B source)
		{
			this.CopyShadowToPlain((Plc1.Ctrl_1EFB4D3B)source);
		}
	}
}