using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace Plc1
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "GVL_iXlinker", "Plc1", TypeComplexityEnum.Complex)]
	public partial class GVL_iXlinker : Vortex.Connector.IVortexObject, IGVL_iXlinker, IShadowGVL_iXlinker, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		Device_1_EtherCAT_B557D6C6 _Device_1_EtherCAT;
		public Device_1_EtherCAT_B557D6C6 Device_1_EtherCAT
		{
			get
			{
				return _Device_1_EtherCAT;
			}
		}

		IDevice_1_EtherCAT_B557D6C6 IGVL_iXlinker.Device_1_EtherCAT
		{
			get
			{
				return Device_1_EtherCAT;
			}
		}

		IShadowDevice_1_EtherCAT_B557D6C6 IShadowGVL_iXlinker.Device_1_EtherCAT
		{
			get
			{
				return Device_1_EtherCAT;
			}
		}

		Device_2_EtherCAT_CA128DDC _Device_2_EtherCAT;
		public Device_2_EtherCAT_CA128DDC Device_2_EtherCAT
		{
			get
			{
				return _Device_2_EtherCAT;
			}
		}

		IDevice_2_EtherCAT_CA128DDC IGVL_iXlinker.Device_2_EtherCAT
		{
			get
			{
				return Device_2_EtherCAT;
			}
		}

		IShadowDevice_2_EtherCAT_CA128DDC IShadowGVL_iXlinker.Device_2_EtherCAT
		{
			get
			{
				return Device_2_EtherCAT;
			}
		}

		Device_3_EtherCAT_CA191EDE _Device_3_EtherCAT;
		public Device_3_EtherCAT_CA191EDE Device_3_EtherCAT
		{
			get
			{
				return _Device_3_EtherCAT;
			}
		}

		IDevice_3_EtherCAT_CA191EDE IGVL_iXlinker.Device_3_EtherCAT
		{
			get
			{
				return Device_3_EtherCAT;
			}
		}

		IShadowDevice_3_EtherCAT_CA191EDE IShadowGVL_iXlinker.Device_3_EtherCAT
		{
			get
			{
				return Device_3_EtherCAT;
			}
		}

		public void LazyOnlineToShadow()
		{
			Device_1_EtherCAT.LazyOnlineToShadow();
			Device_2_EtherCAT.LazyOnlineToShadow();
			Device_3_EtherCAT.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			Device_1_EtherCAT.LazyShadowToOnline();
			Device_2_EtherCAT.LazyShadowToOnline();
			Device_3_EtherCAT.LazyShadowToOnline();
		}

		public PlainGVL_iXlinker CreatePlainerType()
		{
			var cloned = new PlainGVL_iXlinker();
			cloned.Device_1_EtherCAT = Device_1_EtherCAT.CreatePlainerType();
			cloned.Device_2_EtherCAT = Device_2_EtherCAT.CreatePlainerType();
			cloned.Device_3_EtherCAT = Device_3_EtherCAT.CreatePlainerType();
			return cloned;
		}

		protected PlainGVL_iXlinker CreatePlainerType(PlainGVL_iXlinker cloned)
		{
			cloned.Device_1_EtherCAT = Device_1_EtherCAT.CreatePlainerType();
			cloned.Device_2_EtherCAT = Device_2_EtherCAT.CreatePlainerType();
			cloned.Device_3_EtherCAT = Device_3_EtherCAT.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		private System.Collections.Generic.List<Vortex.Connector.IVortexObject> @Children
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexObject> @GetChildren()
		{
			return this.@Children;
		}

		public void AddChild(Vortex.Connector.IVortexObject vortexObject)
		{
			this.@Children.Add(vortexObject);
		}

		private System.Collections.Generic.List<Vortex.Connector.IVortexElement> Kids
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexElement> GetKids()
		{
			return this.Kids;
		}

		public void AddKid(Vortex.Connector.IVortexElement vortexElement)
		{
			this.Kids.Add(vortexElement);
		}

		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		protected Vortex.Connector.IVortexObject @Parent
		{
			get;
			set;
		}

		public Vortex.Connector.IVortexObject GetParent()
		{
			return this.@Parent;
		}

		private System.Collections.Generic.List<Vortex.Connector.IValueTag> @ValueTags
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IValueTag> GetValueTags()
		{
			return this.@ValueTags;
		}

		public void AddValueTag(Vortex.Connector.IValueTag valueTag)
		{
			this.@ValueTags.Add(valueTag);
		}

		protected Vortex.Connector.IConnector @Connector
		{
			get;
			set;
		}

		public Vortex.Connector.IConnector GetConnector()
		{
			return this.@Connector;
		}

		public void FlushPlainToOnline(Plc1.PlainGVL_iXlinker source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(Plc1.PlainGVL_iXlinker source)
		{
			source.CopyPlainToShadow(this);
		}

		public void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(Plc1.PlainGVL_iXlinker source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		protected System.String @SymbolTail
		{
			get;
			set;
		}

		public System.String GetSymbolTail()
		{
			return this.SymbolTail;
		}

		public System.String AttributeName
		{
			get
			{
				return Plc1TwinController.Translator.Translate(_AttributeName, this).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public GVL_iXlinker(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			this.Kids = new System.Collections.Generic.List<Vortex.Connector.IVortexElement>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Device_1_EtherCAT = new Device_1_EtherCAT_B557D6C6(this, "", "Device_1_EtherCAT");
			_Device_2_EtherCAT = new Device_2_EtherCAT_CA128DDC(this, "", "Device_2_EtherCAT");
			_Device_3_EtherCAT = new Device_3_EtherCAT_CA191EDE(this, "", "Device_3_EtherCAT");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public GVL_iXlinker()
		{
			PexPreConstructorParameterless();
			_Device_1_EtherCAT = new Device_1_EtherCAT_B557D6C6();
			_Device_2_EtherCAT = new Device_2_EtherCAT_CA128DDC();
			_Device_3_EtherCAT = new Device_3_EtherCAT_CA191EDE();
			AttributeName = "";
			PexConstructorParameterless();
		}
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainGVL_iXlinker
	{
		public void CopyPlainToCyclic(Plc1.GVL_iXlinker target)
		{
			Device_1_EtherCAT.CopyPlainToCyclic(target.Device_1_EtherCAT);
			Device_2_EtherCAT.CopyPlainToCyclic(target.Device_2_EtherCAT);
			Device_3_EtherCAT.CopyPlainToCyclic(target.Device_3_EtherCAT);
		}

		public void CopyPlainToCyclic(Plc1.IGVL_iXlinker target)
		{
			this.CopyPlainToCyclic((Plc1.GVL_iXlinker)target);
		}

		public void CopyPlainToShadow(Plc1.GVL_iXlinker target)
		{
			Device_1_EtherCAT.CopyPlainToShadow(target.Device_1_EtherCAT);
			Device_2_EtherCAT.CopyPlainToShadow(target.Device_2_EtherCAT);
			Device_3_EtherCAT.CopyPlainToShadow(target.Device_3_EtherCAT);
		}

		public void CopyPlainToShadow(Plc1.IShadowGVL_iXlinker target)
		{
			this.CopyPlainToShadow((Plc1.GVL_iXlinker)target);
		}

		public void CopyCyclicToPlain(Plc1.GVL_iXlinker source)
		{
			Device_1_EtherCAT.CopyCyclicToPlain(source.Device_1_EtherCAT);
			Device_2_EtherCAT.CopyCyclicToPlain(source.Device_2_EtherCAT);
			Device_3_EtherCAT.CopyCyclicToPlain(source.Device_3_EtherCAT);
		}

		public void CopyCyclicToPlain(Plc1.IGVL_iXlinker source)
		{
			this.CopyCyclicToPlain((Plc1.GVL_iXlinker)source);
		}

		public void CopyShadowToPlain(Plc1.GVL_iXlinker source)
		{
			Device_1_EtherCAT.CopyShadowToPlain(source.Device_1_EtherCAT);
			Device_2_EtherCAT.CopyShadowToPlain(source.Device_2_EtherCAT);
			Device_3_EtherCAT.CopyShadowToPlain(source.Device_3_EtherCAT);
		}

		public void CopyShadowToPlain(Plc1.IShadowGVL_iXlinker source)
		{
			this.CopyShadowToPlain((Plc1.GVL_iXlinker)source);
		}
	}
}