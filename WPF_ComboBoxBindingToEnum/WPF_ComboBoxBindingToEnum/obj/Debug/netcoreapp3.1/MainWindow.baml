   M S B A M L   `   `   `  ����T  PWPF_ComboBoxBindingToEnum, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:WPF_ComboBoxBindingToEnumWPF_ComboBoxBindingToEnum  5   	   Q-clr-namespace:WPF_ComboBoxBindingToEnum.ModelWPF_ComboBoxBindingToEnum.Model  5   	   *    $WPF_ComboBoxBindingToEnum.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:WPF_ComboBoxBindingToEnum     5   	   BlocalSub-clr-namespace:WPF_ComboBoxBindingToEnum.Model     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��450��6,   $	��800��69   $	��800��6H   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��10px �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $
��10px �6    � RowDefinitions 5   
   �� 5      $
��10px �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $
��10px �6   .+�5   
   �� $��Status:��6   $��1��6"   $��1��62   $��Center=�6?   $��Center=�6Z   �� 5   
   $��2��6   $��1��6#    �� 
IsEditable$
 True��60   $��Center=�6B   $��Center=�6_   $	��150��6z   ��5       ��  �� Source @   :WPF_ComboBoxBindingToEnum.Model.EnumBindingSourceExtension  *M� *localSub:Status++�� 5"   
   $��
Car-Brand:��6   $��1��6%   $��2��65   $��Center=�6B   $��Center=�6]   �� 5#   
   $��2��6   $��2��6#   $��Center=�60   $��Center=�6M   $	��150��6h   ��5$      ��    *M� *localSub:CarBrand++5'      5(      