using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty VendorId \"#x00000002\" } {attribute addProperty BoxType \"EL3011-0000-0018\" } {attribute addProperty Description \"EL3011 4Ch. Ana. Input 0-20mA DIFF\" } {attribute addProperty Physics \"KK\" } {attribute addProperty Id \"AI_StandardAT %I*AI_Standard_Channel_4A3944819WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_23CBA8372\" } {attribute addProperty CRC \"2051625512\" } {attribute addProperty Size \"13\" } {attribute addProperty Name \"\" }", "EL3011_7A495228", "Plc1", TypeComplexityEnum.Complex)]
	public partial class EL3011_7A495228 : TcoIo.EtcSlaveTerminalBase_947E5A46, Vortex.Connector.IVortexObject, IEL3011_7A495228, IShadowEL3011_7A495228, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		AI_Standard_Channel_4A394481 _AI_Standard;
		public AI_Standard_Channel_4A394481 AI_Standard
		{
			get
			{
				return _AI_Standard;
			}
		}

		IAI_Standard_Channel_4A394481 IEL3011_7A495228.AI_Standard
		{
			get
			{
				return AI_Standard;
			}
		}

		IShadowAI_Standard_Channel_4A394481 IShadowEL3011_7A495228.AI_Standard
		{
			get
			{
				return AI_Standard;
			}
		}

		TcoIo.WcState_9091E0EB _WcState;
		public TcoIo.WcState_9091E0EB WcState
		{
			get
			{
				return _WcState;
			}
		}

		TcoIo.IWcState_9091E0EB IEL3011_7A495228.WcState
		{
			get
			{
				return WcState;
			}
		}

		TcoIo.IShadowWcState_9091E0EB IShadowEL3011_7A495228.WcState
		{
			get
			{
				return WcState;
			}
		}

		TcoIo.InfoData_23CBA837 _InfoData;
		public TcoIo.InfoData_23CBA837 InfoData
		{
			get
			{
				return _InfoData;
			}
		}

		TcoIo.IInfoData_23CBA837 IEL3011_7A495228.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		TcoIo.IShadowInfoData_23CBA837 IShadowEL3011_7A495228.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			AI_Standard.LazyOnlineToShadow();
			WcState.LazyOnlineToShadow();
			InfoData.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			AI_Standard.LazyShadowToOnline();
			WcState.LazyShadowToOnline();
			InfoData.LazyShadowToOnline();
		}

		public new PlainEL3011_7A495228 CreatePlainerType()
		{
			var cloned = new PlainEL3011_7A495228();
			base.CreatePlainerType(cloned);
			cloned.AI_Standard = AI_Standard.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		protected PlainEL3011_7A495228 CreatePlainerType(PlainEL3011_7A495228 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.AI_Standard = AI_Standard.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainEL3011_7A495228 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainEL3011_7A495228 source)
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

		public void FlushOnlineToPlain(Plc1.PlainEL3011_7A495228 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public System.String AttributeVendorId
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeVendorId, this).Interpolate(this);
			}

			set
			{
				_AttributeVendorId = value;
			}
		}

		private System.String _AttributeVendorId
		{
			get;
			set;
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

		public System.String AttributeDescription
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeDescription, this).Interpolate(this);
			}

			set
			{
				_AttributeDescription = value;
			}
		}

		private System.String _AttributeDescription
		{
			get;
			set;
		}

		public System.String AttributePhysics
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributePhysics, this).Interpolate(this);
			}

			set
			{
				_AttributePhysics = value;
			}
		}

		private System.String _AttributePhysics
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

		public EL3011_7A495228(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_AI_Standard = new AI_Standard_Channel_4A394481(this, "AI_Standard", "AI_Standard");
			_AI_Standard.AttributeName = "AI_Standard";
			_WcState = new TcoIo.WcState_9091E0EB(this, "WcState", "WcState");
			_WcState.AttributeName = "WcState";
			_InfoData = new TcoIo.InfoData_23CBA837(this, "InfoData", "InfoData");
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL3011-0000-0018";
			AttributeDescription = "EL3011 4Ch. Ana. Input 0-20mA DIFF";
			AttributePhysics = "KK";
			AttributeId = "AI_StandardAT %I*AI_Standard_Channel_4A3944819WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_23CBA8372";
			AttributeCRC = "2051625512";
			AttributeSize = "13";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public EL3011_7A495228(): base ()
		{
			PexPreConstructorParameterless();
			_AI_Standard = new AI_Standard_Channel_4A394481();
			_AI_Standard.AttributeName = "AI_Standard";
			_WcState = new TcoIo.WcState_9091E0EB();
			_WcState.AttributeName = "WcState";
			_InfoData = new TcoIo.InfoData_23CBA837();
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL3011-0000-0018";
			AttributeDescription = "EL3011 4Ch. Ana. Input 0-20mA DIFF";
			AttributePhysics = "KK";
			AttributeId = "AI_StandardAT %I*AI_Standard_Channel_4A3944819WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_23CBA8372";
			AttributeCRC = "2051625512";
			AttributeSize = "13";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL3011_7A495228
	{
		public void CopyPlainToCyclic(Plc1.EL3011_7A495228 target)
		{
			base.CopyPlainToCyclic(target);
			AI_Standard.CopyPlainToCyclic(target.AI_Standard);
			WcState.CopyPlainToCyclic(target.WcState);
			InfoData.CopyPlainToCyclic(target.InfoData);
		}

		public void CopyPlainToCyclic(Plc1.IEL3011_7A495228 target)
		{
			this.CopyPlainToCyclic((Plc1.EL3011_7A495228)target);
		}

		public void CopyPlainToShadow(Plc1.EL3011_7A495228 target)
		{
			base.CopyPlainToShadow(target);
			AI_Standard.CopyPlainToShadow(target.AI_Standard);
			WcState.CopyPlainToShadow(target.WcState);
			InfoData.CopyPlainToShadow(target.InfoData);
		}

		public void CopyPlainToShadow(Plc1.IShadowEL3011_7A495228 target)
		{
			this.CopyPlainToShadow((Plc1.EL3011_7A495228)target);
		}

		public void CopyCyclicToPlain(Plc1.EL3011_7A495228 source)
		{
			base.CopyCyclicToPlain(source);
			AI_Standard.CopyCyclicToPlain(source.AI_Standard);
			WcState.CopyCyclicToPlain(source.WcState);
			InfoData.CopyCyclicToPlain(source.InfoData);
		}

		public void CopyCyclicToPlain(Plc1.IEL3011_7A495228 source)
		{
			this.CopyCyclicToPlain((Plc1.EL3011_7A495228)source);
		}

		public void CopyShadowToPlain(Plc1.EL3011_7A495228 source)
		{
			base.CopyShadowToPlain(source);
			AI_Standard.CopyShadowToPlain(source.AI_Standard);
			WcState.CopyShadowToPlain(source.WcState);
			InfoData.CopyShadowToPlain(source.InfoData);
		}

		public void CopyShadowToPlain(Plc1.IShadowEL3011_7A495228 source)
		{
			this.CopyShadowToPlain((Plc1.EL3011_7A495228)source);
		}
	}
}