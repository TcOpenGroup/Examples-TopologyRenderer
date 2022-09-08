using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"U3_StatusAT %I*U3_Status_DC9039207\" } {attribute addProperty CRC \"658469525\" } {attribute addProperty Size \"7\" } {attribute addProperty Name \"\" }", "L3_Voltage_Status_273F7295", "Plc1", TypeComplexityEnum.Complex)]
	public partial class L3_Voltage_Status_273F7295 : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IL3_Voltage_Status_273F7295, IShadowL3_Voltage_Status_273F7295, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		U3_Status_DC903920 _U3_Status;
		[IoLinkable("Inputs")]
		public U3_Status_DC903920 U3_Status
		{
			get
			{
				return _U3_Status;
			}
		}

		[IoLinkable("Inputs")]
		IU3_Status_DC903920 IL3_Voltage_Status_273F7295.U3_Status
		{
			get
			{
				return U3_Status;
			}
		}

		[IoLinkable("Inputs")]
		IShadowU3_Status_DC903920 IShadowL3_Voltage_Status_273F7295.U3_Status
		{
			get
			{
				return U3_Status;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			U3_Status.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			U3_Status.LazyShadowToOnline();
		}

		public new PlainL3_Voltage_Status_273F7295 CreatePlainerType()
		{
			var cloned = new PlainL3_Voltage_Status_273F7295();
			base.CreatePlainerType(cloned);
			cloned.U3_Status = U3_Status.CreatePlainerType();
			return cloned;
		}

		protected PlainL3_Voltage_Status_273F7295 CreatePlainerType(PlainL3_Voltage_Status_273F7295 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.U3_Status = U3_Status.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainL3_Voltage_Status_273F7295 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainL3_Voltage_Status_273F7295 source)
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

		public void FlushOnlineToPlain(Plc1.PlainL3_Voltage_Status_273F7295 source)
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

		public L3_Voltage_Status_273F7295(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_U3_Status = new U3_Status_DC903920(this, "U3_Status", "U3_Status");
			_U3_Status.AttributeName = "U3_Status";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "U3_StatusAT %I*U3_Status_DC9039207";
			AttributeCRC = "658469525";
			AttributeSize = "7";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public L3_Voltage_Status_273F7295(): base ()
		{
			PexPreConstructorParameterless();
			_U3_Status = new U3_Status_DC903920();
			_U3_Status.AttributeName = "U3_Status";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "U3_StatusAT %I*U3_Status_DC9039207";
			AttributeCRC = "658469525";
			AttributeSize = "7";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL3_Voltage_Status_273F7295
	{
		public void CopyPlainToCyclic(Plc1.L3_Voltage_Status_273F7295 target)
		{
			base.CopyPlainToCyclic(target);
			U3_Status.CopyPlainToCyclic(target.U3_Status);
		}

		public void CopyPlainToCyclic(Plc1.IL3_Voltage_Status_273F7295 target)
		{
			this.CopyPlainToCyclic((Plc1.L3_Voltage_Status_273F7295)target);
		}

		public void CopyPlainToShadow(Plc1.L3_Voltage_Status_273F7295 target)
		{
			base.CopyPlainToShadow(target);
			U3_Status.CopyPlainToShadow(target.U3_Status);
		}

		public void CopyPlainToShadow(Plc1.IShadowL3_Voltage_Status_273F7295 target)
		{
			this.CopyPlainToShadow((Plc1.L3_Voltage_Status_273F7295)target);
		}

		public void CopyCyclicToPlain(Plc1.L3_Voltage_Status_273F7295 source)
		{
			base.CopyCyclicToPlain(source);
			U3_Status.CopyCyclicToPlain(source.U3_Status);
		}

		public void CopyCyclicToPlain(Plc1.IL3_Voltage_Status_273F7295 source)
		{
			this.CopyCyclicToPlain((Plc1.L3_Voltage_Status_273F7295)source);
		}

		public void CopyShadowToPlain(Plc1.L3_Voltage_Status_273F7295 source)
		{
			base.CopyShadowToPlain(source);
			U3_Status.CopyShadowToPlain(source.U3_Status);
		}

		public void CopyShadowToPlain(Plc1.IShadowL3_Voltage_Status_273F7295 source)
		{
			this.CopyShadowToPlain((Plc1.L3_Voltage_Status_273F7295)source);
		}
	}
}