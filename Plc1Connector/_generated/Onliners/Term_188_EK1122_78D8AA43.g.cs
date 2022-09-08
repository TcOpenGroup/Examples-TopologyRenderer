using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1122-0000-0018\" } {attribute addProperty Id \"Term_189_EK1100Term_189_EK1100_06A1601420Term_194_EK1100Term_194_EK1100_D4E2C05F20\" } {attribute addProperty CRC \"2027465283\" } {attribute addProperty Size \"40\" } {attribute addProperty Name \"Term 188 (EK1122)\" }", "Term_188_EK1122_78D8AA43", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_188_EK1122_78D8AA43 : EK1122_1FC0878B, Vortex.Connector.IVortexObject, ITerm_188_EK1122_78D8AA43, IShadowTerm_188_EK1122_78D8AA43, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_189_EK1100_06A16014 _Term_189_EK1100;
		public Term_189_EK1100_06A16014 Term_189_EK1100
		{
			get
			{
				return _Term_189_EK1100;
			}
		}

		ITerm_189_EK1100_06A16014 ITerm_188_EK1122_78D8AA43.Term_189_EK1100
		{
			get
			{
				return Term_189_EK1100;
			}
		}

		IShadowTerm_189_EK1100_06A16014 IShadowTerm_188_EK1122_78D8AA43.Term_189_EK1100
		{
			get
			{
				return Term_189_EK1100;
			}
		}

		Term_194_EK1100_D4E2C05F _Term_194_EK1100;
		public Term_194_EK1100_D4E2C05F Term_194_EK1100
		{
			get
			{
				return _Term_194_EK1100;
			}
		}

		ITerm_194_EK1100_D4E2C05F ITerm_188_EK1122_78D8AA43.Term_194_EK1100
		{
			get
			{
				return Term_194_EK1100;
			}
		}

		IShadowTerm_194_EK1100_D4E2C05F IShadowTerm_188_EK1122_78D8AA43.Term_194_EK1100
		{
			get
			{
				return Term_194_EK1100;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_189_EK1100.LazyOnlineToShadow();
			Term_194_EK1100.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_189_EK1100.LazyShadowToOnline();
			Term_194_EK1100.LazyShadowToOnline();
		}

		public new PlainTerm_188_EK1122_78D8AA43 CreatePlainerType()
		{
			var cloned = new PlainTerm_188_EK1122_78D8AA43();
			base.CreatePlainerType(cloned);
			cloned.Term_189_EK1100 = Term_189_EK1100.CreatePlainerType();
			cloned.Term_194_EK1100 = Term_194_EK1100.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_188_EK1122_78D8AA43 CreatePlainerType(PlainTerm_188_EK1122_78D8AA43 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_189_EK1100 = Term_189_EK1100.CreatePlainerType();
			cloned.Term_194_EK1100 = Term_194_EK1100.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_188_EK1122_78D8AA43 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_188_EK1122_78D8AA43 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_188_EK1122_78D8AA43 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_188_EK1122_78D8AA43(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_189_EK1100 = new Term_189_EK1100_06A16014(this, "Term 189 (EK1100)", "Term_189_EK1100");
			_Term_189_EK1100.AttributeName = "Term 189 (EK1100)";
			_Term_189_EK1100.AttributePreviousPort = "Term 188 (EK1122) : D";
			_Term_189_EK1100.AttributeSyncUnit = "default";
			_Term_194_EK1100 = new Term_194_EK1100_D4E2C05F(this, "Term 194 (EK1100)", "Term_194_EK1100");
			_Term_194_EK1100.AttributeName = "Term 194 (EK1100)";
			_Term_194_EK1100.AttributePreviousPort = "Term 188 (EK1122) : B";
			_Term_194_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_189_EK1100Term_189_EK1100_06A1601420Term_194_EK1100Term_194_EK1100_D4E2C05F20";
			AttributeCRC = "2027465283";
			AttributeSize = "40";
			AttributeName = "Term 188 (EK1122)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_188_EK1122_78D8AA43(): base ()
		{
			PexPreConstructorParameterless();
			_Term_189_EK1100 = new Term_189_EK1100_06A16014();
			_Term_189_EK1100.AttributeName = "Term 189 (EK1100)";
			_Term_189_EK1100.AttributePreviousPort = "Term 188 (EK1122) : D";
			_Term_189_EK1100.AttributeSyncUnit = "default";
			_Term_194_EK1100 = new Term_194_EK1100_D4E2C05F();
			_Term_194_EK1100.AttributeName = "Term 194 (EK1100)";
			_Term_194_EK1100.AttributePreviousPort = "Term 188 (EK1122) : B";
			_Term_194_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_189_EK1100Term_189_EK1100_06A1601420Term_194_EK1100Term_194_EK1100_D4E2C05F20";
			AttributeCRC = "2027465283";
			AttributeSize = "40";
			AttributeName = "Term 188 (EK1122)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_188_EK1122_78D8AA43
	{
		public void CopyPlainToCyclic(Plc1.Term_188_EK1122_78D8AA43 target)
		{
			base.CopyPlainToCyclic(target);
			Term_189_EK1100.CopyPlainToCyclic(target.Term_189_EK1100);
			Term_194_EK1100.CopyPlainToCyclic(target.Term_194_EK1100);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_188_EK1122_78D8AA43 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_188_EK1122_78D8AA43)target);
		}

		public void CopyPlainToShadow(Plc1.Term_188_EK1122_78D8AA43 target)
		{
			base.CopyPlainToShadow(target);
			Term_189_EK1100.CopyPlainToShadow(target.Term_189_EK1100);
			Term_194_EK1100.CopyPlainToShadow(target.Term_194_EK1100);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_188_EK1122_78D8AA43 target)
		{
			this.CopyPlainToShadow((Plc1.Term_188_EK1122_78D8AA43)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_188_EK1122_78D8AA43 source)
		{
			base.CopyCyclicToPlain(source);
			Term_189_EK1100.CopyCyclicToPlain(source.Term_189_EK1100);
			Term_194_EK1100.CopyCyclicToPlain(source.Term_194_EK1100);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_188_EK1122_78D8AA43 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_188_EK1122_78D8AA43)source);
		}

		public void CopyShadowToPlain(Plc1.Term_188_EK1122_78D8AA43 source)
		{
			base.CopyShadowToPlain(source);
			Term_189_EK1100.CopyShadowToPlain(source.Term_189_EK1100);
			Term_194_EK1100.CopyShadowToPlain(source.Term_194_EK1100);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_188_EK1122_78D8AA43 source)
		{
			this.CopyShadowToPlain((Plc1.Term_188_EK1122_78D8AA43)source);
		}
	}
}