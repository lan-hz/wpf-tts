   M S B A M L   `   `   `  ����E  ASpeechTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SpeechTest
SpeechTest  5   	       SpeechTest.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:SpeechTest     5   	   -   5          � Title$  文字转音频��5   	   $	��205��6   $	��400��6$   .��5	      �  � RowDefinitions 5   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      .+�5   
   �� $��0��6   $��1��6"   .+�5      �� $��输入路径��6   $��16(�6%   $
��Left=�63   $	��Top=�6O   �� 5      -   5         ��Name$ PathBox��5      $��14(�6%   $��这里是路径��63   $
��Left=�6C   $	��Top=�6^   $	��350��6v   �� 5      -   5         ��Name$ 
PathSelect��5      $��16(�6*   $��路径选择��68   $
��Left=�6G   $	��Top=�6b   6z   5      �� 5   
   $��1��6   $��1��6"   .+�5      �� $��单句转换:��6   $��16(�6%   $
��Left=�63   $	��Top=�6O   �� 5      -   5         ��Name$ 	InputText��5      $��14(�6*   $
��Left=�68    �� TextWrapping$
 Wrap=�6S   $��输入文字��6g   $	��Top=�6s   $	��350��6�   $��30��6�   6�   �� 5      -   5        $ OnceOrc��5      $��16(�6(   $��单句转换��66   $
��Left=�6E   $	��Top=�6a   6y   5       5%      5&      