   M S B A M L   `   `   `  ����N  JadonetCourseProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:adonetCourseProjectadonetCourseProject  5      *    $adonetCourseProject.Warehousecontrol   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:adonetCourseProject     5        � 	Resources  5
   
    �� MergedDictionaries �� Source�� 5       5      �� 5      $ Dictionary.xaml?�6)   %    5      .��5   
   �  � RowDefinitions 5      �� 5      $��50 �6    �� 5      $
��200* �6    .+�5      �� $��Right=�6    �� Orientation$ 
Horizontal=�65   .+�5      �� -   5        $��tbSearch��5   #   $��0��6   $
��0 15q�63   $	��250��6A      tbSearch#��[  6M   6o   �� 5      -   5        $��	btnSearch��5      $��	5 0 170 0q�6'     
btnTextbox#��[ 6;   6_   �� 5      -   5        $��btnAdd��5       
 btnadd#���  6(   5      �� 5       -   5        $��	btnDelete��5         	btndelete#��[ 6*   5"      �� 5#      -   5        $��btnEdit��5#        btnedit#��[ 6(   5%      5&      �� 5(   
   -   5         ��Name$ lvWarehouse��5(       $��1��6   $��50,0,0,0q�65   $��Italic$�6G    �� View 5+      �� 5,      .P�5-      �� $��Продукт��6&    �� CellTemplate 5.      �� 5/      .R�50   "   �� .+�53   &   R� $��0q�6/   
������ .@�56   *   Q� $��
tviProduct��67   -   5        ��56   �   ��  �� ElementName$ tbName��	 �� Path$
	 Text�.@�58   .   �� .+�59   2   �� $ 
Horizontal=�6>   .+�5:   6   �� $��Название:��6@   �� 5;   6   $��tbName��6>   -   5          tbInner#��[ 5;   j   
 �� 
IsReadOnly
 . ��6L   �� *Product.Name+6�   5<   3   �� 5=   2   $ 
Horizontal=�6>   .+�5>   6   �� $��	Цена:��6@   �� 5?   6   -	   5        
 . #��[ 5?   o   ��6P   �� *Product.Price+6�   5@   3   �� 5A   2   $ 
Horizontal=�6>   .+�5B   6   �� $��Вес:��6@   �� 5C   6   -
   5        
 . #��[ 5C   p   ��6P   �� *Product.Weight+6�   5D   3   �� 5E   2   $ 
Horizontal=�6=   .+�5F   6   �� $��Описание:��6@   �� 5G   6   -   5        
 . #��[ 5G   u   ��6P   �� *Product.Description+6�   5H   3   5I   /   5J   +   5K   '   5L   #   5M      5O      �� 5R      $��Количество��6&    5S      �� 5T      .R�5U   "   �� -   5        #��[ 5U   E   ��6+   �� *
Quantity+6�   5V      5X      5Y      5[      5\      5]      