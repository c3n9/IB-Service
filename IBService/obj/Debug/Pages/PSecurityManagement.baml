   M S B A M L   `   `   `  ����D  @IBService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:IBService.PagesIBService.Pages  5      )    #IBService.Pages.PSecurityManagement   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:IBService.Pages     5      -   5          N� Title$  PSecurityManagement��5	      .��5      �  � RowDefinitions 5      �� 5      �� 5      $��75 �6   .+�5      �� -   5         ��Name$ 
TBFullName��5      $��Right=�5      $	��Top=�5      $��	0,10,10,0q�5      �� 5      -   5         ��Name$ TCManagment��5      $	��Top=�5       � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName��%  '��       �� 5      " ��6   .�5      ��  � �� 5      �� 5   	   " ��6   .R�5   
   �� $��Border��6   $��3q�6   ._�5      �� $	 ContentSite��6   $��Center=�5      $��Center=�5      $��Header��5       $
��10,2q�5!      5"      
 5#   
   P� 5$       �@��
IsSelected . . �5%      �� $ Border��6    � ��
 ��·�5'   1   5(      P� 5)       �@��
IsSelected .  . �5+      �� $ Border��6    � ��
 �����5-   1   5.      50   
   52      53      54      .@�55      �� -   5         ��Name$ TBVerification��55      ��56      �� 57      $��Верификация��6   ��59      &   System.Windows.Controls.DataGrid  5:      -   5          Name$ DGUsersVerification��5;   
      AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5<   
      CanUserAddRows .     Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5?   	   ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 5@      �� *	Surname+5A        5B   	   $ Имя��6    .  5C      �� *Name+5D        5E   	   $ Отчество��6    .  5F      �� *
Patronymic+5G        5H   	   $ Должность��6    .  5I      �� *Post+5J      4  .System.Windows.Controls.DataGridComboBoxColumn  5K   	   $% Тип пользователя��6    -   5        
CBType��   DisplayMemberPath$
 Name��5M         SelectedItemBinding 5N      �� *Type+  5O   	   $ 
Логин��6    .   5P      �� *Login+5Q        5R   	   $ Пароль��6    5S      �� *
Password+  5T   	   $# Секретное слово��6    5U      �� *
SecretWord+4  .System.Windows.Controls.DataGridCheckBoxColumn  5V   	   $ Одобрить��6     5W      �� *
Approved+5Y      5[      �� 5\      -   5        $ 	TBMandats��5\      ��5]      �� 5^      $#��Мандаты доступа��6   ��5`        5a      -   5        $ DGUsersMandats��5b   
    .  $ * 5c   
    .   5e        5f   	   $ Фамилия��6    .    Width$ 70 5i       5g      �� *	Surname+5i        5j   	   $ Имя��6    . $ 70 5m       5k      �� *Name+5m        5n   	   $ Отчество��6    . $ 70 5q       5o      �� *
Patronymic+5q        5r   	   $ Должность��6   $ 70 5s       .  5t      �� *Post+5u        5v   	   $' !Добавление данных��5w       5v       �� *	AddData+5w        5x   	   $# Просмотр данных��5y       5x       �� *
ViewData+5y        5z   	   $- 'Формирование отчетов��5{       5z       �� *	Reports+5{      5}      5      5�      �� 5�      -	   5         ��Name$ BSave��5�      $��Одобрить��5�      $��20��5�      $	��100��5�      $��Center=�5�      $��1��5�      $��Center=�5�      5�      5�      