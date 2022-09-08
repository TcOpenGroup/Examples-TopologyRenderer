using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"AX5101-0000-0214-0214\" } {attribute addProperty Id \"Drive_status_wordAT %I*UINT2Position_feedback_1_valueAT %I*DINT4Following_distanceAT %I*DINT4\" } {attribute addProperty CRC \"1321396072\" } {attribute addProperty Size \"10\" } {attribute addProperty Name \"\" }", "AT_x_4EC2E768", "Plc1", TypeComplexityEnum.Complex)]
	public partial class AT_x_4EC2E768 : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IAT_x_4EC2E768, IShadowAT_x_4EC2E768, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerUInt _Drive_status_word;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerUInt Drive_status_word
		{
			get
			{
				return _Drive_status_word;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineUInt IAT_x_4EC2E768.Drive_status_word
		{
			get
			{
				return Drive_status_word;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowAT_x_4EC2E768.Drive_status_word
		{
			get
			{
				return Drive_status_word;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDInt _Position_feedback_1_value;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerDInt Position_feedback_1_value
		{
			get
			{
				return _Position_feedback_1_value;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineDInt IAT_x_4EC2E768.Position_feedback_1_value
		{
			get
			{
				return Position_feedback_1_value;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowAT_x_4EC2E768.Position_feedback_1_value
		{
			get
			{
				return Position_feedback_1_value;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDInt _Following_distance;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerDInt Following_distance
		{
			get
			{
				return _Following_distance;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineDInt IAT_x_4EC2E768.Following_distance
		{
			get
			{
				return Following_distance;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowAT_x_4EC2E768.Following_distance
		{
			get
			{
				return Following_distance;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Drive_status_word.Shadow = Drive_status_word.LastValue;
			Position_feedback_1_value.Shadow = Position_feedback_1_value.LastValue;
			Following_distance.Shadow = Following_distance.LastValue;
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Drive_status_word.Cyclic = Drive_status_word.Shadow;
			Position_feedback_1_value.Cyclic = Position_feedback_1_value.Shadow;
			Following_distance.Cyclic = Following_distance.Shadow;
		}

		public new PlainAT_x_4EC2E768 CreatePlainerType()
		{
			var cloned = new PlainAT_x_4EC2E768();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainAT_x_4EC2E768 CreatePlainerType(PlainAT_x_4EC2E768 cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainAT_x_4EC2E768 source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainAT_x_4EC2E768 source)
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

		public void FlushOnlineToPlain(Plc1.PlainAT_x_4EC2E768 source)
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

		public AT_x_4EC2E768(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Drive_status_word = @Connector.Online.Adapter.CreateUINT(this, "Drive_status_word", "Drive_status_word");
			Drive_status_word.AttributeName = "Drive_status_word";
			_Position_feedback_1_value = @Connector.Online.Adapter.CreateDINT(this, "Position_feedback_1_value", "Position_feedback_1_value");
			Position_feedback_1_value.AttributeName = "Position_feedback_1_value";
			_Following_distance = @Connector.Online.Adapter.CreateDINT(this, "Following_distance", "Following_distance");
			Following_distance.AttributeName = "Following_distance";
			AttributeBoxType = "AX5101-0000-0214-0214";
			AttributeId = "Drive_status_wordAT %I*UINT2Position_feedback_1_valueAT %I*DINT4Following_distanceAT %I*DINT4";
			AttributeCRC = "1321396072";
			AttributeSize = "10";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public AT_x_4EC2E768(): base ()
		{
			PexPreConstructorParameterless();
			_Drive_status_word = Vortex.Connector.IConnectorFactory.CreateUINT();
			Drive_status_word.AttributeName = "Drive_status_word";
			_Position_feedback_1_value = Vortex.Connector.IConnectorFactory.CreateDINT();
			Position_feedback_1_value.AttributeName = "Position_feedback_1_value";
			_Following_distance = Vortex.Connector.IConnectorFactory.CreateDINT();
			Following_distance.AttributeName = "Following_distance";
			AttributeBoxType = "AX5101-0000-0214-0214";
			AttributeId = "Drive_status_wordAT %I*UINT2Position_feedback_1_valueAT %I*DINT4Following_distanceAT %I*DINT4";
			AttributeCRC = "1321396072";
			AttributeSize = "10";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainAT_x_4EC2E768
	{
		public void CopyPlainToCyclic(Plc1.AT_x_4EC2E768 target)
		{
			base.CopyPlainToCyclic(target);
			target.Drive_status_word.Cyclic = Drive_status_word;
			target.Position_feedback_1_value.Cyclic = Position_feedback_1_value;
			target.Following_distance.Cyclic = Following_distance;
		}

		public void CopyPlainToCyclic(Plc1.IAT_x_4EC2E768 target)
		{
			this.CopyPlainToCyclic((Plc1.AT_x_4EC2E768)target);
		}

		public void CopyPlainToShadow(Plc1.AT_x_4EC2E768 target)
		{
			base.CopyPlainToShadow(target);
			target.Drive_status_word.Shadow = Drive_status_word;
			target.Position_feedback_1_value.Shadow = Position_feedback_1_value;
			target.Following_distance.Shadow = Following_distance;
		}

		public void CopyPlainToShadow(Plc1.IShadowAT_x_4EC2E768 target)
		{
			this.CopyPlainToShadow((Plc1.AT_x_4EC2E768)target);
		}

		public void CopyCyclicToPlain(Plc1.AT_x_4EC2E768 source)
		{
			base.CopyCyclicToPlain(source);
			Drive_status_word = source.Drive_status_word.LastValue;
			Position_feedback_1_value = source.Position_feedback_1_value.LastValue;
			Following_distance = source.Following_distance.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.IAT_x_4EC2E768 source)
		{
			this.CopyCyclicToPlain((Plc1.AT_x_4EC2E768)source);
		}

		public void CopyShadowToPlain(Plc1.AT_x_4EC2E768 source)
		{
			base.CopyShadowToPlain(source);
			Drive_status_word = source.Drive_status_word.Shadow;
			Position_feedback_1_value = source.Position_feedback_1_value.Shadow;
			Following_distance = source.Following_distance.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowAT_x_4EC2E768 source)
		{
			this.CopyShadowToPlain((Plc1.AT_x_4EC2E768)source);
		}
	}
}