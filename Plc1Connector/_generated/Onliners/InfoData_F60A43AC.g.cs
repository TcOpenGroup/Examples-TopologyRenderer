using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"AX5101-0000-0214-0214\" } {attribute addProperty Id \"AdsAddrAT %I*TcoIo.TcoAmsAddr0DcOutputShiftAT %I*DINT4DcInputShiftAT %I*DINT4Chn0AT %I*USINT1StateAT %I*UINT2\" } {attribute addProperty CRC \"4127867820\" } {attribute addProperty Size \"11\" } {attribute addProperty Name \"\" }", "InfoData_F60A43AC", "Plc1", TypeComplexityEnum.Complex)]
	public partial class InfoData_F60A43AC : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IInfoData_F60A43AC, IShadowInfoData_F60A43AC, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		TcoIo.ITcoAmsAddr IInfoData_F60A43AC.AdsAddr
		{
			get
			{
				return AdsAddr;
			}
		}

		[IoLinkable("Inputs")]
		TcoIo.IShadowTcoAmsAddr IShadowInfoData_F60A43AC.AdsAddr
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
		Vortex.Connector.ValueTypes.Online.IOnlineDInt IInfoData_F60A43AC.DcOutputShift
		{
			get
			{
				return DcOutputShift;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowInfoData_F60A43AC.DcOutputShift
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
		Vortex.Connector.ValueTypes.Online.IOnlineDInt IInfoData_F60A43AC.DcInputShift
		{
			get
			{
				return DcInputShift;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowInfoData_F60A43AC.DcInputShift
		{
			get
			{
				return DcInputShift;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUSInt _Chn0;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerUSInt Chn0
		{
			get
			{
				return _Chn0;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineUSInt IInfoData_F60A43AC.Chn0
		{
			get
			{
				return Chn0;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt IShadowInfoData_F60A43AC.Chn0
		{
			get
			{
				return Chn0;
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
		Vortex.Connector.ValueTypes.Online.IOnlineUInt IInfoData_F60A43AC.State
		{
			get
			{
				return State;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowInfoData_F60A43AC.State
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
			Chn0.Shadow = Chn0.LastValue;
			State.Shadow = State.LastValue;
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			AdsAddr.LazyShadowToOnline();
			DcOutputShift.Cyclic = DcOutputShift.Shadow;
			DcInputShift.Cyclic = DcInputShift.Shadow;
			Chn0.Cyclic = Chn0.Shadow;
			State.Cyclic = State.Shadow;
		}

		public new PlainInfoData_F60A43AC CreatePlainerType()
		{
			var cloned = new PlainInfoData_F60A43AC();
			base.CreatePlainerType(cloned);
			cloned.AdsAddr = AdsAddr.CreatePlainerType();
			return cloned;
		}

		protected PlainInfoData_F60A43AC CreatePlainerType(PlainInfoData_F60A43AC cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.AdsAddr = AdsAddr.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainInfoData_F60A43AC source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainInfoData_F60A43AC source)
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

		public void FlushOnlineToPlain(Plc1.PlainInfoData_F60A43AC source)
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

		public InfoData_F60A43AC(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
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
			_Chn0 = @Connector.Online.Adapter.CreateUSINT(this, "Chn0", "Chn0");
			Chn0.AttributeName = "Chn0";
			_State = @Connector.Online.Adapter.CreateUINT(this, "State", "State");
			State.AttributeName = "State";
			AttributeBoxType = "AX5101-0000-0214-0214";
			AttributeId = "AdsAddrAT %I*TcoIo.TcoAmsAddr0DcOutputShiftAT %I*DINT4DcInputShiftAT %I*DINT4Chn0AT %I*USINT1StateAT %I*UINT2";
			AttributeCRC = "4127867820";
			AttributeSize = "11";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public InfoData_F60A43AC(): base ()
		{
			PexPreConstructorParameterless();
			_AdsAddr = new TcoIo.TcoAmsAddr();
			_AdsAddr.AttributeName = "AdsAddr";
			_DcOutputShift = Vortex.Connector.IConnectorFactory.CreateDINT();
			DcOutputShift.AttributeName = "DcOutputShift";
			_DcInputShift = Vortex.Connector.IConnectorFactory.CreateDINT();
			DcInputShift.AttributeName = "DcInputShift";
			_Chn0 = Vortex.Connector.IConnectorFactory.CreateUSINT();
			Chn0.AttributeName = "Chn0";
			_State = Vortex.Connector.IConnectorFactory.CreateUINT();
			State.AttributeName = "State";
			AttributeBoxType = "AX5101-0000-0214-0214";
			AttributeId = "AdsAddrAT %I*TcoIo.TcoAmsAddr0DcOutputShiftAT %I*DINT4DcInputShiftAT %I*DINT4Chn0AT %I*USINT1StateAT %I*UINT2";
			AttributeCRC = "4127867820";
			AttributeSize = "11";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainInfoData_F60A43AC
	{
		public void CopyPlainToCyclic(Plc1.InfoData_F60A43AC target)
		{
			base.CopyPlainToCyclic(target);
			AdsAddr.CopyPlainToCyclic(target.AdsAddr);
			target.DcOutputShift.Cyclic = DcOutputShift;
			target.DcInputShift.Cyclic = DcInputShift;
			target.Chn0.Cyclic = Chn0;
			target.State.Cyclic = State;
		}

		public void CopyPlainToCyclic(Plc1.IInfoData_F60A43AC target)
		{
			this.CopyPlainToCyclic((Plc1.InfoData_F60A43AC)target);
		}

		public void CopyPlainToShadow(Plc1.InfoData_F60A43AC target)
		{
			base.CopyPlainToShadow(target);
			AdsAddr.CopyPlainToShadow(target.AdsAddr);
			target.DcOutputShift.Shadow = DcOutputShift;
			target.DcInputShift.Shadow = DcInputShift;
			target.Chn0.Shadow = Chn0;
			target.State.Shadow = State;
		}

		public void CopyPlainToShadow(Plc1.IShadowInfoData_F60A43AC target)
		{
			this.CopyPlainToShadow((Plc1.InfoData_F60A43AC)target);
		}

		public void CopyCyclicToPlain(Plc1.InfoData_F60A43AC source)
		{
			base.CopyCyclicToPlain(source);
			AdsAddr.CopyCyclicToPlain(source.AdsAddr);
			DcOutputShift = source.DcOutputShift.LastValue;
			DcInputShift = source.DcInputShift.LastValue;
			Chn0 = source.Chn0.LastValue;
			State = source.State.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.IInfoData_F60A43AC source)
		{
			this.CopyCyclicToPlain((Plc1.InfoData_F60A43AC)source);
		}

		public void CopyShadowToPlain(Plc1.InfoData_F60A43AC source)
		{
			base.CopyShadowToPlain(source);
			AdsAddr.CopyShadowToPlain(source.AdsAddr);
			DcOutputShift = source.DcOutputShift.Shadow;
			DcInputShift = source.DcInputShift.Shadow;
			Chn0 = source.Chn0.Shadow;
			State = source.State.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowInfoData_F60A43AC source)
		{
			this.CopyShadowToPlain((Plc1.InfoData_F60A43AC)source);
		}
	}
}