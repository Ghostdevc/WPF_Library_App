   M S B A M L   `   `   `  ����M  ILibraryApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LibraryApplication.ViewsLibraryApplication.Views  5      M+clr-namespace:LibraryApplication.ViewModelsLibraryApplication.ViewModels  6C   0    *LibraryApplication.Views.ClientControlView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:LibraryApplication.Views     5      B
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
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5!   
   �� $��Client Management��6   $��0��6-   $��0��6=   $��2��6J   $��20(�6^   $
��Bold"�6l   $��Center=�6~   6�   �� 5#   
   $��User Id��6   $��1��5$      $��0��5%      �� 5'   
   $
��Name��6   $��2��5(      $��0��5)      �� 5+   
   $��Surname��6   $��3��5,      $��0��5-      �� 5/   
   $��Username��6   $��4��50      $��0��51      �� 53   
   $��Password��6   $��5��54      $��0��55      �� 57   
   $��User Type ID��6   $��6��58      $��0��59      �� 5;   
   -   5        $��txtId��5;      $��1��5<      $��1��5=      ��6$   ��  �� Path$ CurrentUser.User_id� �� Mode$ TwoWay=�6\   �� 5?   
   -   5        $��txtName��5?      $��2��5@      $��1��5A      ��6$   �� $ CurrentUser.User_name�$ TwoWay=�6^   �� 5C   
   -   5        $��
txtSurname��5C      $��3��5D      $��1��5E      ��6$   �� $ CurrentUser.User_surname�$ TwoWay=�6a   �� 5G   
   -   5        $��txtUsername��5G      $��4��5H      $��1��5I      ��6$   �� $ CurrentUser.User_nick�$ TwoWay=�6^   �� 5K   
   -   5        $��txtPassword��5K      $��5��5L      $��1��5M      ��6$   �� $ CurrentUser.User_password�$ TwoWay=�6b   �� 5O   
   -   5        $��txtUserTypeID��5O      $��6��5P      $��1��5Q      ��6$   �� $ CurrentUser.User_type_id�$ TwoWay=�6a   �� 5S   
    �� Orientation$ 
Horizontal=�6   $��7��6.   $��1��6;   .+�5U      �� -   5        $��btnAdd��5U      $	��ADD��6#   ��61   �� $ SaveUserCommand�6\   �� 5W      -   5        $��	btnSearch��5W      $��SEARCH��6&   ��67   �� $ SearchUserCommand�6d   �� 5Y      -	   5        $��	btnUpdate��5Y      $��UPDATE��6&   ��67   �� $ UpdateUserCommand�6d   �� 5[      -
   5        $��	btnDelete��5[      $��DELETE��6&   ��67   �� $ DeleteUserCommand�6d   �� 5]      -   5        $��btnNavigateMain��5]      $��>>>NAVIGATE ADMIN PAGE��6,   $��15 0 0 0q�6u   ��6M   �� *NavigateMainCommand+6�   5_      �� 5a   
   -   5        $��txtBlockMessage��5a      $��8��6+   $��1��68   ��6H   �� $ Message�6h   �� 5e   
   -   5        $��lvUsers��5e      $��9��6"   $��1��6/    �� SelectionMode$ Single=�6u   ��6?   �� $ 	UsersList�$ TwoWay=� �� View 5g      �� 5i      .P�5k      �� $��User ID��6%    �� DisplayMemberBinding 66   �� $ User_id�6f   �� 5m      $��User Type ID��6%    6;   �� $ User_type_id�6p   �� 5o      $
��Name��6%    63   �� $ 	User_name�6e   �� 5q      $��Surname��6%    66   �� $ User_surname�6k   �� 5s      $��Username��6%    67   �� $ 	User_nick�6i   �� 5u      $��Password��6%    67   �� $ User_password�6m   5w      5{      5�      5�      