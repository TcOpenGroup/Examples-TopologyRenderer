using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"I1_StatusAT %I*I1_Status_DC9039207\" } {attribute addProperty CRC \"2195639286\" } {attribute addProperty Size \"7\" } {attribute addProperty Name \"\" }", "L1_Current_Status_82DECBF6", "Plc1", TypeComplexityEnum.Complex)]
	public partial class L1_Current_Status_82DECBF6 : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IL1_Current_Status_82DECBF6, IShadowL1_Current_Status_82DECBF6, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		I1_Status_DC903920 _I1_Status;
		[IoLinkable("Inputs")]
		public I1_Status_DC903920 I1_Status
		{
			get
			{
				return _I1_Status;
			}
		}

		[IoLinkable("Inputs")]
		II1_Status_DC903920 IL1_Current_Status_82DECBF6.I1_Status
		{
			get
			{
				return I1_Status;
			}
		}

		[IoLinkable("Inputs")]
		IShadowI1_Status_DC903920 IShadowL1_Current_Status_82DECBF6.I1_Status
		{
			get
			{
				return I1_Status;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			I1_Status.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			I1_Status.LazyShadowToOnline();
		}

		public new PlainL1_Current_Status_82DECBF6 CreatePlainerType()
		{
			var cloned = new PlainL1_Current_Status_82DECBF6();
			base.CreatePlainerType(cloned);
			cloned.I1_Status = I1_Status.CreatePlainerType();
			return cloned;
		}

		protected PlainL1_Current_Status_82DECBF6 CreatePlainerType(PlainL1_Current_Status_82DECBF6 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.I1_Status = I1_Status.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainL1_Current_Status_82DECBF6 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainL1_Current_Status_82DECBF6 source)
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

		public void FlushOnlineToPlain(Plc1.PlainL1_Current_Status_82DECBF6 source)
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

		public L1_Current_Status_82DECBF6(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_I1_Status = new I1_Status_DC903920(this, "I1_Status", "I1_Status");
			_I1_Status.AttributeName = "I1_Status";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "I1_StatusAT %I*I1_Status_DC9039207";
			AttributeCRC = "2195639286";
			AttributeSize = "7";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public L1_Current_Status_82DECBF6(): base ()
		{
			PexPreConstructorParameterless();
			_I1_Status = new I1_Status_DC903920();
			_I1_Status.AttributeName = "I1_Status";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "I1_StatusAT %I*I1_Status_DC9039207";
			AttributeCRC = "2195639286";
			AttributeSize = "7";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL1_Current_Status_82DECBF6
	{
		public void CopyPlainToCyclic(Plc1.L1_Current_Status_82DECBF6 target)
		{
			base.CopyPlainToCyclic(target);
			I1_Status.CopyPlainToCyclic(target.I1_Status);
		}

		public void CopyPlainToCyclic(Plc1.IL1_Current_Status_82DECBF6 target)
		{
			this.CopyPlainToCyclic((Plc1.L1_Current_Status_82DECBF6)target);
		}

		public void CopyPlainToShadow(Plc1.L1_Current_Status_82DECBF6 target)
		{
			base.CopyPlainToShadow(target);
			I1_Status.CopyPlainToShadow(target.I1_Status);
		}

		public void CopyPlainToShadow(Plc1.IShadowL1_Current_Status_82DECBF6 target)
		{
			this.CopyPlainToShadow((Plc1.L1_Current_Status_82DECBF6)target);
		}

		public void CopyCyclicToPlain(Plc1.L1_Current_Status_82DECBF6 source)
		{
			base.CopyCyclicToPlain(source);
			I1_Status.CopyCyclicToPlain(source.I1_Status);
		}

		public void CopyCyclicToPlain(Plc1.IL1_Current_Status_82DECBF6 source)
		{
			this.CopyCyclicToPlain((Plc1.L1_Current_Status_82DECBF6)source);
		}

		public void CopyShadowToPlain(Plc1.L1_Current_Status_82DECBF6 source)
		{
			base.CopyShadowToPlain(source);
			I1_Status.CopyShadowToPlain(source.I1_Status);
		}

		public void CopyShadowToPlain(Plc1.IShadowL1_Current_Status_82DECBF6 source)
		{
			this.CopyShadowToPlain((Plc1.L1_Current_Status_82DECBF6)source);
		}
	}
}