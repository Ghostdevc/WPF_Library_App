   M S B A M L   `   `   `  ����M  ILibraryApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LibraryApplication.ViewsLibraryApplication.Views  5      M+clr-namespace:LibraryApplication.ViewModelsLibraryApplication.ViewModels  6C   5    /LibraryApplication.Views.ManageReservationsView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:LibraryApplication.Views     5      B
viewmodels+clr-namespace:LibraryApplication.ViewModels     6C   .��5
      � $��5q�6     � ColumnDefinitions  5   
   �� 5      $��3* �6   6,   �� 5      $��2* �6   6,   �� 5      $��* �6   6+   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��dgReservations��5         AutoGenerateColumns .  $��1��6E   $��5q�6U      
IsReadOnly . ��6`   �� *Reservations+ �� Mode$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Reservation ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6=   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   ��  �� Path$ Reservation_id�6t     5      $ Book ID��6%   $
 auto 66    6C   �� $ Reserved_book_id�6o     5       $ User ID��6%   $
 auto 66    6C   �� $ Reserved_to_user_id�6r     5"      $ Booking Date��6%   $
 auto 6;    6H   �� $ Booking_date�6p     5$      $ Expected to Return Date��6%   $
 auto 6F    6S   �� $ Expected_to_return_date�6�     5&      $ Return date��6%   $
 auto 6:    6G   �� $ Return_date�6n     5(      $ Status��6%   $
 auto 65    6B   �� $ Reservation_status_id�6s   5-      �� 5/   
   $��2��6   $��Center=�6%   $��Center=�6B   .+�52      �� 	 �� Orientation$	 
Horizontal=�6   $��5q�62   $��Right=�6=   .+�54      �� $��Reservation ID : ��6   $��15(�65   $
��Bold"�6C   6W   �� 55      -   5        $��txtReservationId��55      $��90��62   ��6=   �� *CurrentRecord.Reservation_id+6m   57      �� 59      $	 
Horizontal=�6   $��5q�62   $��Right=�6=   .+�5;      �� $��
Book ID : ��6   $��15(�6.   $
��Bold"�6<   6P   �� 5<      -   5        $��	txtBookId��5<      $��90��6+   ��66   �� * CurrentRecord.Reserved_book_id+6h   5>      �� 5@      $	 
Horizontal=�6   $��5q�62   $��Right=�6=   .+�5B      �� $��
User ID : ��6   $��15(�6.   $
��Bold"�6<   6P   �� 5C      -   5        $��	txtUserId��5C      $��90��6+   ��66   �� *#!CurrentRecord.Reserved_to_user_id+6k   5E      �� 5G      $	 
Horizontal=�6   $��5q�62   $��Right=�6=   .+�5I      �� $��Booking Date : ��6   $��15(�63   $
��Bold"�6A   6U   �� 5J      -   5        $��txtBookingDate��5J      $��90��60   ��6;   �� *CurrentRecord.Booking_date+6i   5L      �� 5N      $	 
Horizontal=�6   $��5q�62   $��Right=�6=   .+�5P      �� $��Expected to return : ��6   $��15(�69   $
��Bold"�6G   6[   �� 5Q      -   5        $��txtExpectedReturnDate��5Q      $��90��67   ��6B   �� *'%CurrentRecord.Expected_to_return_date+6{   5S      �� 5U      $	 
Horizontal=�6   $��5q�62   $��Right=�6=   .+�5W      �� $��Return date : ��6   $��15(�62   $
��Bold"�6@   6T   �� 5X      -   5        $��txtReturnDate��5X      $��90��6/   ��6:   �� *CurrentRecord.Return_date+6g   5Z      �� 5\      $	 
Horizontal=�6   $��5q�62   $��Right=�6=   .+�5^      �� $��Reservation Status : ��6   $��15(�69   $
��Bold"�6G   6[   �� 5_      -   5        $��	cmbStatus��5_      $��90��6,   
 �� DisplayMemberPath$
 Reservation_status��6c    �� SelectedValuePath$ Reservation_status_id��5`      ��5_   7   �� *ReservationStatuses+ �� SelectedValue 5a      �� $) #CurrentRecord.Reservation_status_id�6X   5c      �� 5e      -	   5        $��btnUpdateReservation��5e      $��UPDATE RESERVATION��61   $��Center=�6N   $��Center=�6k   $��1��6�   $��0��6�   $
��Bold"�6�   $��15(�6�   $��10q�6�   ��6�   �� $ UpdateReservationCommand�6  �� 5g      -
   5        $��btnDeleteReservation��5g      $��DELETE RESERVATION��61   $��Center=�6N   $��Center=�6k   $��1��6�   $��0��6�   $
��Bold"�6�   $��15(�6�   $��10q�6�   ��6�   �� $ DeleteReservationCommand�6  �� 5i      -   5        $��btnMarkReceived��5i      $��MARK RETURNED��6,   $��Center=�6D   $��Center=�6a   $��1��6|   $��0��6�   $
��Bold"�6�   $��15(�6�   $��10q�6�   ��6�   �� $ MarkBookReturnedCommand�6�   �� 5k      $	 
Horizontal=�6   $��5q�62   $��Center=�6=   $��Center=�6Z   .+�5m      �� -   5        $��btnSearchReservation��5m      $��SEARCH RESERVATION��65   $��Center=�6R   $��Center=�6o   $��1��6�   $��0��6�   $
��Bold"�6�   $��15(�6�   $��10q�6�   ��6�   �� $ SearchReservationCommand�6  �� 5n      -   5        $��	txtSearch��5n      $��90��6+   ��66   �� *SearchInput+$ TwoWay=�6b   5p      	� 5t      -   5        $��rdbSearchByUserID��5t      $��Search by User ID��63    	� 	GroupName$ 	SearchRDB��6O   $
��Left=�6e   $��Center=�6�    d� 	IsChecked 6�   �� *IsUserIdChecked+$ TwoWay=�6�   	� 5v      -   5        $��rdbSearchByReservationID��5v      $��Search by Reservation ID��6:   $ 	SearchRDB��6]   $
��Left=�6s   $��Center=�6�    6�   �� *IsReservationIdChecked+$ TwoWay=�6�   	� 5x      -   5        $��rdbSearchByBookID��5x      $��Search by Book ID��63   $ 	SearchRDB��6O   $
��Left=�6e   $��Center=�6�    6�   �� *IsBookIdChecked+$ TwoWay=�6�   �� 5|      -   5        $��btnListActiveReservations��5|      $��LIST ACTIVE RESERVATIONS��66   $��Center=�6Y   $��Center=�6v   $��1��6�   $��0��6�   $
��Bold"�6�   $��15(�6�   $��10q�6�   ��6�   �� $ LoadActiveReservations�6  �� 5~      -   5        $��btnListAllReservations��5~      $��LIST ALL RESERVATIONS��63   $��Center=�6S   $��Center=�6p   $��1��6�   $��0��6�   $
��Bold"�6�   $��15(�6�   $��10q�6�   ��6�   �� $ LoadAllReservations�6  �� 5�      $��15(�6K   $
��Bold"�6Y   $��Center=�6k   $��Center=�6�   
���  ����6   �� $" ReservationManagementMessage�6�   �� 5�      -   5        $��btnNavigateMain��5�      $��>>>NAVIGATE ADMIN PAGE��6,   $��0 0 0 0q�6u   ��6M   �� *NavigateMainCommand+6�   5�      � 5�   
     5�      �� 5�      $��2* �6#   60   �� 5�      $��* �6#   6/   .+�5�      � $��0��6    � RowDefinitions 5�      �� 5�      6&   �� 5�      6&   .+�5�        -   5        $��dgUsers��5�       .  $��0��6F   $��0��6S   $��5q�6c    . ��6n   �� *UsersViewModel.UsersList+ 5�        5�      $ User ID��6-   $
 auto 6>    6K   �� $ User_id�6n     5�      $ 	User Name��6-   $
 auto 6@    6M   �� $ 	User_name�6r     5�      $ User Surname��6-   $
 auto 6C    6P   �� $ User_surname�6x   5�        5�      -   5        $��dgBooks��5�       .  $��1��6F   $��0��6S   $��5q�6c    . ��6n   �� *BooksViewModel.BooksList+ 5�        5�      $ Book ID��6-   $
 auto 6>    6K   �� $ Book_id�6n     5�      $ 	Book Name��6-   $
 auto 6@    6M   �� $ 	Book_name�6r     5�      $ Writer��6-   $
 auto 6=    6J   �� $ 	Writer_id�6o   5�      5�      �� 5�      $��1��6   $��5q�6)   $��Center=�64   $��Center=�6O   .+�5�      �� $	 
Horizontal=�6   $��5q�66   $��Right=�6A   .+�5�      �� $��
User ID : ��6    $��15(�62   $
��Bold"�6@   6T   �� 5�      -   5        $��
txtUser_id��5�      $��50��60   ��6;   �� *$"UsersViewModel.CurrentUser.User_id+6q   5�      �� 5�      $	 
Horizontal=�6   $��5q�66   $��Right=�6A   .+�5�      �� $��User Name Surname : ��6    $��15(�6<   $
��Bold"�6J   6^   �� 5�      -   5        $��txtUserNameSurname��5�      $��90��68   ��6C   �� *&$UsersViewModel.CurrentUser.User_name+6{   5�      �� 5�      $	 
Horizontal=�6   $��5q�66   $��Right=�6A   .+�5�      �� $��
Book ID : ��6    $��15(�62   $
��Bold"�6@   6T   �� 5�      -   5        $��
txtBook_id��5�      $��50��60   ��6;   �� *$"BooksViewModel.CurrentBook.Book_id+6q   5�      �� 5�      $	 
Horizontal=�6   $��5q�66   $��Right=�6A   .+�5�      �� $��Book Name : ��6    $��15(�64   $
��Bold"�6B   6V   �� 5�      -   5        $��txtBookName��5�      $��90��61   ��6<   �� *&$BooksViewModel.CurrentBook.Book_name+6t   5�      �� 5�      $��5q�6   .+�5�      �� -   5        $��btnCreate_Reservation��5�      $��CREATE RESERVATION��6:   $��Center=�6W   $��Center=�6t   $��1��6�   $��0��6�   $
��Bold"�6�   $��15(�6�   $��10q�6�   ��6�   �� $ SaveReservationCommand�6
  �� 5�      $��15(�6>   $
��Bold"�6L   $��Center=�6^   $��Center=�6{   ��6    �� $ Message�6�   �� 5�      -   5        $��btnListAvailableBooks��5�      $��
LIST BOOKS��6:   $��Center=�6O   $��Center=�6l   $��1��6�   $��0��6�   $
��Bold"�6�   $��15(�6�   $��10q�6�   ��6�   �� $. (BooksViewModel.LoadAvailableBooksCommand�6  �� 5�      $��15(�6M   $
��Bold"�6[   $��Center=�6m   $��Center=�6�   ��6    �� $ BooksViewModel.Message�6�   5�      5�      5�      5�      5�      