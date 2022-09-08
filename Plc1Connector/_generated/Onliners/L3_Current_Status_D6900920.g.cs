using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"I3_StatusAT %I*I3_Status_DC9039207\" } {attribute addProperty CRC \"3599763744\" } {attribute addProperty Size \"7\" } {attribute addProperty Name \"\" }", "L3_Current_Status_D6900920", "Plc1", TypeComplexityEnum.Complex)]
	public partial class L3_Current_Status_D6900920 : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IL3_Current_Status_D6900920, IShadowL3_Current_Status_D6900920, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		I3_Status_DC903920 _I3_Status;
		[IoLinkable("Inputs")]
		public I3_Status_DC903920 I3_Status
		{
			get
			{
				return _I3_Status;
			}
		}

		[IoLinkable("Inputs")]
		II3_Status_DC903920 IL3_Current_Status_D6900920.I3_Status
		{
			get
			{
				return I3_Status;
			}
		}

		[IoLinkable("Inputs")]
		IShadowI3_Status_DC903920 IShadowL3_Current_Status_D6900920.I3_Status
		{
			get
			{
				return I3_Status;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			I3_Status.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			I3_Status.LazyShadowToOnline();
		}

		public new PlainL3_Current_Status_D6900920 CreatePlainerType()
		{
			var cloned = new PlainL3_Current_Status_D6900920();
			base.CreatePlainerType(cloned);
			cloned.I3_Status = I3_Status.CreatePlainerType();
			return cloned;
		}

		protected PlainL3_Current_Status_D6900920 CreatePlainerType(PlainL3_Current_Status_D6900920 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.I3_Status = I3_Status.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainL3_Current_Status_D6900920 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainL3_Current_Status_D6900920 source)
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

		public void FlushOnlineToPlain(Plc1.PlainL3_Current_Status_D6900920 source)
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

		public L3_Current_Status_D6900920(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_I3_Status = new I3_Status_DC903920(this, "I3_Status", "I3_Status");
			_I3_Status.AttributeName = "I3_Status";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "I3_StatusAT %I*I3_Status_DC9039207";
			AttributeCRC = "3599763744";
			AttributeSize = "7";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public L3_Current_Status_D6900920(): base ()
		{
			PexPreConstructorParameterless();
			_I3_Status = new I3_Status_DC903920();
			_I3_Status.AttributeName = "I3_Status";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "I3_StatusAT %I*I3_Status_DC9039207";
			AttributeCRC = "3599763744";
			AttributeSize = "7";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainL3_Current_Status_D6900920
	{
		public void CopyPlainToCyclic(Plc1.L3_Current_Status_D6900920 target)
		{
			base.CopyPlainToCyclic(target);
			I3_Status.CopyPlainToCyclic(target.I3_Status);
		}

		public void CopyPlainToCyclic(Plc1.IL3_Current_Status_D6900920 target)
		{
			this.CopyPlainToCyclic((Plc1.L3_Current_Status_D6900920)target);
		}

		public void CopyPlainToShadow(Plc1.L3_Current_Status_D6900920 target)
		{
			base.CopyPlainToShadow(target);
			I3_Status.CopyPlainToShadow(target.I3_Status);
		}

		public void CopyPlainToShadow(Plc1.IShadowL3_Current_Status_D6900920 target)
		{
			this.CopyPlainToShadow((Plc1.L3_Current_Status_D6900920)target);
		}

		public void CopyCyclicToPlain(Plc1.L3_Current_Status_D6900920 source)
		{
			base.CopyCyclicToPlain(source);
			I3_Status.CopyCyclicToPlain(source.I3_Status);
		}

		public void CopyCyclicToPlain(Plc1.IL3_Current_Status_D6900920 source)
		{
			this.CopyCyclicToPlain((Plc1.L3_Current_Status_D6900920)source);
		}

		public void CopyShadowToPlain(Plc1.L3_Current_Status_D6900920 source)
		{
			base.CopyShadowToPlain(source);
			I3_Status.CopyShadowToPlain(source.I3_Status);
		}

		public void CopyShadowToPlain(Plc1.IShadowL3_Current_Status_D6900920 source)
		{
			this.CopyShadowToPlain((Plc1.L3_Current_Status_D6900920)source);
		}
	}
}