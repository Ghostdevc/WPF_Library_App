   M S B A M L   `   `   `  ����M  ILibraryApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LibraryApplication.ViewsLibraryApplication.Views  5      M+clr-namespace:LibraryApplication.ViewModelsLibraryApplication.ViewModels  6C   (    "LibraryApplication.Views.BooksView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:LibraryApplication.Views     5      B
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
   �� $��Books Management��6   $��0��6,   $��0��6<   $��2��6I   $��20(�6]   $
��Bold"�6k   $��Center=�6}   6�   �� 5#   
   $��Book Id��6   $��1��5$      $��0��5%      �� 5'   
   $��	Book Name��6   $��2��5(      $��0��5)      �� 5+   
   $��Status��6   $��3��5,      $��0��5-      �� 5/   
   $��Writer��6   $��4��50      $��0��51      �� 53   
   $��Category��6   $��5��54      $��0��55      �� 57   
   -   5        $��	txtBookId��57      $��1��58      $��1��59      ��6$   ��  �� Path$ CurrentBook.Book_id� �� Mode$ TwoWay=�6\   �� 5;   
   -   5        $��txtBookName��5;      $��2��5<      $��1��5=      ��6$   �� $ CurrentBook.Book_name�$ TwoWay=�6^   �� 5?   
   -   5        $��	txtStatus��5?      $��3��5@      $��1��5A      ��6$   �� $ CurrentBook.Status_id�$ TwoWay=�6^   �� 5C   
   -   5        $��	txtWriter��5C      $��4��5D      $��1��5E      ��6$   �� $ CurrentBook.Writer_id�$ TwoWay=�6^   �� 5G   
   -   5        $��txtCategory��5G      $��5��5H      $��1��5I      ��6$   �� $ CurrentBook.Category_id�$ TwoWay=�6`   �� 5K   
    �� Orientation$ 
Horizontal=�6   $��7��6.   $��1��6;   .+�5M      �� -   5        $��btnAdd��5M      $	��ADD��6#   ��61   �� $ SaveBookCommand�6\   �� 5O      -   5        $��	btnSearch��5O      $��SEARCH��6&   ��67   �� $ SearchBookCommand�6d   �� 5Q      -   5        $��	btnUpdate��5Q      $��UPDATE��6&   ��67   �� $ UpdateBookCommand�6d   �� 5S      -	   5        $��	btnDelete��5S      $��DELETE��6&   ��67   �� $ DeleteBookCommand�6d   �� 5U      -
   5        $��btnLoadBooks��5U      $��
LIST BOOKS��6)   ��6>   �� $ LoadAllBooksCommand�6m   �� 5W      -   5        $��btnLoadAvailableBooks��5W      $��LIST AVAILABLE BOOKS��62   ��6Q   �� $ LoadAvailableBooksCommand�6�   �� 5Y      -   5        $!��btnNavigateContentInterface��5Y      $"��>>NAVIGATE CONTENT INTERFACE��68   $��15 0 0 0q�6�   ��6_   �� *!NavigateContentInterfaceCommand+6�   �� 5[      -   5        $��btnNavigateMain��5[      $��>>>NAVIGATE ADMIN PAGE��6,   $��0 0 0 0q�6u   ��6M   �� *NavigateMainCommand+6�   5]      �� 5_   
   -   5        $��txtBlockMessage��5_      $��8��6+   $��1��68   ��6H   �� $ Message�6h   �� 5b   
   -   5        $��lvBooks��5b      $��9��6"   $��1��6/    �� SelectionMode$ Single=�6u   ��6?   �� $ 	BooksList�$ TwoWay=� �� View 5d      �� 5f      .P�5h      �� $��Book ID��6%    �� DisplayMemberBinding 66   �� *	Book_id+6a   �� 5j      $��	Book Name��6%    68   �� *	Book_name+6e   �� 5l      $��	Status ID��6%    68   �� *	Status_id+6e   �� 5n      $��	Writer ID��6%    68   �� *	Writer_id+6e   �� 5p      $��Category ID��6%    6:   �� *Category_id+6i   5s      5w      5�      5�      