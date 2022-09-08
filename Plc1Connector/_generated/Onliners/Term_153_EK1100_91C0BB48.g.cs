using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_154_EK1122Term_154_EK1122_E57516AE40Term_155_EL2008EL2008_E2806B9511Term_156_EL2008EL2008_E2806B9511\" } {attribute addProperty CRC \"2445327176\" } {attribute addProperty Size \"62\" } {attribute addProperty Name \"Term 153 (EK1100)\" }", "Term_153_EK1100_91C0BB48", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_153_EK1100_91C0BB48 : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_153_EK1100_91C0BB48, IShadowTerm_153_EK1100_91C0BB48, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_154_EK1122_E57516AE _Term_154_EK1122;
		public Term_154_EK1122_E57516AE Term_154_EK1122
		{
			get
			{
				return _Term_154_EK1122;
			}
		}

		ITerm_154_EK1122_E57516AE ITerm_153_EK1100_91C0BB48.Term_154_EK1122
		{
			get
			{
				return Term_154_EK1122;
			}
		}

		IShadowTerm_154_EK1122_E57516AE IShadowTerm_153_EK1100_91C0BB48.Term_154_EK1122
		{
			get
			{
				return Term_154_EK1122;
			}
		}

		EL2008_E2806B95 _Term_155_EL2008;
		public EL2008_E2806B95 Term_155_EL2008
		{
			get
			{
				return _Term_155_EL2008;
			}
		}

		IEL2008_E2806B95 ITerm_153_EK1100_91C0BB48.Term_155_EL2008
		{
			get
			{
				return Term_155_EL2008;
			}
		}

		IShadowEL2008_E2806B95 IShadowTerm_153_EK1100_91C0BB48.Term_155_EL2008
		{
			get
			{
				return Term_155_EL2008;
			}
		}

		EL2008_E2806B95 _Term_156_EL2008;
		public EL2008_E2806B95 Term_156_EL2008
		{
			get
			{
				return _Term_156_EL2008;
			}
		}

		IEL2008_E2806B95 ITerm_153_EK1100_91C0BB48.Term_156_EL2008
		{
			get
			{
				return Term_156_EL2008;
			}
		}

		IShadowEL2008_E2806B95 IShadowTerm_153_EK1100_91C0BB48.Term_156_EL2008
		{
			get
			{
				return Term_156_EL2008;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_154_EK1122.LazyOnlineToShadow();
			Term_155_EL2008.LazyOnlineToShadow();
			Term_156_EL2008.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_154_EK1122.LazyShadowToOnline();
			Term_155_EL2008.LazyShadowToOnline();
			Term_156_EL2008.LazyShadowToOnline();
		}

		public new PlainTerm_153_EK1100_91C0BB48 CreatePlainerType()
		{
			var cloned = new PlainTerm_153_EK1100_91C0BB48();
			base.CreatePlainerType(cloned);
			cloned.Term_154_EK1122 = Term_154_EK1122.CreatePlainerType();
			cloned.Term_155_EL2008 = Term_155_EL2008.CreatePlainerType();
			cloned.Term_156_EL2008 = Term_156_EL2008.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_153_EK1100_91C0BB48 CreatePlainerType(PlainTerm_153_EK1100_91C0BB48 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_154_EK1122 = Term_154_EK1122.CreatePlainerType();
			cloned.Term_155_EL2008 = Term_155_EL2008.CreatePlainerType();
			cloned.Term_156_EL2008 = Term_156_EL2008.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_153_EK1100_91C0BB48 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_153_EK1100_91C0BB48 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_153_EK1100_91C0BB48 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_153_EK1100_91C0BB48(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_154_EK1122 = new Term_154_EK1122_E57516AE(this, "Term 154 (EK1122)", "Term_154_EK1122");
			_Term_154_EK1122.AttributeName = "Term 154 (EK1122)";
			_Term_154_EK1122.AttributePreviousPort = "Term 153 (EK1100) : B";
			_Term_154_EK1122.AttributeSyncUnit = "default";
			_Term_155_EL2008 = new EL2008_E2806B95(this, "Term 155 (EL2008)", "Term_155_EL2008");
			_Term_155_EL2008.AttributeName = "Term 155 (EL2008)";
			_Term_155_EL2008.AttributePreviousPort = "Term 154 (EK1122) : C";
			_Term_155_EL2008.AttributeSyncUnit = "default";
			_Term_156_EL2008 = new EL2008_E2806B95(this, "Term 156 (EL2008)", "Term_156_EL2008");
			_Term_156_EL2008.AttributeName = "Term 156 (EL2008)";
			_Term_156_EL2008.AttributePreviousPort = "Term 155 (EL2008) : B";
			_Term_156_EL2008.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_154_EK1122Term_154_EK1122_E57516AE40Term_155_EL2008EL2008_E2806B9511Term_156_EL2008EL2008_E2806B9511";
			AttributeCRC = "2445327176";
			AttributeSize = "62";
			AttributeName = "Term 153 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_153_EK1100_91C0BB48(): base ()
		{
			PexPreConstructorParameterless();
			_Term_154_EK1122 = new Term_154_EK1122_E57516AE();
			_Term_154_EK1122.AttributeName = "Term 154 (EK1122)";
			_Term_154_EK1122.AttributePreviousPort = "Term 153 (EK1100) : B";
			_Term_154_EK1122.AttributeSyncUnit = "default";
			_Term_155_EL2008 = new EL2008_E2806B95();
			_Term_155_EL2008.AttributeName = "Term 155 (EL2008)";
			_Term_155_EL2008.AttributePreviousPort = "Term 154 (EK1122) : C";
			_Term_155_EL2008.AttributeSyncUnit = "default";
			_Term_156_EL2008 = new EL2008_E2806B95();
			_Term_156_EL2008.AttributeName = "Term 156 (EL2008)";
			_Term_156_EL2008.AttributePreviousPort = "Term 155 (EL2008) : B";
			_Term_156_EL2008.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_154_EK1122Term_154_EK1122_E57516AE40Term_155_EL2008EL2008_E2806B9511Term_156_EL2008EL2008_E2806B9511";
			AttributeCRC = "2445327176";
			AttributeSize = "62";
			AttributeName = "Term 153 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_153_EK1100_91C0BB48
	{
		public void CopyPlainToCyclic(Plc1.Term_153_EK1100_91C0BB48 target)
		{
			base.CopyPlainToCyclic(target);
			Term_154_EK1122.CopyPlainToCyclic(target.Term_154_EK1122);
			Term_155_EL2008.CopyPlainToCyclic(target.Term_155_EL2008);
			Term_156_EL2008.CopyPlainToCyclic(target.Term_156_EL2008);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_153_EK1100_91C0BB48 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_153_EK1100_91C0BB48)target);
		}

		public void CopyPlainToShadow(Plc1.Term_153_EK1100_91C0BB48 target)
		{
			base.CopyPlainToShadow(target);
			Term_154_EK1122.CopyPlainToShadow(target.Term_154_EK1122);
			Term_155_EL2008.CopyPlainToShadow(target.Term_155_EL2008);
			Term_156_EL2008.CopyPlainToShadow(target.Term_156_EL2008);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_153_EK1100_91C0BB48 target)
		{
			this.CopyPlainToShadow((Plc1.Term_153_EK1100_91C0BB48)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_153_EK1100_91C0BB48 source)
		{
			base.CopyCyclicToPlain(source);
			Term_154_EK1122.CopyCyclicToPlain(source.Term_154_EK1122);
			Term_155_EL2008.CopyCyclicToPlain(source.Term_155_EL2008);
			Term_156_EL2008.CopyCyclicToPlain(source.Term_156_EL2008);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_153_EK1100_91C0BB48 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_153_EK1100_91C0BB48)source);
		}

		public void CopyShadowToPlain(Plc1.Term_153_EK1100_91C0BB48 source)
		{
			base.CopyShadowToPlain(source);
			Term_154_EK1122.CopyShadowToPlain(source.Term_154_EK1122);
			Term_155_EL2008.CopyShadowToPlain(source.Term_155_EL2008);
			Term_156_EL2008.CopyShadowToPlain(source.Term_156_EL2008);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_153_EK1100_91C0BB48 source)
		{
			this.CopyShadowToPlain((Plc1.Term_153_EK1100_91C0BB48)source);
		}
	}
}