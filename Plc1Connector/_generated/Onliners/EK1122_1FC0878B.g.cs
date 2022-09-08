using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty VendorId \"#x00000002\" } {attribute addProperty BoxType \"EK1122-0000-0018\" } {attribute addProperty Description \"EK1122 2 port EtherCAT junction\" } {attribute addProperty Physics \"KYKY\" } {attribute addProperty Id \"InfoDataAT %I*InfoData_6F19DB2B2\" } {attribute addProperty CRC \"532711307\" } {attribute addProperty Size \"2\" } {attribute addProperty Name \"\" }", "EK1122_1FC0878B", "Plc1", TypeComplexityEnum.Complex)]
	public partial class EK1122_1FC0878B : TcoIo.EtcSlaveTerminalBase_947E5A46, Vortex.Connector.IVortexObject, IEK1122_1FC0878B, IShadowEK1122_1FC0878B, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		TcoIo.InfoData_6F19DB2B _InfoData;
		public TcoIo.InfoData_6F19DB2B InfoData
		{
			get
			{
				return _InfoData;
			}
		}

		TcoIo.IInfoData_6F19DB2B IEK1122_1FC0878B.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		TcoIo.IShadowInfoData_6F19DB2B IShadowEK1122_1FC0878B.InfoData
		{
			get
			{
				return InfoData;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			InfoData.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			InfoData.LazyShadowToOnline();
		}

		public new PlainEK1122_1FC0878B CreatePlainerType()
		{
			var cloned = new PlainEK1122_1FC0878B();
			base.CreatePlainerType(cloned);
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		protected PlainEK1122_1FC0878B CreatePlainerType(PlainEK1122_1FC0878B cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.InfoData = InfoData.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainEK1122_1FC0878B source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainEK1122_1FC0878B source)
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

		public void FlushOnlineToPlain(Plc1.PlainEK1122_1FC0878B source)
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

		public EK1122_1FC0878B(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_InfoData = new TcoIo.InfoData_6F19DB2B(this, "InfoData", "InfoData");
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeDescription = "EK1122 2 port EtherCAT junction";
			AttributePhysics = "KYKY";
			AttributeId = "InfoDataAT %I*InfoData_6F19DB2B2";
			AttributeCRC = "532711307";
			AttributeSize = "2";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public EK1122_1FC0878B(): base ()
		{
			PexPreConstructorParameterless();
			_InfoData = new TcoIo.InfoData_6F19DB2B();
			_InfoData.AttributeName = "InfoData";
			AttributeVendorId = "#x00000002";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeDescription = "EK1122 2 port EtherCAT junction";
			AttributePhysics = "KYKY";
			AttributeId = "InfoDataAT %I*InfoData_6F19DB2B2";
			AttributeCRC = "532711307";
			AttributeSize = "2";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainEK1122_1FC0878B
	{
		public void CopyPlainToCyclic(Plc1.EK1122_1FC0878B target)
		{
			base.CopyPlainToCyclic(target);
			InfoData.CopyPlainToCyclic(target.InfoData);
		}

		public void CopyPlainToCyclic(Plc1.IEK1122_1FC0878B target)
		{
			this.CopyPlainToCyclic((Plc1.EK1122_1FC0878B)target);
		}

		public void CopyPlainToShadow(Plc1.EK1122_1FC0878B target)
		{
			base.CopyPlainToShadow(target);
			InfoData.CopyPlainToShadow(target.InfoData);
		}

		public void CopyPlainToShadow(Plc1.IShadowEK1122_1FC0878B target)
		{
			this.CopyPlainToShadow((Plc1.EK1122_1FC0878B)target);
		}

		public void CopyCyclicToPlain(Plc1.EK1122_1FC0878B source)
		{
			base.CopyCyclicToPlain(source);
			InfoData.CopyCyclicToPlain(source.InfoData);
		}

		public void CopyCyclicToPlain(Plc1.IEK1122_1FC0878B source)
		{
			this.CopyCyclicToPlain((Plc1.EK1122_1FC0878B)source);
		}

		public void CopyShadowToPlain(Plc1.EK1122_1FC0878B source)
		{
			base.CopyShadowToPlain(source);
			InfoData.CopyShadowToPlain(source.InfoData);
		}

		public void CopyShadowToPlain(Plc1.IShadowEK1122_1FC0878B source)
		{
			this.CopyShadowToPlain((Plc1.EK1122_1FC0878B)source);
		}
	}
}