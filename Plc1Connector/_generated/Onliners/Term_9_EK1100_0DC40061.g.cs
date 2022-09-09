using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_10_EK1122Term_10_EK1122_152EB6C21211Term_34_EL3403EL3403_812980A665Term_35_EL6001EL6001_0DE01E7E61Term_36_EL3024EL3024_C6E76B5A40Term_33_EL9011EL9011_D65D3D320\" } {attribute addProperty CRC \"230948961\" } {attribute addProperty Size \"1377\" } {attribute addProperty Name \"Term 9 (EK1100)\" }", "Term_9_EK1100_0DC40061", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_9_EK1100_0DC40061 : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_9_EK1100_0DC40061, IShadowTerm_9_EK1100_0DC40061, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_10_EK1122_152EB6C2 _Term_10_EK1122;
		public Term_10_EK1122_152EB6C2 Term_10_EK1122
		{
			get
			{
				return _Term_10_EK1122;
			}
		}

		ITerm_10_EK1122_152EB6C2 ITerm_9_EK1100_0DC40061.Term_10_EK1122
		{
			get
			{
				return Term_10_EK1122;
			}
		}

		IShadowTerm_10_EK1122_152EB6C2 IShadowTerm_9_EK1100_0DC40061.Term_10_EK1122
		{
			get
			{
				return Term_10_EK1122;
			}
		}

		EL3403_812980A6 _Term_34_EL3403;
		public EL3403_812980A6 Term_34_EL3403
		{
			get
			{
				return _Term_34_EL3403;
			}
		}

		IEL3403_812980A6 ITerm_9_EK1100_0DC40061.Term_34_EL3403
		{
			get
			{
				return Term_34_EL3403;
			}
		}

		IShadowEL3403_812980A6 IShadowTerm_9_EK1100_0DC40061.Term_34_EL3403
		{
			get
			{
				return Term_34_EL3403;
			}
		}

		EL6001_0DE01E7E _Term_35_EL6001;
		public EL6001_0DE01E7E Term_35_EL6001
		{
			get
			{
				return _Term_35_EL6001;
			}
		}

		IEL6001_0DE01E7E ITerm_9_EK1100_0DC40061.Term_35_EL6001
		{
			get
			{
				return Term_35_EL6001;
			}
		}

		IShadowEL6001_0DE01E7E IShadowTerm_9_EK1100_0DC40061.Term_35_EL6001
		{
			get
			{
				return Term_35_EL6001;
			}
		}

		EL3024_C6E76B5A _Term_36_EL3024;
		public EL3024_C6E76B5A Term_36_EL3024
		{
			get
			{
				return _Term_36_EL3024;
			}
		}

		IEL3024_C6E76B5A ITerm_9_EK1100_0DC40061.Term_36_EL3024
		{
			get
			{
				return Term_36_EL3024;
			}
		}

		IShadowEL3024_C6E76B5A IShadowTerm_9_EK1100_0DC40061.Term_36_EL3024
		{
			get
			{
				return Term_36_EL3024;
			}
		}

		EL9011_D65D3D32 _Term_33_EL9011;
		public EL9011_D65D3D32 Term_33_EL9011
		{
			get
			{
				return _Term_33_EL9011;
			}
		}

		IEL9011_D65D3D32 ITerm_9_EK1100_0DC40061.Term_33_EL9011
		{
			get
			{
				return Term_33_EL9011;
			}
		}

		IShadowEL9011_D65D3D32 IShadowTerm_9_EK1100_0DC40061.Term_33_EL9011
		{
			get
			{
				return Term_33_EL9011;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_10_EK1122.LazyOnlineToShadow();
			Term_34_EL3403.LazyOnlineToShadow();
			Term_35_EL6001.LazyOnlineToShadow();
			Term_36_EL3024.LazyOnlineToShadow();
			Term_33_EL9011.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_10_EK1122.LazyShadowToOnline();
			Term_34_EL3403.LazyShadowToOnline();
			Term_35_EL6001.LazyShadowToOnline();
			Term_36_EL3024.LazyShadowToOnline();
			Term_33_EL9011.LazyShadowToOnline();
		}

		public new PlainTerm_9_EK1100_0DC40061 CreatePlainerType()
		{
			var cloned = new PlainTerm_9_EK1100_0DC40061();
			base.CreatePlainerType(cloned);
			cloned.Term_10_EK1122 = Term_10_EK1122.CreatePlainerType();
			cloned.Term_34_EL3403 = Term_34_EL3403.CreatePlainerType();
			cloned.Term_35_EL6001 = Term_35_EL6001.CreatePlainerType();
			cloned.Term_36_EL3024 = Term_36_EL3024.CreatePlainerType();
			cloned.Term_33_EL9011 = Term_33_EL9011.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_9_EK1100_0DC40061 CreatePlainerType(PlainTerm_9_EK1100_0DC40061 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_10_EK1122 = Term_10_EK1122.CreatePlainerType();
			cloned.Term_34_EL3403 = Term_34_EL3403.CreatePlainerType();
			cloned.Term_35_EL6001 = Term_35_EL6001.CreatePlainerType();
			cloned.Term_36_EL3024 = Term_36_EL3024.CreatePlainerType();
			cloned.Term_33_EL9011 = Term_33_EL9011.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_9_EK1100_0DC40061 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_9_EK1100_0DC40061 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_9_EK1100_0DC40061 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_9_EK1100_0DC40061(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_10_EK1122 = new Term_10_EK1122_152EB6C2(this, "Term 10 (EK1122)", "Term_10_EK1122");
			_Term_10_EK1122.AttributeName = "Term 10 (EK1122)";
			_Term_10_EK1122.AttributePreviousPort = "Term 9 (EK1100) : B";
			_Term_10_EK1122.AttributeSyncUnit = "default";
			_Term_34_EL3403 = new EL3403_812980A6(this, "Term 34 (EL3403)", "Term_34_EL3403");
			_Term_34_EL3403.AttributeName = "Term 34 (EL3403)";
			_Term_34_EL3403.AttributePreviousPort = "Term 10 (EK1122) : C";
			_Term_34_EL3403.AttributeSyncUnit = "Row_0";
			_Term_35_EL6001 = new EL6001_0DE01E7E(this, "Term 35 (EL6001)", "Term_35_EL6001");
			_Term_35_EL6001.AttributeName = "Term 35 (EL6001)";
			_Term_35_EL6001.AttributePreviousPort = "Term 34 (EL3403) : B";
			_Term_35_EL6001.AttributeSyncUnit = "Row_0";
			_Term_36_EL3024 = new EL3024_C6E76B5A(this, "Term 36 (EL3024)", "Term_36_EL3024");
			_Term_36_EL3024.AttributeName = "Term 36 (EL3024)";
			_Term_36_EL3024.AttributePreviousPort = "Term 35 (EL6001) : B";
			_Term_36_EL3024.AttributeSyncUnit = "Row_0";
			_Term_33_EL9011 = new EL9011_D65D3D32(this, "Term 33 (EL9011)", "Term_33_EL9011");
			_Term_33_EL9011.AttributeName = "Term 33 (EL9011)";
			_Term_33_EL9011.AttributePreviousPort = "Term 36 (EL3024) : B";
			_Term_33_EL9011.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_10_EK1122Term_10_EK1122_152EB6C21211Term_34_EL3403EL3403_812980A665Term_35_EL6001EL6001_0DE01E7E61Term_36_EL3024EL3024_C6E76B5A40Term_33_EL9011EL9011_D65D3D320";
			AttributeCRC = "230948961";
			AttributeSize = "1377";
			AttributeName = "Term 9 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_9_EK1100_0DC40061(): base ()
		{
			PexPreConstructorParameterless();
			_Term_10_EK1122 = new Term_10_EK1122_152EB6C2();
			_Term_10_EK1122.AttributeName = "Term 10 (EK1122)";
			_Term_10_EK1122.AttributePreviousPort = "Term 9 (EK1100) : B";
			_Term_10_EK1122.AttributeSyncUnit = "default";
			_Term_34_EL3403 = new EL3403_812980A6();
			_Term_34_EL3403.AttributeName = "Term 34 (EL3403)";
			_Term_34_EL3403.AttributePreviousPort = "Term 10 (EK1122) : C";
			_Term_34_EL3403.AttributeSyncUnit = "Row_0";
			_Term_35_EL6001 = new EL6001_0DE01E7E();
			_Term_35_EL6001.AttributeName = "Term 35 (EL6001)";
			_Term_35_EL6001.AttributePreviousPort = "Term 34 (EL3403) : B";
			_Term_35_EL6001.AttributeSyncUnit = "Row_0";
			_Term_36_EL3024 = new EL3024_C6E76B5A();
			_Term_36_EL3024.AttributeName = "Term 36 (EL3024)";
			_Term_36_EL3024.AttributePreviousPort = "Term 35 (EL6001) : B";
			_Term_36_EL3024.AttributeSyncUnit = "Row_0";
			_Term_33_EL9011 = new EL9011_D65D3D32();
			_Term_33_EL9011.AttributeName = "Term 33 (EL9011)";
			_Term_33_EL9011.AttributePreviousPort = "Term 36 (EL3024) : B";
			_Term_33_EL9011.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_10_EK1122Term_10_EK1122_152EB6C21211Term_34_EL3403EL3403_812980A665Term_35_EL6001EL6001_0DE01E7E61Term_36_EL3024EL3024_C6E76B5A40Term_33_EL9011EL9011_D65D3D320";
			AttributeCRC = "230948961";
			AttributeSize = "1377";
			AttributeName = "Term 9 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_9_EK1100_0DC40061
	{
		public void CopyPlainToCyclic(Plc1.Term_9_EK1100_0DC40061 target)
		{
			base.CopyPlainToCyclic(target);
			Term_10_EK1122.CopyPlainToCyclic(target.Term_10_EK1122);
			Term_34_EL3403.CopyPlainToCyclic(target.Term_34_EL3403);
			Term_35_EL6001.CopyPlainToCyclic(target.Term_35_EL6001);
			Term_36_EL3024.CopyPlainToCyclic(target.Term_36_EL3024);
			Term_33_EL9011.CopyPlainToCyclic(target.Term_33_EL9011);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_9_EK1100_0DC40061 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_9_EK1100_0DC40061)target);
		}

		public void CopyPlainToShadow(Plc1.Term_9_EK1100_0DC40061 target)
		{
			base.CopyPlainToShadow(target);
			Term_10_EK1122.CopyPlainToShadow(target.Term_10_EK1122);
			Term_34_EL3403.CopyPlainToShadow(target.Term_34_EL3403);
			Term_35_EL6001.CopyPlainToShadow(target.Term_35_EL6001);
			Term_36_EL3024.CopyPlainToShadow(target.Term_36_EL3024);
			Term_33_EL9011.CopyPlainToShadow(target.Term_33_EL9011);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_9_EK1100_0DC40061 target)
		{
			this.CopyPlainToShadow((Plc1.Term_9_EK1100_0DC40061)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_9_EK1100_0DC40061 source)
		{
			base.CopyCyclicToPlain(source);
			Term_10_EK1122.CopyCyclicToPlain(source.Term_10_EK1122);
			Term_34_EL3403.CopyCyclicToPlain(source.Term_34_EL3403);
			Term_35_EL6001.CopyCyclicToPlain(source.Term_35_EL6001);
			Term_36_EL3024.CopyCyclicToPlain(source.Term_36_EL3024);
			Term_33_EL9011.CopyCyclicToPlain(source.Term_33_EL9011);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_9_EK1100_0DC40061 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_9_EK1100_0DC40061)source);
		}

		public void CopyShadowToPlain(Plc1.Term_9_EK1100_0DC40061 source)
		{
			base.CopyShadowToPlain(source);
			Term_10_EK1122.CopyShadowToPlain(source.Term_10_EK1122);
			Term_34_EL3403.CopyShadowToPlain(source.Term_34_EL3403);
			Term_35_EL6001.CopyShadowToPlain(source.Term_35_EL6001);
			Term_36_EL3024.CopyShadowToPlain(source.Term_36_EL3024);
			Term_33_EL9011.CopyShadowToPlain(source.Term_33_EL9011);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_9_EK1100_0DC40061 source)
		{
			this.CopyShadowToPlain((Plc1.Term_9_EK1100_0DC40061)source);
		}
	}
}