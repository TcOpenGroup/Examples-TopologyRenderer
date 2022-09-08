using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_179_EK1122Term_179_EK1122_2A33725A40Term_184_EL2008EL2008_E2806B9511Term_185_EL2008EL2008_E2806B9511\" } {attribute addProperty CRC \"2608765010\" } {attribute addProperty Size \"62\" } {attribute addProperty Name \"Term 178 (EK1100)\" }", "Term_178_EK1100_9B7E9852", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_178_EK1100_9B7E9852 : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_178_EK1100_9B7E9852, IShadowTerm_178_EK1100_9B7E9852, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_179_EK1122_2A33725A _Term_179_EK1122;
		public Term_179_EK1122_2A33725A Term_179_EK1122
		{
			get
			{
				return _Term_179_EK1122;
			}
		}

		ITerm_179_EK1122_2A33725A ITerm_178_EK1100_9B7E9852.Term_179_EK1122
		{
			get
			{
				return Term_179_EK1122;
			}
		}

		IShadowTerm_179_EK1122_2A33725A IShadowTerm_178_EK1100_9B7E9852.Term_179_EK1122
		{
			get
			{
				return Term_179_EK1122;
			}
		}

		EL2008_E2806B95 _Term_184_EL2008;
		public EL2008_E2806B95 Term_184_EL2008
		{
			get
			{
				return _Term_184_EL2008;
			}
		}

		IEL2008_E2806B95 ITerm_178_EK1100_9B7E9852.Term_184_EL2008
		{
			get
			{
				return Term_184_EL2008;
			}
		}

		IShadowEL2008_E2806B95 IShadowTerm_178_EK1100_9B7E9852.Term_184_EL2008
		{
			get
			{
				return Term_184_EL2008;
			}
		}

		EL2008_E2806B95 _Term_185_EL2008;
		public EL2008_E2806B95 Term_185_EL2008
		{
			get
			{
				return _Term_185_EL2008;
			}
		}

		IEL2008_E2806B95 ITerm_178_EK1100_9B7E9852.Term_185_EL2008
		{
			get
			{
				return Term_185_EL2008;
			}
		}

		IShadowEL2008_E2806B95 IShadowTerm_178_EK1100_9B7E9852.Term_185_EL2008
		{
			get
			{
				return Term_185_EL2008;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_179_EK1122.LazyOnlineToShadow();
			Term_184_EL2008.LazyOnlineToShadow();
			Term_185_EL2008.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_179_EK1122.LazyShadowToOnline();
			Term_184_EL2008.LazyShadowToOnline();
			Term_185_EL2008.LazyShadowToOnline();
		}

		public new PlainTerm_178_EK1100_9B7E9852 CreatePlainerType()
		{
			var cloned = new PlainTerm_178_EK1100_9B7E9852();
			base.CreatePlainerType(cloned);
			cloned.Term_179_EK1122 = Term_179_EK1122.CreatePlainerType();
			cloned.Term_184_EL2008 = Term_184_EL2008.CreatePlainerType();
			cloned.Term_185_EL2008 = Term_185_EL2008.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_178_EK1100_9B7E9852 CreatePlainerType(PlainTerm_178_EK1100_9B7E9852 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_179_EK1122 = Term_179_EK1122.CreatePlainerType();
			cloned.Term_184_EL2008 = Term_184_EL2008.CreatePlainerType();
			cloned.Term_185_EL2008 = Term_185_EL2008.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_178_EK1100_9B7E9852 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_178_EK1100_9B7E9852 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_178_EK1100_9B7E9852 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_178_EK1100_9B7E9852(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_179_EK1122 = new Term_179_EK1122_2A33725A(this, "Term 179 (EK1122)", "Term_179_EK1122");
			_Term_179_EK1122.AttributeName = "Term 179 (EK1122)";
			_Term_179_EK1122.AttributePreviousPort = "Term 178 (EK1100) : B";
			_Term_179_EK1122.AttributeSyncUnit = "default";
			_Term_184_EL2008 = new EL2008_E2806B95(this, "Term 184 (EL2008)", "Term_184_EL2008");
			_Term_184_EL2008.AttributeName = "Term 184 (EL2008)";
			_Term_184_EL2008.AttributePreviousPort = "Term 179 (EK1122) : C";
			_Term_184_EL2008.AttributeSyncUnit = "default";
			_Term_185_EL2008 = new EL2008_E2806B95(this, "Term 185 (EL2008)", "Term_185_EL2008");
			_Term_185_EL2008.AttributeName = "Term 185 (EL2008)";
			_Term_185_EL2008.AttributePreviousPort = "Term 184 (EL2008) : B";
			_Term_185_EL2008.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_179_EK1122Term_179_EK1122_2A33725A40Term_184_EL2008EL2008_E2806B9511Term_185_EL2008EL2008_E2806B9511";
			AttributeCRC = "2608765010";
			AttributeSize = "62";
			AttributeName = "Term 178 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_178_EK1100_9B7E9852(): base ()
		{
			PexPreConstructorParameterless();
			_Term_179_EK1122 = new Term_179_EK1122_2A33725A();
			_Term_179_EK1122.AttributeName = "Term 179 (EK1122)";
			_Term_179_EK1122.AttributePreviousPort = "Term 178 (EK1100) : B";
			_Term_179_EK1122.AttributeSyncUnit = "default";
			_Term_184_EL2008 = new EL2008_E2806B95();
			_Term_184_EL2008.AttributeName = "Term 184 (EL2008)";
			_Term_184_EL2008.AttributePreviousPort = "Term 179 (EK1122) : C";
			_Term_184_EL2008.AttributeSyncUnit = "default";
			_Term_185_EL2008 = new EL2008_E2806B95();
			_Term_185_EL2008.AttributeName = "Term 185 (EL2008)";
			_Term_185_EL2008.AttributePreviousPort = "Term 184 (EL2008) : B";
			_Term_185_EL2008.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_179_EK1122Term_179_EK1122_2A33725A40Term_184_EL2008EL2008_E2806B9511Term_185_EL2008EL2008_E2806B9511";
			AttributeCRC = "2608765010";
			AttributeSize = "62";
			AttributeName = "Term 178 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_178_EK1100_9B7E9852
	{
		public void CopyPlainToCyclic(Plc1.Term_178_EK1100_9B7E9852 target)
		{
			base.CopyPlainToCyclic(target);
			Term_179_EK1122.CopyPlainToCyclic(target.Term_179_EK1122);
			Term_184_EL2008.CopyPlainToCyclic(target.Term_184_EL2008);
			Term_185_EL2008.CopyPlainToCyclic(target.Term_185_EL2008);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_178_EK1100_9B7E9852 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_178_EK1100_9B7E9852)target);
		}

		public void CopyPlainToShadow(Plc1.Term_178_EK1100_9B7E9852 target)
		{
			base.CopyPlainToShadow(target);
			Term_179_EK1122.CopyPlainToShadow(target.Term_179_EK1122);
			Term_184_EL2008.CopyPlainToShadow(target.Term_184_EL2008);
			Term_185_EL2008.CopyPlainToShadow(target.Term_185_EL2008);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_178_EK1100_9B7E9852 target)
		{
			this.CopyPlainToShadow((Plc1.Term_178_EK1100_9B7E9852)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_178_EK1100_9B7E9852 source)
		{
			base.CopyCyclicToPlain(source);
			Term_179_EK1122.CopyCyclicToPlain(source.Term_179_EK1122);
			Term_184_EL2008.CopyCyclicToPlain(source.Term_184_EL2008);
			Term_185_EL2008.CopyCyclicToPlain(source.Term_185_EL2008);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_178_EK1100_9B7E9852 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_178_EK1100_9B7E9852)source);
		}

		public void CopyShadowToPlain(Plc1.Term_178_EK1100_9B7E9852 source)
		{
			base.CopyShadowToPlain(source);
			Term_179_EK1122.CopyShadowToPlain(source.Term_179_EK1122);
			Term_184_EL2008.CopyShadowToPlain(source.Term_184_EL2008);
			Term_185_EL2008.CopyShadowToPlain(source.Term_185_EL2008);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_178_EK1100_9B7E9852 source)
		{
			this.CopyShadowToPlain((Plc1.Term_178_EK1100_9B7E9852)source);
		}
	}
}