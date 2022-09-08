using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_188_EK1122Term_188_EK1122_78D8AA4340Term_204_EL2008EL2008_E2806B9511Term_205_EL2008EL2008_E2806B9511\" } {attribute addProperty CRC \"1686909373\" } {attribute addProperty Size \"62\" } {attribute addProperty Name \"Term 187 (EK1100)\" }", "Term_187_EK1100_648C31BD", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_187_EK1100_648C31BD : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_187_EK1100_648C31BD, IShadowTerm_187_EK1100_648C31BD, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_188_EK1122_78D8AA43 _Term_188_EK1122;
		public Term_188_EK1122_78D8AA43 Term_188_EK1122
		{
			get
			{
				return _Term_188_EK1122;
			}
		}

		ITerm_188_EK1122_78D8AA43 ITerm_187_EK1100_648C31BD.Term_188_EK1122
		{
			get
			{
				return Term_188_EK1122;
			}
		}

		IShadowTerm_188_EK1122_78D8AA43 IShadowTerm_187_EK1100_648C31BD.Term_188_EK1122
		{
			get
			{
				return Term_188_EK1122;
			}
		}

		EL2008_E2806B95 _Term_204_EL2008;
		public EL2008_E2806B95 Term_204_EL2008
		{
			get
			{
				return _Term_204_EL2008;
			}
		}

		IEL2008_E2806B95 ITerm_187_EK1100_648C31BD.Term_204_EL2008
		{
			get
			{
				return Term_204_EL2008;
			}
		}

		IShadowEL2008_E2806B95 IShadowTerm_187_EK1100_648C31BD.Term_204_EL2008
		{
			get
			{
				return Term_204_EL2008;
			}
		}

		EL2008_E2806B95 _Term_205_EL2008;
		public EL2008_E2806B95 Term_205_EL2008
		{
			get
			{
				return _Term_205_EL2008;
			}
		}

		IEL2008_E2806B95 ITerm_187_EK1100_648C31BD.Term_205_EL2008
		{
			get
			{
				return Term_205_EL2008;
			}
		}

		IShadowEL2008_E2806B95 IShadowTerm_187_EK1100_648C31BD.Term_205_EL2008
		{
			get
			{
				return Term_205_EL2008;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_188_EK1122.LazyOnlineToShadow();
			Term_204_EL2008.LazyOnlineToShadow();
			Term_205_EL2008.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_188_EK1122.LazyShadowToOnline();
			Term_204_EL2008.LazyShadowToOnline();
			Term_205_EL2008.LazyShadowToOnline();
		}

		public new PlainTerm_187_EK1100_648C31BD CreatePlainerType()
		{
			var cloned = new PlainTerm_187_EK1100_648C31BD();
			base.CreatePlainerType(cloned);
			cloned.Term_188_EK1122 = Term_188_EK1122.CreatePlainerType();
			cloned.Term_204_EL2008 = Term_204_EL2008.CreatePlainerType();
			cloned.Term_205_EL2008 = Term_205_EL2008.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_187_EK1100_648C31BD CreatePlainerType(PlainTerm_187_EK1100_648C31BD cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_188_EK1122 = Term_188_EK1122.CreatePlainerType();
			cloned.Term_204_EL2008 = Term_204_EL2008.CreatePlainerType();
			cloned.Term_205_EL2008 = Term_205_EL2008.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_187_EK1100_648C31BD source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_187_EK1100_648C31BD source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_187_EK1100_648C31BD source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_187_EK1100_648C31BD(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_188_EK1122 = new Term_188_EK1122_78D8AA43(this, "Term 188 (EK1122)", "Term_188_EK1122");
			_Term_188_EK1122.AttributeName = "Term 188 (EK1122)";
			_Term_188_EK1122.AttributePreviousPort = "Term 187 (EK1100) : B";
			_Term_188_EK1122.AttributeSyncUnit = "default";
			_Term_204_EL2008 = new EL2008_E2806B95(this, "Term 204 (EL2008)", "Term_204_EL2008");
			_Term_204_EL2008.AttributeName = "Term 204 (EL2008)";
			_Term_204_EL2008.AttributePreviousPort = "Term 188 (EK1122) : C";
			_Term_204_EL2008.AttributeSyncUnit = "default";
			_Term_205_EL2008 = new EL2008_E2806B95(this, "Term 205 (EL2008)", "Term_205_EL2008");
			_Term_205_EL2008.AttributeName = "Term 205 (EL2008)";
			_Term_205_EL2008.AttributePreviousPort = "Term 204 (EL2008) : B";
			_Term_205_EL2008.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_188_EK1122Term_188_EK1122_78D8AA4340Term_204_EL2008EL2008_E2806B9511Term_205_EL2008EL2008_E2806B9511";
			AttributeCRC = "1686909373";
			AttributeSize = "62";
			AttributeName = "Term 187 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_187_EK1100_648C31BD(): base ()
		{
			PexPreConstructorParameterless();
			_Term_188_EK1122 = new Term_188_EK1122_78D8AA43();
			_Term_188_EK1122.AttributeName = "Term 188 (EK1122)";
			_Term_188_EK1122.AttributePreviousPort = "Term 187 (EK1100) : B";
			_Term_188_EK1122.AttributeSyncUnit = "default";
			_Term_204_EL2008 = new EL2008_E2806B95();
			_Term_204_EL2008.AttributeName = "Term 204 (EL2008)";
			_Term_204_EL2008.AttributePreviousPort = "Term 188 (EK1122) : C";
			_Term_204_EL2008.AttributeSyncUnit = "default";
			_Term_205_EL2008 = new EL2008_E2806B95();
			_Term_205_EL2008.AttributeName = "Term 205 (EL2008)";
			_Term_205_EL2008.AttributePreviousPort = "Term 204 (EL2008) : B";
			_Term_205_EL2008.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_188_EK1122Term_188_EK1122_78D8AA4340Term_204_EL2008EL2008_E2806B9511Term_205_EL2008EL2008_E2806B9511";
			AttributeCRC = "1686909373";
			AttributeSize = "62";
			AttributeName = "Term 187 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_187_EK1100_648C31BD
	{
		public void CopyPlainToCyclic(Plc1.Term_187_EK1100_648C31BD target)
		{
			base.CopyPlainToCyclic(target);
			Term_188_EK1122.CopyPlainToCyclic(target.Term_188_EK1122);
			Term_204_EL2008.CopyPlainToCyclic(target.Term_204_EL2008);
			Term_205_EL2008.CopyPlainToCyclic(target.Term_205_EL2008);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_187_EK1100_648C31BD target)
		{
			this.CopyPlainToCyclic((Plc1.Term_187_EK1100_648C31BD)target);
		}

		public void CopyPlainToShadow(Plc1.Term_187_EK1100_648C31BD target)
		{
			base.CopyPlainToShadow(target);
			Term_188_EK1122.CopyPlainToShadow(target.Term_188_EK1122);
			Term_204_EL2008.CopyPlainToShadow(target.Term_204_EL2008);
			Term_205_EL2008.CopyPlainToShadow(target.Term_205_EL2008);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_187_EK1100_648C31BD target)
		{
			this.CopyPlainToShadow((Plc1.Term_187_EK1100_648C31BD)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_187_EK1100_648C31BD source)
		{
			base.CopyCyclicToPlain(source);
			Term_188_EK1122.CopyCyclicToPlain(source.Term_188_EK1122);
			Term_204_EL2008.CopyCyclicToPlain(source.Term_204_EL2008);
			Term_205_EL2008.CopyCyclicToPlain(source.Term_205_EL2008);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_187_EK1100_648C31BD source)
		{
			this.CopyCyclicToPlain((Plc1.Term_187_EK1100_648C31BD)source);
		}

		public void CopyShadowToPlain(Plc1.Term_187_EK1100_648C31BD source)
		{
			base.CopyShadowToPlain(source);
			Term_188_EK1122.CopyShadowToPlain(source.Term_188_EK1122);
			Term_204_EL2008.CopyShadowToPlain(source.Term_204_EL2008);
			Term_205_EL2008.CopyShadowToPlain(source.Term_205_EL2008);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_187_EK1100_648C31BD source)
		{
			this.CopyShadowToPlain((Plc1.Term_187_EK1100_648C31BD)source);
		}
	}
}