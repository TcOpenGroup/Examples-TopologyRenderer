using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1122-0000-0018\" } {attribute addProperty Id \"Term_153_EK1100Term_153_EK1100_91C0BB4862Term_178_EK1100Term_178_EK1100_9B7E985262\" } {attribute addProperty CRC \"3395968278\" } {attribute addProperty Size \"124\" } {attribute addProperty Name \"Term 147 (EK1122)\" }", "Term_147_EK1122_CA6A5D16", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_147_EK1122_CA6A5D16 : EK1122_1FC0878B, Vortex.Connector.IVortexObject, ITerm_147_EK1122_CA6A5D16, IShadowTerm_147_EK1122_CA6A5D16, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_153_EK1100_91C0BB48 _Term_153_EK1100;
		public Term_153_EK1100_91C0BB48 Term_153_EK1100
		{
			get
			{
				return _Term_153_EK1100;
			}
		}

		ITerm_153_EK1100_91C0BB48 ITerm_147_EK1122_CA6A5D16.Term_153_EK1100
		{
			get
			{
				return Term_153_EK1100;
			}
		}

		IShadowTerm_153_EK1100_91C0BB48 IShadowTerm_147_EK1122_CA6A5D16.Term_153_EK1100
		{
			get
			{
				return Term_153_EK1100;
			}
		}

		Term_178_EK1100_9B7E9852 _Term_178_EK1100;
		public Term_178_EK1100_9B7E9852 Term_178_EK1100
		{
			get
			{
				return _Term_178_EK1100;
			}
		}

		ITerm_178_EK1100_9B7E9852 ITerm_147_EK1122_CA6A5D16.Term_178_EK1100
		{
			get
			{
				return Term_178_EK1100;
			}
		}

		IShadowTerm_178_EK1100_9B7E9852 IShadowTerm_147_EK1122_CA6A5D16.Term_178_EK1100
		{
			get
			{
				return Term_178_EK1100;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_153_EK1100.LazyOnlineToShadow();
			Term_178_EK1100.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_153_EK1100.LazyShadowToOnline();
			Term_178_EK1100.LazyShadowToOnline();
		}

		public new PlainTerm_147_EK1122_CA6A5D16 CreatePlainerType()
		{
			var cloned = new PlainTerm_147_EK1122_CA6A5D16();
			base.CreatePlainerType(cloned);
			cloned.Term_153_EK1100 = Term_153_EK1100.CreatePlainerType();
			cloned.Term_178_EK1100 = Term_178_EK1100.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_147_EK1122_CA6A5D16 CreatePlainerType(PlainTerm_147_EK1122_CA6A5D16 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_153_EK1100 = Term_153_EK1100.CreatePlainerType();
			cloned.Term_178_EK1100 = Term_178_EK1100.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_147_EK1122_CA6A5D16 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_147_EK1122_CA6A5D16 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_147_EK1122_CA6A5D16 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_147_EK1122_CA6A5D16(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_153_EK1100 = new Term_153_EK1100_91C0BB48(this, "Term 153 (EK1100)", "Term_153_EK1100");
			_Term_153_EK1100.AttributeName = "Term 153 (EK1100)";
			_Term_153_EK1100.AttributePreviousPort = "Term 147 (EK1122) : D";
			_Term_153_EK1100.AttributeSyncUnit = "default";
			_Term_178_EK1100 = new Term_178_EK1100_9B7E9852(this, "Term 178 (EK1100)", "Term_178_EK1100");
			_Term_178_EK1100.AttributeName = "Term 178 (EK1100)";
			_Term_178_EK1100.AttributePreviousPort = "Term 147 (EK1122) : B";
			_Term_178_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_153_EK1100Term_153_EK1100_91C0BB4862Term_178_EK1100Term_178_EK1100_9B7E985262";
			AttributeCRC = "3395968278";
			AttributeSize = "124";
			AttributeName = "Term 147 (EK1122)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_147_EK1122_CA6A5D16(): base ()
		{
			PexPreConstructorParameterless();
			_Term_153_EK1100 = new Term_153_EK1100_91C0BB48();
			_Term_153_EK1100.AttributeName = "Term 153 (EK1100)";
			_Term_153_EK1100.AttributePreviousPort = "Term 147 (EK1122) : D";
			_Term_153_EK1100.AttributeSyncUnit = "default";
			_Term_178_EK1100 = new Term_178_EK1100_9B7E9852();
			_Term_178_EK1100.AttributeName = "Term 178 (EK1100)";
			_Term_178_EK1100.AttributePreviousPort = "Term 147 (EK1122) : B";
			_Term_178_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_153_EK1100Term_153_EK1100_91C0BB4862Term_178_EK1100Term_178_EK1100_9B7E985262";
			AttributeCRC = "3395968278";
			AttributeSize = "124";
			AttributeName = "Term 147 (EK1122)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_147_EK1122_CA6A5D16
	{
		public void CopyPlainToCyclic(Plc1.Term_147_EK1122_CA6A5D16 target)
		{
			base.CopyPlainToCyclic(target);
			Term_153_EK1100.CopyPlainToCyclic(target.Term_153_EK1100);
			Term_178_EK1100.CopyPlainToCyclic(target.Term_178_EK1100);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_147_EK1122_CA6A5D16 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_147_EK1122_CA6A5D16)target);
		}

		public void CopyPlainToShadow(Plc1.Term_147_EK1122_CA6A5D16 target)
		{
			base.CopyPlainToShadow(target);
			Term_153_EK1100.CopyPlainToShadow(target.Term_153_EK1100);
			Term_178_EK1100.CopyPlainToShadow(target.Term_178_EK1100);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_147_EK1122_CA6A5D16 target)
		{
			this.CopyPlainToShadow((Plc1.Term_147_EK1122_CA6A5D16)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_147_EK1122_CA6A5D16 source)
		{
			base.CopyCyclicToPlain(source);
			Term_153_EK1100.CopyCyclicToPlain(source.Term_153_EK1100);
			Term_178_EK1100.CopyCyclicToPlain(source.Term_178_EK1100);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_147_EK1122_CA6A5D16 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_147_EK1122_CA6A5D16)source);
		}

		public void CopyShadowToPlain(Plc1.Term_147_EK1122_CA6A5D16 source)
		{
			base.CopyShadowToPlain(source);
			Term_153_EK1100.CopyShadowToPlain(source.Term_153_EK1100);
			Term_178_EK1100.CopyShadowToPlain(source.Term_178_EK1100);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_147_EK1122_CA6A5D16 source)
		{
			this.CopyShadowToPlain((Plc1.Term_147_EK1122_CA6A5D16)source);
		}
	}
}