using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EK1122-0000-0018\" } {attribute addProperty Id \"Drive_238_AX5101_0000_0214AX5101_1BD22F5129\" } {attribute addProperty CRC \"2259220413\" } {attribute addProperty Size \"29\" } {attribute addProperty Name \"Term 237 (EK1122)\" }", "Term_237_EK1122_86A8F7BD", "Plc1", TypeComplexityEnum.Complex)]
	public partial class Term_237_EK1122_86A8F7BD : EK1122_1FC0878B, Vortex.Connector.IVortexObject, ITerm_237_EK1122_86A8F7BD, IShadowTerm_237_EK1122_86A8F7BD, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		AX5101_1BD22F51 _Drive_238_AX5101_0000_0214;
		public AX5101_1BD22F51 Drive_238_AX5101_0000_0214
		{
			get
			{
				return _Drive_238_AX5101_0000_0214;
			}
		}

		IAX5101_1BD22F51 ITerm_237_EK1122_86A8F7BD.Drive_238_AX5101_0000_0214
		{
			get
			{
				return Drive_238_AX5101_0000_0214;
			}
		}

		IShadowAX5101_1BD22F51 IShadowTerm_237_EK1122_86A8F7BD.Drive_238_AX5101_0000_0214
		{
			get
			{
				return Drive_238_AX5101_0000_0214;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Drive_238_AX5101_0000_0214.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Drive_238_AX5101_0000_0214.LazyShadowToOnline();
		}

		public new PlainTerm_237_EK1122_86A8F7BD CreatePlainerType()
		{
			var cloned = new PlainTerm_237_EK1122_86A8F7BD();
			base.CreatePlainerType(cloned);
			cloned.Drive_238_AX5101_0000_0214 = Drive_238_AX5101_0000_0214.CreatePlainerType();
			return cloned;
		}

		protected PlainTerm_237_EK1122_86A8F7BD CreatePlainerType(PlainTerm_237_EK1122_86A8F7BD cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Drive_238_AX5101_0000_0214 = Drive_238_AX5101_0000_0214.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainTerm_237_EK1122_86A8F7BD source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainTerm_237_EK1122_86A8F7BD source)
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

		public void FlushOnlineToPlain(Plc1.PlainTerm_237_EK1122_86A8F7BD source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public Term_237_EK1122_86A8F7BD(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Drive_238_AX5101_0000_0214 = new AX5101_1BD22F51(this, "Drive 238 (AX5101-0000-0214)", "Drive_238_AX5101_0000_0214");
			_Drive_238_AX5101_0000_0214.AttributeName = "Drive 238 (AX5101-0000-0214)";
			_Drive_238_AX5101_0000_0214.AttributePreviousPort = "Term 237 (EK1122) : D";
			_Drive_238_AX5101_0000_0214.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Drive_238_AX5101_0000_0214AX5101_1BD22F5129";
			AttributeCRC = "2259220413";
			AttributeSize = "29";
			AttributeName = "Term 237 (EK1122)";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public Term_237_EK1122_86A8F7BD(): base ()
		{
			PexPreConstructorParameterless();
			_Drive_238_AX5101_0000_0214 = new AX5101_1BD22F51();
			_Drive_238_AX5101_0000_0214.AttributeName = "Drive 238 (AX5101-0000-0214)";
			_Drive_238_AX5101_0000_0214.AttributePreviousPort = "Term 237 (EK1122) : D";
			_Drive_238_AX5101_0000_0214.AttributeSyncUnit = "default";
			AttributeBoxType = "EK1122-0000-0018";
			AttributeId = "Drive_238_AX5101_0000_0214AX5101_1BD22F5129";
			AttributeCRC = "2259220413";
			AttributeSize = "29";
			AttributeName = "Term 237 (EK1122)";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainTerm_237_EK1122_86A8F7BD
	{
		public void CopyPlainToCyclic(Plc1.Term_237_EK1122_86A8F7BD target)
		{
			base.CopyPlainToCyclic(target);
			Drive_238_AX5101_0000_0214.CopyPlainToCyclic(target.Drive_238_AX5101_0000_0214);
		}

		public void CopyPlainToCyclic(Plc1.ITerm_237_EK1122_86A8F7BD target)
		{
			this.CopyPlainToCyclic((Plc1.Term_237_EK1122_86A8F7BD)target);
		}

		public void CopyPlainToShadow(Plc1.Term_237_EK1122_86A8F7BD target)
		{
			base.CopyPlainToShadow(target);
			Drive_238_AX5101_0000_0214.CopyPlainToShadow(target.Drive_238_AX5101_0000_0214);
		}

		public void CopyPlainToShadow(Plc1.IShadowTerm_237_EK1122_86A8F7BD target)
		{
			this.CopyPlainToShadow((Plc1.Term_237_EK1122_86A8F7BD)target);
		}

		public void CopyCyclicToPlain(Plc1.Term_237_EK1122_86A8F7BD source)
		{
			base.CopyCyclicToPlain(source);
			Drive_238_AX5101_0000_0214.CopyCyclicToPlain(source.Drive_238_AX5101_0000_0214);
		}

		public void CopyCyclicToPlain(Plc1.ITerm_237_EK1122_86A8F7BD source)
		{
			this.CopyCyclicToPlain((Plc1.Term_237_EK1122_86A8F7BD)source);
		}

		public void CopyShadowToPlain(Plc1.Term_237_EK1122_86A8F7BD source)
		{
			base.CopyShadowToPlain(source);
			Drive_238_AX5101_0000_0214.CopyShadowToPlain(source.Drive_238_AX5101_0000_0214);
		}

		public void CopyShadowToPlain(Plc1.IShadowTerm_237_EK1122_86A8F7BD source)
		{
			this.CopyShadowToPlain((Plc1.Term_237_EK1122_86A8F7BD)source);
		}
	}
}