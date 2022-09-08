using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1122-0000-0018\" } {attribute addProperty Id \"Term_331_EK1100Term_331_EK1100_B9C4E09220Term_333_EK1100Term_333_EK1100_1D6F204220\" } {attribute addProperty CRC \"249454846\" } {attribute addProperty Size \"40\" } {attribute addProperty Name \"Term 330 (EK1122)\" }", "Term_330_EK1122_0EDE60FE", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_330_EK1122_0EDE60FE : EK1122_1FC0878B, Vortex.Connector.IVortexObject, ITerm_330_EK1122_0EDE60FE, IShadowTerm_330_EK1122_0EDE60FE, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_331_EK1100_B9C4E092 _Term_331_EK1100;
		public Term_331_EK1100_B9C4E092 Term_331_EK1100
		{
			get
			{
				return _Term_331_EK1100;
			}
		}

		ITerm_331_EK1100_B9C4E092 ITerm_330_EK1122_0EDE60FE.Term_331_EK1100
		{
			get
			{
				return Term_331_EK1100;
			}
		}

		IShadowTerm_331_EK1100_B9C4E092 IShadowTerm_330_EK1122_0EDE60FE.Term_331_EK1100
		{
			get
			{
				return Term_331_EK1100;
			}
		}

		Term_333_EK1100_1D6F2042 _Term_333_EK1100;
		public Term_333_EK1100_1D6F2042 Term_333_EK1100
		{
			get
			{
				return _Term_333_EK1100;
			}
		}

		ITerm_333_EK1100_1D6F2042 ITerm_330_EK1122_0EDE60FE.Term_333_EK1100
		{
			get
			{
				return Term_333_EK1100;
			}
		}

		IShadowTerm_333_EK1100_1D6F2042 IShadowTerm_330_EK1122_0EDE60FE.Term_333_EK1100
		{
			get
			{
				return Term_333_EK1100;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_331_EK1100.LazyOnlineToShadow();
			Term_333_EK1100.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_331_EK1100.LazyShadowToOnline();
			Term_333_EK1100.LazyShadowToOnline();
		}

		public new PlainTerm_330_EK1122_0EDE60FE CreatePlainerType()
		{
			var cloned = new PlainTerm_330_EK1122_0EDE60FE();
			base.CreatePlainerType(cloned);
			cloned.Term_331_EK1100 = Term_331_EK1100.CreatePlainerType();
			cloned.Term_333_EK1100 = Term_333_EK1100.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_330_EK1122_0EDE60FE CreatePlainerType(PlainTerm_330_EK1122_0EDE60FE cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_331_EK1100 = Term_331_EK1100.CreatePlainerType();
			cloned.Term_333_EK1100 = Term_333_EK1100.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_330_EK1122_0EDE60FE source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_330_EK1122_0EDE60FE source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_330_EK1122_0EDE60FE source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_330_EK1122_0EDE60FE(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_331_EK1100 = new Term_331_EK1100_B9C4E092(this, "Term 331 (EK1100)", "Term_331_EK1100");
			_Term_331_EK1100.AttributeName = "Term 331 (EK1100)";
			_Term_331_EK1100.AttributePreviousPort = "Term 330 (EK1122) : D";
			_Term_331_EK1100.AttributeSyncUnit = "default";
			_Term_333_EK1100 = new Term_333_EK1100_1D6F2042(this, "Term 333 (EK1100)", "Term_333_EK1100");
			_Term_333_EK1100.AttributeName = "Term 333 (EK1100)";
			_Term_333_EK1100.AttributePreviousPort = "Term 331 (EK1100) : C";
			_Term_333_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_331_EK1100Term_331_EK1100_B9C4E09220Term_333_EK1100Term_333_EK1100_1D6F204220";
			AttributeCRC = "249454846";
			AttributeSize = "40";
			AttributeName = "Term 330 (EK1122)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_330_EK1122_0EDE60FE(): base ()
		{
			PexPreConstructorParameterless();
			_Term_331_EK1100 = new Term_331_EK1100_B9C4E092();
			_Term_331_EK1100.AttributeName = "Term 331 (EK1100)";
			_Term_331_EK1100.AttributePreviousPort = "Term 330 (EK1122) : D";
			_Term_331_EK1100.AttributeSyncUnit = "default";
			_Term_333_EK1100 = new Term_333_EK1100_1D6F2042();
			_Term_333_EK1100.AttributeName = "Term 333 (EK1100)";
			_Term_333_EK1100.AttributePreviousPort = "Term 331 (EK1100) : C";
			_Term_333_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_331_EK1100Term_331_EK1100_B9C4E09220Term_333_EK1100Term_333_EK1100_1D6F204220";
			AttributeCRC = "249454846";
			AttributeSize = "40";
			AttributeName = "Term 330 (EK1122)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_330_EK1122_0EDE60FE
	{
		public void CopyPlainToCyclic(Plc1.Term_330_EK1122_0EDE60FE target)
		{
			base.CopyPlainToCyclic(target);
			Term_331_EK1100.CopyPlainToCyclic(target.Term_331_EK1100);
			Term_333_EK1100.CopyPlainToCyclic(target.Term_333_EK1100);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_330_EK1122_0EDE60FE target)
		{
			this.CopyPlainToCyclic((Plc1.Term_330_EK1122_0EDE60FE)target);
		}

		public void CopyPlainToShadow(Plc1.Term_330_EK1122_0EDE60FE target)
		{
			base.CopyPlainToShadow(target);
			Term_331_EK1100.CopyPlainToShadow(target.Term_331_EK1100);
			Term_333_EK1100.CopyPlainToShadow(target.Term_333_EK1100);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_330_EK1122_0EDE60FE target)
		{
			this.CopyPlainToShadow((Plc1.Term_330_EK1122_0EDE60FE)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_330_EK1122_0EDE60FE source)
		{
			base.CopyCyclicToPlain(source);
			Term_331_EK1100.CopyCyclicToPlain(source.Term_331_EK1100);
			Term_333_EK1100.CopyCyclicToPlain(source.Term_333_EK1100);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_330_EK1122_0EDE60FE source)
		{
			this.CopyCyclicToPlain((Plc1.Term_330_EK1122_0EDE60FE)source);
		}

		public void CopyShadowToPlain(Plc1.Term_330_EK1122_0EDE60FE source)
		{
			base.CopyShadowToPlain(source);
			Term_331_EK1100.CopyShadowToPlain(source.Term_331_EK1100);
			Term_333_EK1100.CopyShadowToPlain(source.Term_333_EK1100);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_330_EK1122_0EDE60FE source)
		{
			this.CopyShadowToPlain((Plc1.Term_330_EK1122_0EDE60FE)source);
		}
	}
}