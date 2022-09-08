using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1122-0000-0018\" } {attribute addProperty Id \"Term_187_EK1100Term_187_EK1100_648C31BD62Term_207_EK1100Term_207_EK1100_2D36550A62\" } {attribute addProperty CRC \"1976016210\" } {attribute addProperty Size \"124\" } {attribute addProperty Name \"Term 186 (EK1122)\" }", "Term_186_EK1122_75C79D52", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_186_EK1122_75C79D52 : EK1122_1FC0878B, Vortex.Connector.IVortexObject, ITerm_186_EK1122_75C79D52, IShadowTerm_186_EK1122_75C79D52, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_187_EK1100_648C31BD _Term_187_EK1100;
		public Term_187_EK1100_648C31BD Term_187_EK1100
		{
			get
			{
				return _Term_187_EK1100;
			}
		}

		ITerm_187_EK1100_648C31BD ITerm_186_EK1122_75C79D52.Term_187_EK1100
		{
			get
			{
				return Term_187_EK1100;
			}
		}

		IShadowTerm_187_EK1100_648C31BD IShadowTerm_186_EK1122_75C79D52.Term_187_EK1100
		{
			get
			{
				return Term_187_EK1100;
			}
		}

		Term_207_EK1100_2D36550A _Term_207_EK1100;
		public Term_207_EK1100_2D36550A Term_207_EK1100
		{
			get
			{
				return _Term_207_EK1100;
			}
		}

		ITerm_207_EK1100_2D36550A ITerm_186_EK1122_75C79D52.Term_207_EK1100
		{
			get
			{
				return Term_207_EK1100;
			}
		}

		IShadowTerm_207_EK1100_2D36550A IShadowTerm_186_EK1122_75C79D52.Term_207_EK1100
		{
			get
			{
				return Term_207_EK1100;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_187_EK1100.LazyOnlineToShadow();
			Term_207_EK1100.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_187_EK1100.LazyShadowToOnline();
			Term_207_EK1100.LazyShadowToOnline();
		}

		public new PlainTerm_186_EK1122_75C79D52 CreatePlainerType()
		{
			var cloned = new PlainTerm_186_EK1122_75C79D52();
			base.CreatePlainerType(cloned);
			cloned.Term_187_EK1100 = Term_187_EK1100.CreatePlainerType();
			cloned.Term_207_EK1100 = Term_207_EK1100.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_186_EK1122_75C79D52 CreatePlainerType(PlainTerm_186_EK1122_75C79D52 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_187_EK1100 = Term_187_EK1100.CreatePlainerType();
			cloned.Term_207_EK1100 = Term_207_EK1100.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_186_EK1122_75C79D52 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_186_EK1122_75C79D52 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_186_EK1122_75C79D52 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_186_EK1122_75C79D52(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_187_EK1100 = new Term_187_EK1100_648C31BD(this, "Term 187 (EK1100)", "Term_187_EK1100");
			_Term_187_EK1100.AttributeName = "Term 187 (EK1100)";
			_Term_187_EK1100.AttributePreviousPort = "Term 186 (EK1122) : D";
			_Term_187_EK1100.AttributeSyncUnit = "default";
			_Term_207_EK1100 = new Term_207_EK1100_2D36550A(this, "Term 207 (EK1100)", "Term_207_EK1100");
			_Term_207_EK1100.AttributeName = "Term 207 (EK1100)";
			_Term_207_EK1100.AttributePreviousPort = "Term 186 (EK1122) : B";
			_Term_207_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_187_EK1100Term_187_EK1100_648C31BD62Term_207_EK1100Term_207_EK1100_2D36550A62";
			AttributeCRC = "1976016210";
			AttributeSize = "124";
			AttributeName = "Term 186 (EK1122)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_186_EK1122_75C79D52(): base ()
		{
			PexPreConstructorParameterless();
			_Term_187_EK1100 = new Term_187_EK1100_648C31BD();
			_Term_187_EK1100.AttributeName = "Term 187 (EK1100)";
			_Term_187_EK1100.AttributePreviousPort = "Term 186 (EK1122) : D";
			_Term_187_EK1100.AttributeSyncUnit = "default";
			_Term_207_EK1100 = new Term_207_EK1100_2D36550A();
			_Term_207_EK1100.AttributeName = "Term 207 (EK1100)";
			_Term_207_EK1100.AttributePreviousPort = "Term 186 (EK1122) : B";
			_Term_207_EK1100.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Term_187_EK1100Term_187_EK1100_648C31BD62Term_207_EK1100Term_207_EK1100_2D36550A62";
			AttributeCRC = "1976016210";
			AttributeSize = "124";
			AttributeName = "Term 186 (EK1122)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_186_EK1122_75C79D52
	{
		public void CopyPlainToCyclic(Plc1.Term_186_EK1122_75C79D52 target)
		{
			base.CopyPlainToCyclic(target);
			Term_187_EK1100.CopyPlainToCyclic(target.Term_187_EK1100);
			Term_207_EK1100.CopyPlainToCyclic(target.Term_207_EK1100);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_186_EK1122_75C79D52 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_186_EK1122_75C79D52)target);
		}

		public void CopyPlainToShadow(Plc1.Term_186_EK1122_75C79D52 target)
		{
			base.CopyPlainToShadow(target);
			Term_187_EK1100.CopyPlainToShadow(target.Term_187_EK1100);
			Term_207_EK1100.CopyPlainToShadow(target.Term_207_EK1100);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_186_EK1122_75C79D52 target)
		{
			this.CopyPlainToShadow((Plc1.Term_186_EK1122_75C79D52)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_186_EK1122_75C79D52 source)
		{
			base.CopyCyclicToPlain(source);
			Term_187_EK1100.CopyCyclicToPlain(source.Term_187_EK1100);
			Term_207_EK1100.CopyCyclicToPlain(source.Term_207_EK1100);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_186_EK1122_75C79D52 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_186_EK1122_75C79D52)source);
		}

		public void CopyShadowToPlain(Plc1.Term_186_EK1122_75C79D52 source)
		{
			base.CopyShadowToPlain(source);
			Term_187_EK1100.CopyShadowToPlain(source.Term_187_EK1100);
			Term_207_EK1100.CopyShadowToPlain(source.Term_207_EK1100);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_186_EK1122_75C79D52 source)
		{
			this.CopyShadowToPlain((Plc1.Term_186_EK1122_75C79D52)source);
		}
	}
}