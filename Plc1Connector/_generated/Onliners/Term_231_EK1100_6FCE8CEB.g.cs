using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_232_EL1809EL1809_32157CFD20\" } {attribute addProperty CRC \"1875807467\" } {attribute addProperty Size \"20\" } {attribute addProperty Name \"Term 231 (EK1100)\" }", "Term_231_EK1100_6FCE8CEB", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_231_EK1100_6FCE8CEB : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_231_EK1100_6FCE8CEB, IShadowTerm_231_EK1100_6FCE8CEB, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		EL1809_32157CFD _Term_232_EL1809;
		public EL1809_32157CFD Term_232_EL1809
		{
			get
			{
				return _Term_232_EL1809;
			}
		}

		IEL1809_32157CFD ITerm_231_EK1100_6FCE8CEB.Term_232_EL1809
		{
			get
			{
				return Term_232_EL1809;
			}
		}

		IShadowEL1809_32157CFD IShadowTerm_231_EK1100_6FCE8CEB.Term_232_EL1809
		{
			get
			{
				return Term_232_EL1809;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_232_EL1809.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_232_EL1809.LazyShadowToOnline();
		}

		public new PlainTerm_231_EK1100_6FCE8CEB CreatePlainerType()
		{
			var cloned = new PlainTerm_231_EK1100_6FCE8CEB();
			base.CreatePlainerType(cloned);
			cloned.Term_232_EL1809 = Term_232_EL1809.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_231_EK1100_6FCE8CEB CreatePlainerType(PlainTerm_231_EK1100_6FCE8CEB cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_232_EL1809 = Term_232_EL1809.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_231_EK1100_6FCE8CEB source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_231_EK1100_6FCE8CEB source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_231_EK1100_6FCE8CEB source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_231_EK1100_6FCE8CEB(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_232_EL1809 = new EL1809_32157CFD(this, "Term 232 (EL1809)", "Term_232_EL1809");
			_Term_232_EL1809.AttributeName = "Term 232 (EL1809)";
			_Term_232_EL1809.AttributePreviousPort = "Term 231 (EK1100) : B";
			_Term_232_EL1809.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_232_EL1809EL1809_32157CFD20";
			AttributeCRC = "1875807467";
			AttributeSize = "20";
			AttributeName = "Term 231 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_231_EK1100_6FCE8CEB(): base ()
		{
			PexPreConstructorParameterless();
			_Term_232_EL1809 = new EL1809_32157CFD();
			_Term_232_EL1809.AttributeName = "Term 232 (EL1809)";
			_Term_232_EL1809.AttributePreviousPort = "Term 231 (EK1100) : B";
			_Term_232_EL1809.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_232_EL1809EL1809_32157CFD20";
			AttributeCRC = "1875807467";
			AttributeSize = "20";
			AttributeName = "Term 231 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_231_EK1100_6FCE8CEB
	{
		public void CopyPlainToCyclic(Plc1.Term_231_EK1100_6FCE8CEB target)
		{
			base.CopyPlainToCyclic(target);
			Term_232_EL1809.CopyPlainToCyclic(target.Term_232_EL1809);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_231_EK1100_6FCE8CEB target)
		{
			this.CopyPlainToCyclic((Plc1.Term_231_EK1100_6FCE8CEB)target);
		}

		public void CopyPlainToShadow(Plc1.Term_231_EK1100_6FCE8CEB target)
		{
			base.CopyPlainToShadow(target);
			Term_232_EL1809.CopyPlainToShadow(target.Term_232_EL1809);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_231_EK1100_6FCE8CEB target)
		{
			this.CopyPlainToShadow((Plc1.Term_231_EK1100_6FCE8CEB)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_231_EK1100_6FCE8CEB source)
		{
			base.CopyCyclicToPlain(source);
			Term_232_EL1809.CopyCyclicToPlain(source.Term_232_EL1809);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_231_EK1100_6FCE8CEB source)
		{
			this.CopyCyclicToPlain((Plc1.Term_231_EK1100_6FCE8CEB)source);
		}

		public void CopyShadowToPlain(Plc1.Term_231_EK1100_6FCE8CEB source)
		{
			base.CopyShadowToPlain(source);
			Term_232_EL1809.CopyShadowToPlain(source.Term_232_EL1809);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_231_EK1100_6FCE8CEB source)
		{
			this.CopyShadowToPlain((Plc1.Term_231_EK1100_6FCE8CEB)source);
		}
	}
}