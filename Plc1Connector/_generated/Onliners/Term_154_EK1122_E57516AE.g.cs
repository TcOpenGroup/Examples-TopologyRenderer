using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1122-0000-0018\" } {attribute addProperty Id \"Term_157_EK1100Term_157_EK1100_7C4BDD7720Term_158_EK1100Term_158_EK1100_E3D699B120\" } {attribute addProperty CRC \"3849655982\" } {attribute addProperty Size \"40\" } {attribute addProperty Name \"Term 154 (EK1122)\" }", "Term_154_EK1122_E57516AE", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_154_EK1122_E57516AE : EK1122_1FC0878B, Vortex.Connector.IVortexObject, ITerm_154_EK1122_E57516AE, IShadowTerm_154_EK1122_E57516AE, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_157_EK1100_7C4BDD77 _Term_157_EK1100;
		public Term_157_EK1100_7C4BDD77 Term_157_EK1100
		{
			get
			{
				return _Term_157_EK1100;
			}
		}

		ITerm_157_EK1100_7C4BDD77 ITerm_154_EK1122_E57516AE.Term_157_EK1100
		{
			get
			{
				return Term_157_EK1100;
			}
		}

		IShadowTerm_157_EK1100_7C4BDD77 IShadowTerm_154_EK1122_E57516AE.Term_157_EK1100
		{
			get
			{
				return Term_157_EK1100;
			}
		}

		Term_158_EK1100_E3D699B1 _Term_158_EK1100;
		public Term_158_EK1100_E3D699B1 Term_158_EK1100
		{
			get
			{
				return _Term_158_EK1100;
			}
		}

		ITerm_158_EK1100_E3D699B1 ITerm_154_EK1122_E57516AE.Term_158_EK1100
		{
			get
			{
				return Term_158_EK1100;
			}
		}

		IShadowTerm_158_EK1100_E3D699B1 IShadowTerm_154_EK1122_E57516AE.Term_158_EK1100
		{
			get
			{
				return Term_158_EK1100;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_157_EK1100.LazyOnlineToShadow();
			Term_158_EK1100.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_157_EK1100.LazyShadowToOnline();
			Term_158_EK1100.LazyShadowToOnline();
		}

		public new PlainTerm_154_EK1122_E57516AE CreatePlainerType()
		{
			var cloned = new PlainTerm_154_EK1122_E57516AE();
			base.CreatePlainerType(cloned);
			cloned.Term_157_EK1100 = Term_157_EK1100.CreatePlainerType();
			cloned.Term_158_EK1100 = Term_158_EK1100.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_154_EK1122_E57516AE CreatePlainerType(PlainTerm_154_EK1122_E57516AE cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_157_EK1100 = Term_157_EK1100.CreatePlainerType();
			cloned.Term_158_EK1100 = Term_158_EK1100.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_154_EK1122_E57516AE source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_154_EK1122_E57516AE source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_154_EK1122_E57516AE source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_154_EK1122_E57516AE(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_157_EK1100 = new Term_157_EK1100_7C4BDD77(this, "Term 157 (EK1100)", "Term_157_EK1100");
			_Term_157_EK1100.AttributeName = "Term 157 (EK1100)";
			_Term_157_EK1100.AttributePreviousPort = "Term 154 (EK1122) : D";
			_Term_157_EK1100.AttributeSyncUnit = "default";
			_Term_158_EK1100 = new Term_158_EK1100_E3D699B1(this, "Term 158 (EK1100)", "Term_158_EK1100");
			_Term_158_EK1100.AttributeName = "Term 158 (EK1100)";
			_Term_158_EK1100.AttributePreviousPort = "Term 154 (EK1122) : B";
			_Term_158_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_157_EK1100Term_157_EK1100_7C4BDD7720Term_158_EK1100Term_158_EK1100_E3D699B120";
			AttributeCRC = "3849655982";
			AttributeSize = "40";
			AttributeName = "Term 154 (EK1122)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_154_EK1122_E57516AE(): base ()
		{
			PexPreConstructorParameterless();
			_Term_157_EK1100 = new Term_157_EK1100_7C4BDD77();
			_Term_157_EK1100.AttributeName = "Term 157 (EK1100)";
			_Term_157_EK1100.AttributePreviousPort = "Term 154 (EK1122) : D";
			_Term_157_EK1100.AttributeSyncUnit = "default";
			_Term_158_EK1100 = new Term_158_EK1100_E3D699B1();
			_Term_158_EK1100.AttributeName = "Term 158 (EK1100)";
			_Term_158_EK1100.AttributePreviousPort = "Term 154 (EK1122) : B";
			_Term_158_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_157_EK1100Term_157_EK1100_7C4BDD7720Term_158_EK1100Term_158_EK1100_E3D699B120";
			AttributeCRC = "3849655982";
			AttributeSize = "40";
			AttributeName = "Term 154 (EK1122)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_154_EK1122_E57516AE
	{
		public void CopyPlainToCyclic(Plc1.Term_154_EK1122_E57516AE target)
		{
			base.CopyPlainToCyclic(target);
			Term_157_EK1100.CopyPlainToCyclic(target.Term_157_EK1100);
			Term_158_EK1100.CopyPlainToCyclic(target.Term_158_EK1100);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_154_EK1122_E57516AE target)
		{
			this.CopyPlainToCyclic((Plc1.Term_154_EK1122_E57516AE)target);
		}

		public void CopyPlainToShadow(Plc1.Term_154_EK1122_E57516AE target)
		{
			base.CopyPlainToShadow(target);
			Term_157_EK1100.CopyPlainToShadow(target.Term_157_EK1100);
			Term_158_EK1100.CopyPlainToShadow(target.Term_158_EK1100);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_154_EK1122_E57516AE target)
		{
			this.CopyPlainToShadow((Plc1.Term_154_EK1122_E57516AE)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_154_EK1122_E57516AE source)
		{
			base.CopyCyclicToPlain(source);
			Term_157_EK1100.CopyCyclicToPlain(source.Term_157_EK1100);
			Term_158_EK1100.CopyCyclicToPlain(source.Term_158_EK1100);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_154_EK1122_E57516AE source)
		{
			this.CopyCyclicToPlain((Plc1.Term_154_EK1122_E57516AE)source);
		}

		public void CopyShadowToPlain(Plc1.Term_154_EK1122_E57516AE source)
		{
			base.CopyShadowToPlain(source);
			Term_157_EK1100.CopyShadowToPlain(source.Term_157_EK1100);
			Term_158_EK1100.CopyShadowToPlain(source.Term_158_EK1100);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_154_EK1122_E57516AE source)
		{
			this.CopyShadowToPlain((Plc1.Term_154_EK1122_E57516AE)source);
		}
	}
}