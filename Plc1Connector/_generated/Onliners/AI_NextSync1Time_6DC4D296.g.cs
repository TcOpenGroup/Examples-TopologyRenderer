using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3773-0000-0021\" } {attribute addProperty Id \"StartTimeNextLatchAT %I*StartTimeNextLatch_02E0C1C88\" } {attribute addProperty CRC \"1841615510\" } {attribute addProperty Size \"8\" } {attribute addProperty Name \"\" }", "AI_NextSync1Time_6DC4D296", "Plc1", TypeComplexityEnum.Complex)]
	public partial class AI_NextSync1Time_6DC4D296 : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IAI_NextSync1Time_6DC4D296, IShadowAI_NextSync1Time_6DC4D296, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		StartTimeNextLatch_02E0C1C8 _StartTimeNextLatch;
		[IoLinkable("Inputs")]
		public StartTimeNextLatch_02E0C1C8 StartTimeNextLatch
		{
			get
			{
				return _StartTimeNextLatch;
			}
		}

		[IoLinkable("Inputs")]
		IStartTimeNextLatch_02E0C1C8 IAI_NextSync1Time_6DC4D296.StartTimeNextLatch
		{
			get
			{
				return StartTimeNextLatch;
			}
		}

		[IoLinkable("Inputs")]
		IShadowStartTimeNextLatch_02E0C1C8 IShadowAI_NextSync1Time_6DC4D296.StartTimeNextLatch
		{
			get
			{
				return StartTimeNextLatch;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			StartTimeNextLatch.LazyOnlineToShadow();
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			StartTimeNextLatch.LazyShadowToOnline();
		}

		public new PlainAI_NextSync1Time_6DC4D296 CreatePlainerType()
		{
			var cloned = new PlainAI_NextSync1Time_6DC4D296();
			base.CreatePlainerType(cloned);
			cloned.StartTimeNextLatch = StartTimeNextLatch.CreatePlainerType();
			return cloned;
		}

		protected PlainAI_NextSync1Time_6DC4D296 CreatePlainerType(PlainAI_NextSync1Time_6DC4D296 cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.StartTimeNextLatch = StartTimeNextLatch.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainAI_NextSync1Time_6DC4D296 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainAI_NextSync1Time_6DC4D296 source)
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

		public void FlushOnlineToPlain(Plc1.PlainAI_NextSync1Time_6DC4D296 source)
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

		public AI_NextSync1Time_6DC4D296(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_StartTimeNextLatch = new StartTimeNextLatch_02E0C1C8(this, "StartTimeNextLatch", "StartTimeNextLatch");
			_StartTimeNextLatch.AttributeName = "StartTimeNextLatch";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "StartTimeNextLatchAT %I*StartTimeNextLatch_02E0C1C88";
			AttributeCRC = "1841615510";
			AttributeSize = "8";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public AI_NextSync1Time_6DC4D296(): base ()
		{
			PexPreConstructorParameterless();
			_StartTimeNextLatch = new StartTimeNextLatch_02E0C1C8();
			_StartTimeNextLatch.AttributeName = "StartTimeNextLatch";
			AttributeBoxType = "EL3773-0000-0021";
			AttributeId = "StartTimeNextLatchAT %I*StartTimeNextLatch_02E0C1C88";
			AttributeCRC = "1841615510";
			AttributeSize = "8";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainAI_NextSync1Time_6DC4D296
	{
		public void CopyPlainToCyclic(Plc1.AI_NextSync1Time_6DC4D296 target)
		{
			base.CopyPlainToCyclic(target);
			StartTimeNextLatch.CopyPlainToCyclic(target.StartTimeNextLatch);
		}

		public void CopyPlainToCyclic(Plc1.IAI_NextSync1Time_6DC4D296 target)
		{
			this.CopyPlainToCyclic((Plc1.AI_NextSync1Time_6DC4D296)target);
		}

		public void CopyPlainToShadow(Plc1.AI_NextSync1Time_6DC4D296 target)
		{
			base.CopyPlainToShadow(target);
			StartTimeNextLatch.CopyPlainToShadow(target.StartTimeNextLatch);
		}

		public void CopyPlainToShadow(Plc1.IShadowAI_NextSync1Time_6DC4D296 target)
		{
			this.CopyPlainToShadow((Plc1.AI_NextSync1Time_6DC4D296)target);
		}

		public void CopyCyclicToPlain(Plc1.AI_NextSync1Time_6DC4D296 source)
		{
			base.CopyCyclicToPlain(source);
			StartTimeNextLatch.CopyCyclicToPlain(source.StartTimeNextLatch);
		}

		public void CopyCyclicToPlain(Plc1.IAI_NextSync1Time_6DC4D296 source)
		{
			this.CopyCyclicToPlain((Plc1.AI_NextSync1Time_6DC4D296)source);
		}

		public void CopyShadowToPlain(Plc1.AI_NextSync1Time_6DC4D296 source)
		{
			base.CopyShadowToPlain(source);
			StartTimeNextLatch.CopyShadowToPlain(source.StartTimeNextLatch);
		}

		public void CopyShadowToPlain(Plc1.IShadowAI_NextSync1Time_6DC4D296 source)
		{
			this.CopyShadowToPlain((Plc1.AI_NextSync1Time_6DC4D296)source);
		}
	}
}