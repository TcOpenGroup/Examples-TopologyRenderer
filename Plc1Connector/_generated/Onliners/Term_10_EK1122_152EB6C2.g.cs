using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1122-0000-0018\" } {attribute addProperty Id \"Term_11_EK1100Term_11_EK1100_B6553301142Term_18_EK1100Term_18_EK1100_20659A8D72Term_23_EK1100Term_23_EK1100_C1096874973Term_42_EK1100Term_42_EK1100_1039F2C424\" } {attribute addProperty CRC \"355382978\" } {attribute addProperty Size \"1211\" } {attribute addProperty Name \"Term 10 (EK1122)\" }", "Term_10_EK1122_152EB6C2", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_10_EK1122_152EB6C2 : EK1122_1FC0878B, Vortex.Connector.IVortexObject, ITerm_10_EK1122_152EB6C2, IShadowTerm_10_EK1122_152EB6C2, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_11_EK1100_B6553301 _Term_11_EK1100;
		public Term_11_EK1100_B6553301 Term_11_EK1100
		{
			get
			{
				return _Term_11_EK1100;
			}
		}

		ITerm_11_EK1100_B6553301 ITerm_10_EK1122_152EB6C2.Term_11_EK1100
		{
			get
			{
				return Term_11_EK1100;
			}
		}

		IShadowTerm_11_EK1100_B6553301 IShadowTerm_10_EK1122_152EB6C2.Term_11_EK1100
		{
			get
			{
				return Term_11_EK1100;
			}
		}

		Term_18_EK1100_20659A8D _Term_18_EK1100;
		public Term_18_EK1100_20659A8D Term_18_EK1100
		{
			get
			{
				return _Term_18_EK1100;
			}
		}

		ITerm_18_EK1100_20659A8D ITerm_10_EK1122_152EB6C2.Term_18_EK1100
		{
			get
			{
				return Term_18_EK1100;
			}
		}

		IShadowTerm_18_EK1100_20659A8D IShadowTerm_10_EK1122_152EB6C2.Term_18_EK1100
		{
			get
			{
				return Term_18_EK1100;
			}
		}

		Term_23_EK1100_C1096874 _Term_23_EK1100;
		public Term_23_EK1100_C1096874 Term_23_EK1100
		{
			get
			{
				return _Term_23_EK1100;
			}
		}

		ITerm_23_EK1100_C1096874 ITerm_10_EK1122_152EB6C2.Term_23_EK1100
		{
			get
			{
				return Term_23_EK1100;
			}
		}

		IShadowTerm_23_EK1100_C1096874 IShadowTerm_10_EK1122_152EB6C2.Term_23_EK1100
		{
			get
			{
				return Term_23_EK1100;
			}
		}

		Term_42_EK1100_1039F2C4 _Term_42_EK1100;
		public Term_42_EK1100_1039F2C4 Term_42_EK1100
		{
			get
			{
				return _Term_42_EK1100;
			}
		}

		ITerm_42_EK1100_1039F2C4 ITerm_10_EK1122_152EB6C2.Term_42_EK1100
		{
			get
			{
				return Term_42_EK1100;
			}
		}

		IShadowTerm_42_EK1100_1039F2C4 IShadowTerm_10_EK1122_152EB6C2.Term_42_EK1100
		{
			get
			{
				return Term_42_EK1100;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_11_EK1100.LazyOnlineToShadow();
			Term_18_EK1100.LazyOnlineToShadow();
			Term_23_EK1100.LazyOnlineToShadow();
			Term_42_EK1100.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_11_EK1100.LazyShadowToOnline();
			Term_18_EK1100.LazyShadowToOnline();
			Term_23_EK1100.LazyShadowToOnline();
			Term_42_EK1100.LazyShadowToOnline();
		}

		public new PlainTerm_10_EK1122_152EB6C2 CreatePlainerType()
		{
			var cloned = new PlainTerm_10_EK1122_152EB6C2();
			base.CreatePlainerType(cloned);
			cloned.Term_11_EK1100 = Term_11_EK1100.CreatePlainerType();
			cloned.Term_18_EK1100 = Term_18_EK1100.CreatePlainerType();
			cloned.Term_23_EK1100 = Term_23_EK1100.CreatePlainerType();
			cloned.Term_42_EK1100 = Term_42_EK1100.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_10_EK1122_152EB6C2 CreatePlainerType(PlainTerm_10_EK1122_152EB6C2 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_11_EK1100 = Term_11_EK1100.CreatePlainerType();
			cloned.Term_18_EK1100 = Term_18_EK1100.CreatePlainerType();
			cloned.Term_23_EK1100 = Term_23_EK1100.CreatePlainerType();
			cloned.Term_42_EK1100 = Term_42_EK1100.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_10_EK1122_152EB6C2 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_10_EK1122_152EB6C2 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_10_EK1122_152EB6C2 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_10_EK1122_152EB6C2(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_11_EK1100 = new Term_11_EK1100_B6553301(this, "Term 11 (EK1100)", "Term_11_EK1100");
			_Term_11_EK1100.AttributeName = "Term 11 (EK1100)";
			_Term_11_EK1100.AttributePreviousPort = "Term 10 (EK1122) : D";
			_Term_11_EK1100.AttributeSyncUnit = "default";
			_Term_18_EK1100 = new Term_18_EK1100_20659A8D(this, "Term 18 (EK1100)", "Term_18_EK1100");
			_Term_18_EK1100.AttributeName = "Term 18 (EK1100)";
			_Term_18_EK1100.AttributePreviousPort = "Term 17 (EK1110) : B";
			_Term_18_EK1100.AttributeSyncUnit = "default";
			_Term_23_EK1100 = new Term_23_EK1100_C1096874(this, "Term 23 (EK1100)", "Term_23_EK1100");
			_Term_23_EK1100.AttributeName = "Term 23 (EK1100)";
			_Term_23_EK1100.AttributePreviousPort = "Term 10 (EK1122) : B";
			_Term_23_EK1100.AttributeSyncUnit = "default";
			_Term_42_EK1100 = new Term_42_EK1100_1039F2C4(this, "Term 42 (EK1100)", "Term_42_EK1100");
			_Term_42_EK1100.AttributeName = "Term 42 (EK1100)";
			_Term_42_EK1100.AttributePreviousPort = "Term 40 (EK1110) : B";
			_Term_42_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_11_EK1100Term_11_EK1100_B6553301142Term_18_EK1100Term_18_EK1100_20659A8D72Term_23_EK1100Term_23_EK1100_C1096874973Term_42_EK1100Term_42_EK1100_1039F2C424";
			AttributeCRC = "355382978";
			AttributeSize = "1211";
			AttributeName = "Term 10 (EK1122)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_10_EK1122_152EB6C2(): base ()
		{
			PexPreConstructorParameterless();
			_Term_11_EK1100 = new Term_11_EK1100_B6553301();
			_Term_11_EK1100.AttributeName = "Term 11 (EK1100)";
			_Term_11_EK1100.AttributePreviousPort = "Term 10 (EK1122) : D";
			_Term_11_EK1100.AttributeSyncUnit = "default";
			_Term_18_EK1100 = new Term_18_EK1100_20659A8D();
			_Term_18_EK1100.AttributeName = "Term 18 (EK1100)";
			_Term_18_EK1100.AttributePreviousPort = "Term 17 (EK1110) : B";
			_Term_18_EK1100.AttributeSyncUnit = "default";
			_Term_23_EK1100 = new Term_23_EK1100_C1096874();
			_Term_23_EK1100.AttributeName = "Term 23 (EK1100)";
			_Term_23_EK1100.AttributePreviousPort = "Term 10 (EK1122) : B";
			_Term_23_EK1100.AttributeSyncUnit = "default";
			_Term_42_EK1100 = new Term_42_EK1100_1039F2C4();
			_Term_42_EK1100.AttributeName = "Term 42 (EK1100)";
			_Term_42_EK1100.AttributePreviousPort = "Term 40 (EK1110) : B";
			_Term_42_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_11_EK1100Term_11_EK1100_B6553301142Term_18_EK1100Term_18_EK1100_20659A8D72Term_23_EK1100Term_23_EK1100_C1096874973Term_42_EK1100Term_42_EK1100_1039F2C424";
			AttributeCRC = "355382978";
			AttributeSize = "1211";
			AttributeName = "Term 10 (EK1122)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_10_EK1122_152EB6C2
	{
		public void CopyPlainToCyclic(Plc1.Term_10_EK1122_152EB6C2 target)
		{
			base.CopyPlainToCyclic(target);
			Term_11_EK1100.CopyPlainToCyclic(target.Term_11_EK1100);
			Term_18_EK1100.CopyPlainToCyclic(target.Term_18_EK1100);
			Term_23_EK1100.CopyPlainToCyclic(target.Term_23_EK1100);
			Term_42_EK1100.CopyPlainToCyclic(target.Term_42_EK1100);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_10_EK1122_152EB6C2 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_10_EK1122_152EB6C2)target);
		}

		public void CopyPlainToShadow(Plc1.Term_10_EK1122_152EB6C2 target)
		{
			base.CopyPlainToShadow(target);
			Term_11_EK1100.CopyPlainToShadow(target.Term_11_EK1100);
			Term_18_EK1100.CopyPlainToShadow(target.Term_18_EK1100);
			Term_23_EK1100.CopyPlainToShadow(target.Term_23_EK1100);
			Term_42_EK1100.CopyPlainToShadow(target.Term_42_EK1100);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_10_EK1122_152EB6C2 target)
		{
			this.CopyPlainToShadow((Plc1.Term_10_EK1122_152EB6C2)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_10_EK1122_152EB6C2 source)
		{
			base.CopyCyclicToPlain(source);
			Term_11_EK1100.CopyCyclicToPlain(source.Term_11_EK1100);
			Term_18_EK1100.CopyCyclicToPlain(source.Term_18_EK1100);
			Term_23_EK1100.CopyCyclicToPlain(source.Term_23_EK1100);
			Term_42_EK1100.CopyCyclicToPlain(source.Term_42_EK1100);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_10_EK1122_152EB6C2 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_10_EK1122_152EB6C2)source);
		}

		public void CopyShadowToPlain(Plc1.Term_10_EK1122_152EB6C2 source)
		{
			base.CopyShadowToPlain(source);
			Term_11_EK1100.CopyShadowToPlain(source.Term_11_EK1100);
			Term_18_EK1100.CopyShadowToPlain(source.Term_18_EK1100);
			Term_23_EK1100.CopyShadowToPlain(source.Term_23_EK1100);
			Term_42_EK1100.CopyShadowToPlain(source.Term_42_EK1100);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_10_EK1122_152EB6C2 source)
		{
			this.CopyShadowToPlain((Plc1.Term_10_EK1122_152EB6C2)source);
		}
	}
}