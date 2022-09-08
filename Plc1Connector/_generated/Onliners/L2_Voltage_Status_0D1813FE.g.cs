using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"U2_StatusAT %I*U2_Status_DC9039207\" } {attribute addProperty CRC \"219681790\" } {attribute addProperty Size \"7\" } {attribute addProperty Name \"\" }", "L2_Voltage_Status_0D1813FE", "Plc1", TypeComplexityEnum.Complex)]
	public partial class L2_Voltage_Status_0D1813FE : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IL2_Voltage_Status_0D1813FE, IShadowL2_Voltage_Status_0D1813FE, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		U2_Status_DC903920 _U2_Status;
		[IoLinkable("Inputs")]
		public U2_Status_DC903920 U2_Status
		{
			get
			{
				return _U2_Status;
			}
		}

		[IoLinkable("Inputs")]
		IU2_Status_DC903920 IL2_Voltage_Status_0D1813FE.U2_Status
		{
			get
			{
				return U2_Status;
			}
		}

		[IoLinkable("Inputs")]
		IShadowU2_Status_DC903920 IShadowL2_Voltage_Status_0D1813FE.U2_Status
		{
			get
			{
				return U2_Status;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			U2_Status.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			U2_Status.LazyShadowToOnline();
		}

		public new PlainL2_Voltage_Status_0D1813FE CreatePlainerType()
		{
			var cloned = new PlainL2_Voltage_Status_0D1813FE();
			base.CreatePlainerType(cloned);
			cloned.U2_Status = U2_Status.CreatePlainerType();
			return cloned;
		}

		protected PlainL2_Voltage_Status_0D1813FE CreatePlainerType(PlainL2_Voltage_Status_0D1813FE cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.U2_Status = U2_Status.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainL2_Voltage_Status_0D1813FE source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainL2_Voltage_Status_0D1813FE source)
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

		public void FlushOnlineToPlain(Plc1.PlainL2_Voltage_Status_0D1813FE source)
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

		public L2_Voltage_Status_0D1813FE(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_U2_Status = new U2_Status_DC903920(this, "U2_Status", "U2_Status");
			_U2_Status.AttributeName = "U2_Status";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "U2_StatusAT %I*U2_Status_DC9039207";
			AttributeCRC = "219681790";
			AttributeSize = "7";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public L2_Voltage_Status_0D1813FE(): base ()
		{
			PexPreConstructorParameterless();
			_U2_Status = new U2_Status_DC903920();
			_U2_Status.AttributeName = "U2_Status";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "U2_StatusAT %I*U2_Status_DC9039207";
			AttributeCRC = "219681790";
			AttributeSize = "7";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL2_Voltage_Status_0D1813FE
	{
		public void CopyPlainToCyclic(Plc1.L2_Voltage_Status_0D1813FE target)
		{
			base.CopyPlainToCyclic(target);
			U2_Status.CopyPlainToCyclic(target.U2_Status);
		}

		public void CopyPlainToCyclic(Plc1.IL2_Voltage_Status_0D1813FE target)
		{
			this.CopyPlainToCyclic((Plc1.L2_Voltage_Status_0D1813FE)target);
		}

		public void CopyPlainToShadow(Plc1.L2_Voltage_Status_0D1813FE target)
		{
			base.CopyPlainToShadow(target);
			U2_Status.CopyPlainToShadow(target.U2_Status);
		}

		public void CopyPlainToShadow(Plc1.IShadowL2_Voltage_Status_0D1813FE target)
		{
			this.CopyPlainToShadow((Plc1.L2_Voltage_Status_0D1813FE)target);
		}

		public void CopyCyclicToPlain(Plc1.L2_Voltage_Status_0D1813FE source)
		{
			base.CopyCyclicToPlain(source);
			U2_Status.CopyCyclicToPlain(source.U2_Status);
		}

		public void CopyCyclicToPlain(Plc1.IL2_Voltage_Status_0D1813FE source)
		{
			this.CopyCyclicToPlain((Plc1.L2_Voltage_Status_0D1813FE)source);
		}

		public void CopyShadowToPlain(Plc1.L2_Voltage_Status_0D1813FE source)
		{
			base.CopyShadowToPlain(source);
			U2_Status.CopyShadowToPlain(source.U2_Status);
		}

		public void CopyShadowToPlain(Plc1.IShadowL2_Voltage_Status_0D1813FE source)
		{
			this.CopyShadowToPlain((Plc1.L2_Voltage_Status_0D1813FE)source);
		}
	}
}