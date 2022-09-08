using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty BoxType \"EL6001-0000-0020\" } {attribute addProperty Id \"StatusAT %I*Status_3D84275F8Data_InAT %I*ARRAY[0..21] OF USINT22\" } {attribute addProperty CRC \"1334739266\" } {attribute addProperty Size \"30\" } {attribute addProperty Name \"\" }", "COM_Inputs_3801C95E", "Plc1", TypeComplexityEnum.Complex)]
	public partial class COM_Inputs_3801C95E : TcoIo.InputBase_8311D824, Vortex.Connector.IVortexObject, ICOM_Inputs_3801C95E, IShadowCOM_Inputs_3801C95E, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		Status_3D84275F _Status;
		[IoLinkable("Inputs")]
		public Status_3D84275F Status
		{
			get
			{
				return _Status;
			}
		}

		[IoLinkable("Inputs")]
		IStatus_3D84275F ICOM_Inputs_3801C95E.Status
		{
			get
			{
				return Status;
			}
		}

		[IoLinkable("Inputs")]
		IShadowStatus_3D84275F IShadowCOM_Inputs_3801C95E.Status
		{
			get
			{
				return Status;
			}
		}

		[IoLinkable("Inputs")]
		public Vortex.Connector.ValueTypes.OnlinerUSInt[] Data_In
		{
			get;
			set;
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Online.IOnlineUSInt[] ICOM_Inputs_3801C95E.Data_In
		{
			get
			{
				return Data_In;
			}

			set
			{
				Data_In = (Vortex.Connector.ValueTypes.OnlinerUSInt[])value;
			}
		}

		[IoLinkable("Inputs")]
		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt[] IShadowCOM_Inputs_3801C95E.Data_In
		{
			get
			{
				return Data_In;
			}
		}

		public new void LazyOnlineToShadow()
		{
			base.LazyOnlineToShadow();
			Status.LazyOnlineToShadow();
			Vortex.Connector.BuilderHelpers.Arrays.CopyCyclicToShadowPrimitive<Vortex.Connector.ValueTypes.OnlinerUSInt>(Data_In);
		}

		public new void LazyShadowToOnline()
		{
			base.LazyShadowToOnline();
			Status.LazyShadowToOnline();
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToCyclicPrimitive<Vortex.Connector.ValueTypes.OnlinerUSInt>(Data_In);
		}

		public new PlainCOM_Inputs_3801C95E CreatePlainerType()
		{
			var cloned = new PlainCOM_Inputs_3801C95E();
			base.CreatePlainerType(cloned);
			cloned.Status = Status.CreatePlainerType();
			cloned.Data_In = new System.Byte[22];
			return cloned;
		}

		protected PlainCOM_Inputs_3801C95E CreatePlainerType(PlainCOM_Inputs_3801C95E cloned)
		{
			base.CreatePlainerType(cloned);
			cloned.Status = Status.CreatePlainerType();
			cloned.Data_In = new System.Byte[22];
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		public void FlushPlainToOnline(Plc1.PlainCOM_Inputs_3801C95E source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainCOM_Inputs_3801C95E source)
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

		public void FlushOnlineToPlain(Plc1.PlainCOM_Inputs_3801C95E source)
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

		public COM_Inputs_3801C95E(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail): base (parent, readableTail, symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Status = new Status_3D84275F(this, "Status", "Status");
			_Status.AttributeName = "Status";
			Data_In = new Vortex.Connector.ValueTypes.OnlinerUSInt[22];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(Data_In, this, "Data_In", "Data_In", (p, rt, st) => @Connector.Online.Adapter.CreateUSINT(p, rt, st));
			AttributeBoxType = "EL6001-0000-0020";
			AttributeId = "StatusAT %I*Status_3D84275F8Data_InAT %I*ARRAY[0..21] OF USINT22";
			AttributeCRC = "1334739266";
			AttributeSize = "30";
			PexConstructor(parent, readableTail, symbolTail);
		}

		public COM_Inputs_3801C95E(): base ()
		{
			PexPreConstructorParameterless();
			_Status = new Status_3D84275F();
			_Status.AttributeName = "Status";
			Data_In = new Vortex.Connector.ValueTypes.OnlinerUSInt[22];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(Data_In, () => Vortex.Connector.IConnectorFactory.CreateUSINT());
			AttributeBoxType = "EL6001-0000-0020";
			AttributeId = "StatusAT %I*Status_3D84275F8Data_InAT %I*ARRAY[0..21] OF USINT22";
			AttributeCRC = "1334739266";
			AttributeSize = "30";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainCOM_Inputs_3801C95E
	{
		public void CopyPlainToCyclic(Plc1.COM_Inputs_3801C95E target)
		{
			base.CopyPlainToCyclic(target);
			Status.CopyPlainToCyclic(target.Status);
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToOnline<System.Byte, Vortex.Connector.ValueTypes.OnlinerUSInt>(Data_In, target.Data_In);
		}

		public void CopyPlainToCyclic(Plc1.ICOM_Inputs_3801C95E target)
		{
			this.CopyPlainToCyclic((Plc1.COM_Inputs_3801C95E)target);
		}

		public void CopyPlainToShadow(Plc1.COM_Inputs_3801C95E target)
		{
			base.CopyPlainToShadow(target);
			Status.CopyPlainToShadow(target.Status);
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToShadow<System.Byte, Vortex.Connector.ValueTypes.OnlinerUSInt>(Data_In, target.Data_In);
		}

		public void CopyPlainToShadow(Plc1.IShadowCOM_Inputs_3801C95E target)
		{
			this.CopyPlainToShadow((Plc1.COM_Inputs_3801C95E)target);
		}

		public void CopyCyclicToPlain(Plc1.COM_Inputs_3801C95E source)
		{
			base.CopyCyclicToPlain(source);
			Status.CopyCyclicToPlain(source.Status);
			Vortex.Connector.BuilderHelpers.Arrays.CopyOnlineToPlain<Vortex.Connector.ValueTypes.OnlinerUSInt, System.Byte>(source.Data_In, Data_In);
		}

		public void CopyCyclicToPlain(Plc1.ICOM_Inputs_3801C95E source)
		{
			this.CopyCyclicToPlain((Plc1.COM_Inputs_3801C95E)source);
		}

		public void CopyShadowToPlain(Plc1.COM_Inputs_3801C95E source)
		{
			base.CopyShadowToPlain(source);
			Status.CopyShadowToPlain(source.Status);
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToPlain<Vortex.Connector.ValueTypes.OnlinerUSInt, System.Byte>(source.Data_In, Data_In);
		}

		public void CopyShadowToPlain(Plc1.IShadowCOM_Inputs_3801C95E source)
		{
			this.CopyShadowToPlain((Plc1.COM_Inputs_3801C95E)source);
		}
	}
}