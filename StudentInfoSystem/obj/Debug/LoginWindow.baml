   M S B A M L   `   `   `  ����L  HStudentInfoSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentInfoSystemStudentInfoSystem  5   	   #    StudentInfoSystem.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StudentInfoSystem     5   	     � Title$  Login��5   	   $	��350��6   $	��350��6$   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   6+   �� 5      $��3* �6   6,    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $
��0.5* �6   6,   �� 5      $
��0.5* �6   6,   �� 5      $
��0.5* �6   6,   .+�5   
   �� $��0��6   $��Center=�6   $��Center=�68   $��36(�6U   $��2��6c   $��Arial Black)�6w   .��6�   Login6�   �� 5   
   $��1��6   $��Center=�6   $��Right=�68   .��6T   	Username:6_   �� 5   
   $��2��6   $��Center=�6   $��Right=�68   .��6T   	Password:6_   �� 5   
   -   5         ��Name$ userNameBox��5      $��1��6'   $��1��64   $��25��6D   $��5q�6P   6]   G� 5   
   -   5         G�Name$ passwordBox��5      $��2��6+   $��2��68   $��25��6H   $��5q�6T   6a   �� 5   
   -   5        $��3��5      $��2��6   $��25��62   $��75��6>   .��6^   Login6e   5      5      