   M S B A M L   `   `   `  ���� D  @HowrseBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:HowrseBot.ViewModelHowrseBot.ViewModel  /clr-namespace:HowrseBot.ViewHowrseBot.View  !    HowrseBot.View.SettingsView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     7	viewModel!clr-namespace:HowrseBot.ViewModel     .localclr-namespace:HowrseBot.View     $	��600��$	��500��.��� .+��� -     ��Name$	  ufo��$��Ufos fangen��$
��Left=�$��100,100,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.5,0.5&� d� 	IsChecked �� *
User.Ufo+�� -    ��Name$ tarif��$
��Left=�$��270,154,0,0q�$	��Top=�$	��120������ *
Data.Tarif+ �� SelectedIndex �� *
User.Tarif+�� -   $ duration��$
��Left=�$��270,200,0,0q�$	��Top=�$	��120������ *Data.Duration+ �� *User.Duration+�� -   $
 sort��$
��Left=�$��270,250,0,0q�$	��Top=�$	��120������ *	Data.Sort+ �� *	User.Sort+�� $��Max. Einstallkosten��$
��Left=�$��100,150,0,0q�$	��Top=��� $��Einstalldauer��$
��Left=�$��100,200,0,0q�$	��Top=��� $��Pferdesortierung��$
��Left=�$��100,250,0,0q�$	��Top=��� $��	Speichern��$��Right=�$��	0,0,50,50q�$��Bottom=�$��75��$��Center=�