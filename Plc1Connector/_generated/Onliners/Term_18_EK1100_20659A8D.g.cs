using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_19_EL1809EL1809_32157CFD20Term_20_EL2809EL2809_2B6483BD19Term_21_EL1809EL1809_32157CFD20Term_22_EL3011EL3011_7A49522813Term_29_EL9011EL9011_D65D3D320\" } {attribute addProperty CRC \"543529613\" } {attribute addProperty Size \"72\" } {attribute addProperty Name \"Term 18 (EK1100)\" }", "Term_18_EK1100_20659A8D", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_18_EK1100_20659A8D : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_18_EK1100_20659A8D, IShadowTerm_18_EK1100_20659A8D, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		EL1809_32157CFD _Term_19_EL1809;
		public EL1809_32157CFD Term_19_EL1809
		{
			get
			{
				return _Term_19_EL1809;
			}
		}

		IEL1809_32157CFD ITerm_18_EK1100_20659A8D.Term_19_EL1809
		{
			get
			{
				return Term_19_EL1809;
			}
		}

		IShadowEL1809_32157CFD IShadowTerm_18_EK1100_20659A8D.Term_19_EL1809
		{
			get
			{
				return Term_19_EL1809;
			}
		}

		EL2809_2B6483BD _Term_20_EL2809;
		public EL2809_2B6483BD Term_20_EL2809
		{
			get
			{
				return _Term_20_EL2809;
			}
		}

		IEL2809_2B6483BD ITerm_18_EK1100_20659A8D.Term_20_EL2809
		{
			get
			{
				return Term_20_EL2809;
			}
		}

		IShadowEL2809_2B6483BD IShadowTerm_18_EK1100_20659A8D.Term_20_EL2809
		{
			get
			{
				return Term_20_EL2809;
			}
		}

		EL1809_32157CFD _Term_21_EL1809;
		public EL1809_32157CFD Term_21_EL1809
		{
			get
			{
				return _Term_21_EL1809;
			}
		}

		IEL1809_32157CFD ITerm_18_EK1100_20659A8D.Term_21_EL1809
		{
			get
			{
				return Term_21_EL1809;
			}
		}

		IShadowEL1809_32157CFD IShadowTerm_18_EK1100_20659A8D.Term_21_EL1809
		{
			get
			{
				return Term_21_EL1809;
			}
		}

		EL3011_7A495228 _Term_22_EL3011;
		public EL3011_7A495228 Term_22_EL3011
		{
			get
			{
				return _Term_22_EL3011;
			}
		}

		IEL3011_7A495228 ITerm_18_EK1100_20659A8D.Term_22_EL3011
		{
			get
			{
				return Term_22_EL3011;
			}
		}

		IShadowEL3011_7A495228 IShadowTerm_18_EK1100_20659A8D.Term_22_EL3011
		{
			get
			{
				return Term_22_EL3011;
			}
		}

		EL9011_D65D3D32 _Term_29_EL9011;
		public EL9011_D65D3D32 Term_29_EL9011
		{
			get
			{
				return _Term_29_EL9011;
			}
		}

		IEL9011_D65D3D32 ITerm_18_EK1100_20659A8D.Term_29_EL9011
		{
			get
			{
				return Term_29_EL9011;
			}
		}

		IShadowEL9011_D65D3D32 IShadowTerm_18_EK1100_20659A8D.Term_29_EL9011
		{
			get
			{
				return Term_29_EL9011;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_19_EL1809.LazyOnlineToShadow();
			Term_20_EL2809.LazyOnlineToShadow();
			Term_21_EL1809.LazyOnlineToShadow();
			Term_22_EL3011.LazyOnlineToShadow();
			Term_29_EL9011.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_19_EL1809.LazyShadowToOnline();
			Term_20_EL2809.LazyShadowToOnline();
			Term_21_EL1809.LazyShadowToOnline();
			Term_22_EL3011.LazyShadowToOnline();
			Term_29_EL9011.LazyShadowToOnline();
		}

		public new PlainTerm_18_EK1100_20659A8D CreatePlainerType()
		{
			var cloned = new PlainTerm_18_EK1100_20659A8D();
			base.CreatePlainerType(cloned);
			cloned.Term_19_EL1809 = Term_19_EL1809.CreatePlainerType();
			cloned.Term_20_EL2809 = Term_20_EL2809.CreatePlainerType();
			cloned.Term_21_EL1809 = Term_21_EL1809.CreatePlainerType();
			cloned.Term_22_EL3011 = Term_22_EL3011.CreatePlainerType();
			cloned.Term_29_EL9011 = Term_29_EL9011.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_18_EK1100_20659A8D CreatePlainerType(PlainTerm_18_EK1100_20659A8D cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_19_EL1809 = Term_19_EL1809.CreatePlainerType();
			cloned.Term_20_EL2809 = Term_20_EL2809.CreatePlainerType();
			cloned.Term_21_EL1809 = Term_21_EL1809.CreatePlainerType();
			cloned.Term_22_EL3011 = Term_22_EL3011.CreatePlainerType();
			cloned.Term_29_EL9011 = Term_29_EL9011.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_18_EK1100_20659A8D source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_18_EK1100_20659A8D source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_18_EK1100_20659A8D source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_18_EK1100_20659A8D(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_19_EL1809 = new EL1809_32157CFD(this, "Term 19 (EL1809)", "Term_19_EL1809");
			_Term_19_EL1809.AttributeName = "Term 19 (EL1809)";
			_Term_19_EL1809.AttributePreviousPort = "Term 18 (EK1100) : B";
			_Term_19_EL1809.AttributeSyncUnit = "Row_1";
			_Term_20_EL2809 = new EL2809_2B6483BD(this, "Term 20 (EL2809)", "Term_20_EL2809");
			_Term_20_EL2809.AttributeName = "Term 20 (EL2809)";
			_Term_20_EL2809.AttributePreviousPort = "Term 19 (EL1809) : B";
			_Term_20_EL2809.AttributeSyncUnit = "Row_1";
			_Term_21_EL1809 = new EL1809_32157CFD(this, "Term 21 (EL1809)", "Term_21_EL1809");
			_Term_21_EL1809.AttributeName = "Term 21 (EL1809)";
			_Term_21_EL1809.AttributePreviousPort = "Term 20 (EL2809) : B";
			_Term_21_EL1809.AttributeSyncUnit = "Row_1";
			_Term_22_EL3011 = new EL3011_7A495228(this, "Term 22 (EL3011)", "Term_22_EL3011");
			_Term_22_EL3011.AttributeName = "Term 22 (EL3011)";
			_Term_22_EL3011.AttributePreviousPort = "Term 21 (EL1809) : B";
			_Term_22_EL3011.AttributeSyncUnit = "Row_1";
			_Term_29_EL9011 = new EL9011_D65D3D32(this, "Term 29 (EL9011)", "Term_29_EL9011");
			_Term_29_EL9011.AttributeName = "Term 29 (EL9011)";
			_Term_29_EL9011.AttributePreviousPort = "Term 22 (EL3011) : B";
			_Term_29_EL9011.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_19_EL1809EL1809_32157CFD20Term_20_EL2809EL2809_2B6483BD19Term_21_EL1809EL1809_32157CFD20Term_22_EL3011EL3011_7A49522813Term_29_EL9011EL9011_D65D3D320";
			AttributeCRC = "543529613";
			AttributeSize = "72";
			AttributeName = "Term 18 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_18_EK1100_20659A8D(): base ()
		{
			PexPreConstructorParameterless();
			_Term_19_EL1809 = new EL1809_32157CFD();
			_Term_19_EL1809.AttributeName = "Term 19 (EL1809)";
			_Term_19_EL1809.AttributePreviousPort = "Term 18 (EK1100) : B";
			_Term_19_EL1809.AttributeSyncUnit = "Row_1";
			_Term_20_EL2809 = new EL2809_2B6483BD();
			_Term_20_EL2809.AttributeName = "Term 20 (EL2809)";
			_Term_20_EL2809.AttributePreviousPort = "Term 19 (EL1809) : B";
			_Term_20_EL2809.AttributeSyncUnit = "Row_1";
			_Term_21_EL1809 = new EL1809_32157CFD();
			_Term_21_EL1809.AttributeName = "Term 21 (EL1809)";
			_Term_21_EL1809.AttributePreviousPort = "Term 20 (EL2809) : B";
			_Term_21_EL1809.AttributeSyncUnit = "Row_1";
			_Term_22_EL3011 = new EL3011_7A495228();
			_Term_22_EL3011.AttributeName = "Term 22 (EL3011)";
			_Term_22_EL3011.AttributePreviousPort = "Term 21 (EL1809) : B";
			_Term_22_EL3011.AttributeSyncUnit = "Row_1";
			_Term_29_EL9011 = new EL9011_D65D3D32();
			_Term_29_EL9011.AttributeName = "Term 29 (EL9011)";
			_Term_29_EL9011.AttributePreviousPort = "Term 22 (EL3011) : B";
			_Term_29_EL9011.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_19_EL1809EL1809_32157CFD20Term_20_EL2809EL2809_2B6483BD19Term_21_EL1809EL1809_32157CFD20Term_22_EL3011EL3011_7A49522813Term_29_EL9011EL9011_D65D3D320";
			AttributeCRC = "543529613";
			AttributeSize = "72";
			AttributeName = "Term 18 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_18_EK1100_20659A8D
	{
		public void CopyPlainToCyclic(Plc1.Term_18_EK1100_20659A8D target)
		{
			base.CopyPlainToCyclic(target);
			Term_19_EL1809.CopyPlainToCyclic(target.Term_19_EL1809);
			Term_20_EL2809.CopyPlainToCyclic(target.Term_20_EL2809);
			Term_21_EL1809.CopyPlainToCyclic(target.Term_21_EL1809);
			Term_22_EL3011.CopyPlainToCyclic(target.Term_22_EL3011);
			Term_29_EL9011.CopyPlainToCyclic(target.Term_29_EL9011);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_18_EK1100_20659A8D target)
		{
			this.CopyPlainToCyclic((Plc1.Term_18_EK1100_20659A8D)target);
		}

		public void CopyPlainToShadow(Plc1.Term_18_EK1100_20659A8D target)
		{
			base.CopyPlainToShadow(target);
			Term_19_EL1809.CopyPlainToShadow(target.Term_19_EL1809);
			Term_20_EL2809.CopyPlainToShadow(target.Term_20_EL2809);
			Term_21_EL1809.CopyPlainToShadow(target.Term_21_EL1809);
			Term_22_EL3011.CopyPlainToShadow(target.Term_22_EL3011);
			Term_29_EL9011.CopyPlainToShadow(target.Term_29_EL9011);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_18_EK1100_20659A8D target)
		{
			this.CopyPlainToShadow((Plc1.Term_18_EK1100_20659A8D)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_18_EK1100_20659A8D source)
		{
			base.CopyCyclicToPlain(source);
			Term_19_EL1809.CopyCyclicToPlain(source.Term_19_EL1809);
			Term_20_EL2809.CopyCyclicToPlain(source.Term_20_EL2809);
			Term_21_EL1809.CopyCyclicToPlain(source.Term_21_EL1809);
			Term_22_EL3011.CopyCyclicToPlain(source.Term_22_EL3011);
			Term_29_EL9011.CopyCyclicToPlain(source.Term_29_EL9011);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_18_EK1100_20659A8D source)
		{
			this.CopyCyclicToPlain((Plc1.Term_18_EK1100_20659A8D)source);
		}

		public void CopyShadowToPlain(Plc1.Term_18_EK1100_20659A8D source)
		{
			base.CopyShadowToPlain(source);
			Term_19_EL1809.CopyShadowToPlain(source.Term_19_EL1809);
			Term_20_EL2809.CopyShadowToPlain(source.Term_20_EL2809);
			Term_21_EL1809.CopyShadowToPlain(source.Term_21_EL1809);
			Term_22_EL3011.CopyShadowToPlain(source.Term_22_EL3011);
			Term_29_EL9011.CopyShadowToPlain(source.Term_29_EL9011);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_18_EK1100_20659A8D source)
		{
			this.CopyShadowToPlain((Plc1.Term_18_EK1100_20659A8D)source);
		}
	}
}