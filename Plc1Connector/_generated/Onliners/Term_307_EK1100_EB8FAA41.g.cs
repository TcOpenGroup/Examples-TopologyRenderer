using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_330_EK1122Term_330_EK1122_0EDE60FE40Term_335_EL2008EL2008_E2806B9511Term_336_EL2008EL2008_E2806B9511\" } {attribute addProperty CRC \"3952060993\" } {attribute addProperty Size \"62\" } {attribute addProperty Name \"Term 307 (EK1100)\" }", "Term_307_EK1100_EB8FAA41", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_307_EK1100_EB8FAA41 : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_307_EK1100_EB8FAA41, IShadowTerm_307_EK1100_EB8FAA41, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_330_EK1122_0EDE60FE _Term_330_EK1122;
		public Term_330_EK1122_0EDE60FE Term_330_EK1122
		{
			get
			{
				return _Term_330_EK1122;
			}
		}

		ITerm_330_EK1122_0EDE60FE ITerm_307_EK1100_EB8FAA41.Term_330_EK1122
		{
			get
			{
				return Term_330_EK1122;
			}
		}

		IShadowTerm_330_EK1122_0EDE60FE IShadowTerm_307_EK1100_EB8FAA41.Term_330_EK1122
		{
			get
			{
				return Term_330_EK1122;
			}
		}

		EL2008_E2806B95 _Term_335_EL2008;
		public EL2008_E2806B95 Term_335_EL2008
		{
			get
			{
				return _Term_335_EL2008;
			}
		}

		IEL2008_E2806B95 ITerm_307_EK1100_EB8FAA41.Term_335_EL2008
		{
			get
			{
				return Term_335_EL2008;
			}
		}

		IShadowEL2008_E2806B95 IShadowTerm_307_EK1100_EB8FAA41.Term_335_EL2008
		{
			get
			{
				return Term_335_EL2008;
			}
		}

		EL2008_E2806B95 _Term_336_EL2008;
		public EL2008_E2806B95 Term_336_EL2008
		{
			get
			{
				return _Term_336_EL2008;
			}
		}

		IEL2008_E2806B95 ITerm_307_EK1100_EB8FAA41.Term_336_EL2008
		{
			get
			{
				return Term_336_EL2008;
			}
		}

		IShadowEL2008_E2806B95 IShadowTerm_307_EK1100_EB8FAA41.Term_336_EL2008
		{
			get
			{
				return Term_336_EL2008;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_330_EK1122.LazyOnlineToShadow();
			Term_335_EL2008.LazyOnlineToShadow();
			Term_336_EL2008.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_330_EK1122.LazyShadowToOnline();
			Term_335_EL2008.LazyShadowToOnline();
			Term_336_EL2008.LazyShadowToOnline();
		}

		public new PlainTerm_307_EK1100_EB8FAA41 CreatePlainerType()
		{
			var cloned = new PlainTerm_307_EK1100_EB8FAA41();
			base.CreatePlainerType(cloned);
			cloned.Term_330_EK1122 = Term_330_EK1122.CreatePlainerType();
			cloned.Term_335_EL2008 = Term_335_EL2008.CreatePlainerType();
			cloned.Term_336_EL2008 = Term_336_EL2008.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_307_EK1100_EB8FAA41 CreatePlainerType(PlainTerm_307_EK1100_EB8FAA41 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_330_EK1122 = Term_330_EK1122.CreatePlainerType();
			cloned.Term_335_EL2008 = Term_335_EL2008.CreatePlainerType();
			cloned.Term_336_EL2008 = Term_336_EL2008.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_307_EK1100_EB8FAA41 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_307_EK1100_EB8FAA41 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_307_EK1100_EB8FAA41 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_307_EK1100_EB8FAA41(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_330_EK1122 = new Term_330_EK1122_0EDE60FE(this, "Term 330 (EK1122)", "Term_330_EK1122");
			_Term_330_EK1122.AttributeName = "Term 330 (EK1122)";
			_Term_330_EK1122.AttributePreviousPort = "Term 307 (EK1100) : B";
			_Term_330_EK1122.AttributeSyncUnit = "default";
			_Term_335_EL2008 = new EL2008_E2806B95(this, "Term 335 (EL2008)", "Term_335_EL2008");
			_Term_335_EL2008.AttributeName = "Term 335 (EL2008)";
			_Term_335_EL2008.AttributePreviousPort = "Term 330 (EK1122) : C";
			_Term_335_EL2008.AttributeSyncUnit = "default";
			_Term_336_EL2008 = new EL2008_E2806B95(this, "Term 336 (EL2008)", "Term_336_EL2008");
			_Term_336_EL2008.AttributeName = "Term 336 (EL2008)";
			_Term_336_EL2008.AttributePreviousPort = "Term 335 (EL2008) : B";
			_Term_336_EL2008.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_330_EK1122Term_330_EK1122_0EDE60FE40Term_335_EL2008EL2008_E2806B9511Term_336_EL2008EL2008_E2806B9511";
			AttributeCRC = "3952060993";
			AttributeSize = "62";
			AttributeName = "Term 307 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_307_EK1100_EB8FAA41(): base ()
		{
			PexPreConstructorParameterless();
			_Term_330_EK1122 = new Term_330_EK1122_0EDE60FE();
			_Term_330_EK1122.AttributeName = "Term 330 (EK1122)";
			_Term_330_EK1122.AttributePreviousPort = "Term 307 (EK1100) : B";
			_Term_330_EK1122.AttributeSyncUnit = "default";
			_Term_335_EL2008 = new EL2008_E2806B95();
			_Term_335_EL2008.AttributeName = "Term 335 (EL2008)";
			_Term_335_EL2008.AttributePreviousPort = "Term 330 (EK1122) : C";
			_Term_335_EL2008.AttributeSyncUnit = "default";
			_Term_336_EL2008 = new EL2008_E2806B95();
			_Term_336_EL2008.AttributeName = "Term 336 (EL2008)";
			_Term_336_EL2008.AttributePreviousPort = "Term 335 (EL2008) : B";
			_Term_336_EL2008.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_330_EK1122Term_330_EK1122_0EDE60FE40Term_335_EL2008EL2008_E2806B9511Term_336_EL2008EL2008_E2806B9511";
			AttributeCRC = "3952060993";
			AttributeSize = "62";
			AttributeName = "Term 307 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_307_EK1100_EB8FAA41
	{
		public void CopyPlainToCyclic(Plc1.Term_307_EK1100_EB8FAA41 target)
		{
			base.CopyPlainToCyclic(target);
			Term_330_EK1122.CopyPlainToCyclic(target.Term_330_EK1122);
			Term_335_EL2008.CopyPlainToCyclic(target.Term_335_EL2008);
			Term_336_EL2008.CopyPlainToCyclic(target.Term_336_EL2008);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_307_EK1100_EB8FAA41 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_307_EK1100_EB8FAA41)target);
		}

		public void CopyPlainToShadow(Plc1.Term_307_EK1100_EB8FAA41 target)
		{
			base.CopyPlainToShadow(target);
			Term_330_EK1122.CopyPlainToShadow(target.Term_330_EK1122);
			Term_335_EL2008.CopyPlainToShadow(target.Term_335_EL2008);
			Term_336_EL2008.CopyPlainToShadow(target.Term_336_EL2008);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_307_EK1100_EB8FAA41 target)
		{
			this.CopyPlainToShadow((Plc1.Term_307_EK1100_EB8FAA41)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_307_EK1100_EB8FAA41 source)
		{
			base.CopyCyclicToPlain(source);
			Term_330_EK1122.CopyCyclicToPlain(source.Term_330_EK1122);
			Term_335_EL2008.CopyCyclicToPlain(source.Term_335_EL2008);
			Term_336_EL2008.CopyCyclicToPlain(source.Term_336_EL2008);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_307_EK1100_EB8FAA41 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_307_EK1100_EB8FAA41)source);
		}

		public void CopyShadowToPlain(Plc1.Term_307_EK1100_EB8FAA41 source)
		{
			base.CopyShadowToPlain(source);
			Term_330_EK1122.CopyShadowToPlain(source.Term_330_EK1122);
			Term_335_EL2008.CopyShadowToPlain(source.Term_335_EL2008);
			Term_336_EL2008.CopyShadowToPlain(source.Term_336_EL2008);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_307_EK1100_EB8FAA41 source)
		{
			this.CopyShadowToPlain((Plc1.Term_307_EK1100_EB8FAA41)source);
		}
	}
}