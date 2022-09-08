using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_12_EL3174_0002EL3174_B71BFF4244Term_13_EL6001EL6001_0DE01E7E61Term_14_EL3011EL3011_7A49522813Term_15_EL2008EL2008_E2806B9511Term_16_EL2008EL2008_E2806B9511Term_17_EK1110EK1110_1FC0878B2\" } {attribute addProperty CRC \"3059036929\" } {attribute addProperty Size \"142\" } {attribute addProperty Name \"Term 11 (EK1100)\" }", "Term_11_EK1100_B6553301", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_11_EK1100_B6553301 : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_11_EK1100_B6553301, IShadowTerm_11_EK1100_B6553301, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		EL3174_B71BFF42 _Term_12_EL3174_0002;
		public EL3174_B71BFF42 Term_12_EL3174_0002
		{
			get
			{
				return _Term_12_EL3174_0002;
			}
		}

		IEL3174_B71BFF42 ITerm_11_EK1100_B6553301.Term_12_EL3174_0002
		{
			get
			{
				return Term_12_EL3174_0002;
			}
		}

		IShadowEL3174_B71BFF42 IShadowTerm_11_EK1100_B6553301.Term_12_EL3174_0002
		{
			get
			{
				return Term_12_EL3174_0002;
			}
		}

		EL6001_0DE01E7E _Term_13_EL6001;
		public EL6001_0DE01E7E Term_13_EL6001
		{
			get
			{
				return _Term_13_EL6001;
			}
		}

		IEL6001_0DE01E7E ITerm_11_EK1100_B6553301.Term_13_EL6001
		{
			get
			{
				return Term_13_EL6001;
			}
		}

		IShadowEL6001_0DE01E7E IShadowTerm_11_EK1100_B6553301.Term_13_EL6001
		{
			get
			{
				return Term_13_EL6001;
			}
		}

		EL3011_7A495228 _Term_14_EL3011;
		public EL3011_7A495228 Term_14_EL3011
		{
			get
			{
				return _Term_14_EL3011;
			}
		}

		IEL3011_7A495228 ITerm_11_EK1100_B6553301.Term_14_EL3011
		{
			get
			{
				return Term_14_EL3011;
			}
		}

		IShadowEL3011_7A495228 IShadowTerm_11_EK1100_B6553301.Term_14_EL3011
		{
			get
			{
				return Term_14_EL3011;
			}
		}

		EL2008_E2806B95 _Term_15_EL2008;
		public EL2008_E2806B95 Term_15_EL2008
		{
			get
			{
				return _Term_15_EL2008;
			}
		}

		IEL2008_E2806B95 ITerm_11_EK1100_B6553301.Term_15_EL2008
		{
			get
			{
				return Term_15_EL2008;
			}
		}

		IShadowEL2008_E2806B95 IShadowTerm_11_EK1100_B6553301.Term_15_EL2008
		{
			get
			{
				return Term_15_EL2008;
			}
		}

		EL2008_E2806B95 _Term_16_EL2008;
		public EL2008_E2806B95 Term_16_EL2008
		{
			get
			{
				return _Term_16_EL2008;
			}
		}

		IEL2008_E2806B95 ITerm_11_EK1100_B6553301.Term_16_EL2008
		{
			get
			{
				return Term_16_EL2008;
			}
		}

		IShadowEL2008_E2806B95 IShadowTerm_11_EK1100_B6553301.Term_16_EL2008
		{
			get
			{
				return Term_16_EL2008;
			}
		}

		EK1110_1FC0878B _Term_17_EK1110;
		public EK1110_1FC0878B Term_17_EK1110
		{
			get
			{
				return _Term_17_EK1110;
			}
		}

		IEK1110_1FC0878B ITerm_11_EK1100_B6553301.Term_17_EK1110
		{
			get
			{
				return Term_17_EK1110;
			}
		}

		IShadowEK1110_1FC0878B IShadowTerm_11_EK1100_B6553301.Term_17_EK1110
		{
			get
			{
				return Term_17_EK1110;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_12_EL3174_0002.LazyOnlineToShadow();
			Term_13_EL6001.LazyOnlineToShadow();
			Term_14_EL3011.LazyOnlineToShadow();
			Term_15_EL2008.LazyOnlineToShadow();
			Term_16_EL2008.LazyOnlineToShadow();
			Term_17_EK1110.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_12_EL3174_0002.LazyShadowToOnline();
			Term_13_EL6001.LazyShadowToOnline();
			Term_14_EL3011.LazyShadowToOnline();
			Term_15_EL2008.LazyShadowToOnline();
			Term_16_EL2008.LazyShadowToOnline();
			Term_17_EK1110.LazyShadowToOnline();
		}

		public new PlainTerm_11_EK1100_B6553301 CreatePlainerType()
		{
			var cloned = new PlainTerm_11_EK1100_B6553301();
			base.CreatePlainerType(cloned);
			cloned.Term_12_EL3174_0002 = Term_12_EL3174_0002.CreatePlainerType();
			cloned.Term_13_EL6001 = Term_13_EL6001.CreatePlainerType();
			cloned.Term_14_EL3011 = Term_14_EL3011.CreatePlainerType();
			cloned.Term_15_EL2008 = Term_15_EL2008.CreatePlainerType();
			cloned.Term_16_EL2008 = Term_16_EL2008.CreatePlainerType();
			cloned.Term_17_EK1110 = Term_17_EK1110.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_11_EK1100_B6553301 CreatePlainerType(PlainTerm_11_EK1100_B6553301 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_12_EL3174_0002 = Term_12_EL3174_0002.CreatePlainerType();
			cloned.Term_13_EL6001 = Term_13_EL6001.CreatePlainerType();
			cloned.Term_14_EL3011 = Term_14_EL3011.CreatePlainerType();
			cloned.Term_15_EL2008 = Term_15_EL2008.CreatePlainerType();
			cloned.Term_16_EL2008 = Term_16_EL2008.CreatePlainerType();
			cloned.Term_17_EK1110 = Term_17_EK1110.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_11_EK1100_B6553301 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_11_EK1100_B6553301 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_11_EK1100_B6553301 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_11_EK1100_B6553301(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_12_EL3174_0002 = new EL3174_B71BFF42(this, "Term 12 (EL3174-0002)", "Term_12_EL3174_0002");
			_Term_12_EL3174_0002.AttributeName = "Term 12 (EL3174-0002)";
			_Term_12_EL3174_0002.AttributePreviousPort = "Term 11 (EK1100) : B";
			_Term_12_EL3174_0002.AttributeSyncUnit = "Row_1";
			_Term_13_EL6001 = new EL6001_0DE01E7E(this, "Term 13 (EL6001)", "Term_13_EL6001");
			_Term_13_EL6001.AttributeName = "Term 13 (EL6001)";
			_Term_13_EL6001.AttributePreviousPort = "Term 12 (EL3174-0002) : B";
			_Term_13_EL6001.AttributeSyncUnit = "Row_1";
			_Term_14_EL3011 = new EL3011_7A495228(this, "Term 14 (EL3011)", "Term_14_EL3011");
			_Term_14_EL3011.AttributeName = "Term 14 (EL3011)";
			_Term_14_EL3011.AttributePreviousPort = "Term 13 (EL6001) : B";
			_Term_14_EL3011.AttributeSyncUnit = "Row_1";
			_Term_15_EL2008 = new EL2008_E2806B95(this, "Term 15 (EL2008)", "Term_15_EL2008");
			_Term_15_EL2008.AttributeName = "Term 15 (EL2008)";
			_Term_15_EL2008.AttributePreviousPort = "Term 14 (EL3011) : B";
			_Term_15_EL2008.AttributeSyncUnit = "Row_1";
			_Term_16_EL2008 = new EL2008_E2806B95(this, "Term 16 (EL2008)", "Term_16_EL2008");
			_Term_16_EL2008.AttributeName = "Term 16 (EL2008)";
			_Term_16_EL2008.AttributePreviousPort = "Term 15 (EL2008) : B";
			_Term_16_EL2008.AttributeSyncUnit = "Row_1";
			_Term_17_EK1110 = new EK1110_1FC0878B(this, "Term 17 (EK1110)", "Term_17_EK1110");
			_Term_17_EK1110.AttributeName = "Term 17 (EK1110)";
			_Term_17_EK1110.AttributePreviousPort = "Term 16 (EL2008) : B";
			_Term_17_EK1110.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_12_EL3174_0002EL3174_B71BFF4244Term_13_EL6001EL6001_0DE01E7E61Term_14_EL3011EL3011_7A49522813Term_15_EL2008EL2008_E2806B9511Term_16_EL2008EL2008_E2806B9511Term_17_EK1110EK1110_1FC0878B2";
			AttributeCRC = "3059036929";
			AttributeSize = "142";
			AttributeName = "Term 11 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_11_EK1100_B6553301(): base ()
		{
			PexPreConstructorParameterless();
			_Term_12_EL3174_0002 = new EL3174_B71BFF42();
			_Term_12_EL3174_0002.AttributeName = "Term 12 (EL3174-0002)";
			_Term_12_EL3174_0002.AttributePreviousPort = "Term 11 (EK1100) : B";
			_Term_12_EL3174_0002.AttributeSyncUnit = "Row_1";
			_Term_13_EL6001 = new EL6001_0DE01E7E();
			_Term_13_EL6001.AttributeName = "Term 13 (EL6001)";
			_Term_13_EL6001.AttributePreviousPort = "Term 12 (EL3174-0002) : B";
			_Term_13_EL6001.AttributeSyncUnit = "Row_1";
			_Term_14_EL3011 = new EL3011_7A495228();
			_Term_14_EL3011.AttributeName = "Term 14 (EL3011)";
			_Term_14_EL3011.AttributePreviousPort = "Term 13 (EL6001) : B";
			_Term_14_EL3011.AttributeSyncUnit = "Row_1";
			_Term_15_EL2008 = new EL2008_E2806B95();
			_Term_15_EL2008.AttributeName = "Term 15 (EL2008)";
			_Term_15_EL2008.AttributePreviousPort = "Term 14 (EL3011) : B";
			_Term_15_EL2008.AttributeSyncUnit = "Row_1";
			_Term_16_EL2008 = new EL2008_E2806B95();
			_Term_16_EL2008.AttributeName = "Term 16 (EL2008)";
			_Term_16_EL2008.AttributePreviousPort = "Term 15 (EL2008) : B";
			_Term_16_EL2008.AttributeSyncUnit = "Row_1";
			_Term_17_EK1110 = new EK1110_1FC0878B();
			_Term_17_EK1110.AttributeName = "Term 17 (EK1110)";
			_Term_17_EK1110.AttributePreviousPort = "Term 16 (EL2008) : B";
			_Term_17_EK1110.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_12_EL3174_0002EL3174_B71BFF4244Term_13_EL6001EL6001_0DE01E7E61Term_14_EL3011EL3011_7A49522813Term_15_EL2008EL2008_E2806B9511Term_16_EL2008EL2008_E2806B9511Term_17_EK1110EK1110_1FC0878B2";
			AttributeCRC = "3059036929";
			AttributeSize = "142";
			AttributeName = "Term 11 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_11_EK1100_B6553301
	{
		public void CopyPlainToCyclic(Plc1.Term_11_EK1100_B6553301 target)
		{
			base.CopyPlainToCyclic(target);
			Term_12_EL3174_0002.CopyPlainToCyclic(target.Term_12_EL3174_0002);
			Term_13_EL6001.CopyPlainToCyclic(target.Term_13_EL6001);
			Term_14_EL3011.CopyPlainToCyclic(target.Term_14_EL3011);
			Term_15_EL2008.CopyPlainToCyclic(target.Term_15_EL2008);
			Term_16_EL2008.CopyPlainToCyclic(target.Term_16_EL2008);
			Term_17_EK1110.CopyPlainToCyclic(target.Term_17_EK1110);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_11_EK1100_B6553301 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_11_EK1100_B6553301)target);
		}

		public void CopyPlainToShadow(Plc1.Term_11_EK1100_B6553301 target)
		{
			base.CopyPlainToShadow(target);
			Term_12_EL3174_0002.CopyPlainToShadow(target.Term_12_EL3174_0002);
			Term_13_EL6001.CopyPlainToShadow(target.Term_13_EL6001);
			Term_14_EL3011.CopyPlainToShadow(target.Term_14_EL3011);
			Term_15_EL2008.CopyPlainToShadow(target.Term_15_EL2008);
			Term_16_EL2008.CopyPlainToShadow(target.Term_16_EL2008);
			Term_17_EK1110.CopyPlainToShadow(target.Term_17_EK1110);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_11_EK1100_B6553301 target)
		{
			this.CopyPlainToShadow((Plc1.Term_11_EK1100_B6553301)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_11_EK1100_B6553301 source)
		{
			base.CopyCyclicToPlain(source);
			Term_12_EL3174_0002.CopyCyclicToPlain(source.Term_12_EL3174_0002);
			Term_13_EL6001.CopyCyclicToPlain(source.Term_13_EL6001);
			Term_14_EL3011.CopyCyclicToPlain(source.Term_14_EL3011);
			Term_15_EL2008.CopyCyclicToPlain(source.Term_15_EL2008);
			Term_16_EL2008.CopyCyclicToPlain(source.Term_16_EL2008);
			Term_17_EK1110.CopyCyclicToPlain(source.Term_17_EK1110);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_11_EK1100_B6553301 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_11_EK1100_B6553301)source);
		}

		public void CopyShadowToPlain(Plc1.Term_11_EK1100_B6553301 source)
		{
			base.CopyShadowToPlain(source);
			Term_12_EL3174_0002.CopyShadowToPlain(source.Term_12_EL3174_0002);
			Term_13_EL6001.CopyShadowToPlain(source.Term_13_EL6001);
			Term_14_EL3011.CopyShadowToPlain(source.Term_14_EL3011);
			Term_15_EL2008.CopyShadowToPlain(source.Term_15_EL2008);
			Term_16_EL2008.CopyShadowToPlain(source.Term_16_EL2008);
			Term_17_EK1110.CopyShadowToPlain(source.Term_17_EK1110);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_11_EK1100_B6553301 source)
		{
			this.CopyShadowToPlain((Plc1.Term_11_EK1100_B6553301)source);
		}
	}
}