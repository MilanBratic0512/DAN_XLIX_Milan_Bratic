   M S B A M L   `   `   `  ����D  @Zadatak_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Zadatak_1	Zadatak_1  5   	       Zadatak_1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Zadatak_1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��775* �6   �� 5      $	��17* �6   .+�5   
   �� $
��Left=�6   $��23��5       �� TextWrapping$
 Wrap=�5      $	��Top=�5      $	��120��5      $��
220,45,0,0q�5       �� 	MaxLength$ 13��5      ��5      �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5      �� 5   
   $��Username��6   $
��Left=�5      $��	57,45,0,0q�5      $	��Top=�5      $��68��5      �� 5   
   $��Password��6   $
��Left=�5      $��
57,104,0,0q�5      $	��Top=�5      $��68��5      �� 5    
   $
��Left=�6   $��23��5!      $
 Wrap=�5"      $	��Top=�5$      $	��120��5%      $��220,104,0,0q�5&      $0��*pack://application:,,,/Resources/#password)�5'      ��5#      �� *
Password+$ PropertyChanged=�5'      �� 5)   
   $��Log in��6   $
��Left=�5*      $	��Top=�5+      $��75��5,      $��
57,330,0,0q�5-      ��5.      �� *Login+$ PropertyChanged=��� 5/   
   $��Cancel��6   $
��Left=�50      $	��Top=�51      $��75��52      $��265,330,0,0q�53      ��54      �� *Close+$ PropertyChanged=�55      56      