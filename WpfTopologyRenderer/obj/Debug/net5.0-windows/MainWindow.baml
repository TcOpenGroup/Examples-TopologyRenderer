   M S B A M L   `   `   `  ????R  NTcOpen.Inxton.TcoIo.Wpf, Version=0.9.0.0, Culture=neutral, PublicKeyToken=null>4clr-namespace:TcoIo;assembly=TcOpen.Inxton.TcoIo.WpfTcoIo  5   	   N JWpfTopologyRenderer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WpfTopologyRendererWpfTopologyRenderer 5   	   M+clr-namespace:WpfTopologyRenderer.UserViewsWpfTopologyRenderer.UserViews 5      O,clr-namespace:WpfTopologyRenderer.SimulationWpfTopologyRenderer.Simulation 5	   	   $   WpfTopologyRenderer.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dwpf4clr-namespace:TcoIo;assembly=TcOpen.Inxton.TcoIo.Wpf     5   	   3local!clr-namespace:WpfTopologyRenderer     5   	   <user+clr-namespace:WpfTopologyRenderer.UserViews     5      <sim,clr-namespace:WpfTopologyRenderer.Simulation     5	   	   T PTcOpen.Inxton.TcoCore.Wpf, Version=0.9.0.0, Culture=neutral, PublicKeyToken=nullL	 HTcOpen.Inxton.Wpf, Version=0.9.0.0, Culture=neutral, PublicKeyToken=null]
 YVortex.Presentation.Controls.Wpf, Version=1.15.10.0, Culture=neutral, PublicKeyToken=null` \Vortex.Presentation.Wpf, Version=1.15.10.0, Culture=neutral, PublicKeyToken=3bf43df27f52305d+vortexhttp://vortex.mts/xaml    	 
  5
   	     ? Title$  
MainWindow??5   	   $
??1200??6   $
??2048??6*    ? DataContext 5   
   -  'WpfTopologyRenderer.MainWindowViewModel  5      .??5      ?? .@?5   
   ?? $??Startup??6   5      ?? 5   
   $??Complete topology??6   .??5         TcoIo.TopologyRenderer   6#   ?? *Plc1.GVL_iXlinker+5      ?? 5   
   $??Userview-grouped??6   .??5      ? $
??True??6   $
??Auto=?68   $
??Auto=?6h    ? ColumnDefinitions 5      ?? 5      $
??Auto ?6'   ?? 5      $
??Auto ?6'   ?? 5      $
??Auto ?6'    ? RowDefinitions 5      ?? 5      $
??Auto ?6$   ?? 5       $
??Auto ?6$   ?? 5!      $
??Auto ?6$   ?? 5"      $
??Auto ?6$   .+?5$        $??0??6'   $??0??64      GroupedView$
 True??6?      	GroupName$ Device 1 (EtherCAT)??6?    6D   ?? *%#Plc1.GVL_iXlinker.Device_1_EtherCAT+6?     5%      $??1??6'   $??0??64   $
 True??6?   $ Device 2 (EtherCAT)??6?      UserView3  -WpfTopologyRenderer.UserViews.UserViewDevice2"  6?    6D   ?? *%#Plc1.GVL_iXlinker.Device_2_EtherCAT+6?     5&      $??2??6'   $??0??64   $
 True??6?   $ Device 3 (EtherCAT)??6?   3  -WpfTopologyRenderer.UserViews.UserViewDevice3"  6?    6D   ?? *%#Plc1.GVL_iXlinker.Device_3_EtherCAT+6?   5'      5(      ?? 5)   
   $??
Simulation??6   .??5*      ?  5+      ?? 5,      $
??Auto ?6'   ?? 5-      $
??Auto ?6'   ?? 5.      $
??Auto ?6'    50      ?? 51      $
??Auto ?6$   ?? 52      $
??Auto ?6$   ?? 53      $
??Auto ?6$   ?? 54      $
??Auto ?6$   ?? 55      $
??Auto ?6$   ?? 56      $
??Auto ?6$   ?? 57      $
??Auto ?6$   ?? 58      $
??Auto ?6$   ?? 59      $
??Auto ?6$   ?? 5:      $
??Auto ?6$   ?? 5;      $
??Auto ?6$   ?? 5<      $
??Auto ?6$   ?? 5=      $
??Auto ?6$   ?? 5>      $
??Auto ?6$   ?? 5?      $
??Auto ?6$   ?? 5@      $
??Auto ?6$   .+?5C      2  ,WpfTopologyRenderer.Simulation.SimulateState  $??0??6$   $??0??64      SimulatedState$ OP=?6A    6U   ?? *%#Plc1.GVL_iXlinker.Device_1_EtherCAT+  5D      $??0??6$   $??1??64   $
 INIT=?6A    6W   ?? *%#Plc1.GVL_iXlinker.Device_1_EtherCAT+  5E      $??0??6$   $??2??64   $ SlaveSignalsMissingLink=?6A    6j   ?? *%#Plc1.GVL_iXlinker.Device_1_EtherCAT+  5F      $??0??6$   $??3??64   $
 INIT=?6A    6W   ?? *A?Plc1.GVL_iXlinker.Device_1_EtherCAT.Term_1_EK1200.Term_5_EL4004+  5G      $??0??6$   $??4??64   $
 INIT=?6A    6W   ?? *@>Plc1.GVL_iXlinker.Device_1_EtherCAT.SyncUnits._default.PlcTask+  5H      $??0??6$   $??5??64   $ SlaveSignalsMissingLink=?6A    6j   ?? *A?Plc1.GVL_iXlinker.Device_1_EtherCAT.Term_1_EK1200.Term_3_EL1809+  5I      $??0??6$   $??6??64   $ SlaveSignalsMissingLink=?6A    6j   ?? *A?Plc1.GVL_iXlinker.Device_1_EtherCAT.Term_1_EK1200.Term_6_EL2809+  5K      $??1??6$   $??0??64   $ OP=?6A    6U   ?? *%#Plc1.GVL_iXlinker.Device_2_EtherCAT+  5L      $??1??6$   $??1??64   $
 INIT=?6A    6W   ?? *%#Plc1.GVL_iXlinker.Device_2_EtherCAT+  5M      $??1??6$   $??2??64   $ SlaveSignalsMissingLink=?6A    6j   ?? *%#Plc1.GVL_iXlinker.Device_2_EtherCAT+  5N      $??1??6$   $??3??64   $
 INIT=?6A    6W   ?? *B@Plc1.GVL_iXlinker.Device_2_EtherCAT.Term_9_EK1100.Term_36_EL3024+  5O      $??1??6$   $??4??64   $
 INIT=?6A    6W   ?? *@>Plc1.GVL_iXlinker.Device_2_EtherCAT.SyncUnits._default.PlcTask+  5P      $??1??6$   $??5??64   $ SlaveSignalsMissingLink=?6A    6j   ?? *QOPlc1.GVL_iXlinker.Device_2_EtherCAT.Term_9_EK1100.Term_10_EK1122.Term_11_EK1100+  5Q      $??1??6$   $??6??64   $ SlaveSignalsMissingLink=?6A    6j   ?? *`^Plc1.GVL_iXlinker.Device_2_EtherCAT.Term_9_EK1100.Term_10_EK1122.Term_18_EK1100.Term_22_EL3011+  5S      $??2??6$   $??0??64   $ OP=?6A    6U   ?? *%#Plc1.GVL_iXlinker.Device_3_EtherCAT+  5T      $??2??6$   $??1??64   $
 INIT=?6A    6W   ?? *%#Plc1.GVL_iXlinker.Device_3_EtherCAT+  5U      $??2??6$   $??2??64   $ SlaveSignalsMissingLink=?6A    6j   ?? *%#Plc1.GVL_iXlinker.Device_3_EtherCAT+  5V      $??2??6$   $??3??64   $
 INIT=?6A    6W   ?? *ECPlc1.GVL_iXlinker.Device_3_EtherCAT.Term_146_EK1100.Term_150_EL1809+  5W      $??2??6$   $??4??64   $
 INIT=?6A    6W   ?? *@>Plc1.GVL_iXlinker.Device_3_EtherCAT.SyncUnits._default.PlcTask+  5X      $??2??6$   $??5??64   $ SlaveSignalsMissingLink=?6A    6j   ?? *53Plc1.GVL_iXlinker.Device_3_EtherCAT.Term_146_EK1100+  5Y      $??2??6$   $??6??64   $ ERROR=?6A    6q   ?? *??Plc1.GVL_iXlinker.Device_3_EtherCAT.Term_146_EK1100.Term_147_EK1122.Term_178_EK1100.Term_179_EK1122.Term_182_EK1100.Term_183_EL1809+  5Z      $??2??6$   $??7??64   $ InvalidVendorId=?6A    6q   ?? *??Plc1.GVL_iXlinker.Device_3_EtherCAT.Term_146_EK1100.Term_147_EK1122.Term_178_EK1100.Term_179_EK1122.Term_182_EK1100.Term_183_EL1809+  5[      $??2??6$   $??8??64   $ InitializationError=?6A    6q   ?? *??Plc1.GVL_iXlinker.Device_3_EtherCAT.Term_146_EK1100.Term_147_EK1122.Term_178_EK1100.Term_179_EK1122.Term_182_EK1100.Term_183_EL1809+  5\      $??2??6$   $??9??64   $ SlaveDisabled=?6A    6q   ?? *??Plc1.GVL_iXlinker.Device_3_EtherCAT.Term_146_EK1100.Term_147_EK1122.Term_178_EK1100.Term_179_EK1122.Term_182_EK1100.Term_183_EL1809+  5]      $??2??6$   $??10??64   $ SlaveNotPresent=?6B    6q   ?? *??Plc1.GVL_iXlinker.Device_3_EtherCAT.Term_146_EK1100.Term_147_EK1122.Term_178_EK1100.Term_179_EK1122.Term_182_EK1100.Term_183_EL1809+  5^      $??2??6$   $??11??64   $ SlaveSignalsLinkError=?6B    6q   ?? *??Plc1.GVL_iXlinker.Device_3_EtherCAT.Term_146_EK1100.Term_147_EK1122.Term_178_EK1100.Term_179_EK1122.Term_182_EK1100.Term_183_EL1809+  5_      $??2??6$   $??12??64   $ SlaveSignalsMissingLink=?6B    6q   ?? *??Plc1.GVL_iXlinker.Device_3_EtherCAT.Term_146_EK1100.Term_147_EK1122.Term_178_EK1100.Term_179_EK1122.Term_182_EK1100.Term_183_EL1809+  5`      $??2??6$   $??13??64   $  SlaveSignalsUnexpectedLink=?6B    6q   ?? *??Plc1.GVL_iXlinker.Device_3_EtherCAT.Term_146_EK1100.Term_147_EK1122.Term_178_EK1100.Term_179_EK1122.Term_182_EK1100.Term_183_EL1809+5a      5b      ?? 5c   
   $??Device2??6   .??5d         6#   ?? *%#Plc1.GVL_iXlinker.Device_2_EtherCAT+5e      5f      5g      