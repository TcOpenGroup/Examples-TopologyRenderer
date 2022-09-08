using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1200-1388-0000\" } {attribute addProperty Id \"Term_2_EL6002EL6002_CD897635118Term_3_EL1809EL1809_32157CFD20Term_4_EL2809EL2809_2B6483BD19Term_5_EL4004EL4004_E203F87511Term_6_EL2809EL2809_2B6483BD19Term_7_EL6001EL6001_0DE01E7E61Term_8_EL9011EL9011_D65D3D320\" } {attribute addProperty CRC \"3012413864\" } {attribute addProperty Size \"248\" } {attribute addProperty Name \"Term 1 (EK1200)\" }", "Term_1_EK1200_B38DC9A8", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_1_EK1200_B38DC9A8 : EK1200_013D0B49, Vortex.Connector.IVortexObject, ITerm_1_EK1200_B38DC9A8, IShadowTerm_1_EK1200_B38DC9A8, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		EL6002_CD897635 _Term_2_EL6002;
		public EL6002_CD897635 Term_2_EL6002
		{
			get
			{
				return _Term_2_EL6002;
			}
		}

		IEL6002_CD897635 ITerm_1_EK1200_B38DC9A8.Term_2_EL6002
		{
			get
			{
				return Term_2_EL6002;
			}
		}

		IShadowEL6002_CD897635 IShadowTerm_1_EK1200_B38DC9A8.Term_2_EL6002
		{
			get
			{
				return Term_2_EL6002;
			}
		}

		EL1809_32157CFD _Term_3_EL1809;
		public EL1809_32157CFD Term_3_EL1809
		{
			get
			{
				return _Term_3_EL1809;
			}
		}

		IEL1809_32157CFD ITerm_1_EK1200_B38DC9A8.Term_3_EL1809
		{
			get
			{
				return Term_3_EL1809;
			}
		}

		IShadowEL1809_32157CFD IShadowTerm_1_EK1200_B38DC9A8.Term_3_EL1809
		{
			get
			{
				return Term_3_EL1809;
			}
		}

		EL2809_2B6483BD _Term_4_EL2809;
		public EL2809_2B6483BD Term_4_EL2809
		{
			get
			{
				return _Term_4_EL2809;
			}
		}

		IEL2809_2B6483BD ITerm_1_EK1200_B38DC9A8.Term_4_EL2809
		{
			get
			{
				return Term_4_EL2809;
			}
		}

		IShadowEL2809_2B6483BD IShadowTerm_1_EK1200_B38DC9A8.Term_4_EL2809
		{
			get
			{
				return Term_4_EL2809;
			}
		}

		EL4004_E203F875 _Term_5_EL4004;
		public EL4004_E203F875 Term_5_EL4004
		{
			get
			{
				return _Term_5_EL4004;
			}
		}

		IEL4004_E203F875 ITerm_1_EK1200_B38DC9A8.Term_5_EL4004
		{
			get
			{
				return Term_5_EL4004;
			}
		}

		IShadowEL4004_E203F875 IShadowTerm_1_EK1200_B38DC9A8.Term_5_EL4004
		{
			get
			{
				return Term_5_EL4004;
			}
		}

		EL2809_2B6483BD _Term_6_EL2809;
		public EL2809_2B6483BD Term_6_EL2809
		{
			get
			{
				return _Term_6_EL2809;
			}
		}

		IEL2809_2B6483BD ITerm_1_EK1200_B38DC9A8.Term_6_EL2809
		{
			get
			{
				return Term_6_EL2809;
			}
		}

		IShadowEL2809_2B6483BD IShadowTerm_1_EK1200_B38DC9A8.Term_6_EL2809
		{
			get
			{
				return Term_6_EL2809;
			}
		}

		EL6001_0DE01E7E _Term_7_EL6001;
		public EL6001_0DE01E7E Term_7_EL6001
		{
			get
			{
				return _Term_7_EL6001;
			}
		}

		IEL6001_0DE01E7E ITerm_1_EK1200_B38DC9A8.Term_7_EL6001
		{
			get
			{
				return Term_7_EL6001;
			}
		}

		IShadowEL6001_0DE01E7E IShadowTerm_1_EK1200_B38DC9A8.Term_7_EL6001
		{
			get
			{
				return Term_7_EL6001;
			}
		}

		EL9011_D65D3D32 _Term_8_EL9011;
		public EL9011_D65D3D32 Term_8_EL9011
		{
			get
			{
				return _Term_8_EL9011;
			}
		}

		IEL9011_D65D3D32 ITerm_1_EK1200_B38DC9A8.Term_8_EL9011
		{
			get
			{
				return Term_8_EL9011;
			}
		}

		IShadowEL9011_D65D3D32 IShadowTerm_1_EK1200_B38DC9A8.Term_8_EL9011
		{
			get
			{
				return Term_8_EL9011;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_2_EL6002.LazyOnlineToShadow();
			Term_3_EL1809.LazyOnlineToShadow();
			Term_4_EL2809.LazyOnlineToShadow();
			Term_5_EL4004.LazyOnlineToShadow();
			Term_6_EL2809.LazyOnlineToShadow();
			Term_7_EL6001.LazyOnlineToShadow();
			Term_8_EL9011.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_2_EL6002.LazyShadowToOnline();
			Term_3_EL1809.LazyShadowToOnline();
			Term_4_EL2809.LazyShadowToOnline();
			Term_5_EL4004.LazyShadowToOnline();
			Term_6_EL2809.LazyShadowToOnline();
			Term_7_EL6001.LazyShadowToOnline();
			Term_8_EL9011.LazyShadowToOnline();
		}

		public new PlainTerm_1_EK1200_B38DC9A8 CreatePlainerType()
		{
			var cloned = new PlainTerm_1_EK1200_B38DC9A8();
			base.CreatePlainerType(cloned);
			cloned.Term_2_EL6002 = Term_2_EL6002.CreatePlainerType();
			cloned.Term_3_EL1809 = Term_3_EL1809.CreatePlainerType();
			cloned.Term_4_EL2809 = Term_4_EL2809.CreatePlainerType();
			cloned.Term_5_EL4004 = Term_5_EL4004.CreatePlainerType();
			cloned.Term_6_EL2809 = Term_6_EL2809.CreatePlainerType();
			cloned.Term_7_EL6001 = Term_7_EL6001.CreatePlainerType();
			cloned.Term_8_EL9011 = Term_8_EL9011.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_1_EK1200_B38DC9A8 CreatePlainerType(PlainTerm_1_EK1200_B38DC9A8 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_2_EL6002 = Term_2_EL6002.CreatePlainerType();
			cloned.Term_3_EL1809 = Term_3_EL1809.CreatePlainerType();
			cloned.Term_4_EL2809 = Term_4_EL2809.CreatePlainerType();
			cloned.Term_5_EL4004 = Term_5_EL4004.CreatePlainerType();
			cloned.Term_6_EL2809 = Term_6_EL2809.CreatePlainerType();
			cloned.Term_7_EL6001 = Term_7_EL6001.CreatePlainerType();
			cloned.Term_8_EL9011 = Term_8_EL9011.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_1_EK1200_B38DC9A8 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_1_EK1200_B38DC9A8 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_1_EK1200_B38DC9A8 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_1_EK1200_B38DC9A8(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_2_EL6002 = new EL6002_CD897635(this, "Term 2 (EL6002)", "Term_2_EL6002");
			_Term_2_EL6002.AttributeName = "Term 2 (EL6002)";
			_Term_2_EL6002.AttributePreviousPort = "Term 1 (EK1200) : B";
			_Term_2_EL6002.AttributeSyncUnit = "default";
			_Term_3_EL1809 = new EL1809_32157CFD(this, "Term 3 (EL1809)", "Term_3_EL1809");
			_Term_3_EL1809.AttributeName = "Term 3 (EL1809)";
			_Term_3_EL1809.AttributePreviousPort = "Term 2 (EL6002) : B";
			_Term_3_EL1809.AttributeSyncUnit = "default";
			_Term_4_EL2809 = new EL2809_2B6483BD(this, "Term 4 (EL2809)", "Term_4_EL2809");
			_Term_4_EL2809.AttributeName = "Term 4 (EL2809)";
			_Term_4_EL2809.AttributePreviousPort = "Term 3 (EL1809) : B";
			_Term_4_EL2809.AttributeSyncUnit = "default";
			_Term_5_EL4004 = new EL4004_E203F875(this, "Term 5 (EL4004)", "Term_5_EL4004");
			_Term_5_EL4004.AttributeName = "Term 5 (EL4004)";
			_Term_5_EL4004.AttributePreviousPort = "Term 4 (EL2809) : B";
			_Term_5_EL4004.AttributeSyncUnit = "default";
			_Term_6_EL2809 = new EL2809_2B6483BD(this, "Term 6 (EL2809)", "Term_6_EL2809");
			_Term_6_EL2809.AttributeName = "Term 6 (EL2809)";
			_Term_6_EL2809.AttributePreviousPort = "Term 5 (EL4004) : B";
			_Term_6_EL2809.AttributeSyncUnit = "default";
			_Term_7_EL6001 = new EL6001_0DE01E7E(this, "Term 7 (EL6001)", "Term_7_EL6001");
			_Term_7_EL6001.AttributeName = "Term 7 (EL6001)";
			_Term_7_EL6001.AttributePreviousPort = "Term 6 (EL2809) : B";
			_Term_7_EL6001.AttributeSyncUnit = "default";
			_Term_8_EL9011 = new EL9011_D65D3D32(this, "Term 8 (EL9011)", "Term_8_EL9011");
			_Term_8_EL9011.AttributeName = "Term 8 (EL9011)";
			_Term_8_EL9011.AttributePreviousPort = "Term 7 (EL6001) : B";
			_Term_8_EL9011.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1200-1388-0000";
			AttributeId = "Term_2_EL6002EL6002_CD897635118Term_3_EL1809EL1809_32157CFD20Term_4_EL2809EL2809_2B6483BD19Term_5_EL4004EL4004_E203F87511Term_6_EL2809EL2809_2B6483BD19Term_7_EL6001EL6001_0DE01E7E61Term_8_EL9011EL9011_D65D3D320";
			AttributeCRC = "3012413864";
			AttributeSize = "248";
			AttributeName = "Term 1 (EK1200)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_1_EK1200_B38DC9A8(): base ()
		{
			PexPreConstructorParameterless();
			_Term_2_EL6002 = new EL6002_CD897635();
			_Term_2_EL6002.AttributeName = "Term 2 (EL6002)";
			_Term_2_EL6002.AttributePreviousPort = "Term 1 (EK1200) : B";
			_Term_2_EL6002.AttributeSyncUnit = "default";
			_Term_3_EL1809 = new EL1809_32157CFD();
			_Term_3_EL1809.AttributeName = "Term 3 (EL1809)";
			_Term_3_EL1809.AttributePreviousPort = "Term 2 (EL6002) : B";
			_Term_3_EL1809.AttributeSyncUnit = "default";
			_Term_4_EL2809 = new EL2809_2B6483BD();
			_Term_4_EL2809.AttributeName = "Term 4 (EL2809)";
			_Term_4_EL2809.AttributePreviousPort = "Term 3 (EL1809) : B";
			_Term_4_EL2809.AttributeSyncUnit = "default";
			_Term_5_EL4004 = new EL4004_E203F875();
			_Term_5_EL4004.AttributeName = "Term 5 (EL4004)";
			_Term_5_EL4004.AttributePreviousPort = "Term 4 (EL2809) : B";
			_Term_5_EL4004.AttributeSyncUnit = "default";
			_Term_6_EL2809 = new EL2809_2B6483BD();
			_Term_6_EL2809.AttributeName = "Term 6 (EL2809)";
			_Term_6_EL2809.AttributePreviousPort = "Term 5 (EL4004) : B";
			_Term_6_EL2809.AttributeSyncUnit = "default";
			_Term_7_EL6001 = new EL6001_0DE01E7E();
			_Term_7_EL6001.AttributeName = "Term 7 (EL6001)";
			_Term_7_EL6001.AttributePreviousPort = "Term 6 (EL2809) : B";
			_Term_7_EL6001.AttributeSyncUnit = "default";
			_Term_8_EL9011 = new EL9011_D65D3D32();
			_Term_8_EL9011.AttributeName = "Term 8 (EL9011)";
			_Term_8_EL9011.AttributePreviousPort = "Term 7 (EL6001) : B";
			_Term_8_EL9011.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1200-1388-0000";
			AttributeId = "Term_2_EL6002EL6002_CD897635118Term_3_EL1809EL1809_32157CFD20Term_4_EL2809EL2809_2B6483BD19Term_5_EL4004EL4004_E203F87511Term_6_EL2809EL2809_2B6483BD19Term_7_EL6001EL6001_0DE01E7E61Term_8_EL9011EL9011_D65D3D320";
			AttributeCRC = "3012413864";
			AttributeSize = "248";
			AttributeName = "Term 1 (EK1200)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_1_EK1200_B38DC9A8
	{
		public void CopyPlainToCyclic(Plc1.Term_1_EK1200_B38DC9A8 target)
		{
			base.CopyPlainToCyclic(target);
			Term_2_EL6002.CopyPlainToCyclic(target.Term_2_EL6002);
			Term_3_EL1809.CopyPlainToCyclic(target.Term_3_EL1809);
			Term_4_EL2809.CopyPlainToCyclic(target.Term_4_EL2809);
			Term_5_EL4004.CopyPlainToCyclic(target.Term_5_EL4004);
			Term_6_EL2809.CopyPlainToCyclic(target.Term_6_EL2809);
			Term_7_EL6001.CopyPlainToCyclic(target.Term_7_EL6001);
			Term_8_EL9011.CopyPlainToCyclic(target.Term_8_EL9011);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_1_EK1200_B38DC9A8 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_1_EK1200_B38DC9A8)target);
		}

		public void CopyPlainToShadow(Plc1.Term_1_EK1200_B38DC9A8 target)
		{
			base.CopyPlainToShadow(target);
			Term_2_EL6002.CopyPlainToShadow(target.Term_2_EL6002);
			Term_3_EL1809.CopyPlainToShadow(target.Term_3_EL1809);
			Term_4_EL2809.CopyPlainToShadow(target.Term_4_EL2809);
			Term_5_EL4004.CopyPlainToShadow(target.Term_5_EL4004);
			Term_6_EL2809.CopyPlainToShadow(target.Term_6_EL2809);
			Term_7_EL6001.CopyPlainToShadow(target.Term_7_EL6001);
			Term_8_EL9011.CopyPlainToShadow(target.Term_8_EL9011);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_1_EK1200_B38DC9A8 target)
		{
			this.CopyPlainToShadow((Plc1.Term_1_EK1200_B38DC9A8)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_1_EK1200_B38DC9A8 source)
		{
			base.CopyCyclicToPlain(source);
			Term_2_EL6002.CopyCyclicToPlain(source.Term_2_EL6002);
			Term_3_EL1809.CopyCyclicToPlain(source.Term_3_EL1809);
			Term_4_EL2809.CopyCyclicToPlain(source.Term_4_EL2809);
			Term_5_EL4004.CopyCyclicToPlain(source.Term_5_EL4004);
			Term_6_EL2809.CopyCyclicToPlain(source.Term_6_EL2809);
			Term_7_EL6001.CopyCyclicToPlain(source.Term_7_EL6001);
			Term_8_EL9011.CopyCyclicToPlain(source.Term_8_EL9011);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_1_EK1200_B38DC9A8 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_1_EK1200_B38DC9A8)source);
		}

		public void CopyShadowToPlain(Plc1.Term_1_EK1200_B38DC9A8 source)
		{
			base.CopyShadowToPlain(source);
			Term_2_EL6002.CopyShadowToPlain(source.Term_2_EL6002);
			Term_3_EL1809.CopyShadowToPlain(source.Term_3_EL1809);
			Term_4_EL2809.CopyShadowToPlain(source.Term_4_EL2809);
			Term_5_EL4004.CopyShadowToPlain(source.Term_5_EL4004);
			Term_6_EL2809.CopyShadowToPlain(source.Term_6_EL2809);
			Term_7_EL6001.CopyShadowToPlain(source.Term_7_EL6001);
			Term_8_EL9011.CopyShadowToPlain(source.Term_8_EL9011);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_1_EK1200_B38DC9A8 source)
		{
			this.CopyShadowToPlain((Plc1.Term_1_EK1200_B38DC9A8)source);
		}
	}
}