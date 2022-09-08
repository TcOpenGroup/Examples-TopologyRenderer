using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"AdsAddrAT %I*TcoIo.TcoAmsAddr0DcOutputShiftAT %I*DINT4DcInputShiftAT %I*DINT4StateAT %I*UINT2\" } {attribute addProperty CRC \"3092102853\" } {attribute addProperty Size \"10\" } {attribute addProperty Name \"\" }", "InfoData_B84DBEC5", "Plc1", TypeComplexityEnum.Complex)]
	public partial class InfoData_B84DBEC5 : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IInfoData_B84DBEC5, IShadowInfoData_B84DBEC5, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		TcoIo.TcoAmsAddr _AdsAddr;
		[IoLinkable("Inputs")]
		public TcoIo.TcoAmsAddr AdsAddr
		{
			get
			{
				return _AdsAddr;
			}
		}

		[IoLinkable("Inputs")]
		TcoIo.ITcoAmsAddr IInfoData_B84DBEC5.AdsAddr
		{
			get
			{
				return AdsAddr;
			}
		}

		[IoLinkable("Inputs")]
		TcoIo.IShadowTcoAmsAddr IShadowInfoData_B84DBEC5.AdsAddr
		{
			get
			{
				return AdsAddr;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDInt _DcOutputShift;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerDInt DcOutputShift
		{
			get
			{
				return _DcOutputShift;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineDInt IInfoData_B84DBEC5.DcOutputShift
		{
			get
			{
				return DcOutputShift;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowInfoData_B84DBEC5.DcOutputShift
		{
			get
			{
				return DcOutputShift;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDInt _DcInputShift;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerDInt DcInputShift
		{
			get
			{
				return _DcInputShift;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineDInt IInfoData_B84DBEC5.DcInputShift
		{
			get
			{
				return DcInputShift;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowInfoData_B84DBEC5.DcInputShift
		{
			get
			{
				return DcInputShift;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _State;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerUInt State
		{
			get
			{
				return _State;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineUInt IInfoData_B84DBEC5.State
		{
			get
			{
				return State;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowInfoData_B84DBEC5.State
		{
			get
			{
				return State;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			AdsAddr.LazyOnlineToShadow();
			DcOutputShift.Shadow = DcOutputShift.LastValue;
			DcInputShift.Shadow = DcInputShift.LastValue;
			State.Shadow = State.LastValue;
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			AdsAddr.LazyShadowToOnline();
			DcOutputShift.Cyclic = DcOutputShift.Shadow;
			DcInputShift.Cyclic = DcInputShift.Shadow;
			State.Cyclic = State.Shadow;
		}

		public new PlainInfoData_B84DBEC5 CreatePlainerType()
		{
			var cloned = new PlainInfoData_B84DBEC5();
			base.CreatePlainerType(cloned);
			cloned.AdsAddr = AdsAddr.CreatePlainerType();
			return cloned;
		}

		protected PlainInfoData_B84DBEC5 CreatePlainerType(PlainInfoData_B84DBEC5 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.AdsAddr = AdsAddr.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainInfoData_B84DBEC5 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainInfoData_B84DBEC5 source)
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

		public void FlushOnlineToPlain(Plc1.PlainInfoData_B84DBEC5 source)
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

		public InfoData_B84DBEC5(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_AdsAddr = new TcoIo.TcoAmsAddr(this, "AdsAddr", "AdsAddr");
			_AdsAddr.AttributeName = "AdsAddr";
			_DcOutputShift = @Connector.Online.Adapter.CreateDINT(this, "DcOutputShift", "DcOutputShift");
			DcOutputShift.AttributeName = "DcOutputShift";
			_DcInputShift = @Connector.Online.Adapter.CreateDINT(this, "DcInputShift", "DcInputShift");
			DcInputShift.AttributeName = "DcInputShift";
			_State = @Connector.Online.Adapter.CreateUINT(this, "State", "State");
			State.AttributeName = "State";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "AdsAddrAT %I*TcoIo.TcoAmsAddr0DcOutputShiftAT %I*DINT4DcInputShiftAT %I*DINT4StateAT %I*UINT2";
			AttributeCRC = "3092102853";
			AttributeSize = "10";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public InfoData_B84DBEC5(): base ()
		{
			PexPreConstructorParameterless();
			_AdsAddr = new TcoIo.TcoAmsAddr();
			_AdsAddr.AttributeName = "AdsAddr";
			_DcOutputShift = Vortex.Connector.IConnectorFactory.CreateDINT();
			DcOutputShift.AttributeName = "DcOutputShift";
			_DcInputShift = Vortex.Connector.IConnectorFactory.CreateDINT();
			DcInputShift.AttributeName = "DcInputShift";
			_State = Vortex.Connector.IConnectorFactory.CreateUINT();
			State.AttributeName = "State";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "AdsAddrAT %I*TcoIo.TcoAmsAddr0DcOutputShiftAT %I*DINT4DcInputShiftAT %I*DINT4StateAT %I*UINT2";
			AttributeCRC = "3092102853";
			AttributeSize = "10";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainInfoData_B84DBEC5
	{
		public void CopyPlainToCyclic(Plc1.InfoData_B84DBEC5 target)
		{
			base.CopyPlainToCyclic(target);
			AdsAddr.CopyPlainToCyclic(target.AdsAddr);
			target.DcOutputShift.Cyclic = DcOutputShift;
			target.DcInputShift.Cyclic = DcInputShift;
			target.State.Cyclic = State;
		}

		public void CopyPlainToCyclic(Plc1.IInfoData_B84DBEC5 target)
		{
			this.CopyPlainToCyclic((Plc1.InfoData_B84DBEC5)target);
		}

		public void CopyPlainToShadow(Plc1.InfoData_B84DBEC5 target)
		{
			base.CopyPlainToShadow(target);
			AdsAddr.CopyPlainToShadow(target.AdsAddr);
			target.DcOutputShift.Shadow = DcOutputShift;
			target.DcInputShift.Shadow = DcInputShift;
			target.State.Shadow = State;
		}

		public void CopyPlainToShadow(Plc1.IShadowInfoData_B84DBEC5 target)
		{
			this.CopyPlainToShadow((Plc1.InfoData_B84DBEC5)target);
		}

		public void CopyCyclicToPlain(Plc1.InfoData_B84DBEC5 source)
		{
			base.CopyCyclicToPlain(source);
			AdsAddr.CopyCyclicToPlain(source.AdsAddr);
			DcOutputShift = source.DcOutputShift.LastValue;
			DcInputShift = source.DcInputShift.LastValue;
			State = source.State.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.IInfoData_B84DBEC5 source)
		{
			this.CopyCyclicToPlain((Plc1.InfoData_B84DBEC5)source);
		}

		public void CopyShadowToPlain(Plc1.InfoData_B84DBEC5 source)
		{
			base.CopyShadowToPlain(source);
			AdsAddr.CopyShadowToPlain(source.AdsAddr);
			DcOutputShift = source.DcOutputShift.Shadow;
			DcInputShift = source.DcInputShift.Shadow;
			State = source.State.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowInfoData_B84DBEC5 source)
		{
			this.CopyShadowToPlain((Plc1.InfoData_B84DBEC5)source);
		}
	}
}