using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"UnderrangeBOOL1OverrangeBOOL1Limit_xBYTE1ErrorBOOL1Sync_errorBOOL1TxPDO_StateBOOL1TxPDO_ToggleBOOL1\" } {attribute addProperty CRC \"3700439328\" } {attribute addProperty Size \"7\" } {attribute addProperty Name \"\" }", "I2_Status_DC903920", "Plc1", TypeComplexityEnum.Complex)]
	public partial class I2_Status_DC903920 : Vortex.Connector.IVortexObject, II2_Status_DC903920, IShadowI2_Status_DC903920, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _Underrange;
		public Vortex.Connector.ValueTypes.OnlinerBool Underrange
		{
			get
			{
				return _Underrange;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool II2_Status_DC903920.Underrange
		{
			get
			{
				return Underrange;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowI2_Status_DC903920.Underrange
		{
			get
			{
				return Underrange;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Overrange;
		public Vortex.Connector.ValueTypes.OnlinerBool Overrange
		{
			get
			{
				return _Overrange;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool II2_Status_DC903920.Overrange
		{
			get
			{
				return Overrange;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowI2_Status_DC903920.Overrange
		{
			get
			{
				return Overrange;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerByte _Limit_x;
		public Vortex.Connector.ValueTypes.OnlinerByte Limit_x
		{
			get
			{
				return _Limit_x;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte II2_Status_DC903920.Limit_x
		{
			get
			{
				return Limit_x;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte IShadowI2_Status_DC903920.Limit_x
		{
			get
			{
				return Limit_x;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Error;
		public Vortex.Connector.ValueTypes.OnlinerBool Error
		{
			get
			{
				return _Error;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool II2_Status_DC903920.Error
		{
			get
			{
				return Error;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowI2_Status_DC903920.Error
		{
			get
			{
				return Error;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Sync_error;
		public Vortex.Connector.ValueTypes.OnlinerBool Sync_error
		{
			get
			{
				return _Sync_error;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool II2_Status_DC903920.Sync_error
		{
			get
			{
				return Sync_error;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowI2_Status_DC903920.Sync_error
		{
			get
			{
				return Sync_error;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _TxPDO_State;
		public Vortex.Connector.ValueTypes.OnlinerBool TxPDO_State
		{
			get
			{
				return _TxPDO_State;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool II2_Status_DC903920.TxPDO_State
		{
			get
			{
				return TxPDO_State;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowI2_Status_DC903920.TxPDO_State
		{
			get
			{
				return TxPDO_State;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _TxPDO_Toggle;
		public Vortex.Connector.ValueTypes.OnlinerBool TxPDO_Toggle
		{
			get
			{
				return _TxPDO_Toggle;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool II2_Status_DC903920.TxPDO_Toggle
		{
			get
			{
				return TxPDO_Toggle;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowI2_Status_DC903920.TxPDO_Toggle
		{
			get
			{
				return TxPDO_Toggle;
			}
		}

		public void LazyOnlineToShadow()
		{
			Underrange.Shadow = Underrange.LastValue;
			Overrange.Shadow = Overrange.LastValue;
			Limit_x.Shadow = Limit_x.LastValue;
			Error.Shadow = Error.LastValue;
			Sync_error.Shadow = Sync_error.LastValue;
			TxPDO_State.Shadow = TxPDO_State.LastValue;
			TxPDO_Toggle.Shadow = TxPDO_Toggle.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Underrange.Cyclic = Underrange.Shadow;
			Overrange.Cyclic = Overrange.Shadow;
			Limit_x.Cyclic = Limit_x.Shadow;
			Error.Cyclic = Error.Shadow;
			Sync_error.Cyclic = Sync_error.Shadow;
			TxPDO_State.Cyclic = TxPDO_State.Shadow;
			TxPDO_Toggle.Cyclic = TxPDO_Toggle.Shadow;
		}

		public PlainI2_Status_DC903920 CreatePlainerType()
		{
			var cloned = new PlainI2_Status_DC903920();
			return cloned;
		}

		protected PlainI2_Status_DC903920 CreatePlainerType(PlainI2_Status_DC903920 cloned)
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

		public void FlushPlainToOnline(Plc1.PlainI2_Status_DC903920 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainI2_Status_DC903920 source)
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

		public void FlushOnlineToPlain(Plc1.PlainI2_Status_DC903920 source)
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

		public I2_Status_DC903920(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_Underrange = @Connector.Online.Adapter.CreateBOOL(this, "Underrange", "Underrange");
			Underrange.AttributeName = "Underrange";
			_Overrange = @Connector.Online.Adapter.CreateBOOL(this, "Overrange", "Overrange");
			Overrange.AttributeName = "Overrange";
			_Limit_x = @Connector.Online.Adapter.CreateBYTE(this, "Limit_x", "Limit_x");
			Limit_x.AttributeName = "Limit_x";
			_Error = @Connector.Online.Adapter.CreateBOOL(this, "Error", "Error");
			Error.AttributeName = "Error";
			_Sync_error = @Connector.Online.Adapter.CreateBOOL(this, "Sync_error", "Sync_error");
			Sync_error.AttributeName = "Sync_error";
			_TxPDO_State = @Connector.Online.Adapter.CreateBOOL(this, "TxPDO_State", "TxPDO_State");
			TxPDO_State.AttributeName = "TxPDO_State";
			_TxPDO_Toggle = @Connector.Online.Adapter.CreateBOOL(this, "TxPDO_Toggle", "TxPDO_Toggle");
			TxPDO_Toggle.AttributeName = "TxPDO_Toggle";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "UnderrangeBOOL1OverrangeBOOL1Limit_xBYTE1ErrorBOOL1Sync_errorBOOL1TxPDO_StateBOOL1TxPDO_ToggleBOOL1";
			AttributeCRC = "3700439328";
			AttributeSize = "7";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public I2_Status_DC903920()
		{
			PexPreConstructorParameterless();
			_Underrange = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Underrange.AttributeName = "Underrange";
			_Overrange = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Overrange.AttributeName = "Overrange";
			_Limit_x = Vortex.Connector.IConnectorFactory.CreateBYTE();
			Limit_x.AttributeName = "Limit_x";
			_Error = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Error.AttributeName = "Error";
			_Sync_error = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Sync_error.AttributeName = "Sync_error";
			_TxPDO_State = Vortex.Connector.IConnectorFactory.CreateBOOL();
			TxPDO_State.AttributeName = "TxPDO_State";
			_TxPDO_Toggle = Vortex.Connector.IConnectorFactory.CreateBOOL();
			TxPDO_Toggle.AttributeName = "TxPDO_Toggle";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "UnderrangeBOOL1OverrangeBOOL1Limit_xBYTE1ErrorBOOL1Sync_errorBOOL1TxPDO_StateBOOL1TxPDO_ToggleBOOL1";
			AttributeCRC = "3700439328";
			AttributeSize = "7";
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainI2_Status_DC903920
	{
		public void CopyPlainToCyclic(Plc1.I2_Status_DC903920 target)
		{
			target.Underrange.Cyclic = Underrange;
			target.Overrange.Cyclic = Overrange;
			target.Limit_x.Cyclic = Limit_x;
			target.Error.Cyclic = Error;
			target.Sync_error.Cyclic = Sync_error;
			target.TxPDO_State.Cyclic = TxPDO_State;
			target.TxPDO_Toggle.Cyclic = TxPDO_Toggle;
		}

		public void CopyPlainToCyclic(Plc1.II2_Status_DC903920 target)
		{
			this.CopyPlainToCyclic((Plc1.I2_Status_DC903920)target);
		}

		public void CopyPlainToShadow(Plc1.I2_Status_DC903920 target)
		{
			target.Underrange.Shadow = Underrange;
			target.Overrange.Shadow = Overrange;
			target.Limit_x.Shadow = Limit_x;
			target.Error.Shadow = Error;
			target.Sync_error.Shadow = Sync_error;
			target.TxPDO_State.Shadow = TxPDO_State;
			target.TxPDO_Toggle.Shadow = TxPDO_Toggle;
		}

		public void CopyPlainToShadow(Plc1.IShadowI2_Status_DC903920 target)
		{
			this.CopyPlainToShadow((Plc1.I2_Status_DC903920)target);
		}

		public void CopyCyclicToPlain(Plc1.I2_Status_DC903920 source)
		{
			Underrange = source.Underrange.LastValue;
			Overrange = source.Overrange.LastValue;
			Limit_x = source.Limit_x.LastValue;
			Error = source.Error.LastValue;
			Sync_error = source.Sync_error.LastValue;
			TxPDO_State = source.TxPDO_State.LastValue;
			TxPDO_Toggle = source.TxPDO_Toggle.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.II2_Status_DC903920 source)
		{
			this.CopyCyclicToPlain((Plc1.I2_Status_DC903920)source);
		}

		public void CopyShadowToPlain(Plc1.I2_Status_DC903920 source)
		{
			Underrange = source.Underrange.Shadow;
			Overrange = source.Overrange.Shadow;
			Limit_x = source.Limit_x.Shadow;
			Error = source.Error.Shadow;
			Sync_error = source.Sync_error.Shadow;
			TxPDO_State = source.TxPDO_State.Shadow;
			TxPDO_Toggle = source.TxPDO_Toggle.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowI2_Status_DC903920 source)
		{
			this.CopyShadowToPlain((Plc1.I2_Status_DC903920)source);
		}
	}
}