   M S B A M L   `   `   `  ����M  ILibraryApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LibraryApplication.ViewsLibraryApplication.Views  5      M+clr-namespace:LibraryApplication.ViewModelsLibraryApplication.ViewModels  6C   2    ,LibraryApplication.Views.CategoryControlView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:LibraryApplication.Views     5      B
viewmodels+clr-namespace:LibraryApplication.ViewModels     6C   .��5      � $��5q�6     � ColumnDefinitions  5   
   �� 5      $
��auto �6   6.   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5    
   �� $��Client Management��6   $��0��6-   $��0��6=   $��2��6J   $��20(�6^   $
��Bold"�6l   $��Center=�6~   6�   �� 5"   
   $��Category Id��6   $��1��5#      $��0��5$      �� 5&   
   $��Category Name��6   $��2��5'      $��0��5(      �� 5+   
   -   5        $��txtCategoryId��5+      $��1��5,      $��1��5-      ��6$   ��  �� Path$ CurrentRecord.Category_id� �� Mode$ TwoWay=�6b   �� 5/   
   -   5        $��txtCategoryName��5/      $��2��50      $��1��51      ��6$   �� $! CurrentRecord.Category_name�$ TwoWay=�6d   �� 54   
    �� Orientation$ 
Horizontal=�6   $��4��6.   $��1��6;   .+�56      �� -   5        $��btnAdd��56      $	��ADD��6#   $��0 0 1 0q�6^   ��61   �� $ SaveCategoryCommand�6r   �� 58      -   5        $��	btnSearch��58      $��SEARCH��6&   $��1 0 1 0q�6f   ��67   �� $ SearchCategoryCommand�6z   �� 5:      -   5        $��	btnUpdate��5:      $��UPDATE��6&   $��1 0 1 0q�6f   ��67   �� $ UpdateCategoryCommand�6z   �� 5<      -   5        $��	btnDelete��5<      $��DELETE��6&   $��1 0 1 0q�6f   ��67   �� $ DeleteCategoryCommand�6z   �� 5>      -   5        $!��btnNavigateContentInterface��5>      $"��>>NAVIGATE CONTENT INTERFACE��68   $��15 0 0 0q�6�   ��6_   �� *!NavigateContentInterfaceCommand+6�   �� 5@      -   5        $��btnNavigateMain��5@      $��>>>NAVIGATE ADMIN PAGE��6,   $��0 0 0 0q�6u   ��6M   �� *NavigateMainCommand+6�   5B      �� 5D   
   -	   5        $��txtBlockMessage��5D      $��5��6+   $��1��68   ��6H   �� $ Message�6h   �� 5G   
   -
   5        $��lvCategories��5G      $��6��6'   $��1��64    �� SelectionMode$ Single=�6�   $ �� IsSynchronizedWithCurrentItem$ FalseY�6�   ��6D   �� *RecordsList+ �� View 5I      �� 5K      .P�5M      �� $��Category ID��6%    �� DisplayMemberBinding 6:   �� *Category_id+6i   �� 5O      $��Category Name��6%    6<   �� *Category_name+6m   5Q      5U      5c      5d      