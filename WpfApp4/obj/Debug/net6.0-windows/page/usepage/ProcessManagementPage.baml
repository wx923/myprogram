   M S B A M L   `   `   `  ����B  >WpfApp4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WpfApp4.page.usepageWpfApp4.page.usepage  5      0    *WpfApp4.page.usepage.ProcessManagementPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:WpfApp4.page.usepage     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  Page6��5
       � 	Resources 5      &   System.Windows.Controls.DataGrid �� 
TargetType �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  '        '  �    �� 5   
   "  6   .�5      ��   �@ AlternatingRowBackground
 �����69   �� 5       �@ RowBackground
 �����6.   �� 5       �@ GridLinesVisibility$	 All=�64   �� 5        �@ HorizontalGridLinesBrush
 �����69   �� 5       �@ VerticalGridLinesBrush
 �����67   �� 5       � ��
 �����6,   �� 5       � ��$ 1q�60   �� 5       � ��$ 14(�6)   5      �� 5   
   "  6   .�5      ��  � ��
 ��ح�6+   �� 5       � ��
 �   �6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��
 �����6,   �� 5       � ��$ 0,0,1,1q�60   5      5      .��5      � .+�5    
   �  � RowDefinitions 5!      �� 5"      $��50 �6    6.   �� 5#      6"   .+�5%      #  MaterialDesignThemes.Wpf.Card  $��0��6"   .��5&      ��  �� Orientation$ 
Horizontal=�6   .+�5'      ��    MaterialDesignFlatButton#��[  6   
����·�$��选择工艺��6i   $	��100��6x   $��10q�6�   6�   �� 5(      #��[  6   
����·�$��新建工艺��6i   $	��100��6x   $��10q�6�   6�   �� 5)      #��[  6   
����·�$��	插入行��6i   $	��100��6w   $��10q�6�   6�   �� 5*      #��[  6   
����·�$��	删除行��6i   $	��100��6w   $��10q�6�   6�   �� 5+      #��[  6   
����·�$��清空��6i   $	��100��6v   $��10q�6�   6�   �� 5,      $��当前工艺名称��6    $��Center=�6.   $��10q�6I   6W   �� 5-      $��Hello, TextBox!��6   $	��100��65   $��30��6A   $��10q�6M   6[   �� 5.      #��[  6   
����·�$��导出excel文件��6i   $	��130��6}   $��10q�6�   6�   �� 5/      #��[  6   
����·�$��保存工艺��6i   $	��100��6x   $��10q�6�   6�   50      51        52      -   5          Name$ 
myDataGrid��52         AutoGenerateColumns$ False��6+   $��1��6G   	   Columns	 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn
   Header$
 时间��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Time+  55      $
 温度��6)    65   �� *Temperature+  56      $
 湿度��6)    65   �� *
Humidity+59      5:      5;      5<      