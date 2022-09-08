using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_160_EL1809EL1809_32157CFD20\" } {attribute addProperty CRC \"3822492081\" } {attribute addProperty Size \"20\" } {attribute addProperty Name \"Term 158 (EK1100)\" }", "Term_158_EK1100_E3D699B1", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_158_EK1100_E3D699B1 : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_158_EK1100_E3D699B1, IShadowTerm_158_EK1100_E3D699B1, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		EL1809_32157CFD _Term_160_EL1809;
		public EL1809_32157CFD Term_160_EL1809
		{
			get
			{
				return _Term_160_EL1809;
			}
		}

		IEL1809_32157CFD ITerm_158_EK1100_E3D699B1.Term_160_EL1809
		{
			get
			{
				return Term_160_EL1809;
			}
		}

		IShadowEL1809_32157CFD IShadowTerm_158_EK1100_E3D699B1.Term_160_EL1809
		{
			get
			{
				return Term_160_EL1809;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_160_EL1809.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_160_EL1809.LazyShadowToOnline();
		}

		public new PlainTerm_158_EK1100_E3D699B1 CreatePlainerType()
		{
			var cloned = new PlainTerm_158_EK1100_E3D699B1();
			base.CreatePlainerType(cloned);
			cloned.Term_160_EL1809 = Term_160_EL1809.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_158_EK1100_E3D699B1 CreatePlainerType(PlainTerm_158_EK1100_E3D699B1 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_160_EL1809 = Term_160_EL1809.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_158_EK1100_E3D699B1 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_158_EK1100_E3D699B1 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_158_EK1100_E3D699B1 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_158_EK1100_E3D699B1(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_160_EL1809 = new EL1809_32157CFD(this, "Term 160 (EL1809)", "Term_160_EL1809");
			_Term_160_EL1809.AttributeName = "Term 160 (EL1809)";
			_Term_160_EL1809.AttributePreviousPort = "Term 158 (EK1100) : B";
			_Term_160_EL1809.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_160_EL1809EL1809_32157CFD20";
			AttributeCRC = "3822492081";
			AttributeSize = "20";
			AttributeName = "Term 158 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_158_EK1100_E3D699B1(): base ()
		{
			PexPreConstructorParameterless();
			_Term_160_EL1809 = new EL1809_32157CFD();
			_Term_160_EL1809.AttributeName = "Term 160 (EL1809)";
			_Term_160_EL1809.AttributePreviousPort = "Term 158 (EK1100) : B";
			_Term_160_EL1809.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_160_EL1809EL1809_32157CFD20";
			AttributeCRC = "3822492081";
			AttributeSize = "20";
			AttributeName = "Term 158 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_158_EK1100_E3D699B1
	{
		public void CopyPlainToCyclic(Plc1.Term_158_EK1100_E3D699B1 target)
		{
			base.CopyPlainToCyclic(target);
			Term_160_EL1809.CopyPlainToCyclic(target.Term_160_EL1809);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_158_EK1100_E3D699B1 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_158_EK1100_E3D699B1)target);
		}

		public void CopyPlainToShadow(Plc1.Term_158_EK1100_E3D699B1 target)
		{
			base.CopyPlainToShadow(target);
			Term_160_EL1809.CopyPlainToShadow(target.Term_160_EL1809);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_158_EK1100_E3D699B1 target)
		{
			this.CopyPlainToShadow((Plc1.Term_158_EK1100_E3D699B1)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_158_EK1100_E3D699B1 source)
		{
			base.CopyCyclicToPlain(source);
			Term_160_EL1809.CopyCyclicToPlain(source.Term_160_EL1809);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_158_EK1100_E3D699B1 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_158_EK1100_E3D699B1)source);
		}

		public void CopyShadowToPlain(Plc1.Term_158_EK1100_E3D699B1 source)
		{
			base.CopyShadowToPlain(source);
			Term_160_EL1809.CopyShadowToPlain(source.Term_160_EL1809);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_158_EK1100_E3D699B1 source)
		{
			this.CopyShadowToPlain((Plc1.Term_158_EK1100_E3D699B1)source);
		}
	}
}