using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_159_EL1809EL1809_32157CFD20\" } {attribute addProperty CRC \"2085346679\" } {attribute addProperty Size \"20\" } {attribute addProperty Name \"Term 157 (EK1100)\" }", "Term_157_EK1100_7C4BDD77", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_157_EK1100_7C4BDD77 : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_157_EK1100_7C4BDD77, IShadowTerm_157_EK1100_7C4BDD77, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		EL1809_32157CFD _Term_159_EL1809;
		public EL1809_32157CFD Term_159_EL1809
		{
			get
			{
				return _Term_159_EL1809;
			}
		}

		IEL1809_32157CFD ITerm_157_EK1100_7C4BDD77.Term_159_EL1809
		{
			get
			{
				return Term_159_EL1809;
			}
		}

		IShadowEL1809_32157CFD IShadowTerm_157_EK1100_7C4BDD77.Term_159_EL1809
		{
			get
			{
				return Term_159_EL1809;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_159_EL1809.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_159_EL1809.LazyShadowToOnline();
		}

		public new PlainTerm_157_EK1100_7C4BDD77 CreatePlainerType()
		{
			var cloned = new PlainTerm_157_EK1100_7C4BDD77();
			base.CreatePlainerType(cloned);
			cloned.Term_159_EL1809 = Term_159_EL1809.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_157_EK1100_7C4BDD77 CreatePlainerType(PlainTerm_157_EK1100_7C4BDD77 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_159_EL1809 = Term_159_EL1809.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_157_EK1100_7C4BDD77 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_157_EK1100_7C4BDD77 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_157_EK1100_7C4BDD77 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_157_EK1100_7C4BDD77(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_159_EL1809 = new EL1809_32157CFD(this, "Term 159 (EL1809)", "Term_159_EL1809");
			_Term_159_EL1809.AttributeName = "Term 159 (EL1809)";
			_Term_159_EL1809.AttributePreviousPort = "Term 157 (EK1100) : B";
			_Term_159_EL1809.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_159_EL1809EL1809_32157CFD20";
			AttributeCRC = "2085346679";
			AttributeSize = "20";
			AttributeName = "Term 157 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_157_EK1100_7C4BDD77(): base ()
		{
			PexPreConstructorParameterless();
			_Term_159_EL1809 = new EL1809_32157CFD();
			_Term_159_EL1809.AttributeName = "Term 159 (EL1809)";
			_Term_159_EL1809.AttributePreviousPort = "Term 157 (EK1100) : B";
			_Term_159_EL1809.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_159_EL1809EL1809_32157CFD20";
			AttributeCRC = "2085346679";
			AttributeSize = "20";
			AttributeName = "Term 157 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_157_EK1100_7C4BDD77
	{
		public void CopyPlainToCyclic(Plc1.Term_157_EK1100_7C4BDD77 target)
		{
			base.CopyPlainToCyclic(target);
			Term_159_EL1809.CopyPlainToCyclic(target.Term_159_EL1809);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_157_EK1100_7C4BDD77 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_157_EK1100_7C4BDD77)target);
		}

		public void CopyPlainToShadow(Plc1.Term_157_EK1100_7C4BDD77 target)
		{
			base.CopyPlainToShadow(target);
			Term_159_EL1809.CopyPlainToShadow(target.Term_159_EL1809);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_157_EK1100_7C4BDD77 target)
		{
			this.CopyPlainToShadow((Plc1.Term_157_EK1100_7C4BDD77)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_157_EK1100_7C4BDD77 source)
		{
			base.CopyCyclicToPlain(source);
			Term_159_EL1809.CopyCyclicToPlain(source.Term_159_EL1809);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_157_EK1100_7C4BDD77 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_157_EK1100_7C4BDD77)source);
		}

		public void CopyShadowToPlain(Plc1.Term_157_EK1100_7C4BDD77 source)
		{
			base.CopyShadowToPlain(source);
			Term_159_EL1809.CopyShadowToPlain(source.Term_159_EL1809);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_157_EK1100_7C4BDD77 source)
		{
			this.CopyShadowToPlain((Plc1.Term_157_EK1100_7C4BDD77)source);
		}
	}
}