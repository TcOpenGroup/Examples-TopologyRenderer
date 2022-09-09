using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_43_EL1008EL1008_78E8D3DD12Term_44_EL1008EL1008_78E8D3DD12\" } {attribute addProperty CRC \"272233156\" } {attribute addProperty Size \"24\" } {attribute addProperty Name \"Term 42 (EK1100)\" }", "Term_42_EK1100_1039F2C4", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_42_EK1100_1039F2C4 : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_42_EK1100_1039F2C4, IShadowTerm_42_EK1100_1039F2C4, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		EL1008_78E8D3DD _Term_43_EL1008;
		public EL1008_78E8D3DD Term_43_EL1008
		{
			get
			{
				return _Term_43_EL1008;
			}
		}

		IEL1008_78E8D3DD ITerm_42_EK1100_1039F2C4.Term_43_EL1008
		{
			get
			{
				return Term_43_EL1008;
			}
		}

		IShadowEL1008_78E8D3DD IShadowTerm_42_EK1100_1039F2C4.Term_43_EL1008
		{
			get
			{
				return Term_43_EL1008;
			}
		}

		EL1008_78E8D3DD _Term_44_EL1008;
		public EL1008_78E8D3DD Term_44_EL1008
		{
			get
			{
				return _Term_44_EL1008;
			}
		}

		IEL1008_78E8D3DD ITerm_42_EK1100_1039F2C4.Term_44_EL1008
		{
			get
			{
				return Term_44_EL1008;
			}
		}

		IShadowEL1008_78E8D3DD IShadowTerm_42_EK1100_1039F2C4.Term_44_EL1008
		{
			get
			{
				return Term_44_EL1008;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_43_EL1008.LazyOnlineToShadow();
			Term_44_EL1008.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_43_EL1008.LazyShadowToOnline();
			Term_44_EL1008.LazyShadowToOnline();
		}

		public new PlainTerm_42_EK1100_1039F2C4 CreatePlainerType()
		{
			var cloned = new PlainTerm_42_EK1100_1039F2C4();
			base.CreatePlainerType(cloned);
			cloned.Term_43_EL1008 = Term_43_EL1008.CreatePlainerType();
			cloned.Term_44_EL1008 = Term_44_EL1008.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_42_EK1100_1039F2C4 CreatePlainerType(PlainTerm_42_EK1100_1039F2C4 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_43_EL1008 = Term_43_EL1008.CreatePlainerType();
			cloned.Term_44_EL1008 = Term_44_EL1008.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_42_EK1100_1039F2C4 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_42_EK1100_1039F2C4 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_42_EK1100_1039F2C4 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_42_EK1100_1039F2C4(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_43_EL1008 = new EL1008_78E8D3DD(this, "Term 43 (EL1008)", "Term_43_EL1008");
			_Term_43_EL1008.AttributeName = "Term 43 (EL1008)";
			_Term_43_EL1008.AttributePreviousPort = "Term 42 (EK1100) : B";
			_Term_43_EL1008.AttributeSyncUnit = "default";
			_Term_44_EL1008 = new EL1008_78E8D3DD(this, "Term 44 (EL1008)", "Term_44_EL1008");
			_Term_44_EL1008.AttributeName = "Term 44 (EL1008)";
			_Term_44_EL1008.AttributePreviousPort = "Term 43 (EL1008) : B";
			_Term_44_EL1008.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_43_EL1008EL1008_78E8D3DD12Term_44_EL1008EL1008_78E8D3DD12";
			AttributeCRC = "272233156";
			AttributeSize = "24";
			AttributeName = "Term 42 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_42_EK1100_1039F2C4(): base ()
		{
			PexPreConstructorParameterless();
			_Term_43_EL1008 = new EL1008_78E8D3DD();
			_Term_43_EL1008.AttributeName = "Term 43 (EL1008)";
			_Term_43_EL1008.AttributePreviousPort = "Term 42 (EK1100) : B";
			_Term_43_EL1008.AttributeSyncUnit = "default";
			_Term_44_EL1008 = new EL1008_78E8D3DD();
			_Term_44_EL1008.AttributeName = "Term 44 (EL1008)";
			_Term_44_EL1008.AttributePreviousPort = "Term 43 (EL1008) : B";
			_Term_44_EL1008.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_43_EL1008EL1008_78E8D3DD12Term_44_EL1008EL1008_78E8D3DD12";
			AttributeCRC = "272233156";
			AttributeSize = "24";
			AttributeName = "Term 42 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_42_EK1100_1039F2C4
	{
		public void CopyPlainToCyclic(Plc1.Term_42_EK1100_1039F2C4 target)
		{
			base.CopyPlainToCyclic(target);
			Term_43_EL1008.CopyPlainToCyclic(target.Term_43_EL1008);
			Term_44_EL1008.CopyPlainToCyclic(target.Term_44_EL1008);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_42_EK1100_1039F2C4 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_42_EK1100_1039F2C4)target);
		}

		public void CopyPlainToShadow(Plc1.Term_42_EK1100_1039F2C4 target)
		{
			base.CopyPlainToShadow(target);
			Term_43_EL1008.CopyPlainToShadow(target.Term_43_EL1008);
			Term_44_EL1008.CopyPlainToShadow(target.Term_44_EL1008);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_42_EK1100_1039F2C4 target)
		{
			this.CopyPlainToShadow((Plc1.Term_42_EK1100_1039F2C4)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_42_EK1100_1039F2C4 source)
		{
			base.CopyCyclicToPlain(source);
			Term_43_EL1008.CopyCyclicToPlain(source.Term_43_EL1008);
			Term_44_EL1008.CopyCyclicToPlain(source.Term_44_EL1008);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_42_EK1100_1039F2C4 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_42_EK1100_1039F2C4)source);
		}

		public void CopyShadowToPlain(Plc1.Term_42_EK1100_1039F2C4 source)
		{
			base.CopyShadowToPlain(source);
			Term_43_EL1008.CopyShadowToPlain(source.Term_43_EL1008);
			Term_44_EL1008.CopyShadowToPlain(source.Term_44_EL1008);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_42_EK1100_1039F2C4 source)
		{
			this.CopyShadowToPlain((Plc1.Term_42_EK1100_1039F2C4)source);
		}
	}
}