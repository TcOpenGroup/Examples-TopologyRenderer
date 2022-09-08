using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1122-0000-0018\" } {attribute addProperty Id \"Term_289_EK1100Term_289_EK1100_9C677E5049Term_294_EK1100Term_294_EK1100_DFE2A59E42Term_307_EK1100Term_307_EK1100_EB8FAA4162\" } {attribute addProperty CRC \"418943519\" } {attribute addProperty Size \"153\" } {attribute addProperty Name \"Term 288 (EK1122)\" }", "Term_288_EK1122_18F8921F", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_288_EK1122_18F8921F : EK1122_1FC0878B, Vortex.Connector.IVortexObject, ITerm_288_EK1122_18F8921F, IShadowTerm_288_EK1122_18F8921F, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_289_EK1100_9C677E50 _Term_289_EK1100;
		public Term_289_EK1100_9C677E50 Term_289_EK1100
		{
			get
			{
				return _Term_289_EK1100;
			}
		}

		ITerm_289_EK1100_9C677E50 ITerm_288_EK1122_18F8921F.Term_289_EK1100
		{
			get
			{
				return Term_289_EK1100;
			}
		}

		IShadowTerm_289_EK1100_9C677E50 IShadowTerm_288_EK1122_18F8921F.Term_289_EK1100
		{
			get
			{
				return Term_289_EK1100;
			}
		}

		Term_294_EK1100_DFE2A59E _Term_294_EK1100;
		public Term_294_EK1100_DFE2A59E Term_294_EK1100
		{
			get
			{
				return _Term_294_EK1100;
			}
		}

		ITerm_294_EK1100_DFE2A59E ITerm_288_EK1122_18F8921F.Term_294_EK1100
		{
			get
			{
				return Term_294_EK1100;
			}
		}

		IShadowTerm_294_EK1100_DFE2A59E IShadowTerm_288_EK1122_18F8921F.Term_294_EK1100
		{
			get
			{
				return Term_294_EK1100;
			}
		}

		Term_307_EK1100_EB8FAA41 _Term_307_EK1100;
		public Term_307_EK1100_EB8FAA41 Term_307_EK1100
		{
			get
			{
				return _Term_307_EK1100;
			}
		}

		ITerm_307_EK1100_EB8FAA41 ITerm_288_EK1122_18F8921F.Term_307_EK1100
		{
			get
			{
				return Term_307_EK1100;
			}
		}

		IShadowTerm_307_EK1100_EB8FAA41 IShadowTerm_288_EK1122_18F8921F.Term_307_EK1100
		{
			get
			{
				return Term_307_EK1100;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_289_EK1100.LazyOnlineToShadow();
			Term_294_EK1100.LazyOnlineToShadow();
			Term_307_EK1100.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_289_EK1100.LazyShadowToOnline();
			Term_294_EK1100.LazyShadowToOnline();
			Term_307_EK1100.LazyShadowToOnline();
		}

		public new PlainTerm_288_EK1122_18F8921F CreatePlainerType()
		{
			var cloned = new PlainTerm_288_EK1122_18F8921F();
			base.CreatePlainerType(cloned);
			cloned.Term_289_EK1100 = Term_289_EK1100.CreatePlainerType();
			cloned.Term_294_EK1100 = Term_294_EK1100.CreatePlainerType();
			cloned.Term_307_EK1100 = Term_307_EK1100.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_288_EK1122_18F8921F CreatePlainerType(PlainTerm_288_EK1122_18F8921F cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_289_EK1100 = Term_289_EK1100.CreatePlainerType();
			cloned.Term_294_EK1100 = Term_294_EK1100.CreatePlainerType();
			cloned.Term_307_EK1100 = Term_307_EK1100.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_288_EK1122_18F8921F source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_288_EK1122_18F8921F source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_288_EK1122_18F8921F source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_288_EK1122_18F8921F(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_289_EK1100 = new Term_289_EK1100_9C677E50(this, "Term 289 (EK1100)", "Term_289_EK1100");
			_Term_289_EK1100.AttributeName = "Term 289 (EK1100)";
			_Term_289_EK1100.AttributePreviousPort = "Term 288 (EK1122) : D";
			_Term_289_EK1100.AttributeSyncUnit = "default";
			_Term_294_EK1100 = new Term_294_EK1100_DFE2A59E(this, "Term 294 (EK1100)", "Term_294_EK1100");
			_Term_294_EK1100.AttributeName = "Term 294 (EK1100)";
			_Term_294_EK1100.AttributePreviousPort = "Term 289 (EK1100) : C";
			_Term_294_EK1100.AttributeSyncUnit = "default";
			_Term_307_EK1100 = new Term_307_EK1100_EB8FAA41(this, "Term 307 (EK1100)", "Term_307_EK1100");
			_Term_307_EK1100.AttributeName = "Term 307 (EK1100)";
			_Term_307_EK1100.AttributePreviousPort = "Term 294 (EK1100) : C";
			_Term_307_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_289_EK1100Term_289_EK1100_9C677E5049Term_294_EK1100Term_294_EK1100_DFE2A59E42Term_307_EK1100Term_307_EK1100_EB8FAA4162";
			AttributeCRC = "418943519";
			AttributeSize = "153";
			AttributeName = "Term 288 (EK1122)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_288_EK1122_18F8921F(): base ()
		{
			PexPreConstructorParameterless();
			_Term_289_EK1100 = new Term_289_EK1100_9C677E50();
			_Term_289_EK1100.AttributeName = "Term 289 (EK1100)";
			_Term_289_EK1100.AttributePreviousPort = "Term 288 (EK1122) : D";
			_Term_289_EK1100.AttributeSyncUnit = "default";
			_Term_294_EK1100 = new Term_294_EK1100_DFE2A59E();
			_Term_294_EK1100.AttributeName = "Term 294 (EK1100)";
			_Term_294_EK1100.AttributePreviousPort = "Term 289 (EK1100) : C";
			_Term_294_EK1100.AttributeSyncUnit = "default";
			_Term_307_EK1100 = new Term_307_EK1100_EB8FAA41();
			_Term_307_EK1100.AttributeName = "Term 307 (EK1100)";
			_Term_307_EK1100.AttributePreviousPort = "Term 294 (EK1100) : C";
			_Term_307_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_289_EK1100Term_289_EK1100_9C677E5049Term_294_EK1100Term_294_EK1100_DFE2A59E42Term_307_EK1100Term_307_EK1100_EB8FAA4162";
			AttributeCRC = "418943519";
			AttributeSize = "153";
			AttributeName = "Term 288 (EK1122)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_288_EK1122_18F8921F
	{
		public void CopyPlainToCyclic(Plc1.Term_288_EK1122_18F8921F target)
		{
			base.CopyPlainToCyclic(target);
			Term_289_EK1100.CopyPlainToCyclic(target.Term_289_EK1100);
			Term_294_EK1100.CopyPlainToCyclic(target.Term_294_EK1100);
			Term_307_EK1100.CopyPlainToCyclic(target.Term_307_EK1100);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_288_EK1122_18F8921F target)
		{
			this.CopyPlainToCyclic((Plc1.Term_288_EK1122_18F8921F)target);
		}

		public void CopyPlainToShadow(Plc1.Term_288_EK1122_18F8921F target)
		{
			base.CopyPlainToShadow(target);
			Term_289_EK1100.CopyPlainToShadow(target.Term_289_EK1100);
			Term_294_EK1100.CopyPlainToShadow(target.Term_294_EK1100);
			Term_307_EK1100.CopyPlainToShadow(target.Term_307_EK1100);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_288_EK1122_18F8921F target)
		{
			this.CopyPlainToShadow((Plc1.Term_288_EK1122_18F8921F)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_288_EK1122_18F8921F source)
		{
			base.CopyCyclicToPlain(source);
			Term_289_EK1100.CopyCyclicToPlain(source.Term_289_EK1100);
			Term_294_EK1100.CopyCyclicToPlain(source.Term_294_EK1100);
			Term_307_EK1100.CopyCyclicToPlain(source.Term_307_EK1100);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_288_EK1122_18F8921F source)
		{
			this.CopyCyclicToPlain((Plc1.Term_288_EK1122_18F8921F)source);
		}

		public void CopyShadowToPlain(Plc1.Term_288_EK1122_18F8921F source)
		{
			base.CopyShadowToPlain(source);
			Term_289_EK1100.CopyShadowToPlain(source.Term_289_EK1100);
			Term_294_EK1100.CopyShadowToPlain(source.Term_294_EK1100);
			Term_307_EK1100.CopyShadowToPlain(source.Term_307_EK1100);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_288_EK1122_18F8921F source)
		{
			this.CopyShadowToPlain((Plc1.Term_288_EK1122_18F8921F)source);
		}
	}
}