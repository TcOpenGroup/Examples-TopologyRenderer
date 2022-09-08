using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_300_EL1809EL1809_32157CFD20Term_304_EL2008EL2008_E2806B9511Term_305_EL2008EL2008_E2806B9511\" } {attribute addProperty CRC \"3756172702\" } {attribute addProperty Size \"42\" } {attribute addProperty Name \"Term 294 (EK1100)\" }", "Term_294_EK1100_DFE2A59E", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_294_EK1100_DFE2A59E : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_294_EK1100_DFE2A59E, IShadowTerm_294_EK1100_DFE2A59E, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		EL1809_32157CFD _Term_300_EL1809;
		public EL1809_32157CFD Term_300_EL1809
		{
			get
			{
				return _Term_300_EL1809;
			}
		}

		IEL1809_32157CFD ITerm_294_EK1100_DFE2A59E.Term_300_EL1809
		{
			get
			{
				return Term_300_EL1809;
			}
		}

		IShadowEL1809_32157CFD IShadowTerm_294_EK1100_DFE2A59E.Term_300_EL1809
		{
			get
			{
				return Term_300_EL1809;
			}
		}

		EL2008_E2806B95 _Term_304_EL2008;
		public EL2008_E2806B95 Term_304_EL2008
		{
			get
			{
				return _Term_304_EL2008;
			}
		}

		IEL2008_E2806B95 ITerm_294_EK1100_DFE2A59E.Term_304_EL2008
		{
			get
			{
				return Term_304_EL2008;
			}
		}

		IShadowEL2008_E2806B95 IShadowTerm_294_EK1100_DFE2A59E.Term_304_EL2008
		{
			get
			{
				return Term_304_EL2008;
			}
		}

		EL2008_E2806B95 _Term_305_EL2008;
		public EL2008_E2806B95 Term_305_EL2008
		{
			get
			{
				return _Term_305_EL2008;
			}
		}

		IEL2008_E2806B95 ITerm_294_EK1100_DFE2A59E.Term_305_EL2008
		{
			get
			{
				return Term_305_EL2008;
			}
		}

		IShadowEL2008_E2806B95 IShadowTerm_294_EK1100_DFE2A59E.Term_305_EL2008
		{
			get
			{
				return Term_305_EL2008;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_300_EL1809.LazyOnlineToShadow();
			Term_304_EL2008.LazyOnlineToShadow();
			Term_305_EL2008.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_300_EL1809.LazyShadowToOnline();
			Term_304_EL2008.LazyShadowToOnline();
			Term_305_EL2008.LazyShadowToOnline();
		}

		public new PlainTerm_294_EK1100_DFE2A59E CreatePlainerType()
		{
			var cloned = new PlainTerm_294_EK1100_DFE2A59E();
			base.CreatePlainerType(cloned);
			cloned.Term_300_EL1809 = Term_300_EL1809.CreatePlainerType();
			cloned.Term_304_EL2008 = Term_304_EL2008.CreatePlainerType();
			cloned.Term_305_EL2008 = Term_305_EL2008.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_294_EK1100_DFE2A59E CreatePlainerType(PlainTerm_294_EK1100_DFE2A59E cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_300_EL1809 = Term_300_EL1809.CreatePlainerType();
			cloned.Term_304_EL2008 = Term_304_EL2008.CreatePlainerType();
			cloned.Term_305_EL2008 = Term_305_EL2008.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_294_EK1100_DFE2A59E source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_294_EK1100_DFE2A59E source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_294_EK1100_DFE2A59E source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_294_EK1100_DFE2A59E(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_300_EL1809 = new EL1809_32157CFD(this, "Term 300 (EL1809)", "Term_300_EL1809");
			_Term_300_EL1809.AttributeName = "Term 300 (EL1809)";
			_Term_300_EL1809.AttributePreviousPort = "Term 294 (EK1100) : B";
			_Term_300_EL1809.AttributeSyncUnit = "default";
			_Term_304_EL2008 = new EL2008_E2806B95(this, "Term 304 (EL2008)", "Term_304_EL2008");
			_Term_304_EL2008.AttributeName = "Term 304 (EL2008)";
			_Term_304_EL2008.AttributePreviousPort = "Term 300 (EL1809) : B";
			_Term_304_EL2008.AttributeSyncUnit = "default";
			_Term_305_EL2008 = new EL2008_E2806B95(this, "Term 305 (EL2008)", "Term_305_EL2008");
			_Term_305_EL2008.AttributeName = "Term 305 (EL2008)";
			_Term_305_EL2008.AttributePreviousPort = "Term 304 (EL2008) : B";
			_Term_305_EL2008.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_300_EL1809EL1809_32157CFD20Term_304_EL2008EL2008_E2806B9511Term_305_EL2008EL2008_E2806B9511";
			AttributeCRC = "3756172702";
			AttributeSize = "42";
			AttributeName = "Term 294 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_294_EK1100_DFE2A59E(): base ()
		{
			PexPreConstructorParameterless();
			_Term_300_EL1809 = new EL1809_32157CFD();
			_Term_300_EL1809.AttributeName = "Term 300 (EL1809)";
			_Term_300_EL1809.AttributePreviousPort = "Term 294 (EK1100) : B";
			_Term_300_EL1809.AttributeSyncUnit = "default";
			_Term_304_EL2008 = new EL2008_E2806B95();
			_Term_304_EL2008.AttributeName = "Term 304 (EL2008)";
			_Term_304_EL2008.AttributePreviousPort = "Term 300 (EL1809) : B";
			_Term_304_EL2008.AttributeSyncUnit = "default";
			_Term_305_EL2008 = new EL2008_E2806B95();
			_Term_305_EL2008.AttributeName = "Term 305 (EL2008)";
			_Term_305_EL2008.AttributePreviousPort = "Term 304 (EL2008) : B";
			_Term_305_EL2008.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_300_EL1809EL1809_32157CFD20Term_304_EL2008EL2008_E2806B9511Term_305_EL2008EL2008_E2806B9511";
			AttributeCRC = "3756172702";
			AttributeSize = "42";
			AttributeName = "Term 294 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_294_EK1100_DFE2A59E
	{
		public void CopyPlainToCyclic(Plc1.Term_294_EK1100_DFE2A59E target)
		{
			base.CopyPlainToCyclic(target);
			Term_300_EL1809.CopyPlainToCyclic(target.Term_300_EL1809);
			Term_304_EL2008.CopyPlainToCyclic(target.Term_304_EL2008);
			Term_305_EL2008.CopyPlainToCyclic(target.Term_305_EL2008);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_294_EK1100_DFE2A59E target)
		{
			this.CopyPlainToCyclic((Plc1.Term_294_EK1100_DFE2A59E)target);
		}

		public void CopyPlainToShadow(Plc1.Term_294_EK1100_DFE2A59E target)
		{
			base.CopyPlainToShadow(target);
			Term_300_EL1809.CopyPlainToShadow(target.Term_300_EL1809);
			Term_304_EL2008.CopyPlainToShadow(target.Term_304_EL2008);
			Term_305_EL2008.CopyPlainToShadow(target.Term_305_EL2008);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_294_EK1100_DFE2A59E target)
		{
			this.CopyPlainToShadow((Plc1.Term_294_EK1100_DFE2A59E)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_294_EK1100_DFE2A59E source)
		{
			base.CopyCyclicToPlain(source);
			Term_300_EL1809.CopyCyclicToPlain(source.Term_300_EL1809);
			Term_304_EL2008.CopyCyclicToPlain(source.Term_304_EL2008);
			Term_305_EL2008.CopyCyclicToPlain(source.Term_305_EL2008);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_294_EK1100_DFE2A59E source)
		{
			this.CopyCyclicToPlain((Plc1.Term_294_EK1100_DFE2A59E)source);
		}

		public void CopyShadowToPlain(Plc1.Term_294_EK1100_DFE2A59E source)
		{
			base.CopyShadowToPlain(source);
			Term_300_EL1809.CopyShadowToPlain(source.Term_300_EL1809);
			Term_304_EL2008.CopyShadowToPlain(source.Term_304_EL2008);
			Term_305_EL2008.CopyShadowToPlain(source.Term_305_EL2008);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_294_EK1100_DFE2A59E source)
		{
			this.CopyShadowToPlain((Plc1.Term_294_EK1100_DFE2A59E)source);
		}
	}
}