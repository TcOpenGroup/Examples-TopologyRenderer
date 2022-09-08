using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty VendorId \"#x00000002\" } {attribute addProperty BoxType \"EK1200-1388-0000\" } {attribute addProperty Description \"EK1200-5000 EtherCAT Power supply (2A E-Bus)\" } {attribute addProperty Physics \"YK\" } {attribute addProperty Id \"EK1200\" } {attribute addProperty CRC \"20777801\" } {attribute addProperty Size \"0\" } {attribute addProperty Name \"\" }", "EK1200_013D0B49", "Plc1", TypeComplexityEnum.Complex)]
	public partial class EK1200_013D0B49 : TcoIo.EtcSlaveBoxBase_77A0E4A7, Vortex.Connector.IVortexObject, IEK1200_013D0B49, IShadowEK1200_013D0B49, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
		}

		public new PlainEK1200_013D0B49 CreatePlainerType()
		{
			var cloned = new PlainEK1200_013D0B49();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainEK1200_013D0B49 CreatePlainerType(PlainEK1200_013D0B49 cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainEK1200_013D0B49 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainEK1200_013D0B49 source)
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

		public void FlushOnlineToPlain(Plc1.PlainEK1200_013D0B49 source)
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

		public EK1200_013D0B49(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EK1200-1388-0000";
			AttributeDescription = "EK1200-5000 EtherCAT Power supply (2A E-Bus)";
			AttributePhysics = "YK";
			AttributeId = "EK1200";
			AttributeCRC = "20777801";
			AttributeSize = "0";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public EK1200_013D0B49(): base ()
		{
			PexPreConstructorParameterless();
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EK1200-1388-0000";
			AttributeDescription = "EK1200-5000 EtherCAT Power supply (2A E-Bus)";
			AttributePhysics = "YK";
			AttributeId = "EK1200";
			AttributeCRC = "20777801";
			AttributeSize = "0";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEK1200_013D0B49
	{
		public void CopyPlainToCyclic(Plc1.EK1200_013D0B49 target)
		{
			base.CopyPlainToCyclic(target);
		}

		public void CopyPlainToCyclic(Plc1.IEK1200_013D0B49 target)
		{
			this.CopyPlainToCyclic((Plc1.EK1200_013D0B49)target);
		}

		public void CopyPlainToShadow(Plc1.EK1200_013D0B49 target)
		{
			base.CopyPlainToShadow(target);
		}

		public void CopyPlainToShadow(Plc1.IShadowEK1200_013D0B49 target)
		{
			this.CopyPlainToShadow((Plc1.EK1200_013D0B49)target);
		}

		public void CopyCyclicToPlain(Plc1.EK1200_013D0B49 source)
		{
			base.CopyCyclicToPlain(source);
		}

		public void CopyCyclicToPlain(Plc1.IEK1200_013D0B49 source)
		{
			this.CopyCyclicToPlain((Plc1.EK1200_013D0B49)source);
		}

		public void CopyShadowToPlain(Plc1.EK1200_013D0B49 source)
		{
			base.CopyShadowToPlain(source);
		}

		public void CopyShadowToPlain(Plc1.IShadowEK1200_013D0B49 source)
		{
			this.CopyShadowToPlain((Plc1.EK1200_013D0B49)source);
		}
	}
}