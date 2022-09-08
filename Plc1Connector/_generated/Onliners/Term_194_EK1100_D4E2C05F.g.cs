using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_200_EL1809EL1809_32157CFD20\" } {attribute addProperty CRC \"3571630175\" } {attribute addProperty Size \"20\" } {attribute addProperty Name \"Term 194 (EK1100)\" }", "Term_194_EK1100_D4E2C05F", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_194_EK1100_D4E2C05F : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_194_EK1100_D4E2C05F, IShadowTerm_194_EK1100_D4E2C05F, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		EL1809_32157CFD _Term_200_EL1809;
		public EL1809_32157CFD Term_200_EL1809
		{
			get
			{
				return _Term_200_EL1809;
			}
		}

		IEL1809_32157CFD ITerm_194_EK1100_D4E2C05F.Term_200_EL1809
		{
			get
			{
				return Term_200_EL1809;
			}
		}

		IShadowEL1809_32157CFD IShadowTerm_194_EK1100_D4E2C05F.Term_200_EL1809
		{
			get
			{
				return Term_200_EL1809;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_200_EL1809.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_200_EL1809.LazyShadowToOnline();
		}

		public new PlainTerm_194_EK1100_D4E2C05F CreatePlainerType()
		{
			var cloned = new PlainTerm_194_EK1100_D4E2C05F();
			base.CreatePlainerType(cloned);
			cloned.Term_200_EL1809 = Term_200_EL1809.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_194_EK1100_D4E2C05F CreatePlainerType(PlainTerm_194_EK1100_D4E2C05F cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_200_EL1809 = Term_200_EL1809.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_194_EK1100_D4E2C05F source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_194_EK1100_D4E2C05F source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_194_EK1100_D4E2C05F source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_194_EK1100_D4E2C05F(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_200_EL1809 = new EL1809_32157CFD(this, "Term 200 (EL1809)", "Term_200_EL1809");
			_Term_200_EL1809.AttributeName = "Term 200 (EL1809)";
			_Term_200_EL1809.AttributePreviousPort = "Term 194 (EK1100) : B";
			_Term_200_EL1809.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_200_EL1809EL1809_32157CFD20";
			AttributeCRC = "3571630175";
			AttributeSize = "20";
			AttributeName = "Term 194 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_194_EK1100_D4E2C05F(): base ()
		{
			PexPreConstructorParameterless();
			_Term_200_EL1809 = new EL1809_32157CFD();
			_Term_200_EL1809.AttributeName = "Term 200 (EL1809)";
			_Term_200_EL1809.AttributePreviousPort = "Term 194 (EK1100) : B";
			_Term_200_EL1809.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_200_EL1809EL1809_32157CFD20";
			AttributeCRC = "3571630175";
			AttributeSize = "20";
			AttributeName = "Term 194 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_194_EK1100_D4E2C05F
	{
		public void CopyPlainToCyclic(Plc1.Term_194_EK1100_D4E2C05F target)
		{
			base.CopyPlainToCyclic(target);
			Term_200_EL1809.CopyPlainToCyclic(target.Term_200_EL1809);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_194_EK1100_D4E2C05F target)
		{
			this.CopyPlainToCyclic((Plc1.Term_194_EK1100_D4E2C05F)target);
		}

		public void CopyPlainToShadow(Plc1.Term_194_EK1100_D4E2C05F target)
		{
			base.CopyPlainToShadow(target);
			Term_200_EL1809.CopyPlainToShadow(target.Term_200_EL1809);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_194_EK1100_D4E2C05F target)
		{
			this.CopyPlainToShadow((Plc1.Term_194_EK1100_D4E2C05F)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_194_EK1100_D4E2C05F source)
		{
			base.CopyCyclicToPlain(source);
			Term_200_EL1809.CopyCyclicToPlain(source.Term_200_EL1809);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_194_EK1100_D4E2C05F source)
		{
			this.CopyCyclicToPlain((Plc1.Term_194_EK1100_D4E2C05F)source);
		}

		public void CopyShadowToPlain(Plc1.Term_194_EK1100_D4E2C05F source)
		{
			base.CopyShadowToPlain(source);
			Term_200_EL1809.CopyShadowToPlain(source.Term_200_EL1809);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_194_EK1100_D4E2C05F source)
		{
			this.CopyShadowToPlain((Plc1.Term_194_EK1100_D4E2C05F)source);
		}
	}
}