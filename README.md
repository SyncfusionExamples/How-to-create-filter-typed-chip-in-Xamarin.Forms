# How-to-create-filter-typed-chip-in-Xamarin.Forms
Allows users to select more than one chip in a group of chips. The selected chips are indicated by selection indicator in this type. The selection indicator can be customized using the [`SelectionIndicatorColor`](https://help.syncfusion.com/xamarin/chips/customization#selectionindicatorcolor-1)property. Use the [`SelectedItems`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfChipGroup.html#Syncfusion_XForms_Buttons_SfChipGroup_SelectedItems) property to get the list of selected chips.

This selection changes are notified by using [SelectionChanging](https://help.syncfusion.com/xamarin/chips/events#selectionchanging-event) and [SelectionChanged](https://help.syncfusion.com/xamarin/chips/events#selectionchanged-event) events.

## Syncfusion Controls

This project uses the following Syncfusion controls:

* [SfChip](https://www.syncfusion.com/xamarin-ui-controls/xamarin-chips) - To show the SfChip and SfChipGroup.

## Screenshots
![Filter typed Xamarin.Forms SfChipGroup](https://github.com/SyncfusionExamples/How-to-create-filter-typed-chip-in-Xamarin.Forms/blob/main/filter.gif)

## Supported platforms

| Platforms | Supported versions |
| --------- | ------------------ |
| Android   | API level 19 and later versions |
| iOS | iOS 9.0 and later versions |

Refer to the following link for more details: 
[System Requirements](https://help.syncfusion.com/xamarin/installation-and-upgrade/system-requirements)

## Requirements to run the sample

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available in Visual Studio installer)

## How to run the sample

1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.cs file as demonstrated in the following code.

        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

Refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key#xamarinforms) for more details.

3. Set any one of the platform specific projects (iOS, Android or UWP) as a start-up project.
4. Clean and build the application.
5. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
