using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1122-0000-0018\" } {attribute addProperty Id \"Term_231_EK1100Term_231_EK1100_6FCE8CEB20Term_233_EK1100Term_233_EK1100_CB654C3B20\" } {attribute addProperty CRC \"373391430\" } {attribute addProperty Size \"40\" } {attribute addProperty Name \"Term 230 (EK1122)\" }", "Term_230_EK1122_16418046", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_230_EK1122_16418046 : EK1122_1FC0878B, Vortex.Connector.IVortexObject, ITerm_230_EK1122_16418046, IShadowTerm_230_EK1122_16418046, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_231_EK1100_6FCE8CEB _Term_231_EK1100;
		public Term_231_EK1100_6FCE8CEB Term_231_EK1100
		{
			get
			{
				return _Term_231_EK1100;
			}
		}

		ITerm_231_EK1100_6FCE8CEB ITerm_230_EK1122_16418046.Term_231_EK1100
		{
			get
			{
				return Term_231_EK1100;
			}
		}

		IShadowTerm_231_EK1100_6FCE8CEB IShadowTerm_230_EK1122_16418046.Term_231_EK1100
		{
			get
			{
				return Term_231_EK1100;
			}
		}

		Term_233_EK1100_CB654C3B _Term_233_EK1100;
		public Term_233_EK1100_CB654C3B Term_233_EK1100
		{
			get
			{
				return _Term_233_EK1100;
			}
		}

		ITerm_233_EK1100_CB654C3B ITerm_230_EK1122_16418046.Term_233_EK1100
		{
			get
			{
				return Term_233_EK1100;
			}
		}

		IShadowTerm_233_EK1100_CB654C3B IShadowTerm_230_EK1122_16418046.Term_233_EK1100
		{
			get
			{
				return Term_233_EK1100;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_231_EK1100.LazyOnlineToShadow();
			Term_233_EK1100.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_231_EK1100.LazyShadowToOnline();
			Term_233_EK1100.LazyShadowToOnline();
		}

		public new PlainTerm_230_EK1122_16418046 CreatePlainerType()
		{
			var cloned = new PlainTerm_230_EK1122_16418046();
			base.CreatePlainerType(cloned);
			cloned.Term_231_EK1100 = Term_231_EK1100.CreatePlainerType();
			cloned.Term_233_EK1100 = Term_233_EK1100.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_230_EK1122_16418046 CreatePlainerType(PlainTerm_230_EK1122_16418046 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_231_EK1100 = Term_231_EK1100.CreatePlainerType();
			cloned.Term_233_EK1100 = Term_233_EK1100.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_230_EK1122_16418046 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_230_EK1122_16418046 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_230_EK1122_16418046 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_230_EK1122_16418046(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_231_EK1100 = new Term_231_EK1100_6FCE8CEB(this, "Term 231 (EK1100)", "Term_231_EK1100");
			_Term_231_EK1100.AttributeName = "Term 231 (EK1100)";
			_Term_231_EK1100.AttributePreviousPort = "Term 230 (EK1122) : D";
			_Term_231_EK1100.AttributeSyncUnit = "default";
			_Term_233_EK1100 = new Term_233_EK1100_CB654C3B(this, "Term 233 (EK1100)", "Term_233_EK1100");
			_Term_233_EK1100.AttributeName = "Term 233 (EK1100)";
			_Term_233_EK1100.AttributePreviousPort = "Term 230 (EK1122) : B";
			_Term_233_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_231_EK1100Term_231_EK1100_6FCE8CEB20Term_233_EK1100Term_233_EK1100_CB654C3B20";
			AttributeCRC = "373391430";
			AttributeSize = "40";
			AttributeName = "Term 230 (EK1122)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_230_EK1122_16418046(): base ()
		{
			PexPreConstructorParameterless();
			_Term_231_EK1100 = new Term_231_EK1100_6FCE8CEB();
			_Term_231_EK1100.AttributeName = "Term 231 (EK1100)";
			_Term_231_EK1100.AttributePreviousPort = "Term 230 (EK1122) : D";
			_Term_231_EK1100.AttributeSyncUnit = "default";
			_Term_233_EK1100 = new Term_233_EK1100_CB654C3B();
			_Term_233_EK1100.AttributeName = "Term 233 (EK1100)";
			_Term_233_EK1100.AttributePreviousPort = "Term 230 (EK1122) : B";
			_Term_233_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_231_EK1100Term_231_EK1100_6FCE8CEB20Term_233_EK1100Term_233_EK1100_CB654C3B20";
			AttributeCRC = "373391430";
			AttributeSize = "40";
			AttributeName = "Term 230 (EK1122)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_230_EK1122_16418046
	{
		public void CopyPlainToCyclic(Plc1.Term_230_EK1122_16418046 target)
		{
			base.CopyPlainToCyclic(target);
			Term_231_EK1100.CopyPlainToCyclic(target.Term_231_EK1100);
			Term_233_EK1100.CopyPlainToCyclic(target.Term_233_EK1100);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_230_EK1122_16418046 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_230_EK1122_16418046)target);
		}

		public void CopyPlainToShadow(Plc1.Term_230_EK1122_16418046 target)
		{
			base.CopyPlainToShadow(target);
			Term_231_EK1100.CopyPlainToShadow(target.Term_231_EK1100);
			Term_233_EK1100.CopyPlainToShadow(target.Term_233_EK1100);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_230_EK1122_16418046 target)
		{
			this.CopyPlainToShadow((Plc1.Term_230_EK1122_16418046)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_230_EK1122_16418046 source)
		{
			base.CopyCyclicToPlain(source);
			Term_231_EK1100.CopyCyclicToPlain(source.Term_231_EK1100);
			Term_233_EK1100.CopyCyclicToPlain(source.Term_233_EK1100);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_230_EK1122_16418046 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_230_EK1122_16418046)source);
		}

		public void CopyShadowToPlain(Plc1.Term_230_EK1122_16418046 source)
		{
			base.CopyShadowToPlain(source);
			Term_231_EK1100.CopyShadowToPlain(source.Term_231_EK1100);
			Term_233_EK1100.CopyShadowToPlain(source.Term_233_EK1100);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_230_EK1122_16418046 source)
		{
			this.CopyShadowToPlain((Plc1.Term_230_EK1122_16418046)source);
		}
	}
}