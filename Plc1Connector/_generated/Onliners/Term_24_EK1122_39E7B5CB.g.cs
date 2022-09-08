using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1122-0000-0018\" } {attribute addProperty Id \"Term_25_EK1100Term_25_EK1100_08217EB440Term_28_EK1100Term_28_EK1100_415F4A7E195\" } {attribute addProperty CRC \"971486667\" } {attribute addProperty Size \"235\" } {attribute addProperty Name \"Term 24 (EK1122)\" }", "Term_24_EK1122_39E7B5CB", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_24_EK1122_39E7B5CB : EK1122_1FC0878B, Vortex.Connector.IVortexObject, ITerm_24_EK1122_39E7B5CB, IShadowTerm_24_EK1122_39E7B5CB, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_25_EK1100_08217EB4 _Term_25_EK1100;
		public Term_25_EK1100_08217EB4 Term_25_EK1100
		{
			get
			{
				return _Term_25_EK1100;
			}
		}

		ITerm_25_EK1100_08217EB4 ITerm_24_EK1122_39E7B5CB.Term_25_EK1100
		{
			get
			{
				return Term_25_EK1100;
			}
		}

		IShadowTerm_25_EK1100_08217EB4 IShadowTerm_24_EK1122_39E7B5CB.Term_25_EK1100
		{
			get
			{
				return Term_25_EK1100;
			}
		}

		Term_28_EK1100_415F4A7E _Term_28_EK1100;
		public Term_28_EK1100_415F4A7E Term_28_EK1100
		{
			get
			{
				return _Term_28_EK1100;
			}
		}

		ITerm_28_EK1100_415F4A7E ITerm_24_EK1122_39E7B5CB.Term_28_EK1100
		{
			get
			{
				return Term_28_EK1100;
			}
		}

		IShadowTerm_28_EK1100_415F4A7E IShadowTerm_24_EK1122_39E7B5CB.Term_28_EK1100
		{
			get
			{
				return Term_28_EK1100;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_25_EK1100.LazyOnlineToShadow();
			Term_28_EK1100.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_25_EK1100.LazyShadowToOnline();
			Term_28_EK1100.LazyShadowToOnline();
		}

		public new PlainTerm_24_EK1122_39E7B5CB CreatePlainerType()
		{
			var cloned = new PlainTerm_24_EK1122_39E7B5CB();
			base.CreatePlainerType(cloned);
			cloned.Term_25_EK1100 = Term_25_EK1100.CreatePlainerType();
			cloned.Term_28_EK1100 = Term_28_EK1100.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_24_EK1122_39E7B5CB CreatePlainerType(PlainTerm_24_EK1122_39E7B5CB cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_25_EK1100 = Term_25_EK1100.CreatePlainerType();
			cloned.Term_28_EK1100 = Term_28_EK1100.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_24_EK1122_39E7B5CB source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_24_EK1122_39E7B5CB source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_24_EK1122_39E7B5CB source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_24_EK1122_39E7B5CB(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_25_EK1100 = new Term_25_EK1100_08217EB4(this, "Term 25 (EK1100)", "Term_25_EK1100");
			_Term_25_EK1100.AttributeName = "Term 25 (EK1100)";
			_Term_25_EK1100.AttributePreviousPort = "Term 24 (EK1122) : B";
			_Term_25_EK1100.AttributeSyncUnit = "default";
			_Term_28_EK1100 = new Term_28_EK1100_415F4A7E(this, "Term 28 (EK1100)", "Term_28_EK1100");
			_Term_28_EK1100.AttributeName = "Term 28 (EK1100)";
			_Term_28_EK1100.AttributePreviousPort = "Term 25 (EK1100) : C";
			_Term_28_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_25_EK1100Term_25_EK1100_08217EB440Term_28_EK1100Term_28_EK1100_415F4A7E195";
			AttributeCRC = "971486667";
			AttributeSize = "235";
			AttributeName = "Term 24 (EK1122)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_24_EK1122_39E7B5CB(): base ()
		{
			PexPreConstructorParameterless();
			_Term_25_EK1100 = new Term_25_EK1100_08217EB4();
			_Term_25_EK1100.AttributeName = "Term 25 (EK1100)";
			_Term_25_EK1100.AttributePreviousPort = "Term 24 (EK1122) : B";
			_Term_25_EK1100.AttributeSyncUnit = "default";
			_Term_28_EK1100 = new Term_28_EK1100_415F4A7E();
			_Term_28_EK1100.AttributeName = "Term 28 (EK1100)";
			_Term_28_EK1100.AttributePreviousPort = "Term 25 (EK1100) : C";
			_Term_28_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_25_EK1100Term_25_EK1100_08217EB440Term_28_EK1100Term_28_EK1100_415F4A7E195";
			AttributeCRC = "971486667";
			AttributeSize = "235";
			AttributeName = "Term 24 (EK1122)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_24_EK1122_39E7B5CB
	{
		public void CopyPlainToCyclic(Plc1.Term_24_EK1122_39E7B5CB target)
		{
			base.CopyPlainToCyclic(target);
			Term_25_EK1100.CopyPlainToCyclic(target.Term_25_EK1100);
			Term_28_EK1100.CopyPlainToCyclic(target.Term_28_EK1100);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_24_EK1122_39E7B5CB target)
		{
			this.CopyPlainToCyclic((Plc1.Term_24_EK1122_39E7B5CB)target);
		}

		public void CopyPlainToShadow(Plc1.Term_24_EK1122_39E7B5CB target)
		{
			base.CopyPlainToShadow(target);
			Term_25_EK1100.CopyPlainToShadow(target.Term_25_EK1100);
			Term_28_EK1100.CopyPlainToShadow(target.Term_28_EK1100);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_24_EK1122_39E7B5CB target)
		{
			this.CopyPlainToShadow((Plc1.Term_24_EK1122_39E7B5CB)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_24_EK1122_39E7B5CB source)
		{
			base.CopyCyclicToPlain(source);
			Term_25_EK1100.CopyCyclicToPlain(source.Term_25_EK1100);
			Term_28_EK1100.CopyCyclicToPlain(source.Term_28_EK1100);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_24_EK1122_39E7B5CB source)
		{
			this.CopyCyclicToPlain((Plc1.Term_24_EK1122_39E7B5CB)source);
		}

		public void CopyShadowToPlain(Plc1.Term_24_EK1122_39E7B5CB source)
		{
			base.CopyShadowToPlain(source);
			Term_25_EK1100.CopyShadowToPlain(source.Term_25_EK1100);
			Term_28_EK1100.CopyShadowToPlain(source.Term_28_EK1100);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_24_EK1122_39E7B5CB source)
		{
			this.CopyShadowToPlain((Plc1.Term_24_EK1122_39E7B5CB)source);
		}
	}
}