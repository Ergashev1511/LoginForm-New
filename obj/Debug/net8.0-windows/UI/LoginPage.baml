   M S B A M L   `   `   `  ����D  @LoginForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:LoginForm.UILoginForm.UI  5          LoginForm.UI.LoginPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:LoginForm.UI     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5        � 	Resources  5       �� Source�� 5   
   $ \Controls.xaml?�6   %    .��5      � .+�5   
   �� $��Images/login1.jpg��6   $
��Fill=�6+   �� 5   
   -   5         ��Name$ 
SignUp_btn��5      $	��Top=�6@   $��Right=�6X   $��Sign up��6t   $��15(�6�   $��60��6�   $��0q�6�   $��5q�6�   
������ 6�   � 5   
   $	��500��6   $	��300��6   .+�5      �� .+�5      �� $��Login��6   
�������$��30(�6<   $��Center=�6J   6i   �� 5      .+�5      �� $��
0 20 170 0q�6   $��Username��63   
�������$��Center=�6V   6v   �� 5      $	��230��6   $��40��6(   
�������$��1q�6I    �� CornerRadius$ 5��6]   ._�5      �� -   5         ��Name$ username_txt��5   !   $��Center=�67   $	��230��6R   $��40��6^   $��0q�6j   $��15(�6   $��5 7 0 0 q�6�   6�   5      5      �� 5      $��
0 20 170 0q�6   $��Password��60   
�������$��Center=�6S   6r   ]� 5      $��Right=�6   $��0 0 95 0q�66   .+�5      �� $	��230��6   $��40��6'   
�������$��1q�6H   $ 5��6\   ._�5      �� .+�5      G� -   5         G�Name$ password_txt��5   (   $��Center=�6?   $��15(�6Z   $��5 7 0 0 q�6h   $	��230��6{   $��40��6�   $��0q�6�   $y�Visible=�6�   5       �� 5!      -   5        $ password_textbox��5!   $   $��Center=�6?   $��15(�6Z   $��5 7 0 0 q�6h   $	��230��6{   $��40��6�   $��0q�6�   $y�	Collapsed=�6�   .��6�   5"      5#      5$      �� 5%      -   5         ��Name$ show_btn��5%      
������ $��5 5 0 0q�6�   $��30��6�   $��30��6�   5&      5'      ]� 5)      $��0 5 0 0q�6   .+�5*      �� $��
135 0 0  0q�6   65   �� 5+      $��	10 0 0 0 q�6   $#��Do you remember the password?��62   
�������6l   5,      �� 5-      -   5        $ 	login_btn��5-         RoundButton#���   6F   
��� � �$��Login��6   
�������$��20(�6�   $	��150��6�   $��40��6�   $��20q�6�   6�   5.      5/      50      52      