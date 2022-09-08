using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_234_EL1809EL1809_32157CFD20\" } {attribute addProperty CRC \"3412413499\" } {attribute addProperty Size \"20\" } {attribute addProperty Name \"Term 233 (EK1100)\" }", "Term_233_EK1100_CB654C3B", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_233_EK1100_CB654C3B : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_233_EK1100_CB654C3B, IShadowTerm_233_EK1100_CB654C3B, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		EL1809_32157CFD _Term_234_EL1809;
		public EL1809_32157CFD Term_234_EL1809
		{
			get
			{
				return _Term_234_EL1809;
			}
		}

		IEL1809_32157CFD ITerm_233_EK1100_CB654C3B.Term_234_EL1809
		{
			get
			{
				return Term_234_EL1809;
			}
		}

		IShadowEL1809_32157CFD IShadowTerm_233_EK1100_CB654C3B.Term_234_EL1809
		{
			get
			{
				return Term_234_EL1809;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_234_EL1809.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_234_EL1809.LazyShadowToOnline();
		}

		public new PlainTerm_233_EK1100_CB654C3B CreatePlainerType()
		{
			var cloned = new PlainTerm_233_EK1100_CB654C3B();
			base.CreatePlainerType(cloned);
			cloned.Term_234_EL1809 = Term_234_EL1809.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_233_EK1100_CB654C3B CreatePlainerType(PlainTerm_233_EK1100_CB654C3B cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_234_EL1809 = Term_234_EL1809.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_233_EK1100_CB654C3B source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_233_EK1100_CB654C3B source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_233_EK1100_CB654C3B source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_233_EK1100_CB654C3B(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_234_EL1809 = new EL1809_32157CFD(this, "Term 234 (EL1809)", "Term_234_EL1809");
			_Term_234_EL1809.AttributeName = "Term 234 (EL1809)";
			_Term_234_EL1809.AttributePreviousPort = "Term 233 (EK1100) : B";
			_Term_234_EL1809.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_234_EL1809EL1809_32157CFD20";
			AttributeCRC = "3412413499";
			AttributeSize = "20";
			AttributeName = "Term 233 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_233_EK1100_CB654C3B(): base ()
		{
			PexPreConstructorParameterless();
			_Term_234_EL1809 = new EL1809_32157CFD();
			_Term_234_EL1809.AttributeName = "Term 234 (EL1809)";
			_Term_234_EL1809.AttributePreviousPort = "Term 233 (EK1100) : B";
			_Term_234_EL1809.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_234_EL1809EL1809_32157CFD20";
			AttributeCRC = "3412413499";
			AttributeSize = "20";
			AttributeName = "Term 233 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_233_EK1100_CB654C3B
	{
		public void CopyPlainToCyclic(Plc1.Term_233_EK1100_CB654C3B target)
		{
			base.CopyPlainToCyclic(target);
			Term_234_EL1809.CopyPlainToCyclic(target.Term_234_EL1809);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_233_EK1100_CB654C3B target)
		{
			this.CopyPlainToCyclic((Plc1.Term_233_EK1100_CB654C3B)target);
		}

		public void CopyPlainToShadow(Plc1.Term_233_EK1100_CB654C3B target)
		{
			base.CopyPlainToShadow(target);
			Term_234_EL1809.CopyPlainToShadow(target.Term_234_EL1809);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_233_EK1100_CB654C3B target)
		{
			this.CopyPlainToShadow((Plc1.Term_233_EK1100_CB654C3B)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_233_EK1100_CB654C3B source)
		{
			base.CopyCyclicToPlain(source);
			Term_234_EL1809.CopyCyclicToPlain(source.Term_234_EL1809);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_233_EK1100_CB654C3B source)
		{
			this.CopyCyclicToPlain((Plc1.Term_233_EK1100_CB654C3B)source);
		}

		public void CopyShadowToPlain(Plc1.Term_233_EK1100_CB654C3B source)
		{
			base.CopyShadowToPlain(source);
			Term_234_EL1809.CopyShadowToPlain(source.Term_234_EL1809);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_233_EK1100_CB654C3B source)
		{
			this.CopyShadowToPlain((Plc1.Term_233_EK1100_CB654C3B)source);
		}
	}
}