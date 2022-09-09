using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_24_EK1122Term_24_EK1122_39E7B5CB235Term_31_EL3773EL3773_F128CC82184Term_32_EL2258EL2258_E3B260FA508Term_33_EL3164EL3164_B71BFF4244Term_40_EK1110EK1110_1FC0878B2\" } {attribute addProperty CRC \"3238619252\" } {attribute addProperty Size \"973\" } {attribute addProperty Name \"Term 23 (EK1100)\" }", "Term_23_EK1100_C1096874", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_23_EK1100_C1096874 : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_23_EK1100_C1096874, IShadowTerm_23_EK1100_C1096874, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_24_EK1122_39E7B5CB _Term_24_EK1122;
		public Term_24_EK1122_39E7B5CB Term_24_EK1122
		{
			get
			{
				return _Term_24_EK1122;
			}
		}

		ITerm_24_EK1122_39E7B5CB ITerm_23_EK1100_C1096874.Term_24_EK1122
		{
			get
			{
				return Term_24_EK1122;
			}
		}

		IShadowTerm_24_EK1122_39E7B5CB IShadowTerm_23_EK1100_C1096874.Term_24_EK1122
		{
			get
			{
				return Term_24_EK1122;
			}
		}

		EL3773_F128CC82 _Term_31_EL3773;
		public EL3773_F128CC82 Term_31_EL3773
		{
			get
			{
				return _Term_31_EL3773;
			}
		}

		IEL3773_F128CC82 ITerm_23_EK1100_C1096874.Term_31_EL3773
		{
			get
			{
				return Term_31_EL3773;
			}
		}

		IShadowEL3773_F128CC82 IShadowTerm_23_EK1100_C1096874.Term_31_EL3773
		{
			get
			{
				return Term_31_EL3773;
			}
		}

		EL2258_E3B260FA _Term_32_EL2258;
		public EL2258_E3B260FA Term_32_EL2258
		{
			get
			{
				return _Term_32_EL2258;
			}
		}

		IEL2258_E3B260FA ITerm_23_EK1100_C1096874.Term_32_EL2258
		{
			get
			{
				return Term_32_EL2258;
			}
		}

		IShadowEL2258_E3B260FA IShadowTerm_23_EK1100_C1096874.Term_32_EL2258
		{
			get
			{
				return Term_32_EL2258;
			}
		}

		EL3164_B71BFF42 _Term_33_EL3164;
		public EL3164_B71BFF42 Term_33_EL3164
		{
			get
			{
				return _Term_33_EL3164;
			}
		}

		IEL3164_B71BFF42 ITerm_23_EK1100_C1096874.Term_33_EL3164
		{
			get
			{
				return Term_33_EL3164;
			}
		}

		IShadowEL3164_B71BFF42 IShadowTerm_23_EK1100_C1096874.Term_33_EL3164
		{
			get
			{
				return Term_33_EL3164;
			}
		}

		EK1110_1FC0878B _Term_40_EK1110;
		public EK1110_1FC0878B Term_40_EK1110
		{
			get
			{
				return _Term_40_EK1110;
			}
		}

		IEK1110_1FC0878B ITerm_23_EK1100_C1096874.Term_40_EK1110
		{
			get
			{
				return Term_40_EK1110;
			}
		}

		IShadowEK1110_1FC0878B IShadowTerm_23_EK1100_C1096874.Term_40_EK1110
		{
			get
			{
				return Term_40_EK1110;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_24_EK1122.LazyOnlineToShadow();
			Term_31_EL3773.LazyOnlineToShadow();
			Term_32_EL2258.LazyOnlineToShadow();
			Term_33_EL3164.LazyOnlineToShadow();
			Term_40_EK1110.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_24_EK1122.LazyShadowToOnline();
			Term_31_EL3773.LazyShadowToOnline();
			Term_32_EL2258.LazyShadowToOnline();
			Term_33_EL3164.LazyShadowToOnline();
			Term_40_EK1110.LazyShadowToOnline();
		}

		public new PlainTerm_23_EK1100_C1096874 CreatePlainerType()
		{
			var cloned = new PlainTerm_23_EK1100_C1096874();
			base.CreatePlainerType(cloned);
			cloned.Term_24_EK1122 = Term_24_EK1122.CreatePlainerType();
			cloned.Term_31_EL3773 = Term_31_EL3773.CreatePlainerType();
			cloned.Term_32_EL2258 = Term_32_EL2258.CreatePlainerType();
			cloned.Term_33_EL3164 = Term_33_EL3164.CreatePlainerType();
			cloned.Term_40_EK1110 = Term_40_EK1110.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_23_EK1100_C1096874 CreatePlainerType(PlainTerm_23_EK1100_C1096874 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_24_EK1122 = Term_24_EK1122.CreatePlainerType();
			cloned.Term_31_EL3773 = Term_31_EL3773.CreatePlainerType();
			cloned.Term_32_EL2258 = Term_32_EL2258.CreatePlainerType();
			cloned.Term_33_EL3164 = Term_33_EL3164.CreatePlainerType();
			cloned.Term_40_EK1110 = Term_40_EK1110.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_23_EK1100_C1096874 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_23_EK1100_C1096874 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_23_EK1100_C1096874 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_23_EK1100_C1096874(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_24_EK1122 = new Term_24_EK1122_39E7B5CB(this, "Term 24 (EK1122)", "Term_24_EK1122");
			_Term_24_EK1122.AttributeName = "Term 24 (EK1122)";
			_Term_24_EK1122.AttributePreviousPort = "Term 23 (EK1100) : B";
			_Term_24_EK1122.AttributeSyncUnit = "default";
			_Term_31_EL3773 = new EL3773_F128CC82(this, "Term 31 (EL3773)", "Term_31_EL3773");
			_Term_31_EL3773.AttributeName = "Term 31 (EL3773)";
			_Term_31_EL3773.AttributePreviousPort = "Term 24 (EK1122) : C";
			_Term_31_EL3773.AttributeSyncUnit = "Row_2";
			_Term_32_EL2258 = new EL2258_E3B260FA(this, "Term 32 (EL2258)", "Term_32_EL2258");
			_Term_32_EL2258.AttributeName = "Term 32 (EL2258)";
			_Term_32_EL2258.AttributePreviousPort = "Term 31 (EL3773) : B";
			_Term_32_EL2258.AttributeSyncUnit = "Row_2";
			_Term_33_EL3164 = new EL3164_B71BFF42(this, "Term 33 (EL3164)", "Term_33_EL3164");
			_Term_33_EL3164.AttributeName = "Term 33 (EL3164)";
			_Term_33_EL3164.AttributePreviousPort = "Term 32 (EL2258) : B";
			_Term_33_EL3164.AttributeSyncUnit = "Row_2";
			_Term_40_EK1110 = new EK1110_1FC0878B(this, "Term 40 (EK1110)", "Term_40_EK1110");
			_Term_40_EK1110.AttributeName = "Term 40 (EK1110)";
			_Term_40_EK1110.AttributePreviousPort = "Term 33 (EL3164) : B";
			_Term_40_EK1110.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_24_EK1122Term_24_EK1122_39E7B5CB235Term_31_EL3773EL3773_F128CC82184Term_32_EL2258EL2258_E3B260FA508Term_33_EL3164EL3164_B71BFF4244Term_40_EK1110EK1110_1FC0878B2";
			AttributeCRC = "3238619252";
			AttributeSize = "973";
			AttributeName = "Term 23 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_23_EK1100_C1096874(): base ()
		{
			PexPreConstructorParameterless();
			_Term_24_EK1122 = new Term_24_EK1122_39E7B5CB();
			_Term_24_EK1122.AttributeName = "Term 24 (EK1122)";
			_Term_24_EK1122.AttributePreviousPort = "Term 23 (EK1100) : B";
			_Term_24_EK1122.AttributeSyncUnit = "default";
			_Term_31_EL3773 = new EL3773_F128CC82();
			_Term_31_EL3773.AttributeName = "Term 31 (EL3773)";
			_Term_31_EL3773.AttributePreviousPort = "Term 24 (EK1122) : C";
			_Term_31_EL3773.AttributeSyncUnit = "Row_2";
			_Term_32_EL2258 = new EL2258_E3B260FA();
			_Term_32_EL2258.AttributeName = "Term 32 (EL2258)";
			_Term_32_EL2258.AttributePreviousPort = "Term 31 (EL3773) : B";
			_Term_32_EL2258.AttributeSyncUnit = "Row_2";
			_Term_33_EL3164 = new EL3164_B71BFF42();
			_Term_33_EL3164.AttributeName = "Term 33 (EL3164)";
			_Term_33_EL3164.AttributePreviousPort = "Term 32 (EL2258) : B";
			_Term_33_EL3164.AttributeSyncUnit = "Row_2";
			_Term_40_EK1110 = new EK1110_1FC0878B();
			_Term_40_EK1110.AttributeName = "Term 40 (EK1110)";
			_Term_40_EK1110.AttributePreviousPort = "Term 33 (EL3164) : B";
			_Term_40_EK1110.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_24_EK1122Term_24_EK1122_39E7B5CB235Term_31_EL3773EL3773_F128CC82184Term_32_EL2258EL2258_E3B260FA508Term_33_EL3164EL3164_B71BFF4244Term_40_EK1110EK1110_1FC0878B2";
			AttributeCRC = "3238619252";
			AttributeSize = "973";
			AttributeName = "Term 23 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_23_EK1100_C1096874
	{
		public void CopyPlainToCyclic(Plc1.Term_23_EK1100_C1096874 target)
		{
			base.CopyPlainToCyclic(target);
			Term_24_EK1122.CopyPlainToCyclic(target.Term_24_EK1122);
			Term_31_EL3773.CopyPlainToCyclic(target.Term_31_EL3773);
			Term_32_EL2258.CopyPlainToCyclic(target.Term_32_EL2258);
			Term_33_EL3164.CopyPlainToCyclic(target.Term_33_EL3164);
			Term_40_EK1110.CopyPlainToCyclic(target.Term_40_EK1110);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_23_EK1100_C1096874 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_23_EK1100_C1096874)target);
		}

		public void CopyPlainToShadow(Plc1.Term_23_EK1100_C1096874 target)
		{
			base.CopyPlainToShadow(target);
			Term_24_EK1122.CopyPlainToShadow(target.Term_24_EK1122);
			Term_31_EL3773.CopyPlainToShadow(target.Term_31_EL3773);
			Term_32_EL2258.CopyPlainToShadow(target.Term_32_EL2258);
			Term_33_EL3164.CopyPlainToShadow(target.Term_33_EL3164);
			Term_40_EK1110.CopyPlainToShadow(target.Term_40_EK1110);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_23_EK1100_C1096874 target)
		{
			this.CopyPlainToShadow((Plc1.Term_23_EK1100_C1096874)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_23_EK1100_C1096874 source)
		{
			base.CopyCyclicToPlain(source);
			Term_24_EK1122.CopyCyclicToPlain(source.Term_24_EK1122);
			Term_31_EL3773.CopyCyclicToPlain(source.Term_31_EL3773);
			Term_32_EL2258.CopyCyclicToPlain(source.Term_32_EL2258);
			Term_33_EL3164.CopyCyclicToPlain(source.Term_33_EL3164);
			Term_40_EK1110.CopyCyclicToPlain(source.Term_40_EK1110);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_23_EK1100_C1096874 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_23_EK1100_C1096874)source);
		}

		public void CopyShadowToPlain(Plc1.Term_23_EK1100_C1096874 source)
		{
			base.CopyShadowToPlain(source);
			Term_24_EK1122.CopyShadowToPlain(source.Term_24_EK1122);
			Term_31_EL3773.CopyShadowToPlain(source.Term_31_EL3773);
			Term_32_EL2258.CopyShadowToPlain(source.Term_32_EL2258);
			Term_33_EL3164.CopyShadowToPlain(source.Term_33_EL3164);
			Term_40_EK1110.CopyShadowToPlain(source.Term_40_EK1110);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_23_EK1100_C1096874 source)
		{
			this.CopyShadowToPlain((Plc1.Term_23_EK1100_C1096874)source);
		}
	}
}