using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_26_EL1819EL1819_32157CFD20Term_27_EL1819EL1819_32157CFD20Term_30_EL9011EL9011_D65D3D320\" } {attribute addProperty CRC \"136412852\" } {attribute addProperty Size \"40\" } {attribute addProperty Name \"Term 25 (EK1100)\" }", "Term_25_EK1100_08217EB4", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_25_EK1100_08217EB4 : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_25_EK1100_08217EB4, IShadowTerm_25_EK1100_08217EB4, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		EL1819_32157CFD _Term_26_EL1819;
		public EL1819_32157CFD Term_26_EL1819
		{
			get
			{
				return _Term_26_EL1819;
			}
		}

		IEL1819_32157CFD ITerm_25_EK1100_08217EB4.Term_26_EL1819
		{
			get
			{
				return Term_26_EL1819;
			}
		}

		IShadowEL1819_32157CFD IShadowTerm_25_EK1100_08217EB4.Term_26_EL1819
		{
			get
			{
				return Term_26_EL1819;
			}
		}

		EL1819_32157CFD _Term_27_EL1819;
		public EL1819_32157CFD Term_27_EL1819
		{
			get
			{
				return _Term_27_EL1819;
			}
		}

		IEL1819_32157CFD ITerm_25_EK1100_08217EB4.Term_27_EL1819
		{
			get
			{
				return Term_27_EL1819;
			}
		}

		IShadowEL1819_32157CFD IShadowTerm_25_EK1100_08217EB4.Term_27_EL1819
		{
			get
			{
				return Term_27_EL1819;
			}
		}

		EL9011_D65D3D32 _Term_30_EL9011;
		public EL9011_D65D3D32 Term_30_EL9011
		{
			get
			{
				return _Term_30_EL9011;
			}
		}

		IEL9011_D65D3D32 ITerm_25_EK1100_08217EB4.Term_30_EL9011
		{
			get
			{
				return Term_30_EL9011;
			}
		}

		IShadowEL9011_D65D3D32 IShadowTerm_25_EK1100_08217EB4.Term_30_EL9011
		{
			get
			{
				return Term_30_EL9011;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_26_EL1819.LazyOnlineToShadow();
			Term_27_EL1819.LazyOnlineToShadow();
			Term_30_EL9011.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_26_EL1819.LazyShadowToOnline();
			Term_27_EL1819.LazyShadowToOnline();
			Term_30_EL9011.LazyShadowToOnline();
		}

		public new PlainTerm_25_EK1100_08217EB4 CreatePlainerType()
		{
			var cloned = new PlainTerm_25_EK1100_08217EB4();
			base.CreatePlainerType(cloned);
			cloned.Term_26_EL1819 = Term_26_EL1819.CreatePlainerType();
			cloned.Term_27_EL1819 = Term_27_EL1819.CreatePlainerType();
			cloned.Term_30_EL9011 = Term_30_EL9011.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_25_EK1100_08217EB4 CreatePlainerType(PlainTerm_25_EK1100_08217EB4 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_26_EL1819 = Term_26_EL1819.CreatePlainerType();
			cloned.Term_27_EL1819 = Term_27_EL1819.CreatePlainerType();
			cloned.Term_30_EL9011 = Term_30_EL9011.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_25_EK1100_08217EB4 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_25_EK1100_08217EB4 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_25_EK1100_08217EB4 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_25_EK1100_08217EB4(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_26_EL1819 = new EL1819_32157CFD(this, "Term 26 (EL1819)", "Term_26_EL1819");
			_Term_26_EL1819.AttributeName = "Term 26 (EL1819)";
			_Term_26_EL1819.AttributePreviousPort = "Term 25 (EK1100) : B";
			_Term_26_EL1819.AttributeSyncUnit = "Row_3";
			_Term_27_EL1819 = new EL1819_32157CFD(this, "Term 27 (EL1819)", "Term_27_EL1819");
			_Term_27_EL1819.AttributeName = "Term 27 (EL1819)";
			_Term_27_EL1819.AttributePreviousPort = "Term 26 (EL1819) : B";
			_Term_27_EL1819.AttributeSyncUnit = "Row_3";
			_Term_30_EL9011 = new EL9011_D65D3D32(this, "Term 30 (EL9011)", "Term_30_EL9011");
			_Term_30_EL9011.AttributeName = "Term 30 (EL9011)";
			_Term_30_EL9011.AttributePreviousPort = "Term 27 (EL1819) : B";
			_Term_30_EL9011.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_26_EL1819EL1819_32157CFD20Term_27_EL1819EL1819_32157CFD20Term_30_EL9011EL9011_D65D3D320";
			AttributeCRC = "136412852";
			AttributeSize = "40";
			AttributeName = "Term 25 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_25_EK1100_08217EB4(): base ()
		{
			PexPreConstructorParameterless();
			_Term_26_EL1819 = new EL1819_32157CFD();
			_Term_26_EL1819.AttributeName = "Term 26 (EL1819)";
			_Term_26_EL1819.AttributePreviousPort = "Term 25 (EK1100) : B";
			_Term_26_EL1819.AttributeSyncUnit = "Row_3";
			_Term_27_EL1819 = new EL1819_32157CFD();
			_Term_27_EL1819.AttributeName = "Term 27 (EL1819)";
			_Term_27_EL1819.AttributePreviousPort = "Term 26 (EL1819) : B";
			_Term_27_EL1819.AttributeSyncUnit = "Row_3";
			_Term_30_EL9011 = new EL9011_D65D3D32();
			_Term_30_EL9011.AttributeName = "Term 30 (EL9011)";
			_Term_30_EL9011.AttributePreviousPort = "Term 27 (EL1819) : B";
			_Term_30_EL9011.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_26_EL1819EL1819_32157CFD20Term_27_EL1819EL1819_32157CFD20Term_30_EL9011EL9011_D65D3D320";
			AttributeCRC = "136412852";
			AttributeSize = "40";
			AttributeName = "Term 25 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_25_EK1100_08217EB4
	{
		public void CopyPlainToCyclic(Plc1.Term_25_EK1100_08217EB4 target)
		{
			base.CopyPlainToCyclic(target);
			Term_26_EL1819.CopyPlainToCyclic(target.Term_26_EL1819);
			Term_27_EL1819.CopyPlainToCyclic(target.Term_27_EL1819);
			Term_30_EL9011.CopyPlainToCyclic(target.Term_30_EL9011);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_25_EK1100_08217EB4 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_25_EK1100_08217EB4)target);
		}

		public void CopyPlainToShadow(Plc1.Term_25_EK1100_08217EB4 target)
		{
			base.CopyPlainToShadow(target);
			Term_26_EL1819.CopyPlainToShadow(target.Term_26_EL1819);
			Term_27_EL1819.CopyPlainToShadow(target.Term_27_EL1819);
			Term_30_EL9011.CopyPlainToShadow(target.Term_30_EL9011);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_25_EK1100_08217EB4 target)
		{
			this.CopyPlainToShadow((Plc1.Term_25_EK1100_08217EB4)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_25_EK1100_08217EB4 source)
		{
			base.CopyCyclicToPlain(source);
			Term_26_EL1819.CopyCyclicToPlain(source.Term_26_EL1819);
			Term_27_EL1819.CopyCyclicToPlain(source.Term_27_EL1819);
			Term_30_EL9011.CopyCyclicToPlain(source.Term_30_EL9011);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_25_EK1100_08217EB4 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_25_EK1100_08217EB4)source);
		}

		public void CopyShadowToPlain(Plc1.Term_25_EK1100_08217EB4 source)
		{
			base.CopyShadowToPlain(source);
			Term_26_EL1819.CopyShadowToPlain(source.Term_26_EL1819);
			Term_27_EL1819.CopyShadowToPlain(source.Term_27_EL1819);
			Term_30_EL9011.CopyShadowToPlain(source.Term_30_EL9011);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_25_EK1100_08217EB4 source)
		{
			this.CopyShadowToPlain((Plc1.Term_25_EK1100_08217EB4)source);
		}
	}
}