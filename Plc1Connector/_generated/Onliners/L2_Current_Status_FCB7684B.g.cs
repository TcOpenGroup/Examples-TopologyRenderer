using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"I2_StatusAT %I*I2_Status_DC9039207\" } {attribute addProperty CRC \"4239878219\" } {attribute addProperty Size \"7\" } {attribute addProperty Name \"\" }", "L2_Current_Status_FCB7684B", "Plc1", TypeComplexityEnum.Complex)]
	public partial class L2_Current_Status_FCB7684B : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IL2_Current_Status_FCB7684B, IShadowL2_Current_Status_FCB7684B, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		I2_Status_DC903920 _I2_Status;
		[IoLinkable("Inputs")]
		public I2_Status_DC903920 I2_Status
		{
			get
			{
				return _I2_Status;
			}
		}

		[IoLinkable("Inputs")]
		II2_Status_DC903920 IL2_Current_Status_FCB7684B.I2_Status
		{
			get
			{
				return I2_Status;
			}
		}

		[IoLinkable("Inputs")]
		IShadowI2_Status_DC903920 IShadowL2_Current_Status_FCB7684B.I2_Status
		{
			get
			{
				return I2_Status;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			I2_Status.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			I2_Status.LazyShadowToOnline();
		}

		public new PlainL2_Current_Status_FCB7684B CreatePlainerType()
		{
			var cloned = new PlainL2_Current_Status_FCB7684B();
			base.CreatePlainerType(cloned);
			cloned.I2_Status = I2_Status.CreatePlainerType();
			return cloned;
		}

		protected PlainL2_Current_Status_FCB7684B CreatePlainerType(PlainL2_Current_Status_FCB7684B cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.I2_Status = I2_Status.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainL2_Current_Status_FCB7684B source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainL2_Current_Status_FCB7684B source)
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

		public void FlushOnlineToPlain(Plc1.PlainL2_Current_Status_FCB7684B source)
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

		public L2_Current_Status_FCB7684B(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_I2_Status = new I2_Status_DC903920(this, "I2_Status", "I2_Status");
			_I2_Status.AttributeName = "I2_Status";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "I2_StatusAT %I*I2_Status_DC9039207";
			AttributeCRC = "4239878219";
			AttributeSize = "7";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public L2_Current_Status_FCB7684B(): base ()
		{
			PexPreConstructorParameterless();
			_I2_Status = new I2_Status_DC903920();
			_I2_Status.AttributeName = "I2_Status";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "I2_StatusAT %I*I2_Status_DC9039207";
			AttributeCRC = "4239878219";
			AttributeSize = "7";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL2_Current_Status_FCB7684B
	{
		public void CopyPlainToCyclic(Plc1.L2_Current_Status_FCB7684B target)
		{
			base.CopyPlainToCyclic(target);
			I2_Status.CopyPlainToCyclic(target.I2_Status);
		}

		public void CopyPlainToCyclic(Plc1.IL2_Current_Status_FCB7684B target)
		{
			this.CopyPlainToCyclic((Plc1.L2_Current_Status_FCB7684B)target);
		}

		public void CopyPlainToShadow(Plc1.L2_Current_Status_FCB7684B target)
		{
			base.CopyPlainToShadow(target);
			I2_Status.CopyPlainToShadow(target.I2_Status);
		}

		public void CopyPlainToShadow(Plc1.IShadowL2_Current_Status_FCB7684B target)
		{
			this.CopyPlainToShadow((Plc1.L2_Current_Status_FCB7684B)target);
		}

		public void CopyCyclicToPlain(Plc1.L2_Current_Status_FCB7684B source)
		{
			base.CopyCyclicToPlain(source);
			I2_Status.CopyCyclicToPlain(source.I2_Status);
		}

		public void CopyCyclicToPlain(Plc1.IL2_Current_Status_FCB7684B source)
		{
			this.CopyCyclicToPlain((Plc1.L2_Current_Status_FCB7684B)source);
		}

		public void CopyShadowToPlain(Plc1.L2_Current_Status_FCB7684B source)
		{
			base.CopyShadowToPlain(source);
			I2_Status.CopyShadowToPlain(source.I2_Status);
		}

		public void CopyShadowToPlain(Plc1.IShadowL2_Current_Status_FCB7684B source)
		{
			this.CopyShadowToPlain((Plc1.L2_Current_Status_FCB7684B)source);
		}
	}
}