   M S B A M L   `   `   `  ���� J  FPhoto_SorterWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Photo_SorterWPFPhoto_SorterWPF       Photo_SorterWPF.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     /localclr-namespace:Photo_SorterWPF     -     � Title$  Photo Sorter��$	��600��$
��1000�� � 	Resources  �� 
TargetType   
BgrndColor �� Property �� Value  ForegroundColor  HeaderTemplate �� TextAlignment��%�   '��       &	       &	 8     &	 t     �� " ��.�-   �� .���  � �� �	#FFF3F5FF�� .���  � �� �	#FF616161��  � ��$ 14(��� .R��� $��Myriad Pro Light)�$��14(�$ Center=�$
��auto������ .���  � RowDefinitions �� $
��0.1* ��� $
��auto ��� $��* ��� $
��auto � � ColumnDefinitions �� $��0.40* ��� $
��auto ��� $��* �.+���  �� ShowsPreview .  $��2��
�������$��Center=�$��Stretch=�$��3��$��1���� -   $��sortBtn��$
��Left=�$��Center=�$��1��$��0��$
��Sort��$��22��$��90��$��
10,10,0,10q�{��� 	 �� ElementName$	 
pathString��
 �� Path$
 Text.Length��� -   $��
extractBtn��$
��Left=�$��Center=�$��0��$��Extract��$��1��$��22��$��90��$��105,10,0,10q�{��� $	 
pathString��$
 Text.Length��� -   $��clearBtn��{�.  $��Bottom=�$��Right=�$��	Clear Log��$��3��$��2��$��22��$��	0,0,10,10q�$��90���� -   $��
pathString��#��[  
�������$	��Top=�$��Stretch=� �� TextWrapping$ NoWrap=�$��2��$��0��$��22��$��10,0,0,0q��� -   $��mainListView��#��[  
�������$��2��$��2��$��0,0,10,5q� �� View �� .P���  �� HeaderTemplate# [ $
��Name�� �� DisplayMemberBinding �� *Name+�� # [ $
��Path�� �� *Path+�� # [ $��Creation time�� �� *CreationTime+�� # [ $��Modification time�� �� *ModificationTime+�� # [ $��Size Mb�� �� *Size+�� # [ $��	Extansion�� �� *	Extansion+�� -   $��txtBlockMoved��#��[ $
 Left=�$��NoWrap=�$��Bottom=�$
��Left=�$��2��$��3��$��0,0,0,10q��� $�Item(s) moved:�� �� ��� $	 mainListView��$
 Items.Count� �� Mode$ OneWay=��� #��[ $��3��$��NoWrap=�$��Stretch=�$��Bottom=�$��	10,0,0,10q��� $�File(s) in folder:�� �� -	    �Name$ txtBlockTotal��.�--o� #��[ $��0��$��0��
�������$	��Top=�$��Stretch=�$��24��.@�m� $
��Menu��.@��� m� $
��Exit��m� $
��Help��R� -
    R�Name$ foldersItem��#��[  
�������$��2��$��0��$��	10,25,0,5q�  �� Orientation �� RelativeSource �� Mode �� AncestorType,   &Photo_SorterWPF.HeaderToImageConverter   Instance �� 	Converter��%�   'Q�       �� " Q�.���  � �� �� .R��� $ 
Horizontal=�.+��� $	��img��$��20��$��20��$
��Fill=�����  �� $ FindAncestor=�" Q�$
 Header�# Z �� $	��5,0q����� 