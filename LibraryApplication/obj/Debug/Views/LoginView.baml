   M S B A M L   `   `   `  ����M  ILibraryApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LibraryApplication.ViewsLibraryApplication.Views  5      M+clr-namespace:LibraryApplication.ViewModelsLibraryApplication.ViewModels  6C   M+clr-namespace:LibraryApplication.ComponentsLibraryApplication.Components  6�   (    "LibraryApplication.Views.LoginView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:LibraryApplication.Views     5      B
viewmodels+clr-namespace:LibraryApplication.ViewModels     6C   B
components+clr-namespace:LibraryApplication.Components     6�   .��5
      �   � ColumnDefinitions  5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� $��1��6   $��Center=�6%   $��Center=�6@   .+�5      �� $��LIBRARY MANAGEMENT SYSTEM��6   $��Center=�69   $
��Bold"�6V   $��10q�6h   6v   �� 5       �� Orientation$ 
Horizontal=�6   $��Center=�62   $��30q�6O   .+�5      �� $��Username : ��6   $��Center=�6/   $
��Bold"�6L   6`   �� 5      -   5        $��txtUserName��5      $	��100��6G   ��6-   �� *
Username+6U   5      �� 5      $ 
Horizontal=�6   $��Center=�62   $��10q�6O   .+�5!      �� $��Password : ��6   $��Center=�6/   $
��Bold"�6L   6`   7   1LibraryApplication.Components.BindablePasswordBox  5"      $	��100��6�      Password 61   �� *
Password+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   5$      �� 5&      $��Center=�61   $
��Bold"�6N   ��6   �� *	Message+6b   �� 5(      -   5        $��btnLogin��5(      $��Login��6%   $��Center=�65   $	��100��6R   $��10q�6^   ��6j   �� *LoginCommand+6�   5+      5-      50      