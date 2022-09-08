using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1122-0000-0018\" } {attribute addProperty Id \"Term_180_EK1100Term_180_EK1100_796B778320Term_182_EK1100Term_182_EK1100_E6B2C35E20\" } {attribute addProperty CRC \"708014682\" } {attribute addProperty Size \"40\" } {attribute addProperty Name \"Term 179 (EK1122)\" }", "Term_179_EK1122_2A33725A", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_179_EK1122_2A33725A : EK1122_1FC0878B, Vortex.Connector.IVortexObject, ITerm_179_EK1122_2A33725A, IShadowTerm_179_EK1122_2A33725A, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_180_EK1100_796B7783 _Term_180_EK1100;
		public Term_180_EK1100_796B7783 Term_180_EK1100
		{
			get
			{
				return _Term_180_EK1100;
			}
		}

		ITerm_180_EK1100_796B7783 ITerm_179_EK1122_2A33725A.Term_180_EK1100
		{
			get
			{
				return Term_180_EK1100;
			}
		}

		IShadowTerm_180_EK1100_796B7783 IShadowTerm_179_EK1122_2A33725A.Term_180_EK1100
		{
			get
			{
				return Term_180_EK1100;
			}
		}

		Term_182_EK1100_E6B2C35E _Term_182_EK1100;
		public Term_182_EK1100_E6B2C35E Term_182_EK1100
		{
			get
			{
				return _Term_182_EK1100;
			}
		}

		ITerm_182_EK1100_E6B2C35E ITerm_179_EK1122_2A33725A.Term_182_EK1100
		{
			get
			{
				return Term_182_EK1100;
			}
		}

		IShadowTerm_182_EK1100_E6B2C35E IShadowTerm_179_EK1122_2A33725A.Term_182_EK1100
		{
			get
			{
				return Term_182_EK1100;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_180_EK1100.LazyOnlineToShadow();
			Term_182_EK1100.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_180_EK1100.LazyShadowToOnline();
			Term_182_EK1100.LazyShadowToOnline();
		}

		public new PlainTerm_179_EK1122_2A33725A CreatePlainerType()
		{
			var cloned = new PlainTerm_179_EK1122_2A33725A();
			base.CreatePlainerType(cloned);
			cloned.Term_180_EK1100 = Term_180_EK1100.CreatePlainerType();
			cloned.Term_182_EK1100 = Term_182_EK1100.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_179_EK1122_2A33725A CreatePlainerType(PlainTerm_179_EK1122_2A33725A cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_180_EK1100 = Term_180_EK1100.CreatePlainerType();
			cloned.Term_182_EK1100 = Term_182_EK1100.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_179_EK1122_2A33725A source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_179_EK1122_2A33725A source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_179_EK1122_2A33725A source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_179_EK1122_2A33725A(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_180_EK1100 = new Term_180_EK1100_796B7783(this, "Term 180 (EK1100)", "Term_180_EK1100");
			_Term_180_EK1100.AttributeName = "Term 180 (EK1100)";
			_Term_180_EK1100.AttributePreviousPort = "Term 179 (EK1122) : D";
			_Term_180_EK1100.AttributeSyncUnit = "default";
			_Term_182_EK1100 = new Term_182_EK1100_E6B2C35E(this, "Term 182 (EK1100)", "Term_182_EK1100");
			_Term_182_EK1100.AttributeName = "Term 182 (EK1100)";
			_Term_182_EK1100.AttributePreviousPort = "Term 179 (EK1122) : B";
			_Term_182_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_180_EK1100Term_180_EK1100_796B778320Term_182_EK1100Term_182_EK1100_E6B2C35E20";
			AttributeCRC = "708014682";
			AttributeSize = "40";
			AttributeName = "Term 179 (EK1122)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_179_EK1122_2A33725A(): base ()
		{
			PexPreConstructorParameterless();
			_Term_180_EK1100 = new Term_180_EK1100_796B7783();
			_Term_180_EK1100.AttributeName = "Term 180 (EK1100)";
			_Term_180_EK1100.AttributePreviousPort = "Term 179 (EK1122) : D";
			_Term_180_EK1100.AttributeSyncUnit = "default";
			_Term_182_EK1100 = new Term_182_EK1100_E6B2C35E();
			_Term_182_EK1100.AttributeName = "Term 182 (EK1100)";
			_Term_182_EK1100.AttributePreviousPort = "Term 179 (EK1122) : B";
			_Term_182_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_180_EK1100Term_180_EK1100_796B778320Term_182_EK1100Term_182_EK1100_E6B2C35E20";
			AttributeCRC = "708014682";
			AttributeSize = "40";
			AttributeName = "Term 179 (EK1122)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_179_EK1122_2A33725A
	{
		public void CopyPlainToCyclic(Plc1.Term_179_EK1122_2A33725A target)
		{
			base.CopyPlainToCyclic(target);
			Term_180_EK1100.CopyPlainToCyclic(target.Term_180_EK1100);
			Term_182_EK1100.CopyPlainToCyclic(target.Term_182_EK1100);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_179_EK1122_2A33725A target)
		{
			this.CopyPlainToCyclic((Plc1.Term_179_EK1122_2A33725A)target);
		}

		public void CopyPlainToShadow(Plc1.Term_179_EK1122_2A33725A target)
		{
			base.CopyPlainToShadow(target);
			Term_180_EK1100.CopyPlainToShadow(target.Term_180_EK1100);
			Term_182_EK1100.CopyPlainToShadow(target.Term_182_EK1100);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_179_EK1122_2A33725A target)
		{
			this.CopyPlainToShadow((Plc1.Term_179_EK1122_2A33725A)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_179_EK1122_2A33725A source)
		{
			base.CopyCyclicToPlain(source);
			Term_180_EK1100.CopyCyclicToPlain(source.Term_180_EK1100);
			Term_182_EK1100.CopyCyclicToPlain(source.Term_182_EK1100);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_179_EK1122_2A33725A source)
		{
			this.CopyCyclicToPlain((Plc1.Term_179_EK1122_2A33725A)source);
		}

		public void CopyShadowToPlain(Plc1.Term_179_EK1122_2A33725A source)
		{
			base.CopyShadowToPlain(source);
			Term_180_EK1100.CopyShadowToPlain(source.Term_180_EK1100);
			Term_182_EK1100.CopyShadowToPlain(source.Term_182_EK1100);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_179_EK1122_2A33725A source)
		{
			this.CopyShadowToPlain((Plc1.Term_179_EK1122_2A33725A)source);
		}
	}
}