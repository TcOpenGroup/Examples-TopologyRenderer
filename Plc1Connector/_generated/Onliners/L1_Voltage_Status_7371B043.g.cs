using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"U1_StatusAT %I*U1_Status_DC9039207\" } {attribute addProperty CRC \"1936830531\" } {attribute addProperty Size \"7\" } {attribute addProperty Name \"\" }", "L1_Voltage_Status_7371B043", "Plc1", TypeComplexityEnum.Complex)]
	public partial class L1_Voltage_Status_7371B043 : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IL1_Voltage_Status_7371B043, IShadowL1_Voltage_Status_7371B043, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		U1_Status_DC903920 _U1_Status;
		[IoLinkable("Inputs")]
		public U1_Status_DC903920 U1_Status
		{
			get
			{
				return _U1_Status;
			}
		}

		[IoLinkable("Inputs")]
		IU1_Status_DC903920 IL1_Voltage_Status_7371B043.U1_Status
		{
			get
			{
				return U1_Status;
			}
		}

		[IoLinkable("Inputs")]
		IShadowU1_Status_DC903920 IShadowL1_Voltage_Status_7371B043.U1_Status
		{
			get
			{
				return U1_Status;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			U1_Status.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			U1_Status.LazyShadowToOnline();
		}

		public new PlainL1_Voltage_Status_7371B043 CreatePlainerType()
		{
			var cloned = new PlainL1_Voltage_Status_7371B043();
			base.CreatePlainerType(cloned);
			cloned.U1_Status = U1_Status.CreatePlainerType();
			return cloned;
		}

		protected PlainL1_Voltage_Status_7371B043 CreatePlainerType(PlainL1_Voltage_Status_7371B043 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.U1_Status = U1_Status.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainL1_Voltage_Status_7371B043 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainL1_Voltage_Status_7371B043 source)
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

		public void FlushOnlineToPlain(Plc1.PlainL1_Voltage_Status_7371B043 source)
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

		public L1_Voltage_Status_7371B043(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_U1_Status = new U1_Status_DC903920(this, "U1_Status", "U1_Status");
			_U1_Status.AttributeName = "U1_Status";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "U1_StatusAT %I*U1_Status_DC9039207";
			AttributeCRC = "1936830531";
			AttributeSize = "7";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public L1_Voltage_Status_7371B043(): base ()
		{
			PexPreConstructorParameterless();
			_U1_Status = new U1_Status_DC903920();
			_U1_Status.AttributeName = "U1_Status";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "U1_StatusAT %I*U1_Status_DC9039207";
			AttributeCRC = "1936830531";
			AttributeSize = "7";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL1_Voltage_Status_7371B043
	{
		public void CopyPlainToCyclic(Plc1.L1_Voltage_Status_7371B043 target)
		{
			base.CopyPlainToCyclic(target);
			U1_Status.CopyPlainToCyclic(target.U1_Status);
		}

		public void CopyPlainToCyclic(Plc1.IL1_Voltage_Status_7371B043 target)
		{
			this.CopyPlainToCyclic((Plc1.L1_Voltage_Status_7371B043)target);
		}

		public void CopyPlainToShadow(Plc1.L1_Voltage_Status_7371B043 target)
		{
			base.CopyPlainToShadow(target);
			U1_Status.CopyPlainToShadow(target.U1_Status);
		}

		public void CopyPlainToShadow(Plc1.IShadowL1_Voltage_Status_7371B043 target)
		{
			this.CopyPlainToShadow((Plc1.L1_Voltage_Status_7371B043)target);
		}

		public void CopyCyclicToPlain(Plc1.L1_Voltage_Status_7371B043 source)
		{
			base.CopyCyclicToPlain(source);
			U1_Status.CopyCyclicToPlain(source.U1_Status);
		}

		public void CopyCyclicToPlain(Plc1.IL1_Voltage_Status_7371B043 source)
		{
			this.CopyCyclicToPlain((Plc1.L1_Voltage_Status_7371B043)source);
		}

		public void CopyShadowToPlain(Plc1.L1_Voltage_Status_7371B043 source)
		{
			base.CopyShadowToPlain(source);
			U1_Status.CopyShadowToPlain(source.U1_Status);
		}

		public void CopyShadowToPlain(Plc1.IShadowL1_Voltage_Status_7371B043 source)
		{
			this.CopyShadowToPlain((Plc1.L1_Voltage_Status_7371B043)source);
		}
	}
}