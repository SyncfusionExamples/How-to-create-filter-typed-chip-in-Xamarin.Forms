
# Getting Started with Chip sample
Step 1: Add the NuGet to the project and add the namespace as shown in the following code sample:

**[XAML]**

```
xmlns:buttons="clr-namespace:Syncfusion.XForms.Buttons;assembly=Syncfusion.Buttons.XForms"
```
**[C#]**

```
using Syncfusion.XForms.Buttons;
```
Step 2: Then initialize an empty SfChipGroup as shown in the following code:

**[XAML]**

```
<ContentPage.Content>
  <Grid>
     <buttons:SfChipGroup/>
  </Grid>
</ContentPage.Content>
```
**[C#]**
```
public GettingStarted()
{
  InitializeComponent();
  Grid grid = new Grid();
  grid.Children.Add(new SfChipGroup());
  this.Content = grid;
}
```
# How to create filter typed chip in Xamarin.Forms 
Allows users to select more than one chip in a group of chips. The selected chips are indicated by selection indicator in this type. The selection indicator can be customized using the SelectionIndicatorColorproperty. Use the SelectedItems property to get the list of selected chips.

This selection changes are notified by using SelectionChanging and SelectionChanged events.

The following code illustrates how to get filter typed ChipGroup.

**[XAML]**
```
<buttons:SfChipGroup 
	Type="Filter"   
	ItemsSource="{Binding Languages}"
	SelectedChipBackgroundColor="Red"
	ChipPadding="8,8,0,0" 
	SelectionIndicatorColor="White"
	DisplayMemberPath="Name">
	<buttons:SfChipGroup.ChipLayout>
		<FlexLayout 
			HorizontalOptions="Start" 
			VerticalOptions="Center" 
			Direction="Row" 
			Wrap="Wrap"
			JustifyContent="Start"
			AlignContent="Start" 
			AlignItems="Start"/>
	</buttons:SfChipGroup.ChipLayout>
</buttons:SfChipGroup>
```

**[ViewModel]**

```

public class ViewModel : INotifyPropertyChanged
{
	private ObservableCollection<Language> languages;

	...

	public event PropertyChangedEventHandler PropertyChanged;

	public ObservableCollection<Language> Languages
	{
		get
		{
			return languages;
		}
		set
		{
			languages = value;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Languages"));
		}
	}
	
	...

	public ViewModel()
	{
		Languages = new ObservableCollection<Language>();
		Languages.Add(new Language() { Name = "C#" });
		Languages.Add(new Language() { Name = "HTML" });
		Languages.Add(new Language() { Name = "Java" });
		Languages.Add(new Language() { Name = "JS" });
      ...
	}
}

[Language Model]

public class Language
{
	public string Name { get; set; }
}
```
## How to run this application?

To run this application, you need to first clone the How-to-create-filter-typed-chip-in-Xamarin.Forms repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
