   M S B A M L   `   `   `  ����C  ?PRC 3 V9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PRC_3_V9PRC_3_V9  5   	       PRC_3_V9.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:PRC_3_V9     5   	     � Title$  Practice 3 option 9��5   	   $	��315��6%   $	��405��62   .��5	      � .+�5
   
   o� $
��Left=�6   $��20��6*   $	��Top=�66   $	��392��6N   .@�5      m� $��Меню��6   $��20��6%   $��45��61   $��11(�6<   .@�5      m� -   5        $%��Заполнить массив��5      65   m� 5      -   5        $#��Очистить массив��5      64   m� 5      -   5        $%��Сохранить массив��5      65   m� 5      -   5        $!��Открыть массив��5      63   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $	��100��6@   $��	10,20,0,0q�6M   $	��Top=�6`   $	��372��6x   �� 5   
   $����Номер последней из ее строк, содержащих максимальное 
количество одинаковых элементов.��6   $
��Left=�6z   $��
10,125,0,0q�6�   $	��Top=�6�   $��40��6�   $	��372��6�   �� 5   
   -   5         ��Name$ lineNumberOutput��5      $
��Left=�6,   $��23��6G   $��
10,170,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��372��6�   �� 5   
   -   5         ��Name$ 	Calculate��5      $��Вычислить��6$   $
��Left=�68   $��
10,198,0,0q�6S   $	��Top=�6g   $	��372��6   6�   �� 5   
   -   5        $ Information��5      $��О программе��6&   $
��Left=�6<   $��
10,223,0,0q�6W   $	��Top=�6k   $	��372��6�   6�   �� 5   
   -	   5        $
 Exit��5      $��
Выход��6   $
��Left=�6/   $��
10,248,0,0q�6J   $	��Top=�6^   $	��372��6v   6�   5      5      