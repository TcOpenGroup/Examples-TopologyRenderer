using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3403-0000-0023\" } {attribute addProperty Id \"IndexAT %Q*USINT1\" } {attribute addProperty CRC \"3858488880\" } {attribute addProperty Size \"1\" } {attribute addProperty Name \"\" }", "PM_Outputs_Channel_E5FBDE30", "Plc1", TypeComplexityEnum.Complex)]
	public partial class PM_Outputs_Channel_E5FBDE30 : TcoIo.OutputBase_10CEE7DE, Vortex.Connector.IVortexObject, IPM_Outputs_Channel_E5FBDE30, IShadowPM_Outputs_Channel_E5FBDE30, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerUSInt _Index;
		[IoLinkable("Outputs")]
		public Vortex.Connector.ValueTypes.OnlinerUSInt Index
		{
			get
			{
				return _Index;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineUSInt IPM_Outputs_Channel_E5FBDE30.Index
		{
			get
			{
				return Index;
			}
		}

		[IoLinkable("Outputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt IShadowPM_Outputs_Channel_E5FBDE30.Index
		{
			get
			{
				return Index;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Index.Shadow = Index.LastValue;
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Index.Cyclic = Index.Shadow;
		}

		public new PlainPM_Outputs_Channel_E5FBDE30 CreatePlainerType()
		{
			var cloned = new PlainPM_Outputs_Channel_E5FBDE30();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainPM_Outputs_Channel_E5FBDE30 CreatePlainerType(PlainPM_Outputs_Channel_E5FBDE30 cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainPM_Outputs_Channel_E5FBDE30 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainPM_Outputs_Channel_E5FBDE30 source)
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

		public void FlushOnlineToPlain(Plc1.PlainPM_Outputs_Channel_E5FBDE30 source)
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

		public PM_Outputs_Channel_E5FBDE30(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Index = @Connector.Online.Adapter.CreateUSINT(this, "Index", "Index");
			Index.AttributeName = "Index";
			AttributeBoxType = "EL3403-0000-0023";
			AttributeId = "IndexAT %Q*USINT1";
			AttributeCRC = "3858488880";
			AttributeSize = "1";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public PM_Outputs_Channel_E5FBDE30(): base ()
		{
			PexPreConstructorParameterless();
			_Index = Vortex.Connector.IConnectorFactory.CreateUSINT();
			Index.AttributeName = "Index";
			AttributeBoxType = "EL3403-0000-0023";
			AttributeId = "IndexAT %Q*USINT1";
			AttributeCRC = "3858488880";
			AttributeSize = "1";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainPM_Outputs_Channel_E5FBDE30
	{
		public void CopyPlainToCyclic(Plc1.PM_Outputs_Channel_E5FBDE30 target)
		{
			base.CopyPlainToCyclic(target);
			target.Index.Cyclic = Index;
		}

		public void CopyPlainToCyclic(Plc1.IPM_Outputs_Channel_E5FBDE30 target)
		{
			this.CopyPlainToCyclic((Plc1.PM_Outputs_Channel_E5FBDE30)target);
		}

		public void CopyPlainToShadow(Plc1.PM_Outputs_Channel_E5FBDE30 target)
		{
			base.CopyPlainToShadow(target);
			target.Index.Shadow = Index;
		}

		public void CopyPlainToShadow(Plc1.IShadowPM_Outputs_Channel_E5FBDE30 target)
		{
			this.CopyPlainToShadow((Plc1.PM_Outputs_Channel_E5FBDE30)target);
		}

		public void CopyCyclicToPlain(Plc1.PM_Outputs_Channel_E5FBDE30 source)
		{
			base.CopyCyclicToPlain(source);
			Index = source.Index.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.IPM_Outputs_Channel_E5FBDE30 source)
		{
			this.CopyCyclicToPlain((Plc1.PM_Outputs_Channel_E5FBDE30)source);
		}

		public void CopyShadowToPlain(Plc1.PM_Outputs_Channel_E5FBDE30 source)
		{
			base.CopyShadowToPlain(source);
			Index = source.Index.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowPM_Outputs_Channel_E5FBDE30 source)
		{
			this.CopyShadowToPlain((Plc1.PM_Outputs_Channel_E5FBDE30)source);
		}
	}
}