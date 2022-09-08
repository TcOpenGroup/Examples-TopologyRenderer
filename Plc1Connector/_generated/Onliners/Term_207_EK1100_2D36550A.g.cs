using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_230_EK1122Term_230_EK1122_1641804640Term_235_EL2008EL2008_E2806B9511Term_236_EL2008EL2008_E2806B9511\" } {attribute addProperty CRC \"758535434\" } {attribute addProperty Size \"62\" } {attribute addProperty Name \"Term 207 (EK1100)\" }", "Term_207_EK1100_2D36550A", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_207_EK1100_2D36550A : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_207_EK1100_2D36550A, IShadowTerm_207_EK1100_2D36550A, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_230_EK1122_16418046 _Term_230_EK1122;
		public Term_230_EK1122_16418046 Term_230_EK1122
		{
			get
			{
				return _Term_230_EK1122;
			}
		}

		ITerm_230_EK1122_16418046 ITerm_207_EK1100_2D36550A.Term_230_EK1122
		{
			get
			{
				return Term_230_EK1122;
			}
		}

		IShadowTerm_230_EK1122_16418046 IShadowTerm_207_EK1100_2D36550A.Term_230_EK1122
		{
			get
			{
				return Term_230_EK1122;
			}
		}

		EL2008_E2806B95 _Term_235_EL2008;
		public EL2008_E2806B95 Term_235_EL2008
		{
			get
			{
				return _Term_235_EL2008;
			}
		}

		IEL2008_E2806B95 ITerm_207_EK1100_2D36550A.Term_235_EL2008
		{
			get
			{
				return Term_235_EL2008;
			}
		}

		IShadowEL2008_E2806B95 IShadowTerm_207_EK1100_2D36550A.Term_235_EL2008
		{
			get
			{
				return Term_235_EL2008;
			}
		}

		EL2008_E2806B95 _Term_236_EL2008;
		public EL2008_E2806B95 Term_236_EL2008
		{
			get
			{
				return _Term_236_EL2008;
			}
		}

		IEL2008_E2806B95 ITerm_207_EK1100_2D36550A.Term_236_EL2008
		{
			get
			{
				return Term_236_EL2008;
			}
		}

		IShadowEL2008_E2806B95 IShadowTerm_207_EK1100_2D36550A.Term_236_EL2008
		{
			get
			{
				return Term_236_EL2008;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_230_EK1122.LazyOnlineToShadow();
			Term_235_EL2008.LazyOnlineToShadow();
			Term_236_EL2008.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_230_EK1122.LazyShadowToOnline();
			Term_235_EL2008.LazyShadowToOnline();
			Term_236_EL2008.LazyShadowToOnline();
		}

		public new PlainTerm_207_EK1100_2D36550A CreatePlainerType()
		{
			var cloned = new PlainTerm_207_EK1100_2D36550A();
			base.CreatePlainerType(cloned);
			cloned.Term_230_EK1122 = Term_230_EK1122.CreatePlainerType();
			cloned.Term_235_EL2008 = Term_235_EL2008.CreatePlainerType();
			cloned.Term_236_EL2008 = Term_236_EL2008.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_207_EK1100_2D36550A CreatePlainerType(PlainTerm_207_EK1100_2D36550A cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_230_EK1122 = Term_230_EK1122.CreatePlainerType();
			cloned.Term_235_EL2008 = Term_235_EL2008.CreatePlainerType();
			cloned.Term_236_EL2008 = Term_236_EL2008.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_207_EK1100_2D36550A source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_207_EK1100_2D36550A source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_207_EK1100_2D36550A source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_207_EK1100_2D36550A(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_230_EK1122 = new Term_230_EK1122_16418046(this, "Term 230 (EK1122)", "Term_230_EK1122");
			_Term_230_EK1122.AttributeName = "Term 230 (EK1122)";
			_Term_230_EK1122.AttributePreviousPort = "Term 207 (EK1100) : B";
			_Term_230_EK1122.AttributeSyncUnit = "default";
			_Term_235_EL2008 = new EL2008_E2806B95(this, "Term 235 (EL2008)", "Term_235_EL2008");
			_Term_235_EL2008.AttributeName = "Term 235 (EL2008)";
			_Term_235_EL2008.AttributePreviousPort = "Term 230 (EK1122) : C";
			_Term_235_EL2008.AttributeSyncUnit = "default";
			_Term_236_EL2008 = new EL2008_E2806B95(this, "Term 236 (EL2008)", "Term_236_EL2008");
			_Term_236_EL2008.AttributeName = "Term 236 (EL2008)";
			_Term_236_EL2008.AttributePreviousPort = "Term 235 (EL2008) : B";
			_Term_236_EL2008.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_230_EK1122Term_230_EK1122_1641804640Term_235_EL2008EL2008_E2806B9511Term_236_EL2008EL2008_E2806B9511";
			AttributeCRC = "758535434";
			AttributeSize = "62";
			AttributeName = "Term 207 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_207_EK1100_2D36550A(): base ()
		{
			PexPreConstructorParameterless();
			_Term_230_EK1122 = new Term_230_EK1122_16418046();
			_Term_230_EK1122.AttributeName = "Term 230 (EK1122)";
			_Term_230_EK1122.AttributePreviousPort = "Term 207 (EK1100) : B";
			_Term_230_EK1122.AttributeSyncUnit = "default";
			_Term_235_EL2008 = new EL2008_E2806B95();
			_Term_235_EL2008.AttributeName = "Term 235 (EL2008)";
			_Term_235_EL2008.AttributePreviousPort = "Term 230 (EK1122) : C";
			_Term_235_EL2008.AttributeSyncUnit = "default";
			_Term_236_EL2008 = new EL2008_E2806B95();
			_Term_236_EL2008.AttributeName = "Term 236 (EL2008)";
			_Term_236_EL2008.AttributePreviousPort = "Term 235 (EL2008) : B";
			_Term_236_EL2008.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_230_EK1122Term_230_EK1122_1641804640Term_235_EL2008EL2008_E2806B9511Term_236_EL2008EL2008_E2806B9511";
			AttributeCRC = "758535434";
			AttributeSize = "62";
			AttributeName = "Term 207 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_207_EK1100_2D36550A
	{
		public void CopyPlainToCyclic(Plc1.Term_207_EK1100_2D36550A target)
		{
			base.CopyPlainToCyclic(target);
			Term_230_EK1122.CopyPlainToCyclic(target.Term_230_EK1122);
			Term_235_EL2008.CopyPlainToCyclic(target.Term_235_EL2008);
			Term_236_EL2008.CopyPlainToCyclic(target.Term_236_EL2008);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_207_EK1100_2D36550A target)
		{
			this.CopyPlainToCyclic((Plc1.Term_207_EK1100_2D36550A)target);
		}

		public void CopyPlainToShadow(Plc1.Term_207_EK1100_2D36550A target)
		{
			base.CopyPlainToShadow(target);
			Term_230_EK1122.CopyPlainToShadow(target.Term_230_EK1122);
			Term_235_EL2008.CopyPlainToShadow(target.Term_235_EL2008);
			Term_236_EL2008.CopyPlainToShadow(target.Term_236_EL2008);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_207_EK1100_2D36550A target)
		{
			this.CopyPlainToShadow((Plc1.Term_207_EK1100_2D36550A)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_207_EK1100_2D36550A source)
		{
			base.CopyCyclicToPlain(source);
			Term_230_EK1122.CopyCyclicToPlain(source.Term_230_EK1122);
			Term_235_EL2008.CopyCyclicToPlain(source.Term_235_EL2008);
			Term_236_EL2008.CopyCyclicToPlain(source.Term_236_EL2008);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_207_EK1100_2D36550A source)
		{
			this.CopyCyclicToPlain((Plc1.Term_207_EK1100_2D36550A)source);
		}

		public void CopyShadowToPlain(Plc1.Term_207_EK1100_2D36550A source)
		{
			base.CopyShadowToPlain(source);
			Term_230_EK1122.CopyShadowToPlain(source.Term_230_EK1122);
			Term_235_EL2008.CopyShadowToPlain(source.Term_235_EL2008);
			Term_236_EL2008.CopyShadowToPlain(source.Term_236_EL2008);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_207_EK1100_2D36550A source)
		{
			this.CopyShadowToPlain((Plc1.Term_207_EK1100_2D36550A)source);
		}
	}
}