using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty VendorId \"#x00000002\" } {attribute addProperty BoxType \"EL3174-0002-0017\" } {attribute addProperty Description \"EL3174-0002 4Ch. Ana. Input +/-10V, +/-20mA 16 Bit, Isolated Channels\" } {attribute addProperty Physics \"KK\" } {attribute addProperty Id \"AI_Standard_Channel_1AT %I*AI_Standard_Channel_A8DF64E310AI_Standard_Channel_2AT %I*AI_Standard_Channel_A8DF64E310AI_Standard_Channel_3AT %I*AI_Standard_Channel_A8DF64E310AI_Standard_Channel_4AT %I*AI_Standard_Channel_A8DF64E310WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_23CBA8372\" } {attribute addProperty CRC \"3072065346\" } {attribute addProperty Size \"44\" } {attribute addProperty Name \"\" }", "EL3174_B71BFF42", "Plc1", TypeComplexityEnum.Complex)]
	public partial class EL3174_B71BFF42 : TcoIo.EtcSlaveTerminalBase_947E5A46, Vortex.Connector.IVortexObject, IEL3174_B71BFF42, IShadowEL3174_B71BFF42, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		AI_Standard_Channel_A8DF64E3 _AI_Standard_Channel_1;
		public AI_Standard_Channel_A8DF64E3 AI_Standard_Channel_1
		{
			get
			{
				return _AI_Standard_Channel_1;
			}
		}

		IAI_Standard_Channel_A8DF64E3 IEL3174_B71BFF42.AI_Standard_Channel_1
		{
			get
			{
				return AI_Standard_Channel_1;
			}
		}

		IShadowAI_Standard_Channel_A8DF64E3 IShadowEL3174_B71BFF42.AI_Standard_Channel_1
		{
			get
			{
				return AI_Standard_Channel_1;
			}
		}

		AI_Standard_Channel_A8DF64E3 _AI_Standard_Channel_2;
		public AI_Standard_Channel_A8DF64E3 AI_Standard_Channel_2
		{
			get
			{
				return _AI_Standard_Channel_2;
			}
		}

		IAI_Standard_Channel_A8DF64E3 IEL3174_B71BFF42.AI_Standard_Channel_2
		{
			get
			{
				return AI_Standard_Channel_2;
			}
		}

		IShadowAI_Standard_Channel_A8DF64E3 IShadowEL3174_B71BFF42.AI_Standard_Channel_2
		{
			get
			{
				return AI_Standard_Channel_2;
			}
		}

		AI_Standard_Channel_A8DF64E3 _AI_Standard_Channel_3;
		public AI_Standard_Channel_A8DF64E3 AI_Standard_Channel_3
		{
			get
			{
				return _AI_Standard_Channel_3;
			}
		}

		IAI_Standard_Channel_A8DF64E3 IEL3174_B71BFF42.AI_Standard_Channel_3
		{
			get
			{
				return AI_Standard_Channel_3;
			}
		}

		IShadowAI_Standard_Channel_A8DF64E3 IShadowEL3174_B71BFF42.AI_Standard_Channel_3
		{
			get
			{
				return AI_Standard_Channel_3;
			}
		}

		AI_Standard_Channel_A8DF64E3 _AI_Standard_Channel_4;
		public AI_Standard_Channel_A8DF64E3 AI_Standard_Channel_4
		{
			get
			{
				return _AI_Standard_Channel_4;
			}
		}

		IAI_Standard_Channel_A8DF64E3 IEL3174_B71BFF42.AI_Standard_Channel_4
		{
			get
			{
				return AI_Standard_Channel_4;
			}
		}

		IShadowAI_Standard_Channel_A8DF64E3 IShadowEL3174_B71BFF42.AI_Standard_Channel_4
		{
			get
			{
				return AI_Standard_Channel_4;
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

		TcoIo.IWcState_9091E0EB IEL3174_B71BFF42.WcState
		{
			get
			{
				return WcState;
			}
		}

		TcoIo.IShadowWcState_9091E0EB IShadowEL3174_B71BFF42.WcState
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

		TcoIo.IInfoData_23CBA837 IEL3174_B71BFF42.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		TcoIo.IShadowInfoData_23CBA837 IShadowEL3174_B71BFF42.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			AI_Standard_Channel_1.LazyOnlineToShadow();
			AI_Standard_Channel_2.LazyOnlineToShadow();
			AI_Standard_Channel_3.LazyOnlineToShadow();
			AI_Standard_Channel_4.LazyOnlineToShadow();
			WcState.LazyOnlineToShadow();
			InfoData.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			AI_Standard_Channel_1.LazyShadowToOnline();
			AI_Standard_Channel_2.LazyShadowToOnline();
			AI_Standard_Channel_3.LazyShadowToOnline();
			AI_Standard_Channel_4.LazyShadowToOnline();
			WcState.LazyShadowToOnline();
			InfoData.LazyShadowToOnline();
		}

		public new PlainEL3174_B71BFF42 CreatePlainerType()
		{
			var cloned = new PlainEL3174_B71BFF42();
			base.CreatePlainerType(cloned);
			cloned.AI_Standard_Channel_1 = AI_Standard_Channel_1.CreatePlainerType();
			cloned.AI_Standard_Channel_2 = AI_Standard_Channel_2.CreatePlainerType();
			cloned.AI_Standard_Channel_3 = AI_Standard_Channel_3.CreatePlainerType();
			cloned.AI_Standard_Channel_4 = AI_Standard_Channel_4.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		protected PlainEL3174_B71BFF42 CreatePlainerType(PlainEL3174_B71BFF42 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.AI_Standard_Channel_1 = AI_Standard_Channel_1.CreatePlainerType();
			cloned.AI_Standard_Channel_2 = AI_Standard_Channel_2.CreatePlainerType();
			cloned.AI_Standard_Channel_3 = AI_Standard_Channel_3.CreatePlainerType();
			cloned.AI_Standard_Channel_4 = AI_Standard_Channel_4.CreatePlainerType();
			cloned.WcState = WcState.CreatePlainerType();
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainEL3174_B71BFF42 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainEL3174_B71BFF42 source)
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

		public void FlushOnlineToPlain(Plc1.PlainEL3174_B71BFF42 source)
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

		public EL3174_B71BFF42(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_AI_Standard_Channel_1 = new AI_Standard_Channel_A8DF64E3(this, "AI_Standard_Channel_1", "AI_Standard_Channel_1");
			_AI_Standard_Channel_1.AttributeName = "AI_Standard_Channel_1";
			_AI_Standard_Channel_2 = new AI_Standard_Channel_A8DF64E3(this, "AI_Standard_Channel_2", "AI_Standard_Channel_2");
			_AI_Standard_Channel_2.AttributeName = "AI_Standard_Channel_2";
			_AI_Standard_Channel_3 = new AI_Standard_Channel_A8DF64E3(this, "AI_Standard_Channel_3", "AI_Standard_Channel_3");
			_AI_Standard_Channel_3.AttributeName = "AI_Standard_Channel_3";
			_AI_Standard_Channel_4 = new AI_Standard_Channel_A8DF64E3(this, "AI_Standard_Channel_4", "AI_Standard_Channel_4");
			_AI_Standard_Channel_4.AttributeName = "AI_Standard_Channel_4";
			_WcState = new TcoIo.WcState_9091E0EB(this, "WcState", "WcState");
			_WcState.AttributeName = "WcState";
			_InfoData = new TcoIo.InfoData_23CBA837(this, "InfoData", "InfoData");
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL3174-0002-0017";
			AttributeDescription = "EL3174-0002 4Ch. Ana. Input +/-10V, +/-20mA 16 Bit, Isolated Channels";
			AttributePhysics = "KK";
			AttributeId = "AI_Standard_Channel_1AT %I*AI_Standard_Channel_A8DF64E310AI_Standard_Channel_2AT %I*AI_Standard_Channel_A8DF64E310AI_Standard_Channel_3AT %I*AI_Standard_Channel_A8DF64E310AI_Standard_Channel_4AT %I*AI_Standard_Channel_A8DF64E310WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_23CBA8372";
			AttributeCRC = "3072065346";
			AttributeSize = "44";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public EL3174_B71BFF42(): base ()
		{
			PexPreConstructorParameterless();
			_AI_Standard_Channel_1 = new AI_Standard_Channel_A8DF64E3();
			_AI_Standard_Channel_1.AttributeName = "AI_Standard_Channel_1";
			_AI_Standard_Channel_2 = new AI_Standard_Channel_A8DF64E3();
			_AI_Standard_Channel_2.AttributeName = "AI_Standard_Channel_2";
			_AI_Standard_Channel_3 = new AI_Standard_Channel_A8DF64E3();
			_AI_Standard_Channel_3.AttributeName = "AI_Standard_Channel_3";
			_AI_Standard_Channel_4 = new AI_Standard_Channel_A8DF64E3();
			_AI_Standard_Channel_4.AttributeName = "AI_Standard_Channel_4";
			_WcState = new TcoIo.WcState_9091E0EB();
			_WcState.AttributeName = "WcState";
			_InfoData = new TcoIo.InfoData_23CBA837();
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL3174-0002-0017";
			AttributeDescription = "EL3174-0002 4Ch. Ana. Input +/-10V, +/-20mA 16 Bit, Isolated Channels";
			AttributePhysics = "KK";
			AttributeId = "AI_Standard_Channel_1AT %I*AI_Standard_Channel_A8DF64E310AI_Standard_Channel_2AT %I*AI_Standard_Channel_A8DF64E310AI_Standard_Channel_3AT %I*AI_Standard_Channel_A8DF64E310AI_Standard_Channel_4AT %I*AI_Standard_Channel_A8DF64E310WcStateAT %I*WcState_9091E0EB2InfoDataAT %I*InfoData_23CBA8372";
			AttributeCRC = "3072065346";
			AttributeSize = "44";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL3174_B71BFF42
	{
		public void CopyPlainToCyclic(Plc1.EL3174_B71BFF42 target)
		{
			base.CopyPlainToCyclic(target);
			AI_Standard_Channel_1.CopyPlainToCyclic(target.AI_Standard_Channel_1);
			AI_Standard_Channel_2.CopyPlainToCyclic(target.AI_Standard_Channel_2);
			AI_Standard_Channel_3.CopyPlainToCyclic(target.AI_Standard_Channel_3);
			AI_Standard_Channel_4.CopyPlainToCyclic(target.AI_Standard_Channel_4);
			WcState.CopyPlainToCyclic(target.WcState);
			InfoData.CopyPlainToCyclic(target.InfoData);
		}

		public void CopyPlainToCyclic(Plc1.IEL3174_B71BFF42 target)
		{
			this.CopyPlainToCyclic((Plc1.EL3174_B71BFF42)target);
		}

		public void CopyPlainToShadow(Plc1.EL3174_B71BFF42 target)
		{
			base.CopyPlainToShadow(target);
			AI_Standard_Channel_1.CopyPlainToShadow(target.AI_Standard_Channel_1);
			AI_Standard_Channel_2.CopyPlainToShadow(target.AI_Standard_Channel_2);
			AI_Standard_Channel_3.CopyPlainToShadow(target.AI_Standard_Channel_3);
			AI_Standard_Channel_4.CopyPlainToShadow(target.AI_Standard_Channel_4);
			WcState.CopyPlainToShadow(target.WcState);
			InfoData.CopyPlainToShadow(target.InfoData);
		}

		public void CopyPlainToShadow(Plc1.IShadowEL3174_B71BFF42 target)
		{
			this.CopyPlainToShadow((Plc1.EL3174_B71BFF42)target);
		}

		public void CopyCyclicToPlain(Plc1.EL3174_B71BFF42 source)
		{
			base.CopyCyclicToPlain(source);
			AI_Standard_Channel_1.CopyCyclicToPlain(source.AI_Standard_Channel_1);
			AI_Standard_Channel_2.CopyCyclicToPlain(source.AI_Standard_Channel_2);
			AI_Standard_Channel_3.CopyCyclicToPlain(source.AI_Standard_Channel_3);
			AI_Standard_Channel_4.CopyCyclicToPlain(source.AI_Standard_Channel_4);
			WcState.CopyCyclicToPlain(source.WcState);
			InfoData.CopyCyclicToPlain(source.InfoData);
		}

		public void CopyCyclicToPlain(Plc1.IEL3174_B71BFF42 source)
		{
			this.CopyCyclicToPlain((Plc1.EL3174_B71BFF42)source);
		}

		public void CopyShadowToPlain(Plc1.EL3174_B71BFF42 source)
		{
			base.CopyShadowToPlain(source);
			AI_Standard_Channel_1.CopyShadowToPlain(source.AI_Standard_Channel_1);
			AI_Standard_Channel_2.CopyShadowToPlain(source.AI_Standard_Channel_2);
			AI_Standard_Channel_3.CopyShadowToPlain(source.AI_Standard_Channel_3);
			AI_Standard_Channel_4.CopyShadowToPlain(source.AI_Standard_Channel_4);
			WcState.CopyShadowToPlain(source.WcState);
			InfoData.CopyShadowToPlain(source.InfoData);
		}

		public void CopyShadowToPlain(Plc1.IShadowEL3174_B71BFF42 source)
		{
			this.CopyShadowToPlain((Plc1.EL3174_B71BFF42)source);
		}
	}
}