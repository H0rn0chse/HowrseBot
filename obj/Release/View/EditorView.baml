   M S B A M L   `   `   `  ���� D  @HowrseBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:HowrseBot.ViewModelHowrseBot.ViewModel  /clr-namespace:HowrseBot.ViewHowrseBot.View      HowrseBot.View.EditorView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     U QGongSolutions.WPF.DragDrop, Version=1.1.0.0, Culture=neutral, PublicKeyToken=nullddurn:gong-wpf-dragdrop  1	viewModel!clr-namespace:HowrseBot.ViewModel  (localclr-namespace:HowrseBot.View  .���   � 	Resources   �� 
TargetType   DefaultListBoxStyle �� BasedOn �� Property  ListBoxControlTemplate1 �� Value��%4   '��       7   �� " ��8   .���  � ��# �  .+��� -    ��Name$ CommandSource��$��Right=�$	��300��$��0,0,100,100q�$��Bottom=�$	��150��)  #GongSolutions.Wpf.DragDrop.DragDrop   IsDragSource .    IsDropTarget .  "   CanDragWithMouseRightButton . 	   DropTargetAdornerBrush
	 �P��
   UseDefaultDragAdorner
 . #   UseDefaultEffectDataTemplate . $	��Top=�   DropHandler �� ���� *Data.CommandPool+�� -   $ CommandPanel��$��100,0,0,100q�$	��300�� .  .  . 
	 �P��
 .  . $	��150��$
��Left=�$��Bottom=�$��Center=� �� ���� *
Data.Prog1+�� -    ��Name$ 
CommandBin��$��Center=�$��0q�$��Center=�$-��'/HowrseBot;component/Resources/bin2.png��$
��56.7�� .   .  . $��UniformToFill=�$��56�� �� �� $
��Left=�$��208.35,60,0,0q�$	��Top=�$	��120���� $��Programliste:��$
��Left=�$��123.543,60,0,0q�$	��Top=��� $��	Speichern��$��Right=�$��	0,0,50,50q�$��Bottom=�$��75���� $��Laden��$
��Left=�$��
387,60,0,0q�$	��Top=�$��75���� $
��Left=�$��19.96��$��333.35,60,0,0q�$	��Top=�$��19.96��$��
pencil.png��