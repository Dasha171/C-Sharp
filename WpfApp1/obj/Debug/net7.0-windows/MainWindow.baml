   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         redStyle �� Color  gradientStyle �� 
StartPoint �� EndPoint � Color � Offset ��Name  	buttonRes��%M  &	        &	 (     &	 �    �� 5
   
   $ BlanchedAlmond��6+   �� 5   
   $ 0.5,1&�65   $ 0.5,0&�6H   .��5      � $ 	LightBlue��6   $ 0Q�6-   � 5      $ White��6   $ 1Q�6)   5      �� 5   
   $ 	TextBlock��6   -   5        $��Ok��5   G   $��40��6T   $��80��6c   
�������6�   5      .��5      � #��[  6   .+�5   
   �� -   5        $��40��5      $	��120��6    $��Ресурсы в WPF��6/     buttonBrush#���  6G   6r   �� 5   
   $��90q�6   .+�5      ��  �� ResourceKey$ 	buttonRes��6   �� 5      $ 	buttonRes��6   �� 5      $ 	buttonRes��6   �� 5      $ 	buttonRes��6   5      �� 5   
   .+�5      �� -   5        	 ��Name$	 	myTextBox��5      $��30��6)   �� 5      -   5        
 ��Name$
 myTextBlock��5      $��30��6^   ��6-   ��  �� ElementName$ 	myTextBox�� �� Path$
 Text�6^   5      5       5!      