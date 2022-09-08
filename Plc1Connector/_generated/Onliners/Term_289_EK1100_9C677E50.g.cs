using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1100-0000-0018\" } {attribute addProperty Id \"Term_237_EK1122Term_237_EK1122_86A8F7BD29Term_293_EL1809EL1809_32157CFD20\" } {attribute addProperty CRC \"2624028240\" } {attribute addProperty Size \"49\" } {attribute addProperty Name \"Term 289 (EK1100)\" }", "Term_289_EK1100_9C677E50", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_289_EK1100_9C677E50 : EK1100_1FC0878B, Vortex.Connector.IVortexObject, ITerm_289_EK1100_9C677E50, IShadowTerm_289_EK1100_9C677E50, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Term_237_EK1122_86A8F7BD _Term_237_EK1122;
		public Term_237_EK1122_86A8F7BD Term_237_EK1122
		{
			get
			{
				return _Term_237_EK1122;
			}
		}

		ITerm_237_EK1122_86A8F7BD ITerm_289_EK1100_9C677E50.Term_237_EK1122
		{
			get
			{
				return Term_237_EK1122;
			}
		}

		IShadowTerm_237_EK1122_86A8F7BD IShadowTerm_289_EK1100_9C677E50.Term_237_EK1122
		{
			get
			{
				return Term_237_EK1122;
			}
		}

		EL1809_32157CFD _Term_293_EL1809;
		public EL1809_32157CFD Term_293_EL1809
		{
			get
			{
				return _Term_293_EL1809;
			}
		}

		IEL1809_32157CFD ITerm_289_EK1100_9C677E50.Term_293_EL1809
		{
			get
			{
				return Term_293_EL1809;
			}
		}

		IShadowEL1809_32157CFD IShadowTerm_289_EK1100_9C677E50.Term_293_EL1809
		{
			get
			{
				return Term_293_EL1809;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Term_237_EK1122.LazyOnlineToShadow();
			Term_293_EL1809.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Term_237_EK1122.LazyShadowToOnline();
			Term_293_EL1809.LazyShadowToOnline();
		}

		public new PlainTerm_289_EK1100_9C677E50 CreatePlainerType()
		{
			var cloned = new PlainTerm_289_EK1100_9C677E50();
			base.CreatePlainerType(cloned);
			cloned.Term_237_EK1122 = Term_237_EK1122.CreatePlainerType();
			cloned.Term_293_EL1809 = Term_293_EL1809.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_289_EK1100_9C677E50 CreatePlainerType(PlainTerm_289_EK1100_9C677E50 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Term_237_EK1122 = Term_237_EK1122.CreatePlainerType();
			cloned.Term_293_EL1809 = Term_293_EL1809.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_289_EK1100_9C677E50 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_289_EK1100_9C677E50 source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_289_EK1100_9C677E50 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_289_EK1100_9C677E50(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Term_237_EK1122 = new Term_237_EK1122_86A8F7BD(this, "Term 237 (EK1122)", "Term_237_EK1122");
			_Term_237_EK1122.AttributeName = "Term 237 (EK1122)";
			_Term_237_EK1122.AttributePreviousPort = "Term 289 (EK1100) : B";
			_Term_237_EK1122.AttributeSyncUnit = "default";
			_Term_293_EL1809 = new EL1809_32157CFD(this, "Term 293 (EL1809)", "Term_293_EL1809");
			_Term_293_EL1809.AttributeName = "Term 293 (EL1809)";
			_Term_293_EL1809.AttributePreviousPort = "Term 237 (EK1122) : C";
			_Term_293_EL1809.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_237_EK1122Term_237_EK1122_86A8F7BD29Term_293_EL1809EL1809_32157CFD20";
			AttributeCRC = "2624028240";
			AttributeSize = "49";
			AttributeName = "Term 289 (EK1100)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_289_EK1100_9C677E50(): base ()
		{
			PexPreConstructorParameterless();
			_Term_237_EK1122 = new Term_237_EK1122_86A8F7BD();
			_Term_237_EK1122.AttributeName = "Term 237 (EK1122)";
			_Term_237_EK1122.AttributePreviousPort = "Term 289 (EK1100) : B";
			_Term_237_EK1122.AttributeSyncUnit = "default";
			_Term_293_EL1809 = new EL1809_32157CFD();
			_Term_293_EL1809.AttributeName = "Term 293 (EL1809)";
			_Term_293_EL1809.AttributePreviousPort = "Term 237 (EK1122) : C";
			_Term_293_EL1809.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1100-0000-0018";
			AttributeId = "Term_237_EK1122Term_237_EK1122_86A8F7BD29Term_293_EL1809EL1809_32157CFD20";
			AttributeCRC = "2624028240";
			AttributeSize = "49";
			AttributeName = "Term 289 (EK1100)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_289_EK1100_9C677E50
	{
		public void CopyPlainToCyclic(Plc1.Term_289_EK1100_9C677E50 target)
		{
			base.CopyPlainToCyclic(target);
			Term_237_EK1122.CopyPlainToCyclic(target.Term_237_EK1122);
			Term_293_EL1809.CopyPlainToCyclic(target.Term_293_EL1809);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_289_EK1100_9C677E50 target)
		{
			this.CopyPlainToCyclic((Plc1.Term_289_EK1100_9C677E50)target);
		}

		public void CopyPlainToShadow(Plc1.Term_289_EK1100_9C677E50 target)
		{
			base.CopyPlainToShadow(target);
			Term_237_EK1122.CopyPlainToShadow(target.Term_237_EK1122);
			Term_293_EL1809.CopyPlainToShadow(target.Term_293_EL1809);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_289_EK1100_9C677E50 target)
		{
			this.CopyPlainToShadow((Plc1.Term_289_EK1100_9C677E50)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_289_EK1100_9C677E50 source)
		{
			base.CopyCyclicToPlain(source);
			Term_237_EK1122.CopyCyclicToPlain(source.Term_237_EK1122);
			Term_293_EL1809.CopyCyclicToPlain(source.Term_293_EL1809);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_289_EK1100_9C677E50 source)
		{
			this.CopyCyclicToPlain((Plc1.Term_289_EK1100_9C677E50)source);
		}

		public void CopyShadowToPlain(Plc1.Term_289_EK1100_9C677E50 source)
		{
			base.CopyShadowToPlain(source);
			Term_237_EK1122.CopyShadowToPlain(source.Term_237_EK1122);
			Term_293_EL1809.CopyShadowToPlain(source.Term_293_EL1809);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_289_EK1100_9C677E50 source)
		{
			this.CopyShadowToPlain((Plc1.Term_289_EK1100_9C677E50)source);
		}
	}
}