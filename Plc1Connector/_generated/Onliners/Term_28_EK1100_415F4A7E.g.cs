using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_29_EL2788EL2788_E2806B9511Term_30_EL3773EL3773_F128CC82184Term_31_EL9011EL9011_D65D3D320\" } {attribute addProperty CRC \"1096764030\" } {attribute addProperty Size \"195\" } {attribute addProperty Name \"Term 28 (EK1100)\" }", "Term_28_EK1100_415F4A7E", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_28_EK1100_415F4A7E : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_28_EK1100_415F4A7E, IShadowTerm_28_EK1100_415F4A7E, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		EL2788_E2806B95 _Term_29_EL2788;
		public EL2788_E2806B95 Term_29_EL2788
		{
			get
			{
				return _Term_29_EL2788;
			}
		}

		IEL2788_E2806B95 ITerm_28_EK1100_415F4A7E.Term_29_EL2788
		{
			get
			{
				return Term_29_EL2788;
			}
		}

		IShadowEL2788_E2806B95 IShadowTerm_28_EK1100_415F4A7E.Term_29_EL2788
		{
			get
			{
				return Term_29_EL2788;
			}
		}

		EL3773_F128CC82 _Term_30_EL3773;
		public EL3773_F128CC82 Term_30_EL3773
		{
			get
			{
				return _Term_30_EL3773;
			}
		}

		IEL3773_F128CC82 ITerm_28_EK1100_415F4A7E.Term_30_EL3773
		{
			get
			{
				return Term_30_EL3773;
			}
		}

		IShadowEL3773_F128CC82 IShadowTerm_28_EK1100_415F4A7E.Term_30_EL3773
		{
			get
			{
				return Term_30_EL3773;
			}
		}

		EL9011_D65D3D32 _Term_31_EL9011;
		public EL9011_D65D3D32 Term_31_EL9011
		{
			get
			{
				return _Term_31_EL9011;
			}
		}

		IEL9011_D65D3D32 ITerm_28_EK1100_415F4A7E.Term_31_EL9011
		{
			get
			{
				return Term_31_EL9011;
			}
		}

		IShadowEL9011_D65D3D32 IShadowTerm_28_EK1100_415F4A7E.Term_31_EL9011
		{
			get
			{
				return Term_31_EL9011;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_29_EL2788.LazyOnlineToShadow();
			Term_30_EL3773.LazyOnlineToShadow();
			Term_31_EL9011.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_29_EL2788.LazyShadowToOnline();
			Term_30_EL3773.LazyShadowToOnline();
			Term_31_EL9011.LazyShadowToOnline();
		}

		public new PlainTerm_28_EK1100_415F4A7E CreatePlainerType()
		{
			var cloned = new PlainTerm_28_EK1100_415F4A7E();
			base.CreatePlainerType(cloned);
			cloned.Term_29_EL2788 = Term_29_EL2788.CreatePlainerType();
			cloned.Term_30_EL3773 = Term_30_EL3773.CreatePlainerType();
			cloned.Term_31_EL9011 = Term_31_EL9011.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_28_EK1100_415F4A7E CreatePlainerType(PlainTerm_28_EK1100_415F4A7E cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_29_EL2788 = Term_29_EL2788.CreatePlainerType();
			cloned.Term_30_EL3773 = Term_30_EL3773.CreatePlainerType();
			cloned.Term_31_EL9011 = Term_31_EL9011.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_28_EK1100_415F4A7E source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_28_EK1100_415F4A7E source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_28_EK1100_415F4A7E source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_28_EK1100_415F4A7E(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_29_EL2788 = new EL2788_E2806B95(this, "Term 29 (EL2788)", "Term_29_EL2788");
			_Term_29_EL2788.AttributeName = "Term 29 (EL2788)";
			_Term_29_EL2788.AttributePreviousPort = "Term 28 (EK1100) : B";
			_Term_29_EL2788.AttributeSyncUnit = "Row_4";
			_Term_30_EL3773 = new EL3773_F128CC82(this, "Term 30 (EL3773)", "Term_30_EL3773");
			_Term_30_EL3773.AttributeName = "Term 30 (EL3773)";
			_Term_30_EL3773.AttributePreviousPort = "Term 29 (EL2788) : B";
			_Term_30_EL3773.AttributeSyncUnit = "Row_4";
			_Term_31_EL9011 = new EL9011_D65D3D32(this, "Term 31 (EL9011)", "Term_31_EL9011");
			_Term_31_EL9011.AttributeName = "Term 31 (EL9011)";
			_Term_31_EL9011.AttributePreviousPort = "Term 30 (EL3773) : B";
			_Term_31_EL9011.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_29_EL2788EL2788_E2806B9511Term_30_EL3773EL3773_F128CC82184Term_31_EL9011EL9011_D65D3D320";
			AttributeCRC = "1096764030";
			AttributeSize = "195";
			AttributeName = "Term 28 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_28_EK1100_415F4A7E(): base ()
		{
			PexPreConstructorParameterless();
			_Term_29_EL2788 = new EL2788_E2806B95();
			_Term_29_EL2788.AttributeName = "Term 29 (EL2788)";
			_Term_29_EL2788.AttributePreviousPort = "Term 28 (EK1100) : B";
			_Term_29_EL2788.AttributeSyncUnit = "Row_4";
			_Term_30_EL3773 = new EL3773_F128CC82();
			_Term_30_EL3773.AttributeName = "Term 30 (EL3773)";
			_Term_30_EL3773.AttributePreviousPort = "Term 29 (EL2788) : B";
			_Term_30_EL3773.AttributeSyncUnit = "Row_4";
			_Term_31_EL9011 = new EL9011_D65D3D32();
			_Term_31_EL9011.AttributeName = "Term 31 (EL9011)";
			_Term_31_EL9011.AttributePreviousPort = "Term 30 (EL3773) : B";
			_Term_31_EL9011.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_29_EL2788EL2788_E2806B9511Term_30_EL3773EL3773_F128CC82184Term_31_EL9011EL9011_D65D3D320";
			AttributeCRC = "1096764030";
			AttributeSize = "195";
			AttributeName = "Term 28 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_28_EK1100_415F4A7E
	{
		public void CopyPlainToCyclic(Plc1.Term_28_EK1100_415F4A7E target)
		{
			base.CopyPlainToCyclic(target);
			Term_29_EL2788.CopyPlainToCyclic(target.Term_29_EL2788);
			Term_30_EL3773.CopyPlainToCyclic(target.Term_30_EL3773);
			Term_31_EL9011.CopyPlainToCyclic(target.Term_31_EL9011);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_28_EK1100_415F4A7E target)
		{
			this.CopyPlainToCyclic((Plc1.Term_28_EK1100_415F4A7E)target);
		}

		public void CopyPlainToShadow(Plc1.Term_28_EK1100_415F4A7E target)
		{
			base.CopyPlainToShadow(target);
			Term_29_EL2788.CopyPlainToShadow(target.Term_29_EL2788);
			Term_30_EL3773.CopyPlainToShadow(target.Term_30_EL3773);
			Term_31_EL9011.CopyPlainToShadow(target.Term_31_EL9011);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_28_EK1100_415F4A7E target)
		{
			this.CopyPlainToShadow((Plc1.Term_28_EK1100_415F4A7E)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_28_EK1100_415F4A7E source)
		{
			base.CopyCyclicToPlain(source);
			Term_29_EL2788.CopyCyclicToPlain(source.Term_29_EL2788);
			Term_30_EL3773.CopyCyclicToPlain(source.Term_30_EL3773);
			Term_31_EL9011.CopyCyclicToPlain(source.Term_31_EL9011);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_28_EK1100_415F4A7E source)
		{
			this.CopyCyclicToPlain((Plc1.Term_28_EK1100_415F4A7E)source);
		}

		public void CopyShadowToPlain(Plc1.Term_28_EK1100_415F4A7E source)
		{
			base.CopyShadowToPlain(source);
			Term_29_EL2788.CopyShadowToPlain(source.Term_29_EL2788);
			Term_30_EL3773.CopyShadowToPlain(source.Term_30_EL3773);
			Term_31_EL9011.CopyShadowToPlain(source.Term_31_EL9011);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_28_EK1100_415F4A7E source)
		{
			this.CopyShadowToPlain((Plc1.Term_28_EK1100_415F4A7E)source);
		}
	}
}