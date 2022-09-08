using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL2258-0000-0017\" } {attribute addProperty Id \"StatusAT %I*Status_642C2ED16\" } {attribute addProperty CRC \"1405132427\" } {attribute addProperty Size \"6\" } {attribute addProperty Name \"\" }", "MTO_Inputs_Channel_53C09E8B", "Plc1", TypeComplexityEnum.Complex)]
	public partial class MTO_Inputs_Channel_53C09E8B : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IMTO_Inputs_Channel_53C09E8B, IShadowMTO_Inputs_Channel_53C09E8B, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Status_642C2ED1 _Status;
		[IoLinkable("Inputs")]
		public Status_642C2ED1 Status
		{
			get
			{
				return _Status;
			}
		}

		[IoLinkable("Inputs")]
		IStatus_642C2ED1 IMTO_Inputs_Channel_53C09E8B.Status
		{
			get
			{
				return Status;
			}
		}

		[IoLinkable("Inputs")]
		IShadowStatus_642C2ED1 IShadowMTO_Inputs_Channel_53C09E8B.Status
		{
			get
			{
				return Status;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Status.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Status.LazyShadowToOnline();
		}

		public new PlainMTO_Inputs_Channel_53C09E8B CreatePlainerType()
		{
			var cloned = new PlainMTO_Inputs_Channel_53C09E8B();
			base.CreatePlainerType(cloned);
			cloned.Status = Status.CreatePlainerType();
			return cloned;
		}

		protected PlainMTO_Inputs_Channel_53C09E8B CreatePlainerType(PlainMTO_Inputs_Channel_53C09E8B cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Status = Status.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainMTO_Inputs_Channel_53C09E8B source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainMTO_Inputs_Channel_53C09E8B source)
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

		public void FlushOnlineToPlain(Plc1.PlainMTO_Inputs_Channel_53C09E8B source)
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

		public MTO_Inputs_Channel_53C09E8B(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Status = new Status_642C2ED1(this, "Status", "Status");
			_Status.AttributeName = "Status";
			AttributeBoxType = "EL2258-0000-0017";
			AttributeId = "StatusAT %I*Status_642C2ED16";
			AttributeCRC = "1405132427";
			AttributeSize = "6";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public MTO_Inputs_Channel_53C09E8B(): base ()
		{
			PexPreConstructorParameterless();
			_Status = new Status_642C2ED1();
			_Status.AttributeName = "Status";
			AttributeBoxType = "EL2258-0000-0017";
			AttributeId = "StatusAT %I*Status_642C2ED16";
			AttributeCRC = "1405132427";
			AttributeSize = "6";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainMTO_Inputs_Channel_53C09E8B
	{
		public void CopyPlainToCyclic(Plc1.MTO_Inputs_Channel_53C09E8B target)
		{
			base.CopyPlainToCyclic(target);
			Status.CopyPlainToCyclic(target.Status);
		}

		public void CopyPlainToCyclic(Plc1.IMTO_Inputs_Channel_53C09E8B target)
		{
			this.CopyPlainToCyclic((Plc1.MTO_Inputs_Channel_53C09E8B)target);
		}

		public void CopyPlainToShadow(Plc1.MTO_Inputs_Channel_53C09E8B target)
		{
			base.CopyPlainToShadow(target);
			Status.CopyPlainToShadow(target.Status);
		}

		public void CopyPlainToShadow(Plc1.IShadowMTO_Inputs_Channel_53C09E8B target)
		{
			this.CopyPlainToShadow((Plc1.MTO_Inputs_Channel_53C09E8B)target);
		}

		public void CopyCyclicToPlain(Plc1.MTO_Inputs_Channel_53C09E8B source)
		{
			base.CopyCyclicToPlain(source);
			Status.CopyCyclicToPlain(source.Status);
		}

		public void CopyCyclicToPlain(Plc1.IMTO_Inputs_Channel_53C09E8B source)
		{
			this.CopyCyclicToPlain((Plc1.MTO_Inputs_Channel_53C09E8B)source);
		}

		public void CopyShadowToPlain(Plc1.MTO_Inputs_Channel_53C09E8B source)
		{
			base.CopyShadowToPlain(source);
			Status.CopyShadowToPlain(source.Status);
		}

		public void CopyShadowToPlain(Plc1.IShadowMTO_Inputs_Channel_53C09E8B source)
		{
			this.CopyShadowToPlain((Plc1.MTO_Inputs_Channel_53C09E8B)source);
		}
	}
}