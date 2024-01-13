
# CustomTemplate

Custom template is an application made in wpf, which has 2 themes dark and light mode.

Give me 5 minutes and you won't regret it, you will understand how the application works and you can make your own template.

## 🍿 Video

https://github.com/MarianM00/CustomThemes/assets/20222415/01297c39-8ce9-4835-91bf-764d42762060

## Project structure

- Command folder -> The MVVM-specific command part for the event

- The ViewModels folder -> Specific MVVM architectures, there is not much to explain here so I will quickly go over it.

- The Themes folder:

- ThemeEnums: As the name says, the 'theme' enums when you create a new theme must be added here
- Extensions : Method extensions
- ThemeStyle: The place where you can find the colors specific to each theme, here to mention that when you create your own theme you can add whatever colors you want, as long as they must respect the same x:Key
- ThemeControllers: Here you have a controller that deals with "changing the theme", more precisely with changing the xaml file from the ResourceDictionary
- DynamicControls: ControlColours: Here the most important part appears if in the ThemeStyle part we have defined the colors with an x:Key here we have defined SolidColorBrush also with an x:Key and at the value of the x:key from the ThemeStyle part, I hope that made quite clear.
- Controls: Here we have the style and let's say the functionality of some components such as a button, there is not much to explain here, change the default colors with the x:key from ControlColours, nothing very complicated. You will understand by looking at the code
## Authors

- [@MarianM00](https://github.com/MarianM00?tab=repositories)

