   M S B A M L   `   `   `  ����M  ILibraryApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LibraryApplication.ViewsLibraryApplication.Views  5      M+clr-namespace:LibraryApplication.ViewModelsLibraryApplication.ViewModels  6C   0    *LibraryApplication.Views.ManagePenaltyView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:LibraryApplication.Views     5      B
viewmodels+clr-namespace:LibraryApplication.ViewModels     6C   .��5	      � ���#2E3349  � ColumnDefinitions  5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   � $��5q�6   $��1��6     5      �� 5      $
��auto �6#   62   �� 5      $��* �6#   6/    � RowDefinitions 5       �� 5"      $
��auto �6    60   �� 5#      $
��auto �6    60   �� 5$      $
��auto �6    60   �� 5%      $
��auto �6    60   �� 5&      $
��auto �6    60   �� 5'      $
��auto �6    60   �� 5(      $
��auto �6    60   �� 5)      $
��auto �6    60   �� 5*      $
��auto �6    60   �� 5+      $
��auto �6    60   .+�5/      �� $��Penalties Management��6   $��0��64   $��0��6D   $��2��6Q   $��20(�6e   $
��Bold"�6s   $��Center=�6�   6�   �� 51      $��0��6   $��0��6)   $��2��66   $��Right=�6J    �� Orientation$ 
Horizontal=�6f   .+�53      �� -   5        $!��btnNavigatePenaltyInterface��53      $"��>>NAVIGATE PENALTY INTERFACE��6<   $��15 0 0 0q�6�   ��6c   �� *!NavigatePenaltyInterfaceCommand+6�   �� 55      -   5        $��btnNavigateMain��55      $��>>>NAVIGATE ADMIN PAGE��60   $��0 0 0 0q�6y   ��6Q   �� *NavigateMainCommand+6�   57      �� 5;      $��Penalty ID : ��6   $��1��5<      $��0��5=      �� 5?      $��Punished User ID : ��6   $��2��5@      $��0��5A      �� 5C      $��Penalty Policy ID : ��6   $��3��5D      $��0��5E      �� 5G      $��Penalty Expires On : ��6   $��4��5H      $��0��5I      �� 5K      $ ��Punished Reservation ID : ��6   $��5��5L      $��0��5M      �� 5O      -   5        $��txtPenaltyId��5O      $��1��5P      $��1��5Q      ��6$   ��  �� Path$ CurrentRecord.Penalty_id�6S   �� 5S      -   5        $��txtPunishedUserID��5S      $��2��5T      $��1��5U      ��6$   �� $% CurrentRecord.Penalized_user_id�6Z   �� 5W      -   5        $��txtPenaltyPolicyID��5W      $��3��5X      $��1��5Y      ��6$   �� $% CurrentRecord.Penalty_policy_id�6Z   �� 5[      -   5        $��txtPenaltyExpiresOn��5[      $��4��5\      $��1��5]      ��6$   �� $&  CurrentRecord.Penalty_expires_on�6[   �� 5_      -   5        $��txtPunishedReservation_id��5_      $��5��5`      $��1��5a      ��6$   �� $+ %CurrentRecord.Punished_reservation_id�6`   �� 5d      $ 
Horizontal=�6   $��7��62   $��1��6?   .+�5h      �� -   5        $��
btn_Search��5h      $��SEARCH��6+   ��6<   �� $ SearchPenaltyCommand�6l   �� 5j      -	   5        $��
btn_Update��5j      $��UPDATE��6+   ��6<   �� $ UpdatePenaltyCommand�6l   �� 5l      -
   5        $��
btn_Delete��5l      $��DELETE��6+   ��6<   �� $ DeletePenaltyCommand�6l   5n      �� 5p      -   5        $��txtBlock_Message��5p      $��8��60   $��1��6=   ��6M   �� $ Message�6m   �� 5t      -   5        $��lvPenalties��5t      $��9��6*   $��1��67    �� SelectionMode$ Single=�6}   ��6G   �� $ 	Penalties� �� Mode$ TwoWay=� �� View 5v      �� 5x      .P�5z      �� $��
Penalty ID��6)    �� DisplayMemberBinding 6=   �� $ 
Penalty_id�6p   �� 5|      $��Punished User ID��6)    6C   �� $ Penalized_user_id�6}   �� 5~      $��Penalty Policy ID��6)    6D   �� $ Penalty_policy_id�6~   �� 5�      $��Penalty Expires On��6)    6E   �� $ Penalty_expires_on�6�   �� 5�      $��Punished Reservation ID��6)    6J   �� $ Punished_reservation_id�6�   5�      5�      5�      � 5�   
   $��5q�6   $��0��6     5�      �� 5�      $
��auto �6#   62   �� 5�      $��* �6#   6/    5�      �� 5�      $
��auto �6    60   �� 5�      $
��auto �6    60   �� 5�      $
��auto �6    60   �� 5�      $
��auto �6    60   �� 5�      $
��auto �6    60   �� 5�      $
��auto �6    60   �� 5�      $
��auto �6    60   �� 5�      $
��auto �6    60   �� 5�      $
��auto �6    60   �� 5�      $
��auto �6    60   �� 5�      $
��auto �6    60   .+�5�      �� $��Set Penalty��6   $��0��6+   $��0��6;   $��2��6H   $��20(�6\   $
��Bold"�6j   $��Center=�6|   6�   �� 5�      $��Reservation ID : ��6   $��1��5�      $��0��5�      �� 5�      $��
Book ID : ��6   $��2��5�      $��0��5�      �� 5�      $��
User ID : ��6   $��3��5�      $��0��5�      �� 5�      $��Booking Date : ��6   $��4��5�      $��0��5�      �� 5�      $ ��Expected to Return Date : ��6   $��5��5�      $��0��5�      �� 5�      $��Return Date : ��6   $��6��5�      $��0��5�      �� 5�      $��Reservation Status : ��6   $��7��5�      $��0��5�      �� 5�      -   5        $��txtReservationID��5�      $��1��5�      $��1��5�      ��6$   �� $3 -CurrentReservationToBePunished.Reservation_id�6h   �� 5�      -   5        $��	txtBookID��5�      $��2��5�      $��1��5�      ��6$   �� $5 /CurrentReservationToBePunished.Reserved_book_id�6j   �� 5�      -   5        $��	txtUserID��5�      $��3��5�      $��1��5�      ��6$   �� $8 2CurrentReservationToBePunished.Reserved_to_user_id�6m   �� 5�      -   5        $��txtBookingDate��5�      $��4��5�      $��1��5�      ��6$   �� $1 +CurrentReservationToBePunished.Booking_date�6f   �� 5�      -   5        $��txtExpectedToReturnDate��5�      $��5��5�      $��1��5�      ��6$   �� $< 6CurrentReservationToBePunished.Expected_to_return_date�6q   �� 5�      -   5        $��txtReturnDate��5�      $��6��5�      $��1��5�      ��6$   �� $0 *CurrentReservationToBePunished.Return_date�6e   �� 5�      -   5        $��txtReservationStatus��5�      $��7��5�      $��1��5�      ��6$   �� $: 4CurrentReservationToBePunished.Reservation_status_id�6o   �� 5�      $ 
Horizontal=�6   $��8��62   $��1��6?   .+�5�      �� -   5        $#��btnListPunishableReservations��5�      $'��!LIST RESERVATIONS TO BE PENALIZED��6>   $��0 2 2 2q�6�   ��6k   �� $' !ListPunishableReservationsCommand�6�   �� 5      $ 
Horizontal=�6   $��Right=�66   $��2q�6R   .+�5     �� $��Days Count : ��6    $��15(�65   $
��Bold"�6C   6W   �� 5     -   5        $��cmbPenaltyDays��5     $
��auto��65    �� DisplayMemberPath$ Penalty_days��6�   	 �� SelectedValuePath$	 Penal_policy_id��5     ��5  B   �� **(PenaltyPoliciesViewModel.PenaltyPolicies+
 �� SelectedValue
 5  9   �� $ SelectedPolicy�$ TwoWay=�6v   5     �� 5     -   5        $��btnAdd��5     $��PUNISH RESERVATION��6'   $��2q�6p   ��6D   �� $ SavePenaltyCommand�6}   5     �� 5     -   5        $��txtBlockMessage��5     $��9��6/   $��1��6<   ��6L   �� $ Message�6l   �� 5     -   5        $��lvReservations��5     $��10��6-   $��1��6;   $ Single=�6�   ��6K   �� $ Reservations�$ TwoWay=� 5     �� 5     .P�5     �� $��Reservation ID��6)    6A   �� $ Reservation_id�6x   �� 5     $��Book ID��6)    6:   �� $ Reserved_book_id�6s   �� 5     $��User ID��6)    6:   �� $ Reserved_to_user_id�6v   �� 5     $��Booking Date��6)    6?   �� $ Booking_date�6t   �� 5      $��Expected to Return Date��6)    6J   �� $ Expected_to_return_date�6�   �� 5"     $��Return Date��6)    6>   �� $ Return_date�6r   �� 5$     $��Status��6)    69   �� $ Reservation_status_id�6w   5&     5*     5F     5I     5J     