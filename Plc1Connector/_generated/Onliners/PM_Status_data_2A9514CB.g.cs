using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL3403-0000-0023\" } {attribute addProperty Id \"Missing_zero_crossing_AAT %I*BOOL1Missing_zero_crossing_BAT %I*BOOL1Missing_zero_crossing_CAT %I*BOOL1Phase_sequence_errorAT %I*BOOL1\" } {attribute addProperty CRC \"714413259\" } {attribute addProperty Size \"4\" } {attribute addProperty Name \"\" }", "PM_Status_data_2A9514CB", "Plc1", TypeComplexityEnum.Complex)]
	public partial class PM_Status_data_2A9514CB : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, IPM_Status_data_2A9514CB, IShadowPM_Status_data_2A9514CB, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.OnlinerBool _Missing_zero_crossing_A;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool Missing_zero_crossing_A
		{
			get
			{
				return _Missing_zero_crossing_A;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IPM_Status_data_2A9514CB.Missing_zero_crossing_A
		{
			get
			{
				return Missing_zero_crossing_A;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowPM_Status_data_2A9514CB.Missing_zero_crossing_A
		{
			get
			{
				return Missing_zero_crossing_A;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Missing_zero_crossing_B;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool Missing_zero_crossing_B
		{
			get
			{
				return _Missing_zero_crossing_B;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IPM_Status_data_2A9514CB.Missing_zero_crossing_B
		{
			get
			{
				return Missing_zero_crossing_B;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowPM_Status_data_2A9514CB.Missing_zero_crossing_B
		{
			get
			{
				return Missing_zero_crossing_B;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Missing_zero_crossing_C;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool Missing_zero_crossing_C
		{
			get
			{
				return _Missing_zero_crossing_C;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IPM_Status_data_2A9514CB.Missing_zero_crossing_C
		{
			get
			{
				return Missing_zero_crossing_C;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowPM_Status_data_2A9514CB.Missing_zero_crossing_C
		{
			get
			{
				return Missing_zero_crossing_C;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool _Phase_sequence_error;
		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerBool Phase_sequence_error
		{
			get
			{
				return _Phase_sequence_error;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineBool IPM_Status_data_2A9514CB.Phase_sequence_error
		{
			get
			{
				return Phase_sequence_error;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowPM_Status_data_2A9514CB.Phase_sequence_error
		{
			get
			{
				return Phase_sequence_error;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Missing_zero_crossing_A.Shadow = Missing_zero_crossing_A.LastValue;
			Missing_zero_crossing_B.Shadow = Missing_zero_crossing_B.LastValue;
			Missing_zero_crossing_C.Shadow = Missing_zero_crossing_C.LastValue;
			Phase_sequence_error.Shadow = Phase_sequence_error.LastValue;
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Missing_zero_crossing_A.Cyclic = Missing_zero_crossing_A.Shadow;
			Missing_zero_crossing_B.Cyclic = Missing_zero_crossing_B.Shadow;
			Missing_zero_crossing_C.Cyclic = Missing_zero_crossing_C.Shadow;
			Phase_sequence_error.Cyclic = Phase_sequence_error.Shadow;
		}

		public new PlainPM_Status_data_2A9514CB CreatePlainerType()
		{
			var cloned = new PlainPM_Status_data_2A9514CB();
			base.CreatePlainerType(cloned);
			return cloned;
		}

		protected PlainPM_Status_data_2A9514CB CreatePlainerType(PlainPM_Status_data_2A9514CB cloned)
		{
			base.CreatePlainerType(cloned);
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainPM_Status_data_2A9514CB source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainPM_Status_data_2A9514CB source)
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

		public void FlushOnlineToPlain(Plc1.PlainPM_Status_data_2A9514CB source)
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

		public PM_Status_data_2A9514CB(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Missing_zero_crossing_A = @Connector.Online.Adapter.CreateBOOL(this, "Missing_zero_crossing_A", "Missing_zero_crossing_A");
			Missing_zero_crossing_A.AttributeName = "Missing_zero_crossing_A";
			_Missing_zero_crossing_B = @Connector.Online.Adapter.CreateBOOL(this, "Missing_zero_crossing_B", "Missing_zero_crossing_B");
			Missing_zero_crossing_B.AttributeName = "Missing_zero_crossing_B";
			_Missing_zero_crossing_C = @Connector.Online.Adapter.CreateBOOL(this, "Missing_zero_crossing_C", "Missing_zero_crossing_C");
			Missing_zero_crossing_C.AttributeName = "Missing_zero_crossing_C";
			_Phase_sequence_error = @Connector.Online.Adapter.CreateBOOL(this, "Phase_sequence_error", "Phase_sequence_error");
			Phase_sequence_error.AttributeName = "Phase_sequence_error";
			AttributeBoxType = "EL3403-0000-0023";
			AttributeId = "Missing_zero_crossing_AAT %I*BOOL1Missing_zero_crossing_BAT %I*BOOL1Missing_zero_crossing_CAT %I*BOOL1Phase_sequence_errorAT %I*BOOL1";
			AttributeCRC = "714413259";
			AttributeSize = "4";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public PM_Status_data_2A9514CB(): base ()
		{
			PexPreConstructorParameterless();
			_Missing_zero_crossing_A = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Missing_zero_crossing_A.AttributeName = "Missing_zero_crossing_A";
			_Missing_zero_crossing_B = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Missing_zero_crossing_B.AttributeName = "Missing_zero_crossing_B";
			_Missing_zero_crossing_C = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Missing_zero_crossing_C.AttributeName = "Missing_zero_crossing_C";
			_Phase_sequence_error = Vortex.Connector.IConnectorFactory.CreateBOOL();
			Phase_sequence_error.AttributeName = "Phase_sequence_error";
			AttributeBoxType = "EL3403-0000-0023";
			AttributeId = "Missing_zero_crossing_AAT %I*BOOL1Missing_zero_crossing_BAT %I*BOOL1Missing_zero_crossing_CAT %I*BOOL1Phase_sequence_errorAT %I*BOOL1";
			AttributeCRC = "714413259";
			AttributeSize = "4";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainPM_Status_data_2A9514CB
	{
		public void CopyPlainToCyclic(Plc1.PM_Status_data_2A9514CB target)
		{
			base.CopyPlainToCyclic(target);
			target.Missing_zero_crossing_A.Cyclic = Missing_zero_crossing_A;
			target.Missing_zero_crossing_B.Cyclic = Missing_zero_crossing_B;
			target.Missing_zero_crossing_C.Cyclic = Missing_zero_crossing_C;
			target.Phase_sequence_error.Cyclic = Phase_sequence_error;
		}

		public void CopyPlainToCyclic(Plc1.IPM_Status_data_2A9514CB target)
		{
			this.CopyPlainToCyclic((Plc1.PM_Status_data_2A9514CB)target);
		}

		public void CopyPlainToShadow(Plc1.PM_Status_data_2A9514CB target)
		{
			base.CopyPlainToShadow(target);
			target.Missing_zero_crossing_A.Shadow = Missing_zero_crossing_A;
			target.Missing_zero_crossing_B.Shadow = Missing_zero_crossing_B;
			target.Missing_zero_crossing_C.Shadow = Missing_zero_crossing_C;
			target.Phase_sequence_error.Shadow = Phase_sequence_error;
		}

		public void CopyPlainToShadow(Plc1.IShadowPM_Status_data_2A9514CB target)
		{
			this.CopyPlainToShadow((Plc1.PM_Status_data_2A9514CB)target);
		}

		public void CopyCyclicToPlain(Plc1.PM_Status_data_2A9514CB source)
		{
			base.CopyCyclicToPlain(source);
			Missing_zero_crossing_A = source.Missing_zero_crossing_A.LastValue;
			Missing_zero_crossing_B = source.Missing_zero_crossing_B.LastValue;
			Missing_zero_crossing_C = source.Missing_zero_crossing_C.LastValue;
			Phase_sequence_error = source.Phase_sequence_error.LastValue;
		}

		public void CopyCyclicToPlain(Plc1.IPM_Status_data_2A9514CB source)
		{
			this.CopyCyclicToPlain((Plc1.PM_Status_data_2A9514CB)source);
		}

		public void CopyShadowToPlain(Plc1.PM_Status_data_2A9514CB source)
		{
			base.CopyShadowToPlain(source);
			Missing_zero_crossing_A = source.Missing_zero_crossing_A.Shadow;
			Missing_zero_crossing_B = source.Missing_zero_crossing_B.Shadow;
			Missing_zero_crossing_C = source.Missing_zero_crossing_C.Shadow;
			Phase_sequence_error = source.Phase_sequence_error.Shadow;
		}

		public void CopyShadowToPlain(Plc1.IShadowPM_Status_data_2A9514CB source)
		{
			this.CopyShadowToPlain((Plc1.PM_Status_data_2A9514CB)source);
		}
	}
}