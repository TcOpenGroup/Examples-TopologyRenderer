using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty VendorId \"#x00000002\" } {attribute addProperty BoxType \"EL9011--0000\" } {attribute addProperty Description \"EL9011 End Terminal\" } {attribute addProperty Physics \"\" } {attribute addProperty Id \"EL9011\" } {attribute addProperty CRC \"3596434738\" } {attribute addProperty Size \"0\" } {attribute addProperty Name \"\" }", "EL9011_D65D3D32", "Plc1", TypeComplexityEnum.Complex)]
	public partial class EL9011_D65D3D32 : TcoIo.EtcSlaveEndTerminalBase_866C7F0C, Vortex.Connector.IVortexObject, IEL9011_D65D3D32, IShadowEL9011_D65D3D32, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
		}

		public new PlainEL9011_D65D3D32 CreatePlainerType()
		{
			var cloned = new PlainEL9011_D65D3D32();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainEL9011_D65D3D32 CreatePlainerType(PlainEL9011_D65D3D32 cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainEL9011_D65D3D32 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainEL9011_D65D3D32 source)
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

		public void FlushOnlineToPlain(Plc1.PlainEL9011_D65D3D32 source)
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

		public EL9011_D65D3D32(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL9011--0000";
			AttributeDescription = "EL9011 End Terminal";
			AttributePhysics = "";
			AttributeId = "EL9011";
			AttributeCRC = "3596434738";
			AttributeSize = "0";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public EL9011_D65D3D32(): base ()
		{
			PexPreConstructorParameterless();
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EL9011--0000";
			AttributeDescription = "EL9011 End Terminal";
			AttributePhysics = "";
			AttributeId = "EL9011";
			AttributeCRC = "3596434738";
			AttributeSize = "0";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEL9011_D65D3D32
	{
		public void CopyPlainToCyclic(Plc1.EL9011_D65D3D32 target)
		{
			base.CopyPlainToCyclic(target);
		}

		public void CopyPlainToCyclic(Plc1.IEL9011_D65D3D32 target)
		{
			this.CopyPlainToCyclic((Plc1.EL9011_D65D3D32)target);
		}

		public void CopyPlainToShadow(Plc1.EL9011_D65D3D32 target)
		{
			base.CopyPlainToShadow(target);
		}

		public void CopyPlainToShadow(Plc1.IShadowEL9011_D65D3D32 target)
		{
			this.CopyPlainToShadow((Plc1.EL9011_D65D3D32)target);
		}

		public void CopyCyclicToPlain(Plc1.EL9011_D65D3D32 source)
		{
			base.CopyCyclicToPlain(source);
		}

		public void CopyCyclicToPlain(Plc1.IEL9011_D65D3D32 source)
		{
			this.CopyCyclicToPlain((Plc1.EL9011_D65D3D32)source);
		}

		public void CopyShadowToPlain(Plc1.EL9011_D65D3D32 source)
		{
			base.CopyShadowToPlain(source);
		}

		public void CopyShadowToPlain(Plc1.IShadowEL9011_D65D3D32 source)
		{
			this.CopyShadowToPlain((Plc1.EL9011_D65D3D32)source);
		}
	}
}