using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"Sample_CountAT %I*UINT2\" } {attribute addProperty CRC \"3934833369\" } {attribute addProperty Size \"2\" } {attribute addProperty Name \"\" }", "AI_Sample_Count_EA88CAD9", "Plc1", TypeComplexityEnum.Complex)]
	public partial class AI_Sample_Count_EA88CAD9 : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IAI_Sample_Count_EA88CAD9, IShadowAI_Sample_Count_EA88CAD9, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerUInt _Sample_Count;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerUInt Sample_Count
		{
			get
			{
				return _Sample_Count;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineUInt IAI_Sample_Count_EA88CAD9.Sample_Count
		{
			get
			{
				return Sample_Count;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowAI_Sample_Count_EA88CAD9.Sample_Count
		{
			get
			{
				return Sample_Count;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Sample_Count.Shadow = Sample_Count.LastValue;
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Sample_Count.Cyclic = Sample_Count.Shadow;
		}

		public new PlainAI_Sample_Count_EA88CAD9 CreatePlainerType()
		{
			var cloned = new PlainAI_Sample_Count_EA88CAD9();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainAI_Sample_Count_EA88CAD9 CreatePlainerType(PlainAI_Sample_Count_EA88CAD9 cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainAI_Sample_Count_EA88CAD9 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainAI_Sample_Count_EA88CAD9 source)
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

		public void FlushOnlineToPlain(Plc1.PlainAI_Sample_Count_EA88CAD9 source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		public System.String AttributeBoxType
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeBoxType, this).Interpolate(this);
			}

			set
			{
				_AttributeBoxType = value;
			}
		}

		private System.String _AttributeBoxType
		{
			get;
			set;
		}

		public System.String AttributeId
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeId, this).Interpolate(this);
			}

			set
			{
				_AttributeId = value;
			}
		}

		private System.String _AttributeId
		{
			get;
			set;
		}

		public System.String AttributeCRC
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeCRC, this).Interpolate(this);
			}

			set
			{
				_AttributeCRC = value;
			}
		}

		private System.String _AttributeCRC
		{
			get;
			set;
		}

		public System.String AttributeSize
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeSize, this).Interpolate(this);
			}

			set
			{
				_AttributeSize = value;
			}
		}

		private System.String _AttributeSize
		{
			get;
			set;
		}

		public AI_Sample_Count_EA88CAD9(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Sample_Count = @Connector.Online.Adapter.CreateUINT(this, "Sample_Count", "Sample_Count");
			Sample_Count.AttributeName = "Sample_Count";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "Sample_CountAT %I*UINT2";
			AttributeCRC = "3934833369";
			AttributeSize = "2";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public AI_Sample_Count_EA88CAD9(): base ()
		{
			PexPreConstructorParameterless();
			_Sample_Count = Vortex.Connector.IConnectorFactory.CreateUINT();
			Sample_Count.AttributeName = "Sample_Count";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "Sample_CountAT %I*UINT2";
			AttributeCRC = "3934833369";
			AttributeSize = "2";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainAI_Sample_Count_EA88CAD9
	{
		public void CopyPlainToCyclic(Plc1.AI_Sample_Count_EA88CAD9 target)
		{
			base.CopyPlainToCyclic(target);
			target.Sample_Count.Cyclic = Sample_Count;
		}

		public void CopyPlainToCyclic(Plc1.IAI_Sample_Count_EA88CAD9 target)
		{
			this.CopyPlainToCyclic((Plc1.AI_Sample_Count_EA88CAD9)target);
		}

		public void CopyPlainToShadow(Plc1.AI_Sample_Count_EA88CAD9 target)
		{
			base.CopyPlainToShadow(target);
			target.Sample_Count.Shadow = Sample_Count;
		}

		public void CopyPlainToShadow(Plc1.IShadowAI_Sample_Count_EA88CAD9 target)
		{
			this.CopyPlainToShadow((Plc1.AI_Sample_Count_EA88CAD9)target);
		}

		public void CopyCyclicToPlain(Plc1.AI_Sample_Count_EA88CAD9 source)
		{
			base.CopyCyclicToPlain(source);
			Sample_Count = source.Sample_Count.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.IAI_Sample_Count_EA88CAD9 source)
		{
			this.CopyCyclicToPlain((Plc1.AI_Sample_Count_EA88CAD9)source);
		}

		public void CopyShadowToPlain(Plc1.AI_Sample_Count_EA88CAD9 source)
		{
			base.CopyShadowToPlain(source);
			Sample_Count = source.Sample_Count.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowAI_Sample_Count_EA88CAD9 source)
		{
			this.CopyShadowToPlain((Plc1.AI_Sample_Count_EA88CAD9)source);
		}
	}
}