   M S B A M L   `   `   `  ����D  @Expenselt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Expenselt	Expenselt  5   	       Expenselt.ExpenseltHome   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Expenselt     5   	     � Title$  Expenselt - Home��5   	   $	��450��6"   $	��800��6/   .��5	      � $��
10,0,10,10q�6    � ColumnDefinitions 5
   
   �� 5      �� 5      $	��250 �6   ��5   
   �� 5       �� ImageSource$ watermark.png��6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��0��6   $��3��6    $��Bottom=�6�   $
��Left=�6�   $��Arial Black)�6�   $��16(�6�   ��6-   ��  �� RelativeSource ��  �� AncestorType" � �� Path$ LastChecked�6�   �� 5   
   $��1��6   $��0��6    $��20(�6�   ���	#FF0452CE$
��Left=�6�   $��Stretch=�6�   $��Arial Black)�6�   ��6-   ��  �� " �$ MainCaptionText�6  �� 5   
   $��35��6    �� Padding$ 5q�6   ���#4E87D4$��1��6>   $��1��6N   ._�5      �� $��1��6   $��1��6$   $��Center=�61   
�������.��6_   Names6f   5      �� 5   
   $��0��6   $��2��6"   ��6/   �� $ PersonsChecked�6]   �� 5   
   -   5         ��Name$ peopleListBox��5   /   $��1��6   $��2��6"   ��6F   ��  �� " �$ ExpenseDataSource���5      �� 5       .R�5!      �� ��6   �� $
 Name�5"      5$      �� 5&   
   -   5        $��1��5&      $��3��6!   $��0,10,0,0q�6.   $	��125��6@   $��25��6L   $��Right=�6X   ��6�   �� 	 �� ElementName$	 peopleListBox��$ SelectedItem.Name�5'      5(      