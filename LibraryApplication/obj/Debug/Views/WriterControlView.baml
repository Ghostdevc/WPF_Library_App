   M S B A M L   `   `   `  ����M  ILibraryApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LibraryApplication.ViewsLibraryApplication.Views  5      M+clr-namespace:LibraryApplication.ViewModelsLibraryApplication.ViewModels  6C   0    *LibraryApplication.Views.WriterControlView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:LibraryApplication.Views     5      B
viewmodels+clr-namespace:LibraryApplication.ViewModels     6C   .��5	      � $��5q�6     � ColumnDefinitions  5   
   �� 5      $
��auto �6   6.   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   �� $��Writer Management��6   $��0��6-   $��0��6=   $��2��6J   $��20(�6^   $
��Bold"�6l   $��Center=�6~   6�   �� 5    
   $��	Writer Id��6   $��1��5!      $��0��5"      �� 5$   
   $��Writer Name Surname��6   $��2��5%      $��0��5&      �� 5)   
   -   5        $��txtWriterId��5)      $��1��5*      $��1��5+      ��6$   ��  �� Path$ CurrentRecord.Writer_id� �� Mode$ TwoWay=�6`   �� 5-   
   -   5        $��txtWriterNameSurname��5-      $��2��5.      $��1��5/      ��6$   �� $' !CurrentRecord.Writer_name_surname�$ TwoWay=�6j   �� 52   
    �� Orientation$ 
Horizontal=�6   $��4��6.   $��1��6;   .+�54      �� -   5        $��btnAdd��54      $	��ADD��6#   ��61   �� $ SaveWriterCommand�6^   �� 56      -   5        $��	btnSearch��56      $��SEARCH��6&   ��67   �� $ SearchWriterCommand�6f   �� 58      -   5        $��	btnUpdate��58      $��UPDATE��6&   ��67   �� $ UpdateWriterCommand�6f   �� 5:      -   5        $��	btnDelete��5:      $��DELETE��6&   ��67   �� $ DeleteWriterCommand�6f   �� 5<      -   5        $!��btnNavigateContentInterface��5<      $"��>>NAVIGATE CONTENT INTERFACE��68   $��15 0 0 0q�6�   ��6_   �� *!NavigateContentInterfaceCommand+6�   �� 5>      -   5        $��btnNavigateMain��5>      $��>>>NAVIGATE ADMIN PAGE��6,   $��0 0 0 0q�6u   ��6M   �� *NavigateMainCommand+6�   5@      �� 5B   
   -	   5        $��txtBlockMessage��5B      $��5��6+   $��1��68   ��6H   �� $ Message�6h   �� 5E   
   -
   5        $��	lvWriters��5E      $��6��6$   $��1��61    �� SelectionMode$ Single=�6y   ��6A   �� $ WritersList�$ TwoWay=� �� View 5G      �� 5I      .P�5K      �� $��	Writer ID��6%    �� DisplayMemberBinding 68   �� *	Writer_id+6e   �� 5M      $��Writer Name Surname��6%    6B   �� *Writer_name_surname+6y   5O      5S      5b      5c      